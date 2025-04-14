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
	/// Name from PLC:Tc2_MC2._FB_MoveUniversalGeneric
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 1064
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2__FB_MoveUniversalGenericWrapper : BeckhoffStruct<Tc2_MC2__FB_MoveUniversalGenericWrapper, Tc2_MC2__FB_MoveUniversalGeneric>
	{
		
		public Tc2_MC2__FB_MoveUniversalGenericWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Execute { get; init; }

		public IBaseData<Tc2_MC2__E_TcNC_StartPosType> StartType{ get; init; }

		public IBaseData<double> Position { get; init; }

		public IBaseData<double> Torque { get; init; }

		public IBaseData<double> TorqueRamp { get; init; }

		public IBaseData<double> Velocity { get; init; }

		public IBaseData<double> VelocityLimitHigh { get; init; }

		public IBaseData<double> VelocityLimitLow { get; init; }

		public IBaseData<double> Acceleration { get; init; }

		public IBaseData<double> Deceleration { get; init; }

		public IBaseData<double> Jerk { get; init; }

		public IBaseData<Tc2_MC2_MC_BufferMode> BufferMode{ get; init; }

		public Tc2_MC2_ST_MoveOptionsWrapper Options { get; init; }

		public Tc2_MC2_ST_TorqueControlOptionsWrapper OptionsTorque { get; init; }

		public IBaseData<bool> Reset { get; init; }

		public IBaseData<bool> GotoRunState { get; init; }

		public IBaseData<bool> ContinuousUpdate { get; init; }

		public IBaseData<bool> Done { get; init; }

		public IBaseData<bool> Busy { get; init; }

		public IBaseData<bool> Active { get; init; }

		public IBaseData<bool> CommandAborted { get; init; }

		public IBaseData<bool> Error { get; init; }

		public IBaseData<uint> ErrorID { get; init; }

		public IBaseData<ushort> CmdNo { get; init; }

		public IBaseData<bool> ADSbusy { get; init; }

		public IBaseData<bool> InTorque { get; init; }

		public IBaseData<Tc2_MC2__E_TcMC_STATES> iState{ get; init; }

		public Tc2_MC2__ST_TcNC_UnversalAxisStartRequestWrapper sStartRequest { get; init; }

		public Tc2_MC2__ST_TcNC_UniversalAxisTorqueStartRequestWrapper sTorqueStartRequest { get; init; }

		public Tc2_MC2__ST_TcNC_UnversalAxisStartResponseWrapper sStartResponse { get; init; }

		public Tc2_System_ADSRDWRTEXWrapper fbAdsReadWrite { get; init; }

		public IBaseData<bool> ContinousMode { get; init; }

		public IBaseData<bool> InVelocity { get; init; }

		public IBaseData<uint> DiffCycleCounter { get; init; }

		public Tc2_MC2__ST_TcNC_UnversalAxisStartResponseWrapper EmptyStartResponse { get; init; }

		public IBaseData<uint> COUNT_R { get; init; }

		public IBaseData<byte> CounterCmdNoZero { get; init; }

		public IBaseData<byte> CounterCmdNotStarted { get; init; }

		public IBaseData<short> DiffCmdNo { get; init; }

		public IBaseData<ushort> InitialNcToPlcCmdNo { get; init; }

		public IBaseData<byte> NcCycleCounter { get; init; }

		public IBaseData<byte> LastNcCycleCounter { get; init; }

		public IBaseData<byte> NcMappingCounter { get; init; }

		public IBaseData<bool> NcCycleCounterAvailable { get; init; }

		public IBaseData<bool> NcCycleCounterNotAvailable { get; init; }

		public IBaseData<bool> NcCyclicFeedbackExpected { get; init; }

		public IBaseData<int> PlcDebugCode { get; init; }

		public IBaseData<bool> AxisIsSlave { get; init; }

		public Tc2_System_GETCURTASKINDEXWrapper GetTaskIndex { get; init; }

		public IBaseData<uint> CycleCounter { get; init; }

		public IBaseData<uint> BusyCounter { get; init; }

		public Tc2_Standard_TONWrapper fbTimeOut { get; init; }

		public Tc2_Standard_TONWrapper fbStopMonitoringTimeOut { get; init; }

		public Tc2_Standard_TONWrapper fbTimeOutMappingCounter { get; init; }

		public Tc2_Standard_R_TRIGWrapper fbOnTrigger { get; init; }

		public IBaseString sTempMsg{ get; init; }

		public IBaseData<bool> AccDecreasing { get; init; }

		public IBaseData<double> AccOld { get; init; }

		public IBaseData<bool> iContinuousUpdate { get; init; }

		public Tc2_MC2__ST_TcNc_OperationModesWrapper OpMode { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Execute;
			yield return StartType;
			yield return Position;
			yield return Torque;
			yield return TorqueRamp;
			yield return Velocity;
			yield return VelocityLimitHigh;
			yield return VelocityLimitLow;
			yield return Acceleration;
			yield return Deceleration;
			yield return Jerk;
			yield return BufferMode;
			yield return Options;
			yield return OptionsTorque;
			yield return Reset;
			yield return GotoRunState;
			yield return ContinuousUpdate;
			yield return Done;
			yield return Busy;
			yield return Active;
			yield return CommandAborted;
			yield return Error;
			yield return ErrorID;
			yield return CmdNo;
			yield return ADSbusy;
			yield return InTorque;
			yield return iState;
			yield return sStartRequest;
			yield return sTorqueStartRequest;
			yield return sStartResponse;
			yield return fbAdsReadWrite;
			yield return ContinousMode;
			yield return InVelocity;
			yield return DiffCycleCounter;
			yield return EmptyStartResponse;
			yield return COUNT_R;
			yield return CounterCmdNoZero;
			yield return CounterCmdNotStarted;
			yield return DiffCmdNo;
			yield return InitialNcToPlcCmdNo;
			yield return NcCycleCounter;
			yield return LastNcCycleCounter;
			yield return NcMappingCounter;
			yield return NcCycleCounterAvailable;
			yield return NcCycleCounterNotAvailable;
			yield return NcCyclicFeedbackExpected;
			yield return PlcDebugCode;
			yield return AxisIsSlave;
			yield return GetTaskIndex;
			yield return CycleCounter;
			yield return BusyCounter;
			yield return fbTimeOut;
			yield return fbStopMonitoringTimeOut;
			yield return fbTimeOutMappingCounter;
			yield return fbOnTrigger;
			yield return sTempMsg;
			yield return AccDecreasing;
			yield return AccOld;
			yield return iContinuousUpdate;
			yield return OpMode;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Execute):
					return Execute;
				case nameof(StartType):
					return StartType;
				case nameof(Position):
					return Position;
				case nameof(Torque):
					return Torque;
				case nameof(TorqueRamp):
					return TorqueRamp;
				case nameof(Velocity):
					return Velocity;
				case nameof(VelocityLimitHigh):
					return VelocityLimitHigh;
				case nameof(VelocityLimitLow):
					return VelocityLimitLow;
				case nameof(Acceleration):
					return Acceleration;
				case nameof(Deceleration):
					return Deceleration;
				case nameof(Jerk):
					return Jerk;
				case nameof(BufferMode):
					return BufferMode;
				case nameof(Options):
					return Options;
				case nameof(OptionsTorque):
					return OptionsTorque;
				case nameof(Reset):
					return Reset;
				case nameof(GotoRunState):
					return GotoRunState;
				case nameof(ContinuousUpdate):
					return ContinuousUpdate;
				case nameof(Done):
					return Done;
				case nameof(Busy):
					return Busy;
				case nameof(Active):
					return Active;
				case nameof(CommandAborted):
					return CommandAborted;
				case nameof(Error):
					return Error;
				case nameof(ErrorID):
					return ErrorID;
				case nameof(CmdNo):
					return CmdNo;
				case nameof(ADSbusy):
					return ADSbusy;
				case nameof(InTorque):
					return InTorque;
				case nameof(iState):
					return iState;
				case nameof(sStartRequest):
					return sStartRequest;
				case nameof(sTorqueStartRequest):
					return sTorqueStartRequest;
				case nameof(sStartResponse):
					return sStartResponse;
				case nameof(fbAdsReadWrite):
					return fbAdsReadWrite;
				case nameof(ContinousMode):
					return ContinousMode;
				case nameof(InVelocity):
					return InVelocity;
				case nameof(DiffCycleCounter):
					return DiffCycleCounter;
				case nameof(EmptyStartResponse):
					return EmptyStartResponse;
				case nameof(COUNT_R):
					return COUNT_R;
				case nameof(CounterCmdNoZero):
					return CounterCmdNoZero;
				case nameof(CounterCmdNotStarted):
					return CounterCmdNotStarted;
				case nameof(DiffCmdNo):
					return DiffCmdNo;
				case nameof(InitialNcToPlcCmdNo):
					return InitialNcToPlcCmdNo;
				case nameof(NcCycleCounter):
					return NcCycleCounter;
				case nameof(LastNcCycleCounter):
					return LastNcCycleCounter;
				case nameof(NcMappingCounter):
					return NcMappingCounter;
				case nameof(NcCycleCounterAvailable):
					return NcCycleCounterAvailable;
				case nameof(NcCycleCounterNotAvailable):
					return NcCycleCounterNotAvailable;
				case nameof(NcCyclicFeedbackExpected):
					return NcCyclicFeedbackExpected;
				case nameof(PlcDebugCode):
					return PlcDebugCode;
				case nameof(AxisIsSlave):
					return AxisIsSlave;
				case nameof(GetTaskIndex):
					return GetTaskIndex;
				case nameof(CycleCounter):
					return CycleCounter;
				case nameof(BusyCounter):
					return BusyCounter;
				case nameof(fbTimeOut):
					return fbTimeOut;
				case nameof(fbStopMonitoringTimeOut):
					return fbStopMonitoringTimeOut;
				case nameof(fbTimeOutMappingCounter):
					return fbTimeOutMappingCounter;
				case nameof(fbOnTrigger):
					return fbOnTrigger;
				case nameof(sTempMsg):
					return sTempMsg;
				case nameof(AccDecreasing):
					return AccDecreasing;
				case nameof(AccOld):
					return AccOld;
				case nameof(iContinuousUpdate):
					return iContinuousUpdate;
				case nameof(OpMode):
					return OpMode;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
