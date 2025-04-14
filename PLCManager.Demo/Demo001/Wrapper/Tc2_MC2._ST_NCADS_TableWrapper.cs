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
	/// Name from PLC:Tc2_MC2._ST_NCADS_Table
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 44
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2__ST_NCADS_TableWrapper : BeckhoffStruct<Tc2_MC2__ST_NCADS_TableWrapper, Tc2_MC2__ST_NCADS_Table>
	{
		
		public Tc2_MC2__ST_NCADS_TableWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public Tc2_MC2__ST_NCADS_TableParameterWrapper Parameter { get; init; }

		public Tc2_MC2__ST_NCADS_TableFunctionsWrapper Functions { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Parameter;
			yield return Functions;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Parameter):
					return Parameter;
				case nameof(Functions):
					return Functions;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
