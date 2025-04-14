using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:FB_IO_Cylinder
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 520
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct FB_IO_Cylinder
	{
		public FB_IO_Cylinder()
		{
		}

		[FieldOffset(8)]
		[MarshalAs(UnmanagedType.I1)]
		public bool RunMode;

		[FieldOffset(9)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Selected;

		[FieldOffset(10)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Nl;

		[FieldOffset(11)]
		[MarshalAs(UnmanagedType.I1)]
		public bool PL;

		[FieldOffset(12)]
		public short Coil_Num;

		[FieldOffset(14)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Cmd_Auto_Extend;

		[FieldOffset(15)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Cmd_Auto_Retract;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Cmd_Manual_Extend;

		[FieldOffset(17)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Cmd_Manual_Retract;

		[FieldOffset(18)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Cmd_Reset;

		[FieldOffset(20)]
		public float Over_Time;

		[FieldOffset(24)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Out_Retract;

		[FieldOffset(25)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Out_Extend;

		[FieldOffset(26)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Out_Alarm;

		[FieldOffset(32)]
		public Tc2_Standard_TON10 DelayOn = new Tc2_Standard_TON10();

		[FieldOffset(352)]
		public Tc2_Standard_R_TRIG10 TrigOn = new Tc2_Standard_R_TRIG10();

		[FieldOffset(512)]
		public short I;


	}
}
