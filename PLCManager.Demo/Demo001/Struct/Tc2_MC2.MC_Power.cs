using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.MC_Power
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 120
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_MC_Power
	{
		public Tc2_MC2_MC_Power()
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
		public bool Enable_Positive;

		[FieldOffset(18)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Enable_Negative;

		[FieldOffset(24)]
		public double Override;

		[FieldOffset(32)]
		public Tc2_MC2_MC_BufferMode BufferMode;

		[FieldOffset(34)]
		public Tc2_MC2_ST_PowerOptions Options = new Tc2_MC2_ST_PowerOptions();

		[FieldOffset(35)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Status;

		[FieldOffset(36)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Busy;

		[FieldOffset(38)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Error;

		[FieldOffset(40)]
		public uint ErrorID;

		[FieldOffset(48)]
		public Tc2_Standard_TON EnableTimeout = new Tc2_Standard_TON();

		[FieldOffset(80)]
		public Tc2_Standard_TP EnableOffOnDelay = new Tc2_Standard_TP();

		[FieldOffset(112)]
		public int iOverride;


	}
}
