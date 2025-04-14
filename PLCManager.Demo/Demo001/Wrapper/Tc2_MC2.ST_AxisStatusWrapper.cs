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
	/// Name from PLC:Tc2_MC2.ST_AxisStatus
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 96
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_ST_AxisStatusWrapper : BeckhoffStruct<Tc2_MC2_ST_AxisStatusWrapper, Tc2_MC2_ST_AxisStatus>
	{
		
		public Tc2_MC2_ST_AxisStatusWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<byte> UpdateTaskIndex { get; init; }

		public IBaseData<double> UpdateCycleTime { get; init; }

		public IBaseData<uint> CycleCounter { get; init; }

		public IBaseData<uint> NcCycleCounter { get; init; }

		public IBaseData<Tc2_MC2_MC_AxisStates> MotionState{ get; init; }

		public IBaseData<bool> Error { get; init; }

		public IBaseData<uint> ErrorID { get; init; }

		public IBaseData<bool> ErrorStop { get; init; }

		public IBaseData<bool> Disabled { get; init; }

		public IBaseData<bool> Stopping { get; init; }

		public IBaseData<bool> StandStill { get; init; }

		public IBaseData<bool> DiscreteMotion { get; init; }

		public IBaseData<bool> ContinuousMotion { get; init; }

		public IBaseData<bool> SynchronizedMotion { get; init; }

		public IBaseData<bool> Homing { get; init; }

		public IBaseData<bool> ConstantVelocity { get; init; }

		public IBaseData<bool> Accelerating { get; init; }

		public IBaseData<bool> Decelerating { get; init; }

		public IBaseData<bool> Operational { get; init; }

		public IBaseData<bool> ControlLoopClosed { get; init; }

		public IBaseData<bool> HasJob { get; init; }

		public IBaseData<bool> HasBeenStopped { get; init; }

		public IBaseData<bool> NewTargetPosition { get; init; }

		public IBaseData<bool> InPositionArea { get; init; }

		public IBaseData<bool> InTargetPosition { get; init; }

		public IBaseData<bool> ProtectedMode { get; init; }

		public IBaseData<bool> Homed { get; init; }

		public IBaseData<bool> HomingBusy { get; init; }

		public IBaseData<bool> MotionCommandsLocked { get; init; }

		public IBaseData<bool> SoftLimitMinExceeded { get; init; }

		public IBaseData<bool> SoftLimitMaxExceeded { get; init; }

		public IBaseData<bool> Moving { get; init; }

		public IBaseData<bool> PositiveDirection { get; init; }

		public IBaseData<bool> NegativeDirection { get; init; }

		public IBaseData<bool> NotMoving { get; init; }

		public IBaseData<bool> Compensating { get; init; }

		public IBaseData<bool> ExtSetPointGenEnabled { get; init; }

		public IBaseData<bool> PhasingActive { get; init; }

		public IBaseData<bool> ExternalLatchValid { get; init; }

		public IBaseData<bool> CamDataQueued { get; init; }

		public IBaseData<bool> CamTableQueued { get; init; }

		public IBaseData<bool> CamScalingPending { get; init; }

		public IBaseData<bool> CmdBuffered { get; init; }

		public IBaseData<bool> PTPmode { get; init; }

		public IBaseData<bool> DriveDeviceError { get; init; }

		public IBaseData<bool> IoDataInvalid { get; init; }

		public IBaseData<bool> ErrorPropagationDelayed { get; init; }

		public IBaseData<bool> DriveLimitActive { get; init; }

		public IBaseData<bool> TargetTorqueReached { get; init; }

		public IBaseData<bool> Coupled { get; init; }

		public Tc2_MC2_ST_AxisOpModesWrapper OpMode { get; init; }

		public IBaseData<bool> NcApplicationRequest { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return UpdateTaskIndex;
			yield return UpdateCycleTime;
			yield return CycleCounter;
			yield return NcCycleCounter;
			yield return MotionState;
			yield return Error;
			yield return ErrorID;
			yield return ErrorStop;
			yield return Disabled;
			yield return Stopping;
			yield return StandStill;
			yield return DiscreteMotion;
			yield return ContinuousMotion;
			yield return SynchronizedMotion;
			yield return Homing;
			yield return ConstantVelocity;
			yield return Accelerating;
			yield return Decelerating;
			yield return Operational;
			yield return ControlLoopClosed;
			yield return HasJob;
			yield return HasBeenStopped;
			yield return NewTargetPosition;
			yield return InPositionArea;
			yield return InTargetPosition;
			yield return ProtectedMode;
			yield return Homed;
			yield return HomingBusy;
			yield return MotionCommandsLocked;
			yield return SoftLimitMinExceeded;
			yield return SoftLimitMaxExceeded;
			yield return Moving;
			yield return PositiveDirection;
			yield return NegativeDirection;
			yield return NotMoving;
			yield return Compensating;
			yield return ExtSetPointGenEnabled;
			yield return PhasingActive;
			yield return ExternalLatchValid;
			yield return CamDataQueued;
			yield return CamTableQueued;
			yield return CamScalingPending;
			yield return CmdBuffered;
			yield return PTPmode;
			yield return DriveDeviceError;
			yield return IoDataInvalid;
			yield return ErrorPropagationDelayed;
			yield return DriveLimitActive;
			yield return TargetTorqueReached;
			yield return Coupled;
			yield return OpMode;
			yield return NcApplicationRequest;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(UpdateTaskIndex):
					return UpdateTaskIndex;
				case nameof(UpdateCycleTime):
					return UpdateCycleTime;
				case nameof(CycleCounter):
					return CycleCounter;
				case nameof(NcCycleCounter):
					return NcCycleCounter;
				case nameof(MotionState):
					return MotionState;
				case nameof(Error):
					return Error;
				case nameof(ErrorID):
					return ErrorID;
				case nameof(ErrorStop):
					return ErrorStop;
				case nameof(Disabled):
					return Disabled;
				case nameof(Stopping):
					return Stopping;
				case nameof(StandStill):
					return StandStill;
				case nameof(DiscreteMotion):
					return DiscreteMotion;
				case nameof(ContinuousMotion):
					return ContinuousMotion;
				case nameof(SynchronizedMotion):
					return SynchronizedMotion;
				case nameof(Homing):
					return Homing;
				case nameof(ConstantVelocity):
					return ConstantVelocity;
				case nameof(Accelerating):
					return Accelerating;
				case nameof(Decelerating):
					return Decelerating;
				case nameof(Operational):
					return Operational;
				case nameof(ControlLoopClosed):
					return ControlLoopClosed;
				case nameof(HasJob):
					return HasJob;
				case nameof(HasBeenStopped):
					return HasBeenStopped;
				case nameof(NewTargetPosition):
					return NewTargetPosition;
				case nameof(InPositionArea):
					return InPositionArea;
				case nameof(InTargetPosition):
					return InTargetPosition;
				case nameof(ProtectedMode):
					return ProtectedMode;
				case nameof(Homed):
					return Homed;
				case nameof(HomingBusy):
					return HomingBusy;
				case nameof(MotionCommandsLocked):
					return MotionCommandsLocked;
				case nameof(SoftLimitMinExceeded):
					return SoftLimitMinExceeded;
				case nameof(SoftLimitMaxExceeded):
					return SoftLimitMaxExceeded;
				case nameof(Moving):
					return Moving;
				case nameof(PositiveDirection):
					return PositiveDirection;
				case nameof(NegativeDirection):
					return NegativeDirection;
				case nameof(NotMoving):
					return NotMoving;
				case nameof(Compensating):
					return Compensating;
				case nameof(ExtSetPointGenEnabled):
					return ExtSetPointGenEnabled;
				case nameof(PhasingActive):
					return PhasingActive;
				case nameof(ExternalLatchValid):
					return ExternalLatchValid;
				case nameof(CamDataQueued):
					return CamDataQueued;
				case nameof(CamTableQueued):
					return CamTableQueued;
				case nameof(CamScalingPending):
					return CamScalingPending;
				case nameof(CmdBuffered):
					return CmdBuffered;
				case nameof(PTPmode):
					return PTPmode;
				case nameof(DriveDeviceError):
					return DriveDeviceError;
				case nameof(IoDataInvalid):
					return IoDataInvalid;
				case nameof(ErrorPropagationDelayed):
					return ErrorPropagationDelayed;
				case nameof(DriveLimitActive):
					return DriveLimitActive;
				case nameof(TargetTorqueReached):
					return TargetTorqueReached;
				case nameof(Coupled):
					return Coupled;
				case nameof(OpMode):
					return OpMode;
				case nameof(NcApplicationRequest):
					return NcApplicationRequest;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
