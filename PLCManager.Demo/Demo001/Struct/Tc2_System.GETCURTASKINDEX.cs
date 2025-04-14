using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_System.GETCURTASKINDEX
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 32
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_System_GETCURTASKINDEX
	{
		public Tc2_System_GETCURTASKINDEX()
		{
		}

		[FieldOffset(8)]
		public byte index;

		[FieldOffset(16)]
		public Tc2_System_FW_GetCurTaskIndex fbGetCurTaskIndex = new Tc2_System_FW_GetCurTaskIndex();


	}
}
