using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._ST_NCADS_IDXOFFS_TableFunctions
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 12
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2__ST_NCADS_IDXOFFS_TableFunctions
	{
		public Tc2_MC2__ST_NCADS_IDXOFFS_TableFunctions()
		{
		}

		[FieldOffset(0)]
		public uint CREATETAB;

		[FieldOffset(4)]
		public uint CREATEMOTIONTAB;

		[FieldOffset(8)]
		public uint DELETETAB;


	}
}
