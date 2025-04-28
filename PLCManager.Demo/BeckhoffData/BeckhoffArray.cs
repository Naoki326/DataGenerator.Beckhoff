using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using PlcCore.Data;
using TwinCAT.Ads;
using TwinCAT.Ads.Reactive;

namespace PlcCore.Beckhoff
{

    public class BeckhoffArray<T> : BaseArray<T> where T : struct
    {
        public BeckhoffArray(GetDataDel getDataDel,
            AdsClient client,
            uint indexGroup, uint indexOffset,
            uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero) : base(getDataDel)
        {
            this.client = client;
            this.indexGroup = indexGroup;
            this.indexOffset = indexOffset;
            this.indexGroups = indexGroups;
            this.indexOffsets = indexOffsets;
            this.isStartFromZero = isStartFromZero;
        }

        private bool isStartFromZero = true;


        private Subject<T[]> notifySubject = new();
        public override IDisposable Subscribe(IObserver<T[]> observer)
        {
            return notifySubject.ObserveOn(ThreadPoolScheduler.Instance).Subscribe(observer);
        }

        public override bool SelfNotify
        {
            get => base.SelfNotify;
            set
            {
                base.SelfNotify = value;
                SetBeckhoffNotify(value);
            }
        }

        private IDisposable beckhoffNotify;
        private void SetBeckhoffNotify(bool isBeckhoffNotifyOn)
        {
            beckhoffNotify?.Dispose();
            if (isBeckhoffNotifyOn)
            {
                beckhoffNotify = client.WhenNotification<T[]>(this.GetFullName(), NotificationSettings.Default).Subscribe((v) =>
                {
                    getData().CopyFrom(ref v);
                    notifySubject.OnNext(v);
                });
            }
        }

        protected T[] oldData;
        public override void CheckAndNotify(int timeout = -1, CancellationToken token = default)
        {
            bool areInitiallyEqual = true;
            for (int i = 0; i < Count; i++)
            {
                if (!getData()[i].Equals(oldData[i]))
                {
                    // 如果发现不相同，将array2的值设置为array1的值
                    getData()[i] = oldData[i];
                    areInitiallyEqual = false;
                }
            }
            if (!SelfNotify && !areInitiallyEqual)
            {
                notifySubject.OnNext(oldData);
            }
        }
        protected void CheckAndNotify(int index, int timeout = -1, CancellationToken token = default)
        {
            if (!getData()[index].Equals(oldData[index]))
            {
                // 如果发现不相同，将array2的值设置为array1的值
                getData()[index] = oldData[index];
                if(!SelfNotify)
                {
                    notifySubject.OnNext(oldData);
                }
            }
        }

        internal override void Init()
        {
            oldData = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                if (!getData()[i].Equals(oldData[i]))
                {
                    // 如果发现不相同，将array2的值设置为array1的值
                    getData()[i] = oldData[i];
                }
            }
        }


        protected readonly AdsClient client;

        protected readonly uint indexGroup;
        protected readonly uint indexOffset;

        protected readonly uint[] indexGroups;
        protected readonly uint[] indexOffsets;

        private bool disposedValue;

        public override T[] Get(int timeout = -1, CancellationToken token = default)
        {
            T[] readData = client.ReadAny<T[]>(indexGroup, indexOffset, [this.Count]);
            getData().CopyFrom(ref readData);
            return readData;
        }

        public override void Set(T[] value, int timeout = -1, CancellationToken token = default)
        {
            client.WriteAny(indexGroup, indexOffset, value, [this.Count]);
        }

        public override T GetItem(int index, int timeout = -1, CancellationToken token = default)
        {
            T item = client.ReadAny<T>(indexGroups[index], indexOffsets[index]);
            getData()[index] = item;
            return item;
        }

        public override void SetItem(int index, T value, int timeout = -1, CancellationToken token = default)
        {
            client.WriteAny(indexGroups[index], indexOffsets[index], value);
        }

        public override async Task<T[]> GetAsync(int timeout = -1, CancellationToken token = default)
        {
            var getTask = client.ReadAnyAsync<T[]>(indexGroup, indexOffset, [this.Count], token);
            await Task.WhenAny(Task.Delay(timeout), getTask);
            if (getTask.Status == TaskStatus.RanToCompletion)
            {
                T[] readData = getTask.Result.Value;
                getData().CopyFrom(ref readData);
                return readData;
            }
            throw getTask.Exception;
        }

        public override async Task SetAsync(T[] value, int timeout = -1, CancellationToken token = default)
        {
            var setTask = client.WriteAnyAsync(indexGroup, indexOffset, value, [this.Count], token);
            await Task.WhenAny(Task.Delay(timeout), setTask);
            if (setTask.Status == TaskStatus.RanToCompletion)
            {
                return;
            }
            throw setTask.Exception;
        }

        public override async Task<T> GetItemAsync(int index, int timeout = -1, CancellationToken token = default)
        {
            var getTask = client.ReadAnyAsync<T>(indexGroups[index], indexOffsets[index], token);
            await Task.WhenAny(Task.Delay(timeout), getTask);
            if (getTask.Status == TaskStatus.RanToCompletion)
            {
                T item = getTask.Result.Value;
                getData()[index] = item;
                return item;
            }
            throw getTask.Exception;
        }

