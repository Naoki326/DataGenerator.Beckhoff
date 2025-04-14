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
	/// Name from PLC:MC.NCTOPLC_AXIS_REF_STATE3_FLAGS
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 4
	/// Comment from PLC: 
	/// <summary>
	public partial class MC_NCTOPLC_AXIS_REF_STATE3_FLAGSWrapper : BeckhoffStruct<MC_NCTOPLC_AXIS_REF_STATE3_FLAGSWrapper, MC_NCTOPLC_AXIS_REF_STATE3_FLAGS>
	{
		
		public MC_NCTOPLC_AXIS_REF_STATE3_FLAGSWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> TouchProbe1InputState  { get; init; }

		public IBaseData<bool> TouchProbe2InputState  { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return TouchProbe1InputState ;
			yield return TouchProbe2InputState ;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(TouchProbe1InputState ):
					return TouchProbe1InputState ;
				case nameof(TouchProbe2InputState ):
					return TouchProbe2InputState ;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
