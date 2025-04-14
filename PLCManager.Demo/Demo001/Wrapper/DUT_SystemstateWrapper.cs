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
	/// Name from PLC:DUT_Systemstate
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 10
	/// Comment from PLC: 
	/// <summary>
	public partial class DUT_SystemstateWrapper : BeckhoffStruct<DUT_SystemstateWrapper, DUT_Systemstate>
	{
		
		public DUT_SystemstateWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> AutoAllow { get; init; }

		public IBaseData<bool> HomeRequest { get; init; }

		public IBaseData<short> HomeStep { get; init; }

		public IBaseData<bool> HomeAllow { get; init; }

		public IBaseData<bool> Homing { get; init; }

		public IBaseData<bool> HomeFinished { get; init; }

		public IBaseData<bool> AutoRun { get; init; }

		public IBaseData<bool> Fault { get; init; }

		public IBaseData<bool> OnlineTcpAlarm { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return AutoAllow;
			yield return HomeRequest;
			yield return HomeStep;
			yield return HomeAllow;
			yield return Homing;
			yield return HomeFinished;
			yield return AutoRun;
			yield return Fault;
			yield return OnlineTcpAlarm;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(AutoAllow):
					return AutoAllow;
				case nameof(HomeRequest):
					return HomeRequest;
				case nameof(HomeStep):
					return HomeStep;
				case nameof(HomeAllow):
					return HomeAllow;
				case nameof(Homing):
					return Homing;
				case nameof(HomeFinished):
					return HomeFinished;
				case nameof(AutoRun):
					return AutoRun;
				case nameof(Fault):
					return Fault;
				case nameof(OnlineTcpAlarm):
					return OnlineTcpAlarm;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
