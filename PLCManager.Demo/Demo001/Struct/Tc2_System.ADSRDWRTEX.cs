using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_System.ADSRDWRTEX
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 224
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_System_ADSRDWRTEX
	{
		public Tc2_System_ADSRDWRTEX()
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
		public uint WRITELEN;

		[FieldOffset(48)]
		public uint READLEN;

		[FieldOffset(56)]
		// pointer or reference
		[Obsolete("PLC reference not used")]
		public byte SRCADDR;

		[FieldOffset(64)]
		// pointer or reference
		[Obsolete("PLC reference not used")]
		public byte DESTADDR;

		[FieldOffset(72)]
		[MarshalAs(UnmanagedType.I1)]
		public bool WRTRD;

		[FieldOffset(76)]
		[MarshalAs(UnmanagedType.U4)]
		public uint TMOUT;

		[FieldOffset(80)]
		[MarshalAs(UnmanagedType.I1)]
		public bool BUSY;

		[FieldOffset(81)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ERR;

		[FieldOffset(84)]
		public uint ERRID;

		[FieldOffset(88)]
		public uint COUNT_R;


	}
}
