using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:_Implicit_Jitter_Distribution
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 6
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct _Implicit_Jitter_Distribution
	{
		public _Implicit_Jitter_Distribution()
		{
		}

		[FieldOffset(0)]
		public short wRangeMax;

		[FieldOffset(2)]
		public short wCountJitterNeg;

		[FieldOffset(4)]
		public short wCountJitterPos;


	}
}
