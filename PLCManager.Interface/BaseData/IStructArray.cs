using System;
using System.Threading;
using System.Threading.Tasks;

namespace PlcCore.Data
{
    /// <summary>
    /// 结构体类型的数组对应的数据接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TStruct">T对应的结构体类型</typeparam>
    public interface IStructArray<T, TStruct> : IBaseData, IObservable<TStruct[]>, IDisposable where T : IBaseData where TStruct : struct
    {
        /// <summary>
        /// 这里使用T类型，是TStruct的代理类型，不需要担心修改结构体数据的问题
        /// 故使用ref T this[int index] { get; }
        /// </summary>
        ref T this[int index] { get; }

        int Count { get; }

        /// <summary>
        /// 考虑到函数调用方有可能修改Data的数据，故这里不使用ref TStruct[] Data { get; }
        /// 获取结构体数组数据，每次从原有的结构体数据上浅拷贝一个新的返回
        /// 与SetAsync方法联合调用，先从这里拿到结构体拷贝，然后Set
        /// </summary>
        TStruct[] Data { get; }

        TStruct[] Get(int timeout = -1, CancellationToken token = default);

        bool TryGet(out TStruct[] value, int timeout = -1, CancellationToken token = default);

        void Set(TStruct[] value, int timeout = -1, CancellationToken token = default);

        bool TrySet(TStruct[] value, int timeout = -1, CancellationToken token = default);

        Task<TStruct[]> GetAsync(int timeout = -1, CancellationToken token = default);

        Task<ResultArray<TStruct>> TryGetAsync(int timeout = -1, CancellationToken token = default);

        Task SetAsync(TStruct[] value, int timeout = -1, CancellationToken token = default);

        Task<bool> TrySetAsync(TStruct[] value, int timeout = -1, CancellationToken token = default);


        TStruct GetItem(int index, int timeout = -1, CancellationToken token = default);

        bool TryGetItem(int index, out TStruct value, int timeout = -1, CancellationToken token = default);

        void SetItem(int index, TStruct value, int timeout = -1, CancellationToken token = default);

        bool TrySetItem(int index, TStruct value, int timeout = -1, CancellationToken token = default);

        Task<TStruct> GetItemAsync(int index, int timeout = -1, CancellationToken token = default);

        Task<Result<TStruct>> TryGetItemAsync(int index, int timeout = -1, CancellationToken token = default);

        Task SetItemAsync(int index, TStruct value, int timeout = -1, CancellationToken token = default);

        Task<bool> TrySetItemAsync(int index, TStruct value, int timeout = -1, CancellationToken token = default);
    }
    /// <summary>
    /// 结构体类型的数组对应的数据接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TStruct">T对应的结构体类型</typeparam>
    public interface IStructArray<TS, T, TStruct> : IBaseData, IObservable<TS>, IDisposable
        where T : IBaseData where TStruct : struct where TS : IPLCStructArray<TStruct>
    {
        /// <summary>
        /// 这里使用T类型，是TStruct的代理类型，不需要担心修改结构体数据的问题
        /// 故使用ref T this[int index] { get; }
        /// </summary>
        ref T this[int index] { get; }

        int Count { get; }

        /// <summary>
        /// 考虑到函数调用方有可能修改Data的数据，故这里不使用ref TStruct[] Data { get; }
        /// 获取结构体数组数据，每次从原有的结构体数据上浅拷贝一个新的返回
        /// 与SetAsync方法联合调用，先从这里拿到结构体拷贝，然后Set
        /// </summary>
        TS Data { get; }

        TStruct[] Get(int timeout = -1, CancellationToken token = default);

        bool TryGet(out TStruct[] value, int timeout = -1, CancellationToken token = default);

        void Set(TStruct[] value, int timeout = -1, CancellationToken token = default);

        bool TrySet(TStruct[] value, int timeout = -1, CancellationToken token = default);

        Task<TStruct[]> GetAsync(int timeout = -1, CancellationToken token = default);

        Task<ResultArray<TStruct>> TryGetAsync(int timeout = -1, CancellationToken token = default);

        Task SetAsync(TStruct[] value, int timeout = -1, CancellationToken token = default);

        Task<bool> TrySetAsync(TStruct[] value, int timeout = -1, CancellationToken token = default);


        TStruct GetItem(int index, int timeout = -1, CancellationToken token = default);

        void SetItem(int index, TStruct value, int timeout = -1, CancellationToken token = default);

        Task<TStruct> GetItemAsync(int index, int timeout = -1, CancellationToken token = default);

        Task<Result<TStruct>> TryGetItemAsync(int index, int timeout = -1, CancellationToken token = default);

        Task SetItemAsync(int index, TStruct value, int timeout = -1, CancellationToken token = default);

        Task<bool> TrySetItemAsync(int index, TStruct value, int timeout = -1, CancellationToken token = default);
    }
}
