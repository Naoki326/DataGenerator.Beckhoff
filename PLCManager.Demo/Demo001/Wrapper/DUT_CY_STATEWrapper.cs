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
	/// Name from PLC:DUT_CY_STATE
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 3
	/// Comment from PLC: 
	/// <summary>
	public partial class DUT_CY_STATEWrapper : BeckhoffStruct<DUT_CY_STATEWrapper, DUT_CY_STATE>
	{
		
		public DUT_CY_STATEWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Out_Retract { get; init; }

		public IBaseData<bool> Out_Extend { get; init; }

		public IBaseData<bool> Out_Fault_Alarm { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Out_Retract;
			yield return Out_Extend;
			yield return Out_Fault_Alarm;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Out_Retract):
					return Out_Retract;
				case nameof(Out_Extend):
					return Out_Extend;
				case nameof(Out_Fault_Alarm):
					return Out_Fault_Alarm;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
