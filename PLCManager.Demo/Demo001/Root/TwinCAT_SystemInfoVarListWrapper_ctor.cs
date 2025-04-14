using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TwinCAT.Ads;
using PLCManager.Demo.Enum;
using PLCManager.Demo.Struct;
using PLCManager.Demo.Wrapper;
using PlcCore.Beckhoff;
using PlcCore.Data;

namespace PLCManager.Demo.Root
{

	/// <summary>
	/// Name from PLC:TwinCAT_SystemInfoVarList
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class TwinCAT_SystemInfoVarListWrapper : BaseData, IBaseData
	{
		public override IEnumerable<IBaseData> Children
		{
			get
			{
				yield return _AppInfo;
				yield return _TaskInfo;
				yield return _TaskPouOid_PlcTask;
				yield return _TaskOid_PlcTask;
				yield return __PlcTask;
			}
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(_AppInfo):
					return _AppInfo;
				case nameof(_TaskInfo):
					return _TaskInfo;
				case nameof(_TaskPouOid_PlcTask):
					return _TaskPouOid_PlcTask;
				case nameof(_TaskOid_PlcTask):
					return _TaskOid_PlcTask;
				case nameof(__PlcTask):
					return __PlcTask;
			}
			throw new KeyNotFoundException(name);
		}

		private readonly AdsClient client;

