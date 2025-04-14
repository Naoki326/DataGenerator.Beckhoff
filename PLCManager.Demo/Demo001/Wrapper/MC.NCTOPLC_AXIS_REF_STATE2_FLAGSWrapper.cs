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
	/// Name from PLC:MC.NCTOPLC_AXIS_REF_STATE2_FLAGS
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 4
	/// Comment from PLC: 
	/// <summary>
	public partial class MC_NCTOPLC_AXIS_REF_STATE2_FLAGSWrapper : BeckhoffStruct<MC_NCTOPLC_AXIS_REF_STATE2_FLAGSWrapper, MC_NCTOPLC_AXIS_REF_STATE2_FLAGS>
	{
		
		public MC_NCTOPLC_AXIS_REF_STATE2_FLAGSWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> AvoidingCollision { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return AvoidingCollision;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(AvoidingCollision):
					return AvoidingCollision;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
