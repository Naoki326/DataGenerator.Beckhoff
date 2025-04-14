using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:MC.NCTOPLC_AXIS_REF_STATE3_FLAGS
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 4
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct MC_NCTOPLC_AXIS_REF_STATE3_FLAGS
	{
		public MC_NCTOPLC_AXIS_REF_STATE3_FLAGS()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool TouchProbe1InputState ;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.I1)]
		public bool TouchProbe2InputState ;


	}
}
