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
	/// Name from PLC:_Implicit_Task_Info
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 112
	/// Comment from PLC: 
	/// <summary>
	public partial class _Implicit_Task_InfoWrapper : BeckhoffStruct<_Implicit_Task_InfoWrapper, _Implicit_Task_Info>
	{
		
		public _Implicit_Task_InfoWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<int> dwVersion { get; init; }

		public IBaseData<short> nPriority { get; init; }

		public IBaseData<_Implicit_KindOfTask> KindOf{ get; init; }

		public IBaseData<bool> bWatchdog { get; init; }

		public IBaseData<bool> bProfilingTask { get; init; }

		public IBaseData<int> dwWatchdogSensitivity { get; init; }

		public IBaseData<int> dwInterval { get; init; }

		public IBaseData<int> dwWatchdogTime { get; init; }

		public IBaseData<int> dwLastCycleTime { get; init; }

		public IBaseData<int> dwAverageCycleTime { get; init; }

		public IBaseData<int> dwMaxCycleTime { get; init; }

		public IBaseData<int> dwMinCycleTime { get; init; }

		public IBaseData<int> diJitter { get; init; }

		public IBaseData<int> diJitterMin { get; init; }

		public IBaseData<int> diJitterMax { get; init; }

		public IBaseData<int> dwCycleCount { get; init; }

		public IBaseData<short> wTaskStatus { get; init; }

		public IBaseData<short> wNumOfJitterDistributions { get; init; }

		public IBaseData<bool> bWithinSPSTimeSlicing { get; init; }

		public IBaseData<byte> byDummy { get; init; }

		public IBaseData<bool> bShouldBlock { get; init; }

		public IBaseData<bool> bActive { get; init; }

		public IBaseData<int> dwIECCycleCount { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return dwVersion;
			yield return nPriority;
			yield return KindOf;
			yield return bWatchdog;
			yield return bProfilingTask;
			yield return dwWatchdogSensitivity;
			yield return dwInterval;
			yield return dwWatchdogTime;
			yield return dwLastCycleTime;
			yield return dwAverageCycleTime;
			yield return dwMaxCycleTime;
			yield return dwMinCycleTime;
			yield return diJitter;
			yield return diJitterMin;
			yield return diJitterMax;
			yield return dwCycleCount;
			yield return wTaskStatus;
			yield return wNumOfJitterDistributions;
			yield return bWithinSPSTimeSlicing;
			yield return byDummy;
			yield return bShouldBlock;
			yield return bActive;
			yield return dwIECCycleCount;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(dwVersion):
					return dwVersion;
				case nameof(nPriority):
					return nPriority;
				case nameof(KindOf):
					return KindOf;
				case nameof(bWatchdog):
					return bWatchdog;
				case nameof(bProfilingTask):
					return bProfilingTask;
				case nameof(dwWatchdogSensitivity):
					return dwWatchdogSensitivity;
				case nameof(dwInterval):
					return dwInterval;
				case nameof(dwWatchdogTime):
					return dwWatchdogTime;
				case nameof(dwLastCycleTime):
					return dwLastCycleTime;
				case nameof(dwAverageCycleTime):
					return dwAverageCycleTime;
				case nameof(dwMaxCycleTime):
					return dwMaxCycleTime;
				case nameof(dwMinCycleTime):
					return dwMinCycleTime;
				case nameof(diJitter):
					return diJitter;
				case nameof(diJitterMin):
					return diJitterMin;
				case nameof(diJitterMax):
					return diJitterMax;
				case nameof(dwCycleCount):
					return dwCycleCount;
				case nameof(wTaskStatus):
					return wTaskStatus;
				case nameof(wNumOfJitterDistributions):
					return wNumOfJitterDistributions;
				case nameof(bWithinSPSTimeSlicing):
					return bWithinSPSTimeSlicing;
				case nameof(byDummy):
					return byDummy;
				case nameof(bShouldBlock):
					return bShouldBlock;
				case nameof(bActive):
					return bActive;
				case nameof(dwIECCycleCount):
					return dwIECCycleCount;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
