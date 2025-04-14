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
	/// Name from PLC:DUT_CY_CMD
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 6
	/// Comment from PLC: 
	/// <summary>
	public partial class DUT_CY_CMDWrapper : BeckhoffStruct<DUT_CY_CMDWrapper, DUT_CY_CMD>
	{
		
		public DUT_CY_CMDWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Extend_CMD { get; init; }

		public IBaseData<bool> Retract_CMD { get; init; }

		public IBaseData<bool> CY_PL { get; init; }

		public IBaseData<bool> CY_NL { get; init; }

		public IBaseData<ushort> Coil_Num { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Extend_CMD;
			yield return Retract_CMD;
			yield return CY_PL;
			yield return CY_NL;
			yield return Coil_Num;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Extend_CMD):
					return Extend_CMD;
				case nameof(Retract_CMD):
					return Retract_CMD;
				case nameof(CY_PL):
					return CY_PL;
				case nameof(CY_NL):
					return CY_NL;
				case nameof(Coil_Num):
					return Coil_Num;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
