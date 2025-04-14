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
	/// Name from PLC:MC.NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 1
	/// Comment from PLC: 
	/// <summary>
	public partial class MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATEWrapper : BeckhoffStruct<MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATEWrapper, MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE>
	{
		
		public MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATEWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> CamActivationPending { get; init; }

		public IBaseData<bool> CamDeactivationPending { get; init; }

		public IBaseData<bool> CamActive { get; init; }

		public IBaseData<bool> CamDataQueued { get; init; }

		public IBaseData<bool> CamScalingPending { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return CamActivationPending;
			yield return CamDeactivationPending;
			yield return CamActive;
			yield return CamDataQueued;
			yield return CamScalingPending;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(CamActivationPending):
					return CamActivationPending;
				case nameof(CamDeactivationPending):
					return CamDeactivationPending;
				case nameof(CamActive):
					return CamActive;
				case nameof(CamDataQueued):
					return CamDataQueued;
				case nameof(CamScalingPending):
					return CamScalingPending;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
