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
	/// Name from PLC:GVL_Recipe_TransferMaterial
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_Recipe_TransferMaterialWrapper
	{

		/// <summary>
		/// Name from PLC:Detection_mode
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003687)
		/// Size: 1
		public IBaseData<bool> Detection_mode { get; }
		internal bool ref_Detection_mode = new bool();

		/// <summary>
		/// Name from PLC:Frame_length
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003688)
		/// Size: 4
		public IBaseData<float> Frame_length { get; }
		internal float ref_Frame_length = new float();

		/// <summary>
		/// Name from PLC:Frame_width
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003692)
		/// Size: 4
		public IBaseData<float> Frame_width { get; }
		internal float ref_Frame_width = new float();

		/// <summary>
		/// Name from PLC:Frame_thickness
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003696)
		/// Size: 4
		public IBaseData<float> Frame_thickness { get; }
		internal float ref_Frame_thickness = new float();

		/// <summary>
		/// Name from PLC:No_of_blocks
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003700)
		/// Size: 4
		public IBaseData<float> No_of_blocks { get; }
		internal float ref_No_of_blocks = new float();

		/// <summary>
		/// Name from PLC:Block_pitch
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003704)
		/// Size: 4
		public IBaseData<float> Block_pitch { get; }
		internal float ref_Block_pitch = new float();

		/// <summary>
		/// Name from PLC:No_of_column_X
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003708)
		/// Size: 4
		public IBaseData<float> No_of_column_X { get; }
		internal float ref_No_of_column_X = new float();

		/// <summary>
		/// Name from PLC:Column_X_pitch
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003712)
		/// Size: 4
		public IBaseData<float> Column_X_pitch { get; }
		internal float ref_Column_X_pitch = new float();

		/// <summary>
		/// Name from PLC:No_of_Row_Y
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003716)
		/// Size: 4
		public IBaseData<float> No_of_Row_Y { get; }
		internal float ref_No_of_Row_Y = new float();

		/// <summary>
		/// Name from PLC:Row_Y_pitch
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003720)
		/// Size: 4
		public IBaseData<float> Row_Y_pitch { get; }
		internal float ref_Row_Y_pitch = new float();

		/// <summary>
		/// Name from PLC:First_Column_X_Pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003724)
		/// Size: 4
		public IBaseData<float> First_Column_X_Pos { get; }
		internal float ref_First_Column_X_Pos = new float();

		/// <summary>
		/// Name from PLC:Frame_head_detection_offset
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003728)
		/// Size: 4
		public IBaseData<float> Frame_head_detection_offset { get; }
		internal float ref_Frame_head_detection_offset = new float();

		/// <summary>
		/// Name from PLC:FRM_head_Det_offset_at_LA
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003732)
		/// Size: 4
		public IBaseData<float> FRM_head_Det_offset_at_LA { get; }
		internal float ref_FRM_head_Det_offset_at_LA = new float();

		/// <summary>
		/// Name from PLC:Row_Y_offset
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003736)
		/// Size: 4
		public IBaseData<float> Row_Y_offset { get; }
		internal float ref_Row_Y_offset = new float();

		/// <summary>
		/// Name from PLC:Block_length
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003740)
		/// Size: 4
		public IBaseData<float> Block_length { get; }
		internal float ref_Block_length = new float();

		/// <summary>
		/// Name from PLC:First_block_width
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003744)
		/// Size: 4
		public IBaseData<float> First_block_width { get; }
		internal float ref_First_block_width = new float();

		/// <summary>
		/// Name from PLC:No_of_Block_Y
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003748)
		/// Size: 4
		public IBaseData<float> No_of_Block_Y { get; }
		internal float ref_No_of_Block_Y = new float();

		/// <summary>
		/// Name from PLC:Block_Y_pitch1
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003752)
		/// Size: 4
		public IBaseData<float> Block_Y_pitch1 { get; }
		internal float ref_Block_Y_pitch1 = new float();

		/// <summary>
		/// Name from PLC:Block_Y_pitch2
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003756)
		/// Size: 4
		public IBaseData<float> Block_Y_pitch2 { get; }
		internal float ref_Block_Y_pitch2 = new float();

		/// <summary>
		/// Name from PLC:Block_Y_pitch3
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003760)
		/// Size: 4
		public IBaseData<float> Block_Y_pitch3 { get; }
		internal float ref_Block_Y_pitch3 = new float();

		/// <summary>
		/// Name from PLC:Block_Y_pitch4
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003764)
		/// Size: 4
		public IBaseData<float> Block_Y_pitch4 { get; }
		internal float ref_Block_Y_pitch4 = new float();

		/// <summary>
		/// Name from PLC:Block_Y_pitch5
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003768)
		/// Size: 4
		public IBaseData<float> Block_Y_pitch5 { get; }
		internal float ref_Block_Y_pitch5 = new float();

		/// <summary>
		/// Name from PLC:No_of_detection_pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003772)
		/// Size: 4
		public IBaseData<float> No_of_detection_pos { get; }
		internal float ref_No_of_detection_pos = new float();

		/// <summary>
		/// Name from PLC:Detection_position_1
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003776)
		/// Size: 4
		public IBaseData<float> Detection_position_1 { get; }
		internal float ref_Detection_position_1 = new float();

		/// <summary>
		/// Name from PLC:Detection_logic_1
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003780)
		/// Size: 1
		public IBaseData<bool> Detection_logic_1 { get; }
		internal bool ref_Detection_logic_1 = new bool();

		/// <summary>
		/// Name from PLC:Detection_logic_3
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003781)
		/// Size: 1
		public IBaseData<bool> Detection_logic_3 { get; }
		internal bool ref_Detection_logic_3 = new bool();

		/// <summary>
		/// Name from PLC:Detection_logic_4
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003782)
		/// Size: 1
		public IBaseData<bool> Detection_logic_4 { get; }
		internal bool ref_Detection_logic_4 = new bool();

		/// <summary>
		/// Name from PLC:Input_media_type
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003783)
		/// Size: 1
		public IBaseData<bool> Input_media_type { get; }
		internal bool ref_Input_media_type = new bool();

		/// <summary>
		/// Name from PLC:Detection_pos_tolerance_1
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003784)
		/// Size: 4
		public IBaseData<float> Detection_pos_tolerance_1 { get; }
		internal float ref_Detection_pos_tolerance_1 = new float();

		/// <summary>
		/// Name from PLC:Detection_position_2
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003788)
		/// Size: 4
		public IBaseData<float> Detection_position_2 { get; }
		internal float ref_Detection_position_2 = new float();

		/// <summary>
		/// Name from PLC:Detection_logic_2_
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003792)
		/// Size: 4
		public IBaseData<float> Detection_logic_2_ { get; }
		internal float ref_Detection_logic_2_ = new float();

		/// <summary>
		/// Name from PLC:Detection_pos_tolerance_2
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003796)
		/// Size: 4
		public IBaseData<float> Detection_pos_tolerance_2 { get; }
		internal float ref_Detection_pos_tolerance_2 = new float();

		/// <summary>
		/// Name from PLC:Detection_position_3
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003800)
		/// Size: 4
		public IBaseData<float> Detection_position_3 { get; }
		internal float ref_Detection_position_3 = new float();

		/// <summary>
		/// Name from PLC:Detection_pos_tolerance_3
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003804)
		/// Size: 4
		public IBaseData<float> Detection_pos_tolerance_3 { get; }
		internal float ref_Detection_pos_tolerance_3 = new float();

		/// <summary>
		/// Name from PLC:Detection_position_4
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003808)
		/// Size: 4
		public IBaseData<float> Detection_position_4 { get; }
		internal float ref_Detection_position_4 = new float();

		/// <summary>
		/// Name from PLC:Detection_pos_tolerance_4
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003812)
		/// Size: 4
		public IBaseData<float> Detection_pos_tolerance_4 { get; }
		internal float ref_Detection_pos_tolerance_4 = new float();

		/// <summary>
		/// Name from PLC:IMH_Magazine_Lowest_Slot_Height
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003816)
		/// Size: 4
		public IBaseData<float> IMH_Magazine_Lowest_Slot_Height { get; }
		internal float ref_IMH_Magazine_Lowest_Slot_Height = new float();

		/// <summary>
		/// Name from PLC:IMH_Magazine_Width
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003820)
		/// Size: 4
		public IBaseData<float> IMH_Magazine_Width { get; }
		internal float ref_IMH_Magazine_Width = new float();

		/// <summary>
		/// Name from PLC:IMH_Num_Of_Slots
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2003824)
		/// Size: 2
		public IBaseData<short> IMH_Num_Of_Slots { get; }
		internal short ref_IMH_Num_Of_Slots = new short();

		/// <summary>
		/// Name from PLC:OMH_Num_Of_Slots
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2003826)
		/// Size: 2
		public IBaseData<short> OMH_Num_Of_Slots { get; }
		internal short ref_OMH_Num_Of_Slots = new short();

		/// <summary>
		/// Name from PLC:IMH_Slot_Pitch
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003828)
		/// Size: 4
		public IBaseData<float> IMH_Slot_Pitch { get; }
		internal float ref_IMH_Slot_Pitch = new float();

		/// <summary>
		/// Name from PLC:OMH_Magazine_Lowest_Slot_Height
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003832)
		/// Size: 4
		public IBaseData<float> OMH_Magazine_Lowest_Slot_Height { get; }
		internal float ref_OMH_Magazine_Lowest_Slot_Height = new float();

		/// <summary>
		/// Name from PLC:OMH_Magazine_Width
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003836)
		/// Size: 4
		public IBaseData<float> OMH_Magazine_Width { get; }
		internal float ref_OMH_Magazine_Width = new float();

		/// <summary>
		/// Name from PLC:OMH_Slot_Pitch
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003840)
		/// Size: 4
		public IBaseData<float> OMH_Slot_Pitch { get; }
		internal float ref_OMH_Slot_Pitch = new float();

		/// <summary>
		/// Name from PLC:Frame_map
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003844)
		/// Size: 1
		public IBaseData<bool> Frame_map { get; }
		internal bool ref_Frame_map = new bool();

		/// <summary>
		/// Name from PLC:Preform_stage_vacuum
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003845)
		/// Size: 1
		public IBaseData<bool> Preform_stage_vacuum { get; }
		internal bool ref_Preform_stage_vacuum = new bool();

		/// <summary>
		/// Name from PLC:Bonding_stage_vacuum
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003846)
		/// Size: 1
		public IBaseData<bool> Bonding_stage_vacuum { get; }
		internal bool ref_Bonding_stage_vacuum = new bool();

		/// <summary>
		/// Name from PLC:P_gripper_escape
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003847)
		/// Size: 1
		public IBaseData<bool> P_gripper_escape { get; }
		internal bool ref_P_gripper_escape = new bool();

		/// <summary>
		/// Name from PLC:B_gripper_escape
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003848)
		/// Size: 1
		public IBaseData<bool> B_gripper_escape { get; }
		internal bool ref_B_gripper_escape = new bool();

		/// <summary>
		/// Name from PLC:P_frame_grip_during
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003849)
		/// Size: 1
		public IBaseData<bool> P_frame_grip_during { get; }
		internal bool ref_P_frame_grip_during = new bool();

		/// <summary>
		/// Name from PLC:B_frame_grip_during
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003850)
		/// Size: 1
		public IBaseData<bool> B_frame_grip_during { get; }
		internal bool ref_B_frame_grip_during = new bool();

		/// <summary>
		/// Name from PLC:P_frame_clamp_during
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003851)
		/// Size: 1
		public IBaseData<bool> P_frame_clamp_during { get; }
		internal bool ref_P_frame_clamp_during = new bool();

		/// <summary>
		/// Name from PLC:B_frame_clamp_during
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003852)
		/// Size: 1
		public IBaseData<bool> B_frame_clamp_during { get; }
		internal bool ref_B_frame_clamp_during = new bool();

		/// <summary>
		/// Name from PLC:Cure_action
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003853)
		/// Size: 1
		public IBaseData<bool> Cure_action { get; }
		internal bool ref_Cure_action = new bool();

		/// <summary>
		/// Name from PLC:B_frame_feed_shift_check
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003854)
		/// Size: 1
		public IBaseData<bool> B_frame_feed_shift_check { get; }
		internal bool ref_B_frame_feed_shift_check = new bool();

		/// <summary>
		/// Name from PLC:Frame_hold_change_Hi_speed_Disable
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003855)
		/// Size: 1
		public IBaseData<bool> Frame_hold_change_Hi_speed_Disable { get; }
		internal bool ref_Frame_hold_change_Hi_speed_Disable = new bool();

		/// <summary>
		/// Name from PLC:Loader_conveyer_unit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003856)
		/// Size: 4
		public IBaseData<float> Loader_conveyer_unit { get; }
		internal float ref_Loader_conveyer_unit = new float();

		/// <summary>
		/// Name from PLC:Unloader_conveyer_unit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003860)
		/// Size: 4
		public IBaseData<float> Unloader_conveyer_unit { get; }
		internal float ref_Unloader_conveyer_unit = new float();

		/// <summary>
		/// Name from PLC:PS_Vac_Sens_upper_limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003864)
		/// Size: 4
		public IBaseData<float> PS_Vac_Sens_upper_limit { get; }
		internal float ref_PS_Vac_Sens_upper_limit = new float();

		/// <summary>
		/// Name from PLC:PS_Vac_Sens_lower_limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003868)
		/// Size: 4
		public IBaseData<float> PS_Vac_Sens_lower_limit { get; }
		internal float ref_PS_Vac_Sens_lower_limit = new float();

		/// <summary>
		/// Name from PLC:BS_Vac_Sens_upper_limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003872)
		/// Size: 4
		public IBaseData<float> BS_Vac_Sens_upper_limit { get; }
		internal float ref_BS_Vac_Sens_upper_limit = new float();

		/// <summary>
		/// Name from PLC:BS_Vac_Sens_lower_limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003876)
		/// Size: 4
		public IBaseData<float> BS_Vac_Sens_lower_limit { get; }
		internal float ref_BS_Vac_Sens_lower_limit = new float();

		/// <summary>
		/// Name from PLC:B_frame_feed_shift_tolerance_X
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003880)
		/// Size: 4
		public IBaseData<float> B_frame_feed_shift_tolerance_X { get; }
		internal float ref_B_frame_feed_shift_tolerance_X = new float();

		/// <summary>
		/// Name from PLC:B_frame_feed_shift_tolerance_Y
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2003884)
		/// Size: 4
		public IBaseData<float> B_frame_feed_shift_tolerance_Y { get; }
		internal float ref_B_frame_feed_shift_tolerance_Y = new float();

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
