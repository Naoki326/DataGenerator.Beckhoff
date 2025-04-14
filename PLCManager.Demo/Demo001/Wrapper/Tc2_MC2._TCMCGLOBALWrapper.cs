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
	/// Name from PLC:Tc2_MC2._TCMCGLOBAL
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 896
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2__TCMCGLOBALWrapper : BeckhoffStruct<Tc2_MC2__TCMCGLOBALWrapper, Tc2_MC2__TCMCGLOBAL>
	{
		
		public Tc2_MC2__TCMCGLOBALWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<ushort> NCPORT_TCMC { get; init; }

		public IBaseData<ushort> NCPORT_TCMC_COUPLING { get; init; }

		public IBaseString NCNETID_TCMC{ get; init; }

		public IBaseData<ushort> NCPORT_TCMC_CAM { get; init; }

		public IBaseData<ushort> NCPORT_TCMC_CAM_FAST { get; init; }

		public IBaseString NCNETID_TCMC_CAM{ get; init; }

		public IBaseData<ushort> NCPORT_TCMC_SUPERPOSITION { get; init; }

		public IBaseData<ushort> NCPORT_TCMC_RESET { get; init; }

		public IBaseData<int> NcDeviceInfoTcMainVersion { get; init; }

		public IBaseData<int> NcDeviceInfoTcSubVersion { get; init; }

		public IBaseData<int> NcDeviceInfoNcDriverVersion { get; init; }

		public IBaseData<int> NcDeviceInfoNcVersion { get; init; }

		public IBaseString NcDeviceInfoNcName{ get; init; }

		public Tc2_MC2__ST_NCADS_AxisWrapper Axis { get; init; }

		public Tc2_MC2__ST_NCADS_TableWrapper Table { get; init; }

		public IBaseData<ushort> NCPORT_TCNCCAMMING_TABLEFUNCTION { get; init; }

		public IBaseData<uint> tTargetPosTimeOut { get; init; }

		public IBaseData<uint> tADSTimeOut { get; init; }

		public IBaseData<uint> tStopMonitoringTimeOut { get; init; }

		public IBaseData<short> NCTOPLC_FEEDBACK_MAXWAITCYCLES { get; init; }

		public Tc2_System_ADSRDDEVINFOWrapper fbADSRDDEVINFO { get; init; }

		public IBaseData<int> DeviceVersion { get; init; }

		public IBaseData<bool> Init { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return NCPORT_TCMC;
			yield return NCPORT_TCMC_COUPLING;
			yield return NCNETID_TCMC;
			yield return NCPORT_TCMC_CAM;
			yield return NCPORT_TCMC_CAM_FAST;
			yield return NCNETID_TCMC_CAM;
			yield return NCPORT_TCMC_SUPERPOSITION;
			yield return NCPORT_TCMC_RESET;
			yield return NcDeviceInfoTcMainVersion;
			yield return NcDeviceInfoTcSubVersion;
			yield return NcDeviceInfoNcDriverVersion;
			yield return NcDeviceInfoNcVersion;
			yield return NcDeviceInfoNcName;
			yield return Axis;
			yield return Table;
			yield return NCPORT_TCNCCAMMING_TABLEFUNCTION;
			yield return tTargetPosTimeOut;
			yield return tADSTimeOut;
			yield return tStopMonitoringTimeOut;
			yield return NCTOPLC_FEEDBACK_MAXWAITCYCLES;
			yield return fbADSRDDEVINFO;
			yield return DeviceVersion;
			yield return Init;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(NCPORT_TCMC):
					return NCPORT_TCMC;
				case nameof(NCPORT_TCMC_COUPLING):
					return NCPORT_TCMC_COUPLING;
				case nameof(NCNETID_TCMC):
					return NCNETID_TCMC;
				case nameof(NCPORT_TCMC_CAM):
					return NCPORT_TCMC_CAM;
				case nameof(NCPORT_TCMC_CAM_FAST):
					return NCPORT_TCMC_CAM_FAST;
				case nameof(NCNETID_TCMC_CAM):
					return NCNETID_TCMC_CAM;
				case nameof(NCPORT_TCMC_SUPERPOSITION):
					return NCPORT_TCMC_SUPERPOSITION;
				case nameof(NCPORT_TCMC_RESET):
					return NCPORT_TCMC_RESET;
				case nameof(NcDeviceInfoTcMainVersion):
					return NcDeviceInfoTcMainVersion;
				case nameof(NcDeviceInfoTcSubVersion):
					return NcDeviceInfoTcSubVersion;
				case nameof(NcDeviceInfoNcDriverVersion):
					return NcDeviceInfoNcDriverVersion;
				case nameof(NcDeviceInfoNcVersion):
					return NcDeviceInfoNcVersion;
				case nameof(NcDeviceInfoNcName):
					return NcDeviceInfoNcName;
				case nameof(Axis):
					return Axis;
				case nameof(Table):
					return Table;
				case nameof(NCPORT_TCNCCAMMING_TABLEFUNCTION):
					return NCPORT_TCNCCAMMING_TABLEFUNCTION;
				case nameof(tTargetPosTimeOut):
					return tTargetPosTimeOut;
				case nameof(tADSTimeOut):
					return tADSTimeOut;
				case nameof(tStopMonitoringTimeOut):
					return tStopMonitoringTimeOut;
				case nameof(NCTOPLC_FEEDBACK_MAXWAITCYCLES):
					return NCTOPLC_FEEDBACK_MAXWAITCYCLES;
				case nameof(fbADSRDDEVINFO):
					return fbADSRDDEVINFO;
				case nameof(DeviceVersion):
					return DeviceVersion;
				case nameof(Init):
					return Init;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
