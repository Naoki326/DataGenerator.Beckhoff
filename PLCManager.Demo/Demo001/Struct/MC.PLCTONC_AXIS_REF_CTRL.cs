using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:MC.PLCTONC_AXIS_REF_CTRL
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 4
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct MC_PLCTONC_AXIS_REF_CTRL
	{
		public MC_PLCTONC_AXIS_REF_CTRL()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Enable;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.I1)]
		public bool FeedEnablePlus;

		[FieldOffset(2)]
		[MarshalAs(UnmanagedType.I1)]
		public bool FeedEnableMinus;

		[FieldOffset(5)]
		[MarshalAs(UnmanagedType.I1)]
		public bool HomingSensor;

		[FieldOffset(8)]
		[MarshalAs(UnmanagedType.I1)]
		public bool AcceptBlockedDrive;

		[FieldOffset(30)]
		[MarshalAs(UnmanagedType.I1)]
		public bool PlcDebugFlag;

		[FieldOffset(31)]
		[MarshalAs(UnmanagedType.I1)]
		public bool NcDebugFlag;


	}
}