		public TwinCAT_SystemInfoVarListWrapper(AdsClient client)
		{
			this.client = client;

			_AppInfo = new PLC_PlcAppSystemInfoWrapper(this.Get_AppInfo, client, 16448, 2005752)
			{
				Name = "_AppInfo",
				ObjId = new BeckhoffUInt(this.Get_AppInfo_Dot_ObjId, client, 16448, 2005752){ Name = "ObjId" },
				TaskCnt = new BeckhoffUInt(this.Get_AppInfo_Dot_TaskCnt, client, 16448, 2005756){ Name = "TaskCnt" },
				OnlineChangeCnt = new BeckhoffUInt(this.Get_AppInfo_Dot_OnlineChangeCnt, client, 16448, 2005760){ Name = "OnlineChangeCnt" },
				Flags = new BeckhoffInt(this.Get_AppInfo_Dot_Flags, client, 16448, 2005764){ Name = "Flags" },
				AdsPort = new BeckhoffUShort(this.Get_AppInfo_Dot_AdsPort, client, 16448, 2005768){ Name = "AdsPort" },
				BootDataLoaded = new BeckhoffBool(this.Get_AppInfo_Dot_BootDataLoaded, client, 16448, 2005770){ Name = "BootDataLoaded" },
				OldBootData = new BeckhoffBool(this.Get_AppInfo_Dot_OldBootData, client, 16448, 2005771){ Name = "OldBootData" },
				AppTimestamp = new BeckhoffUInt(this.Get_AppInfo_Dot_AppTimestamp, client, 16448, 2005772){ Name = "AppTimestamp" },
				KeepOutputsOnBP = new BeckhoffBool(this.Get_AppInfo_Dot_KeepOutputsOnBP, client, 16448, 2005776){ Name = "KeepOutputsOnBP" },
				ShutdownInProgress = new BeckhoffBool(this.Get_AppInfo_Dot_ShutdownInProgress, client, 16448, 2005777){ Name = "ShutdownInProgress" },
				LicensesPending = new BeckhoffBool(this.Get_AppInfo_Dot_LicensesPending, client, 16448, 2005778){ Name = "LicensesPending" },
				BSODOccured = new BeckhoffBool(this.Get_AppInfo_Dot_BSODOccured, client, 16448, 2005779){ Name = "BSODOccured" },
				LoggedIn = new BeckhoffBool(this.Get_AppInfo_Dot_LoggedIn, client, 16448, 2005780){ Name = "LoggedIn" },
				PersistentStatus = new BeckhoffEnum<PLC_EPlcPersistentStatus>(this.Get_AppInfo_Dot_PersistentStatus, client, 16448, 2005781){ Name = "PersistentStatus" },
				AppName = new BeckhoffString<String64>(this.Get_AppInfo_Dot_AppName, client, 16448, 2005816){ Name = "AppName" },
				ProjectName = new BeckhoffString<String64>(this.Get_AppInfo_Dot_ProjectName, client, 16448, 2005880){ Name = "ProjectName" },
			};
			_TaskInfo = new BeckhoffStructArray<PLC_PlcTaskSystemInfo1, PLC_PlcTaskSystemInfoWrapper, PLC_PlcTaskSystemInfo>(this.Get_TaskInfo, client, 16448, 2006008,
				new uint[] { 16448 , },
				new uint[] { 2006008 , },
				new PLC_PlcTaskSystemInfoWrapper[]
				{
					new PLC_PlcTaskSystemInfoWrapper(this.Get_TaskInfo0, client, 16448, 2006008)
					{
						 Name = "Item_1",
						ObjId = new BeckhoffUInt(this.Get_TaskInfo0_Dot_ObjId, client, 16448, 2006008){ Name = "ObjId" },
						CycleTime = new BeckhoffUInt(this.Get_TaskInfo0_Dot_CycleTime, client, 16448, 2006012){ Name = "CycleTime" },
						Priority = new BeckhoffUShort(this.Get_TaskInfo0_Dot_Priority, client, 16448, 2006016){ Name = "Priority" },
						AdsPort = new BeckhoffUShort(this.Get_TaskInfo0_Dot_AdsPort, client, 16448, 2006018){ Name = "AdsPort" },
						CycleCount = new BeckhoffUInt(this.Get_TaskInfo0_Dot_CycleCount, client, 16448, 2006020){ Name = "CycleCount" },
						DcTaskTime = new BeckhoffLong(this.Get_TaskInfo0_Dot_DcTaskTime, client, 16448, 2006024){ Name = "DcTaskTime" },
						LastExecTime = new BeckhoffUInt(this.Get_TaskInfo0_Dot_LastExecTime, client, 16448, 2006032){ Name = "LastExecTime" },
						FirstCycle = new BeckhoffBool(this.Get_TaskInfo0_Dot_FirstCycle, client, 16448, 2006036){ Name = "FirstCycle" },
						CycleTimeExceeded = new BeckhoffBool(this.Get_TaskInfo0_Dot_CycleTimeExceeded, client, 16448, 2006037){ Name = "CycleTimeExceeded" },
						InCallAfterOutputUpdate = new BeckhoffBool(this.Get_TaskInfo0_Dot_InCallAfterOutputUpdate, client, 16448, 2006038){ Name = "InCallAfterOutputUpdate" },
						RTViolation = new BeckhoffBool(this.Get_TaskInfo0_Dot_RTViolation, client, 16448, 2006039){ Name = "RTViolation" },
						TaskName = new BeckhoffString<String64>(this.Get_TaskInfo0_Dot_TaskName, client, 16448, 2006072){ Name = "TaskName" },
					},
			}, false){ Name = "_TaskInfo" };
			_TaskPouOid_PlcTask = new BeckhoffUInt(this.Get_TaskPouOid_PlcTask, client, 16448, 2006136){ Name = "_TaskPouOid_PlcTask" };
			_TaskOid_PlcTask = new BeckhoffUInt(this.Get_TaskOid_PlcTask, client, 16448, 2006140){ Name = "_TaskOid_PlcTask" };
			__PlcTask = new _Implicit_Task_InfoWrapper(this.Get__PlcTask, client, 16448, 2006144)
			{
				Name = "__PlcTask",
				dwVersion = new BeckhoffInt(this.Get__PlcTask_Dot_dwVersion, client, 16448, 2006144){ Name = "dwVersion" },
				nPriority = new BeckhoffShort(this.Get__PlcTask_Dot_nPriority, client, 16448, 2006160){ Name = "nPriority" },
				KindOf = new BeckhoffEnum<_Implicit_KindOfTask>(this.Get__PlcTask_Dot_KindOf, client, 16448, 2006162){ Name = "KindOf" },
				bWatchdog = new BeckhoffBool(this.Get__PlcTask_Dot_bWatchdog, client, 16448, 2006164){ Name = "bWatchdog" },
				bProfilingTask = new BeckhoffBool(this.Get__PlcTask_Dot_bProfilingTask, client, 16448, 2006165){ Name = "bProfilingTask" },
				dwWatchdogSensitivity = new BeckhoffInt(this.Get__PlcTask_Dot_dwWatchdogSensitivity, client, 16448, 2006192){ Name = "dwWatchdogSensitivity" },
				dwInterval = new BeckhoffInt(this.Get__PlcTask_Dot_dwInterval, client, 16448, 2006196){ Name = "dwInterval" },
				dwWatchdogTime = new BeckhoffInt(this.Get__PlcTask_Dot_dwWatchdogTime, client, 16448, 2006200){ Name = "dwWatchdogTime" },
				dwLastCycleTime = new BeckhoffInt(this.Get__PlcTask_Dot_dwLastCycleTime, client, 16448, 2006204){ Name = "dwLastCycleTime" },
				dwAverageCycleTime = new BeckhoffInt(this.Get__PlcTask_Dot_dwAverageCycleTime, client, 16448, 2006208){ Name = "dwAverageCycleTime" },
				dwMaxCycleTime = new BeckhoffInt(this.Get__PlcTask_Dot_dwMaxCycleTime, client, 16448, 2006212){ Name = "dwMaxCycleTime" },
				dwMinCycleTime = new BeckhoffInt(this.Get__PlcTask_Dot_dwMinCycleTime, client, 16448, 2006216){ Name = "dwMinCycleTime" },
				diJitter = new BeckhoffInt(this.Get__PlcTask_Dot_diJitter, client, 16448, 2006220){ Name = "diJitter" },
				diJitterMin = new BeckhoffInt(this.Get__PlcTask_Dot_diJitterMin, client, 16448, 2006224){ Name = "diJitterMin" },
				diJitterMax = new BeckhoffInt(this.Get__PlcTask_Dot_diJitterMax, client, 16448, 2006228){ Name = "diJitterMax" },
				dwCycleCount = new BeckhoffInt(this.Get__PlcTask_Dot_dwCycleCount, client, 16448, 2006232){ Name = "dwCycleCount" },
				wTaskStatus = new BeckhoffShort(this.Get__PlcTask_Dot_wTaskStatus, client, 16448, 2006236){ Name = "wTaskStatus" },
				wNumOfJitterDistributions = new BeckhoffShort(this.Get__PlcTask_Dot_wNumOfJitterDistributions, client, 16448, 2006238){ Name = "wNumOfJitterDistributions" },
				bWithinSPSTimeSlicing = new BeckhoffBool(this.Get__PlcTask_Dot_bWithinSPSTimeSlicing, client, 16448, 2006248){ Name = "bWithinSPSTimeSlicing" },
				byDummy = new BeckhoffByte(this.Get__PlcTask_Dot_byDummy, client, 16448, 2006249){ Name = "byDummy" },
				bShouldBlock = new BeckhoffBool(this.Get__PlcTask_Dot_bShouldBlock, client, 16448, 2006250){ Name = "bShouldBlock" },
				bActive = new BeckhoffBool(this.Get__PlcTask_Dot_bActive, client, 16448, 2006251){ Name = "bActive" },
				dwIECCycleCount = new BeckhoffInt(this.Get__PlcTask_Dot_dwIECCycleCount, client, 16448, 2006252){ Name = "dwIECCycleCount" },
			};
		}

		private bool disposedValue;
		
		private void Dispose(bool disposing)
		{
		    if (!disposedValue)
		    {
		        if (disposing)
		        {
		            // TODO: 释放托管状态(托管对象)
		        }
		
		        // TODO: 释放未托管的资源(未托管的对象)并重写终结器
		        // TODO: 将大型字段设置为 null
		        disposedValue = true;
		    }
		}
		
		// TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器
		~TwinCAT_SystemInfoVarListWrapper()
		{
		    // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
		    Dispose(disposing: false);
		}
		
		public override void Dispose()
		{
		    // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
		    Dispose(disposing: true);
		    GC.SuppressFinalize(this);
		}
	}

}
