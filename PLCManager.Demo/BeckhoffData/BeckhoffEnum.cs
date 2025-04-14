using System.Threading;
using System.Threading.Tasks;
using PlcCore.Data;
using TwinCAT.Ads;

namespace PlcCore.Beckhoff
{
    public class BeckhoffEnum<T> : BeckhoffBase<T>, IBaseData where T : struct
    {
        public BeckhoffEnum(GetDataDel getData, AdsClient client, uint indexGroup, uint indexOffset) : base(getData, client, indexGroup, indexOffset)
        {
        }
    }
}