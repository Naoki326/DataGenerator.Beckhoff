using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace PlcCore.Data
{
    public abstract class BaseStruct<TStruct> : BaseData, IStructData<TStruct> where TStruct : struct
    {
        public BaseStruct(GetDataDel getDataDel)
        {
            getData = getDataDel;
        }

        public delegate ref TStruct GetDataDel();
        protected readonly GetDataDel getData;
        public TStruct Data { get { return getData(); } }

        public abstract Task<TStruct> GetAsync(int timeout = -1, CancellationToken token = default);

        public abstract Task SetAsync(TStruct value, int timeout = -1, CancellationToken token = default);

        public abstract IDisposable Subscribe(IObserver<TStruct> observer);

        public override void Refresh(int timeout = -1, CancellationToken token = default)
        {
            TryGet(out _);
        }

        public virtual TStruct Get(int timeout = -1, CancellationToken token = default)
        {
            return GetAsync(timeout, token).Result;
        }

        public virtual void Set(TStruct value, int timeout = -1, CancellationToken token = default)
        {
            SetAsync(value, timeout, token).Wait();
        }

        public async Task<Result<TStruct>> TryGetAsync(int timeout = -1, CancellationToken token = default)
        {
            try
            {
                TStruct result = await GetAsync(timeout, token);
                return Result<TStruct>.Success(result);
            }
            catch (Exception)
            {
                return Result<TStruct>.Failure();
            }
        }

        public async Task<bool> TrySetAsync(TStruct value, int timeout = -1, CancellationToken token = default)
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

        public bool TryGet(out TStruct value, int timeout = -1, CancellationToken token = default)
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

        public bool TrySet(TStruct value, int timeout = -1, CancellationToken token = default)
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
    }
}
