using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:ST_LibVersion
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 36
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct ST_LibVersion
	{
		public ST_LibVersion()
		{
		}

		[FieldOffset(0)]
		public ushort iMajor;

		[FieldOffset(2)]
		public ushort iMinor;

		[FieldOffset(4)]
		public ushort iBuild;

		[FieldOffset(6)]
		public ushort iRevision;

		[FieldOffset(8)]
		public int nFlags;

		[FieldOffset(12)]
		public String24 sVersion;


	}
}
