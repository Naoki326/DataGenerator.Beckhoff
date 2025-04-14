using System.Runtime.InteropServices;
using System.Threading;
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
	
	public sealed partial class GVL_Recipe_BoolWrapper
	{

		/// <summary>
		/// Name from PLC:Reversed_Frame_Detection_mode
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003593)
		/// Size: 1
		public IBaseData<bool> Reversed_Frame_Detection_mode { get; }
		internal bool ref_Reversed_Frame_Detection_mode = new bool();

		/// <summary>
		/// Name from PLC:Reversed_Frame_Detection_logic_1
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003596)
		/// Size: 1
		public IBaseData<bool> Reversed_Frame_Detection_logic_1 { get; }
		internal bool ref_Reversed_Frame_Detection_logic_1 = new bool();

		/// <summary>
		/// Name from PLC:Reversed_Frame_Detection_logic_2
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003597)
		/// Size: 1
		public IBaseData<bool> Reversed_Frame_Detection_logic_2 { get; }
		internal bool ref_Reversed_Frame_Detection_logic_2 = new bool();

		/// <summary>
		/// Name from PLC:Reversed_Frame_Detection_logic_3
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003598)
		/// Size: 1
		public IBaseData<bool> Reversed_Frame_Detection_logic_3 { get; }
		internal bool ref_Reversed_Frame_Detection_logic_3 = new bool();

		/// <summary>
		/// Name from PLC:Reversed_Frame_Detection_logic_4
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003599)
		/// Size: 1
		public IBaseData<bool> Reversed_Frame_Detection_logic_4 { get; }
		internal bool ref_Reversed_Frame_Detection_logic_4 = new bool();

		/// <summary>
		/// Name from PLC:Feed_Cond_Input_media_type
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003600)
		/// Size: 1
		public IBaseData<bool> Feed_Cond_Input_media_type { get; }
		internal bool ref_Feed_Cond_Input_media_type = new bool();

		/// <summary>
		/// Name from PLC:Feed_Cond_Frame_map
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003601)
		/// Size: 1
		public IBaseData<bool> Feed_Cond_Frame_map { get; }
		internal bool ref_Feed_Cond_Frame_map = new bool();

		/// <summary>
		/// Name from PLC:Feed_Cond_Preform_stage_vacuum
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003602)
		/// Size: 1
		public IBaseData<bool> Feed_Cond_Preform_stage_vacuum { get; }
		internal bool ref_Feed_Cond_Preform_stage_vacuum = new bool();

		/// <summary>
		/// Name from PLC:Feed_Cond_Bonding_stage_vacuum
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003603)
		/// Size: 1
		public IBaseData<bool> Feed_Cond_Bonding_stage_vacuum { get; }
		internal bool ref_Feed_Cond_Bonding_stage_vacuum = new bool();

		/// <summary>
		/// Name from PLC:Feed_Cond_P_gripper_escape
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003604)
		/// Size: 1
		public IBaseData<bool> Feed_Cond_P_gripper_escape { get; }
		internal bool ref_Feed_Cond_P_gripper_escape = new bool();

		/// <summary>
		/// Name from PLC:Feed_Cond_B_gripper_escape
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003605)
		/// Size: 1
		public IBaseData<bool> Feed_Cond_B_gripper_escape { get; }
		internal bool ref_Feed_Cond_B_gripper_escape = new bool();

		/// <summary>
		/// Name from PLC:Feed_Cond_P_frame_grip_during
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003606)
		/// Size: 1
		public IBaseData<bool> Feed_Cond_P_frame_grip_during { get; }
		internal bool ref_Feed_Cond_P_frame_grip_during = new bool();

		/// <summary>
		/// Name from PLC:Feed_Cond_B_frame_grip_during
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003607)
		/// Size: 1
		public IBaseData<bool> Feed_Cond_B_frame_grip_during { get; }
		internal bool ref_Feed_Cond_B_frame_grip_during = new bool();

		/// <summary>
		/// Name from PLC:Feed_Cond_P_frame_clamp_during
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003608)
		/// Size: 1
		public IBaseData<bool> Feed_Cond_P_frame_clamp_during { get; }
		internal bool ref_Feed_Cond_P_frame_clamp_during = new bool();

		/// <summary>
		/// Name from PLC:Feed_Cond_B_frame_clamp_during
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003609)
		/// Size: 1
		public IBaseData<bool> Feed_Cond_B_frame_clamp_during { get; }
		internal bool ref_Feed_Cond_B_frame_clamp_during = new bool();

		/// <summary>
		/// Name from PLC:Feed_Cond_Cure_action
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003610)
		/// Size: 1
		public IBaseData<bool> Feed_Cond_Cure_action { get; }
		internal bool ref_Feed_Cond_Cure_action = new bool();

		/// <summary>
		/// Name from PLC:Stage_Re_clamp_at_Vac_Det_retry
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003611)
		/// Size: 1
		public IBaseData<bool> Stage_Re_clamp_at_Vac_Det_retry { get; }
		internal bool ref_Stage_Re_clamp_at_Vac_Det_retry = new bool();

		/// <summary>
		/// Name from PLC:Action_after_FRM_pullout_error
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003612)
		/// Size: 1
		public IBaseData<bool> Action_after_FRM_pullout_error { get; }
		internal bool ref_Action_after_FRM_pullout_error = new bool();

		/// <summary>
		/// Name from PLC:Frame_pusher_usage
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003613)
		/// Size: 1
		public IBaseData<bool> Frame_pusher_usage { get; }
		internal bool ref_Frame_pusher_usage = new bool();

		/// <summary>
		/// Name from PLC:Frame_cleaning
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003614)
		/// Size: 1
		public IBaseData<bool> Frame_cleaning { get; }
		internal bool ref_Frame_cleaning = new bool();

		/// <summary>
		/// Name from PLC:Frame_unload_jam_detection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003615)
		/// Size: 1
		public IBaseData<bool> Frame_unload_jam_detection { get; }
		internal bool ref_Frame_unload_jam_detection = new bool();

		/// <summary>
		/// Name from PLC:Wafer_Barcode_read
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003616)
		/// Size: 1
		public IBaseData<bool> Wafer_Barcode_read { get; }
		internal bool ref_Wafer_Barcode_read = new bool();

		/// <summary>
		/// Name from PLC:Order_of_wafer_load
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003617)
		/// Size: 1
		public IBaseData<bool> Order_of_wafer_load { get; }
		internal bool ref_Order_of_wafer_load = new bool();

		/// <summary>
		/// Name from PLC:Wafer_auto_unload
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003618)
		/// Size: 1
		public IBaseData<bool> Wafer_auto_unload { get; }
		internal bool ref_Wafer_auto_unload = new bool();

		/// <summary>
		/// Name from PLC:Reversed_frame_Rec_mode
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003619)
		/// Size: 1
		public IBaseData<bool> Reversed_frame_Rec_mode { get; }
		internal bool ref_Reversed_frame_Rec_mode = new bool();

		/// <summary>
		/// Name from PLC:Bonding_step_motion_mode
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003620)
		/// Size: 1
		public IBaseData<bool> Bonding_step_motion_mode { get; }
		internal bool ref_Bonding_step_motion_mode = new bool();

		/// <summary>
		/// Name from PLC:Paste_hard_skip_count
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003621)
		/// Size: 1
		public IBaseData<bool> Paste_hard_skip_count { get; }
		internal bool ref_Paste_hard_skip_count = new bool();

		/// <summary>
		/// Name from PLC:Pre_heat_motion
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003622)
		/// Size: 1
		public IBaseData<bool> Pre_heat_motion { get; }
		internal bool ref_Pre_heat_motion = new bool();

		/// <summary>
		/// Name from PLC:Bond_heat_motion
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003623)
		/// Size: 1
		public IBaseData<bool> Bond_heat_motion { get; }
		internal bool ref_Bond_heat_motion = new bool();

		/// <summary>
		/// Name from PLC:Afrer_heat_motion
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003624)
		/// Size: 1
		public IBaseData<bool> Afrer_heat_motion { get; }
		internal bool ref_Afrer_heat_motion = new bool();

		/// <summary>
		/// Name from PLC:Reverse_frame_detection_mode
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003625)
		/// Size: 1
		public IBaseData<bool> Reverse_frame_detection_mode { get; }
		internal bool ref_Reverse_frame_detection_mode = new bool();

		/// <summary>
		/// Name from PLC:Frame_map_mode
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003626)
		/// Size: 1
		public IBaseData<bool> Frame_map_mode { get; }
		internal bool ref_Frame_map_mode = new bool();

		/// <summary>
		/// Name from PLC:Preform_stage_vacuum
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003627)
		/// Size: 1
		public IBaseData<bool> Preform_stage_vacuum { get; }
		internal bool ref_Preform_stage_vacuum = new bool();

		/// <summary>
		/// Name from PLC:Bonding_stage_vacuum
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003628)
		/// Size: 1
		public IBaseData<bool> Bonding_stage_vacuum { get; }
		internal bool ref_Bonding_stage_vacuum = new bool();

		/// <summary>
		/// Name from PLC:Feeder_escape_at_preform
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003629)
		/// Size: 1
		public IBaseData<bool> Feeder_escape_at_preform { get; }
		internal bool ref_Feeder_escape_at_preform = new bool();

		/// <summary>
		/// Name from PLC:Feeder_escape_at_bonding
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003630)
		/// Size: 1
		public IBaseData<bool> Feeder_escape_at_bonding { get; }
		internal bool ref_Feeder_escape_at_bonding = new bool();

		/// <summary>
		/// Name from PLC:Preform_stage_up_down
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003631)
		/// Size: 1
		public IBaseData<bool> Preform_stage_up_down { get; }
		internal bool ref_Preform_stage_up_down = new bool();

		/// <summary>
		/// Name from PLC:Bonding_stage_up_down
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003632)
		/// Size: 1
		public IBaseData<bool> Bonding_stage_up_down { get; }
		internal bool ref_Bonding_stage_up_down = new bool();

		/// <summary>
		/// Name from PLC:Frame_unload_rehold_distance
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003633)
		/// Size: 1
		public IBaseData<bool> Frame_unload_rehold_distance { get; }
		internal bool ref_Frame_unload_rehold_distance = new bool();

		/// <summary>
		/// Name from PLC:Frame_unload_retry_mode
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003634)
		/// Size: 1
		public IBaseData<bool> Frame_unload_retry_mode { get; }
		internal bool ref_Frame_unload_retry_mode = new bool();

		/// <summary>
		/// Name from PLC:Wafer_map
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003635)
		/// Size: 1
		public IBaseData<bool> Wafer_map { get; }
		internal bool ref_Wafer_map = new bool();

		/// <summary>
		/// Name from PLC:Wafer_recovery
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003636)
		/// Size: 1
		public IBaseData<bool> Wafer_recovery { get; }
		internal bool ref_Wafer_recovery = new bool();

		/// <summary>
		/// Name from PLC:Stop_after_last_wafer
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003637)
		/// Size: 1
		public IBaseData<bool> Stop_after_last_wafer { get; }
		internal bool ref_Stop_after_last_wafer = new bool();

		/// <summary>
		/// Name from PLC:Wafer_die_position_recognition_Conflict
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003638)
		/// Size: 1
		public IBaseData<bool> Wafer_die_position_recognition_Conflict { get; }
		internal bool ref_Wafer_die_position_recognition_Conflict = new bool();

		/// <summary>
		/// Name from PLC:Wafer_edge_recognition
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003639)
		/// Size: 1
		public IBaseData<bool> Wafer_edge_recognition { get; }
		internal bool ref_Wafer_edge_recognition = new bool();

		/// <summary>
		/// Name from PLC:Wafer_ink_mark_recognition
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003640)
		/// Size: 1
		public IBaseData<bool> Wafer_ink_mark_recognition { get; }
		internal bool ref_Wafer_ink_mark_recognition = new bool();

		/// <summary>
		/// Name from PLC:Wafer_target_die_check_Rec
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003641)
		/// Size: 1
		public IBaseData<bool> Wafer_target_die_check_Rec { get; }
		internal bool ref_Wafer_target_die_check_Rec = new bool();

		/// <summary>
		/// Name from PLC:Wafer_check_die
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003642)
		/// Size: 1
		public IBaseData<bool> Wafer_check_die { get; }
		internal bool ref_Wafer_check_die = new bool();

		/// <summary>
		/// Name from PLC:Wafer_die_Rec_error_mode_Conflict
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003643)
		/// Size: 1
		public IBaseData<bool> Wafer_die_Rec_error_mode_Conflict { get; }
		internal bool ref_Wafer_die_Rec_error_mode_Conflict = new bool();

		/// <summary>
		/// Name from PLC:Die_outline_recognition_mode
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003644)
		/// Size: 1
		public IBaseData<bool> Die_outline_recognition_mode { get; }
		internal bool ref_Die_outline_recognition_mode = new bool();

		/// <summary>
		/// Name from PLC:Die_presence_recognition
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003645)
		/// Size: 1
		public IBaseData<bool> Die_presence_recognition { get; }
		internal bool ref_Die_presence_recognition = new bool();

		/// <summary>
		/// Name from PLC:Die_crack_detection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003646)
		/// Size: 1
		public IBaseData<bool> Die_crack_detection { get; }
		internal bool ref_Die_crack_detection = new bool();

		/// <summary>
		/// Name from PLC:Wafer_Die_surface_Judg_Insp
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003647)
		/// Size: 1
		public IBaseData<bool> Wafer_Die_surface_Judg_Insp { get; }
		internal bool ref_Wafer_Die_surface_Judg_Insp = new bool();

		/// <summary>
		/// Name from PLC:Preform_motion_mode
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003648)
		/// Size: 1
		public IBaseData<bool> Preform_motion_mode { get; }
		internal bool ref_Preform_motion_mode = new bool();

		/// <summary>
		/// Name from PLC:Dispenser_motion
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003649)
		/// Size: 1
		public IBaseData<bool> Dispenser_motion { get; }
		internal bool ref_Dispenser_motion = new bool();

		/// <summary>
		/// Name from PLC:Paste_remain_detection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003650)
		/// Size: 1
		public IBaseData<bool> Paste_remain_detection { get; }
		internal bool ref_Paste_remain_detection = new bool();

		/// <summary>
		/// Name from PLC:Preform_cleaning
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003651)
		/// Size: 1
		public IBaseData<bool> Preform_cleaning { get; }
		internal bool ref_Preform_cleaning = new bool();

		/// <summary>
		/// Name from PLC:Preform_paddle_recognition
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003652)
		/// Size: 1
		public IBaseData<bool> Preform_paddle_recognition { get; }
		internal bool ref_Preform_paddle_recognition = new bool();

		/// <summary>
		/// Name from PLC:Preform_fail_mark_recognition
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003653)
		/// Size: 1
		public IBaseData<bool> Preform_fail_mark_recognition { get; }
		internal bool ref_Preform_fail_mark_recognition = new bool();

		/// <summary>
		/// Name from PLC:Preform_Presence_inspection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003654)
		/// Size: 1
		public IBaseData<bool> Preform_Presence_inspection { get; }
		internal bool ref_Preform_Presence_inspection = new bool();

		/// <summary>
		/// Name from PLC:Preform_area_inspection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003655)
		/// Size: 1
		public IBaseData<bool> Preform_area_inspection { get; }
		internal bool ref_Preform_area_inspection = new bool();

		/// <summary>
		/// Name from PLC:Preform_form_inspection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003656)
		/// Size: 1
		public IBaseData<bool> Preform_form_inspection { get; }
		internal bool ref_Preform_form_inspection = new bool();

		/// <summary>
		/// Name from PLC:Reverse_frame_recognition
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003657)
		/// Size: 1
		public IBaseData<bool> Reverse_frame_recognition { get; }
		internal bool ref_Reverse_frame_recognition = new bool();

		/// <summary>
		/// Name from PLC:Pickup_Die_BIN_select
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003658)
		/// Size: 1
		public IBaseData<bool> Pickup_Die_BIN_select { get; }
		internal bool ref_Pickup_Die_BIN_select = new bool();

		/// <summary>
		/// Name from PLC:Bonding_pickup_mode
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003659)
		/// Size: 1
		public IBaseData<bool> Bonding_pickup_mode { get; }
		internal bool ref_Bonding_pickup_mode = new bool();

		/// <summary>
		/// Name from PLC:Pre_heat
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003660)
		/// Size: 1
		public IBaseData<bool> Pre_heat { get; }
		internal bool ref_Pre_heat = new bool();

		/// <summary>
		/// Name from PLC:Bond_heat
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003661)
		/// Size: 1
		public IBaseData<bool> Bond_heat { get; }
		internal bool ref_Bond_heat = new bool();

		/// <summary>
		/// Name from PLC:After_heat
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003662)
		/// Size: 1
		public IBaseData<bool> After_heat { get; }
		internal bool ref_After_heat = new bool();

		/// <summary>
		/// Name from PLC:Bonding_paddle_recognition
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003663)
		/// Size: 1
		public IBaseData<bool> Bonding_paddle_recognition { get; }
		internal bool ref_Bonding_paddle_recognition = new bool();

		/// <summary>
		/// Name from PLC:Bonding_inspection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003664)
		/// Size: 1
		public IBaseData<bool> Bonding_inspection { get; }
		internal bool ref_Bonding_inspection = new bool();

		/// <summary>
		/// Name from PLC:Before_bonding_inspection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003665)
		/// Size: 1
		public IBaseData<bool> Before_bonding_inspection { get; }
		internal bool ref_Before_bonding_inspection = new bool();

		/// <summary>
		/// Name from PLC:Bonding_Die_surface_Judg_Insp
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003666)
		/// Size: 1
		public IBaseData<bool> Bonding_Die_surface_Judg_Insp { get; }
		internal bool ref_Bonding_Die_surface_Judg_Insp = new bool();

		/// <summary>
		/// Name from PLC:Alignment_stage_die_recognition
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003667)
		/// Size: 1
		public IBaseData<bool> Alignment_stage_die_recognition { get; }
		internal bool ref_Alignment_stage_die_recognition = new bool();

		/// <summary>
		/// Name from PLC:Alignment_stage_particle_inspection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003668)
		/// Size: 1
		public IBaseData<bool> Alignment_stage_particle_inspection { get; }
		internal bool ref_Alignment_stage_particle_inspection = new bool();

		/// <summary>
		/// Name from PLC:Alignment_stage_Die_surface_inspection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003669)
		/// Size: 1
		public IBaseData<bool> Alignment_stage_Die_surface_inspection { get; }
		internal bool ref_Alignment_stage_Die_surface_inspection = new bool();

		/// <summary>
		/// Name from PLC:Frame_feed
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003670)
		/// Size: 1
		public IBaseData<bool> Frame_feed { get; }
		internal bool ref_Frame_feed = new bool();

		/// <summary>
		/// Name from PLC:Wafer_feed
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003671)
		/// Size: 1
		public IBaseData<bool> Wafer_feed { get; }
		internal bool ref_Wafer_feed = new bool();

		/// <summary>
		/// Name from PLC:Preform_motion
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003672)
		/// Size: 1
		public IBaseData<bool> Preform_motion { get; }
		internal bool ref_Preform_motion = new bool();

		/// <summary>
		/// Name from PLC:Bonding_motion
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003673)
		/// Size: 1
		public IBaseData<bool> Bonding_motion { get; }
		internal bool ref_Bonding_motion = new bool();

		/// <summary>
		/// Name from PLC:Utility_check
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003674)
		/// Size: 1
		public IBaseData<bool> Utility_check { get; }
		internal bool ref_Utility_check = new bool();

		/// <summary>
		/// Name from PLC:Double_frame_detection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003675)
		/// Size: 1
		public IBaseData<bool> Double_frame_detection { get; }
		internal bool ref_Double_frame_detection = new bool();

		/// <summary>
		/// Name from PLC:Preform_stage_Vac_Det
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003676)
		/// Size: 1
		public IBaseData<bool> Preform_stage_Vac_Det { get; }
		internal bool ref_Preform_stage_Vac_Det = new bool();

		/// <summary>
		/// Name from PLC:Bonding_stage_Vac_Det
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003677)
		/// Size: 1
		public IBaseData<bool> Bonding_stage_Vac_Det { get; }
		internal bool ref_Bonding_stage_Vac_Det = new bool();

		/// <summary>
		/// Name from PLC:ALIGN_stage_Vac_Det
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003678)
		/// Size: 1
		public IBaseData<bool> ALIGN_stage_Vac_Det { get; }
		internal bool ref_ALIGN_stage_Vac_Det = new bool();

		/// <summary>
		/// Name from PLC:Die_pickup_vacuum_detection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003679)
		/// Size: 1
		public IBaseData<bool> Die_pickup_vacuum_detection { get; }
		internal bool ref_Die_pickup_vacuum_detection = new bool();

		/// <summary>
		/// Name from PLC:Die_Det_after_stage_place
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003680)
		/// Size: 1
		public IBaseData<bool> Die_Det_after_stage_place { get; }
		internal bool ref_Die_Det_after_stage_place = new bool();

		/// <summary>
		/// Name from PLC:Die_Det_after_stage_pickup
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003681)
		/// Size: 1
		public IBaseData<bool> Die_Det_after_stage_pickup { get; }
		internal bool ref_Die_Det_after_stage_pickup = new bool();

		/// <summary>
		/// Name from PLC:Bonding_vacuum_detection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003682)
		/// Size: 1
		public IBaseData<bool> Bonding_vacuum_detection { get; }
		internal bool ref_Bonding_vacuum_detection = new bool();

		/// <summary>
		/// Name from PLC:Bonding_land_detection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003683)
		/// Size: 1
		public IBaseData<bool> Bonding_land_detection { get; }
		internal bool ref_Bonding_land_detection = new bool();

		/// <summary>
		/// Name from PLC:Pickup_head_land_detection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003684)
		/// Size: 1
		public IBaseData<bool> Pickup_head_land_detection { get; }
		internal bool ref_Pickup_head_land_detection = new bool();

		/// <summary>
		/// Name from PLC:Collect_cleaning_mode
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003685)
		/// Size: 1
		public IBaseData<bool> Collect_cleaning_mode { get; }
		internal bool ref_Collect_cleaning_mode = new bool();

		/// <summary>
		/// Name from PLC:Preform_circle_form_inspection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003686)
		/// Size: 1
		public IBaseData<bool> Preform_circle_form_inspection { get; }
		internal bool ref_Preform_circle_form_inspection = new bool();

		internal override void Init()
		{
		}
		public override void CheckAndNotify(int timeout = -1, CancellationToken token = default)
		{
		    foreach (var child in Children)
		    {
		        child?.CheckAndNotify(timeout, token);
		    }
		}


	}

}
