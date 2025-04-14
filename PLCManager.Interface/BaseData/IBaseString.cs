using System;
using System.Threading;
using System.Threading.Tasks;

namespace PlcCore.Data
{
    public interface IBaseString : IBaseData, IObservable<string>, IDisposable
    {
        string Data { get; }

        int Length { get; }

        string Get(int timeout = -1, CancellationToken token = default);

        bool TryGet(out string value, int timeout = -1, CancellationToken token = default);

        void Set(string value, int timeout = -1, CancellationToken token = default);

        bool TrySet(string value, int timeout = -1, CancellationToken token = default);

        Task<string> GetAsync(int timeout = -1, CancellationToken token = default);

        Task<BaseResult<string>> TryGetAsync(int timeout = -1, CancellationToken token = default);

        Task SetAsync(string value, int timeout = -1, CancellationToken token = default);

        Task<bool> TrySetAsync(string value, int timeout = -1, CancellationToken token = default);
    }
}
