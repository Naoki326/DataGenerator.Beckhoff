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
	/// Name from PLC:PLC.PlcTaskSystemInfo
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 128
	/// Comment from PLC: 
	/// <summary>
	public partial class PLC_PlcTaskSystemInfoWrapper : BeckhoffStruct<PLC_PlcTaskSystemInfoWrapper, PLC_PlcTaskSystemInfo>
	{
		
		public PLC_PlcTaskSystemInfoWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<uint> ObjId { get; init; }

		public IBaseData<uint> CycleTime { get; init; }

		public IBaseData<ushort> Priority { get; init; }

		public IBaseData<ushort> AdsPort { get; init; }

		public IBaseData<uint> CycleCount { get; init; }

		public IBaseData<long> DcTaskTime { get; init; }

		public IBaseData<uint> LastExecTime { get; init; }

		public IBaseData<bool> FirstCycle { get; init; }

		public IBaseData<bool> CycleTimeExceeded { get; init; }

		public IBaseData<bool> InCallAfterOutputUpdate { get; init; }

		public IBaseData<bool> RTViolation { get; init; }

		public IBaseString TaskName{ get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return ObjId;
			yield return CycleTime;
			yield return Priority;
			yield return AdsPort;
			yield return CycleCount;
			yield return DcTaskTime;
			yield return LastExecTime;
			yield return FirstCycle;
			yield return CycleTimeExceeded;
			yield return InCallAfterOutputUpdate;
			yield return RTViolation;
			yield return TaskName;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(ObjId):
					return ObjId;
				case nameof(CycleTime):
					return CycleTime;
				case nameof(Priority):
					return Priority;
				case nameof(AdsPort):
					return AdsPort;
				case nameof(CycleCount):
					return CycleCount;
				case nameof(DcTaskTime):
					return DcTaskTime;
				case nameof(LastExecTime):
					return LastExecTime;
				case nameof(FirstCycle):
					return FirstCycle;
				case nameof(CycleTimeExceeded):
					return CycleTimeExceeded;
				case nameof(InCallAfterOutputUpdate):
					return InCallAfterOutputUpdate;
				case nameof(RTViolation):
					return RTViolation;
				case nameof(TaskName):
					return TaskName;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
