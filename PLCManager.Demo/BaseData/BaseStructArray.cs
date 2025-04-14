using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PlcCore.Data
{
    public abstract class BaseStructArray<T, TStruct> : BaseData, IStructArray<T, TStruct> where T : IBaseData where TStruct : struct
    {
        public BaseStructArray(GetDataDel getDataDel)
        {
            getData = getDataDel;
        }


        public override IEnumerable<IBaseData> Children
        {
            get
            {
                for (int i = 0; i < Count; i++)
                {
                    yield return this[i];
                }
            }
        }

        public override IBaseData Get(string name)
        {
            if (name.StartsWith("Item_")
               && int.TryParse(name.Substring(5), out int index))
            { return this[index]; }
            throw new KeyNotFoundException(name);
        }

        public delegate ref TStruct[] GetDataDel();
        protected readonly GetDataDel getData;
        public abstract ref T this[int index] { get; }

        public int Count => getData().Length;
        public TStruct[] Data => getData();


        public abstract IDisposable Subscribe(IObserver<TStruct[]> observer);

        public abstract Task<TStruct[]> GetAsync(int timeout = -1, CancellationToken token = default);
        public abstract Task SetAsync(TStruct[] value, int timeout = -1, CancellationToken token = default);

        public abstract Task<TStruct> GetItemAsync(int index, int timeout = -1, CancellationToken token = default);
        public abstract Task SetItemAsync(int index, TStruct value, int timeout = -1, CancellationToken token = default);

        public override void Refresh(int timeout = -1, CancellationToken token = default)
        {
            TryGet(out _, timeout, token);
        }

        public virtual TStruct[] Get(int timeout = -1, CancellationToken token = default)
        {
            return GetAsync(timeout, token).Result;
        }

        public virtual void Set(TStruct[] value, int timeout = -1, CancellationToken token = default)
        {
            SetAsync(value, timeout, token).Wait();
        }

        public virtual TStruct GetItem(int index, int timeout = -1, CancellationToken token = default)
        {
            return GetItemAsync(index, timeout, token).Result;
        }

        public virtual void SetItem(int index, TStruct value, int timeout = -1, CancellationToken token = default)
        {
            SetItemAsync(index, value, timeout, token).Wait();
        }

        public async Task<ResultArray<TStruct>> TryGetAsync(int timeout = -1, CancellationToken token = default)
        {
            try
            {
                var result = await GetAsync(timeout, token);
                return ResultArray<TStruct>.Success(result);
            }
            catch (Exception)
            {
                return ResultArray<TStruct>.Failure();
            }
        }

        public async Task<bool> TrySetAsync(TStruct[] value, int timeout = -1, CancellationToken token = default)
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

        public async Task<Result<TStruct>> TryGetItemAsync(int index, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                var result = await GetItemAsync(index, timeout, token);
                return Result<TStruct>.Success(result);
            }
            catch (Exception)
            {
                return Result<TStruct>.Failure();
            }
        }
        public async Task<bool> TrySetItemAsync(int index, TStruct value, int timeout = -1, CancellationToken token = default)
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

        public bool TryGet(out TStruct[] value, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                value = Get(timeout, token);
                return true;
            }
            catch (Exception)
            {
                value = default;
                return false;
            }
        }

        public bool TrySet(TStruct[] value, int timeout = -1, CancellationToken token = default)
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

        public bool TryGetItem(int index, out TStruct value, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                value = GetItem(index, timeout, token);
                return true;
            }
            catch (Exception)
            {
                value = default;
                return false;
            }
        }

        public bool TrySetItem(int index, TStruct value, int timeout = -1, CancellationToken token = default)
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
    public abstract class BaseStructArray<TS, T, TStruct> : BaseData, IStructArray<TS, T, TStruct>
        where T : IBaseData where TStruct : struct where TS : IPLCStructArray<TStruct>
    {
        public BaseStructArray(GetDataDel getDataDel)
        {
            getData = getDataDel;
        }


        public override IEnumerable<IBaseData> Children
        {
            get
            {
                for (int i = 0; i < Count; i++)
                {
                    yield return this[i];
                }
            }
        }

        public override IBaseData Get(string name)
        {
            if (name.StartsWith("Item_")
               && int.TryParse(name.Substring(5), out int index))
            { return this[index]; }
            throw new KeyNotFoundException(name);
        }

        public delegate ref TS GetDataDel();
        protected readonly GetDataDel getData;
        public abstract ref T this[int index] { get; }

        public int Count => getData().Length;
        public TS Data => getData();


        public abstract IDisposable Subscribe(IObserver<TS> observer);

        public abstract Task<TStruct[]> GetAsync(int timeout = -1, CancellationToken token = default);
        public abstract Task SetAsync(TStruct[] value, int timeout = -1, CancellationToken token = default);

        public abstract Task<TStruct> GetItemAsync(int index, int timeout = -1, CancellationToken token = default);
        public abstract Task SetItemAsync(int index, TStruct value, int timeout = -1, CancellationToken token = default);

        public override void Refresh(int timeout = -1, CancellationToken token = default)
        {
            TryGet(out _, timeout, token);
        }

        public virtual TStruct[] Get(int timeout = -1, CancellationToken token = default)
        {
            return GetAsync(timeout, token).Result;
        }

        public virtual void Set(TStruct[] value, int timeout = -1, CancellationToken token = default)
        {
            SetAsync(value, timeout, token).Wait();
        }

        public virtual TStruct GetItem(int index, int timeout = -1, CancellationToken token = default)
        {
            return GetItemAsync(index, timeout, token).Result;
        }

        public virtual void SetItem(int index, TStruct value, int timeout = -1, CancellationToken token = default)
        {
            SetItemAsync(index, value, timeout, token).Wait();
        }

        public async Task<ResultArray<TStruct>> TryGetAsync(int timeout = -1, CancellationToken token = default)
        {
            try
            {
                var result = await GetAsync(timeout, token);
                return ResultArray<TStruct>.Success(result);
            }
            catch (Exception)
            {
                return ResultArray<TStruct>.Failure();
            }
        }

        public async Task<bool> TrySetAsync(TStruct[] value, int timeout = -1, CancellationToken token = default)
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

        public async Task<Result<TStruct>> TryGetItemAsync(int index, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                var result = await GetItemAsync(index, timeout, token);
                return Result<TStruct>.Success(result);
            }
            catch (Exception)
            {
                return Result<TStruct>.Failure();
            }
        }
        public async Task<bool> TrySetItemAsync(int index, TStruct value, int timeout = -1, CancellationToken token = default)
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

        public bool TryGet(out TStruct[] value, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                value = Get(timeout, token);
                return true;
            }
            catch (Exception)
            {
                value = default;
                return false;
            }
        }

        public bool TrySet(TStruct[] value, int timeout = -1, CancellationToken token = default)
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

        public bool TryGetItem(int index, out TStruct value, int timeout = -1, CancellationToken token = default)
        {
            try
            {
                value = GetItem(index, timeout, token);
                return true;
            }
            catch (Exception)
            {
                value = default;
                return false;
            }
        }

        public bool TrySetItem(int index, TStruct value, int timeout = -1, CancellationToken token = default)
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
