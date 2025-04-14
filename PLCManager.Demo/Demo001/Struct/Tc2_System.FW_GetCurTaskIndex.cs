using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_System.FW_GetCurTaskIndex
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 16
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_System_FW_GetCurTaskIndex
	{
		public Tc2_System_FW_GetCurTaskIndex()
		{
		}

		[FieldOffset(8)]
		public byte nIndex;


	}
}
