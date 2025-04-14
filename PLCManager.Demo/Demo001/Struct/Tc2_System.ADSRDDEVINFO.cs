using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_System.ADSRDDEVINFO
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 168
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_System_ADSRDDEVINFO
	{
		public Tc2_System_ADSRDDEVINFO()
		{
		}

		[FieldOffset(8)]
		public String24 NETID;

		[FieldOffset(32)]
		public ushort PORT;

		[FieldOffset(34)]
		[MarshalAs(UnmanagedType.I1)]
		public bool RDINFO;

		[FieldOffset(36)]
		[MarshalAs(UnmanagedType.U4)]
		public uint TMOUT;

		[FieldOffset(40)]
		[MarshalAs(UnmanagedType.I1)]
		public bool BUSY;

		[FieldOffset(41)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ERR;

		[FieldOffset(44)]
		public uint ERRID;

		[FieldOffset(48)]
		public String20 DEVNAME;

		[FieldOffset(68)]
		public uint DEVVER;


	}
}
