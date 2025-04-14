using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.AXIS_REF
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 1136
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_AXIS_REF
	{
		public Tc2_MC2_AXIS_REF()
		{
		}

		[FieldOffset(8)]
		public MC_PLCTONC_AXIS_REF PlcToNc = new MC_PLCTONC_AXIS_REF();

		[FieldOffset(136)]
		public MC_NCTOPLC_AXIS_REF NcToPlc = new MC_NCTOPLC_AXIS_REF();

		[FieldOffset(392)]
		public Tc2_MC2_ST_AdsAddress ADS = new Tc2_MC2_ST_AdsAddress();

		[FieldOffset(424)]
		public Tc2_MC2_ST_AxisStatus Status = new Tc2_MC2_ST_AxisStatus();

		[FieldOffset(520)]
		public Tc2_MC2_ST_DriveAddress DriveAddress = new Tc2_MC2_ST_DriveAddress();

		[FieldOffset(604)]
		public Tc2_MC2__InternalAxisRefData _internal = new Tc2_MC2__InternalAxisRefData();

		[FieldOffset(624)]
		public Int128 Storage = new Int128();


	}
}
