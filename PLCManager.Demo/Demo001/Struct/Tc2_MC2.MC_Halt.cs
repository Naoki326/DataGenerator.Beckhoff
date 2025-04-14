using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.MC_Halt
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 1192
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_MC_Halt
	{
		public Tc2_MC2_MC_Halt()
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
		public double Deceleration;

		[FieldOffset(32)]
		public double Jerk;

		[FieldOffset(40)]
		public Tc2_MC2_MC_BufferMode BufferMode;

		[FieldOffset(48)]
		public Tc2_MC2_ST_MoveOptions Options = new Tc2_MC2_ST_MoveOptions();

		[FieldOffset(88)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Done;

		[FieldOffset(89)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Busy;

		[FieldOffset(90)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Active;

		[FieldOffset(91)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CommandAborted;

		[FieldOffset(92)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Error;

		[FieldOffset(96)]
		public uint ErrorID;

		[FieldOffset(100)]
		public Tc2_MC2__ST_FunctionBlockResults LastExecutionResult = new Tc2_MC2__ST_FunctionBlockResults();

		[FieldOffset(112)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ADSbusy;

		[FieldOffset(120)]
		public Tc2_MC2__FB_MoveUniversalGeneric MoveGeneric = new Tc2_MC2__FB_MoveUniversalGeneric();

		[FieldOffset(1184)]
		public ushort CmdNo;


	}
}
