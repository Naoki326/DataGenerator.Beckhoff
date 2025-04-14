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
	
	internal static class GetClass_9bc1c7c3c05545d2bc7529fd16686106
	{
		internal static ref bool GetG_Out_bIMH_Home_Done(this GVL_PLC_Output_PCWrapper parent) => ref parent.ref_G_Out_bIMH_Home_Done;
		internal static ref bool GetG_Out_bOMH_Home_Done(this GVL_PLC_Output_PCWrapper parent) => ref parent.ref_G_Out_bOMH_Home_Done;
		internal static ref bool GetG_Out_bFSU_Home_Done(this GVL_PLC_Output_PCWrapper parent) => ref parent.ref_G_Out_bFSU_Home_Done;
		internal static ref bool GetG_OUT_Barcode_Start_Request(this GVL_PLC_Output_PCWrapper parent) => ref parent.ref_G_OUT_Barcode_Start_Request;
		internal static ref bool GetG_OUT_CleanVision_Request(this GVL_PLC_Output_PCWrapper parent) => ref parent.ref_G_OUT_CleanVision_Request;
		internal static ref bool GetG_OUT_TransBonding_Suceess(this GVL_PLC_Output_PCWrapper parent) => ref parent.ref_G_OUT_TransBonding_Suceess;
		internal static ref bool GetG_OUT_TransBonding_Fail(this GVL_PLC_Output_PCWrapper parent) => ref parent.ref_G_OUT_TransBonding_Fail;
		internal static ref bool GetG_OUT_Bonding_Vision_Request(this GVL_PLC_Output_PCWrapper parent) => ref parent.ref_G_OUT_Bonding_Vision_Request;
		internal static ref bool GetG_OUT_Substrate_InCleanPos(this GVL_PLC_Output_PCWrapper parent) => ref parent.ref_G_OUT_Substrate_InCleanPos;
		internal static ref bool GetG_OUT_Preform_Inspection_Start(this GVL_PLC_Output_PCWrapper parent) => ref parent.ref_G_OUT_Preform_Inspection_Start;
		internal static ref short GetG_Out_CDA_Inspect_Result(this GVL_PLC_Output_PCWrapper parent) => ref parent.ref_G_Out_CDA_Inspect_Result;
		internal static ref bool GetG_Out_Bonding_Ready(this GVL_PLC_Output_PCWrapper parent) => ref parent.ref_G_Out_Bonding_Ready;
		internal static ref bool GetG_OUT_WLU_Wafer_Ready(this GVL_PLC_Output_PCWrapper parent) => ref parent.ref_G_OUT_WLU_Wafer_Ready;
		internal static ref bool GetG_Out_bWLU_Home_Done(this GVL_PLC_Output_PCWrapper parent) => ref parent.ref_G_Out_bWLU_Home_Done;
		internal static ref bool GetG_Out_bJOG_HighSpeed_Move(this GVL_PLC_Output_PCWrapper parent) => ref parent.ref_G_Out_bJOG_HighSpeed_Move;
		internal static ref bool GetG_Out_bJOG_LowSpeed_Move(this GVL_PLC_Output_PCWrapper parent) => ref parent.ref_G_Out_bJOG_LowSpeed_Move;
		internal static ref short GetG_Out_Cursor_Speed(this GVL_PLC_Output_PCWrapper parent) => ref parent.ref_G_Out_Cursor_Speed;
	}

}
