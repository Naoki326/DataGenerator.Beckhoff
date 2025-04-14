using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:GUID
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 16
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct GUID
	{
		public GUID()
		{
		}

		[FieldOffset(0)]
		public int Data1;

		[FieldOffset(4)]
		public short Data2;

		[FieldOffset(6)]
		public short Data3;

		[FieldOffset(8)]
		public Byte8 Data4 = new Byte8();


	}
}
