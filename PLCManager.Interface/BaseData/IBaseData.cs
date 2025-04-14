using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace PlcCore.Data
{
    public interface IBaseData : IDisposable
    {
        IBaseData Parent { get; }

        bool SelfNotify { get; set; }

        void Refresh(int timeout = -1, CancellationToken token = default);

        void CheckAndNotify(int timeout = -1, CancellationToken token = default);

        IEnumerable<IBaseData> Children { get; }

        IBaseData Get(string name);

        string Name { get; }
    }

    /// <summary>
    /// 基础类型的数据
    /// 只包括：BOOL、BYTE、UINT、INT、UDINT、DINT、REAL、LREAL、[STRING]
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
    /// <typeparam name="T">基础类型</typeparam>
    public interface IBaseData<T> : IBaseData, IObservable<T>, IDisposable where T : struct
    {
        // 上一次Get到的数据，保存在这里，在不需要获取真实值的场景下使用
        T Data { get; }

        T Get(int timeout = -1, CancellationToken token = default);

        bool TryGet(out T value, int timeout = -1, CancellationToken token = default);

        void Set(T value, int timeout = -1, CancellationToken token = default);

        bool TrySet(T value, int timeout = -1, CancellationToken token = default);

        Task<T> GetAsync(int timeout = -1, CancellationToken token = default);

        Task<Result<T>> TryGetAsync(int timeout = -1, CancellationToken token = default);

        Task SetAsync(T value, int timeout = -1, CancellationToken token = default);

        Task<bool> TrySetAsync(T value, int timeout = -1, CancellationToken token = default);
    }
}
