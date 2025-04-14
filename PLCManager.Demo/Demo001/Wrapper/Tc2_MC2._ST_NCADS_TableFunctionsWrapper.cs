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
	/// Name from PLC:Tc2_MC2._ST_NCADS_TableFunctions
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 16
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2__ST_NCADS_TableFunctionsWrapper : BeckhoffStruct<Tc2_MC2__ST_NCADS_TableFunctionsWrapper, Tc2_MC2__ST_NCADS_TableFunctions>
	{
		
		public Tc2_MC2__ST_NCADS_TableFunctionsWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<uint> IDXGRP { get; init; }

		public Tc2_MC2__ST_NCADS_IDXOFFS_TableFunctionsWrapper IDXOFFS { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return IDXGRP;
			yield return IDXOFFS;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(IDXGRP):
					return IDXGRP;
				case nameof(IDXOFFS):
					return IDXOFFS;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
