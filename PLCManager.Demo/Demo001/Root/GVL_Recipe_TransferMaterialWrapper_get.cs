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
	
	internal static class GetClass_f14bd7daea16471592cf4c3678c6954a
	{
		internal static ref bool GetDetection_mode(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Detection_mode;
		internal static ref float GetFrame_length(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Frame_length;
		internal static ref float GetFrame_width(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Frame_width;
		internal static ref float GetFrame_thickness(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Frame_thickness;
		internal static ref float GetNo_of_blocks(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_No_of_blocks;
		internal static ref float GetBlock_pitch(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Block_pitch;
		internal static ref float GetNo_of_column_X(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_No_of_column_X;
		internal static ref float GetColumn_X_pitch(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Column_X_pitch;
		internal static ref float GetNo_of_Row_Y(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_No_of_Row_Y;
		internal static ref float GetRow_Y_pitch(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Row_Y_pitch;
		internal static ref float GetFirst_Column_X_Pos(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_First_Column_X_Pos;
		internal static ref float GetFrame_head_detection_offset(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Frame_head_detection_offset;
		internal static ref float GetFRM_head_Det_offset_at_LA(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_FRM_head_Det_offset_at_LA;
		internal static ref float GetRow_Y_offset(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Row_Y_offset;
		internal static ref float GetBlock_length(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Block_length;
		internal static ref float GetFirst_block_width(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_First_block_width;
		internal static ref float GetNo_of_Block_Y(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_No_of_Block_Y;
		internal static ref float GetBlock_Y_pitch1(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Block_Y_pitch1;
		internal static ref float GetBlock_Y_pitch2(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Block_Y_pitch2;
		internal static ref float GetBlock_Y_pitch3(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Block_Y_pitch3;
		internal static ref float GetBlock_Y_pitch4(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Block_Y_pitch4;
		internal static ref float GetBlock_Y_pitch5(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Block_Y_pitch5;
		internal static ref float GetNo_of_detection_pos(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_No_of_detection_pos;
		internal static ref float GetDetection_position_1(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Detection_position_1;
		internal static ref bool GetDetection_logic_1(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Detection_logic_1;
		internal static ref bool GetDetection_logic_3(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Detection_logic_3;
		internal static ref bool GetDetection_logic_4(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Detection_logic_4;
		internal static ref bool GetInput_media_type(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Input_media_type;
		internal static ref float GetDetection_pos_tolerance_1(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Detection_pos_tolerance_1;
		internal static ref float GetDetection_position_2(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Detection_position_2;
		internal static ref float GetDetection_logic_2_(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Detection_logic_2_;
		internal static ref float GetDetection_pos_tolerance_2(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Detection_pos_tolerance_2;
		internal static ref float GetDetection_position_3(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Detection_position_3;
		internal static ref float GetDetection_pos_tolerance_3(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Detection_pos_tolerance_3;
		internal static ref float GetDetection_position_4(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Detection_position_4;
		internal static ref float GetDetection_pos_tolerance_4(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Detection_pos_tolerance_4;
		internal static ref float GetIMH_Magazine_Lowest_Slot_Height(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_IMH_Magazine_Lowest_Slot_Height;
		internal static ref float GetIMH_Magazine_Width(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_IMH_Magazine_Width;
		internal static ref short GetIMH_Num_Of_Slots(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_IMH_Num_Of_Slots;
		internal static ref short GetOMH_Num_Of_Slots(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_OMH_Num_Of_Slots;
		internal static ref float GetIMH_Slot_Pitch(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_IMH_Slot_Pitch;
		internal static ref float GetOMH_Magazine_Lowest_Slot_Height(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_OMH_Magazine_Lowest_Slot_Height;
		internal static ref float GetOMH_Magazine_Width(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_OMH_Magazine_Width;
		internal static ref float GetOMH_Slot_Pitch(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_OMH_Slot_Pitch;
		internal static ref bool GetFrame_map(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Frame_map;
		internal static ref bool GetPreform_stage_vacuum(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Preform_stage_vacuum;
		internal static ref bool GetBonding_stage_vacuum(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Bonding_stage_vacuum;
		internal static ref bool GetP_gripper_escape(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_P_gripper_escape;
		internal static ref bool GetB_gripper_escape(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_B_gripper_escape;
		internal static ref bool GetP_frame_grip_during(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_P_frame_grip_during;
		internal static ref bool GetB_frame_grip_during(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_B_frame_grip_during;
		internal static ref bool GetP_frame_clamp_during(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_P_frame_clamp_during;
		internal static ref bool GetB_frame_clamp_during(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_B_frame_clamp_during;
		internal static ref bool GetCure_action(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Cure_action;
		internal static ref bool GetB_frame_feed_shift_check(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_B_frame_feed_shift_check;
		internal static ref bool GetFrame_hold_change_Hi_speed_Disable(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Frame_hold_change_Hi_speed_Disable;
		internal static ref float GetLoader_conveyer_unit(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Loader_conveyer_unit;
		internal static ref float GetUnloader_conveyer_unit(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_Unloader_conveyer_unit;
		internal static ref float GetPS_Vac_Sens_upper_limit(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_PS_Vac_Sens_upper_limit;
		internal static ref float GetPS_Vac_Sens_lower_limit(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_PS_Vac_Sens_lower_limit;
		internal static ref float GetBS_Vac_Sens_upper_limit(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_BS_Vac_Sens_upper_limit;
		internal static ref float GetBS_Vac_Sens_lower_limit(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_BS_Vac_Sens_lower_limit;
		internal static ref float GetB_frame_feed_shift_tolerance_X(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_B_frame_feed_shift_tolerance_X;
		internal static ref float GetB_frame_feed_shift_tolerance_Y(this GVL_Recipe_TransferMaterialWrapper parent) => ref parent.ref_B_frame_feed_shift_tolerance_Y;
	}

}
