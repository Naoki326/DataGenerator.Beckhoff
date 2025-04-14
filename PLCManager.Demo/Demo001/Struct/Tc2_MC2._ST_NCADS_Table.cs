using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._ST_NCADS_Table
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 44
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2__ST_NCADS_Table
	{
		public Tc2_MC2__ST_NCADS_Table()
		{
		}

		[FieldOffset(0)]
		public Tc2_MC2__ST_NCADS_TableParameter Parameter = new Tc2_MC2__ST_NCADS_TableParameter();

		[FieldOffset(28)]
		public Tc2_MC2__ST_NCADS_TableFunctions Functions = new Tc2_MC2__ST_NCADS_TableFunctions();


	}
}
