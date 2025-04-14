using System;
using System.Threading;
using System.Threading.Tasks;

namespace PlcCore.Data
{

    /// <summary>
    /// 基础类型的数据
    /// 只包括：BOOL、BYTE、UINT、INT、UDINT、DINT、REAL、LREAL、STRING
    /// BOOL =>  [MarshalAs(UnmanagedType.I1)]  bool
    /// BYTE =>  byte
    /// UINT =>  ushort
    /// INT =>  short
    /// UDINT =>  uint
    /// DINT =>  int
    /// REAL =>  float
    /// LREAL =>  double
    /// STRING =>  [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 81)]  string
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseArray<T> : IBaseData, IObservable<T[]>, IDisposable where T : struct
    {
        /// <summary>
        /// 考虑到函数调用方有可能修改Data的数据，故这里不使用ref T this[int index] { get; }
        /// 获取数组数据，每次从原有的结构体数据上浅拷贝一个新的返回
        /// 与SetAsync方法联合调用，先从这里拿到结构体拷贝，然后Set
        /// </summary>
        T this[int index] { get; }

        int Count { get; }

        /// <summary>
        /// 考虑到函数调用方有可能修改Data的数据，故这里不使用ref T[] Data { get; }
        /// 获取数组数据，每次从原有的结构体数据上浅拷贝一个新的返回
        /// 与SetAsync方法联合调用，先从这里拿到结构体拷贝，然后Set
        /// </summary>
        IPLCStructArray<T> Data { get; }

        T[] Get(int timeout = -1, CancellationToken token = default);

        bool TryGet(out T[] value, int timeout = -1, CancellationToken token = default);

        void Set(T[] value, int timeout = -1, CancellationToken token = default);

        bool TrySet(T[] value, int timeout = -1, CancellationToken token = default);

        Task<T[]> GetAsync(int timeout = -1, CancellationToken token = default);

        Task<ResultArray<T>> TryGetAsync(int timeout = -1, CancellationToken token = default);

        Task SetAsync(T[] value, int timeout = -1, CancellationToken token = default);

        Task<bool> TrySetAsync(T[] value, int timeout = -1, CancellationToken token = default);


        T GetItem(int index, int timeout = -1, CancellationToken token = default);

        bool TryGetItem(int index, out T value, int timeout = -1, CancellationToken token = default);

        void SetItem(int index, T value, int timeout = -1, CancellationToken token = default);

        bool TrySetItem(int index, T value, int timeout = -1, CancellationToken token = default);

        Task<T> GetItemAsync(int index, int timeout = -1, CancellationToken token = default);

        Task<Result<T>> TryGetItemAsync(int index, int timeout = -1, CancellationToken token = default);

        Task SetItemAsync(int index, T value, int timeout = -1, CancellationToken token = default);

        Task<bool> TrySetItemAsync(int index, T value, int timeout = -1, CancellationToken token = default);
    }

    public interface IBaseArray<TS, T> : IBaseData, IObservable<T[]>, IDisposable where T : struct where TS : IPLCStructArray<T>
    {
        /// <summary>
        /// 考虑到函数调用方有可能修改Data的数据，故这里不使用ref T this[int index] { get; }
        /// 获取数组数据，每次从原有的结构体数据上浅拷贝一个新的返回
        /// 与SetAsync方法联合调用，先从这里拿到结构体拷贝，然后Set
        /// </summary>
        T this[int index] { get; }

        int Count { get; }

        /// <summary>
        /// 考虑到函数调用方有可能修改Data的数据，故这里不使用ref T[] Data { get; }
        /// 获取数组数据，每次从原有的结构体数据上浅拷贝一个新的返回
        /// 与SetAsync方法联合调用，先从这里拿到结构体拷贝，然后Set
        /// </summary>
        TS Data { get; }

        T[] Get(int timeout = -1, CancellationToken token = default);

        bool TryGet(out T[] value, int timeout = -1, CancellationToken token = default);

        void Set(T[] value, int timeout = -1, CancellationToken token = default);

        bool TrySet(T[] value, int timeout = -1, CancellationToken token = default);

        Task<T[]> GetAsync(int timeout = -1, CancellationToken token = default);

        Task<ResultArray<T>> TryGetAsync(int timeout = -1, CancellationToken token = default);

        Task SetAsync(T[] value, int timeout = -1, CancellationToken token = default);

        Task<bool> TrySetAsync(T[] value, int timeout = -1, CancellationToken token = default);


        T GetItem(int index, int timeout = -1, CancellationToken token = default);

        bool TryGetItem(int index, out T value, int timeout = -1, CancellationToken token = default);

        void SetItem(int index, T value, int timeout = -1, CancellationToken token = default);

        bool TrySetItem(int index, T value, int timeout = -1, CancellationToken token = default);

        Task<T> GetItemAsync(int index, int timeout = -1, CancellationToken token = default);

        Task<Result<T>> TryGetItemAsync(int index, int timeout = -1, CancellationToken token = default);

        Task SetItemAsync(int index, T value, int timeout = -1, CancellationToken token = default);

        Task<bool> TrySetItemAsync(int index, T value, int timeout = -1, CancellationToken token = default);
    }
}
