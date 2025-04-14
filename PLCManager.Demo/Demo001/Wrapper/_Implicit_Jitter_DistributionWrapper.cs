using System.Runtime.InteropServices;
using System.Collections.Generic;
using TwinCAT.Ads;
using PLCManager.Demo.Enum;
using PLCManager.Demo.Struct;
using PlcCore.Beckhoff;
using PlcCore.Data;

namespace PLCManager.Demo.Wrapper
{
	/// <summary>
	/// Name from PLC:_Implicit_Jitter_Distribution
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 6
	/// Comment from PLC: 
	/// <summary>
	public partial class _Implicit_Jitter_DistributionWrapper : BeckhoffStruct<_Implicit_Jitter_DistributionWrapper, _Implicit_Jitter_Distribution>
	{
		
		public _Implicit_Jitter_DistributionWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<short> wRangeMax { get; init; }

		public IBaseData<short> wCountJitterNeg { get; init; }

		public IBaseData<short> wCountJitterPos { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return wRangeMax;
			yield return wCountJitterNeg;
			yield return wCountJitterPos;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(wRangeMax):
					return wRangeMax;
				case nameof(wCountJitterNeg):
					return wCountJitterNeg;
				case nameof(wCountJitterPos):
					return wCountJitterPos;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
