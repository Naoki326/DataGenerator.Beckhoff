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
	/// Name from PLC:Tc2_MC2._ST_TcNC_SetPosOnTheFly
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 32
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2__ST_TcNC_SetPosOnTheFlyWrapper : BeckhoffStruct<Tc2_MC2__ST_TcNC_SetPosOnTheFlyWrapper, Tc2_MC2__ST_TcNC_SetPosOnTheFly>
	{
		
		public Tc2_MC2__ST_TcNC_SetPosOnTheFlyWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<uint> nPosSetType { get; init; }

		public IBaseData<uint> nCtrlDWord { get; init; }

		public IBaseData<double> fPreviousActualPos { get; init; }

		public IBaseData<double> fNewActualPos { get; init; }

		public IBaseArray<Int2, int> nReserved{ get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return nPosSetType;
			yield return nCtrlDWord;
			yield return fPreviousActualPos;
			yield return fNewActualPos;
			yield return nReserved;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(nPosSetType):
					return nPosSetType;
				case nameof(nCtrlDWord):
					return nCtrlDWord;
				case nameof(fPreviousActualPos):
					return fPreviousActualPos;
				case nameof(fNewActualPos):
					return fNewActualPos;
				case nameof(nReserved):
					return nReserved;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
