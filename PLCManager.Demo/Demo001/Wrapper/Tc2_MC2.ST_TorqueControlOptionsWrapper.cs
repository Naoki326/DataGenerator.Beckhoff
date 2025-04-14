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
	/// Name from PLC:Tc2_MC2.ST_TorqueControlOptions
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 16
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_ST_TorqueControlOptionsWrapper : BeckhoffStruct<Tc2_MC2_ST_TorqueControlOptionsWrapper, Tc2_MC2_ST_TorqueControlOptions>
	{
		
		public Tc2_MC2_ST_TorqueControlOptionsWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> EnableManualTorqueStartValue { get; init; }

		public IBaseData<double> ManualTorqueStartValue { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return EnableManualTorqueStartValue;
			yield return ManualTorqueStartValue;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(EnableManualTorqueStartValue):
					return EnableManualTorqueStartValue;
				case nameof(ManualTorqueStartValue):
					return ManualTorqueStartValue;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
