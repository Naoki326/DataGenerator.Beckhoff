using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._ST_NCADS_IDXOFFS_TableParameter
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 24
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2__ST_NCADS_IDXOFFS_TableParameter
	{
		public Tc2_MC2__ST_NCADS_IDXOFFS_TableParameter()
		{
		}

		[FieldOffset(0)]
		public uint MFREADCHARACVALUES;

		[FieldOffset(4)]
		public uint WRITETABROWS;

		[FieldOffset(8)]
		public uint WRITEMFTABROWS;

		[FieldOffset(12)]
		public uint MFREADTAB;

		[FieldOffset(16)]
		public uint READSLAVEDYNAMICS;

		[FieldOffset(20)]
		public uint READMASTERPOSITION;


	}
}
