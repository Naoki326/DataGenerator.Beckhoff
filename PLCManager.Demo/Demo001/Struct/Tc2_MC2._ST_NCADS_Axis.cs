using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._ST_NCADS_Axis
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 548
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2__ST_NCADS_Axis
	{
		public Tc2_MC2__ST_NCADS_Axis()
		{
		}

		[FieldOffset(0)]
		public Tc2_MC2__ST_NCADS_AxisParameter Parameter = new Tc2_MC2__ST_NCADS_AxisParameter();

		[FieldOffset(208)]
		public Tc2_MC2__ST_NCADS_AxisState State = new Tc2_MC2__ST_NCADS_AxisState();

		[FieldOffset(316)]
		public Tc2_MC2__ST_NCADS_AxisFunctions Functions = new Tc2_MC2__ST_NCADS_AxisFunctions();


	}
}
