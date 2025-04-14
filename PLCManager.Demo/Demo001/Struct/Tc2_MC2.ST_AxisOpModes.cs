using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.ST_AxisOpModes
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 17
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_ST_AxisOpModes
	{
		public Tc2_MC2_ST_AxisOpModes()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool PositionAreaMonitoring;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.I1)]
		public bool TargetPositionMonitoring;

		[FieldOffset(2)]
		[MarshalAs(UnmanagedType.I1)]
		public bool LoopMode;

		[FieldOffset(3)]
		[MarshalAs(UnmanagedType.I1)]
		public bool MotionMonitoring;

		[FieldOffset(4)]
		[MarshalAs(UnmanagedType.I1)]
		public bool PEHTimeMonitoring;

		[FieldOffset(5)]
		[MarshalAs(UnmanagedType.I1)]
		public bool BacklashCompensation;

		[FieldOffset(6)]
		[MarshalAs(UnmanagedType.I1)]
		public bool DelayedErrorReaction;

		[FieldOffset(7)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Modulo;

		[FieldOffset(8)]
		[MarshalAs(UnmanagedType.I1)]
		public bool SimulationAxis;

		[FieldOffset(9)]
		[MarshalAs(UnmanagedType.I1)]
		public bool StopMonitoring;

		[FieldOffset(10)]
		[MarshalAs(UnmanagedType.I1)]
		public bool PositionLagMonitoring;

		[FieldOffset(11)]
		[MarshalAs(UnmanagedType.I1)]
		public bool VelocityLagMonitoring;

		[FieldOffset(12)]
		[MarshalAs(UnmanagedType.I1)]
		public bool SoftLimitMinMonitoring;

		[FieldOffset(13)]
		[MarshalAs(UnmanagedType.I1)]
		public bool SoftLimitMaxMonitoring;

		[FieldOffset(14)]
		[MarshalAs(UnmanagedType.I1)]
		public bool PositionCorrection;

		[FieldOffset(15)]
		[MarshalAs(UnmanagedType.I1)]
		public bool AllowSlaveCommands;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.I1)]
		public bool AllowExtSetAxisCommands;


	}
}
