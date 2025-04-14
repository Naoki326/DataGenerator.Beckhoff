using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._ST_TcNC_UnversalAxisStartRequest
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 80
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2__ST_TcNC_UnversalAxisStartRequest
	{
		public Tc2_MC2__ST_TcNC_UnversalAxisStartRequest()
		{
		}

		[FieldOffset(0)]
		public uint nStartType;

		[FieldOffset(4)]
		public uint nControlMask;

		[FieldOffset(8)]
		public double fPosTarget;

		[FieldOffset(16)]
		public double fVeloRequ;

		[FieldOffset(24)]
		public double fAcc;

		[FieldOffset(32)]
		public double fDec;

		[FieldOffset(40)]
		public double fJerk;

		[FieldOffset(48)]
		public uint nBufferMode;

		[FieldOffset(52)]
		public uint nReserved;

		[FieldOffset(56)]
		public double fBlendingPosition;

		[FieldOffset(64)]
		public double fVeloStart;

		[FieldOffset(72)]
		public double fVeloEnd;


	}
}
