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
	/// Name from PLC:PLC.PlcAppSystemInfo
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 256
	/// Comment from PLC: 
	/// <summary>
	public partial class PLC_PlcAppSystemInfoWrapper : BeckhoffStruct<PLC_PlcAppSystemInfoWrapper, PLC_PlcAppSystemInfo>
	{
		
		public PLC_PlcAppSystemInfoWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<uint> ObjId { get; init; }

		public IBaseData<uint> TaskCnt { get; init; }

		public IBaseData<uint> OnlineChangeCnt { get; init; }

		public IBaseData<int> Flags { get; init; }

		public IBaseData<ushort> AdsPort { get; init; }

		public IBaseData<bool> BootDataLoaded { get; init; }

		public IBaseData<bool> OldBootData { get; init; }

		public IBaseData<uint> AppTimestamp { get; init; }

		public IBaseData<bool> KeepOutputsOnBP { get; init; }

		public IBaseData<bool> ShutdownInProgress { get; init; }

		public IBaseData<bool> LicensesPending { get; init; }

		public IBaseData<bool> BSODOccured { get; init; }

		public IBaseData<bool> LoggedIn { get; init; }

		public IBaseData<PLC_EPlcPersistentStatus> PersistentStatus{ get; init; }

		public IBaseString AppName{ get; init; }

		public IBaseString ProjectName{ get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return ObjId;
			yield return TaskCnt;
			yield return OnlineChangeCnt;
			yield return Flags;
			yield return AdsPort;
			yield return BootDataLoaded;
			yield return OldBootData;
			yield return AppTimestamp;
			yield return KeepOutputsOnBP;
			yield return ShutdownInProgress;
			yield return LicensesPending;
			yield return BSODOccured;
			yield return LoggedIn;
			yield return PersistentStatus;
			yield return AppName;
			yield return ProjectName;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(ObjId):
					return ObjId;
				case nameof(TaskCnt):
					return TaskCnt;
				case nameof(OnlineChangeCnt):
					return OnlineChangeCnt;
				case nameof(Flags):
					return Flags;
				case nameof(AdsPort):
					return AdsPort;
				case nameof(BootDataLoaded):
					return BootDataLoaded;
				case nameof(OldBootData):
					return OldBootData;
				case nameof(AppTimestamp):
					return AppTimestamp;
				case nameof(KeepOutputsOnBP):
					return KeepOutputsOnBP;
				case nameof(ShutdownInProgress):
					return ShutdownInProgress;
				case nameof(LicensesPending):
					return LicensesPending;
				case nameof(BSODOccured):
					return BSODOccured;
				case nameof(LoggedIn):
					return LoggedIn;
				case nameof(PersistentStatus):
					return PersistentStatus;
				case nameof(AppName):
					return AppName;
				case nameof(ProjectName):
					return ProjectName;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
