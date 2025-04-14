using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Linq;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Threading;
using System.Threading.Tasks;
using PlcCore.Data;
using TwinCAT.Ads;
using TwinCAT.Ads.Reactive;
using TwinCAT.PlcOpen;
using System.Reactive.Concurrency;

namespace PlcCore.Beckhoff
{
    public class BeckhoffStruct<T, TStruct> : BaseStruct<TStruct> where T : IBaseData where TStruct : struct
    {
        public BeckhoffStruct(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel)
        {
            this.client = client;
            this.indexGroup = indexGroup;
            this.indexOffset = indexOffset;
        }

        public override IEnumerable<IBaseData> Children => GetChildren();

        protected virtual IEnumerable<IBaseData> GetChildren()
        {
            yield break;
        }

        private Subject<TStruct> notifySubject = new();
        public override IDisposable Subscribe(IObserver<TStruct> observer)
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
                beckhoffNotify = client.WhenNotification<TStruct>(this.GetFullName(), NotificationSettings.Default).Subscribe((v) =>
                {
                    getData() = v;
                    notifySubject.OnNext(getData());
                });
            }
        }

        public override void CheckAndNotify(int timeout = -1, CancellationToken token = default)
        {
            foreach (var child in Children)
            {
                child?.CheckAndNotify(timeout, token);
            }
        }

        internal override void Init()
        {
            foreach (var child in Children)
            {
                if(child is null)
                { }
                else if (child is IObservable<object> objObservable)
                {
                    objObservable.Select(t => getData()).Subscribe(notifySubject);
                }
                else
                {
                    switch (child)
                    {
                        case IObservable<bool> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<byte> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<short> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<ushort> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<int> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<uint> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<long> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<ulong> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<float> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<double> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<bool[]> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<byte[]> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<short[]> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<ushort[]> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<int[]> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<uint[]> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<long[]> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<ulong[]> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<float[]> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        case IObservable<double[]> data:
                            data.Select(t => getData()).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                        default:
                            ConvertToObservableObject(child).Where(t => !this.SelfNotify).Subscribe(notifySubject);
                            break;
                    }
                }
            }
        }

        public IObservable<TStruct> ConvertToObservableObject(object unknownObservable)
        {
            // 获取所有接口类型
            var interfaces = unknownObservable.GetType().GetInterfaces();

            // 找到 IObservable<T> 的实现
            var observableInterface = interfaces.FirstOrDefault(i =>
                i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IObservable<>));

            if (observableInterface == null)
                throw new ArgumentException("The provided object does not implement IObservable<T>");

            // 获取 T 的类型
            var elementType = observableInterface.GetGenericArguments()[0];

            // 获取 Observable 类的 Select 方法
            var selectMethod = typeof(Observable).GetMethods()
                .First(m => m.Name == "Select" && m.GetParameters().Length == 2);

            // 创建一个泛型方法与对象
            var genericSelectMethod = selectMethod.MakeGenericMethod(elementType, typeof(TStruct));

            // 创建一个 lambda 表达式以将元素转换为 Data 属性
            var parameter = Expression.Parameter(elementType, "x");
            var dataProperty = Expression.Property(Expression.Constant(this), nameof(Data));
            var lambda = Expression.Lambda(dataProperty, parameter);

            // 调用 Select 方法以转换为 IObservable<object>
            var observableObject = genericSelectMethod.Invoke(null, new object[] { unknownObservable, lambda.Compile() });

            return (IObservable<TStruct>)observableObject;
        }

        private readonly AdsClient client;

        private readonly uint indexGroup;
        private readonly uint indexOffset;

        private bool disposedValue;

        public override TStruct Get(int timeout = -1, CancellationToken token = default)
        {
            getData() = client.ReadAny<TStruct>(indexGroup, indexOffset);
            return getData();
        }

        public override void Set(TStruct value, int timeout = -1, CancellationToken token = default)
        {
            client.WriteAny(indexGroup, indexOffset, value);
        }

        public override async Task<TStruct> GetAsync(int timeout = -1, CancellationToken token = default)
        {
            var getTask = client.ReadAnyAsync<TStruct>(indexGroup, indexOffset, token);
            await Task.WhenAny(Task.Delay(timeout), getTask);
            if (getTask.Status == TaskStatus.RanToCompletion)
            {
                getData() = getTask.Result.Value;
                return getData();
            }
            throw getTask.Exception;
        }

        public override async Task SetAsync(TStruct value, int timeout = -1, CancellationToken token = default)
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

        //// TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器
        //~BeckhoffStruct()
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
