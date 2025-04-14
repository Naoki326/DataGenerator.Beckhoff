using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:FB_IO_Sensor
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 192
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct FB_IO_Sensor
	{
		public FB_IO_Sensor()
		{
		}

		[FieldOffset(8)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Disenable;

		[FieldOffset(9)]
		[MarshalAs(UnmanagedType.I1)]
		public bool In_Signal;

		[FieldOffset(10)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Cmd_Reset;

		[FieldOffset(12)]
		public float Over_Time;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Out_Signal;

		[FieldOffset(17)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Out_Alarm;

		[FieldOffset(24)]
		public Tc2_Standard_TON5 DelayOn = new Tc2_Standard_TON5();

		[FieldOffset(184)]
		public short I;


	}
}
