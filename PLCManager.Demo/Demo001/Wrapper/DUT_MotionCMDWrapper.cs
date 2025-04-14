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
	/// Name from PLC:DUT_MotionCMD
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 104
	/// Comment from PLC: 
	/// <summary>
	public partial class DUT_MotionCMDWrapper : BeckhoffStruct<DUT_MotionCMDWrapper, DUT_MotionCMD>
	{
		
		public DUT_MotionCMDWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> bEnable { get; init; }

		public IBaseData<bool> bPosLim { get; init; }

		public IBaseData<bool> bNegLim { get; init; }

		public IBaseData<double> rOverRide { get; init; }

		public IBaseData<bool> bHomeStart { get; init; }

		public IBaseData<bool> bRefCam { get; init; }

		public IBaseData<bool> bStop { get; init; }

		public IBaseData<bool> bHalt { get; init; }

		public IBaseData<bool> bReset { get; init; }

		public IBaseData<bool> bSetPostion { get; init; }

		public IBaseData<double> rSetPositon { get; init; }

		public IBaseData<bool> bJogPlus { get; init; }

		public IBaseData<bool> bJogMin { get; init; }

		public IBaseData<Tc2_MC2_E_JogMode> nJogMode{ get; init; }

		public IBaseData<double> rInchPos { get; init; }

		public IBaseData<double> rJogVelo { get; init; }

		public IBaseData<bool> bMoveVeloStart { get; init; }

		public IBaseData<double> rSetVelo { get; init; }

		public IBaseData<bool> bMoveAbsStart { get; init; }

		public IBaseData<double> rMoveAbsSetPos { get; init; }

		public IBaseData<bool> bMoveRelativeStart { get; init; }

		public IBaseData<double> rMoveRelativeSetPos { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return bEnable;
			yield return bPosLim;
			yield return bNegLim;
			yield return rOverRide;
			yield return bHomeStart;
			yield return bRefCam;
			yield return bStop;
			yield return bHalt;
			yield return bReset;
			yield return bSetPostion;
			yield return rSetPositon;
			yield return bJogPlus;
			yield return bJogMin;
			yield return nJogMode;
			yield return rInchPos;
			yield return rJogVelo;
			yield return bMoveVeloStart;
			yield return rSetVelo;
			yield return bMoveAbsStart;
			yield return rMoveAbsSetPos;
			yield return bMoveRelativeStart;
			yield return rMoveRelativeSetPos;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(bEnable):
					return bEnable;
				case nameof(bPosLim):
					return bPosLim;
				case nameof(bNegLim):
					return bNegLim;
				case nameof(rOverRide):
					return rOverRide;
				case nameof(bHomeStart):
					return bHomeStart;
				case nameof(bRefCam):
					return bRefCam;
				case nameof(bStop):
					return bStop;
				case nameof(bHalt):
					return bHalt;
				case nameof(bReset):
					return bReset;
				case nameof(bSetPostion):
					return bSetPostion;
				case nameof(rSetPositon):
					return rSetPositon;
				case nameof(bJogPlus):
					return bJogPlus;
				case nameof(bJogMin):
					return bJogMin;
				case nameof(nJogMode):
					return nJogMode;
				case nameof(rInchPos):
					return rInchPos;
				case nameof(rJogVelo):
					return rJogVelo;
				case nameof(bMoveVeloStart):
					return bMoveVeloStart;
				case nameof(rSetVelo):
					return rSetVelo;
				case nameof(bMoveAbsStart):
					return bMoveAbsStart;
				case nameof(rMoveAbsSetPos):
					return rMoveAbsSetPos;
				case nameof(bMoveRelativeStart):
					return bMoveRelativeStart;
				case nameof(rMoveRelativeSetPos):
					return rMoveRelativeSetPos;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
