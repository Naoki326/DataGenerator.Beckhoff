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
	/// Name from PLC:FB_MotionControl
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 14152
	/// Comment from PLC: 
	/// <summary>
	public partial class FB_MotionControlWrapper : BeckhoffStruct<FB_MotionControlWrapper, FB_MotionControl>
	{
		
		public FB_MotionControlWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public DUT_MotionCMDWrapper CMD { get; init; }

		public DUT_AxisStateWrapper State { get; init; }

		public Tc2_MC2_MC_PowerWrapper fbPOWER { get; init; }

		public Tc2_MC2_MC_HomeWrapper fbHome { get; init; }

		public Tc2_MC2_MC_StopWrapper fbStop { get; init; }

		public Tc2_MC2_MC_HaltWrapper fbHalt { get; init; }

		public Tc2_MC2_MC_ResetWrapper fbMcreset { get; init; }

		public Tc2_MC2_MC_JogWrapper fbJog { get; init; }

		public Tc2_MC2_MC_MoveVelocityWrapper fbMoveVelo { get; init; }

		public Tc2_MC2_MC_MoveAbsoluteWrapper fbMoveAbs { get; init; }

		public Tc2_MC2_MC_MoveRelativeWrapper fbMoveRelative { get; init; }

		public Tc2_MC2_MC_ReadActualPositionWrapper fbCurrentPos { get; init; }

		public Tc2_MC2_MC_ReadStatusWrapper fbAxisStatus { get; init; }

		public Tc2_MC2_MC_ReadAxisErrorWrapper fbAxisErrorID { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return CMD;
			yield return State;
			yield return fbPOWER;
			yield return fbHome;
			yield return fbStop;
			yield return fbHalt;
			yield return fbMcreset;
			yield return fbJog;
			yield return fbMoveVelo;
			yield return fbMoveAbs;
			yield return fbMoveRelative;
			yield return fbCurrentPos;
			yield return fbAxisStatus;
			yield return fbAxisErrorID;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(CMD):
					return CMD;
				case nameof(State):
					return State;
				case nameof(fbPOWER):
					return fbPOWER;
				case nameof(fbHome):
					return fbHome;
				case nameof(fbStop):
					return fbStop;
				case nameof(fbHalt):
					return fbHalt;
				case nameof(fbMcreset):
					return fbMcreset;
				case nameof(fbJog):
					return fbJog;
				case nameof(fbMoveVelo):
					return fbMoveVelo;
				case nameof(fbMoveAbs):
					return fbMoveAbs;
				case nameof(fbMoveRelative):
					return fbMoveRelative;
				case nameof(fbCurrentPos):
					return fbCurrentPos;
				case nameof(fbAxisStatus):
					return fbAxisStatus;
				case nameof(fbAxisErrorID):
					return fbAxisErrorID;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
