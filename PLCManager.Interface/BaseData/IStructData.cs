using System;
using System.Threading;
using System.Threading.Tasks;

namespace PlcCore.Data
{
    public interface IStructData<TStruct> : IBaseData, IObservable<TStruct>, IDisposable where TStruct : struct
    {
        /// <summary>
        /// 考虑到函数调用方有可能修改Data的数据，故这里不使用ref TStruct Data { get; }
        /// 获取结构体数据，每次从原有的结构体数据上浅拷贝一个新的返回
        /// 与SetAsync方法联合调用，先从这里拿到结构体拷贝，然后Set
        /// </summary>
        TStruct Data { get; }

        TStruct Get(int timeout = -1, CancellationToken token = default);

        void Set(TStruct value, int timeout = -1, CancellationToken token = default);

        bool TryGet(out TStruct value, int timeout = -1, CancellationToken token = default);

        bool TrySet(TStruct value, int timeout = -1, CancellationToken token = default);

        Task<TStruct> GetAsync(int timeout = -1, CancellationToken token = default);

        Task<Result<TStruct>> TryGetAsync(int timeout = -1, CancellationToken token = default);

        Task SetAsync(TStruct value, int timeout = -1, CancellationToken token = default);

        Task<bool> TrySetAsync(TStruct value, int timeout = -1, CancellationToken token = default);
    }
}
