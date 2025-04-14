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
	/// Name from PLC:GVL_Recipe_Bool
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_Recipe_BoolWrapper : BaseData, IBaseData
	{
		public override IEnumerable<IBaseData> Children
		{
			get
			{
				yield return Reversed_Frame_Detection_mode;
				yield return Reversed_Frame_Detection_logic_1;
				yield return Reversed_Frame_Detection_logic_2;
				yield return Reversed_Frame_Detection_logic_3;
				yield return Reversed_Frame_Detection_logic_4;
				yield return Feed_Cond_Input_media_type;
				yield return Feed_Cond_Frame_map;
				yield return Feed_Cond_Preform_stage_vacuum;
				yield return Feed_Cond_Bonding_stage_vacuum;
				yield return Feed_Cond_P_gripper_escape;
				yield return Feed_Cond_B_gripper_escape;
				yield return Feed_Cond_P_frame_grip_during;
				yield return Feed_Cond_B_frame_grip_during;
				yield return Feed_Cond_P_frame_clamp_during;
				yield return Feed_Cond_B_frame_clamp_during;
				yield return Feed_Cond_Cure_action;
				yield return Stage_Re_clamp_at_Vac_Det_retry;
				yield return Action_after_FRM_pullout_error;
				yield return Frame_pusher_usage;
				yield return Frame_cleaning;
				yield return Frame_unload_jam_detection;
				yield return Wafer_Barcode_read;
				yield return Order_of_wafer_load;
				yield return Wafer_auto_unload;
				yield return Reversed_frame_Rec_mode;
				yield return Bonding_step_motion_mode;
				yield return Paste_hard_skip_count;
				yield return Pre_heat_motion;
				yield return Bond_heat_motion;
				yield return Afrer_heat_motion;
				yield return Reverse_frame_detection_mode;
				yield return Frame_map_mode;
				yield return Preform_stage_vacuum;
				yield return Bonding_stage_vacuum;
				yield return Feeder_escape_at_preform;
				yield return Feeder_escape_at_bonding;
				yield return Preform_stage_up_down;
				yield return Bonding_stage_up_down;
				yield return Frame_unload_rehold_distance;
				yield return Frame_unload_retry_mode;
				yield return Wafer_map;
				yield return Wafer_recovery;
				yield return Stop_after_last_wafer;
				yield return Wafer_die_position_recognition_Conflict;
				yield return Wafer_edge_recognition;
				yield return Wafer_ink_mark_recognition;
				yield return Wafer_target_die_check_Rec;
				yield return Wafer_check_die;
				yield return Wafer_die_Rec_error_mode_Conflict;
				yield return Die_outline_recognition_mode;
				yield return Die_presence_recognition;
				yield return Die_crack_detection;
				yield return Wafer_Die_surface_Judg_Insp;
				yield return Preform_motion_mode;
				yield return Dispenser_motion;
				yield return Paste_remain_detection;
				yield return Preform_cleaning;
				yield return Preform_paddle_recognition;
				yield return Preform_fail_mark_recognition;
				yield return Preform_Presence_inspection;
				yield return Preform_area_inspection;
				yield return Preform_form_inspection;
				yield return Reverse_frame_recognition;
				yield return Pickup_Die_BIN_select;
				yield return Bonding_pickup_mode;
				yield return Pre_heat;
				yield return Bond_heat;
				yield return After_heat;
				yield return Bonding_paddle_recognition;
				yield return Bonding_inspection;
				yield return Before_bonding_inspection;
				yield return Bonding_Die_surface_Judg_Insp;
				yield return Alignment_stage_die_recognition;
				yield return Alignment_stage_particle_inspection;
				yield return Alignment_stage_Die_surface_inspection;
				yield return Frame_feed;
				yield return Wafer_feed;
				yield return Preform_motion;
				yield return Bonding_motion;
				yield return Utility_check;
				yield return Double_frame_detection;
				yield return Preform_stage_Vac_Det;
				yield return Bonding_stage_Vac_Det;
				yield return ALIGN_stage_Vac_Det;
				yield return Die_pickup_vacuum_detection;
				yield return Die_Det_after_stage_place;
				yield return Die_Det_after_stage_pickup;
				yield return Bonding_vacuum_detection;
				yield return Bonding_land_detection;
				yield return Pickup_head_land_detection;
				yield return Collect_cleaning_mode;
				yield return Preform_circle_form_inspection;
			}
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Reversed_Frame_Detection_mode):
					return Reversed_Frame_Detection_mode;
				case nameof(Reversed_Frame_Detection_logic_1):
					return Reversed_Frame_Detection_logic_1;
				case nameof(Reversed_Frame_Detection_logic_2):
					return Reversed_Frame_Detection_logic_2;
				case nameof(Reversed_Frame_Detection_logic_3):
					return Reversed_Frame_Detection_logic_3;
				case nameof(Reversed_Frame_Detection_logic_4):
					return Reversed_Frame_Detection_logic_4;
				case nameof(Feed_Cond_Input_media_type):
					return Feed_Cond_Input_media_type;
				case nameof(Feed_Cond_Frame_map):
					return Feed_Cond_Frame_map;
				case nameof(Feed_Cond_Preform_stage_vacuum):
					return Feed_Cond_Preform_stage_vacuum;
				case nameof(Feed_Cond_Bonding_stage_vacuum):
					return Feed_Cond_Bonding_stage_vacuum;
				case nameof(Feed_Cond_P_gripper_escape):
					return Feed_Cond_P_gripper_escape;
				case nameof(Feed_Cond_B_gripper_escape):
					return Feed_Cond_B_gripper_escape;
				case nameof(Feed_Cond_P_frame_grip_during):
					return Feed_Cond_P_frame_grip_during;
				case nameof(Feed_Cond_B_frame_grip_during):
					return Feed_Cond_B_frame_grip_during;
				case nameof(Feed_Cond_P_frame_clamp_during):
					return Feed_Cond_P_frame_clamp_during;
				case nameof(Feed_Cond_B_frame_clamp_during):
					return Feed_Cond_B_frame_clamp_during;
				case nameof(Feed_Cond_Cure_action):
					return Feed_Cond_Cure_action;
				case nameof(Stage_Re_clamp_at_Vac_Det_retry):
					return Stage_Re_clamp_at_Vac_Det_retry;
				case nameof(Action_after_FRM_pullout_error):
					return Action_after_FRM_pullout_error;
				case nameof(Frame_pusher_usage):
					return Frame_pusher_usage;
				case nameof(Frame_cleaning):
					return Frame_cleaning;
				case nameof(Frame_unload_jam_detection):
					return Frame_unload_jam_detection;
				case nameof(Wafer_Barcode_read):
					return Wafer_Barcode_read;
				case nameof(Order_of_wafer_load):
					return Order_of_wafer_load;
				case nameof(Wafer_auto_unload):
					return Wafer_auto_unload;
				case nameof(Reversed_frame_Rec_mode):
					return Reversed_frame_Rec_mode;
				case nameof(Bonding_step_motion_mode):
					return Bonding_step_motion_mode;
				case nameof(Paste_hard_skip_count):
					return Paste_hard_skip_count;
				case nameof(Pre_heat_motion):
					return Pre_heat_motion;
				case nameof(Bond_heat_motion):
					return Bond_heat_motion;
				case nameof(Afrer_heat_motion):
					return Afrer_heat_motion;
				case nameof(Reverse_frame_detection_mode):
					return Reverse_frame_detection_mode;
				case nameof(Frame_map_mode):
					return Frame_map_mode;
				case nameof(Preform_stage_vacuum):
					return Preform_stage_vacuum;
				case nameof(Bonding_stage_vacuum):
					return Bonding_stage_vacuum;
				case nameof(Feeder_escape_at_preform):
					return Feeder_escape_at_preform;
				case nameof(Feeder_escape_at_bonding):
					return Feeder_escape_at_bonding;
				case nameof(Preform_stage_up_down):
					return Preform_stage_up_down;
				case nameof(Bonding_stage_up_down):
					return Bonding_stage_up_down;
				case nameof(Frame_unload_rehold_distance):
					return Frame_unload_rehold_distance;
				case nameof(Frame_unload_retry_mode):
					return Frame_unload_retry_mode;
				case nameof(Wafer_map):
					return Wafer_map;
				case nameof(Wafer_recovery):
					return Wafer_recovery;
				case nameof(Stop_after_last_wafer):
					return Stop_after_last_wafer;
				case nameof(Wafer_die_position_recognition_Conflict):
					return Wafer_die_position_recognition_Conflict;
				case nameof(Wafer_edge_recognition):
					return Wafer_edge_recognition;
				case nameof(Wafer_ink_mark_recognition):
					return Wafer_ink_mark_recognition;
				case nameof(Wafer_target_die_check_Rec):
					return Wafer_target_die_check_Rec;
				case nameof(Wafer_check_die):
					return Wafer_check_die;
				case nameof(Wafer_die_Rec_error_mode_Conflict):
					return Wafer_die_Rec_error_mode_Conflict;
				case nameof(Die_outline_recognition_mode):
					return Die_outline_recognition_mode;
				case nameof(Die_presence_recognition):
					return Die_presence_recognition;
				case nameof(Die_crack_detection):
					return Die_crack_detection;
				case nameof(Wafer_Die_surface_Judg_Insp):
					return Wafer_Die_surface_Judg_Insp;
				case nameof(Preform_motion_mode):
					return Preform_motion_mode;
				case nameof(Dispenser_motion):
					return Dispenser_motion;
				case nameof(Paste_remain_detection):
					return Paste_remain_detection;
				case nameof(Preform_cleaning):
					return Preform_cleaning;
				case nameof(Preform_paddle_recognition):
					return Preform_paddle_recognition;
				case nameof(Preform_fail_mark_recognition):
					return Preform_fail_mark_recognition;
				case nameof(Preform_Presence_inspection):
					return Preform_Presence_inspection;
				case nameof(Preform_area_inspection):
					return Preform_area_inspection;
				case nameof(Preform_form_inspection):
					return Preform_form_inspection;
				case nameof(Reverse_frame_recognition):
					return Reverse_frame_recognition;
				case nameof(Pickup_Die_BIN_select):
					return Pickup_Die_BIN_select;
				case nameof(Bonding_pickup_mode):
					return Bonding_pickup_mode;
				case nameof(Pre_heat):
					return Pre_heat;
				case nameof(Bond_heat):
					return Bond_heat;
				case nameof(After_heat):
					return After_heat;
				case nameof(Bonding_paddle_recognition):
					return Bonding_paddle_recognition;
				case nameof(Bonding_inspection):
					return Bonding_inspection;
				case nameof(Before_bonding_inspection):
					return Before_bonding_inspection;
				case nameof(Bonding_Die_surface_Judg_Insp):
					return Bonding_Die_surface_Judg_Insp;
				case nameof(Alignment_stage_die_recognition):
					return Alignment_stage_die_recognition;
				case nameof(Alignment_stage_particle_inspection):
					return Alignment_stage_particle_inspection;
				case nameof(Alignment_stage_Die_surface_inspection):
					return Alignment_stage_Die_surface_inspection;
				case nameof(Frame_feed):
					return Frame_feed;
				case nameof(Wafer_feed):
					return Wafer_feed;
				case nameof(Preform_motion):
					return Preform_motion;
				case nameof(Bonding_motion):
					return Bonding_motion;
				case nameof(Utility_check):
					return Utility_check;
				case nameof(Double_frame_detection):
					return Double_frame_detection;
				case nameof(Preform_stage_Vac_Det):
					return Preform_stage_Vac_Det;
				case nameof(Bonding_stage_Vac_Det):
					return Bonding_stage_Vac_Det;
				case nameof(ALIGN_stage_Vac_Det):
					return ALIGN_stage_Vac_Det;
				case nameof(Die_pickup_vacuum_detection):
					return Die_pickup_vacuum_detection;
				case nameof(Die_Det_after_stage_place):
					return Die_Det_after_stage_place;
				case nameof(Die_Det_after_stage_pickup):
					return Die_Det_after_stage_pickup;
				case nameof(Bonding_vacuum_detection):
					return Bonding_vacuum_detection;
				case nameof(Bonding_land_detection):
					return Bonding_land_detection;
				case nameof(Pickup_head_land_detection):
					return Pickup_head_land_detection;
				case nameof(Collect_cleaning_mode):
					return Collect_cleaning_mode;
				case nameof(Preform_circle_form_inspection):
					return Preform_circle_form_inspection;
			}
			throw new KeyNotFoundException(name);
		}

		private readonly AdsClient client;

		public GVL_Recipe_BoolWrapper(AdsClient client)
		{
			this.client = client;

			Reversed_Frame_Detection_mode = new BeckhoffBool(this.GetReversed_Frame_Detection_mode, client, 16448, 2003593){ Name = "Reversed_Frame_Detection_mode" };
			Reversed_Frame_Detection_logic_1 = new BeckhoffBool(this.GetReversed_Frame_Detection_logic_1, client, 16448, 2003596){ Name = "Reversed_Frame_Detection_logic_1" };
			Reversed_Frame_Detection_logic_2 = new BeckhoffBool(this.GetReversed_Frame_Detection_logic_2, client, 16448, 2003597){ Name = "Reversed_Frame_Detection_logic_2" };
			Reversed_Frame_Detection_logic_3 = new BeckhoffBool(this.GetReversed_Frame_Detection_logic_3, client, 16448, 2003598){ Name = "Reversed_Frame_Detection_logic_3" };
			Reversed_Frame_Detection_logic_4 = new BeckhoffBool(this.GetReversed_Frame_Detection_logic_4, client, 16448, 2003599){ Name = "Reversed_Frame_Detection_logic_4" };
			Feed_Cond_Input_media_type = new BeckhoffBool(this.GetFeed_Cond_Input_media_type, client, 16448, 2003600){ Name = "Feed_Cond_Input_media_type" };
			Feed_Cond_Frame_map = new BeckhoffBool(this.GetFeed_Cond_Frame_map, client, 16448, 2003601){ Name = "Feed_Cond_Frame_map" };
			Feed_Cond_Preform_stage_vacuum = new BeckhoffBool(this.GetFeed_Cond_Preform_stage_vacuum, client, 16448, 2003602){ Name = "Feed_Cond_Preform_stage_vacuum" };
			Feed_Cond_Bonding_stage_vacuum = new BeckhoffBool(this.GetFeed_Cond_Bonding_stage_vacuum, client, 16448, 2003603){ Name = "Feed_Cond_Bonding_stage_vacuum" };
			Feed_Cond_P_gripper_escape = new BeckhoffBool(this.GetFeed_Cond_P_gripper_escape, client, 16448, 2003604){ Name = "Feed_Cond_P_gripper_escape" };
			Feed_Cond_B_gripper_escape = new BeckhoffBool(this.GetFeed_Cond_B_gripper_escape, client, 16448, 2003605){ Name = "Feed_Cond_B_gripper_escape" };
			Feed_Cond_P_frame_grip_during = new BeckhoffBool(this.GetFeed_Cond_P_frame_grip_during, client, 16448, 2003606){ Name = "Feed_Cond_P_frame_grip_during" };
			Feed_Cond_B_frame_grip_during = new BeckhoffBool(this.GetFeed_Cond_B_frame_grip_during, client, 16448, 2003607){ Name = "Feed_Cond_B_frame_grip_during" };
			Feed_Cond_P_frame_clamp_during = new BeckhoffBool(this.GetFeed_Cond_P_frame_clamp_during, client, 16448, 2003608){ Name = "Feed_Cond_P_frame_clamp_during" };
			Feed_Cond_B_frame_clamp_during = new BeckhoffBool(this.GetFeed_Cond_B_frame_clamp_during, client, 16448, 2003609){ Name = "Feed_Cond_B_frame_clamp_during" };
			Feed_Cond_Cure_action = new BeckhoffBool(this.GetFeed_Cond_Cure_action, client, 16448, 2003610){ Name = "Feed_Cond_Cure_action" };
			Stage_Re_clamp_at_Vac_Det_retry = new BeckhoffBool(this.GetStage_Re_clamp_at_Vac_Det_retry, client, 16448, 2003611){ Name = "Stage_Re_clamp_at_Vac_Det_retry" };
			Action_after_FRM_pullout_error = new BeckhoffBool(this.GetAction_after_FRM_pullout_error, client, 16448, 2003612){ Name = "Action_after_FRM_pullout_error" };
			Frame_pusher_usage = new BeckhoffBool(this.GetFrame_pusher_usage, client, 16448, 2003613){ Name = "Frame_pusher_usage" };
			Frame_cleaning = new BeckhoffBool(this.GetFrame_cleaning, client, 16448, 2003614){ Name = "Frame_cleaning" };
			Frame_unload_jam_detection = new BeckhoffBool(this.GetFrame_unload_jam_detection, client, 16448, 2003615){ Name = "Frame_unload_jam_detection" };
			Wafer_Barcode_read = new BeckhoffBool(this.GetWafer_Barcode_read, client, 16448, 2003616){ Name = "Wafer_Barcode_read" };
			Order_of_wafer_load = new BeckhoffBool(this.GetOrder_of_wafer_load, client, 16448, 2003617){ Name = "Order_of_wafer_load" };
			Wafer_auto_unload = new BeckhoffBool(this.GetWafer_auto_unload, client, 16448, 2003618){ Name = "Wafer_auto_unload" };
			Reversed_frame_Rec_mode = new BeckhoffBool(this.GetReversed_frame_Rec_mode, client, 16448, 2003619){ Name = "Reversed_frame_Rec_mode" };
			Bonding_step_motion_mode = new BeckhoffBool(this.GetBonding_step_motion_mode, client, 16448, 2003620){ Name = "Bonding_step_motion_mode" };
			Paste_hard_skip_count = new BeckhoffBool(this.GetPaste_hard_skip_count, client, 16448, 2003621){ Name = "Paste_hard_skip_count" };
			Pre_heat_motion = new BeckhoffBool(this.GetPre_heat_motion, client, 16448, 2003622){ Name = "Pre_heat_motion" };
			Bond_heat_motion = new BeckhoffBool(this.GetBond_heat_motion, client, 16448, 2003623){ Name = "Bond_heat_motion" };
			Afrer_heat_motion = new BeckhoffBool(this.GetAfrer_heat_motion, client, 16448, 2003624){ Name = "Afrer_heat_motion" };
			Reverse_frame_detection_mode = new BeckhoffBool(this.GetReverse_frame_detection_mode, client, 16448, 2003625){ Name = "Reverse_frame_detection_mode" };
			Frame_map_mode = new BeckhoffBool(this.GetFrame_map_mode, client, 16448, 2003626){ Name = "Frame_map_mode" };
			Preform_stage_vacuum = new BeckhoffBool(this.GetPreform_stage_vacuum, client, 16448, 2003627){ Name = "Preform_stage_vacuum" };
			Bonding_stage_vacuum = new BeckhoffBool(this.GetBonding_stage_vacuum, client, 16448, 2003628){ Name = "Bonding_stage_vacuum" };
			Feeder_escape_at_preform = new BeckhoffBool(this.GetFeeder_escape_at_preform, client, 16448, 2003629){ Name = "Feeder_escape_at_preform" };
			Feeder_escape_at_bonding = new BeckhoffBool(this.GetFeeder_escape_at_bonding, client, 16448, 2003630){ Name = "Feeder_escape_at_bonding" };
			Preform_stage_up_down = new BeckhoffBool(this.GetPreform_stage_up_down, client, 16448, 2003631){ Name = "Preform_stage_up_down" };
			Bonding_stage_up_down = new BeckhoffBool(this.GetBonding_stage_up_down, client, 16448, 2003632){ Name = "Bonding_stage_up_down" };
			Frame_unload_rehold_distance = new BeckhoffBool(this.GetFrame_unload_rehold_distance, client, 16448, 2003633){ Name = "Frame_unload_rehold_distance" };
			Frame_unload_retry_mode = new BeckhoffBool(this.GetFrame_unload_retry_mode, client, 16448, 2003634){ Name = "Frame_unload_retry_mode" };
			Wafer_map = new BeckhoffBool(this.GetWafer_map, client, 16448, 2003635){ Name = "Wafer_map" };
			Wafer_recovery = new BeckhoffBool(this.GetWafer_recovery, client, 16448, 2003636){ Name = "Wafer_recovery" };
			Stop_after_last_wafer = new BeckhoffBool(this.GetStop_after_last_wafer, client, 16448, 2003637){ Name = "Stop_after_last_wafer" };
			Wafer_die_position_recognition_Conflict = new BeckhoffBool(this.GetWafer_die_position_recognition_Conflict, client, 16448, 2003638){ Name = "Wafer_die_position_recognition_Conflict" };
			Wafer_edge_recognition = new BeckhoffBool(this.GetWafer_edge_recognition, client, 16448, 2003639){ Name = "Wafer_edge_recognition" };
			Wafer_ink_mark_recognition = new BeckhoffBool(this.GetWafer_ink_mark_recognition, client, 16448, 2003640){ Name = "Wafer_ink_mark_recognition" };
			Wafer_target_die_check_Rec = new BeckhoffBool(this.GetWafer_target_die_check_Rec, client, 16448, 2003641){ Name = "Wafer_target_die_check_Rec" };
			Wafer_check_die = new BeckhoffBool(this.GetWafer_check_die, client, 16448, 2003642){ Name = "Wafer_check_die" };
			Wafer_die_Rec_error_mode_Conflict = new BeckhoffBool(this.GetWafer_die_Rec_error_mode_Conflict, client, 16448, 2003643){ Name = "Wafer_die_Rec_error_mode_Conflict" };
			Die_outline_recognition_mode = new BeckhoffBool(this.GetDie_outline_recognition_mode, client, 16448, 2003644){ Name = "Die_outline_recognition_mode" };
			Die_presence_recognition = new BeckhoffBool(this.GetDie_presence_recognition, client, 16448, 2003645){ Name = "Die_presence_recognition" };
			Die_crack_detection = new BeckhoffBool(this.GetDie_crack_detection, client, 16448, 2003646){ Name = "Die_crack_detection" };
			Wafer_Die_surface_Judg_Insp = new BeckhoffBool(this.GetWafer_Die_surface_Judg_Insp, client, 16448, 2003647){ Name = "Wafer_Die_surface_Judg_Insp" };
			Preform_motion_mode = new BeckhoffBool(this.GetPreform_motion_mode, client, 16448, 2003648){ Name = "Preform_motion_mode" };
			Dispenser_motion = new BeckhoffBool(this.GetDispenser_motion, client, 16448, 2003649){ Name = "Dispenser_motion" };
			Paste_remain_detection = new BeckhoffBool(this.GetPaste_remain_detection, client, 16448, 2003650){ Name = "Paste_remain_detection" };
			Preform_cleaning = new BeckhoffBool(this.GetPreform_cleaning, client, 16448, 2003651){ Name = "Preform_cleaning" };
			Preform_paddle_recognition = new BeckhoffBool(this.GetPreform_paddle_recognition, client, 16448, 2003652){ Name = "Preform_paddle_recognition" };
			Preform_fail_mark_recognition = new BeckhoffBool(this.GetPreform_fail_mark_recognition, client, 16448, 2003653){ Name = "Preform_fail_mark_recognition" };
			Preform_Presence_inspection = new BeckhoffBool(this.GetPreform_Presence_inspection, client, 16448, 2003654){ Name = "Preform_Presence_inspection" };
			Preform_area_inspection = new BeckhoffBool(this.GetPreform_area_inspection, client, 16448, 2003655){ Name = "Preform_area_inspection" };
			Preform_form_inspection = new BeckhoffBool(this.GetPreform_form_inspection, client, 16448, 2003656){ Name = "Preform_form_inspection" };
			Reverse_frame_recognition = new BeckhoffBool(this.GetReverse_frame_recognition, client, 16448, 2003657){ Name = "Reverse_frame_recognition" };
			Pickup_Die_BIN_select = new BeckhoffBool(this.GetPickup_Die_BIN_select, client, 16448, 2003658){ Name = "Pickup_Die_BIN_select" };
			Bonding_pickup_mode = new BeckhoffBool(this.GetBonding_pickup_mode, client, 16448, 2003659){ Name = "Bonding_pickup_mode" };
			Pre_heat = new BeckhoffBool(this.GetPre_heat, client, 16448, 2003660){ Name = "Pre_heat" };
			Bond_heat = new BeckhoffBool(this.GetBond_heat, client, 16448, 2003661){ Name = "Bond_heat" };
			After_heat = new BeckhoffBool(this.GetAfter_heat, client, 16448, 2003662){ Name = "After_heat" };
			Bonding_paddle_recognition = new BeckhoffBool(this.GetBonding_paddle_recognition, client, 16448, 2003663){ Name = "Bonding_paddle_recognition" };
			Bonding_inspection = new BeckhoffBool(this.GetBonding_inspection, client, 16448, 2003664){ Name = "Bonding_inspection" };
			Before_bonding_inspection = new BeckhoffBool(this.GetBefore_bonding_inspection, client, 16448, 2003665){ Name = "Before_bonding_inspection" };
			Bonding_Die_surface_Judg_Insp = new BeckhoffBool(this.GetBonding_Die_surface_Judg_Insp, client, 16448, 2003666){ Name = "Bonding_Die_surface_Judg_Insp" };
			Alignment_stage_die_recognition = new BeckhoffBool(this.GetAlignment_stage_die_recognition, client, 16448, 2003667){ Name = "Alignment_stage_die_recognition" };
			Alignment_stage_particle_inspection = new BeckhoffBool(this.GetAlignment_stage_particle_inspection, client, 16448, 2003668){ Name = "Alignment_stage_particle_inspection" };
			Alignment_stage_Die_surface_inspection = new BeckhoffBool(this.GetAlignment_stage_Die_surface_inspection, client, 16448, 2003669){ Name = "Alignment_stage_Die_surface_inspection" };
			Frame_feed = new BeckhoffBool(this.GetFrame_feed, client, 16448, 2003670){ Name = "Frame_feed" };
			Wafer_feed = new BeckhoffBool(this.GetWafer_feed, client, 16448, 2003671){ Name = "Wafer_feed" };
			Preform_motion = new BeckhoffBool(this.GetPreform_motion, client, 16448, 2003672){ Name = "Preform_motion" };
			Bonding_motion = new BeckhoffBool(this.GetBonding_motion, client, 16448, 2003673){ Name = "Bonding_motion" };
			Utility_check = new BeckhoffBool(this.GetUtility_check, client, 16448, 2003674){ Name = "Utility_check" };
			Double_frame_detection = new BeckhoffBool(this.GetDouble_frame_detection, client, 16448, 2003675){ Name = "Double_frame_detection" };
			Preform_stage_Vac_Det = new BeckhoffBool(this.GetPreform_stage_Vac_Det, client, 16448, 2003676){ Name = "Preform_stage_Vac_Det" };
			Bonding_stage_Vac_Det = new BeckhoffBool(this.GetBonding_stage_Vac_Det, client, 16448, 2003677){ Name = "Bonding_stage_Vac_Det" };
			ALIGN_stage_Vac_Det = new BeckhoffBool(this.GetALIGN_stage_Vac_Det, client, 16448, 2003678){ Name = "ALIGN_stage_Vac_Det" };
			Die_pickup_vacuum_detection = new BeckhoffBool(this.GetDie_pickup_vacuum_detection, client, 16448, 2003679){ Name = "Die_pickup_vacuum_detection" };
			Die_Det_after_stage_place = new BeckhoffBool(this.GetDie_Det_after_stage_place, client, 16448, 2003680){ Name = "Die_Det_after_stage_place" };
			Die_Det_after_stage_pickup = new BeckhoffBool(this.GetDie_Det_after_stage_pickup, client, 16448, 2003681){ Name = "Die_Det_after_stage_pickup" };
			Bonding_vacuum_detection = new BeckhoffBool(this.GetBonding_vacuum_detection, client, 16448, 2003682){ Name = "Bonding_vacuum_detection" };
			Bonding_land_detection = new BeckhoffBool(this.GetBonding_land_detection, client, 16448, 2003683){ Name = "Bonding_land_detection" };
			Pickup_head_land_detection = new BeckhoffBool(this.GetPickup_head_land_detection, client, 16448, 2003684){ Name = "Pickup_head_land_detection" };
			Collect_cleaning_mode = new BeckhoffBool(this.GetCollect_cleaning_mode, client, 16448, 2003685){ Name = "Collect_cleaning_mode" };
			Preform_circle_form_inspection = new BeckhoffBool(this.GetPreform_circle_form_inspection, client, 16448, 2003686){ Name = "Preform_circle_form_inspection" };
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
		~GVL_Recipe_BoolWrapper()
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
