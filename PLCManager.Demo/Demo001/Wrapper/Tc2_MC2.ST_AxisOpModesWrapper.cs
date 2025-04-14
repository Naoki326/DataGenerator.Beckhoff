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
	/// Name from PLC:Tc2_MC2.ST_AxisOpModes
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 17
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_ST_AxisOpModesWrapper : BeckhoffStruct<Tc2_MC2_ST_AxisOpModesWrapper, Tc2_MC2_ST_AxisOpModes>
	{
		
		public Tc2_MC2_ST_AxisOpModesWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> PositionAreaMonitoring { get; init; }

		public IBaseData<bool> TargetPositionMonitoring { get; init; }

		public IBaseData<bool> LoopMode { get; init; }

		public IBaseData<bool> MotionMonitoring { get; init; }

		public IBaseData<bool> PEHTimeMonitoring { get; init; }

		public IBaseData<bool> BacklashCompensation { get; init; }

		public IBaseData<bool> DelayedErrorReaction { get; init; }

		public IBaseData<bool> Modulo { get; init; }

		public IBaseData<bool> SimulationAxis { get; init; }

		public IBaseData<bool> StopMonitoring { get; init; }

		public IBaseData<bool> PositionLagMonitoring { get; init; }

		public IBaseData<bool> VelocityLagMonitoring { get; init; }

		public IBaseData<bool> SoftLimitMinMonitoring { get; init; }

		public IBaseData<bool> SoftLimitMaxMonitoring { get; init; }

		public IBaseData<bool> PositionCorrection { get; init; }

		public IBaseData<bool> AllowSlaveCommands { get; init; }

		public IBaseData<bool> AllowExtSetAxisCommands { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return PositionAreaMonitoring;
			yield return TargetPositionMonitoring;
			yield return LoopMode;
			yield return MotionMonitoring;
			yield return PEHTimeMonitoring;
			yield return BacklashCompensation;
			yield return DelayedErrorReaction;
			yield return Modulo;
			yield return SimulationAxis;
			yield return StopMonitoring;
			yield return PositionLagMonitoring;
			yield return VelocityLagMonitoring;
			yield return SoftLimitMinMonitoring;
			yield return SoftLimitMaxMonitoring;
			yield return PositionCorrection;
			yield return AllowSlaveCommands;
			yield return AllowExtSetAxisCommands;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(PositionAreaMonitoring):
					return PositionAreaMonitoring;
				case nameof(TargetPositionMonitoring):
					return TargetPositionMonitoring;
				case nameof(LoopMode):
					return LoopMode;
				case nameof(MotionMonitoring):
					return MotionMonitoring;
				case nameof(PEHTimeMonitoring):
					return PEHTimeMonitoring;
				case nameof(BacklashCompensation):
					return BacklashCompensation;
				case nameof(DelayedErrorReaction):
					return DelayedErrorReaction;
				case nameof(Modulo):
					return Modulo;
				case nameof(SimulationAxis):
					return SimulationAxis;
				case nameof(StopMonitoring):
					return StopMonitoring;
				case nameof(PositionLagMonitoring):
					return PositionLagMonitoring;
				case nameof(VelocityLagMonitoring):
					return VelocityLagMonitoring;
				case nameof(SoftLimitMinMonitoring):
					return SoftLimitMinMonitoring;
				case nameof(SoftLimitMaxMonitoring):
					return SoftLimitMaxMonitoring;
				case nameof(PositionCorrection):
					return PositionCorrection;
				case nameof(AllowSlaveCommands):
					return AllowSlaveCommands;
				case nameof(AllowExtSetAxisCommands):
					return AllowExtSetAxisCommands;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
