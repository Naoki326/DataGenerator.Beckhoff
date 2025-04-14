using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:MC.NCTOPLC_AXIS_REF_OPMODE
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 4
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct MC_NCTOPLC_AXIS_REF_OPMODE
	{
		public MC_NCTOPLC_AXIS_REF_OPMODE()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModePosAreaMonitoring;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModeTargetPosMonitoring;

		[FieldOffset(2)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModeLoop;

		[FieldOffset(3)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModeMotionMonitoring;

		[FieldOffset(4)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModePEHTimeMonitoring;

		[FieldOffset(5)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModeBacklashCompensation;

		[FieldOffset(6)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModeDelayedErrorReaction;

		[FieldOffset(7)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModeModulo;

		[FieldOffset(8)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModeSimulationAxis;

		[FieldOffset(12)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModeStopMonitoring;

		[FieldOffset(13)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModeOutputSmoothingFilter;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModePosLagMonitoring;

		[FieldOffset(17)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModeVeloLagMonitoring;

		[FieldOffset(18)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModeSoftLimitMinMonitoring;

		[FieldOffset(19)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModeSoftLimitMaxMonitoring;

		[FieldOffset(20)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModePosCorrection;

		[FieldOffset(21)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModeAllowSlaveCommands;

		[FieldOffset(22)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OpModeAllowExtSetAxisCommands;

		[FieldOffset(23)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ApplicationRequest;


	}
}
