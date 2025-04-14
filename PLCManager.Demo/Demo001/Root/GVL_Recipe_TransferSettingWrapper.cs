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
	/// Name from PLC:GVL_Recipe_TransferSetting
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_Recipe_TransferSettingWrapper
	{

		/// <summary>
		/// Name from PLC:Preform_stage_down_delay
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003888)
		/// Size: 4
		public IBaseData<float> Preform_stage_down_delay { get; }
		internal float ref_Preform_stage_down_delay = new float();

		/// <summary>
		/// Name from PLC:Delay_after_preform_stage_up
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003892)
		/// Size: 4
		public IBaseData<float> Delay_after_preform_stage_up { get; }
		internal float ref_Delay_after_preform_stage_up = new float();

		/// <summary>
		/// Name from PLC:Preform_stage_down_pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003896)
		/// Size: 4
		public IBaseData<float> Preform_stage_down_pos { get; }
		internal float ref_Preform_stage_down_pos = new float();

		/// <summary>
		/// Name from PLC:Preform_stage_upper_pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003900)
		/// Size: 4
		public IBaseData<float> Preform_stage_upper_pos { get; }
		internal float ref_Preform_stage_upper_pos = new float();

		/// <summary>
		/// Name from PLC:Preform_stage_going_up_speed
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003904)
		/// Size: 4
		public IBaseData<float> Preform_stage_going_up_speed { get; }
		internal float ref_Preform_stage_going_up_speed = new float();

		/// <summary>
		/// Name from PLC:PS_vacuum_release_time
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003908)
		/// Size: 4
		public IBaseData<float> PS_vacuum_release_time { get; }
		internal float ref_PS_vacuum_release_time = new float();

		/// <summary>
		/// Name from PLC:Preform_clamp_speed_Fast
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003912)
		/// Size: 4
		public IBaseData<float> Preform_clamp_speed_Fast { get; }
		internal float ref_Preform_clamp_speed_Fast = new float();

		/// <summary>
		/// Name from PLC:Preform_clamp_speed_Slow
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003916)
		/// Size: 4
		public IBaseData<float> Preform_clamp_speed_Slow { get; }
		internal float ref_Preform_clamp_speed_Slow = new float();

		/// <summary>
		/// Name from PLC:Bonding_stage_down_delay
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003920)
		/// Size: 4
		public IBaseData<float> Bonding_stage_down_delay { get; }
		internal float ref_Bonding_stage_down_delay = new float();

		/// <summary>
		/// Name from PLC:Delay_after_bonding_stage_up
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003924)
		/// Size: 4
		public IBaseData<float> Delay_after_bonding_stage_up { get; }
		internal float ref_Delay_after_bonding_stage_up = new float();

		/// <summary>
		/// Name from PLC:Bonding_stage_down_pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003928)
		/// Size: 4
		public IBaseData<float> Bonding_stage_down_pos { get; }
		internal float ref_Bonding_stage_down_pos = new float();

		/// <summary>
		/// Name from PLC:Bonding_stage_upper_pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003932)
		/// Size: 4
		public IBaseData<float> Bonding_stage_upper_pos { get; }
		internal float ref_Bonding_stage_upper_pos = new float();

		/// <summary>
		/// Name from PLC:Bonding_stage_going_up_speed
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003936)
		/// Size: 4
		public IBaseData<float> Bonding_stage_going_up_speed { get; }
		internal float ref_Bonding_stage_going_up_speed = new float();

		/// <summary>
		/// Name from PLC:Bonding_stage_pos_while_stop
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003940)
		/// Size: 4
		public IBaseData<float> Bonding_stage_pos_while_stop { get; }
		internal float ref_Bonding_stage_pos_while_stop = new float();

		/// <summary>
		/// Name from PLC:BS_vacuum_release_time
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003944)
		/// Size: 4
		public IBaseData<float> BS_vacuum_release_time { get; }
		internal float ref_BS_vacuum_release_time = new float();

		/// <summary>
		/// Name from PLC:BS_Vac_Det_retry_count
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003948)
		/// Size: 4
		public IBaseData<float> BS_Vac_Det_retry_count { get; }
		internal float ref_BS_Vac_Det_retry_count = new float();

		/// <summary>
		/// Name from PLC:BS_Vac_Det_retry_time
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003952)
		/// Size: 4
		public IBaseData<float> BS_Vac_Det_retry_time { get; }
		internal float ref_BS_Vac_Det_retry_time = new float();

		/// <summary>
		/// Name from PLC:Re_clamp_at_Vac_Det_retry
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003956)
		/// Size: 1
		public IBaseData<bool> Re_clamp_at_Vac_Det_retry { get; }
		internal bool ref_Re_clamp_at_Vac_Det_retry = new bool();

		/// <summary>
		/// Name from PLC:Action_after_FRM_pullout_error
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003957)
		/// Size: 1
		public IBaseData<bool> Action_after_FRM_pullout_error { get; }
		internal bool ref_Action_after_FRM_pullout_error = new bool();

		/// <summary>
		/// Name from PLC:Frame_pusher_usage
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003958)
		/// Size: 1
		public IBaseData<bool> Frame_pusher_usage { get; }
		internal bool ref_Frame_pusher_usage = new bool();

		/// <summary>
		/// Name from PLC:Frame_cleaning
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003959)
		/// Size: 1
		public IBaseData<bool> Frame_cleaning { get; }
		internal bool ref_Frame_cleaning = new bool();

		/// <summary>
		/// Name from PLC:Bonding_clamp_speed_Fast
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003960)
		/// Size: 4
		public IBaseData<float> Bonding_clamp_speed_Fast { get; }
		internal float ref_Bonding_clamp_speed_Fast = new float();

		/// <summary>
		/// Name from PLC:Bonding_clamp_speed_Slow
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003964)
		/// Size: 4
		public IBaseData<float> Bonding_clamp_speed_Slow { get; }
		internal float ref_Bonding_clamp_speed_Slow = new float();

		/// <summary>
		/// Name from PLC:Frame_head_detection_speed
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003968)
		/// Size: 4
		public IBaseData<float> Frame_head_detection_speed { get; }
		internal float ref_Frame_head_detection_speed = new float();

		/// <summary>
		/// Name from PLC:Frame_grip_position
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003972)
		/// Size: 4
		public IBaseData<float> Frame_grip_position { get; }
		internal float ref_Frame_grip_position = new float();

		/// <summary>
		/// Name from PLC:Gripper_stroke_one_side_in_MGZ
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003976)
		/// Size: 4
		public IBaseData<float> Gripper_stroke_one_side_in_MGZ { get; }
		internal float ref_Gripper_stroke_one_side_in_MGZ = new float();

		/// <summary>
		/// Name from PLC:Frame_Det_sens_offset_Rear
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003980)
		/// Size: 4
		public IBaseData<float> Frame_Det_sens_offset_Rear { get; }
		internal float ref_Frame_Det_sens_offset_Rear = new float();

		/// <summary>
		/// Name from PLC:Loader_feeder_transfer_timer
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003984)
		/// Size: 4
		public IBaseData<float> Loader_feeder_transfer_timer { get; }
		internal float ref_Loader_feeder_transfer_timer = new float();

		/// <summary>
		/// Name from PLC:Frame_pullout_speed
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003988)
		/// Size: 4
		public IBaseData<float> Frame_pullout_speed { get; }
		internal float ref_Frame_pullout_speed = new float();

		/// <summary>
		/// Name from PLC:Frame_pullout_pitch
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003992)
		/// Size: 4
		public IBaseData<float> Frame_pullout_pitch { get; }
		internal float ref_Frame_pullout_pitch = new float();

		/// <summary>
		/// Name from PLC:Frame_pullout_retry_count
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003996)
		/// Size: 4
		public IBaseData<float> Frame_pullout_retry_count { get; }
		internal float ref_Frame_pullout_retry_count = new float();

		/// <summary>
		/// Name from PLC:Grip_pos_offset_at_retry
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004000)
		/// Size: 4
		public IBaseData<float> Grip_pos_offset_at_retry { get; }
		internal float ref_Grip_pos_offset_at_retry = new float();

		/// <summary>
		/// Name from PLC:Frame_return_speed
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004004)
		/// Size: 4
		public IBaseData<float> Frame_return_speed { get; }
		internal float ref_Frame_return_speed = new float();

		/// <summary>
		/// Name from PLC:FIG_feeder_transfer_speed
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004008)
		/// Size: 4
		public IBaseData<float> FIG_feeder_transfer_speed { get; }
		internal float ref_FIG_feeder_transfer_speed = new float();

		/// <summary>
		/// Name from PLC:FIG_feeder_return_speed_Fast
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004012)
		/// Size: 4
		public IBaseData<float> FIG_feeder_return_speed_Fast { get; }
		internal float ref_FIG_feeder_return_speed_Fast = new float();

		/// <summary>
		/// Name from PLC:FIG_feeder_return_speed_Slow
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004016)
		/// Size: 4
		public IBaseData<float> FIG_feeder_return_speed_Slow { get; }
		internal float ref_FIG_feeder_return_speed_Slow = new float();

		/// <summary>
		/// Name from PLC:FIG_grip_motion_Fast
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004020)
		/// Size: 4
		public IBaseData<float> FIG_grip_motion_Fast { get; }
		internal float ref_FIG_grip_motion_Fast = new float();

		/// <summary>
		/// Name from PLC:FIG_grip_motion_Slow
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004024)
		/// Size: 4
		public IBaseData<float> FIG_grip_motion_Slow { get; }
		internal float ref_FIG_grip_motion_Slow = new float();

		/// <summary>
		/// Name from PLC:FIG_frame_head_detect_speed
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004028)
		/// Size: 4
		public IBaseData<float> FIG_frame_head_detect_speed { get; }
		internal float ref_FIG_frame_head_detect_speed = new float();

		/// <summary>
		/// Name from PLC:FIG_grip_pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004032)
		/// Size: 4
		public IBaseData<float> FIG_grip_pos { get; }
		internal float ref_FIG_grip_pos = new float();

		/// <summary>
		/// Name from PLC:FIG_Gripper_Stroke
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004036)
		/// Size: 4
		public IBaseData<float> FIG_Gripper_Stroke { get; }
		internal float ref_FIG_Gripper_Stroke = new float();

		/// <summary>
		/// Name from PLC:FIG_Frame_Detect_Sensor_Offset
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004040)
		/// Size: 4
		public IBaseData<float> FIG_Frame_Detect_Sensor_Offset { get; }
		internal float ref_FIG_Frame_Detect_Sensor_Offset = new float();

		/// <summary>
		/// Name from PLC:FIG_Loader_feeder_Transfer_Timer
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004044)
		/// Size: 4
		public IBaseData<float> FIG_Loader_feeder_Transfer_Timer { get; }
		internal float ref_FIG_Loader_feeder_Transfer_Timer = new float();

		/// <summary>
		/// Name from PLC:Reverse_Frame_DetSpeed1
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004048)
		/// Size: 4
		public IBaseData<float> Reverse_Frame_DetSpeed1 { get; }
		internal float ref_Reverse_Frame_DetSpeed1 = new float();

		/// <summary>
		/// Name from PLC:Reverse_Frame_DetSpeed2
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004052)
		/// Size: 4
		public IBaseData<float> Reverse_Frame_DetSpeed2 { get; }
		internal float ref_Reverse_Frame_DetSpeed2 = new float();

		/// <summary>
		/// Name from PLC:FCU_Main_feeder1_transfer_speed
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004056)
		/// Size: 4
		public IBaseData<float> FCU_Main_feeder1_transfer_speed { get; }
		internal float ref_FCU_Main_feeder1_transfer_speed = new float();

		/// <summary>
		/// Name from PLC:FCU_Main_feeder1_speed_Fast
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004060)
		/// Size: 4
		public IBaseData<float> FCU_Main_feeder1_speed_Fast { get; }
		internal float ref_FCU_Main_feeder1_speed_Fast = new float();

		/// <summary>
		/// Name from PLC:FCU_Main_feeder1_speed_Slow
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004064)
		/// Size: 4
		public IBaseData<float> FCU_Main_feeder1_speed_Slow { get; }
		internal float ref_FCU_Main_feeder1_speed_Slow = new float();

		/// <summary>
		/// Name from PLC:FCU_MF_1_grip_motion_Fast
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004068)
		/// Size: 4
		public IBaseData<float> FCU_MF_1_grip_motion_Fast { get; }
		internal float ref_FCU_MF_1_grip_motion_Fast = new float();

		/// <summary>
		/// Name from PLC:FCU_MF_1_grip_motion_Slow
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004072)
		/// Size: 4
		public IBaseData<float> FCU_MF_1_grip_motion_Slow { get; }
		internal float ref_FCU_MF_1_grip_motion_Slow = new float();

		/// <summary>
		/// Name from PLC:FCU_P_frame_clamp_transfer_timer
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004076)
		/// Size: 4
		public IBaseData<float> FCU_P_frame_clamp_transfer_timer { get; }
		internal float ref_FCU_P_frame_clamp_transfer_timer = new float();

		/// <summary>
		/// Name from PLC:FBU_Main_feeder2_transfer_speed
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004080)
		/// Size: 4
		public IBaseData<float> FBU_Main_feeder2_transfer_speed { get; }
		internal float ref_FBU_Main_feeder2_transfer_speed = new float();

		/// <summary>
		/// Name from PLC:FBU_Main_feeder2_speed_Fast
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004084)
		/// Size: 4
		public IBaseData<float> FBU_Main_feeder2_speed_Fast { get; }
		internal float ref_FBU_Main_feeder2_speed_Fast = new float();

		/// <summary>
		/// Name from PLC:FBU_Main_feeder2_speed_Slow
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004088)
		/// Size: 4
		public IBaseData<float> FBU_Main_feeder2_speed_Slow { get; }
		internal float ref_FBU_Main_feeder2_speed_Slow = new float();

		/// <summary>
		/// Name from PLC:FBU_MF_2_grip_motion_Fast
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004092)
		/// Size: 4
		public IBaseData<float> FBU_MF_2_grip_motion_Fast { get; }
		internal float ref_FBU_MF_2_grip_motion_Fast = new float();

		/// <summary>
		/// Name from PLC:FBU_MF_2_grip_motion_Slow
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004096)
		/// Size: 4
		public IBaseData<float> FBU_MF_2_grip_motion_Slow { get; }
		internal float ref_FBU_MF_2_grip_motion_Slow = new float();

		/// <summary>
		/// Name from PLC:FBU_Unload_feeder_transfer_timer
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004100)
		/// Size: 4
		public IBaseData<float> FBU_Unload_feeder_transfer_timer { get; }
		internal float ref_FBU_Unload_feeder_transfer_timer = new float();

		/// <summary>
		/// Name from PLC:FBU_B_frame_clamp_transfer_timer
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004104)
		/// Size: 4
		public IBaseData<float> FBU_B_frame_clamp_transfer_timer { get; }
		internal float ref_FBU_B_frame_clamp_transfer_timer = new float();

		/// <summary>
		/// Name from PLC:UL_F_transfer_speed
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004108)
		/// Size: 4
		public IBaseData<float> UL_F_transfer_speed { get; }
		internal float ref_UL_F_transfer_speed = new float();

		/// <summary>
		/// Name from PLC:Unload_feeder_speed_Fast
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004112)
		/// Size: 4
		public IBaseData<float> Unload_feeder_speed_Fast { get; }
		internal float ref_Unload_feeder_speed_Fast = new float();

		/// <summary>
		/// Name from PLC:Unload_feeder_speed_Slow
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004116)
		/// Size: 4
		public IBaseData<float> Unload_feeder_speed_Slow { get; }
		internal float ref_Unload_feeder_speed_Slow = new float();

		/// <summary>
		/// Name from PLC:UL_F_grip_speed_Fast
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004120)
		/// Size: 4
		public IBaseData<float> UL_F_grip_speed_Fast { get; }
		internal float ref_UL_F_grip_speed_Fast = new float();

		/// <summary>
		/// Name from PLC:UL_F_grip_speed_Slow
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004124)
		/// Size: 4
		public IBaseData<float> UL_F_grip_speed_Slow { get; }
		internal float ref_UL_F_grip_speed_Slow = new float();

		/// <summary>
		/// Name from PLC:LAF_transfer_timer
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004128)
		/// Size: 4
		public IBaseData<float> LAF_transfer_timer { get; }
		internal float ref_LAF_transfer_timer = new float();

		/// <summary>
		/// Name from PLC:Frame_push_out_pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004132)
		/// Size: 4
		public IBaseData<float> Frame_push_out_pos { get; }
		internal float ref_Frame_push_out_pos = new float();

		/// <summary>
		/// Name from PLC:Frame_unload_speed
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004136)
		/// Size: 4
		public IBaseData<float> Frame_unload_speed { get; }
		internal float ref_Frame_unload_speed = new float();

		/// <summary>
		/// Name from PLC:Frame_overload_return_speed
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004140)
		/// Size: 4
		public IBaseData<float> Frame_overload_return_speed { get; }
		internal float ref_Frame_overload_return_speed = new float();

		/// <summary>
		/// Name from PLC:Frame_unload_pitch
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004144)
		/// Size: 4
		public IBaseData<float> Frame_unload_pitch { get; }
		internal float ref_Frame_unload_pitch = new float();

		/// <summary>
		/// Name from PLC:Frame_unload_speed_change_pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004148)
		/// Size: 4
		public IBaseData<float> Frame_unload_speed_change_pos { get; }
		internal float ref_Frame_unload_speed_change_pos = new float();

		/// <summary>
		/// Name from PLC:Strip_insert_speed1
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004152)
		/// Size: 4
		public IBaseData<float> Strip_insert_speed1 { get; }
		internal float ref_Strip_insert_speed1 = new float();

		/// <summary>
		/// Name from PLC:Strip_insert_speed2
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004156)
		/// Size: 4
		public IBaseData<float> Strip_insert_speed2 { get; }
		internal float ref_Strip_insert_speed2 = new float();

		/// <summary>
		/// Name from PLC:Frame_unload_timer
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004160)
		/// Size: 4
		public IBaseData<float> Frame_unload_timer { get; }
		internal float ref_Frame_unload_timer = new float();

		/// <summary>
		/// Name from PLC:Frame_unload_jam_detection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004164)
		/// Size: 1
		public IBaseData<bool> Frame_unload_jam_detection { get; }
		internal bool ref_Frame_unload_jam_detection = new bool();

		/// <summary>
		/// Name from PLC:IMH_Magazine_flow_direction
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004165)
		/// Size: 1
		public IBaseData<bool> IMH_Magazine_flow_direction { get; }
		internal bool ref_IMH_Magazine_flow_direction = new bool();

		/// <summary>
		/// Name from PLC:G_Clean_Row_Num
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2004166)
		/// Size: 2
		public IBaseData<short> G_Clean_Row_Num { get; }
		internal short ref_G_Clean_Row_Num = new short();

		/// <summary>
		/// Name from PLC:Cure_I_F_Time_out1
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004168)
		/// Size: 4
		public IBaseData<float> Cure_I_F_Time_out1 { get; }
		internal float ref_Cure_I_F_Time_out1 = new float();

		/// <summary>
		/// Name from PLC:Cure_I_F_Time_out2
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004172)
		/// Size: 4
		public IBaseData<float> Cure_I_F_Time_out2 { get; }
		internal float ref_Cure_I_F_Time_out2 = new float();

		/// <summary>
		/// Name from PLC:G_FIG_XM_TO_Sensor_Pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004176)
		/// Size: 4
		public IBaseData<float> G_FIG_XM_TO_Sensor_Pos { get; }
		internal float ref_G_FIG_XM_TO_Sensor_Pos = new float();

		/// <summary>
		/// Name from PLC:G_FIG_XM_TO_Preform_Pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004180)
		/// Size: 4
		public IBaseData<float> G_FIG_XM_TO_Preform_Pos { get; }
		internal float ref_G_FIG_XM_TO_Preform_Pos = new float();

		/// <summary>
		/// Name from PLC:G_FIG_CM_TO_Preform_Pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004184)
		/// Size: 4
		public IBaseData<float> G_FIG_CM_TO_Preform_Pos { get; }
		internal float ref_G_FIG_CM_TO_Preform_Pos = new float();

		/// <summary>
		/// Name from PLC:G_FIG_TO_FCU_Row_Num
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2004188)
		/// Size: 2
		public IBaseData<short> G_FIG_TO_FCU_Row_Num { get; }
		internal short ref_G_FIG_TO_FCU_Row_Num = new short();

		/// <summary>
		/// Name from PLC:G_FCU_Row_Num
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2004190)
		/// Size: 2
		public IBaseData<short> G_FCU_Row_Num { get; }
		internal short ref_G_FCU_Row_Num = new short();

		/// <summary>
		/// Name from PLC:G_FCU_TO_FBU_Row_Num
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2004192)
		/// Size: 2
		public IBaseData<short> G_FCU_TO_FBU_Row_Num { get; }
		internal short ref_G_FCU_TO_FBU_Row_Num = new short();

		/// <summary>
		/// Name from PLC:G_FBU_Row_Num
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2004194)
		/// Size: 2
		public IBaseData<short> G_FBU_Row_Num { get; }
		internal short ref_G_FBU_Row_Num = new short();

		/// <summary>
		/// Name from PLC:G_Clean_Base_MaxRow
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2004196)
		/// Size: 2
		public IBaseData<short> G_Clean_Base_MaxRow { get; }
		internal short ref_G_Clean_Base_MaxRow = new short();

		/// <summary>
		/// Name from PLC:G_Clean_MoveBase_Num
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2004198)
		/// Size: 2
		public IBaseData<short> G_Clean_MoveBase_Num { get; }
		internal short ref_G_Clean_MoveBase_Num = new short();

		/// <summary>
		/// Name from PLC:G_Bonding_MaxRow
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2004200)
		/// Size: 2
		public IBaseData<short> G_Bonding_MaxRow { get; }
		internal short ref_G_Bonding_MaxRow = new short();

		/// <summary>
		/// Name from PLC:G_Bonded_Num
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2004202)
		/// Size: 2
		public IBaseData<short> G_Bonded_Num { get; }
		internal short ref_G_Bonded_Num = new short();

		/// <summary>
		/// Name from PLC:IMH_ZM_speed_Fast
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004204)
		/// Size: 4
		public IBaseData<float> IMH_ZM_speed_Fast { get; }
		internal float ref_IMH_ZM_speed_Fast = new float();

		/// <summary>
		/// Name from PLC:IMH_ZM_speed_Slow
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004208)
		/// Size: 4
		public IBaseData<float> IMH_ZM_speed_Slow { get; }
		internal float ref_IMH_ZM_speed_Slow = new float();

		/// <summary>
		/// Name from PLC:IMH_YM_speed_Fast
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004212)
		/// Size: 4
		public IBaseData<float> IMH_YM_speed_Fast { get; }
		internal float ref_IMH_YM_speed_Fast = new float();

		/// <summary>
		/// Name from PLC:IMH_YM_speed_Slow
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004216)
		/// Size: 4
		public IBaseData<float> IMH_YM_speed_Slow { get; }
		internal float ref_IMH_YM_speed_Slow = new float();

		/// <summary>
		/// Name from PLC:IMH_YC_response_time
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004220)
		/// Size: 4
		public IBaseData<float> IMH_YC_response_time { get; }
		internal float ref_IMH_YC_response_time = new float();

		/// <summary>
		/// Name from PLC:IMH_ZC_response_time
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004224)
		/// Size: 4
		public IBaseData<float> IMH_ZC_response_time { get; }
		internal float ref_IMH_ZC_response_time = new float();

		/// <summary>
		/// Name from PLC:IMH_Magazine_transfer_speed
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004228)
		/// Size: 1
		public IBaseData<bool> IMH_Magazine_transfer_speed { get; }
		internal bool ref_IMH_Magazine_transfer_speed = new bool();

		/// <summary>
		/// Name from PLC:IMH_MGZ_Load_Flow_DIR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004229)
		/// Size: 1
		public IBaseData<bool> IMH_MGZ_Load_Flow_DIR { get; }
		internal bool ref_IMH_MGZ_Load_Flow_DIR = new bool();

		/// <summary>
		/// Name from PLC:IMH_MGZ_Transfer_Speed
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004230)
		/// Size: 1
		public IBaseData<bool> IMH_MGZ_Transfer_Speed { get; }
		internal bool ref_IMH_MGZ_Transfer_Speed = new bool();

		/// <summary>
		/// Name from PLC:OMH_Magazine_flow_direction
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004231)
		/// Size: 1
		public IBaseData<bool> OMH_Magazine_flow_direction { get; }
		internal bool ref_OMH_Magazine_flow_direction = new bool();

		/// <summary>
		/// Name from PLC:IMH_Frame_Pusher_Push_Speed
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004232)
		/// Size: 4
		public IBaseData<float> IMH_Frame_Pusher_Push_Speed { get; }
		internal float ref_IMH_Frame_Pusher_Push_Speed = new float();

		/// <summary>
		/// Name from PLC:IMH_Frame_Pusher_Return_Speed
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004236)
		/// Size: 4
		public IBaseData<float> IMH_Frame_Pusher_Return_Speed { get; }
		internal float ref_IMH_Frame_Pusher_Return_Speed = new float();

		/// <summary>
		/// Name from PLC:IMH_Side_Clamp_Response_Time
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004240)
		/// Size: 4
		public IBaseData<float> IMH_Side_Clamp_Response_Time { get; }
		internal float ref_IMH_Side_Clamp_Response_Time = new float();

		/// <summary>
		/// Name from PLC:OMH_ZM_speed_Fast
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004244)
		/// Size: 4
		public IBaseData<float> OMH_ZM_speed_Fast { get; }
		internal float ref_OMH_ZM_speed_Fast = new float();

		/// <summary>
		/// Name from PLC:OMH_ZM_speed_Slow
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004248)
		/// Size: 4
		public IBaseData<float> OMH_ZM_speed_Slow { get; }
		internal float ref_OMH_ZM_speed_Slow = new float();

		/// <summary>
		/// Name from PLC:OMH_YM_speed_Fast
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004252)
		/// Size: 4
		public IBaseData<float> OMH_YM_speed_Fast { get; }
		internal float ref_OMH_YM_speed_Fast = new float();

		/// <summary>
		/// Name from PLC:OMH_YM_speed_Slow
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004256)
		/// Size: 4
		public IBaseData<float> OMH_YM_speed_Slow { get; }
		internal float ref_OMH_YM_speed_Slow = new float();

		/// <summary>
		/// Name from PLC:OMH_ZC_response_time
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004260)
		/// Size: 4
		public IBaseData<float> OMH_ZC_response_time { get; }
		internal float ref_OMH_ZC_response_time = new float();

		/// <summary>
		/// Name from PLC:OMH_YC_response_time
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004264)
		/// Size: 4
		public IBaseData<float> OMH_YC_response_time { get; }
		internal float ref_OMH_YC_response_time = new float();

		/// <summary>
		/// Name from PLC:OMH_Magazine_transfer_speed
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004268)
		/// Size: 1
		public IBaseData<bool> OMH_Magazine_transfer_speed { get; }
		internal bool ref_OMH_Magazine_transfer_speed = new bool();

		/// <summary>
		/// Name from PLC:OMH_MGZ_Load_Flow_DIR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004269)
		/// Size: 1
		public IBaseData<bool> OMH_MGZ_Load_Flow_DIR { get; }
		internal bool ref_OMH_MGZ_Load_Flow_DIR = new bool();

		/// <summary>
		/// Name from PLC:OMH_MGZ_Transfer_Speed
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004270)
		/// Size: 1
		public IBaseData<bool> OMH_MGZ_Transfer_Speed { get; }
		internal bool ref_OMH_MGZ_Transfer_Speed = new bool();

		/// <summary>
		/// Name from PLC:OMH_Side_Clamp_Response_Time
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004272)
		/// Size: 4
		public IBaseData<float> OMH_Side_Clamp_Response_Time { get; }
		internal float ref_OMH_Side_Clamp_Response_Time = new float();

		/// <summary>
		/// Name from PLC:G_BasePitch_EveryRow
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2004276)
		/// Size: 2
		public IBaseData<short> G_BasePitch_EveryRow { get; }
		internal short ref_G_BasePitch_EveryRow = new short();

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
