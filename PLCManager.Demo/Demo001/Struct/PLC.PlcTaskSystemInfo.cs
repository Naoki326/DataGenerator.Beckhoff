using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:PLC.PlcTaskSystemInfo
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 128
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct PLC_PlcTaskSystemInfo
	{
		public PLC_PlcTaskSystemInfo()
		{
		}

		[FieldOffset(0)]
		public uint ObjId;

		[FieldOffset(4)]
		public uint CycleTime;

		[FieldOffset(8)]
		public ushort Priority;

		[FieldOffset(10)]
		public ushort AdsPort;

		[FieldOffset(12)]
		public uint CycleCount;

		[FieldOffset(16)]
		public long DcTaskTime;

		[FieldOffset(24)]
		public uint LastExecTime;

		[FieldOffset(28)]
		[MarshalAs(UnmanagedType.I1)]
		public bool FirstCycle;

		[FieldOffset(29)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CycleTimeExceeded;

		[FieldOffset(30)]
		[MarshalAs(UnmanagedType.I1)]
		public bool InCallAfterOutputUpdate;

		[FieldOffset(31)]
		[MarshalAs(UnmanagedType.I1)]
		public bool RTViolation;

		[FieldOffset(64)]
		public String64 TaskName;


	}
}
