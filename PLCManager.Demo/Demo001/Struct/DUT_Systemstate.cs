using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:DUT_Systemstate
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 10
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct DUT_Systemstate
	{
		public DUT_Systemstate()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool AutoAllow;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.I1)]
		public bool HomeRequest;

		[FieldOffset(2)]
		public short HomeStep;

		[FieldOffset(4)]
		[MarshalAs(UnmanagedType.I1)]
		public bool HomeAllow;

		[FieldOffset(5)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Homing;

		[FieldOffset(6)]
		[MarshalAs(UnmanagedType.I1)]
		public bool HomeFinished;

		[FieldOffset(7)]
		[MarshalAs(UnmanagedType.I1)]
		public bool AutoRun;

		[FieldOffset(8)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Fault;

		[FieldOffset(9)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OnlineTcpAlarm;


	}
}
