using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_Standard.TP
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 32
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_Standard_TP
	{
		public Tc2_Standard_TP()
		{
		}

		[FieldOffset(8)]
		[MarshalAs(UnmanagedType.I1)]
		public bool IN;

		[FieldOffset(12)]
		[MarshalAs(UnmanagedType.U4)]
		public uint PT;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Q;

		[FieldOffset(20)]
		[MarshalAs(UnmanagedType.U4)]
		public uint ET;

		[FieldOffset(24)]
		[MarshalAs(UnmanagedType.U4)]
		public uint StartTime;


	}
}
