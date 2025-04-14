using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.MC_MoveRelative
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 1216
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_MC_MoveRelative
	{
		public Tc2_MC2_MC_MoveRelative()
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
		public double Distance;

		[FieldOffset(32)]
		public double Velocity;

		[FieldOffset(40)]
		public double Acceleration;

		[FieldOffset(48)]
		public double Deceleration;

		[FieldOffset(56)]
		public double Jerk;

		[FieldOffset(64)]
		public Tc2_MC2_MC_BufferMode BufferMode;

		[FieldOffset(72)]
		public Tc2_MC2_ST_MoveOptions Options = new Tc2_MC2_ST_MoveOptions();

		[FieldOffset(112)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Done;

		[FieldOffset(113)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Busy;

		[FieldOffset(114)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Active;

		[FieldOffset(115)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CommandAborted;

		[FieldOffset(116)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Error;

		[FieldOffset(120)]
		public uint ErrorID;

		[FieldOffset(124)]
		public Tc2_MC2__ST_FunctionBlockResults LastExecutionResult = new Tc2_MC2__ST_FunctionBlockResults();

		[FieldOffset(136)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ADSbusy;

		[FieldOffset(144)]
		public Tc2_MC2__FB_MoveUniversalGeneric MoveGeneric = new Tc2_MC2__FB_MoveUniversalGeneric();

		[FieldOffset(1208)]
		public ushort CmdNo;


	}
}
