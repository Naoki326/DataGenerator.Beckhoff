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
	/// Name from PLC:MC.NCTOPLC_AXIS_REF
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 256
	/// Comment from PLC: 
	/// <summary>
	public partial class MC_NCTOPLC_AXIS_REFWrapper : BeckhoffStruct<MC_NCTOPLC_AXIS_REFWrapper, MC_NCTOPLC_AXIS_REF>
	{
		
		public MC_NCTOPLC_AXIS_REFWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public MC_NCTOPLC_AXIS_REF_STATEWrapper StateDWord { get; init; }

		public IBaseData<uint> ErrorCode { get; init; }

		public IBaseData<uint> AxisState { get; init; }

		public IBaseData<uint> AxisModeConfirmation { get; init; }

		public IBaseData<uint> HomingState { get; init; }

		public IBaseData<uint> CoupleState { get; init; }

		public IBaseData<uint> SvbEntries { get; init; }

		public IBaseData<uint> SafEntries { get; init; }

		public IBaseData<uint> AxisId { get; init; }

		public MC_NCTOPLC_AXIS_REF_OPMODEWrapper OpModeDWord { get; init; }

		public IBaseData<double> ActPos { get; init; }

		public IBaseData<double> ModuloActPos { get; init; }

		public IBaseData<ushort> ActiveControlLoopIndex { get; init; }

		public IBaseData<ushort> ControlLoopIndex { get; init; }

		public IBaseData<int> ModuloActTurns { get; init; }

		public IBaseData<double> ActVelo { get; init; }

		public IBaseData<double> PosDiff { get; init; }

		public IBaseData<double> SetPos { get; init; }

		public IBaseData<double> SetVelo { get; init; }

		public IBaseData<double> SetAcc { get; init; }

		public IBaseData<double> TargetPos { get; init; }

		public IBaseData<double> ModuloSetPos { get; init; }

		public IBaseData<int> ModuloSetTurns { get; init; }

		public IBaseData<ushort> CmdNo { get; init; }

		public IBaseData<ushort> CmdState { get; init; }

		public IBaseData<double> SetJerk { get; init; }

		public IBaseData<double> SetTorque { get; init; }

		public IBaseData<double> ActTorque { get; init; }

		public IBaseData<int> TouchProbeState { get; init; }

		public IBaseData<int> TouchProbeCounter { get; init; }

		public IStructArray<MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE8, MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATEWrapper, MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE> CamCouplingState{ get; init; }

		public IBaseArray<UShort8, ushort> CamCouplingTableID{ get; init; }

		public IBaseData<double> ActTorqueDerivative { get; init; }

		public IBaseData<double> SetTorqueDerivative { get; init; }

		public IBaseData<double> AbsPhasingPos { get; init; }

		public IBaseData<double> TorqueOffset { get; init; }

		public IBaseData<double> ActPosWithoutPosCorrection { get; init; }

		public IBaseData<double> ActAcc { get; init; }

		public IBaseData<uint> DcTimeStamp { get; init; }

		public IBaseData<double> UserData { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return StateDWord;
			yield return ErrorCode;
			yield return AxisState;
			yield return AxisModeConfirmation;
			yield return HomingState;
			yield return CoupleState;
			yield return SvbEntries;
			yield return SafEntries;
			yield return AxisId;
			yield return OpModeDWord;
			yield return ActPos;
			yield return ModuloActPos;
			yield return ActiveControlLoopIndex;
			yield return ControlLoopIndex;
			yield return ModuloActTurns;
			yield return ActVelo;
			yield return PosDiff;
			yield return SetPos;
			yield return SetVelo;
			yield return SetAcc;
			yield return TargetPos;
			yield return ModuloSetPos;
			yield return ModuloSetTurns;
			yield return CmdNo;
			yield return CmdState;
			yield return SetJerk;
			yield return SetTorque;
			yield return ActTorque;
			yield return TouchProbeState;
			yield return TouchProbeCounter;
			yield return CamCouplingState;
			yield return CamCouplingTableID;
			yield return ActTorqueDerivative;
			yield return SetTorqueDerivative;
			yield return AbsPhasingPos;
			yield return TorqueOffset;
			yield return ActPosWithoutPosCorrection;
			yield return ActAcc;
			yield return DcTimeStamp;
			yield return UserData;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(StateDWord):
					return StateDWord;
				case nameof(ErrorCode):
					return ErrorCode;
				case nameof(AxisState):
					return AxisState;
				case nameof(AxisModeConfirmation):
					return AxisModeConfirmation;
				case nameof(HomingState):
					return HomingState;
				case nameof(CoupleState):
					return CoupleState;
				case nameof(SvbEntries):
					return SvbEntries;
				case nameof(SafEntries):
					return SafEntries;
				case nameof(AxisId):
					return AxisId;
				case nameof(OpModeDWord):
					return OpModeDWord;
				case nameof(ActPos):
					return ActPos;
				case nameof(ModuloActPos):
					return ModuloActPos;
				case nameof(ActiveControlLoopIndex):
					return ActiveControlLoopIndex;
				case nameof(ControlLoopIndex):
					return ControlLoopIndex;
				case nameof(ModuloActTurns):
					return ModuloActTurns;
				case nameof(ActVelo):
					return ActVelo;
				case nameof(PosDiff):
					return PosDiff;
				case nameof(SetPos):
					return SetPos;
				case nameof(SetVelo):
					return SetVelo;
				case nameof(SetAcc):
					return SetAcc;
				case nameof(TargetPos):
					return TargetPos;
				case nameof(ModuloSetPos):
					return ModuloSetPos;
				case nameof(ModuloSetTurns):
					return ModuloSetTurns;
				case nameof(CmdNo):
					return CmdNo;
				case nameof(CmdState):
					return CmdState;
				case nameof(SetJerk):
					return SetJerk;
				case nameof(SetTorque):
					return SetTorque;
				case nameof(ActTorque):
					return ActTorque;
				case nameof(TouchProbeState):
					return TouchProbeState;
				case nameof(TouchProbeCounter):
					return TouchProbeCounter;
				case nameof(CamCouplingState):
					return CamCouplingState;
				case nameof(CamCouplingTableID):
					return CamCouplingTableID;
				case nameof(ActTorqueDerivative):
					return ActTorqueDerivative;
				case nameof(SetTorqueDerivative):
					return SetTorqueDerivative;
				case nameof(AbsPhasingPos):
					return AbsPhasingPos;
				case nameof(TorqueOffset):
					return TorqueOffset;
				case nameof(ActPosWithoutPosCorrection):
					return ActPosWithoutPosCorrection;
				case nameof(ActAcc):
					return ActAcc;
				case nameof(DcTimeStamp):
					return DcTimeStamp;
				case nameof(UserData):
					return UserData;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
