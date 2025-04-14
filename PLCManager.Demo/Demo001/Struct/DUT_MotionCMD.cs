using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:DUT_MotionCMD
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 104
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct DUT_MotionCMD
	{
		public DUT_MotionCMD()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bEnable;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bPosLim;

		[FieldOffset(2)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bNegLim;

		[FieldOffset(8)]
		public double rOverRide;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bHomeStart;

		[FieldOffset(17)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bRefCam;

		[FieldOffset(18)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bStop;

		[FieldOffset(19)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bHalt;

		[FieldOffset(20)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bReset;

		[FieldOffset(21)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bSetPostion;

		[FieldOffset(24)]
		public double rSetPositon;

		[FieldOffset(32)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bJogPlus;

		[FieldOffset(33)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bJogMin;

		[FieldOffset(34)]
		public Tc2_MC2_E_JogMode nJogMode;

		[FieldOffset(40)]
		public double rInchPos;

		[FieldOffset(48)]
		public double rJogVelo;

		[FieldOffset(56)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bMoveVeloStart;

		[FieldOffset(64)]
		public double rSetVelo;

		[FieldOffset(72)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bMoveAbsStart;

		[FieldOffset(80)]
		public double rMoveAbsSetPos;

		[FieldOffset(88)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bMoveRelativeStart;

		[FieldOffset(96)]
		public double rMoveRelativeSetPos;


	}
}
