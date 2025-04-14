using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_System.ADSWRITE
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 168
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_System_ADSWRITE
	{
		public Tc2_System_ADSWRITE()
		{
		}

		[FieldOffset(8)]
		public String24 NETID;

		[FieldOffset(32)]
		public ushort PORT;

		[FieldOffset(36)]
		public uint IDXGRP;

		[FieldOffset(40)]
		public uint IDXOFFS;

		[FieldOffset(44)]
		public uint LEN;

		[FieldOffset(48)]
		// pointer or reference
		[Obsolete("PLC reference not used")]
		public byte SRCADDR;

		[FieldOffset(56)]
		[MarshalAs(UnmanagedType.I1)]
		public bool WRITE;

		[FieldOffset(60)]
		[MarshalAs(UnmanagedType.U4)]
		public uint TMOUT;

		[FieldOffset(64)]
		[MarshalAs(UnmanagedType.I1)]
		public bool BUSY;

		[FieldOffset(65)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ERR;

		[FieldOffset(68)]
		public uint ERRID;


	}
}
