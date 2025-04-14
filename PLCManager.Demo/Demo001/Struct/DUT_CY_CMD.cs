using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:DUT_CY_CMD
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 6
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct DUT_CY_CMD
	{
		public DUT_CY_CMD()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Extend_CMD;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Retract_CMD;

		[FieldOffset(2)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CY_PL;

		[FieldOffset(3)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CY_NL;

		[FieldOffset(4)]
		public ushort Coil_Num;


	}
}
