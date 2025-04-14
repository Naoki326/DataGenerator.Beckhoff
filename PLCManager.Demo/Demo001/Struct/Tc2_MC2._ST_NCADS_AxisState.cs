using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._ST_NCADS_AxisState
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 108
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2__ST_NCADS_AxisState
	{
		public Tc2_MC2__ST_NCADS_AxisState()
		{
		}

		[FieldOffset(0)]
		public uint IDXGRP;

		[FieldOffset(4)]
		public Tc2_MC2__ST_NCADS_IDXOFFS_AxisState IDXOFFS = new Tc2_MC2__ST_NCADS_IDXOFFS_AxisState();


	}
}
