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
	/// Name from PLC:GVL_Recipe_TransferSetting
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_Recipe_TransferSettingWrapper : BaseData, IBaseData
	{
		public override IEnumerable<IBaseData> Children
		{
			get
			{
				yield return Preform_stage_down_delay;
				yield return Delay_after_preform_stage_up;
				yield return Preform_stage_down_pos;
				yield return Preform_stage_upper_pos;
				yield return Preform_stage_going_up_speed;
				yield return PS_vacuum_release_time;
				yield return Preform_clamp_speed_Fast;
				yield return Preform_clamp_speed_Slow;
				yield return Bonding_stage_down_delay;
				yield return Delay_after_bonding_stage_up;
				yield return Bonding_stage_down_pos;
				yield return Bonding_stage_upper_pos;
				yield return Bonding_stage_going_up_speed;
				yield return Bonding_stage_pos_while_stop;
				yield return BS_vacuum_release_time;
				yield return BS_Vac_Det_retry_count;
				yield return BS_Vac_Det_retry_time;
				yield return Re_clamp_at_Vac_Det_retry;
				yield return Action_after_FRM_pullout_error;
				yield return Frame_pusher_usage;
				yield return Frame_cleaning;
				yield return Bonding_clamp_speed_Fast;
				yield return Bonding_clamp_speed_Slow;
				yield return Frame_head_detection_speed;
				yield return Frame_grip_position;
				yield return Gripper_stroke_one_side_in_MGZ;
				yield return Frame_Det_sens_offset_Rear;
				yield return Loader_feeder_transfer_timer;
				yield return Frame_pullout_speed;
				yield return Frame_pullout_pitch;
				yield return Frame_pullout_retry_count;
				yield return Grip_pos_offset_at_retry;
				yield return Frame_return_speed;
				yield return FIG_feeder_transfer_speed;
				yield return FIG_feeder_return_speed_Fast;
				yield return FIG_feeder_return_speed_Slow;
				yield return FIG_grip_motion_Fast;
				yield return FIG_grip_motion_Slow;
				yield return FIG_frame_head_detect_speed;
				yield return FIG_grip_pos;
				yield return FIG_Gripper_Stroke;
				yield return FIG_Frame_Detect_Sensor_Offset;
				yield return FIG_Loader_feeder_Transfer_Timer;
				yield return Reverse_Frame_DetSpeed1;
				yield return Reverse_Frame_DetSpeed2;
				yield return FCU_Main_feeder1_transfer_speed;
				yield return FCU_Main_feeder1_speed_Fast;
				yield return FCU_Main_feeder1_speed_Slow;
				yield return FCU_MF_1_grip_motion_Fast;
				yield return FCU_MF_1_grip_motion_Slow;
				yield return FCU_P_frame_clamp_transfer_timer;
				yield return FBU_Main_feeder2_transfer_speed;
				yield return FBU_Main_feeder2_speed_Fast;
				yield return FBU_Main_feeder2_speed_Slow;
				yield return FBU_MF_2_grip_motion_Fast;
				yield return FBU_MF_2_grip_motion_Slow;
				yield return FBU_Unload_feeder_transfer_timer;
				yield return FBU_B_frame_clamp_transfer_timer;
				yield return UL_F_transfer_speed;
				yield return Unload_feeder_speed_Fast;
				yield return Unload_feeder_speed_Slow;
				yield return UL_F_grip_speed_Fast;
				yield return UL_F_grip_speed_Slow;
				yield return LAF_transfer_timer;
				yield return Frame_push_out_pos;
				yield return Frame_unload_speed;
				yield return Frame_overload_return_speed;
				yield return Frame_unload_pitch;
				yield return Frame_unload_speed_change_pos;
				yield return Strip_insert_speed1;
				yield return Strip_insert_speed2;
				yield return Frame_unload_timer;
				yield return Frame_unload_jam_detection;
				yield return IMH_Magazine_flow_direction;
				yield return G_Clean_Row_Num;
				yield return Cure_I_F_Time_out1;
				yield return Cure_I_F_Time_out2;
				yield return G_FIG_XM_TO_Sensor_Pos;
				yield return G_FIG_XM_TO_Preform_Pos;
				yield return G_FIG_CM_TO_Preform_Pos;
				yield return G_FIG_TO_FCU_Row_Num;
				yield return G_FCU_Row_Num;
				yield return G_FCU_TO_FBU_Row_Num;
				yield return G_FBU_Row_Num;
				yield return G_Clean_Base_MaxRow;
				yield return G_Clean_MoveBase_Num;
				yield return G_Bonding_MaxRow;
				yield return G_Bonded_Num;
				yield return IMH_ZM_speed_Fast;
				yield return IMH_ZM_speed_Slow;
				yield return IMH_YM_speed_Fast;
				yield return IMH_YM_speed_Slow;
				yield return IMH_YC_response_time;
				yield return IMH_ZC_response_time;
				yield return IMH_Magazine_transfer_speed;
				yield return IMH_MGZ_Load_Flow_DIR;
				yield return IMH_MGZ_Transfer_Speed;
				yield return OMH_Magazine_flow_direction;
				yield return IMH_Frame_Pusher_Push_Speed;
				yield return IMH_Frame_Pusher_Return_Speed;
				yield return IMH_Side_Clamp_Response_Time;
				yield return OMH_ZM_speed_Fast;
				yield return OMH_ZM_speed_Slow;
				yield return OMH_YM_speed_Fast;
				yield return OMH_YM_speed_Slow;
				yield return OMH_ZC_response_time;
				yield return OMH_YC_response_time;
				yield return OMH_Magazine_transfer_speed;
				yield return OMH_MGZ_Load_Flow_DIR;
				yield return OMH_MGZ_Transfer_Speed;
				yield return OMH_Side_Clamp_Response_Time;
				yield return G_BasePitch_EveryRow;
			}
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Preform_stage_down_delay):
					return Preform_stage_down_delay;
				case nameof(Delay_after_preform_stage_up):
					return Delay_after_preform_stage_up;
				case nameof(Preform_stage_down_pos):
					return Preform_stage_down_pos;
				case nameof(Preform_stage_upper_pos):
					return Preform_stage_upper_pos;
				case nameof(Preform_stage_going_up_speed):
					return Preform_stage_going_up_speed;
				case nameof(PS_vacuum_release_time):
					return PS_vacuum_release_time;
				case nameof(Preform_clamp_speed_Fast):
					return Preform_clamp_speed_Fast;
				case nameof(Preform_clamp_speed_Slow):
					return Preform_clamp_speed_Slow;
				case nameof(Bonding_stage_down_delay):
					return Bonding_stage_down_delay;
				case nameof(Delay_after_bonding_stage_up):
					return Delay_after_bonding_stage_up;
				case nameof(Bonding_stage_down_pos):
					return Bonding_stage_down_pos;
				case nameof(Bonding_stage_upper_pos):
					return Bonding_stage_upper_pos;
				case nameof(Bonding_stage_going_up_speed):
					return Bonding_stage_going_up_speed;
				case nameof(Bonding_stage_pos_while_stop):
					return Bonding_stage_pos_while_stop;
				case nameof(BS_vacuum_release_time):
					return BS_vacuum_release_time;
				case nameof(BS_Vac_Det_retry_count):
					return BS_Vac_Det_retry_count;
				case nameof(BS_Vac_Det_retry_time):
					return BS_Vac_Det_retry_time;
				case nameof(Re_clamp_at_Vac_Det_retry):
					return Re_clamp_at_Vac_Det_retry;
				case nameof(Action_after_FRM_pullout_error):
					return Action_after_FRM_pullout_error;
				case nameof(Frame_pusher_usage):
					return Frame_pusher_usage;
				case nameof(Frame_cleaning):
					return Frame_cleaning;
				case nameof(Bonding_clamp_speed_Fast):
					return Bonding_clamp_speed_Fast;
				case nameof(Bonding_clamp_speed_Slow):
					return Bonding_clamp_speed_Slow;
				case nameof(Frame_head_detection_speed):
					return Frame_head_detection_speed;
				case nameof(Frame_grip_position):
					return Frame_grip_position;
				case nameof(Gripper_stroke_one_side_in_MGZ):
					return Gripper_stroke_one_side_in_MGZ;
				case nameof(Frame_Det_sens_offset_Rear):
					return Frame_Det_sens_offset_Rear;
				case nameof(Loader_feeder_transfer_timer):
					return Loader_feeder_transfer_timer;
				case nameof(Frame_pullout_speed):
					return Frame_pullout_speed;
				case nameof(Frame_pullout_pitch):
					return Frame_pullout_pitch;
				case nameof(Frame_pullout_retry_count):
					return Frame_pullout_retry_count;
				case nameof(Grip_pos_offset_at_retry):
					return Grip_pos_offset_at_retry;
				case nameof(Frame_return_speed):
					return Frame_return_speed;
				case nameof(FIG_feeder_transfer_speed):
					return FIG_feeder_transfer_speed;
				case nameof(FIG_feeder_return_speed_Fast):
					return FIG_feeder_return_speed_Fast;
				case nameof(FIG_feeder_return_speed_Slow):
					return FIG_feeder_return_speed_Slow;
				case nameof(FIG_grip_motion_Fast):
					return FIG_grip_motion_Fast;
				case nameof(FIG_grip_motion_Slow):
					return FIG_grip_motion_Slow;
				case nameof(FIG_frame_head_detect_speed):
					return FIG_frame_head_detect_speed;
				case nameof(FIG_grip_pos):
					return FIG_grip_pos;
				case nameof(FIG_Gripper_Stroke):
					return FIG_Gripper_Stroke;
				case nameof(FIG_Frame_Detect_Sensor_Offset):
					return FIG_Frame_Detect_Sensor_Offset;
				case nameof(FIG_Loader_feeder_Transfer_Timer):
					return FIG_Loader_feeder_Transfer_Timer;
				case nameof(Reverse_Frame_DetSpeed1):
					return Reverse_Frame_DetSpeed1;
				case nameof(Reverse_Frame_DetSpeed2):
					return Reverse_Frame_DetSpeed2;
				case nameof(FCU_Main_feeder1_transfer_speed):
					return FCU_Main_feeder1_transfer_speed;
				case nameof(FCU_Main_feeder1_speed_Fast):
					return FCU_Main_feeder1_speed_Fast;
				case nameof(FCU_Main_feeder1_speed_Slow):
					return FCU_Main_feeder1_speed_Slow;
				case nameof(FCU_MF_1_grip_motion_Fast):
					return FCU_MF_1_grip_motion_Fast;
				case nameof(FCU_MF_1_grip_motion_Slow):
					return FCU_MF_1_grip_motion_Slow;
				case nameof(FCU_P_frame_clamp_transfer_timer):
					return FCU_P_frame_clamp_transfer_timer;
				case nameof(FBU_Main_feeder2_transfer_speed):
					return FBU_Main_feeder2_transfer_speed;
				case nameof(FBU_Main_feeder2_speed_Fast):
					return FBU_Main_feeder2_speed_Fast;
				case nameof(FBU_Main_feeder2_speed_Slow):
					return FBU_Main_feeder2_speed_Slow;
				case nameof(FBU_MF_2_grip_motion_Fast):
					return FBU_MF_2_grip_motion_Fast;
				case nameof(FBU_MF_2_grip_motion_Slow):
					return FBU_MF_2_grip_motion_Slow;
				case nameof(FBU_Unload_feeder_transfer_timer):
					return FBU_Unload_feeder_transfer_timer;
				case nameof(FBU_B_frame_clamp_transfer_timer):
					return FBU_B_frame_clamp_transfer_timer;
				case nameof(UL_F_transfer_speed):
					return UL_F_transfer_speed;
				case nameof(Unload_feeder_speed_Fast):
					return Unload_feeder_speed_Fast;
				case nameof(Unload_feeder_speed_Slow):
					return Unload_feeder_speed_Slow;
				case nameof(UL_F_grip_speed_Fast):
					return UL_F_grip_speed_Fast;
				case nameof(UL_F_grip_speed_Slow):
					return UL_F_grip_speed_Slow;
				case nameof(LAF_transfer_timer):
					return LAF_transfer_timer;
				case nameof(Frame_push_out_pos):
					return Frame_push_out_pos;
				case nameof(Frame_unload_speed):
					return Frame_unload_speed;
				case nameof(Frame_overload_return_speed):
					return Frame_overload_return_speed;
				case nameof(Frame_unload_pitch):
					return Frame_unload_pitch;
				case nameof(Frame_unload_speed_change_pos):
					return Frame_unload_speed_change_pos;
				case nameof(Strip_insert_speed1):
					return Strip_insert_speed1;
				case nameof(Strip_insert_speed2):
					return Strip_insert_speed2;
				case nameof(Frame_unload_timer):
					return Frame_unload_timer;
				case nameof(Frame_unload_jam_detection):
					return Frame_unload_jam_detection;
				case nameof(IMH_Magazine_flow_direction):
					return IMH_Magazine_flow_direction;
				case nameof(G_Clean_Row_Num):
					return G_Clean_Row_Num;
				case nameof(Cure_I_F_Time_out1):
					return Cure_I_F_Time_out1;
				case nameof(Cure_I_F_Time_out2):
					return Cure_I_F_Time_out2;
				case nameof(G_FIG_XM_TO_Sensor_Pos):
					return G_FIG_XM_TO_Sensor_Pos;
				case nameof(G_FIG_XM_TO_Preform_Pos):
					return G_FIG_XM_TO_Preform_Pos;
				case nameof(G_FIG_CM_TO_Preform_Pos):
					return G_FIG_CM_TO_Preform_Pos;
				case nameof(G_FIG_TO_FCU_Row_Num):
					return G_FIG_TO_FCU_Row_Num;
				case nameof(G_FCU_Row_Num):
					return G_FCU_Row_Num;
				case nameof(G_FCU_TO_FBU_Row_Num):
					return G_FCU_TO_FBU_Row_Num;
				case nameof(G_FBU_Row_Num):
					return G_FBU_Row_Num;
				case nameof(G_Clean_Base_MaxRow):
					return G_Clean_Base_MaxRow;
				case nameof(G_Clean_MoveBase_Num):
					return G_Clean_MoveBase_Num;
				case nameof(G_Bonding_MaxRow):
					return G_Bonding_MaxRow;
				case nameof(G_Bonded_Num):
					return G_Bonded_Num;
				case nameof(IMH_ZM_speed_Fast):
					return IMH_ZM_speed_Fast;
				case nameof(IMH_ZM_speed_Slow):
					return IMH_ZM_speed_Slow;
				case nameof(IMH_YM_speed_Fast):
					return IMH_YM_speed_Fast;
				case nameof(IMH_YM_speed_Slow):
					return IMH_YM_speed_Slow;
				case nameof(IMH_YC_response_time):
					return IMH_YC_response_time;
				case nameof(IMH_ZC_response_time):
					return IMH_ZC_response_time;
				case nameof(IMH_Magazine_transfer_speed):
					return IMH_Magazine_transfer_speed;
				case nameof(IMH_MGZ_Load_Flow_DIR):
					return IMH_MGZ_Load_Flow_DIR;
				case nameof(IMH_MGZ_Transfer_Speed):
					return IMH_MGZ_Transfer_Speed;
				case nameof(OMH_Magazine_flow_direction):
					return OMH_Magazine_flow_direction;
				case nameof(IMH_Frame_Pusher_Push_Speed):
					return IMH_Frame_Pusher_Push_Speed;
				case nameof(IMH_Frame_Pusher_Return_Speed):
					return IMH_Frame_Pusher_Return_Speed;
				case nameof(IMH_Side_Clamp_Response_Time):
					return IMH_Side_Clamp_Response_Time;
				case nameof(OMH_ZM_speed_Fast):
					return OMH_ZM_speed_Fast;
				case nameof(OMH_ZM_speed_Slow):
					return OMH_ZM_speed_Slow;
				case nameof(OMH_YM_speed_Fast):
					return OMH_YM_speed_Fast;
				case nameof(OMH_YM_speed_Slow):
					return OMH_YM_speed_Slow;
				case nameof(OMH_ZC_response_time):
					return OMH_ZC_response_time;
				case nameof(OMH_YC_response_time):
					return OMH_YC_response_time;
				case nameof(OMH_Magazine_transfer_speed):
					return OMH_Magazine_transfer_speed;
				case nameof(OMH_MGZ_Load_Flow_DIR):
					return OMH_MGZ_Load_Flow_DIR;
				case nameof(OMH_MGZ_Transfer_Speed):
					return OMH_MGZ_Transfer_Speed;
				case nameof(OMH_Side_Clamp_Response_Time):
					return OMH_Side_Clamp_Response_Time;
				case nameof(G_BasePitch_EveryRow):
					return G_BasePitch_EveryRow;
			}
			throw new KeyNotFoundException(name);
		}

		private readonly AdsClient client;

		public GVL_Recipe_TransferSettingWrapper(AdsClient client)
		{
			this.client = client;

			Preform_stage_down_delay = new BeckhoffFloat(this.GetPreform_stage_down_delay, client, 16448, 2003888){ Name = "Preform_stage_down_delay" };
			Delay_after_preform_stage_up = new BeckhoffFloat(this.GetDelay_after_preform_stage_up, client, 16448, 2003892){ Name = "Delay_after_preform_stage_up" };
			Preform_stage_down_pos = new BeckhoffFloat(this.GetPreform_stage_down_pos, client, 16448, 2003896){ Name = "Preform_stage_down_pos" };
			Preform_stage_upper_pos = new BeckhoffFloat(this.GetPreform_stage_upper_pos, client, 16448, 2003900){ Name = "Preform_stage_upper_pos" };
			Preform_stage_going_up_speed = new BeckhoffFloat(this.GetPreform_stage_going_up_speed, client, 16448, 2003904){ Name = "Preform_stage_going_up_speed" };
			PS_vacuum_release_time = new BeckhoffFloat(this.GetPS_vacuum_release_time, client, 16448, 2003908){ Name = "PS_vacuum_release_time" };
			Preform_clamp_speed_Fast = new BeckhoffFloat(this.GetPreform_clamp_speed_Fast, client, 16448, 2003912){ Name = "Preform_clamp_speed_Fast" };
			Preform_clamp_speed_Slow = new BeckhoffFloat(this.GetPreform_clamp_speed_Slow, client, 16448, 2003916){ Name = "Preform_clamp_speed_Slow" };
			Bonding_stage_down_delay = new BeckhoffFloat(this.GetBonding_stage_down_delay, client, 16448, 2003920){ Name = "Bonding_stage_down_delay" };
			Delay_after_bonding_stage_up = new BeckhoffFloat(this.GetDelay_after_bonding_stage_up, client, 16448, 2003924){ Name = "Delay_after_bonding_stage_up" };
			Bonding_stage_down_pos = new BeckhoffFloat(this.GetBonding_stage_down_pos, client, 16448, 2003928){ Name = "Bonding_stage_down_pos" };
			Bonding_stage_upper_pos = new BeckhoffFloat(this.GetBonding_stage_upper_pos, client, 16448, 2003932){ Name = "Bonding_stage_upper_pos" };
			Bonding_stage_going_up_speed = new BeckhoffFloat(this.GetBonding_stage_going_up_speed, client, 16448, 2003936){ Name = "Bonding_stage_going_up_speed" };
			Bonding_stage_pos_while_stop = new BeckhoffFloat(this.GetBonding_stage_pos_while_stop, client, 16448, 2003940){ Name = "Bonding_stage_pos_while_stop" };
			BS_vacuum_release_time = new BeckhoffFloat(this.GetBS_vacuum_release_time, client, 16448, 2003944){ Name = "BS_vacuum_release_time" };
			BS_Vac_Det_retry_count = new BeckhoffFloat(this.GetBS_Vac_Det_retry_count, client, 16448, 2003948){ Name = "BS_Vac_Det_retry_count" };
			BS_Vac_Det_retry_time = new BeckhoffFloat(this.GetBS_Vac_Det_retry_time, client, 16448, 2003952){ Name = "BS_Vac_Det_retry_time" };
			Re_clamp_at_Vac_Det_retry = new BeckhoffBool(this.GetRe_clamp_at_Vac_Det_retry, client, 16448, 2003956){ Name = "Re_clamp_at_Vac_Det_retry" };
			Action_after_FRM_pullout_error = new BeckhoffBool(this.GetAction_after_FRM_pullout_error, client, 16448, 2003957){ Name = "Action_after_FRM_pullout_error" };
			Frame_pusher_usage = new BeckhoffBool(this.GetFrame_pusher_usage, client, 16448, 2003958){ Name = "Frame_pusher_usage" };
			Frame_cleaning = new BeckhoffBool(this.GetFrame_cleaning, client, 16448, 2003959){ Name = "Frame_cleaning" };
			Bonding_clamp_speed_Fast = new BeckhoffFloat(this.GetBonding_clamp_speed_Fast, client, 16448, 2003960){ Name = "Bonding_clamp_speed_Fast" };
			Bonding_clamp_speed_Slow = new BeckhoffFloat(this.GetBonding_clamp_speed_Slow, client, 16448, 2003964){ Name = "Bonding_clamp_speed_Slow" };
			Frame_head_detection_speed = new BeckhoffFloat(this.GetFrame_head_detection_speed, client, 16448, 2003968){ Name = "Frame_head_detection_speed" };
			Frame_grip_position = new BeckhoffFloat(this.GetFrame_grip_position, client, 16448, 2003972){ Name = "Frame_grip_position" };
			Gripper_stroke_one_side_in_MGZ = new BeckhoffFloat(this.GetGripper_stroke_one_side_in_MGZ, client, 16448, 2003976){ Name = "Gripper_stroke_one_side_in_MGZ" };
			Frame_Det_sens_offset_Rear = new BeckhoffFloat(this.GetFrame_Det_sens_offset_Rear, client, 16448, 2003980){ Name = "Frame_Det_sens_offset_Rear" };
			Loader_feeder_transfer_timer = new BeckhoffFloat(this.GetLoader_feeder_transfer_timer, client, 16448, 2003984){ Name = "Loader_feeder_transfer_timer" };
			Frame_pullout_speed = new BeckhoffFloat(this.GetFrame_pullout_speed, client, 16448, 2003988){ Name = "Frame_pullout_speed" };
			Frame_pullout_pitch = new BeckhoffFloat(this.GetFrame_pullout_pitch, client, 16448, 2003992){ Name = "Frame_pullout_pitch" };
			Frame_pullout_retry_count = new BeckhoffFloat(this.GetFrame_pullout_retry_count, client, 16448, 2003996){ Name = "Frame_pullout_retry_count" };
			Grip_pos_offset_at_retry = new BeckhoffFloat(this.GetGrip_pos_offset_at_retry, client, 16448, 2004000){ Name = "Grip_pos_offset_at_retry" };
			Frame_return_speed = new BeckhoffFloat(this.GetFrame_return_speed, client, 16448, 2004004){ Name = "Frame_return_speed" };
			FIG_feeder_transfer_speed = new BeckhoffFloat(this.GetFIG_feeder_transfer_speed, client, 16448, 2004008){ Name = "FIG_feeder_transfer_speed" };
			FIG_feeder_return_speed_Fast = new BeckhoffFloat(this.GetFIG_feeder_return_speed_Fast, client, 16448, 2004012){ Name = "FIG_feeder_return_speed_Fast" };
			FIG_feeder_return_speed_Slow = new BeckhoffFloat(this.GetFIG_feeder_return_speed_Slow, client, 16448, 2004016){ Name = "FIG_feeder_return_speed_Slow" };
			FIG_grip_motion_Fast = new BeckhoffFloat(this.GetFIG_grip_motion_Fast, client, 16448, 2004020){ Name = "FIG_grip_motion_Fast" };
			FIG_grip_motion_Slow = new BeckhoffFloat(this.GetFIG_grip_motion_Slow, client, 16448, 2004024){ Name = "FIG_grip_motion_Slow" };
			FIG_frame_head_detect_speed = new BeckhoffFloat(this.GetFIG_frame_head_detect_speed, client, 16448, 2004028){ Name = "FIG_frame_head_detect_speed" };
			FIG_grip_pos = new BeckhoffFloat(this.GetFIG_grip_pos, client, 16448, 2004032){ Name = "FIG_grip_pos" };
			FIG_Gripper_Stroke = new BeckhoffFloat(this.GetFIG_Gripper_Stroke, client, 16448, 2004036){ Name = "FIG_Gripper_Stroke" };
			FIG_Frame_Detect_Sensor_Offset = new BeckhoffFloat(this.GetFIG_Frame_Detect_Sensor_Offset, client, 16448, 2004040){ Name = "FIG_Frame_Detect_Sensor_Offset" };
			FIG_Loader_feeder_Transfer_Timer = new BeckhoffFloat(this.GetFIG_Loader_feeder_Transfer_Timer, client, 16448, 2004044){ Name = "FIG_Loader_feeder_Transfer_Timer" };
			Reverse_Frame_DetSpeed1 = new BeckhoffFloat(this.GetReverse_Frame_DetSpeed1, client, 16448, 2004048){ Name = "Reverse_Frame_DetSpeed1" };
			Reverse_Frame_DetSpeed2 = new BeckhoffFloat(this.GetReverse_Frame_DetSpeed2, client, 16448, 2004052){ Name = "Reverse_Frame_DetSpeed2" };
			FCU_Main_feeder1_transfer_speed = new BeckhoffFloat(this.GetFCU_Main_feeder1_transfer_speed, client, 16448, 2004056){ Name = "FCU_Main_feeder1_transfer_speed" };
			FCU_Main_feeder1_speed_Fast = new BeckhoffFloat(this.GetFCU_Main_feeder1_speed_Fast, client, 16448, 2004060){ Name = "FCU_Main_feeder1_speed_Fast" };
			FCU_Main_feeder1_speed_Slow = new BeckhoffFloat(this.GetFCU_Main_feeder1_speed_Slow, client, 16448, 2004064){ Name = "FCU_Main_feeder1_speed_Slow" };
			FCU_MF_1_grip_motion_Fast = new BeckhoffFloat(this.GetFCU_MF_1_grip_motion_Fast, client, 16448, 2004068){ Name = "FCU_MF_1_grip_motion_Fast" };
			FCU_MF_1_grip_motion_Slow = new BeckhoffFloat(this.GetFCU_MF_1_grip_motion_Slow, client, 16448, 2004072){ Name = "FCU_MF_1_grip_motion_Slow" };
			FCU_P_frame_clamp_transfer_timer = new BeckhoffFloat(this.GetFCU_P_frame_clamp_transfer_timer, client, 16448, 2004076){ Name = "FCU_P_frame_clamp_transfer_timer" };
			FBU_Main_feeder2_transfer_speed = new BeckhoffFloat(this.GetFBU_Main_feeder2_transfer_speed, client, 16448, 2004080){ Name = "FBU_Main_feeder2_transfer_speed" };
			FBU_Main_feeder2_speed_Fast = new BeckhoffFloat(this.GetFBU_Main_feeder2_speed_Fast, client, 16448, 2004084){ Name = "FBU_Main_feeder2_speed_Fast" };
			FBU_Main_feeder2_speed_Slow = new BeckhoffFloat(this.GetFBU_Main_feeder2_speed_Slow, client, 16448, 2004088){ Name = "FBU_Main_feeder2_speed_Slow" };
			FBU_MF_2_grip_motion_Fast = new BeckhoffFloat(this.GetFBU_MF_2_grip_motion_Fast, client, 16448, 2004092){ Name = "FBU_MF_2_grip_motion_Fast" };
			FBU_MF_2_grip_motion_Slow = new BeckhoffFloat(this.GetFBU_MF_2_grip_motion_Slow, client, 16448, 2004096){ Name = "FBU_MF_2_grip_motion_Slow" };
			FBU_Unload_feeder_transfer_timer = new BeckhoffFloat(this.GetFBU_Unload_feeder_transfer_timer, client, 16448, 2004100){ Name = "FBU_Unload_feeder_transfer_timer" };
			FBU_B_frame_clamp_transfer_timer = new BeckhoffFloat(this.GetFBU_B_frame_clamp_transfer_timer, client, 16448, 2004104){ Name = "FBU_B_frame_clamp_transfer_timer" };
			UL_F_transfer_speed = new BeckhoffFloat(this.GetUL_F_transfer_speed, client, 16448, 2004108){ Name = "UL_F_transfer_speed" };
			Unload_feeder_speed_Fast = new BeckhoffFloat(this.GetUnload_feeder_speed_Fast, client, 16448, 2004112){ Name = "Unload_feeder_speed_Fast" };
			Unload_feeder_speed_Slow = new BeckhoffFloat(this.GetUnload_feeder_speed_Slow, client, 16448, 2004116){ Name = "Unload_feeder_speed_Slow" };
			UL_F_grip_speed_Fast = new BeckhoffFloat(this.GetUL_F_grip_speed_Fast, client, 16448, 2004120){ Name = "UL_F_grip_speed_Fast" };
			UL_F_grip_speed_Slow = new BeckhoffFloat(this.GetUL_F_grip_speed_Slow, client, 16448, 2004124){ Name = "UL_F_grip_speed_Slow" };
			LAF_transfer_timer = new BeckhoffFloat(this.GetLAF_transfer_timer, client, 16448, 2004128){ Name = "LAF_transfer_timer" };
			Frame_push_out_pos = new BeckhoffFloat(this.GetFrame_push_out_pos, client, 16448, 2004132){ Name = "Frame_push_out_pos" };
			Frame_unload_speed = new BeckhoffFloat(this.GetFrame_unload_speed, client, 16448, 2004136){ Name = "Frame_unload_speed" };
			Frame_overload_return_speed = new BeckhoffFloat(this.GetFrame_overload_return_speed, client, 16448, 2004140){ Name = "Frame_overload_return_speed" };
			Frame_unload_pitch = new BeckhoffFloat(this.GetFrame_unload_pitch, client, 16448, 2004144){ Name = "Frame_unload_pitch" };
			Frame_unload_speed_change_pos = new BeckhoffFloat(this.GetFrame_unload_speed_change_pos, client, 16448, 2004148){ Name = "Frame_unload_speed_change_pos" };
			Strip_insert_speed1 = new BeckhoffFloat(this.GetStrip_insert_speed1, client, 16448, 2004152){ Name = "Strip_insert_speed1" };
			Strip_insert_speed2 = new BeckhoffFloat(this.GetStrip_insert_speed2, client, 16448, 2004156){ Name = "Strip_insert_speed2" };
			Frame_unload_timer = new BeckhoffFloat(this.GetFrame_unload_timer, client, 16448, 2004160){ Name = "Frame_unload_timer" };
			Frame_unload_jam_detection = new BeckhoffBool(this.GetFrame_unload_jam_detection, client, 16448, 2004164){ Name = "Frame_unload_jam_detection" };
			IMH_Magazine_flow_direction = new BeckhoffBool(this.GetIMH_Magazine_flow_direction, client, 16448, 2004165){ Name = "IMH_Magazine_flow_direction" };
			G_Clean_Row_Num = new BeckhoffShort(this.GetG_Clean_Row_Num, client, 16448, 2004166){ Name = "G_Clean_Row_Num" };
			Cure_I_F_Time_out1 = new BeckhoffFloat(this.GetCure_I_F_Time_out1, client, 16448, 2004168){ Name = "Cure_I_F_Time_out1" };
			Cure_I_F_Time_out2 = new BeckhoffFloat(this.GetCure_I_F_Time_out2, client, 16448, 2004172){ Name = "Cure_I_F_Time_out2" };
			G_FIG_XM_TO_Sensor_Pos = new BeckhoffFloat(this.GetG_FIG_XM_TO_Sensor_Pos, client, 16448, 2004176){ Name = "G_FIG_XM_TO_Sensor_Pos" };
			G_FIG_XM_TO_Preform_Pos = new BeckhoffFloat(this.GetG_FIG_XM_TO_Preform_Pos, client, 16448, 2004180){ Name = "G_FIG_XM_TO_Preform_Pos" };
			G_FIG_CM_TO_Preform_Pos = new BeckhoffFloat(this.GetG_FIG_CM_TO_Preform_Pos, client, 16448, 2004184){ Name = "G_FIG_CM_TO_Preform_Pos" };
			G_FIG_TO_FCU_Row_Num = new BeckhoffShort(this.GetG_FIG_TO_FCU_Row_Num, client, 16448, 2004188){ Name = "G_FIG_TO_FCU_Row_Num" };
			G_FCU_Row_Num = new BeckhoffShort(this.GetG_FCU_Row_Num, client, 16448, 2004190){ Name = "G_FCU_Row_Num" };
			G_FCU_TO_FBU_Row_Num = new BeckhoffShort(this.GetG_FCU_TO_FBU_Row_Num, client, 16448, 2004192){ Name = "G_FCU_TO_FBU_Row_Num" };
			G_FBU_Row_Num = new BeckhoffShort(this.GetG_FBU_Row_Num, client, 16448, 2004194){ Name = "G_FBU_Row_Num" };
			G_Clean_Base_MaxRow = new BeckhoffShort(this.GetG_Clean_Base_MaxRow, client, 16448, 2004196){ Name = "G_Clean_Base_MaxRow" };
			G_Clean_MoveBase_Num = new BeckhoffShort(this.GetG_Clean_MoveBase_Num, client, 16448, 2004198){ Name = "G_Clean_MoveBase_Num" };
			G_Bonding_MaxRow = new BeckhoffShort(this.GetG_Bonding_MaxRow, client, 16448, 2004200){ Name = "G_Bonding_MaxRow" };
			G_Bonded_Num = new BeckhoffShort(this.GetG_Bonded_Num, client, 16448, 2004202){ Name = "G_Bonded_Num" };
			IMH_ZM_speed_Fast = new BeckhoffFloat(this.GetIMH_ZM_speed_Fast, client, 16448, 2004204){ Name = "IMH_ZM_speed_Fast" };
			IMH_ZM_speed_Slow = new BeckhoffFloat(this.GetIMH_ZM_speed_Slow, client, 16448, 2004208){ Name = "IMH_ZM_speed_Slow" };
			IMH_YM_speed_Fast = new BeckhoffFloat(this.GetIMH_YM_speed_Fast, client, 16448, 2004212){ Name = "IMH_YM_speed_Fast" };
			IMH_YM_speed_Slow = new BeckhoffFloat(this.GetIMH_YM_speed_Slow, client, 16448, 2004216){ Name = "IMH_YM_speed_Slow" };
			IMH_YC_response_time = new BeckhoffFloat(this.GetIMH_YC_response_time, client, 16448, 2004220){ Name = "IMH_YC_response_time" };
			IMH_ZC_response_time = new BeckhoffFloat(this.GetIMH_ZC_response_time, client, 16448, 2004224){ Name = "IMH_ZC_response_time" };
			IMH_Magazine_transfer_speed = new BeckhoffBool(this.GetIMH_Magazine_transfer_speed, client, 16448, 2004228){ Name = "IMH_Magazine_transfer_speed" };
			IMH_MGZ_Load_Flow_DIR = new BeckhoffBool(this.GetIMH_MGZ_Load_Flow_DIR, client, 16448, 2004229){ Name = "IMH_MGZ_Load_Flow_DIR" };
			IMH_MGZ_Transfer_Speed = new BeckhoffBool(this.GetIMH_MGZ_Transfer_Speed, client, 16448, 2004230){ Name = "IMH_MGZ_Transfer_Speed" };
			OMH_Magazine_flow_direction = new BeckhoffBool(this.GetOMH_Magazine_flow_direction, client, 16448, 2004231){ Name = "OMH_Magazine_flow_direction" };
			IMH_Frame_Pusher_Push_Speed = new BeckhoffFloat(this.GetIMH_Frame_Pusher_Push_Speed, client, 16448, 2004232){ Name = "IMH_Frame_Pusher_Push_Speed" };
			IMH_Frame_Pusher_Return_Speed = new BeckhoffFloat(this.GetIMH_Frame_Pusher_Return_Speed, client, 16448, 2004236){ Name = "IMH_Frame_Pusher_Return_Speed" };
			IMH_Side_Clamp_Response_Time = new BeckhoffFloat(this.GetIMH_Side_Clamp_Response_Time, client, 16448, 2004240){ Name = "IMH_Side_Clamp_Response_Time" };
			OMH_ZM_speed_Fast = new BeckhoffFloat(this.GetOMH_ZM_speed_Fast, client, 16448, 2004244){ Name = "OMH_ZM_speed_Fast" };
			OMH_ZM_speed_Slow = new BeckhoffFloat(this.GetOMH_ZM_speed_Slow, client, 16448, 2004248){ Name = "OMH_ZM_speed_Slow" };
			OMH_YM_speed_Fast = new BeckhoffFloat(this.GetOMH_YM_speed_Fast, client, 16448, 2004252){ Name = "OMH_YM_speed_Fast" };
			OMH_YM_speed_Slow = new BeckhoffFloat(this.GetOMH_YM_speed_Slow, client, 16448, 2004256){ Name = "OMH_YM_speed_Slow" };
			OMH_ZC_response_time = new BeckhoffFloat(this.GetOMH_ZC_response_time, client, 16448, 2004260){ Name = "OMH_ZC_response_time" };
			OMH_YC_response_time = new BeckhoffFloat(this.GetOMH_YC_response_time, client, 16448, 2004264){ Name = "OMH_YC_response_time" };
			OMH_Magazine_transfer_speed = new BeckhoffBool(this.GetOMH_Magazine_transfer_speed, client, 16448, 2004268){ Name = "OMH_Magazine_transfer_speed" };
			OMH_MGZ_Load_Flow_DIR = new BeckhoffBool(this.GetOMH_MGZ_Load_Flow_DIR, client, 16448, 2004269){ Name = "OMH_MGZ_Load_Flow_DIR" };
			OMH_MGZ_Transfer_Speed = new BeckhoffBool(this.GetOMH_MGZ_Transfer_Speed, client, 16448, 2004270){ Name = "OMH_MGZ_Transfer_Speed" };
			OMH_Side_Clamp_Response_Time = new BeckhoffFloat(this.GetOMH_Side_Clamp_Response_Time, client, 16448, 2004272){ Name = "OMH_Side_Clamp_Response_Time" };
			G_BasePitch_EveryRow = new BeckhoffShort(this.GetG_BasePitch_EveryRow, client, 16448, 2004276){ Name = "G_BasePitch_EveryRow" };
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
		~GVL_Recipe_TransferSettingWrapper()
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
