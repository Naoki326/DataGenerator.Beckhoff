using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._ST_TcNC_UniversalAxisTorqueStartRequest
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 72
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2__ST_TcNC_UniversalAxisTorqueStartRequest
	{
		public Tc2_MC2__ST_TcNC_UniversalAxisTorqueStartRequest()
		{
		}

		[FieldOffset(0)]
		public uint nStartType;

		[FieldOffset(4)]
		public uint nControlMask;

		[FieldOffset(8)]
		public uint nMode;

		[FieldOffset(12)]
		public uint nBufferMode;

		[FieldOffset(16)]
		public double fTorque;

		[FieldOffset(24)]
		public double fTorqueRamp;

		[FieldOffset(32)]
		public double fVelocityLimitHigh;

		[FieldOffset(40)]
		public double fVelocityLimitLow;

		[FieldOffset(48)]
		public double fAcceleration;

		[FieldOffset(56)]
		public double fDeceleration;

		[FieldOffset(64)]
		public double fManualTorque;


	}
}
