using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.MC_Reset
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 312
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_MC_Reset
	{
		public Tc2_MC2_MC_Reset()
		{
		}

		[FieldOffset(8)]
		// pointer or reference
		[Obsolete("PLC reference not used")]
		public byte Axis;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Execute;

		[FieldOffset(17)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Done;

		[FieldOffset(18)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Busy;

		[FieldOffset(19)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Error;

		[FieldOffset(20)]
		public uint ErrorID;

		[FieldOffset(24)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ADSbusy;

		[FieldOffset(26)]
		public Tc2_MC2__E_TcMC_STATES iState;

		[FieldOffset(28)]
		public Tc2_MC2__ST_FunctionBlockResults LastExecutionResult = new Tc2_MC2__ST_FunctionBlockResults();

		[FieldOffset(296)]
		public Tc2_Standard_R_TRIG fbOnTrigger = new Tc2_Standard_R_TRIG();


	}
}