        public override async Task SetItemAsync(int index, T value, int timeout = -1, CancellationToken token = default)
        {
            var setTask = client.WriteAnyAsync(indexGroups[index], indexOffsets[index], value, token);
            await Task.WhenAny(Task.Delay(timeout), setTask);
            if (setTask.Status == TaskStatus.RanToCompletion)
            {
                return;
            }
            throw setTask.Exception;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)
                    beckhoffNotify?.Dispose();
                    notifySubject?.Dispose();
                }

                // TODO: 释放未托管的资源(未托管的对象)并重写终结器
                // TODO: 将大型字段设置为 null
                disposedValue = true;
            }
        }

        //// TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器
        //~BeckhoffArray()
        //{
        //    // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
        //    Dispose(disposing: false);
        //}

        public override void Dispose()
        {
            // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

    public class BeckhoffArray<TS, T> : BaseArray<TS, T> where T : struct where TS : IPLCStructArray<T>
    {
        public BeckhoffArray(GetDataDel getDataDel,
            AdsClient client,
            uint indexGroup, uint indexOffset,
            uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero) : base(getDataDel)
        {
            this.client = client;
            this.indexGroup = indexGroup;
            this.indexOffset = indexOffset;
            this.indexGroups = indexGroups;
            this.indexOffsets = indexOffsets;
            this.isStartFromZero = isStartFromZero;
        }

        private bool isStartFromZero = true;


        private Subject<T[]> notifySubject = new();
        public override IDisposable Subscribe(IObserver<T[]> observer)
        {
            return notifySubject.ObserveOn(ThreadPoolScheduler.Instance).Subscribe(observer);
        }

        public override bool SelfNotify
        {
            get => base.SelfNotify;
            set
            {
                base.SelfNotify = value;
                SetBeckhoffNotify(value);
            }
        }

        private IDisposable beckhoffNotify;
        private void SetBeckhoffNotify(bool isBeckhoffNotifyOn)
        {
            beckhoffNotify?.Dispose();
            if (isBeckhoffNotifyOn)
            {
                beckhoffNotify = client.WhenNotification<T[]>(this.GetFullName(), NotificationSettings.Default).Subscribe((v) =>
                {
                    getData().CopyFrom(ref v);
                    notifySubject.OnNext(v);
                });
            }
        }

        protected T[] oldData;
        public override void CheckAndNotify(int timeout = -1, CancellationToken token = default)
        {
            bool areInitiallyEqual = true;
            for (int i = 0; i < Count; i++)
            {
                if (!getData()[i].Equals(oldData[i]))
                {
                    // 如果发现不相同，将array2的值设置为array1的值
                    getData()[i] = oldData[i];
                    areInitiallyEqual = false;
                }
            }
            if (!SelfNotify && !areInitiallyEqual)
            {
                notifySubject.OnNext(oldData);
            }
        }
        protected void CheckAndNotify(int index, int timeout = -1, CancellationToken token = default)
        {
            if (!getData()[index].Equals(oldData[index]))
            {
                // 如果发现不相同，将array2的值设置为array1的值
                getData()[index] = oldData[index];
                if (!SelfNotify)
                {
                    notifySubject.OnNext(oldData);
                }
            }
        }

        internal override void Init()
        {
            oldData = new T[Count];
            for (int i = 0; i < Count; i++)
            {
                if (!getData()[i].Equals(oldData[i]))
                {
                    // 如果发现不相同，将array2的值设置为array1的值
                    getData()[i] = oldData[i];
                }
            }
        }


        protected readonly AdsClient client;

        protected readonly uint indexGroup;
        protected readonly uint indexOffset;

        protected readonly uint[] indexGroups;
        protected readonly uint[] indexOffsets;

        private bool disposedValue;

        public override T[] Get(int timeout = -1, CancellationToken token = default)
        {
            T[] readData = client.ReadAny<T[]>(indexGroup, indexOffset, [this.Count]);
            getData().CopyFrom(ref readData);
            return readData;
        }

        public override void Set(T[] value, int timeout = -1, CancellationToken token = default)
        {
            client.WriteAny(indexGroup, indexOffset, value, [this.Count]);
        }

        public override T GetItem(int index, int timeout = -1, CancellationToken token = default)
        {
            T item = client.ReadAny<T>(indexGroups[index], indexOffsets[index]);
            getData()[index] = item;
            return item;
        }

        public override void SetItem(int index, T value, int timeout = -1, CancellationToken token = default)
        {
            client.WriteAny(indexGroups[index], indexOffsets[index], value);
        }


        public override async Task<T[]> GetAsync(int timeout = -1, CancellationToken token = default)
        {
            var getTask = client.ReadAnyAsync<T[]>(indexGroup, indexOffset, [this.Count], token);
            await Task.WhenAny(Task.Delay(timeout), getTask);
            if (getTask.Status == TaskStatus.RanToCompletion)
            {
                T[] readData = getTask.Result.Value;
                for (int i = 0; i < Count; i++)
                {
                    getData()[i] = readData[i];
                }
                CheckAndNotify();
                return readData;
            }
            throw getTask.Exception;
        }

        public override async Task SetAsync(T[] value, int timeout = -1, CancellationToken token = default)
        {
            var setTask = client.WriteAnyAsync(indexGroup, indexOffset, value, [this.Count], token);
            await Task.WhenAny(Task.Delay(timeout), setTask);
            if (setTask.Status == TaskStatus.RanToCompletion)
            {
                return;
            }
            throw setTask.Exception;
        }

        public override async Task<T> GetItemAsync(int index, int timeout = -1, CancellationToken token = default)
        {
            var getTask = client.ReadAnyAsync<T>(indexGroups[index], indexOffsets[index], token);
            await Task.WhenAny(Task.Delay(timeout), getTask);
            if (getTask.Status == TaskStatus.RanToCompletion)
            {
                T item = getTask.Result.Value;
                getData()[index] = item;
                return item;
            }
            throw getTask.Exception;
        }

        public override async Task SetItemAsync(int index, T value, int timeout = -1, CancellationToken token = default)
        {
            var setTask = client.WriteAnyAsync(indexGroups[index], indexOffsets[index], value, token);
            await Task.WhenAny(Task.Delay(timeout), setTask);
            if (setTask.Status == TaskStatus.RanToCompletion)
            {
                return;
            }
            throw setTask.Exception;
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: 释放托管状态(托管对象)
                    beckhoffNotify?.Dispose();
                    notifySubject?.Dispose();
                }

                // TODO: 释放未托管的资源(未托管的对象)并重写终结器
                // TODO: 将大型字段设置为 null
                disposedValue = true;
            }
        }

        //// TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器
        //~BeckhoffArray()
        //{
        //    // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
        //    Dispose(disposing: false);
        //}

        public override void Dispose()
        {
            // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }


    public class BeckhoffBoolArray : BeckhoffArray<bool>
    {
        public BeckhoffBoolArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }


    public class BeckhoffBoolArray<TS> : BeckhoffArray<TS, bool> where TS : IPLCStructArray<bool>
    {
        public BeckhoffBoolArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffByteArray : BeckhoffArray<byte>
    {
        public BeckhoffByteArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffByteArray<TS> : BeckhoffArray<TS, byte> where TS : IPLCStructArray<byte>
    {
        public BeckhoffByteArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffSByteArray : BeckhoffArray<sbyte>
    {
        public BeckhoffSByteArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffSByteArray<TS> : BeckhoffArray<TS, sbyte> where TS : IPLCStructArray<sbyte>
    {
        public BeckhoffSByteArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffULongArray : BeckhoffArray<ulong>
    {
        public BeckhoffULongArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffULongArray<TS> : BeckhoffArray<TS, ulong> where TS : IPLCStructArray<ulong>
    {
        public BeckhoffULongArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffLongArray : BeckhoffArray<long>
    {
        public BeckhoffLongArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffLongArray<TS> : BeckhoffArray<TS, long> where TS : IPLCStructArray<long>
    {
        public BeckhoffLongArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffUIntArray : BeckhoffArray<uint>
    {
        public BeckhoffUIntArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffUIntArray<TS> : BeckhoffArray<TS, uint> where TS : IPLCStructArray<uint>
    {
        public BeckhoffUIntArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffIntArray : BeckhoffArray<int>
    {
        public BeckhoffIntArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffIntArray<TS> : BeckhoffArray<TS, int> where TS : IPLCStructArray<int>
    {
        public BeckhoffIntArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffUShortArray : BeckhoffArray<ushort>
    {
        public BeckhoffUShortArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffUShortArray<TS> : BeckhoffArray<TS, ushort> where TS : IPLCStructArray<ushort>
    {
        public BeckhoffUShortArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffShortArray : BeckhoffArray<short>
    {
        public BeckhoffShortArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffShortArray<TS> : BeckhoffArray<TS, short> where TS : IPLCStructArray<short>
    {
        public BeckhoffShortArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffFloatArray : BeckhoffArray<float>
    {
        public BeckhoffFloatArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffFloatArray<TS> : BeckhoffArray<TS, float> where TS : IPLCStructArray<float>
    {
        public BeckhoffFloatArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffDoubleArray : BeckhoffArray<double>
    {
        public BeckhoffDoubleArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

    public class BeckhoffDoubleArray<TS> : BeckhoffArray<TS, double> where TS : IPLCStructArray<double>
    {
        public BeckhoffDoubleArray(GetDataDel getDataDel, AdsClient client,
                                    uint indexGroup, uint indexOffset,
                                    uint[] indexGroups, uint[] indexOffsets, bool isStartFromZero)
            : base(getDataDel, client, indexGroup, indexOffset, indexGroups, indexOffsets, isStartFromZero)
        {
        }

    }

}
