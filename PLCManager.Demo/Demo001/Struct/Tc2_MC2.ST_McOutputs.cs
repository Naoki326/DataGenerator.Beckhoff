using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.ST_McOutputs
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 12
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_ST_McOutputs
	{
		public Tc2_MC2_ST_McOutputs()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Done;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Busy;

		[FieldOffset(2)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Active;

		[FieldOffset(3)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CommandAborted;

		[FieldOffset(4)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Error;

		[FieldOffset(8)]
		public uint ErrorID;


	}
}
