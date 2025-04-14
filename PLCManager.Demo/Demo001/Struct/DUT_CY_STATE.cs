using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:DUT_CY_STATE
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 3
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct DUT_CY_STATE
	{
		public DUT_CY_STATE()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Out_Retract;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Out_Extend;

		[FieldOffset(2)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Out_Fault_Alarm;


	}
}
