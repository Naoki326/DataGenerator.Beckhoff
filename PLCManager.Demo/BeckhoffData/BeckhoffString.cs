using System;
using System.Collections.Generic;
using System.Drawing;
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
    public class BeckhoffString : BaseString
    {

        public BeckhoffString(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel)
        {
            this.client = client;
            this.indexGroup = indexGroup;
            this.indexOffset = indexOffset;
        }

        private Subject<string> notifySubject = new();
        public override IDisposable Subscribe(IObserver<string> observer)
        {
            return notifySubject.Subscribe(observer);
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
                beckhoffNotify = client.WhenNotification<byte[]>(this.GetFullName(), NotificationSettings.Default).Subscribe((v) =>
                {
                    getData() = Encoding.ASCII.GetString(v, 0, Length);
                    notifySubject.OnNext(getData());
                });
            }
        }

        protected string oldData;
        public override void CheckAndNotify(int timeout = -1, CancellationToken token = default)
        {
            if (!string.Equals(getData(), oldData))
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

        public override string Get(int timeout = -1, CancellationToken token = default)
        {
            var strValue = client.ReadAny<byte[]>(indexGroup, indexOffset, [Length]);
            getData() = Encoding.ASCII.GetString(strValue, 0, Length);
            return getData();
        }

        public override void Set(string value, int timeout = -1, CancellationToken token = default)
        {
            byte[] strBytes = Encoding.ASCII.GetBytes(value.ToCharArray(), 0, Length);
            client.WriteAny(indexGroup, indexOffset, strBytes);
        }

        public override async Task<string> GetAsync(int timeout = -1, CancellationToken token = default)
        {
            var getTask = client.ReadAnyAsync<byte[]>(indexGroup, indexOffset, [Length], token);
            await Task.WhenAny(Task.Delay(timeout), getTask);
            if (getTask.Status == TaskStatus.RanToCompletion)
            {
                getData() = Encoding.ASCII.GetString(getTask.Result.Value, 0, Length);
                return getData();
            }
            throw getTask.Exception;
        }

        public override async Task SetAsync(string value, int timeout = -1, CancellationToken token = default)
        {
            byte[] strBytes = Encoding.ASCII.GetBytes(value.ToCharArray(), 0, Length);
            var setTask = client.WriteAnyAsync(indexGroup, indexOffset, strBytes, token);
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
        //~BeckhoffString()
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


    public class BeckhoffString<TS> : BaseString<TS> where TS : IPLCStructArray<byte>
    {

        public BeckhoffString(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel)
        {
            this.client = client;
            this.indexGroup = indexGroup;
            this.indexOffset = indexOffset;
        }


        private Subject<string> notifySubject = new();
        public override IDisposable Subscribe(IObserver<string> observer)
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
                beckhoffNotify = client.WhenNotification<byte[]>(this.GetFullName(), NotificationSettings.Default).Subscribe((v) =>
                {
                    for (int i = 0; i < Length; i++)
                    {
                        getData()[i] = v[i];
                    }
                    notifySubject.OnNext(getData().ToString());
                });
            }
        }

        protected string oldData;
        public override void CheckAndNotify(int timeout = -1, CancellationToken token = default)
        {
            if (!string.Equals(getData().ToString(), oldData))
            {
                oldData = getData().ToString();
                if (!SelfNotify)
                { notifySubject.OnNext(oldData); }
            }
        }

        internal override void Init()
        {
            if (!getData().Equals(oldData))
            {
                oldData = getData().ToString();
            }
        }


        private readonly AdsClient client;

        private readonly uint indexGroup;
        private readonly uint indexOffset;

        private bool disposedValue;


        public override string Get(int timeout = -1, CancellationToken token = default)
        {
            var strValue = client.ReadAny<byte[]>(indexGroup, indexOffset, [Length]);
            for(int i = 0; i < Length; i++)
            {
                getData()[i] = strValue[i];
            }
            return Encoding.ASCII.GetString(strValue, 0, Length);
        }

        public override void Set(string value, int timeout = -1, CancellationToken token = default)
        {
            byte[] strBytes = Encoding.ASCII.GetBytes(value.ToCharArray(), 0, Length);
            client.WriteAny(indexGroup, indexOffset, strBytes);
        }

        public override async Task<string> GetAsync(int timeout = -1, CancellationToken token = default)
        {
            var getTask = client.ReadAnyAsync<byte[]>(indexGroup, indexOffset, [Length], token);
            await Task.WhenAny(Task.Delay(timeout), getTask);
            if (getTask.Status == TaskStatus.RanToCompletion)
            {
                var strValue = getTask.Result.Value;
                for (int i = 0; i < getData().Length; i++)
                {
                    getData()[i] = strValue[i];
                }
                return Encoding.ASCII.GetString(strValue, 0, Length);
            }
            throw getTask.Exception;
        }

        public override async Task SetAsync(string value, int timeout = -1, CancellationToken token = default)
        {
            byte[] strBytes = Encoding.ASCII.GetBytes(value.ToCharArray(), 0, Length);
            var setTask = client.WriteAnyAsync(indexGroup, indexOffset, strBytes, token);
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
        //~BeckhoffString()
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
}
