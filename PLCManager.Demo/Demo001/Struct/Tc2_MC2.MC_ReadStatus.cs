using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.MC_ReadStatus
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 136
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_MC_ReadStatus
	{
		public Tc2_MC2_MC_ReadStatus()
		{
		}

		[FieldOffset(8)]
		// pointer or reference
		[Obsolete("PLC reference not used")]
		public byte Axis;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Enable;

		[FieldOffset(17)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Valid;

		[FieldOffset(18)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Busy;

		[FieldOffset(19)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Error;

		[FieldOffset(20)]
		public uint ErrorID;

		[FieldOffset(24)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ErrorStop;

		[FieldOffset(25)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Disabled;

		[FieldOffset(26)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Stopping;

		[FieldOffset(27)]
		[MarshalAs(UnmanagedType.I1)]
		public bool StandStill;

		[FieldOffset(28)]
		[MarshalAs(UnmanagedType.I1)]
		public bool DiscreteMotion;

		[FieldOffset(29)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ContinuousMotion;

		[FieldOffset(30)]
		[MarshalAs(UnmanagedType.I1)]
		public bool SynchronizedMotion;

		[FieldOffset(31)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Homing;

		[FieldOffset(32)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ConstantVelocity;

		[FieldOffset(33)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Accelerating;

		[FieldOffset(34)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Decelerating;

		[FieldOffset(40)]
		public Tc2_MC2_ST_AxisStatus Status = new Tc2_MC2_ST_AxisStatus();


	}
}
