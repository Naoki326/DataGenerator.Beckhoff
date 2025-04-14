using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PlcCore.Data
{
    public abstract class BaseArray<T> : BaseData, IBaseArray<T> where T : struct
    {
        public BaseArray(GetDataDel getDataDel)
        {
            getData = getDataDel;
        }
        public delegate ref IPLCStructArray<T> GetDataDel();
        protected readonly GetDataDel getData;

        public override IEnumerable<IBaseData> Children { get { yield break; } }
        public override IBaseData Get(string name) { throw new KeyNotFoundException(name); }

        public T this[int index] => getData()[index];

        public int Count => getData().Length;
        public IPLCStructArray<T> Data => getData();
        public abstract IDisposable Subscribe(IObserver<T[]> observer);

        public override void Refresh(int timeout = -1, CancellationToken token = default)
        {
            if (!SelfNotify)
            { TryGet(out _); }
        }

        public abstract Task<T[]> GetAsync(int timeout = -1, CancellationToken token = default);

        public abstract Task SetAsync(T[] value, int timeout = -1, CancellationToken token = default);

        public abstract Task<T> GetItemAsync(int index, int timeout = -1, CancellationToken token = default);

        public abstract Task SetItemAsync(int index, T value, int timeout = -1, CancellationToken token = default);

        public virtual T[] Get(int timeout = -1, CancellationToken token = default)
        {
            return GetAsync(timeout, token).Result;
        }

        public virtual void Set(T[] value, int timeout = -1, CancellationToken token = default)
        {
            SetAsync(value, timeout, token).Wait();
        }

        public virtual T GetItem(int index, int timeout = -1, CancellationToken token = default)
        {
            return GetItemAsync(index, timeout, token).Result;
        }

        public virtual void SetItem(int index, T value, int timeout = -1, CancellationToken token = default)
        {
            SetItemAsync(index, value, timeout, token).Wait();
        }

        public async Task<ResultArray<T>> TryGetAsync(int timeout = -1, CancellationToken token = default)
        {
            try
            {
                T[] result = await GetAsync(timeout, token);
                return ResultArray<T>.Success(result);
            }
            catch (Exception)
            {
                return ResultArray<T>.Failure();
            }
        }

        public async Task<bool> TrySetAsync(T[] value, int timeout = -1, CancellationToken token = default)
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

        public async Task<Result<T>> TryGetItemAsync(int index, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                T result = await GetItemAsync(index, timeout, token);
                return Result<T>.Success(result);
            }
            catch (Exception)
            {
                return Result<T>.Failure();
            }
        }

        public async Task<bool> TrySetItemAsync(int index, T value, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                await SetItemAsync(index, value, timeout, token);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool TryGet(out T[] value, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                value = Get(timeout, token);
                return true;
            }
            catch (Exception)
            {
                value = default(T[]);
                return false;
            }
        }

        public bool TrySet(T[] value, int timeout = -1, CancellationToken token = default)
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

        public bool TryGetItem(int index, out T value, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                value = GetItem(index, timeout, token);
                return true;
            }
            catch (Exception)
            {
                value = default(T);
                return false;
            }
        }

        public bool TrySetItem(int index, T value, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                SetItem(index, value, timeout, token);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    public abstract class BaseArray<TS, T> : BaseData, IBaseArray<TS, T> where T : struct where TS : IPLCStructArray<T>
    {
        public BaseArray(GetDataDel getDataDel)
        {
            getData = getDataDel;
        }
        public delegate ref TS GetDataDel();
        protected readonly GetDataDel getData;

        public override IEnumerable<IBaseData> Children { get { yield break; } }
        public override IBaseData Get(string name) { throw new KeyNotFoundException(name); }
        public T this[int index] => getData()[index];

        public int Count => getData().Length;
        public TS Data => getData();

        public abstract IDisposable Subscribe(IObserver<T[]> observer);

        public override void Refresh(int timeout = -1, CancellationToken token = default)
        {
            if (!SelfNotify)
            { TryGet(out _); }
        }

        public abstract Task<T[]> GetAsync(int timeout = -1, CancellationToken token = default);

        public abstract Task SetAsync(T[] value, int timeout = -1, CancellationToken token = default);

        public abstract Task<T> GetItemAsync(int index, int timeout = -1, CancellationToken token = default);

        public abstract Task SetItemAsync(int index, T value, int timeout = -1, CancellationToken token = default);

        public virtual T[] Get(int timeout = -1, CancellationToken token = default)
        {
            return GetAsync(timeout, token).Result;
        }

        public virtual void Set(T[] value, int timeout = -1, CancellationToken token = default)
        {
            SetAsync(value, timeout, token).Wait();
        }

        public virtual T GetItem(int index, int timeout = -1, CancellationToken token = default)
        {
            return GetItemAsync(index, timeout, token).Result;
        }

        public virtual void SetItem(int index, T value, int timeout = -1, CancellationToken token = default)
        {
            SetItemAsync(index, value, timeout, token).Wait();
        }

        public async Task<ResultArray<T>> TryGetAsync(int timeout = -1, CancellationToken token = default)
        {
            try
            {
                T[] result = await GetAsync(timeout, token);
                return ResultArray<T>.Success(result);
            }
            catch (Exception)
            {
                return ResultArray<T>.Failure();
            }
        }

        public async Task<bool> TrySetAsync(T[] value, int timeout = -1, CancellationToken token = default)
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

        public async Task<Result<T>> TryGetItemAsync(int index, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                T result = await GetItemAsync(index, timeout, token);
                return Result<T>.Success(result);
            }
            catch (Exception)
            {
                return Result<T>.Failure();
            }
        }

        public async Task<bool> TrySetItemAsync(int index, T value, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                await SetItemAsync(index, value, timeout, token);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool TryGet(out T[] value, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                value = Get(timeout, token);
                return true;
            }
            catch (Exception)
            {
                value = default(T[]);
                return false;
            }
        }

        public bool TrySet(T[] value, int timeout = -1, CancellationToken token = default)
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

        public bool TryGetItem(int index, out T value, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                value = GetItem(index, timeout, token);
                return true;
            }
            catch (Exception)
            {
                value = default(T);
                return false;
            }
        }

        public bool TrySetItem(int index, T value, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                SetItem(index, value, timeout, token);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }

}
