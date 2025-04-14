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
	/// Name from PLC:Tc2_MC2._ST_NCADS_IDXOFFS_AxisFunctions
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 228
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2__ST_NCADS_IDXOFFS_AxisFunctionsWrapper : BeckhoffStruct<Tc2_MC2__ST_NCADS_IDXOFFS_AxisFunctionsWrapper, Tc2_MC2__ST_NCADS_IDXOFFS_AxisFunctions>
	{
		
		public Tc2_MC2__ST_NCADS_IDXOFFS_AxisFunctionsWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<uint> RESET { get; init; }

		public IBaseData<uint> STOP { get; init; }

		public IBaseData<uint> CLEAR { get; init; }

		public IBaseData<uint> EMERGENCYSTOP { get; init; }

		public IBaseData<uint> PARAMETRIZEDSTOP { get; init; }

		public IBaseData<uint> INITIALIZE { get; init; }

		public IBaseData<uint> ORIENTEDSTOP { get; init; }

		public IBaseData<uint> CALIBR { get; init; }

		public IBaseData<uint> NEWTARGPOS { get; init; }

		public IBaseData<uint> NEWTARGPOSANDVELO { get; init; }

		public IBaseData<uint> CHANGEDYNAMICPARAM { get; init; }

		public IBaseData<uint> UNIVERSALSTART { get; init; }

		public IBaseData<uint> SLAVEUNIVERSALSTART { get; init; }

		public IBaseData<uint> RELEASEAXISLOCK { get; init; }

		public IBaseData<uint> SETEXTERNALERROR { get; init; }

		public IBaseData<uint> SETPOS { get; init; }

		public IBaseData<uint> SETCALFLAG { get; init; }

		public IBaseData<uint> SETACTPOS { get; init; }

		public IBaseData<uint> SETDRIVEPOS { get; init; }

		public IBaseData<uint> SETENCODERSCALING { get; init; }

		public IBaseData<uint> SETPOSONTHEFLY { get; init; }

		public IBaseData<uint> START { get; init; }

		public IBaseData<uint> STARTEXT { get; init; }

		public IBaseData<uint> STARTVELOCHANGE { get; init; }

		public IBaseData<uint> ENABLEEXTGEN { get; init; }

		public IBaseData<uint> DISABLEEXTGEN { get; init; }

		public IBaseData<uint> REVERSINGSEQUENCE { get; init; }

		public IBaseData<uint> STARTDRVOUT { get; init; }

		public IBaseData<uint> STOPDRVOUT { get; init; }

		public IBaseData<uint> CHANGEDRVOUT { get; init; }

		public IBaseData<uint> JUMPTOOVERRIDE { get; init; }

		public IBaseData<uint> EXTSETGENUNIVERSALSTART { get; init; }

		public IBaseData<uint> UNIVERSALTORQUESTART { get; init; }

		public IBaseData<uint> STARTSCOM { get; init; }

		public IBaseData<uint> STOPSCOM { get; init; }

		public IBaseData<uint> PHASINGREQEUST { get; init; }

		public IBaseData<uint> REINITIALIZEENCODER { get; init; }

		public IBaseData<uint> CPL { get; init; }

		public IBaseData<uint> DECPL { get; init; }

		public IBaseData<uint> CPLCHANGE { get; init; }

		public IBaseData<uint> TABCPLCHANGE { get; init; }

		public IBaseData<uint> STOPSLAVE { get; init; }

		public IBaseData<uint> CPLTAB { get; init; }

		public IBaseData<uint> TABSLVACTIVCOR { get; init; }

		public IBaseData<uint> TABSLVLEAVECYC { get; init; }

		public IBaseData<uint> TABSLVCOROFFSET { get; init; }

		public IBaseData<uint> TABSLVSCALING { get; init; }

		public IBaseData<uint> CPLSOLOTAB { get; init; }

		public IBaseData<uint> CPLSYNCHRONIZING { get; init; }

		public IBaseData<uint> CAMSCALING { get; init; }

		public IBaseData<uint> DISABLE { get; init; }

		public IBaseData<uint> ENABLE { get; init; }

		public IBaseData<uint> CHANGEAXISCTRLLOOP { get; init; }

		public IBaseData<uint> DRIVEDISABLE { get; init; }

		public IBaseData<uint> DRIVEENABLE { get; init; }

		public IBaseData<uint> RELEASEBRAKE { get; init; }

		public IBaseData<uint> RECONFIGURATE { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return RESET;
			yield return STOP;
			yield return CLEAR;
			yield return EMERGENCYSTOP;
			yield return PARAMETRIZEDSTOP;
			yield return INITIALIZE;
			yield return ORIENTEDSTOP;
			yield return CALIBR;
			yield return NEWTARGPOS;
			yield return NEWTARGPOSANDVELO;
			yield return CHANGEDYNAMICPARAM;
			yield return UNIVERSALSTART;
			yield return SLAVEUNIVERSALSTART;
			yield return RELEASEAXISLOCK;
			yield return SETEXTERNALERROR;
			yield return SETPOS;
			yield return SETCALFLAG;
			yield return SETACTPOS;
			yield return SETDRIVEPOS;
			yield return SETENCODERSCALING;
			yield return SETPOSONTHEFLY;
			yield return START;
			yield return STARTEXT;
			yield return STARTVELOCHANGE;
			yield return ENABLEEXTGEN;
			yield return DISABLEEXTGEN;
			yield return REVERSINGSEQUENCE;
			yield return STARTDRVOUT;
			yield return STOPDRVOUT;
			yield return CHANGEDRVOUT;
			yield return JUMPTOOVERRIDE;
			yield return EXTSETGENUNIVERSALSTART;
			yield return UNIVERSALTORQUESTART;
			yield return STARTSCOM;
			yield return STOPSCOM;
			yield return PHASINGREQEUST;
			yield return REINITIALIZEENCODER;
			yield return CPL;
			yield return DECPL;
			yield return CPLCHANGE;
			yield return TABCPLCHANGE;
			yield return STOPSLAVE;
			yield return CPLTAB;
			yield return TABSLVACTIVCOR;
			yield return TABSLVLEAVECYC;
			yield return TABSLVCOROFFSET;
			yield return TABSLVSCALING;
			yield return CPLSOLOTAB;
			yield return CPLSYNCHRONIZING;
			yield return CAMSCALING;
			yield return DISABLE;
			yield return ENABLE;
			yield return CHANGEAXISCTRLLOOP;
			yield return DRIVEDISABLE;
			yield return DRIVEENABLE;
			yield return RELEASEBRAKE;
			yield return RECONFIGURATE;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(RESET):
					return RESET;
				case nameof(STOP):
					return STOP;
				case nameof(CLEAR):
					return CLEAR;
				case nameof(EMERGENCYSTOP):
					return EMERGENCYSTOP;
				case nameof(PARAMETRIZEDSTOP):
					return PARAMETRIZEDSTOP;
				case nameof(INITIALIZE):
					return INITIALIZE;
				case nameof(ORIENTEDSTOP):
					return ORIENTEDSTOP;
				case nameof(CALIBR):
					return CALIBR;
				case nameof(NEWTARGPOS):
					return NEWTARGPOS;
				case nameof(NEWTARGPOSANDVELO):
					return NEWTARGPOSANDVELO;
				case nameof(CHANGEDYNAMICPARAM):
					return CHANGEDYNAMICPARAM;
				case nameof(UNIVERSALSTART):
					return UNIVERSALSTART;
				case nameof(SLAVEUNIVERSALSTART):
					return SLAVEUNIVERSALSTART;
				case nameof(RELEASEAXISLOCK):
					return RELEASEAXISLOCK;
				case nameof(SETEXTERNALERROR):
					return SETEXTERNALERROR;
				case nameof(SETPOS):
					return SETPOS;
				case nameof(SETCALFLAG):
					return SETCALFLAG;
				case nameof(SETACTPOS):
					return SETACTPOS;
				case nameof(SETDRIVEPOS):
					return SETDRIVEPOS;
				case nameof(SETENCODERSCALING):
					return SETENCODERSCALING;
				case nameof(SETPOSONTHEFLY):
					return SETPOSONTHEFLY;
				case nameof(START):
					return START;
				case nameof(STARTEXT):
					return STARTEXT;
				case nameof(STARTVELOCHANGE):
					return STARTVELOCHANGE;
				case nameof(ENABLEEXTGEN):
					return ENABLEEXTGEN;
				case nameof(DISABLEEXTGEN):
					return DISABLEEXTGEN;
				case nameof(REVERSINGSEQUENCE):
					return REVERSINGSEQUENCE;
				case nameof(STARTDRVOUT):
					return STARTDRVOUT;
				case nameof(STOPDRVOUT):
					return STOPDRVOUT;
				case nameof(CHANGEDRVOUT):
					return CHANGEDRVOUT;
				case nameof(JUMPTOOVERRIDE):
					return JUMPTOOVERRIDE;
				case nameof(EXTSETGENUNIVERSALSTART):
					return EXTSETGENUNIVERSALSTART;
				case nameof(UNIVERSALTORQUESTART):
					return UNIVERSALTORQUESTART;
				case nameof(STARTSCOM):
					return STARTSCOM;
				case nameof(STOPSCOM):
					return STOPSCOM;
				case nameof(PHASINGREQEUST):
					return PHASINGREQEUST;
				case nameof(REINITIALIZEENCODER):
					return REINITIALIZEENCODER;
				case nameof(CPL):
					return CPL;
				case nameof(DECPL):
					return DECPL;
				case nameof(CPLCHANGE):
					return CPLCHANGE;
				case nameof(TABCPLCHANGE):
					return TABCPLCHANGE;
				case nameof(STOPSLAVE):
					return STOPSLAVE;
				case nameof(CPLTAB):
					return CPLTAB;
				case nameof(TABSLVACTIVCOR):
					return TABSLVACTIVCOR;
				case nameof(TABSLVLEAVECYC):
					return TABSLVLEAVECYC;
				case nameof(TABSLVCOROFFSET):
					return TABSLVCOROFFSET;
				case nameof(TABSLVSCALING):
					return TABSLVSCALING;
				case nameof(CPLSOLOTAB):
					return CPLSOLOTAB;
				case nameof(CPLSYNCHRONIZING):
					return CPLSYNCHRONIZING;
				case nameof(CAMSCALING):
					return CAMSCALING;
				case nameof(DISABLE):
					return DISABLE;
				case nameof(ENABLE):
					return ENABLE;
				case nameof(CHANGEAXISCTRLLOOP):
					return CHANGEAXISCTRLLOOP;
				case nameof(DRIVEDISABLE):
					return DRIVEDISABLE;
				case nameof(DRIVEENABLE):
					return DRIVEENABLE;
				case nameof(RELEASEBRAKE):
					return RELEASEBRAKE;
				case nameof(RECONFIGURATE):
					return RECONFIGURATE;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
