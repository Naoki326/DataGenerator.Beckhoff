using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PlcCore.Data
{

    public abstract class BaseData : IBaseData
    {
        public virtual bool SelfNotify { get; set; } = false;

        public abstract void CheckAndNotify(int timeout = -1, CancellationToken token = default);

        public virtual void Refresh(int timeout = -1, CancellationToken token = default)
        {
            if (SelfNotify)
            { return; }
            foreach (var child in Children)
            {
                child.Refresh(timeout, token);
            }
        }

        public IBaseData Parent { get; internal set; }
        public abstract IEnumerable<IBaseData> Children { get; }

        public virtual IBaseData Get(string name)
        {
            if (Children.FirstOrDefault(p => nameof(p) == name) is IBaseData data)
                return data;
            throw new KeyNotFoundException(name);
        }

        internal abstract void Init();

        public string Name { get; internal set; }

        public abstract void Dispose();
    }

    public abstract class BaseData<T> : BaseData, IBaseData<T> where T : struct
    {
        public BaseData(GetDataDel getDataDel)
        {
            getData = getDataDel;
        }

        public override IEnumerable<IBaseData> Children { get { yield break; } }
        public override IBaseData Get(string name) { throw new KeyNotFoundException(name); }

        public delegate ref T GetDataDel();
        protected readonly GetDataDel getData;
        public T Data
        {
            get { return getData(); }
        }

        public abstract IDisposable Subscribe(IObserver<T> observer);

        public override void Refresh(int timeout = -1, CancellationToken token = default)
        {
            TryGet(out _);
        }

        public abstract Task<T> GetAsync(int timeout = -1, CancellationToken token = default);
        public abstract Task SetAsync(T value, int timeout = -1, CancellationToken token = default);

        public bool TryGet(out T value, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                value = Get(timeout, token);
                return true;
            }
            catch (Exception)
            {
                value = default(T);
                return false;
            }
        }

        public bool TrySet(T value, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                Set(value, timeout, token);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public virtual T Get(int timeout = -1, CancellationToken token = default)
        {
            getData() = GetAsync(timeout, token).Result;
            return getData();
        }

        public virtual void Set(T value, int timeout = -1, CancellationToken token = default)
        {
            SetAsync(value, timeout, token).Wait();
        }

        public async Task<Result<T>> TryGetAsync(int timeout = -1, CancellationToken token = default)
        {
            try
            {
                T result = await GetAsync(timeout, token);
                return Result<T>.Success(result);
            }
            catch (Exception)
            {
                return Result<T>.Failure();
            }
        }
        public async Task<bool> TrySetAsync(T value, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                await SetAsync(value, timeout, token);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
