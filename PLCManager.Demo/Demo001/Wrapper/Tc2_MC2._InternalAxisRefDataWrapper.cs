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
	/// Name from PLC:Tc2_MC2._InternalAxisRefData
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 20
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2__InternalAxisRefDataWrapper : BeckhoffStruct<Tc2_MC2__InternalAxisRefDataWrapper, Tc2_MC2__InternalAxisRefData>
	{
		
		public Tc2_MC2__InternalAxisRefDataWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> NcCycleCounterAvailable { get; init; }

		public IBaseData<uint> NcCycleCounter_AtReadStatusCall { get; init; }

		public IBaseData<byte> LastTaskIndex_AtReadStatusCall { get; init; }

		public IBaseData<ushort> CounterSameTaskIndex_AtReadStatusCall { get; init; }

		public IBaseData<uint> PhasingCmdNo { get; init; }

		public IBaseData<bool> PhasingCmdTriggered { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return NcCycleCounterAvailable;
			yield return NcCycleCounter_AtReadStatusCall;
			yield return LastTaskIndex_AtReadStatusCall;
			yield return CounterSameTaskIndex_AtReadStatusCall;
			yield return PhasingCmdNo;
			yield return PhasingCmdTriggered;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(NcCycleCounterAvailable):
					return NcCycleCounterAvailable;
				case nameof(NcCycleCounter_AtReadStatusCall):
					return NcCycleCounter_AtReadStatusCall;
				case nameof(LastTaskIndex_AtReadStatusCall):
					return LastTaskIndex_AtReadStatusCall;
				case nameof(CounterSameTaskIndex_AtReadStatusCall):
					return CounterSameTaskIndex_AtReadStatusCall;
				case nameof(PhasingCmdNo):
					return PhasingCmdNo;
				case nameof(PhasingCmdTriggered):
					return PhasingCmdTriggered;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
