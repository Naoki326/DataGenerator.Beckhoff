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
	/// Name from PLC:MC.PLCTONC_AXIS_REF
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 128
	/// Comment from PLC: 
	/// <summary>
	public partial class MC_PLCTONC_AXIS_REFWrapper : BeckhoffStruct<MC_PLCTONC_AXIS_REFWrapper, MC_PLCTONC_AXIS_REF>
	{
		
		public MC_PLCTONC_AXIS_REFWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public MC_PLCTONC_AXIS_REF_CTRLWrapper ControlDWord { get; init; }

		public IBaseData<uint> Override { get; init; }

		public IBaseData<uint> AxisModeRequest { get; init; }

		public IBaseData<uint> AxisModeDWord { get; init; }

		public IBaseData<double> AxisModeLReal { get; init; }

		public IBaseData<double> PositionCorrection { get; init; }

		public IBaseData<double> ExtSetPos { get; init; }

		public IBaseData<double> ExtSetVelo { get; init; }

		public IBaseData<double> ExtSetAcc { get; init; }

		public IBaseData<int> ExtSetDirection { get; init; }

		public IBaseData<double> ExtControllerOutput { get; init; }

		public IBaseData<double> GearRatio1 { get; init; }

		public IBaseData<double> GearRatio2 { get; init; }

		public IBaseData<double> GearRatio3 { get; init; }

		public IBaseData<double> GearRatio4 { get; init; }

		public IBaseData<bool> MapState { get; init; }

		public IBaseData<byte> PlcCycleControl { get; init; }

		public IBaseData<byte> PlcCycleCount { get; init; }

		public IBaseData<double> ExtTorque { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return ControlDWord;
			yield return Override;
			yield return AxisModeRequest;
			yield return AxisModeDWord;
			yield return AxisModeLReal;
			yield return PositionCorrection;
			yield return ExtSetPos;
			yield return ExtSetVelo;
			yield return ExtSetAcc;
			yield return ExtSetDirection;
			yield return ExtControllerOutput;
			yield return GearRatio1;
			yield return GearRatio2;
			yield return GearRatio3;
			yield return GearRatio4;
			yield return MapState;
			yield return PlcCycleControl;
			yield return PlcCycleCount;
			yield return ExtTorque;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(ControlDWord):
					return ControlDWord;
				case nameof(Override):
					return Override;
				case nameof(AxisModeRequest):
					return AxisModeRequest;
				case nameof(AxisModeDWord):
					return AxisModeDWord;
				case nameof(AxisModeLReal):
					return AxisModeLReal;
				case nameof(PositionCorrection):
					return PositionCorrection;
				case nameof(ExtSetPos):
					return ExtSetPos;
				case nameof(ExtSetVelo):
					return ExtSetVelo;
				case nameof(ExtSetAcc):
					return ExtSetAcc;
				case nameof(ExtSetDirection):
					return ExtSetDirection;
				case nameof(ExtControllerOutput):
					return ExtControllerOutput;
				case nameof(GearRatio1):
					return GearRatio1;
				case nameof(GearRatio2):
					return GearRatio2;
				case nameof(GearRatio3):
					return GearRatio3;
				case nameof(GearRatio4):
					return GearRatio4;
				case nameof(MapState):
					return MapState;
				case nameof(PlcCycleControl):
					return PlcCycleControl;
				case nameof(PlcCycleCount):
					return PlcCycleCount;
				case nameof(ExtTorque):
					return ExtTorque;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
