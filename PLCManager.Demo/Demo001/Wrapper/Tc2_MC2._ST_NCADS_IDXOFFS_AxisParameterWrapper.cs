using System.Runtime.InteropServices;
using System.Collections.Generic;
using TwinCAT.Ads;
using PLCManager.Demo.Enum;
using PLCManager.Demo.Struct;
using PlcCore.Beckhoff;
using PlcCore.Data;

namespace PLCManager.Demo.Wrapper
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._ST_NCADS_IDXOFFS_AxisParameter
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 204
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2__ST_NCADS_IDXOFFS_AxisParameterWrapper : BeckhoffStruct<Tc2_MC2__ST_NCADS_IDXOFFS_AxisParameterWrapper, Tc2_MC2__ST_NCADS_IDXOFFS_AxisParameter>
	{
		
		public Tc2_MC2__ST_NCADS_IDXOFFS_AxisParameterWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<uint> PARAMSTRUCT { get; init; }

		public IBaseData<uint> ID { get; init; }

		public IBaseData<uint> NAME { get; init; }

		public IBaseData<uint> AXISTYPE { get; init; }

		public IBaseData<uint> CYCLETIME { get; init; }

		public IBaseData<uint> UNITNAME { get; init; }

		public IBaseData<uint> VELOREFSEARCH { get; init; }

		public IBaseData<uint> VELOSYNCSEARCH { get; init; }

		public IBaseData<uint> VELOSLOWMANUAL { get; init; }

		public IBaseData<uint> VELOFASTMANUAL { get; init; }

		public IBaseData<uint> VELOFAST { get; init; }

		public IBaseData<uint> POSAREAENABLE { get; init; }

		public IBaseData<uint> POSAREARANGE { get; init; }

		public IBaseData<uint> MOTCNTRLENABLE { get; init; }

		public IBaseData<uint> MOTCNTRLTIME { get; init; }

		public IBaseData<uint> LOOPENABLE { get; init; }

		public IBaseData<uint> LOOPDISTANCE { get; init; }

		public IBaseData<uint> TARGETPOSENA { get; init; }

		public IBaseData<uint> TARGETPOSRANGE { get; init; }

		public IBaseData<uint> TARGETPOSTIME { get; init; }

		public IBaseData<uint> PULSDISTPOS { get; init; }

		public IBaseData<uint> PULSDISTNEG { get; init; }

		public IBaseData<uint> FADINGACCELERATION { get; init; }

		public IBaseData<uint> FASTAXISSTOPSIGNALTYPE { get; init; }

		public IBaseData<uint> UNITFLAGS { get; init; }

		public IBaseData<uint> VELOMAXIMUM { get; init; }

		public IBaseData<uint> MOTCNTRLRANGE { get; init; }

		public IBaseData<uint> PEHCONTROLENA { get; init; }

		public IBaseData<uint> PEHCONTROLTIME { get; init; }

		public IBaseData<uint> BACKLASHCOMPENA { get; init; }

		public IBaseData<uint> BACKLASH { get; init; }

		public IBaseData<uint> DATAPERSISTENCE { get; init; }

		public IBaseData<uint> HWAMSADDR { get; init; }

		public IBaseData<uint> HWCHNNO { get; init; }

		public IBaseData<uint> APPLICATIONREQUEST { get; init; }

		public IBaseData<uint> ACC { get; init; }

		public IBaseData<uint> DEC { get; init; }

		public IBaseData<uint> JERK { get; init; }

		public IBaseData<uint> DELAY { get; init; }

		public IBaseData<uint> OVERRIDETYPE { get; init; }

		public IBaseData<uint> VELOJUMPFACTOR { get; init; }

		public IBaseData<uint> REDUCTIONFEEDBACK { get; init; }

		public IBaseData<uint> TOLERANCEBALLAUXAXIS { get; init; }

		public IBaseData<uint> MAXPOSDEVIATIONAUXAXIS { get; init; }

		public IBaseData<uint> FASTACC { get; init; }

		public IBaseData<uint> FASTDEC { get; init; }

		public IBaseData<uint> FASTJERK { get; init; }

		public IBaseData<uint> REF_POS { get; init; }

		public IBaseData<uint> ENCSEARCHDIR { get; init; }

		public IBaseData<uint> ENCSYNCDIR { get; init; }

		public IBaseData<uint> ENCREFMODE { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return PARAMSTRUCT;
			yield return ID;
			yield return NAME;
			yield return AXISTYPE;
			yield return CYCLETIME;
			yield return UNITNAME;
			yield return VELOREFSEARCH;
			yield return VELOSYNCSEARCH;
			yield return VELOSLOWMANUAL;
			yield return VELOFASTMANUAL;
			yield return VELOFAST;
			yield return POSAREAENABLE;
			yield return POSAREARANGE;
			yield return MOTCNTRLENABLE;
			yield return MOTCNTRLTIME;
			yield return LOOPENABLE;
			yield return LOOPDISTANCE;
			yield return TARGETPOSENA;
			yield return TARGETPOSRANGE;
			yield return TARGETPOSTIME;
			yield return PULSDISTPOS;
			yield return PULSDISTNEG;
			yield return FADINGACCELERATION;
			yield return FASTAXISSTOPSIGNALTYPE;
			yield return UNITFLAGS;
			yield return VELOMAXIMUM;
			yield return MOTCNTRLRANGE;
			yield return PEHCONTROLENA;
			yield return PEHCONTROLTIME;
			yield return BACKLASHCOMPENA;
			yield return BACKLASH;
			yield return DATAPERSISTENCE;
			yield return HWAMSADDR;
			yield return HWCHNNO;
			yield return APPLICATIONREQUEST;
			yield return ACC;
			yield return DEC;
			yield return JERK;
			yield return DELAY;
			yield return OVERRIDETYPE;
			yield return VELOJUMPFACTOR;
			yield return REDUCTIONFEEDBACK;
			yield return TOLERANCEBALLAUXAXIS;
			yield return MAXPOSDEVIATIONAUXAXIS;
			yield return FASTACC;
			yield return FASTDEC;
			yield return FASTJERK;
			yield return REF_POS;
			yield return ENCSEARCHDIR;
			yield return ENCSYNCDIR;
			yield return ENCREFMODE;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(PARAMSTRUCT):
					return PARAMSTRUCT;
				case nameof(ID):
					return ID;
				case nameof(NAME):
					return NAME;
				case nameof(AXISTYPE):
					return AXISTYPE;
				case nameof(CYCLETIME):
					return CYCLETIME;
				case nameof(UNITNAME):
					return UNITNAME;
				case nameof(VELOREFSEARCH):
					return VELOREFSEARCH;
				case nameof(VELOSYNCSEARCH):
					return VELOSYNCSEARCH;
				case nameof(VELOSLOWMANUAL):
					return VELOSLOWMANUAL;
				case nameof(VELOFASTMANUAL):
					return VELOFASTMANUAL;
				case nameof(VELOFAST):
					return VELOFAST;
				case nameof(POSAREAENABLE):
					return POSAREAENABLE;
				case nameof(POSAREARANGE):
					return POSAREARANGE;
				case nameof(MOTCNTRLENABLE):
					return MOTCNTRLENABLE;
				case nameof(MOTCNTRLTIME):
					return MOTCNTRLTIME;
				case nameof(LOOPENABLE):
					return LOOPENABLE;
				case nameof(LOOPDISTANCE):
					return LOOPDISTANCE;
				case nameof(TARGETPOSENA):
					return TARGETPOSENA;
				case nameof(TARGETPOSRANGE):
					return TARGETPOSRANGE;
				case nameof(TARGETPOSTIME):
					return TARGETPOSTIME;
				case nameof(PULSDISTPOS):
					return PULSDISTPOS;
				case nameof(PULSDISTNEG):
					return PULSDISTNEG;
				case nameof(FADINGACCELERATION):
					return FADINGACCELERATION;
				case nameof(FASTAXISSTOPSIGNALTYPE):
					return FASTAXISSTOPSIGNALTYPE;
				case nameof(UNITFLAGS):
					return UNITFLAGS;
				case nameof(VELOMAXIMUM):
					return VELOMAXIMUM;
				case nameof(MOTCNTRLRANGE):
					return MOTCNTRLRANGE;
				case nameof(PEHCONTROLENA):
					return PEHCONTROLENA;
				case nameof(PEHCONTROLTIME):
					return PEHCONTROLTIME;
				case nameof(BACKLASHCOMPENA):
					return BACKLASHCOMPENA;
				case nameof(BACKLASH):
					return BACKLASH;
				case nameof(DATAPERSISTENCE):
					return DATAPERSISTENCE;
				case nameof(HWAMSADDR):
					return HWAMSADDR;
				case nameof(HWCHNNO):
					return HWCHNNO;
				case nameof(APPLICATIONREQUEST):
					return APPLICATIONREQUEST;
				case nameof(ACC):
					return ACC;
				case nameof(DEC):
					return DEC;
				case nameof(JERK):
					return JERK;
				case nameof(DELAY):
					return DELAY;
				case nameof(OVERRIDETYPE):
					return OVERRIDETYPE;
				case nameof(VELOJUMPFACTOR):
					return VELOJUMPFACTOR;
				case nameof(REDUCTIONFEEDBACK):
					return REDUCTIONFEEDBACK;
				case nameof(TOLERANCEBALLAUXAXIS):
					return TOLERANCEBALLAUXAXIS;
				case nameof(MAXPOSDEVIATIONAUXAXIS):
					return MAXPOSDEVIATIONAUXAXIS;
				case nameof(FASTACC):
					return FASTACC;
				case nameof(FASTDEC):
					return FASTDEC;
				case nameof(FASTJERK):
					return FASTJERK;
				case nameof(REF_POS):
					return REF_POS;
				case nameof(ENCSEARCHDIR):
					return ENCSEARCHDIR;
				case nameof(ENCSYNCDIR):
					return ENCSYNCDIR;
				case nameof(ENCREFMODE):
					return ENCREFMODE;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
