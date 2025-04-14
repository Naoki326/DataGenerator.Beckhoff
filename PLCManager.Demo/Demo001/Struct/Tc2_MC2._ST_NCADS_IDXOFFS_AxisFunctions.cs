using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._ST_NCADS_IDXOFFS_AxisFunctions
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 228
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2__ST_NCADS_IDXOFFS_AxisFunctions
	{
		public Tc2_MC2__ST_NCADS_IDXOFFS_AxisFunctions()
		{
		}

		[FieldOffset(0)]
		public uint RESET;

		[FieldOffset(4)]
		public uint STOP;

		[FieldOffset(8)]
		public uint CLEAR;

		[FieldOffset(12)]
		public uint EMERGENCYSTOP;

		[FieldOffset(16)]
		public uint PARAMETRIZEDSTOP;

		[FieldOffset(20)]
		public uint INITIALIZE;

		[FieldOffset(24)]
		public uint ORIENTEDSTOP;

		[FieldOffset(28)]
		public uint CALIBR;

		[FieldOffset(32)]
		public uint NEWTARGPOS;

		[FieldOffset(36)]
		public uint NEWTARGPOSANDVELO;

		[FieldOffset(40)]
		public uint CHANGEDYNAMICPARAM;

		[FieldOffset(44)]
		public uint UNIVERSALSTART;

		[FieldOffset(48)]
		public uint SLAVEUNIVERSALSTART;

		[FieldOffset(52)]
		public uint RELEASEAXISLOCK;

		[FieldOffset(56)]
		public uint SETEXTERNALERROR;

		[FieldOffset(60)]
		public uint SETPOS;

		[FieldOffset(64)]
		public uint SETCALFLAG;

		[FieldOffset(68)]
		public uint SETACTPOS;

		[FieldOffset(72)]
		public uint SETDRIVEPOS;

		[FieldOffset(76)]
		public uint SETENCODERSCALING;

		[FieldOffset(80)]
		public uint SETPOSONTHEFLY;

		[FieldOffset(84)]
		public uint START;

		[FieldOffset(88)]
		public uint STARTEXT;

		[FieldOffset(92)]
		public uint STARTVELOCHANGE;

		[FieldOffset(96)]
		public uint ENABLEEXTGEN;

		[FieldOffset(100)]
		public uint DISABLEEXTGEN;

		[FieldOffset(104)]
		public uint REVERSINGSEQUENCE;

		[FieldOffset(108)]
		public uint STARTDRVOUT;

		[FieldOffset(112)]
		public uint STOPDRVOUT;

		[FieldOffset(116)]
		public uint CHANGEDRVOUT;

		[FieldOffset(120)]
		public uint JUMPTOOVERRIDE;

		[FieldOffset(124)]
		public uint EXTSETGENUNIVERSALSTART;

		[FieldOffset(128)]
		public uint UNIVERSALTORQUESTART;

		[FieldOffset(132)]
		public uint STARTSCOM;

		[FieldOffset(136)]
		public uint STOPSCOM;

		[FieldOffset(140)]
		public uint PHASINGREQEUST;

		[FieldOffset(144)]
		public uint REINITIALIZEENCODER;

		[FieldOffset(148)]
		public uint CPL;

		[FieldOffset(152)]
		public uint DECPL;

		[FieldOffset(156)]
		public uint CPLCHANGE;

		[FieldOffset(160)]
		public uint TABCPLCHANGE;

		[FieldOffset(164)]
		public uint STOPSLAVE;

		[FieldOffset(168)]
		public uint CPLTAB;

		[FieldOffset(172)]
		public uint TABSLVACTIVCOR;

		[FieldOffset(176)]
		public uint TABSLVLEAVECYC;

		[FieldOffset(180)]
		public uint TABSLVCOROFFSET;

		[FieldOffset(184)]
		public uint TABSLVSCALING;

		[FieldOffset(188)]
		public uint CPLSOLOTAB;

		[FieldOffset(192)]
		public uint CPLSYNCHRONIZING;

		[FieldOffset(196)]
		public uint CAMSCALING;

		[FieldOffset(200)]
		public uint DISABLE;

		[FieldOffset(204)]
		public uint ENABLE;

		[FieldOffset(208)]
		public uint CHANGEAXISCTRLLOOP;

		[FieldOffset(212)]
		public uint DRIVEDISABLE;

		[FieldOffset(216)]
		public uint DRIVEENABLE;

		[FieldOffset(220)]
		public uint RELEASEBRAKE;

		[FieldOffset(224)]
		public uint RECONFIGURATE;


	}
}
