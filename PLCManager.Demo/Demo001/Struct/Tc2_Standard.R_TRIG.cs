using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_Standard.R_TRIG
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 16
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_Standard_R_TRIG
	{
		public Tc2_Standard_R_TRIG()
		{
		}

		[FieldOffset(8)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CLK;

		[FieldOffset(9)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Q;

		[FieldOffset(10)]
		[MarshalAs(UnmanagedType.I1)]
		public bool M;


	}
}
