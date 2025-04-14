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
	/// Name from PLC:MC.PLCTONC_AXIS_REF_CTRL
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 4
	/// Comment from PLC: 
	/// <summary>
	public partial class MC_PLCTONC_AXIS_REF_CTRLWrapper : BeckhoffStruct<MC_PLCTONC_AXIS_REF_CTRLWrapper, MC_PLCTONC_AXIS_REF_CTRL>
	{
		
		public MC_PLCTONC_AXIS_REF_CTRLWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Enable { get; init; }

		public IBaseData<bool> FeedEnablePlus { get; init; }

		public IBaseData<bool> FeedEnableMinus { get; init; }

		public IBaseData<bool> HomingSensor { get; init; }

		public IBaseData<bool> AcceptBlockedDrive { get; init; }

		public IBaseData<bool> PlcDebugFlag { get; init; }

		public IBaseData<bool> NcDebugFlag { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Enable;
			yield return FeedEnablePlus;
			yield return FeedEnableMinus;
			yield return HomingSensor;
			yield return AcceptBlockedDrive;
			yield return PlcDebugFlag;
			yield return NcDebugFlag;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Enable):
					return Enable;
				case nameof(FeedEnablePlus):
					return FeedEnablePlus;
				case nameof(FeedEnableMinus):
					return FeedEnableMinus;
				case nameof(HomingSensor):
					return HomingSensor;
				case nameof(AcceptBlockedDrive):
					return AcceptBlockedDrive;
				case nameof(PlcDebugFlag):
					return PlcDebugFlag;
				case nameof(NcDebugFlag):
					return NcDebugFlag;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
