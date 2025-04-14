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
	/// Name from PLC:Tc2_MC2.MC_ReadActualPosition
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 32
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_MC_ReadActualPositionWrapper : BeckhoffStruct<Tc2_MC2_MC_ReadActualPositionWrapper, Tc2_MC2_MC_ReadActualPosition>
	{
		
		public Tc2_MC2_MC_ReadActualPositionWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Enable { get; init; }

		public IBaseData<bool> Valid { get; init; }

		public IBaseData<bool> Busy { get; init; }

		public IBaseData<bool> Error { get; init; }

		public IBaseData<uint> ErrorID { get; init; }

		public IBaseData<double> Position { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Enable;
			yield return Valid;
			yield return Busy;
			yield return Error;
			yield return ErrorID;
			yield return Position;
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
				case nameof(Position):
					return Position;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
