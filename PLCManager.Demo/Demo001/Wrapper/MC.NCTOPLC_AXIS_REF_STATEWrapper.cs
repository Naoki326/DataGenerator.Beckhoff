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
	/// Name from PLC:MC.NCTOPLC_AXIS_REF_STATE
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 4
	/// Comment from PLC: 
	/// <summary>
	public partial class MC_NCTOPLC_AXIS_REF_STATEWrapper : BeckhoffStruct<MC_NCTOPLC_AXIS_REF_STATEWrapper, MC_NCTOPLC_AXIS_REF_STATE>
	{
		
		public MC_NCTOPLC_AXIS_REF_STATEWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Operational { get; init; }

		public IBaseData<bool> Homed { get; init; }

		public IBaseData<bool> NotMoving { get; init; }

		public IBaseData<bool> InPositionArea { get; init; }

		public IBaseData<bool> InTargetPosition { get; init; }

		public IBaseData<bool> Protected { get; init; }

		public IBaseData<bool> ErrorPropagationDelayed { get; init; }

		public IBaseData<bool> HasBeenStopped { get; init; }

		public IBaseData<bool> HasJob { get; init; }

		public IBaseData<bool> PositiveDirection { get; init; }

		public IBaseData<bool> NegativeDirection { get; init; }

		public IBaseData<bool> HomingBusy { get; init; }

		public IBaseData<bool> ConstantVelocity { get; init; }

		public IBaseData<bool> Compensating { get; init; }

		public IBaseData<bool> ExtSetPointGenEnabled { get; init; }

		public IBaseData<bool> PhasingActive { get; init; }

		public IBaseData<bool> ExternalLatchValid { get; init; }

		public IBaseData<bool> NewTargetPos { get; init; }

		public IBaseData<bool> IsDriveLimitActive { get; init; }

		public IBaseData<bool> ContinuousMotion { get; init; }

		public IBaseData<bool> ControlLoopClosed { get; init; }

		public IBaseData<bool> CamTableQueued { get; init; }

		public IBaseData<bool> CamDataQueued { get; init; }

		public IBaseData<bool> CamScalingPending { get; init; }

		public IBaseData<bool> CmdBuffered { get; init; }

		public IBaseData<bool> PTPmode { get; init; }

		public IBaseData<bool> SoftLimitMinExceeded { get; init; }

		public IBaseData<bool> SoftLimitMaxExceeded { get; init; }

		public IBaseData<bool> DriveDeviceError { get; init; }

		public IBaseData<bool> MotionCommandsLocked { get; init; }

		public IBaseData<bool> IoDataInvalid { get; init; }

		public IBaseData<bool> Error { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Operational;
			yield return Homed;
			yield return NotMoving;
			yield return InPositionArea;
			yield return InTargetPosition;
			yield return Protected;
			yield return ErrorPropagationDelayed;
			yield return HasBeenStopped;
			yield return HasJob;
			yield return PositiveDirection;
			yield return NegativeDirection;
			yield return HomingBusy;
			yield return ConstantVelocity;
			yield return Compensating;
			yield return ExtSetPointGenEnabled;
			yield return PhasingActive;
			yield return ExternalLatchValid;
			yield return NewTargetPos;
			yield return IsDriveLimitActive;
			yield return ContinuousMotion;
			yield return ControlLoopClosed;
			yield return CamTableQueued;
			yield return CamDataQueued;
			yield return CamScalingPending;
			yield return CmdBuffered;
			yield return PTPmode;
			yield return SoftLimitMinExceeded;
			yield return SoftLimitMaxExceeded;
			yield return DriveDeviceError;
			yield return MotionCommandsLocked;
			yield return IoDataInvalid;
			yield return Error;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Operational):
					return Operational;
				case nameof(Homed):
					return Homed;
				case nameof(NotMoving):
					return NotMoving;
				case nameof(InPositionArea):
					return InPositionArea;
				case nameof(InTargetPosition):
					return InTargetPosition;
				case nameof(Protected):
					return Protected;
				case nameof(ErrorPropagationDelayed):
					return ErrorPropagationDelayed;
				case nameof(HasBeenStopped):
					return HasBeenStopped;
				case nameof(HasJob):
					return HasJob;
				case nameof(PositiveDirection):
					return PositiveDirection;
				case nameof(NegativeDirection):
					return NegativeDirection;
				case nameof(HomingBusy):
					return HomingBusy;
				case nameof(ConstantVelocity):
					return ConstantVelocity;
				case nameof(Compensating):
					return Compensating;
				case nameof(ExtSetPointGenEnabled):
					return ExtSetPointGenEnabled;
				case nameof(PhasingActive):
					return PhasingActive;
				case nameof(ExternalLatchValid):
					return ExternalLatchValid;
				case nameof(NewTargetPos):
					return NewTargetPos;
				case nameof(IsDriveLimitActive):
					return IsDriveLimitActive;
				case nameof(ContinuousMotion):
					return ContinuousMotion;
				case nameof(ControlLoopClosed):
					return ControlLoopClosed;
				case nameof(CamTableQueued):
					return CamTableQueued;
				case nameof(CamDataQueued):
					return CamDataQueued;
				case nameof(CamScalingPending):
					return CamScalingPending;
				case nameof(CmdBuffered):
					return CmdBuffered;
				case nameof(PTPmode):
					return PTPmode;
				case nameof(SoftLimitMinExceeded):
					return SoftLimitMinExceeded;
				case nameof(SoftLimitMaxExceeded):
					return SoftLimitMaxExceeded;
				case nameof(DriveDeviceError):
					return DriveDeviceError;
				case nameof(MotionCommandsLocked):
					return MotionCommandsLocked;
				case nameof(IoDataInvalid):
					return IoDataInvalid;
				case nameof(Error):
					return Error;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
