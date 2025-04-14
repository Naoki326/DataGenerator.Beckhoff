using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:PLC.PlcAppSystemInfo
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 256
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct PLC_PlcAppSystemInfo
	{
		public PLC_PlcAppSystemInfo()
		{
		}

		[FieldOffset(0)]
		public uint ObjId;

		[FieldOffset(4)]
		public uint TaskCnt;

		[FieldOffset(8)]
		public uint OnlineChangeCnt;

		[FieldOffset(12)]
		public int Flags;

		[FieldOffset(16)]
		public ushort AdsPort;

		[FieldOffset(18)]
		[MarshalAs(UnmanagedType.I1)]
		public bool BootDataLoaded;

		[FieldOffset(19)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OldBootData;

		[FieldOffset(20)]
		[MarshalAs(UnmanagedType.U4)]
		public uint AppTimestamp;

		[FieldOffset(24)]
		[MarshalAs(UnmanagedType.I1)]
		public bool KeepOutputsOnBP;

		[FieldOffset(25)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ShutdownInProgress;

		[FieldOffset(26)]
		[MarshalAs(UnmanagedType.I1)]
		public bool LicensesPending;

		[FieldOffset(27)]
		[MarshalAs(UnmanagedType.I1)]
		public bool BSODOccured;

		[FieldOffset(28)]
		[MarshalAs(UnmanagedType.I1)]
		public bool LoggedIn;

		[FieldOffset(29)]
		public PLC_EPlcPersistentStatus PersistentStatus;

		[FieldOffset(32)]
		// interface
		[Obsolete("PLC Interface not used")]
		public long TComSrvPtr;

		[FieldOffset(64)]
		public String64 AppName;

		[FieldOffset(128)]
		public String64 ProjectName;


	}
}
