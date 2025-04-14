using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.ST_AxisStatus
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 96
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_ST_AxisStatus
	{
		public Tc2_MC2_ST_AxisStatus()
		{
		}

		[FieldOffset(0)]
		public byte UpdateTaskIndex;

		[FieldOffset(8)]
		public double UpdateCycleTime;

		[FieldOffset(16)]
		public uint CycleCounter;

		[FieldOffset(20)]
		public uint NcCycleCounter;

		[FieldOffset(24)]
		public Tc2_MC2_MC_AxisStates MotionState;

		[FieldOffset(26)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Error;

		[FieldOffset(28)]
		public uint ErrorID;

		[FieldOffset(32)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ErrorStop;

		[FieldOffset(33)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Disabled;

		[FieldOffset(34)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Stopping;

		[FieldOffset(35)]
		[MarshalAs(UnmanagedType.I1)]
		public bool StandStill;

		[FieldOffset(36)]
		[MarshalAs(UnmanagedType.I1)]
		public bool DiscreteMotion;

		[FieldOffset(37)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ContinuousMotion;

		[FieldOffset(38)]
		[MarshalAs(UnmanagedType.I1)]
		public bool SynchronizedMotion;

		[FieldOffset(39)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Homing;

		[FieldOffset(40)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ConstantVelocity;

		[FieldOffset(41)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Accelerating;

		[FieldOffset(42)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Decelerating;

		[FieldOffset(43)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Operational;

		[FieldOffset(44)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ControlLoopClosed;

		[FieldOffset(45)]
		[MarshalAs(UnmanagedType.I1)]
		public bool HasJob;

		[FieldOffset(46)]
		[MarshalAs(UnmanagedType.I1)]
		public bool HasBeenStopped;

		[FieldOffset(47)]
		[MarshalAs(UnmanagedType.I1)]
		public bool NewTargetPosition;

		[FieldOffset(48)]
		[MarshalAs(UnmanagedType.I1)]
		public bool InPositionArea;

		[FieldOffset(49)]
		[MarshalAs(UnmanagedType.I1)]
		public bool InTargetPosition;

		[FieldOffset(50)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ProtectedMode;

		[FieldOffset(51)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Homed;

		[FieldOffset(52)]
		[MarshalAs(UnmanagedType.I1)]
		public bool HomingBusy;

		[FieldOffset(53)]
		[MarshalAs(UnmanagedType.I1)]
		public bool MotionCommandsLocked;

		[FieldOffset(54)]
		[MarshalAs(UnmanagedType.I1)]
		public bool SoftLimitMinExceeded;

		[FieldOffset(55)]
		[MarshalAs(UnmanagedType.I1)]
		public bool SoftLimitMaxExceeded;

		[FieldOffset(56)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Moving;

		[FieldOffset(57)]
		[MarshalAs(UnmanagedType.I1)]
		public bool PositiveDirection;

		[FieldOffset(58)]
		[MarshalAs(UnmanagedType.I1)]
		public bool NegativeDirection;

		[FieldOffset(59)]
		[MarshalAs(UnmanagedType.I1)]
		public bool NotMoving;

		[FieldOffset(60)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Compensating;

		[FieldOffset(61)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ExtSetPointGenEnabled;

		[FieldOffset(62)]
		[MarshalAs(UnmanagedType.I1)]
		public bool PhasingActive;

		[FieldOffset(63)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ExternalLatchValid;

		[FieldOffset(64)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CamDataQueued;

		[FieldOffset(65)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CamTableQueued;

		[FieldOffset(66)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CamScalingPending;

		[FieldOffset(67)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CmdBuffered;

		[FieldOffset(68)]
		[MarshalAs(UnmanagedType.I1)]
		public bool PTPmode;

		[FieldOffset(69)]
		[MarshalAs(UnmanagedType.I1)]
		public bool DriveDeviceError;

		[FieldOffset(70)]
		[MarshalAs(UnmanagedType.I1)]
		public bool IoDataInvalid;

		[FieldOffset(71)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ErrorPropagationDelayed;

		[FieldOffset(72)]
		[MarshalAs(UnmanagedType.I1)]
		public bool DriveLimitActive;

		[FieldOffset(73)]
		[MarshalAs(UnmanagedType.I1)]
		public bool TargetTorqueReached;

		[FieldOffset(74)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Coupled;

		[FieldOffset(75)]
		public Tc2_MC2_ST_AxisOpModes OpMode = new Tc2_MC2_ST_AxisOpModes();

		[FieldOffset(92)]
		[MarshalAs(UnmanagedType.I1)]
		public bool NcApplicationRequest;


	}
}
