using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.MC_SetPosition
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 280
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_MC_SetPosition
	{
		public Tc2_MC2_MC_SetPosition()
		{
		}

		[FieldOffset(8)]
		// pointer or reference
		[Obsolete("PLC reference not used")]
		public byte Axis;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Execute;

		[FieldOffset(24)]
		public double Position;

		[FieldOffset(32)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Mode;

		[FieldOffset(34)]
		public Tc2_MC2_ST_SetPositionOptions Options = new Tc2_MC2_ST_SetPositionOptions();

		[FieldOffset(40)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Done;

		[FieldOffset(41)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Busy;

		[FieldOffset(42)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Error;

		[FieldOffset(44)]
		public uint ErrorID;

		[FieldOffset(48)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ADSbusy;

		[FieldOffset(56)]
		public Tc2_MC2__ST_TcNC_SetPosOnTheFly stSetPos = new Tc2_MC2__ST_TcNC_SetPosOnTheFly();

		[FieldOffset(88)]
		public Tc2_MC2__E_TcMC_STATES iState;

		[FieldOffset(96)]
		public Tc2_System_ADSWRITE fbAdsWrite = new Tc2_System_ADSWRITE();

		[FieldOffset(264)]
		public Tc2_Standard_R_TRIG fbOnTrigger = new Tc2_Standard_R_TRIG();


	}
}
