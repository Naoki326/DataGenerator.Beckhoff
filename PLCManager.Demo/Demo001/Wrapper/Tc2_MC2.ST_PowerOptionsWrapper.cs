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
	/// Name from PLC:Tc2_MC2.ST_PowerOptions
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 1
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_ST_PowerOptionsWrapper : BeckhoffStruct<Tc2_MC2_ST_PowerOptionsWrapper, Tc2_MC2_ST_PowerOptions>
	{
		
		public Tc2_MC2_ST_PowerOptionsWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> reserved { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return reserved;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(reserved):
					return reserved;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
