using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:MC.NCTOPLC_AXIS_REF_STATE
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 4
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct MC_NCTOPLC_AXIS_REF_STATE
	{
		public MC_NCTOPLC_AXIS_REF_STATE()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Operational;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Homed;

		[FieldOffset(2)]
		[MarshalAs(UnmanagedType.I1)]
		public bool NotMoving;

		[FieldOffset(3)]
		[MarshalAs(UnmanagedType.I1)]
		public bool InPositionArea;

		[FieldOffset(4)]
		[MarshalAs(UnmanagedType.I1)]
		public bool InTargetPosition;

		[FieldOffset(5)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Protected;

		[FieldOffset(6)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ErrorPropagationDelayed;

		[FieldOffset(7)]
		[MarshalAs(UnmanagedType.I1)]
		public bool HasBeenStopped;

		[FieldOffset(8)]
		[MarshalAs(UnmanagedType.I1)]
		public bool HasJob;

		[FieldOffset(9)]
		[MarshalAs(UnmanagedType.I1)]
		public bool PositiveDirection;

		[FieldOffset(10)]
		[MarshalAs(UnmanagedType.I1)]
		public bool NegativeDirection;

		[FieldOffset(11)]
		[MarshalAs(UnmanagedType.I1)]
		public bool HomingBusy;

		[FieldOffset(12)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ConstantVelocity;

		[FieldOffset(13)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Compensating;

		[FieldOffset(14)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ExtSetPointGenEnabled;

		[FieldOffset(15)]
		[MarshalAs(UnmanagedType.I1)]
		public bool PhasingActive;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ExternalLatchValid;

		[FieldOffset(17)]
		[MarshalAs(UnmanagedType.I1)]
		public bool NewTargetPos;

		[FieldOffset(18)]
		[MarshalAs(UnmanagedType.I1)]
		public bool IsDriveLimitActive;

		[FieldOffset(19)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ContinuousMotion;

		[FieldOffset(20)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ControlLoopClosed;

		[FieldOffset(21)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CamTableQueued;

		[FieldOffset(22)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CamDataQueued;

		[FieldOffset(23)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CamScalingPending;

		[FieldOffset(24)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CmdBuffered;

		[FieldOffset(25)]
		[MarshalAs(UnmanagedType.I1)]
		public bool PTPmode;

		[FieldOffset(26)]
		[MarshalAs(UnmanagedType.I1)]
		public bool SoftLimitMinExceeded;

		[FieldOffset(27)]
		[MarshalAs(UnmanagedType.I1)]
		public bool SoftLimitMaxExceeded;

		[FieldOffset(28)]
		[MarshalAs(UnmanagedType.I1)]
		public bool DriveDeviceError;

		[FieldOffset(29)]
		[MarshalAs(UnmanagedType.I1)]
		public bool MotionCommandsLocked;

		[FieldOffset(30)]
		[MarshalAs(UnmanagedType.I1)]
		public bool IoDataInvalid;

		[FieldOffset(31)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Error;


	}
}
