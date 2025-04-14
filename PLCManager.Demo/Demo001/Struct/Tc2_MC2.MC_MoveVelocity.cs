using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.MC_MoveVelocity
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 1208
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_MC_MoveVelocity
	{
		public Tc2_MC2_MC_MoveVelocity()
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
		public double Velocity;

		[FieldOffset(32)]
		public double Acceleration;

		[FieldOffset(40)]
		public double Deceleration;

		[FieldOffset(48)]
		public double Jerk;

		[FieldOffset(56)]
		public Tc2_MC2_MC_Direction Direction;

		[FieldOffset(58)]
		public Tc2_MC2_MC_BufferMode BufferMode;

		[FieldOffset(64)]
		public Tc2_MC2_ST_MoveOptions Options = new Tc2_MC2_ST_MoveOptions();

		[FieldOffset(104)]
		[MarshalAs(UnmanagedType.I1)]
		public bool InVelocity;

		[FieldOffset(105)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Busy;

		[FieldOffset(106)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Active;

		[FieldOffset(107)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CommandAborted;

		[FieldOffset(108)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Error;

		[FieldOffset(112)]
		public uint ErrorID;

		[FieldOffset(116)]
		public Tc2_MC2__ST_FunctionBlockResults LastExecutionResult = new Tc2_MC2__ST_FunctionBlockResults();

		[FieldOffset(128)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ADSbusy;

		[FieldOffset(136)]
		public Tc2_MC2__FB_MoveUniversalGeneric MoveGeneric = new Tc2_MC2__FB_MoveUniversalGeneric();

		[FieldOffset(1200)]
		public ushort CmdNo;


	}
}
