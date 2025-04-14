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
	/// Name from PLC:GVL_Recipe_TransferMaterial
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_Recipe_TransferMaterialWrapper : BaseData, IBaseData
	{
		public override IEnumerable<IBaseData> Children
		{
			get
			{
				yield return Detection_mode;
				yield return Frame_length;
				yield return Frame_width;
				yield return Frame_thickness;
				yield return No_of_blocks;
				yield return Block_pitch;
				yield return No_of_column_X;
				yield return Column_X_pitch;
				yield return No_of_Row_Y;
				yield return Row_Y_pitch;
				yield return First_Column_X_Pos;
				yield return Frame_head_detection_offset;
				yield return FRM_head_Det_offset_at_LA;
				yield return Row_Y_offset;
				yield return Block_length;
				yield return First_block_width;
				yield return No_of_Block_Y;
				yield return Block_Y_pitch1;
				yield return Block_Y_pitch2;
				yield return Block_Y_pitch3;
				yield return Block_Y_pitch4;
				yield return Block_Y_pitch5;
				yield return No_of_detection_pos;
				yield return Detection_position_1;
				yield return Detection_logic_1;
				yield return Detection_logic_3;
				yield return Detection_logic_4;
				yield return Input_media_type;
				yield return Detection_pos_tolerance_1;
				yield return Detection_position_2;
				yield return Detection_logic_2_;
				yield return Detection_pos_tolerance_2;
				yield return Detection_position_3;
				yield return Detection_pos_tolerance_3;
				yield return Detection_position_4;
				yield return Detection_pos_tolerance_4;
				yield return IMH_Magazine_Lowest_Slot_Height;
				yield return IMH_Magazine_Width;
				yield return IMH_Num_Of_Slots;
				yield return OMH_Num_Of_Slots;
				yield return IMH_Slot_Pitch;
				yield return OMH_Magazine_Lowest_Slot_Height;
				yield return OMH_Magazine_Width;
				yield return OMH_Slot_Pitch;
				yield return Frame_map;
				yield return Preform_stage_vacuum;
				yield return Bonding_stage_vacuum;
				yield return P_gripper_escape;
				yield return B_gripper_escape;
				yield return P_frame_grip_during;
				yield return B_frame_grip_during;
				yield return P_frame_clamp_during;
				yield return B_frame_clamp_during;
				yield return Cure_action;
				yield return B_frame_feed_shift_check;
				yield return Frame_hold_change_Hi_speed_Disable;
				yield return Loader_conveyer_unit;
				yield return Unloader_conveyer_unit;
				yield return PS_Vac_Sens_upper_limit;
				yield return PS_Vac_Sens_lower_limit;
				yield return BS_Vac_Sens_upper_limit;
				yield return BS_Vac_Sens_lower_limit;
				yield return B_frame_feed_shift_tolerance_X;
				yield return B_frame_feed_shift_tolerance_Y;
			}
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Detection_mode):
					return Detection_mode;
				case nameof(Frame_length):
					return Frame_length;
				case nameof(Frame_width):
					return Frame_width;
				case nameof(Frame_thickness):
					return Frame_thickness;
				case nameof(No_of_blocks):
					return No_of_blocks;
				case nameof(Block_pitch):
					return Block_pitch;
				case nameof(No_of_column_X):
					return No_of_column_X;
				case nameof(Column_X_pitch):
					return Column_X_pitch;
				case nameof(No_of_Row_Y):
					return No_of_Row_Y;
				case nameof(Row_Y_pitch):
					return Row_Y_pitch;
				case nameof(First_Column_X_Pos):
					return First_Column_X_Pos;
				case nameof(Frame_head_detection_offset):
					return Frame_head_detection_offset;
				case nameof(FRM_head_Det_offset_at_LA):
					return FRM_head_Det_offset_at_LA;
				case nameof(Row_Y_offset):
					return Row_Y_offset;
				case nameof(Block_length):
					return Block_length;
				case nameof(First_block_width):
					return First_block_width;
				case nameof(No_of_Block_Y):
					return No_of_Block_Y;
				case nameof(Block_Y_pitch1):
					return Block_Y_pitch1;
				case nameof(Block_Y_pitch2):
					return Block_Y_pitch2;
				case nameof(Block_Y_pitch3):
					return Block_Y_pitch3;
				case nameof(Block_Y_pitch4):
					return Block_Y_pitch4;
				case nameof(Block_Y_pitch5):
					return Block_Y_pitch5;
				case nameof(No_of_detection_pos):
					return No_of_detection_pos;
				case nameof(Detection_position_1):
					return Detection_position_1;
				case nameof(Detection_logic_1):
					return Detection_logic_1;
				case nameof(Detection_logic_3):
					return Detection_logic_3;
				case nameof(Detection_logic_4):
					return Detection_logic_4;
				case nameof(Input_media_type):
					return Input_media_type;
				case nameof(Detection_pos_tolerance_1):
					return Detection_pos_tolerance_1;
				case nameof(Detection_position_2):
					return Detection_position_2;
				case nameof(Detection_logic_2_):
					return Detection_logic_2_;
				case nameof(Detection_pos_tolerance_2):
					return Detection_pos_tolerance_2;
				case nameof(Detection_position_3):
					return Detection_position_3;
				case nameof(Detection_pos_tolerance_3):
					return Detection_pos_tolerance_3;
				case nameof(Detection_position_4):
					return Detection_position_4;
				case nameof(Detection_pos_tolerance_4):
					return Detection_pos_tolerance_4;
				case nameof(IMH_Magazine_Lowest_Slot_Height):
					return IMH_Magazine_Lowest_Slot_Height;
				case nameof(IMH_Magazine_Width):
					return IMH_Magazine_Width;
				case nameof(IMH_Num_Of_Slots):
					return IMH_Num_Of_Slots;
				case nameof(OMH_Num_Of_Slots):
					return OMH_Num_Of_Slots;
				case nameof(IMH_Slot_Pitch):
					return IMH_Slot_Pitch;
				case nameof(OMH_Magazine_Lowest_Slot_Height):
					return OMH_Magazine_Lowest_Slot_Height;
				case nameof(OMH_Magazine_Width):
					return OMH_Magazine_Width;
				case nameof(OMH_Slot_Pitch):
					return OMH_Slot_Pitch;
				case nameof(Frame_map):
					return Frame_map;
				case nameof(Preform_stage_vacuum):
					return Preform_stage_vacuum;
				case nameof(Bonding_stage_vacuum):
					return Bonding_stage_vacuum;
				case nameof(P_gripper_escape):
					return P_gripper_escape;
				case nameof(B_gripper_escape):
					return B_gripper_escape;
				case nameof(P_frame_grip_during):
					return P_frame_grip_during;
				case nameof(B_frame_grip_during):
					return B_frame_grip_during;
				case nameof(P_frame_clamp_during):
					return P_frame_clamp_during;
				case nameof(B_frame_clamp_during):
					return B_frame_clamp_during;
				case nameof(Cure_action):
					return Cure_action;
				case nameof(B_frame_feed_shift_check):
					return B_frame_feed_shift_check;
				case nameof(Frame_hold_change_Hi_speed_Disable):
					return Frame_hold_change_Hi_speed_Disable;
				case nameof(Loader_conveyer_unit):
					return Loader_conveyer_unit;
				case nameof(Unloader_conveyer_unit):
					return Unloader_conveyer_unit;
				case nameof(PS_Vac_Sens_upper_limit):
					return PS_Vac_Sens_upper_limit;
				case nameof(PS_Vac_Sens_lower_limit):
					return PS_Vac_Sens_lower_limit;
				case nameof(BS_Vac_Sens_upper_limit):
					return BS_Vac_Sens_upper_limit;
				case nameof(BS_Vac_Sens_lower_limit):
					return BS_Vac_Sens_lower_limit;
				case nameof(B_frame_feed_shift_tolerance_X):
					return B_frame_feed_shift_tolerance_X;
				case nameof(B_frame_feed_shift_tolerance_Y):
					return B_frame_feed_shift_tolerance_Y;
			}
			throw new KeyNotFoundException(name);
		}

		private readonly AdsClient client;

		public GVL_Recipe_TransferMaterialWrapper(AdsClient client)
		{
			this.client = client;

			Detection_mode = new BeckhoffBool(this.GetDetection_mode, client, 16448, 2003687){ Name = "Detection_mode" };
			Frame_length = new BeckhoffFloat(this.GetFrame_length, client, 16448, 2003688){ Name = "Frame_length" };
			Frame_width = new BeckhoffFloat(this.GetFrame_width, client, 16448, 2003692){ Name = "Frame_width" };
			Frame_thickness = new BeckhoffFloat(this.GetFrame_thickness, client, 16448, 2003696){ Name = "Frame_thickness" };
			No_of_blocks = new BeckhoffFloat(this.GetNo_of_blocks, client, 16448, 2003700){ Name = "No_of_blocks" };
			Block_pitch = new BeckhoffFloat(this.GetBlock_pitch, client, 16448, 2003704){ Name = "Block_pitch" };
			No_of_column_X = new BeckhoffFloat(this.GetNo_of_column_X, client, 16448, 2003708){ Name = "No_of_column_X" };
			Column_X_pitch = new BeckhoffFloat(this.GetColumn_X_pitch, client, 16448, 2003712){ Name = "Column_X_pitch" };
			No_of_Row_Y = new BeckhoffFloat(this.GetNo_of_Row_Y, client, 16448, 2003716){ Name = "No_of_Row_Y" };
			Row_Y_pitch = new BeckhoffFloat(this.GetRow_Y_pitch, client, 16448, 2003720){ Name = "Row_Y_pitch" };
			First_Column_X_Pos = new BeckhoffFloat(this.GetFirst_Column_X_Pos, client, 16448, 2003724){ Name = "First_Column_X_Pos" };
			Frame_head_detection_offset = new BeckhoffFloat(this.GetFrame_head_detection_offset, client, 16448, 2003728){ Name = "Frame_head_detection_offset" };
			FRM_head_Det_offset_at_LA = new BeckhoffFloat(this.GetFRM_head_Det_offset_at_LA, client, 16448, 2003732){ Name = "FRM_head_Det_offset_at_LA" };
			Row_Y_offset = new BeckhoffFloat(this.GetRow_Y_offset, client, 16448, 2003736){ Name = "Row_Y_offset" };
			Block_length = new BeckhoffFloat(this.GetBlock_length, client, 16448, 2003740){ Name = "Block_length" };
			First_block_width = new BeckhoffFloat(this.GetFirst_block_width, client, 16448, 2003744){ Name = "First_block_width" };
			No_of_Block_Y = new BeckhoffFloat(this.GetNo_of_Block_Y, client, 16448, 2003748){ Name = "No_of_Block_Y" };
			Block_Y_pitch1 = new BeckhoffFloat(this.GetBlock_Y_pitch1, client, 16448, 2003752){ Name = "Block_Y_pitch1" };
			Block_Y_pitch2 = new BeckhoffFloat(this.GetBlock_Y_pitch2, client, 16448, 2003756){ Name = "Block_Y_pitch2" };
			Block_Y_pitch3 = new BeckhoffFloat(this.GetBlock_Y_pitch3, client, 16448, 2003760){ Name = "Block_Y_pitch3" };
			Block_Y_pitch4 = new BeckhoffFloat(this.GetBlock_Y_pitch4, client, 16448, 2003764){ Name = "Block_Y_pitch4" };
			Block_Y_pitch5 = new BeckhoffFloat(this.GetBlock_Y_pitch5, client, 16448, 2003768){ Name = "Block_Y_pitch5" };
			No_of_detection_pos = new BeckhoffFloat(this.GetNo_of_detection_pos, client, 16448, 2003772){ Name = "No_of_detection_pos" };
			Detection_position_1 = new BeckhoffFloat(this.GetDetection_position_1, client, 16448, 2003776){ Name = "Detection_position_1" };
			Detection_logic_1 = new BeckhoffBool(this.GetDetection_logic_1, client, 16448, 2003780){ Name = "Detection_logic_1" };
			Detection_logic_3 = new BeckhoffBool(this.GetDetection_logic_3, client, 16448, 2003781){ Name = "Detection_logic_3" };
			Detection_logic_4 = new BeckhoffBool(this.GetDetection_logic_4, client, 16448, 2003782){ Name = "Detection_logic_4" };
			Input_media_type = new BeckhoffBool(this.GetInput_media_type, client, 16448, 2003783){ Name = "Input_media_type" };
			Detection_pos_tolerance_1 = new BeckhoffFloat(this.GetDetection_pos_tolerance_1, client, 16448, 2003784){ Name = "Detection_pos_tolerance_1" };
			Detection_position_2 = new BeckhoffFloat(this.GetDetection_position_2, client, 16448, 2003788){ Name = "Detection_position_2" };
			Detection_logic_2_ = new BeckhoffFloat(this.GetDetection_logic_2_, client, 16448, 2003792){ Name = "Detection_logic_2_" };
			Detection_pos_tolerance_2 = new BeckhoffFloat(this.GetDetection_pos_tolerance_2, client, 16448, 2003796){ Name = "Detection_pos_tolerance_2" };
			Detection_position_3 = new BeckhoffFloat(this.GetDetection_position_3, client, 16448, 2003800){ Name = "Detection_position_3" };
			Detection_pos_tolerance_3 = new BeckhoffFloat(this.GetDetection_pos_tolerance_3, client, 16448, 2003804){ Name = "Detection_pos_tolerance_3" };
			Detection_position_4 = new BeckhoffFloat(this.GetDetection_position_4, client, 16448, 2003808){ Name = "Detection_position_4" };
			Detection_pos_tolerance_4 = new BeckhoffFloat(this.GetDetection_pos_tolerance_4, client, 16448, 2003812){ Name = "Detection_pos_tolerance_4" };
			IMH_Magazine_Lowest_Slot_Height = new BeckhoffFloat(this.GetIMH_Magazine_Lowest_Slot_Height, client, 16448, 2003816){ Name = "IMH_Magazine_Lowest_Slot_Height" };
			IMH_Magazine_Width = new BeckhoffFloat(this.GetIMH_Magazine_Width, client, 16448, 2003820){ Name = "IMH_Magazine_Width" };
			IMH_Num_Of_Slots = new BeckhoffShort(this.GetIMH_Num_Of_Slots, client, 16448, 2003824){ Name = "IMH_Num_Of_Slots" };
			OMH_Num_Of_Slots = new BeckhoffShort(this.GetOMH_Num_Of_Slots, client, 16448, 2003826){ Name = "OMH_Num_Of_Slots" };
			IMH_Slot_Pitch = new BeckhoffFloat(this.GetIMH_Slot_Pitch, client, 16448, 2003828){ Name = "IMH_Slot_Pitch" };
			OMH_Magazine_Lowest_Slot_Height = new BeckhoffFloat(this.GetOMH_Magazine_Lowest_Slot_Height, client, 16448, 2003832){ Name = "OMH_Magazine_Lowest_Slot_Height" };
			OMH_Magazine_Width = new BeckhoffFloat(this.GetOMH_Magazine_Width, client, 16448, 2003836){ Name = "OMH_Magazine_Width" };
			OMH_Slot_Pitch = new BeckhoffFloat(this.GetOMH_Slot_Pitch, client, 16448, 2003840){ Name = "OMH_Slot_Pitch" };
			Frame_map = new BeckhoffBool(this.GetFrame_map, client, 16448, 2003844){ Name = "Frame_map" };
			Preform_stage_vacuum = new BeckhoffBool(this.GetPreform_stage_vacuum, client, 16448, 2003845){ Name = "Preform_stage_vacuum" };
			Bonding_stage_vacuum = new BeckhoffBool(this.GetBonding_stage_vacuum, client, 16448, 2003846){ Name = "Bonding_stage_vacuum" };
			P_gripper_escape = new BeckhoffBool(this.GetP_gripper_escape, client, 16448, 2003847){ Name = "P_gripper_escape" };
			B_gripper_escape = new BeckhoffBool(this.GetB_gripper_escape, client, 16448, 2003848){ Name = "B_gripper_escape" };
			P_frame_grip_during = new BeckhoffBool(this.GetP_frame_grip_during, client, 16448, 2003849){ Name = "P_frame_grip_during" };
			B_frame_grip_during = new BeckhoffBool(this.GetB_frame_grip_during, client, 16448, 2003850){ Name = "B_frame_grip_during" };
			P_frame_clamp_during = new BeckhoffBool(this.GetP_frame_clamp_during, client, 16448, 2003851){ Name = "P_frame_clamp_during" };
			B_frame_clamp_during = new BeckhoffBool(this.GetB_frame_clamp_during, client, 16448, 2003852){ Name = "B_frame_clamp_during" };
			Cure_action = new BeckhoffBool(this.GetCure_action, client, 16448, 2003853){ Name = "Cure_action" };
			B_frame_feed_shift_check = new BeckhoffBool(this.GetB_frame_feed_shift_check, client, 16448, 2003854){ Name = "B_frame_feed_shift_check" };
			Frame_hold_change_Hi_speed_Disable = new BeckhoffBool(this.GetFrame_hold_change_Hi_speed_Disable, client, 16448, 2003855){ Name = "Frame_hold_change_Hi_speed_Disable" };
			Loader_conveyer_unit = new BeckhoffFloat(this.GetLoader_conveyer_unit, client, 16448, 2003856){ Name = "Loader_conveyer_unit" };
			Unloader_conveyer_unit = new BeckhoffFloat(this.GetUnloader_conveyer_unit, client, 16448, 2003860){ Name = "Unloader_conveyer_unit" };
			PS_Vac_Sens_upper_limit = new BeckhoffFloat(this.GetPS_Vac_Sens_upper_limit, client, 16448, 2003864){ Name = "PS_Vac_Sens_upper_limit" };
			PS_Vac_Sens_lower_limit = new BeckhoffFloat(this.GetPS_Vac_Sens_lower_limit, client, 16448, 2003868){ Name = "PS_Vac_Sens_lower_limit" };
			BS_Vac_Sens_upper_limit = new BeckhoffFloat(this.GetBS_Vac_Sens_upper_limit, client, 16448, 2003872){ Name = "BS_Vac_Sens_upper_limit" };
			BS_Vac_Sens_lower_limit = new BeckhoffFloat(this.GetBS_Vac_Sens_lower_limit, client, 16448, 2003876){ Name = "BS_Vac_Sens_lower_limit" };
			B_frame_feed_shift_tolerance_X = new BeckhoffFloat(this.GetB_frame_feed_shift_tolerance_X, client, 16448, 2003880){ Name = "B_frame_feed_shift_tolerance_X" };
			B_frame_feed_shift_tolerance_Y = new BeckhoffFloat(this.GetB_frame_feed_shift_tolerance_Y, client, 16448, 2003884){ Name = "B_frame_feed_shift_tolerance_Y" };
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
		~GVL_Recipe_TransferMaterialWrapper()
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
