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
	/// Name from PLC:ST_Motion
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 15560
	/// Comment from PLC: 
	/// <summary>
	public partial class ST_MotionWrapper : BeckhoffStruct<ST_MotionWrapper, ST_Motion>
	{
		
		public ST_MotionWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public DUT_MotionCMDWrapper ManualMotionCMD { get; init; }

		public DUT_MotionCMDWrapper AutoMotionCMD { get; init; }

		public Tc2_MC2_AXIS_REFWrapper AXIS_REFERENCE { get; init; }

		public FB_MotionControlWrapper AutoMotionAct { get; init; }

		public DUT_AxisStateWrapper AxisState { get; init; }

		public IBaseData<bool> ManualMove { get; init; }

		public IBaseData<uint> AxisInput { get; init; }

		public IBaseData<ushort> Hardware_AxisErrorID { get; init; }

		public IBaseData<ushort> State { get; init; }

		public IBaseData<short> Port { get; init; }

		public IBaseData<byte> nCtrl1 { get; init; }

		public IBaseData<byte> nCtrl2 { get; init; }

		public IBaseData<ushort> Controlword { get; init; }

		public IBaseData<sbyte> ModesOfOperation { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return ManualMotionCMD;
			yield return AutoMotionCMD;
			yield return AXIS_REFERENCE;
			yield return AutoMotionAct;
			yield return AxisState;
			yield return ManualMove;
			yield return AxisInput;
			yield return Hardware_AxisErrorID;
			yield return State;
			yield return Port;
			yield return nCtrl1;
			yield return nCtrl2;
			yield return Controlword;
			yield return ModesOfOperation;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(ManualMotionCMD):
					return ManualMotionCMD;
				case nameof(AutoMotionCMD):
					return AutoMotionCMD;
				case nameof(AXIS_REFERENCE):
					return AXIS_REFERENCE;
				case nameof(AutoMotionAct):
					return AutoMotionAct;
				case nameof(AxisState):
					return AxisState;
				case nameof(ManualMove):
					return ManualMove;
				case nameof(AxisInput):
					return AxisInput;
				case nameof(Hardware_AxisErrorID):
					return Hardware_AxisErrorID;
				case nameof(State):
					return State;
				case nameof(Port):
					return Port;
				case nameof(nCtrl1):
					return nCtrl1;
				case nameof(nCtrl2):
					return nCtrl2;
				case nameof(Controlword):
					return Controlword;
				case nameof(ModesOfOperation):
					return ModesOfOperation;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
