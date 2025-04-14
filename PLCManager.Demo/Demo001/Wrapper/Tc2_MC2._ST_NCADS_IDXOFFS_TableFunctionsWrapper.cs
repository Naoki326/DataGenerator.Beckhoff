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
	/// Name from PLC:Tc2_MC2._ST_NCADS_IDXOFFS_TableFunctions
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 12
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2__ST_NCADS_IDXOFFS_TableFunctionsWrapper : BeckhoffStruct<Tc2_MC2__ST_NCADS_IDXOFFS_TableFunctionsWrapper, Tc2_MC2__ST_NCADS_IDXOFFS_TableFunctions>
	{
		
		public Tc2_MC2__ST_NCADS_IDXOFFS_TableFunctionsWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<uint> CREATETAB { get; init; }

		public IBaseData<uint> CREATEMOTIONTAB { get; init; }

		public IBaseData<uint> DELETETAB { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return CREATETAB;
			yield return CREATEMOTIONTAB;
			yield return DELETETAB;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(CREATETAB):
					return CREATETAB;
				case nameof(CREATEMOTIONTAB):
					return CREATEMOTIONTAB;
				case nameof(DELETETAB):
					return DELETETAB;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
