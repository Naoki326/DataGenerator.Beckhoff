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
	/// Name from PLC:Tc2_MC2._ST_NCADS_Axis
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 548
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2__ST_NCADS_AxisWrapper : BeckhoffStruct<Tc2_MC2__ST_NCADS_AxisWrapper, Tc2_MC2__ST_NCADS_Axis>
	{
		
		public Tc2_MC2__ST_NCADS_AxisWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public Tc2_MC2__ST_NCADS_AxisParameterWrapper Parameter { get; init; }

		public Tc2_MC2__ST_NCADS_AxisStateWrapper State { get; init; }

		public Tc2_MC2__ST_NCADS_AxisFunctionsWrapper Functions { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Parameter;
			yield return State;
			yield return Functions;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Parameter):
					return Parameter;
				case nameof(State):
					return State;
				case nameof(Functions):
					return Functions;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
