using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._ST_NCADS_IDXOFFS_AxisParameter
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 204
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2__ST_NCADS_IDXOFFS_AxisParameter
	{
		public Tc2_MC2__ST_NCADS_IDXOFFS_AxisParameter()
		{
		}

		[FieldOffset(0)]
		public uint PARAMSTRUCT;

		[FieldOffset(4)]
		public uint ID;

		[FieldOffset(8)]
		public uint NAME;

		[FieldOffset(12)]
		public uint AXISTYPE;

		[FieldOffset(16)]
		public uint CYCLETIME;

		[FieldOffset(20)]
		public uint UNITNAME;

		[FieldOffset(24)]
		public uint VELOREFSEARCH;

		[FieldOffset(28)]
		public uint VELOSYNCSEARCH;

		[FieldOffset(32)]
		public uint VELOSLOWMANUAL;

		[FieldOffset(36)]
		public uint VELOFASTMANUAL;

		[FieldOffset(40)]
		public uint VELOFAST;

		[FieldOffset(44)]
		public uint POSAREAENABLE;

		[FieldOffset(48)]
		public uint POSAREARANGE;

		[FieldOffset(52)]
		public uint MOTCNTRLENABLE;

		[FieldOffset(56)]
		public uint MOTCNTRLTIME;

		[FieldOffset(60)]
		public uint LOOPENABLE;

		[FieldOffset(64)]
		public uint LOOPDISTANCE;

		[FieldOffset(68)]
		public uint TARGETPOSENA;

		[FieldOffset(72)]
		public uint TARGETPOSRANGE;

		[FieldOffset(76)]
		public uint TARGETPOSTIME;

		[FieldOffset(80)]
		public uint PULSDISTPOS;

		[FieldOffset(84)]
		public uint PULSDISTNEG;

		[FieldOffset(88)]
		public uint FADINGACCELERATION;

		[FieldOffset(92)]
		public uint FASTAXISSTOPSIGNALTYPE;

		[FieldOffset(96)]
		public uint UNITFLAGS;

		[FieldOffset(100)]
		public uint VELOMAXIMUM;

		[FieldOffset(104)]
		public uint MOTCNTRLRANGE;

		[FieldOffset(108)]
		public uint PEHCONTROLENA;

		[FieldOffset(112)]
		public uint PEHCONTROLTIME;

		[FieldOffset(116)]
		public uint BACKLASHCOMPENA;

		[FieldOffset(120)]
		public uint BACKLASH;

		[FieldOffset(124)]
		public uint DATAPERSISTENCE;

		[FieldOffset(128)]
		public uint HWAMSADDR;

		[FieldOffset(132)]
		public uint HWCHNNO;

		[FieldOffset(136)]
		public uint APPLICATIONREQUEST;

		[FieldOffset(140)]
		public uint ACC;

		[FieldOffset(144)]
		public uint DEC;

		[FieldOffset(148)]
		public uint JERK;

		[FieldOffset(152)]
		public uint DELAY;

		[FieldOffset(156)]
		public uint OVERRIDETYPE;

		[FieldOffset(160)]
		public uint VELOJUMPFACTOR;

		[FieldOffset(164)]
		public uint REDUCTIONFEEDBACK;

		[FieldOffset(168)]
		public uint TOLERANCEBALLAUXAXIS;

		[FieldOffset(172)]
		public uint MAXPOSDEVIATIONAUXAXIS;

		[FieldOffset(176)]
		public uint FASTACC;

		[FieldOffset(180)]
		public uint FASTDEC;

		[FieldOffset(184)]
		public uint FASTJERK;

		[FieldOffset(188)]
		public uint REF_POS;

		[FieldOffset(192)]
		public uint ENCSEARCHDIR;

		[FieldOffset(196)]
		public uint ENCSYNCDIR;

		[FieldOffset(200)]
		public uint ENCREFMODE;


	}
}
