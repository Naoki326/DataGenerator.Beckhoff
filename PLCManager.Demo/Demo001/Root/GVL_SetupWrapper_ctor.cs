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
	/// Name from PLC:GVL_Setup
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_SetupWrapper : BaseData, IBaseData
	{
		public override IEnumerable<IBaseData> Children
		{
			get
			{
				yield return Frame_transfer_motion;
				yield return IMH_Loading_Y_Origin;
				yield return IMH_Loading_Z_Origin;
				yield return IMH_Loading_Z_Limit;
				yield return IMH_Loading_Table_Height;
				yield return IMH_Loading_Height_Before;
				yield return IMH_Loading_Height_After;
				yield return IMH_UnLoading_Position;
				yield return IMH_UnLoad_Table_Height;
				yield return IMH_UnLoading_Height_Before;
				yield return IMH_UnLoading_Height_After;
				yield return OMH_UnLoading_Y_Origin;
				yield return OMH_UnLoading_Z_Origin;
				yield return OMH_UnLoading_Z_Limit;
				yield return OMH_Loading_Table_Height;
				yield return OMH_Loading_Height_Before;
				yield return OMH_Loading_Height_After;
				yield return OMH_UnLoading_Position;
				yield return OMH_UnLoading_Table_Height;
				yield return OMH_UnLoading_Height_Before;
				yield return OMH_UnLoading_Height_After;
				yield return Wafer_motion;
				yield return Clean_motion;
				yield return Frame_transfer_speed;
				yield return Clean_speed;
				yield return Preform_Speed;
				yield return Utility_Check;
				yield return No_frame_error_stop;
				yield return Double_frame_detection;
				yield return PS_vacuum_detection;
				yield return BS_vacuum_detection;
				yield return Stage_up_down_mechanism;
				yield return Pre_heat;
				yield return Bond_heat;
				yield return After_heat;
				yield return IMH_UnLoading_Y_Origin;
				yield return Vac_source_sensor_upper_limit;
				yield return Vac_source_sensor_lower_limit;
				yield return Air_source_sensor_upper_limit;
				yield return Air_source_sensor_lower_limit;
				yield return B_force_air_sensor_upper_limit;
				yield return B_force_air_sensor_lower_limit;
				yield return PS_vacuum_sensor_offset;
				yield return BS_vacuum_sensor_offset;
				yield return Frame_vacuum_sensor_offset;
				yield return Vacuum_source_sensor_offset;
				yield return Air_source_sensor_offset;
				yield return Preform_CDA_Y_Axis_Origin;
				yield return Preform_CDA_Z_Axis_Origin;
				yield return Preform_Touch_Sensor_Sensitivity;
				yield return Preform_Nozzle_height_Check_Y_Pos;
				yield return P_Claw_Conflict_Pos_Y;
				yield return P_Clamp_Conflict_Left_Pos;
				yield return P_Clamp_Conflict_Right_Pos;
				yield return FIG_Loader_Feeder_Origin;
				yield return FIG_Loader_Feeder_Left_Limit;
				yield return FIG_Loader_Feeder_Right_Limit;
				yield return FIG_Clamp_Origin;
				yield return FIG_Preform_POs;
				yield return Feeder_RVS_Frame_Detect_Pos;
				yield return FCU_Main_Feeder1_Origin;
				yield return FCU_Main_Feeder1_Left_Limit;
				yield return FCU_Main_Feeder1_Right_Limit;
				yield return FCU_Main_Feeder_Claw_Width;
				yield return FCU_Clamp_Origin;
				yield return FBU_Main_Feeder2_Origin;
				yield return FBU_Main_Feeder2_Left_Limit;
				yield return FBU_Main_Feeder2_Right_Limit;
				yield return FBU_Main_Feeder2_Claw_Width;
				yield return FBU_Clamp_Origin;
				yield return FOG_UF_Claw_Open_Close_Origin;
				yield return FOG_Unloader_Feeder_Origin;
				yield return FOG_Unloader_Feeder_Left_Limit;
				yield return FOG_Unloader_Feeder_Right_Limit;
				yield return FOG_Unloading_Detect_Pos;
				yield return Track_Width_Origin;
				yield return Track_Width_Close_Limit;
				yield return Track_Left_Edge_Pos;
				yield return Track_Right_Edge_Pos;
				yield return WAF_Case_Lifter_Origin;
				yield return WAF_Case_Lifter_Wait_Height;
				yield return WAF_Case_Lifter_Heat_Plate_Height;
				yield return WAF_Case_Lifter_6inch_Heat_Height;
				yield return WAF_Case_Lifter_8inch_Heat_Height;
				yield return WAF_Case_Lifter_12inch_Heat_Height;
				yield return WAF_Extrator_Origin;
				yield return WAF_Pull_Position;
				yield return WAF_Adjust_Track_Pos;
				yield return WAF_Holder_Set_Release_Pos;
				yield return WAF_Putin_Pos;
				yield return WAF_Lifter_Wait_Pos;
				yield return WAF_Push_Pos;
			}
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Frame_transfer_motion):
					return Frame_transfer_motion;
				case nameof(IMH_Loading_Y_Origin):
					return IMH_Loading_Y_Origin;
				case nameof(IMH_Loading_Z_Origin):
					return IMH_Loading_Z_Origin;
				case nameof(IMH_Loading_Z_Limit):
					return IMH_Loading_Z_Limit;
				case nameof(IMH_Loading_Table_Height):
					return IMH_Loading_Table_Height;
				case nameof(IMH_Loading_Height_Before):
					return IMH_Loading_Height_Before;
				case nameof(IMH_Loading_Height_After):
					return IMH_Loading_Height_After;
				case nameof(IMH_UnLoading_Position):
					return IMH_UnLoading_Position;
				case nameof(IMH_UnLoad_Table_Height):
					return IMH_UnLoad_Table_Height;
				case nameof(IMH_UnLoading_Height_Before):
					return IMH_UnLoading_Height_Before;
				case nameof(IMH_UnLoading_Height_After):
					return IMH_UnLoading_Height_After;
				case nameof(OMH_UnLoading_Y_Origin):
					return OMH_UnLoading_Y_Origin;
				case nameof(OMH_UnLoading_Z_Origin):
					return OMH_UnLoading_Z_Origin;
				case nameof(OMH_UnLoading_Z_Limit):
					return OMH_UnLoading_Z_Limit;
				case nameof(OMH_Loading_Table_Height):
					return OMH_Loading_Table_Height;
				case nameof(OMH_Loading_Height_Before):
					return OMH_Loading_Height_Before;
				case nameof(OMH_Loading_Height_After):
					return OMH_Loading_Height_After;
				case nameof(OMH_UnLoading_Position):
					return OMH_UnLoading_Position;
				case nameof(OMH_UnLoading_Table_Height):
					return OMH_UnLoading_Table_Height;
				case nameof(OMH_UnLoading_Height_Before):
					return OMH_UnLoading_Height_Before;
				case nameof(OMH_UnLoading_Height_After):
					return OMH_UnLoading_Height_After;
				case nameof(Wafer_motion):
					return Wafer_motion;
				case nameof(Clean_motion):
					return Clean_motion;
				case nameof(Frame_transfer_speed):
					return Frame_transfer_speed;
				case nameof(Clean_speed):
					return Clean_speed;
				case nameof(Preform_Speed):
					return Preform_Speed;
				case nameof(Utility_Check):
					return Utility_Check;
				case nameof(No_frame_error_stop):
					return No_frame_error_stop;
				case nameof(Double_frame_detection):
					return Double_frame_detection;
				case nameof(PS_vacuum_detection):
					return PS_vacuum_detection;
				case nameof(BS_vacuum_detection):
					return BS_vacuum_detection;
				case nameof(Stage_up_down_mechanism):
					return Stage_up_down_mechanism;
				case nameof(Pre_heat):
					return Pre_heat;
				case nameof(Bond_heat):
					return Bond_heat;
				case nameof(After_heat):
					return After_heat;
				case nameof(IMH_UnLoading_Y_Origin):
					return IMH_UnLoading_Y_Origin;
				case nameof(Vac_source_sensor_upper_limit):
					return Vac_source_sensor_upper_limit;
				case nameof(Vac_source_sensor_lower_limit):
					return Vac_source_sensor_lower_limit;
				case nameof(Air_source_sensor_upper_limit):
					return Air_source_sensor_upper_limit;
				case nameof(Air_source_sensor_lower_limit):
					return Air_source_sensor_lower_limit;
				case nameof(B_force_air_sensor_upper_limit):
					return B_force_air_sensor_upper_limit;
				case nameof(B_force_air_sensor_lower_limit):
					return B_force_air_sensor_lower_limit;
				case nameof(PS_vacuum_sensor_offset):
					return PS_vacuum_sensor_offset;
				case nameof(BS_vacuum_sensor_offset):
					return BS_vacuum_sensor_offset;
				case nameof(Frame_vacuum_sensor_offset):
					return Frame_vacuum_sensor_offset;
				case nameof(Vacuum_source_sensor_offset):
					return Vacuum_source_sensor_offset;
				case nameof(Air_source_sensor_offset):
					return Air_source_sensor_offset;
				case nameof(Preform_CDA_Y_Axis_Origin):
					return Preform_CDA_Y_Axis_Origin;
				case nameof(Preform_CDA_Z_Axis_Origin):
					return Preform_CDA_Z_Axis_Origin;
				case nameof(Preform_Touch_Sensor_Sensitivity):
					return Preform_Touch_Sensor_Sensitivity;
				case nameof(Preform_Nozzle_height_Check_Y_Pos):
					return Preform_Nozzle_height_Check_Y_Pos;
				case nameof(P_Claw_Conflict_Pos_Y):
					return P_Claw_Conflict_Pos_Y;
				case nameof(P_Clamp_Conflict_Left_Pos):
					return P_Clamp_Conflict_Left_Pos;
				case nameof(P_Clamp_Conflict_Right_Pos):
					return P_Clamp_Conflict_Right_Pos;
				case nameof(FIG_Loader_Feeder_Origin):
					return FIG_Loader_Feeder_Origin;
				case nameof(FIG_Loader_Feeder_Left_Limit):
					return FIG_Loader_Feeder_Left_Limit;
				case nameof(FIG_Loader_Feeder_Right_Limit):
					return FIG_Loader_Feeder_Right_Limit;
				case nameof(FIG_Clamp_Origin):
					return FIG_Clamp_Origin;
				case nameof(FIG_Preform_POs):
					return FIG_Preform_POs;
				case nameof(Feeder_RVS_Frame_Detect_Pos):
					return Feeder_RVS_Frame_Detect_Pos;
				case nameof(FCU_Main_Feeder1_Origin):
					return FCU_Main_Feeder1_Origin;
				case nameof(FCU_Main_Feeder1_Left_Limit):
					return FCU_Main_Feeder1_Left_Limit;
				case nameof(FCU_Main_Feeder1_Right_Limit):
					return FCU_Main_Feeder1_Right_Limit;
				case nameof(FCU_Main_Feeder_Claw_Width):
					return FCU_Main_Feeder_Claw_Width;
				case nameof(FCU_Clamp_Origin):
					return FCU_Clamp_Origin;
				case nameof(FBU_Main_Feeder2_Origin):
					return FBU_Main_Feeder2_Origin;
				case nameof(FBU_Main_Feeder2_Left_Limit):
					return FBU_Main_Feeder2_Left_Limit;
				case nameof(FBU_Main_Feeder2_Right_Limit):
					return FBU_Main_Feeder2_Right_Limit;
				case nameof(FBU_Main_Feeder2_Claw_Width):
					return FBU_Main_Feeder2_Claw_Width;
				case nameof(FBU_Clamp_Origin):
					return FBU_Clamp_Origin;
				case nameof(FOG_UF_Claw_Open_Close_Origin):
					return FOG_UF_Claw_Open_Close_Origin;
				case nameof(FOG_Unloader_Feeder_Origin):
					return FOG_Unloader_Feeder_Origin;
				case nameof(FOG_Unloader_Feeder_Left_Limit):
					return FOG_Unloader_Feeder_Left_Limit;
				case nameof(FOG_Unloader_Feeder_Right_Limit):
					return FOG_Unloader_Feeder_Right_Limit;
				case nameof(FOG_Unloading_Detect_Pos):
					return FOG_Unloading_Detect_Pos;
				case nameof(Track_Width_Origin):
					return Track_Width_Origin;
				case nameof(Track_Width_Close_Limit):
					return Track_Width_Close_Limit;
				case nameof(Track_Left_Edge_Pos):
					return Track_Left_Edge_Pos;
				case nameof(Track_Right_Edge_Pos):
					return Track_Right_Edge_Pos;
				case nameof(WAF_Case_Lifter_Origin):
					return WAF_Case_Lifter_Origin;
				case nameof(WAF_Case_Lifter_Wait_Height):
					return WAF_Case_Lifter_Wait_Height;
				case nameof(WAF_Case_Lifter_Heat_Plate_Height):
					return WAF_Case_Lifter_Heat_Plate_Height;
				case nameof(WAF_Case_Lifter_6inch_Heat_Height):
					return WAF_Case_Lifter_6inch_Heat_Height;
				case nameof(WAF_Case_Lifter_8inch_Heat_Height):
					return WAF_Case_Lifter_8inch_Heat_Height;
				case nameof(WAF_Case_Lifter_12inch_Heat_Height):
					return WAF_Case_Lifter_12inch_Heat_Height;
				case nameof(WAF_Extrator_Origin):
					return WAF_Extrator_Origin;
				case nameof(WAF_Pull_Position):
					return WAF_Pull_Position;
				case nameof(WAF_Adjust_Track_Pos):
					return WAF_Adjust_Track_Pos;
				case nameof(WAF_Holder_Set_Release_Pos):
					return WAF_Holder_Set_Release_Pos;
				case nameof(WAF_Putin_Pos):
					return WAF_Putin_Pos;
				case nameof(WAF_Lifter_Wait_Pos):
					return WAF_Lifter_Wait_Pos;
				case nameof(WAF_Push_Pos):
					return WAF_Push_Pos;
			}
			throw new KeyNotFoundException(name);
		}

		private readonly AdsClient client;

		public GVL_SetupWrapper(AdsClient client)
		{
			this.client = client;

			Frame_transfer_motion = new BeckhoffBool(this.GetFrame_transfer_motion, client, 16448, 2004407){ Name = "Frame_transfer_motion" };
			IMH_Loading_Y_Origin = new BeckhoffFloat(this.GetIMH_Loading_Y_Origin, client, 16448, 2004408){ Name = "IMH_Loading_Y_Origin" };
			IMH_Loading_Z_Origin = new BeckhoffFloat(this.GetIMH_Loading_Z_Origin, client, 16448, 2004412){ Name = "IMH_Loading_Z_Origin" };
			IMH_Loading_Z_Limit = new BeckhoffFloat(this.GetIMH_Loading_Z_Limit, client, 16448, 2004416){ Name = "IMH_Loading_Z_Limit" };
			IMH_Loading_Table_Height = new BeckhoffFloat(this.GetIMH_Loading_Table_Height, client, 16448, 2004420){ Name = "IMH_Loading_Table_Height" };
			IMH_Loading_Height_Before = new BeckhoffFloat(this.GetIMH_Loading_Height_Before, client, 16448, 2004424){ Name = "IMH_Loading_Height_Before" };
			IMH_Loading_Height_After = new BeckhoffFloat(this.GetIMH_Loading_Height_After, client, 16448, 2004428){ Name = "IMH_Loading_Height_After" };
			IMH_UnLoading_Position = new BeckhoffFloat(this.GetIMH_UnLoading_Position, client, 16448, 2004432){ Name = "IMH_UnLoading_Position" };
			IMH_UnLoad_Table_Height = new BeckhoffFloat(this.GetIMH_UnLoad_Table_Height, client, 16448, 2004436){ Name = "IMH_UnLoad_Table_Height" };
			IMH_UnLoading_Height_Before = new BeckhoffFloat(this.GetIMH_UnLoading_Height_Before, client, 16448, 2004440){ Name = "IMH_UnLoading_Height_Before" };
			IMH_UnLoading_Height_After = new BeckhoffFloat(this.GetIMH_UnLoading_Height_After, client, 16448, 2004444){ Name = "IMH_UnLoading_Height_After" };
			OMH_UnLoading_Y_Origin = new BeckhoffFloat(this.GetOMH_UnLoading_Y_Origin, client, 16448, 2004448){ Name = "OMH_UnLoading_Y_Origin" };
			OMH_UnLoading_Z_Origin = new BeckhoffFloat(this.GetOMH_UnLoading_Z_Origin, client, 16448, 2004452){ Name = "OMH_UnLoading_Z_Origin" };
			OMH_UnLoading_Z_Limit = new BeckhoffFloat(this.GetOMH_UnLoading_Z_Limit, client, 16448, 2004456){ Name = "OMH_UnLoading_Z_Limit" };
			OMH_Loading_Table_Height = new BeckhoffFloat(this.GetOMH_Loading_Table_Height, client, 16448, 2004460){ Name = "OMH_Loading_Table_Height" };
			OMH_Loading_Height_Before = new BeckhoffFloat(this.GetOMH_Loading_Height_Before, client, 16448, 2004464){ Name = "OMH_Loading_Height_Before" };
			OMH_Loading_Height_After = new BeckhoffFloat(this.GetOMH_Loading_Height_After, client, 16448, 2004468){ Name = "OMH_Loading_Height_After" };
			OMH_UnLoading_Position = new BeckhoffFloat(this.GetOMH_UnLoading_Position, client, 16448, 2004472){ Name = "OMH_UnLoading_Position" };
			OMH_UnLoading_Table_Height = new BeckhoffFloat(this.GetOMH_UnLoading_Table_Height, client, 16448, 2004476){ Name = "OMH_UnLoading_Table_Height" };
			OMH_UnLoading_Height_Before = new BeckhoffFloat(this.GetOMH_UnLoading_Height_Before, client, 16448, 2004480){ Name = "OMH_UnLoading_Height_Before" };
			OMH_UnLoading_Height_After = new BeckhoffFloat(this.GetOMH_UnLoading_Height_After, client, 16448, 2004484){ Name = "OMH_UnLoading_Height_After" };
			Wafer_motion = new BeckhoffBool(this.GetWafer_motion, client, 16448, 2004488){ Name = "Wafer_motion" };
			Clean_motion = new BeckhoffBool(this.GetClean_motion, client, 16448, 2004489){ Name = "Clean_motion" };
			Frame_transfer_speed = new BeckhoffBool(this.GetFrame_transfer_speed, client, 16448, 2004490){ Name = "Frame_transfer_speed" };
			Clean_speed = new BeckhoffBool(this.GetClean_speed, client, 16448, 2004491){ Name = "Clean_speed" };
			Preform_Speed = new BeckhoffBool(this.GetPreform_Speed, client, 16448, 2004492){ Name = "Preform_Speed" };
			Utility_Check = new BeckhoffBool(this.GetUtility_Check, client, 16448, 2004493){ Name = "Utility_Check" };
			No_frame_error_stop = new BeckhoffBool(this.GetNo_frame_error_stop, client, 16448, 2004494){ Name = "No_frame_error_stop" };
			Double_frame_detection = new BeckhoffBool(this.GetDouble_frame_detection, client, 16448, 2004495){ Name = "Double_frame_detection" };
			PS_vacuum_detection = new BeckhoffBool(this.GetPS_vacuum_detection, client, 16448, 2004496){ Name = "PS_vacuum_detection" };
			BS_vacuum_detection = new BeckhoffBool(this.GetBS_vacuum_detection, client, 16448, 2004497){ Name = "BS_vacuum_detection" };
			Stage_up_down_mechanism = new BeckhoffBool(this.GetStage_up_down_mechanism, client, 16448, 2004498){ Name = "Stage_up_down_mechanism" };
			Pre_heat = new BeckhoffBool(this.GetPre_heat, client, 16448, 2004499){ Name = "Pre_heat" };
			Bond_heat = new BeckhoffBool(this.GetBond_heat, client, 16448, 2004500){ Name = "Bond_heat" };
			After_heat = new BeckhoffBool(this.GetAfter_heat, client, 16448, 2004501){ Name = "After_heat" };
			IMH_UnLoading_Y_Origin = new BeckhoffShort(this.GetIMH_UnLoading_Y_Origin, client, 16448, 2004502){ Name = "IMH_UnLoading_Y_Origin" };
			Vac_source_sensor_upper_limit = new BeckhoffFloat(this.GetVac_source_sensor_upper_limit, client, 16448, 2004504){ Name = "Vac_source_sensor_upper_limit" };
			Vac_source_sensor_lower_limit = new BeckhoffFloat(this.GetVac_source_sensor_lower_limit, client, 16448, 2004508){ Name = "Vac_source_sensor_lower_limit" };
			Air_source_sensor_upper_limit = new BeckhoffFloat(this.GetAir_source_sensor_upper_limit, client, 16448, 2004512){ Name = "Air_source_sensor_upper_limit" };
			Air_source_sensor_lower_limit = new BeckhoffFloat(this.GetAir_source_sensor_lower_limit, client, 16448, 2004516){ Name = "Air_source_sensor_lower_limit" };
			B_force_air_sensor_upper_limit = new BeckhoffFloat(this.GetB_force_air_sensor_upper_limit, client, 16448, 2004520){ Name = "B_force_air_sensor_upper_limit" };
			B_force_air_sensor_lower_limit = new BeckhoffFloat(this.GetB_force_air_sensor_lower_limit, client, 16448, 2004524){ Name = "B_force_air_sensor_lower_limit" };
			PS_vacuum_sensor_offset = new BeckhoffFloat(this.GetPS_vacuum_sensor_offset, client, 16448, 2004528){ Name = "PS_vacuum_sensor_offset" };
			BS_vacuum_sensor_offset = new BeckhoffFloat(this.GetBS_vacuum_sensor_offset, client, 16448, 2004532){ Name = "BS_vacuum_sensor_offset" };
			Frame_vacuum_sensor_offset = new BeckhoffFloat(this.GetFrame_vacuum_sensor_offset, client, 16448, 2004536){ Name = "Frame_vacuum_sensor_offset" };
			Vacuum_source_sensor_offset = new BeckhoffFloat(this.GetVacuum_source_sensor_offset, client, 16448, 2004540){ Name = "Vacuum_source_sensor_offset" };
			Air_source_sensor_offset = new BeckhoffFloat(this.GetAir_source_sensor_offset, client, 16448, 2004544){ Name = "Air_source_sensor_offset" };
			Preform_CDA_Y_Axis_Origin = new BeckhoffFloat(this.GetPreform_CDA_Y_Axis_Origin, client, 16448, 2004548){ Name = "Preform_CDA_Y_Axis_Origin" };
			Preform_CDA_Z_Axis_Origin = new BeckhoffFloat(this.GetPreform_CDA_Z_Axis_Origin, client, 16448, 2004552){ Name = "Preform_CDA_Z_Axis_Origin" };
			Preform_Touch_Sensor_Sensitivity = new BeckhoffFloat(this.GetPreform_Touch_Sensor_Sensitivity, client, 16448, 2004556){ Name = "Preform_Touch_Sensor_Sensitivity" };
			Preform_Nozzle_height_Check_Y_Pos = new BeckhoffFloat(this.GetPreform_Nozzle_height_Check_Y_Pos, client, 16448, 2004560){ Name = "Preform_Nozzle_height_Check_Y_Pos" };
			P_Claw_Conflict_Pos_Y = new BeckhoffFloat(this.GetP_Claw_Conflict_Pos_Y, client, 16448, 2004564){ Name = "P_Claw_Conflict_Pos_Y" };
			P_Clamp_Conflict_Left_Pos = new BeckhoffFloat(this.GetP_Clamp_Conflict_Left_Pos, client, 16448, 2004568){ Name = "P_Clamp_Conflict_Left_Pos" };
			P_Clamp_Conflict_Right_Pos = new BeckhoffFloat(this.GetP_Clamp_Conflict_Right_Pos, client, 16448, 2004572){ Name = "P_Clamp_Conflict_Right_Pos" };
			FIG_Loader_Feeder_Origin = new BeckhoffFloat(this.GetFIG_Loader_Feeder_Origin, client, 16448, 2004576){ Name = "FIG_Loader_Feeder_Origin" };
			FIG_Loader_Feeder_Left_Limit = new BeckhoffFloat(this.GetFIG_Loader_Feeder_Left_Limit, client, 16448, 2004580){ Name = "FIG_Loader_Feeder_Left_Limit" };
			FIG_Loader_Feeder_Right_Limit = new BeckhoffFloat(this.GetFIG_Loader_Feeder_Right_Limit, client, 16448, 2004584){ Name = "FIG_Loader_Feeder_Right_Limit" };
			FIG_Clamp_Origin = new BeckhoffFloat(this.GetFIG_Clamp_Origin, client, 16448, 2004588){ Name = "FIG_Clamp_Origin" };
			FIG_Preform_POs = new BeckhoffFloat(this.GetFIG_Preform_POs, client, 16448, 2004592){ Name = "FIG_Preform_POs" };
			Feeder_RVS_Frame_Detect_Pos = new BeckhoffFloat(this.GetFeeder_RVS_Frame_Detect_Pos, client, 16448, 2004596){ Name = "Feeder_RVS_Frame_Detect_Pos" };
			FCU_Main_Feeder1_Origin = new BeckhoffFloat(this.GetFCU_Main_Feeder1_Origin, client, 16448, 2004600){ Name = "FCU_Main_Feeder1_Origin" };
			FCU_Main_Feeder1_Left_Limit = new BeckhoffFloat(this.GetFCU_Main_Feeder1_Left_Limit, client, 16448, 2004604){ Name = "FCU_Main_Feeder1_Left_Limit" };
			FCU_Main_Feeder1_Right_Limit = new BeckhoffFloat(this.GetFCU_Main_Feeder1_Right_Limit, client, 16448, 2004608){ Name = "FCU_Main_Feeder1_Right_Limit" };
			FCU_Main_Feeder_Claw_Width = new BeckhoffFloat(this.GetFCU_Main_Feeder_Claw_Width, client, 16448, 2004612){ Name = "FCU_Main_Feeder_Claw_Width" };
			FCU_Clamp_Origin = new BeckhoffFloat(this.GetFCU_Clamp_Origin, client, 16448, 2004616){ Name = "FCU_Clamp_Origin" };
			FBU_Main_Feeder2_Origin = new BeckhoffFloat(this.GetFBU_Main_Feeder2_Origin, client, 16448, 2004620){ Name = "FBU_Main_Feeder2_Origin" };
			FBU_Main_Feeder2_Left_Limit = new BeckhoffFloat(this.GetFBU_Main_Feeder2_Left_Limit, client, 16448, 2004624){ Name = "FBU_Main_Feeder2_Left_Limit" };
			FBU_Main_Feeder2_Right_Limit = new BeckhoffFloat(this.GetFBU_Main_Feeder2_Right_Limit, client, 16448, 2004628){ Name = "FBU_Main_Feeder2_Right_Limit" };
			FBU_Main_Feeder2_Claw_Width = new BeckhoffFloat(this.GetFBU_Main_Feeder2_Claw_Width, client, 16448, 2004632){ Name = "FBU_Main_Feeder2_Claw_Width" };
			FBU_Clamp_Origin = new BeckhoffFloat(this.GetFBU_Clamp_Origin, client, 16448, 2004636){ Name = "FBU_Clamp_Origin" };
			FOG_UF_Claw_Open_Close_Origin = new BeckhoffFloat(this.GetFOG_UF_Claw_Open_Close_Origin, client, 16448, 2004640){ Name = "FOG_UF_Claw_Open_Close_Origin" };
			FOG_Unloader_Feeder_Origin = new BeckhoffFloat(this.GetFOG_Unloader_Feeder_Origin, client, 16448, 2004644){ Name = "FOG_Unloader_Feeder_Origin" };
			FOG_Unloader_Feeder_Left_Limit = new BeckhoffFloat(this.GetFOG_Unloader_Feeder_Left_Limit, client, 16448, 2004648){ Name = "FOG_Unloader_Feeder_Left_Limit" };
			FOG_Unloader_Feeder_Right_Limit = new BeckhoffFloat(this.GetFOG_Unloader_Feeder_Right_Limit, client, 16448, 2004652){ Name = "FOG_Unloader_Feeder_Right_Limit" };
			FOG_Unloading_Detect_Pos = new BeckhoffFloat(this.GetFOG_Unloading_Detect_Pos, client, 16448, 2004656){ Name = "FOG_Unloading_Detect_Pos" };
			Track_Width_Origin = new BeckhoffFloat(this.GetTrack_Width_Origin, client, 16448, 2004660){ Name = "Track_Width_Origin" };
			Track_Width_Close_Limit = new BeckhoffFloat(this.GetTrack_Width_Close_Limit, client, 16448, 2004664){ Name = "Track_Width_Close_Limit" };
			Track_Left_Edge_Pos = new BeckhoffFloat(this.GetTrack_Left_Edge_Pos, client, 16448, 2004668){ Name = "Track_Left_Edge_Pos" };
			Track_Right_Edge_Pos = new BeckhoffFloat(this.GetTrack_Right_Edge_Pos, client, 16448, 2004672){ Name = "Track_Right_Edge_Pos" };
			WAF_Case_Lifter_Origin = new BeckhoffFloat(this.GetWAF_Case_Lifter_Origin, client, 16448, 2004676){ Name = "WAF_Case_Lifter_Origin" };
			WAF_Case_Lifter_Wait_Height = new BeckhoffFloat(this.GetWAF_Case_Lifter_Wait_Height, client, 16448, 2004680){ Name = "WAF_Case_Lifter_Wait_Height" };
			WAF_Case_Lifter_Heat_Plate_Height = new BeckhoffFloat(this.GetWAF_Case_Lifter_Heat_Plate_Height, client, 16448, 2004684){ Name = "WAF_Case_Lifter_Heat_Plate_Height" };
			WAF_Case_Lifter_6inch_Heat_Height = new BeckhoffFloat(this.GetWAF_Case_Lifter_6inch_Heat_Height, client, 16448, 2004688){ Name = "WAF_Case_Lifter_6inch_Heat_Height" };
			WAF_Case_Lifter_8inch_Heat_Height = new BeckhoffFloat(this.GetWAF_Case_Lifter_8inch_Heat_Height, client, 16448, 2004692){ Name = "WAF_Case_Lifter_8inch_Heat_Height" };
			WAF_Case_Lifter_12inch_Heat_Height = new BeckhoffFloat(this.GetWAF_Case_Lifter_12inch_Heat_Height, client, 16448, 2004696){ Name = "WAF_Case_Lifter_12inch_Heat_Height" };
			WAF_Extrator_Origin = new BeckhoffFloat(this.GetWAF_Extrator_Origin, client, 16448, 2004700){ Name = "WAF_Extrator_Origin" };
			WAF_Pull_Position = new BeckhoffFloat(this.GetWAF_Pull_Position, client, 16448, 2004704){ Name = "WAF_Pull_Position" };
			WAF_Adjust_Track_Pos = new BeckhoffFloat(this.GetWAF_Adjust_Track_Pos, client, 16448, 2004708){ Name = "WAF_Adjust_Track_Pos" };
			WAF_Holder_Set_Release_Pos = new BeckhoffFloat(this.GetWAF_Holder_Set_Release_Pos, client, 16448, 2004712){ Name = "WAF_Holder_Set_Release_Pos" };
			WAF_Putin_Pos = new BeckhoffFloat(this.GetWAF_Putin_Pos, client, 16448, 2004716){ Name = "WAF_Putin_Pos" };
			WAF_Lifter_Wait_Pos = new BeckhoffFloat(this.GetWAF_Lifter_Wait_Pos, client, 16448, 2004720){ Name = "WAF_Lifter_Wait_Pos" };
			WAF_Push_Pos = new BeckhoffFloat(this.GetWAF_Push_Pos, client, 16448, 2004724){ Name = "WAF_Push_Pos" };
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
		~GVL_SetupWrapper()
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
