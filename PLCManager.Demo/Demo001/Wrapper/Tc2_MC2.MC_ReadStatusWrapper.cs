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
	/// Name from PLC:Tc2_MC2.MC_ReadStatus
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 136
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_MC_ReadStatusWrapper : BeckhoffStruct<Tc2_MC2_MC_ReadStatusWrapper, Tc2_MC2_MC_ReadStatus>
	{
		
		public Tc2_MC2_MC_ReadStatusWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Enable { get; init; }

		public IBaseData<bool> Valid { get; init; }

		public IBaseData<bool> Busy { get; init; }

		public IBaseData<bool> Error { get; init; }

		public IBaseData<uint> ErrorID { get; init; }

		public IBaseData<bool> ErrorStop { get; init; }

		public IBaseData<bool> Disabled { get; init; }

		public IBaseData<bool> Stopping { get; init; }

		public IBaseData<bool> StandStill { get; init; }

		public IBaseData<bool> DiscreteMotion { get; init; }

		public IBaseData<bool> ContinuousMotion { get; init; }

		public IBaseData<bool> SynchronizedMotion { get; init; }

		public IBaseData<bool> Homing { get; init; }

		public IBaseData<bool> ConstantVelocity { get; init; }

		public IBaseData<bool> Accelerating { get; init; }

		public IBaseData<bool> Decelerating { get; init; }

		public Tc2_MC2_ST_AxisStatusWrapper Status { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Enable;
			yield return Valid;
			yield return Busy;
			yield return Error;
			yield return ErrorID;
			yield return ErrorStop;
			yield return Disabled;
			yield return Stopping;
			yield return StandStill;
			yield return DiscreteMotion;
			yield return ContinuousMotion;
			yield return SynchronizedMotion;
			yield return Homing;
			yield return ConstantVelocity;
			yield return Accelerating;
			yield return Decelerating;
			yield return Status;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Enable):
					return Enable;
				case nameof(Valid):
					return Valid;
				case nameof(Busy):
					return Busy;
				case nameof(Error):
					return Error;
				case nameof(ErrorID):
					return ErrorID;
				case nameof(ErrorStop):
					return ErrorStop;
				case nameof(Disabled):
					return Disabled;
				case nameof(Stopping):
					return Stopping;
				case nameof(StandStill):
					return StandStill;
				case nameof(DiscreteMotion):
					return DiscreteMotion;
				case nameof(ContinuousMotion):
					return ContinuousMotion;
				case nameof(SynchronizedMotion):
					return SynchronizedMotion;
				case nameof(Homing):
					return Homing;
				case nameof(ConstantVelocity):
					return ConstantVelocity;
				case nameof(Accelerating):
					return Accelerating;
				case nameof(Decelerating):
					return Decelerating;
				case nameof(Status):
					return Status;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
