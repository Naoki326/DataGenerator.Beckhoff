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
	/// Name from PLC:Tc2_MC2._ST_TcNC_UnversalAxisStartRequest
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 80
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2__ST_TcNC_UnversalAxisStartRequestWrapper : BeckhoffStruct<Tc2_MC2__ST_TcNC_UnversalAxisStartRequestWrapper, Tc2_MC2__ST_TcNC_UnversalAxisStartRequest>
	{
		
		public Tc2_MC2__ST_TcNC_UnversalAxisStartRequestWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<uint> nStartType { get; init; }

		public IBaseData<uint> nControlMask { get; init; }

		public IBaseData<double> fPosTarget { get; init; }

		public IBaseData<double> fVeloRequ { get; init; }

		public IBaseData<double> fAcc { get; init; }

		public IBaseData<double> fDec { get; init; }

		public IBaseData<double> fJerk { get; init; }

		public IBaseData<uint> nBufferMode { get; init; }

		public IBaseData<uint> nReserved { get; init; }

		public IBaseData<double> fBlendingPosition { get; init; }

		public IBaseData<double> fVeloStart { get; init; }

		public IBaseData<double> fVeloEnd { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return nStartType;
			yield return nControlMask;
			yield return fPosTarget;
			yield return fVeloRequ;
			yield return fAcc;
			yield return fDec;
			yield return fJerk;
			yield return nBufferMode;
			yield return nReserved;
			yield return fBlendingPosition;
			yield return fVeloStart;
			yield return fVeloEnd;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(nStartType):
					return nStartType;
				case nameof(nControlMask):
					return nControlMask;
				case nameof(fPosTarget):
					return fPosTarget;
				case nameof(fVeloRequ):
					return fVeloRequ;
				case nameof(fAcc):
					return fAcc;
				case nameof(fDec):
					return fDec;
				case nameof(fJerk):
					return fJerk;
				case nameof(nBufferMode):
					return nBufferMode;
				case nameof(nReserved):
					return nReserved;
				case nameof(fBlendingPosition):
					return fBlendingPosition;
				case nameof(fVeloStart):
					return fVeloStart;
				case nameof(fVeloEnd):
					return fVeloEnd;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
