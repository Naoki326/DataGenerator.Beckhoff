using System;
using System.Collections.Generic;
using System.Reactive.Concurrency;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;
using PlcCore.Data;
using TwinCAT;
using TwinCAT.Ads;
using TwinCAT.Ads.Reactive;
using TwinCAT.Ads.TypeSystem;
using TwinCAT.TypeSystem;

namespace PlcCore.Beckhoff
{
    public class BeckhoffBase<T> : BaseData<T> where T : struct
    {

        public BeckhoffBase(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel)
        {
            this.client = client;
            this.indexGroup = indexGroup;
            this.indexOffset = indexOffset;
        }

        private Subject<T> notifySubject = new();
        public override IDisposable Subscribe(IObserver<T> observer)
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
                beckhoffNotify = client.WhenNotification<T>(this.GetFullName(), NotificationSettings.Default).Subscribe((v) =>
                {
                    getData() = v;
                    notifySubject.OnNext(v);
                });
            }
        }

        protected T oldData;
        public override void CheckAndNotify(int timeout = -1, CancellationToken token = default)
        {
            if (!getData().Equals(oldData))
            {
                oldData = getData();
                if (!SelfNotify)
                { notifySubject.OnNext(oldData); }
            }
        }

        internal override void Init()
        {
            if (!getData().Equals(oldData))
            {
                oldData = getData();
            }
        }


        private readonly AdsClient client;

        private readonly uint indexGroup;
        private readonly uint indexOffset;

        private bool disposedValue;

        public override T Get(int timeout = -1, CancellationToken token = default)
        {
            getData() = client.ReadAny<T>(indexGroup, indexOffset);
            return getData();
        }

        public override void Set(T value, int timeout = -1, CancellationToken token = default)
        {
            client.WriteAny(indexGroup, indexOffset, value);
        }

        public override async Task<T> GetAsync(int timeout = -1, CancellationToken token = default)
        {
            CancellationTokenSource source = new CancellationTokenSource();
            using (token.Register(() => source.Cancel()))
            {
                var getTask = client.ReadAnyAsync<T>(indexGroup, indexOffset, source.Token);
                await Task.WhenAny(Task.Delay(timeout), getTask);
                if (getTask.Status == TaskStatus.RanToCompletion)
                {
                    getData() = getTask.Result.Value;
                    return getData();
                }
                source.Cancel();
                throw getTask.Exception;
            }
        }

        public override async Task SetAsync(T value, int timeout = -1, CancellationToken token = default)
        {
            var setTask = client.WriteAnyAsync(indexGroup, indexOffset, value, token);
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

        // TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器
        ~BeckhoffBase()
        {
            // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
            Dispose(disposing: false);
        }

        public override void Dispose()
        {
            // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

    public class BeckhoffBool : BeckhoffBase<bool>
    {
        public BeckhoffBool(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset)
            : base(getDataDel, client, indexGroup, indexOffset)
        {
        }

    }

    public class BeckhoffByte : BeckhoffBase<byte>
    {
        public BeckhoffByte(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset)
            : base(getDataDel, client, indexGroup, indexOffset)
        {
        }
    }

    public class BeckhoffSByte : BeckhoffBase<sbyte>
    {
        public BeckhoffSByte(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset)
            : base(getDataDel, client, indexGroup, indexOffset)
        {
        }
    }

    public class BeckhoffULong : BeckhoffBase<ulong>
    {
        public BeckhoffULong(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset)
            : base(getDataDel, client, indexGroup, indexOffset)
        {
        }
    }

    public class BeckhoffLong : BeckhoffBase<long>
    {
        public BeckhoffLong(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset)
            : base(getDataDel, client, indexGroup, indexOffset)
        {
        }
    }

    public class BeckhoffUInt : BeckhoffBase<uint>
    {
        public BeckhoffUInt(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset)
            : base(getDataDel, client, indexGroup, indexOffset)
        {
        }
    }

    public class BeckhoffInt : BeckhoffBase<int>
    {
        public BeckhoffInt(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset)
            : base(getDataDel, client, indexGroup, indexOffset)
        {
        }
    }

    public class BeckhoffUShort : BeckhoffBase<ushort>
    {
        public BeckhoffUShort(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset)
            : base(getDataDel, client, indexGroup, indexOffset)
        {
        }
    }

    public class BeckhoffShort : BeckhoffBase<short>
    {
        public BeckhoffShort(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset)
            : base(getDataDel, client, indexGroup, indexOffset)
        {
        }
    }

    public class BeckhoffFloat : BeckhoffBase<float>
    {
        public BeckhoffFloat(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset)
            : base(getDataDel, client, indexGroup, indexOffset)
        {
        }
    }

    public class BeckhoffDouble : BeckhoffBase<double>
    {
        public BeckhoffDouble(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset)
            : base(getDataDel, client, indexGroup, indexOffset)
        {
        }
    }
}
