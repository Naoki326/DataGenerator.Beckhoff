using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:DUT_BufferStatus
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 6
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct DUT_BufferStatus
	{
		public DUT_BufferStatus()
		{
		}

		[FieldOffset(0)]
		public short iCellNo;

		[FieldOffset(2)]
		public short bHomeDone;

		[FieldOffset(4)]
		public short Step;


	}
}
