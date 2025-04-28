using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:AMSADDR
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 8
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct AMSADDR
	{
		public AMSADDR()
		{
		}

		[FieldOffset(0)]
		public Byte6 netId = new Byte6();

		[FieldOffset(6)]
		public short port;


	}
}
