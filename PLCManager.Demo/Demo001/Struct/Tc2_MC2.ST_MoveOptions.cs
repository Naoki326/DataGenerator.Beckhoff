using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.ST_MoveOptions
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 40
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_ST_MoveOptions
	{
		public Tc2_MC2_ST_MoveOptions()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool EnableBlendingPosition;

		[FieldOffset(8)]
		public double BlendingPosition;

		[FieldOffset(16)]
		public double StartVelocity;

		[FieldOffset(24)]
		public double EndVelocity;

		[FieldOffset(32)]
		[MarshalAs(UnmanagedType.I1)]
		public bool IgnorePositionMonitoring;

		[FieldOffset(33)]
		[MarshalAs(UnmanagedType.I1)]
		public bool EnableStopPositionMonitoring;


	}
}
