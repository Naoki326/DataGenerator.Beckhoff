using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.ST_TorqueControlOptions
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 16
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_ST_TorqueControlOptions
	{
		public Tc2_MC2_ST_TorqueControlOptions()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool EnableManualTorqueStartValue;

		[FieldOffset(8)]
		public double ManualTorqueStartValue;


	}
}
