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
	
	internal static class GetClass_467d18ed48e2438088586334c06e582e
	{
		internal static ref PLC_PlcAppSystemInfo Get_AppInfo(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__AppInfo;
		internal static ref uint Get_AppInfo_Dot_ObjId(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__AppInfo.ObjId;
		internal static ref uint Get_AppInfo_Dot_TaskCnt(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__AppInfo.TaskCnt;
		internal static ref uint Get_AppInfo_Dot_OnlineChangeCnt(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__AppInfo.OnlineChangeCnt;
		internal static ref int Get_AppInfo_Dot_Flags(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__AppInfo.Flags;
		internal static ref ushort Get_AppInfo_Dot_AdsPort(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__AppInfo.AdsPort;
		internal static ref bool Get_AppInfo_Dot_BootDataLoaded(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__AppInfo.BootDataLoaded;
		internal static ref bool Get_AppInfo_Dot_OldBootData(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__AppInfo.OldBootData;
		internal static ref uint Get_AppInfo_Dot_AppTimestamp(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__AppInfo.AppTimestamp;
		internal static ref bool Get_AppInfo_Dot_KeepOutputsOnBP(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__AppInfo.KeepOutputsOnBP;
		internal static ref bool Get_AppInfo_Dot_ShutdownInProgress(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__AppInfo.ShutdownInProgress;
		internal static ref bool Get_AppInfo_Dot_LicensesPending(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__AppInfo.LicensesPending;
		internal static ref bool Get_AppInfo_Dot_BSODOccured(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__AppInfo.BSODOccured;
		internal static ref bool Get_AppInfo_Dot_LoggedIn(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__AppInfo.LoggedIn;
		internal static ref PLC_EPlcPersistentStatus Get_AppInfo_Dot_PersistentStatus(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__AppInfo.PersistentStatus;
		internal static ref String64 Get_AppInfo_Dot_AppName(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__AppInfo.AppName;
		internal static ref String64 Get_AppInfo_Dot_ProjectName(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__AppInfo.ProjectName;
		internal static ref PLC_PlcTaskSystemInfo1 Get_TaskInfo(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__TaskInfo;
		internal static ref PLC_PlcTaskSystemInfo Get_TaskInfo0(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__TaskInfo.Item_0;
		internal static ref uint Get_TaskInfo0_Dot_ObjId(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__TaskInfo.Item_0.ObjId;
		internal static ref uint Get_TaskInfo0_Dot_CycleTime(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__TaskInfo.Item_0.CycleTime;
		internal static ref ushort Get_TaskInfo0_Dot_Priority(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__TaskInfo.Item_0.Priority;
		internal static ref ushort Get_TaskInfo0_Dot_AdsPort(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__TaskInfo.Item_0.AdsPort;
		internal static ref uint Get_TaskInfo0_Dot_CycleCount(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__TaskInfo.Item_0.CycleCount;
		internal static ref long Get_TaskInfo0_Dot_DcTaskTime(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__TaskInfo.Item_0.DcTaskTime;
		internal static ref uint Get_TaskInfo0_Dot_LastExecTime(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__TaskInfo.Item_0.LastExecTime;
		internal static ref bool Get_TaskInfo0_Dot_FirstCycle(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__TaskInfo.Item_0.FirstCycle;
		internal static ref bool Get_TaskInfo0_Dot_CycleTimeExceeded(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__TaskInfo.Item_0.CycleTimeExceeded;
		internal static ref bool Get_TaskInfo0_Dot_InCallAfterOutputUpdate(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__TaskInfo.Item_0.InCallAfterOutputUpdate;
		internal static ref bool Get_TaskInfo0_Dot_RTViolation(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__TaskInfo.Item_0.RTViolation;
		internal static ref String64 Get_TaskInfo0_Dot_TaskName(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__TaskInfo.Item_0.TaskName;
		internal static ref uint Get_TaskPouOid_PlcTask(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__TaskPouOid_PlcTask;
		internal static ref uint Get_TaskOid_PlcTask(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref__TaskOid_PlcTask;
		internal static ref _Implicit_Task_Info Get__PlcTask(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask;
		internal static ref int Get__PlcTask_Dot_dwVersion(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.dwVersion;
		internal static ref short Get__PlcTask_Dot_nPriority(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.nPriority;
		internal static ref _Implicit_KindOfTask Get__PlcTask_Dot_KindOf(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.KindOf;
		internal static ref bool Get__PlcTask_Dot_bWatchdog(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.bWatchdog;
		internal static ref bool Get__PlcTask_Dot_bProfilingTask(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.bProfilingTask;
		internal static ref int Get__PlcTask_Dot_dwWatchdogSensitivity(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.dwWatchdogSensitivity;
		internal static ref int Get__PlcTask_Dot_dwInterval(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.dwInterval;
		internal static ref int Get__PlcTask_Dot_dwWatchdogTime(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.dwWatchdogTime;
		internal static ref int Get__PlcTask_Dot_dwLastCycleTime(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.dwLastCycleTime;
		internal static ref int Get__PlcTask_Dot_dwAverageCycleTime(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.dwAverageCycleTime;
		internal static ref int Get__PlcTask_Dot_dwMaxCycleTime(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.dwMaxCycleTime;
		internal static ref int Get__PlcTask_Dot_dwMinCycleTime(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.dwMinCycleTime;
		internal static ref int Get__PlcTask_Dot_diJitter(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.diJitter;
		internal static ref int Get__PlcTask_Dot_diJitterMin(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.diJitterMin;
		internal static ref int Get__PlcTask_Dot_diJitterMax(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.diJitterMax;
		internal static ref int Get__PlcTask_Dot_dwCycleCount(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.dwCycleCount;
		internal static ref short Get__PlcTask_Dot_wTaskStatus(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.wTaskStatus;
		internal static ref short Get__PlcTask_Dot_wNumOfJitterDistributions(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.wNumOfJitterDistributions;
		internal static ref bool Get__PlcTask_Dot_bWithinSPSTimeSlicing(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.bWithinSPSTimeSlicing;
		internal static ref byte Get__PlcTask_Dot_byDummy(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.byDummy;
		internal static ref bool Get__PlcTask_Dot_bShouldBlock(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.bShouldBlock;
		internal static ref bool Get__PlcTask_Dot_bActive(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.bActive;
		internal static ref int Get__PlcTask_Dot_dwIECCycleCount(this TwinCAT_SystemInfoVarListWrapper parent) => ref parent.ref___PlcTask.dwIECCycleCount;
	}

}
