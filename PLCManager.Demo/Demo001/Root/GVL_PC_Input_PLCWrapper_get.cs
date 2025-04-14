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
	
	internal static class GetClass_502331a00d35431a873f8ee233ea80fd
	{
		internal static ref bool GetG_In_bAllHome(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_In_bAllHome;
		internal static ref bool GetG_IN_bAutoRun(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_bAutoRun;
		internal static ref bool GetG_IN_bInitial(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_bInitial;
		internal static ref Bool30 GetG_In_Manual_Axis_bHomeStart(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_In_Manual_Axis_bHomeStart;
		internal static ref Bool30 GetG_In_Manual_Axis_AbsStart(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_In_Manual_Axis_AbsStart;
		internal static ref bool GetG_IN_bIMH_Home(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_bIMH_Home;
		internal static ref bool GetG_IN_bIMH_loadCase(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_bIMH_loadCase;
		internal static ref bool GetG_IN_bIMH_UnloadCase(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_bIMH_UnloadCase;
		internal static ref bool GetG_In_bIMH_Start(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_In_bIMH_Start;
		internal static ref Double30 GetG_Out_Axis_AbsPos(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_Out_Axis_AbsPos;
		internal static ref bool GetG_In_bIMH_Auto_Run(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_In_bIMH_Auto_Run;
		internal static ref bool GetG_IN_bOMH_Home(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_bOMH_Home;
		internal static ref bool GetG_IN_bOMH_loadCase(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_bOMH_loadCase;
		internal static ref bool GetG_IN_bOMH_UnloadCase(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_bOMH_UnloadCase;
		internal static ref bool GetG_In_bOMH_Start(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_In_bOMH_Start;
		internal static ref bool GetG_In_bOMH_Auto_Run(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_In_bOMH_Auto_Run;
		internal static ref bool GetG_IN_bFSU_Home(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_bFSU_Home;
		internal static ref bool GetG_IN_bFSU_Strat(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_bFSU_Strat;
		internal static ref ushort GetG_Alarm_Index(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_Alarm_Index;
		internal static ref short GetG_IN_Valve_Index(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_Valve_Index;
		internal static ref short GetG_IN_Sensor_Index(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_Sensor_Index;
		internal static ref short GetG_IN_Manual_Axis_Index(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_Manual_Axis_Index;
		internal static ref short GetG_IN_Manual_Axis_Home_Index(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_Manual_Axis_Home_Index;
		internal static ref bool GetG_IN_Barcode_Suceess(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_Barcode_Suceess;
		internal static ref bool GetG_IN_Barcode_Fail(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_Barcode_Fail;
		internal static ref bool GetG_IN_CleanVision_Sucess(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_CleanVision_Sucess;
		internal static ref bool GetG_IN_CleanVision_Fail(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_CleanVision_Fail;
		internal static ref short GetG_IN_TransBase_Bonding_Pos(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_TransBase_Bonding_Pos;
		internal static ref bool GetG_IN_TransBase_Request(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_TransBase_Request;
		internal static ref bool GetG_IN_Bonding_Cam_Result(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_Bonding_Cam_Result;
		internal static ref bool GetG_IN_Bonding_Visoion_Sucess(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_Bonding_Visoion_Sucess;
		internal static ref bool GetG_IN_WAF_LOAD_Start(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_WAF_LOAD_Start;
		internal static ref bool GetG_IN_WAF_Unload_Start(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_WAF_Unload_Start;
		internal static ref bool GetG_IN_bWLU_Start(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_bWLU_Start;
		internal static ref bool GetG_IN_bWLU_Home(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_bWLU_Home;
		internal static ref bool GetG_IN_bWLU_Table_Receive_Ready(this GVL_PC_Input_PLCWrapper parent) => ref parent.ref_G_IN_bWLU_Table_Receive_Ready;
	}

}
