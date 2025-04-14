using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._TCMCGLOBAL
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 896
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2__TCMCGLOBAL
	{
		public Tc2_MC2__TCMCGLOBAL()
		{
		}

		[FieldOffset(8)]
		public ushort NCPORT_TCMC;

		[FieldOffset(10)]
		public ushort NCPORT_TCMC_COUPLING;

		[FieldOffset(12)]
		public String24 NCNETID_TCMC;

		[FieldOffset(36)]
		public ushort NCPORT_TCMC_CAM;

		[FieldOffset(38)]
		public ushort NCPORT_TCMC_CAM_FAST;

		[FieldOffset(40)]
		public String24 NCNETID_TCMC_CAM;

		[FieldOffset(64)]
		public ushort NCPORT_TCMC_SUPERPOSITION;

		[FieldOffset(66)]
		public ushort NCPORT_TCMC_RESET;

		[FieldOffset(68)]
		public int NcDeviceInfoTcMainVersion;

		[FieldOffset(72)]
		public int NcDeviceInfoTcSubVersion;

		[FieldOffset(76)]
		public int NcDeviceInfoNcDriverVersion;

		[FieldOffset(80)]
		public int NcDeviceInfoNcVersion;

		[FieldOffset(84)]
		public String20 NcDeviceInfoNcName;

		[FieldOffset(104)]
		public Tc2_MC2__ST_NCADS_Axis Axis = new Tc2_MC2__ST_NCADS_Axis();

		[FieldOffset(652)]
		public Tc2_MC2__ST_NCADS_Table Table = new Tc2_MC2__ST_NCADS_Table();

		[FieldOffset(696)]
		public ushort NCPORT_TCNCCAMMING_TABLEFUNCTION;

		[FieldOffset(700)]
		[MarshalAs(UnmanagedType.U4)]
		public uint tTargetPosTimeOut;

		[FieldOffset(704)]
		[MarshalAs(UnmanagedType.U4)]
		public uint tADSTimeOut;

		[FieldOffset(708)]
		[MarshalAs(UnmanagedType.U4)]
		public uint tStopMonitoringTimeOut;

		[FieldOffset(712)]
		public short NCTOPLC_FEEDBACK_MAXWAITCYCLES;

		[FieldOffset(720)]
		public Tc2_System_ADSRDDEVINFO fbADSRDDEVINFO = new Tc2_System_ADSRDDEVINFO();

		[FieldOffset(888)]
		public int DeviceVersion;

		[FieldOffset(892)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Init;


	}
}
