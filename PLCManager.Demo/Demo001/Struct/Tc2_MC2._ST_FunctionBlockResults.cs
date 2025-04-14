using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._ST_FunctionBlockResults
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 12
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2__ST_FunctionBlockResults
	{
		public Tc2_MC2__ST_FunctionBlockResults()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Done;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CommandAborted;

		[FieldOffset(2)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Error;

		[FieldOffset(4)]
		public uint ErrorID;

		[FieldOffset(8)]
		public uint BusyCounter;


	}
}
