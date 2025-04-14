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
	/// Name from PLC:Tc2_MC2._ST_NCADS_IDXOFFS_AxisState
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 104
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2__ST_NCADS_IDXOFFS_AxisStateWrapper : BeckhoffStruct<Tc2_MC2__ST_NCADS_IDXOFFS_AxisStateWrapper, Tc2_MC2__ST_NCADS_IDXOFFS_AxisState>
	{
		
		public Tc2_MC2__ST_NCADS_IDXOFFS_AxisStateWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<uint> ONLINESTRUCT { get; init; }

		public IBaseData<uint> ERROR { get; init; }

		public IBaseData<uint> SETTASKCYCLE { get; init; }

		public IBaseData<uint> SETPOS { get; init; }

		public IBaseData<uint> SETVELO { get; init; }

		public IBaseData<uint> SETACC { get; init; }

		public IBaseData<uint> MODULOSETPOS { get; init; }

		public IBaseData<uint> MODULOSETTURNS { get; init; }

		public IBaseData<uint> SETDIR { get; init; }

		public IBaseData<uint> TARGETPOSITION { get; init; }

		public IBaseData<uint> REMAININGTIMEANDPOS { get; init; }

		public IBaseData<uint> STOPINFORMATION { get; init; }

		public IBaseData<uint> SETTASKCYCLE_WITHOUTCORR { get; init; }

		public IBaseData<uint> SETPOS_WITHOUTCORR { get; init; }

		public IBaseData<uint> SETVELO_WITHOUTCORR { get; init; }

		public IBaseData<uint> SETACC_WITHOUTCORR { get; init; }

		public IBaseData<uint> SETDIR_WITHOUTCORR { get; init; }

		public IBaseData<uint> COUPLESTATE { get; init; }

		public IBaseData<uint> CPLPARAMS { get; init; }

		public IBaseData<uint> CPLFACTOR { get; init; }

		public IBaseData<uint> AXISCTRLLOOPIDX { get; init; }

		public IBaseData<uint> AXISSETPOINTGENIDX { get; init; }

		public IBaseData<uint> CPLCHARACVALUES { get; init; }

		public IBaseData<uint> CAMINFO { get; init; }

		public IBaseData<uint> CAMSTATUS { get; init; }

		public IBaseData<uint> ENCODERINITIALIZATIONDONE { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return ONLINESTRUCT;
			yield return ERROR;
			yield return SETTASKCYCLE;
			yield return SETPOS;
			yield return SETVELO;
			yield return SETACC;
			yield return MODULOSETPOS;
			yield return MODULOSETTURNS;
			yield return SETDIR;
			yield return TARGETPOSITION;
			yield return REMAININGTIMEANDPOS;
			yield return STOPINFORMATION;
			yield return SETTASKCYCLE_WITHOUTCORR;
			yield return SETPOS_WITHOUTCORR;
			yield return SETVELO_WITHOUTCORR;
			yield return SETACC_WITHOUTCORR;
			yield return SETDIR_WITHOUTCORR;
			yield return COUPLESTATE;
			yield return CPLPARAMS;
			yield return CPLFACTOR;
			yield return AXISCTRLLOOPIDX;
			yield return AXISSETPOINTGENIDX;
			yield return CPLCHARACVALUES;
			yield return CAMINFO;
			yield return CAMSTATUS;
			yield return ENCODERINITIALIZATIONDONE;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(ONLINESTRUCT):
					return ONLINESTRUCT;
				case nameof(ERROR):
					return ERROR;
				case nameof(SETTASKCYCLE):
					return SETTASKCYCLE;
				case nameof(SETPOS):
					return SETPOS;
				case nameof(SETVELO):
					return SETVELO;
				case nameof(SETACC):
					return SETACC;
				case nameof(MODULOSETPOS):
					return MODULOSETPOS;
				case nameof(MODULOSETTURNS):
					return MODULOSETTURNS;
				case nameof(SETDIR):
					return SETDIR;
				case nameof(TARGETPOSITION):
					return TARGETPOSITION;
				case nameof(REMAININGTIMEANDPOS):
					return REMAININGTIMEANDPOS;
				case nameof(STOPINFORMATION):
					return STOPINFORMATION;
				case nameof(SETTASKCYCLE_WITHOUTCORR):
					return SETTASKCYCLE_WITHOUTCORR;
				case nameof(SETPOS_WITHOUTCORR):
					return SETPOS_WITHOUTCORR;
				case nameof(SETVELO_WITHOUTCORR):
					return SETVELO_WITHOUTCORR;
				case nameof(SETACC_WITHOUTCORR):
					return SETACC_WITHOUTCORR;
				case nameof(SETDIR_WITHOUTCORR):
					return SETDIR_WITHOUTCORR;
				case nameof(COUPLESTATE):
					return COUPLESTATE;
				case nameof(CPLPARAMS):
					return CPLPARAMS;
				case nameof(CPLFACTOR):
					return CPLFACTOR;
				case nameof(AXISCTRLLOOPIDX):
					return AXISCTRLLOOPIDX;
				case nameof(AXISSETPOINTGENIDX):
					return AXISSETPOINTGENIDX;
				case nameof(CPLCHARACVALUES):
					return CPLCHARACVALUES;
				case nameof(CAMINFO):
					return CAMINFO;
				case nameof(CAMSTATUS):
					return CAMSTATUS;
				case nameof(ENCODERINITIALIZATIONDONE):
					return ENCODERINITIALIZATIONDONE;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
