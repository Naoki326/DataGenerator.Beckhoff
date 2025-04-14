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
	/// Name from PLC:Tc2_MC2.MC_ReadAxisError
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 32
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_MC_ReadAxisErrorWrapper : BeckhoffStruct<Tc2_MC2_MC_ReadAxisErrorWrapper, Tc2_MC2_MC_ReadAxisError>
	{
		
		public Tc2_MC2_MC_ReadAxisErrorWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Enable { get; init; }

		public IBaseData<bool> Valid { get; init; }

		public IBaseData<bool> Busy { get; init; }

		public IBaseData<bool> Error { get; init; }

		public IBaseData<int> ErrorID { get; init; }

		public IBaseData<int> AxisErrorID { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Enable;
			yield return Valid;
			yield return Busy;
			yield return Error;
			yield return ErrorID;
			yield return AxisErrorID;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Enable):
					return Enable;
				case nameof(Valid):
					return Valid;
				case nameof(Busy):
					return Busy;
				case nameof(Error):
					return Error;
				case nameof(ErrorID):
					return ErrorID;
				case nameof(AxisErrorID):
					return AxisErrorID;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
