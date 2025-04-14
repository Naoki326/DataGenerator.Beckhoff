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
	/// Name from PLC:MC.NCTOPLC_AXIS_REF_OPMODE
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 4
	/// Comment from PLC: 
	/// <summary>
	public partial class MC_NCTOPLC_AXIS_REF_OPMODEWrapper : BeckhoffStruct<MC_NCTOPLC_AXIS_REF_OPMODEWrapper, MC_NCTOPLC_AXIS_REF_OPMODE>
	{
		
		public MC_NCTOPLC_AXIS_REF_OPMODEWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> OpModePosAreaMonitoring { get; init; }

		public IBaseData<bool> OpModeTargetPosMonitoring { get; init; }

		public IBaseData<bool> OpModeLoop { get; init; }

		public IBaseData<bool> OpModeMotionMonitoring { get; init; }

		public IBaseData<bool> OpModePEHTimeMonitoring { get; init; }

		public IBaseData<bool> OpModeBacklashCompensation { get; init; }

		public IBaseData<bool> OpModeDelayedErrorReaction { get; init; }

		public IBaseData<bool> OpModeModulo { get; init; }

		public IBaseData<bool> OpModeSimulationAxis { get; init; }

		public IBaseData<bool> OpModeStopMonitoring { get; init; }

		public IBaseData<bool> OpModeOutputSmoothingFilter { get; init; }

		public IBaseData<bool> OpModePosLagMonitoring { get; init; }

		public IBaseData<bool> OpModeVeloLagMonitoring { get; init; }

		public IBaseData<bool> OpModeSoftLimitMinMonitoring { get; init; }

		public IBaseData<bool> OpModeSoftLimitMaxMonitoring { get; init; }

		public IBaseData<bool> OpModePosCorrection { get; init; }

		public IBaseData<bool> OpModeAllowSlaveCommands { get; init; }

		public IBaseData<bool> OpModeAllowExtSetAxisCommands { get; init; }

		public IBaseData<bool> ApplicationRequest { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return OpModePosAreaMonitoring;
			yield return OpModeTargetPosMonitoring;
			yield return OpModeLoop;
			yield return OpModeMotionMonitoring;
			yield return OpModePEHTimeMonitoring;
			yield return OpModeBacklashCompensation;
			yield return OpModeDelayedErrorReaction;
			yield return OpModeModulo;
			yield return OpModeSimulationAxis;
			yield return OpModeStopMonitoring;
			yield return OpModeOutputSmoothingFilter;
			yield return OpModePosLagMonitoring;
			yield return OpModeVeloLagMonitoring;
			yield return OpModeSoftLimitMinMonitoring;
			yield return OpModeSoftLimitMaxMonitoring;
			yield return OpModePosCorrection;
			yield return OpModeAllowSlaveCommands;
			yield return OpModeAllowExtSetAxisCommands;
			yield return ApplicationRequest;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(OpModePosAreaMonitoring):
					return OpModePosAreaMonitoring;
				case nameof(OpModeTargetPosMonitoring):
					return OpModeTargetPosMonitoring;
				case nameof(OpModeLoop):
					return OpModeLoop;
				case nameof(OpModeMotionMonitoring):
					return OpModeMotionMonitoring;
				case nameof(OpModePEHTimeMonitoring):
					return OpModePEHTimeMonitoring;
				case nameof(OpModeBacklashCompensation):
					return OpModeBacklashCompensation;
				case nameof(OpModeDelayedErrorReaction):
					return OpModeDelayedErrorReaction;
				case nameof(OpModeModulo):
					return OpModeModulo;
				case nameof(OpModeSimulationAxis):
					return OpModeSimulationAxis;
				case nameof(OpModeStopMonitoring):
					return OpModeStopMonitoring;
				case nameof(OpModeOutputSmoothingFilter):
					return OpModeOutputSmoothingFilter;
				case nameof(OpModePosLagMonitoring):
					return OpModePosLagMonitoring;
				case nameof(OpModeVeloLagMonitoring):
					return OpModeVeloLagMonitoring;
				case nameof(OpModeSoftLimitMinMonitoring):
					return OpModeSoftLimitMinMonitoring;
				case nameof(OpModeSoftLimitMaxMonitoring):
					return OpModeSoftLimitMaxMonitoring;
				case nameof(OpModePosCorrection):
					return OpModePosCorrection;
				case nameof(OpModeAllowSlaveCommands):
					return OpModeAllowSlaveCommands;
				case nameof(OpModeAllowExtSetAxisCommands):
					return OpModeAllowExtSetAxisCommands;
				case nameof(ApplicationRequest):
					return ApplicationRequest;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
