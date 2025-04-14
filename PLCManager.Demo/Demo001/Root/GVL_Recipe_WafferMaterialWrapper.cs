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
	/// Name from PLC:GVL_Recipe_WafferMaterial
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_Recipe_WafferMaterialWrapper
	{

		/// <summary>
		/// Name from PLC:Wafer_radius
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005536)
		/// Size: 4
		public IBaseData<float> Wafer_radius { get; }
		internal float ref_Wafer_radius = new float();

		/// <summary>
		/// Name from PLC:Wafer_ring_diameter
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005540)
		/// Size: 4
		public IBaseData<float> Wafer_ring_diameter { get; }
		internal float ref_Wafer_ring_diameter = new float();

		/// <summary>
		/// Name from PLC:Wafer_ring_thickness
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005544)
		/// Size: 4
		public IBaseData<float> Wafer_ring_thickness { get; }
		internal float ref_Wafer_ring_thickness = new float();

		/// <summary>
		/// Name from PLC:No_of_W_cassette_slots
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005548)
		/// Size: 4
		public IBaseData<float> No_of_W_cassette_slots { get; }
		internal float ref_No_of_W_cassette_slots = new float();

		/// <summary>
		/// Name from PLC:W_cassette_slot_pitch
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005552)
		/// Size: 4
		public IBaseData<float> W_cassette_slot_pitch { get; }
		internal float ref_W_cassette_slot_pitch = new float();

		/// <summary>
		/// Name from PLC:W_CST_bottom_slot_height
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005556)
		/// Size: 4
		public IBaseData<float> W_CST_bottom_slot_height { get; }
		internal float ref_W_CST_bottom_slot_height = new float();

		/// <summary>
		/// Name from PLC:No_of_W_cassette_stack
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005560)
		/// Size: 4
		public IBaseData<float> No_of_W_cassette_stack { get; }
		internal float ref_No_of_W_cassette_stack = new float();

		/// <summary>
		/// Name from PLC:W_cassette_height
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005564)
		/// Size: 4
		public IBaseData<float> W_cassette_height { get; }
		internal float ref_W_cassette_height = new float();

		/// <summary>
		/// Name from PLC:Wafer_tape_heat_temperature
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005568)
		/// Size: 4
		public IBaseData<float> Wafer_tape_heat_temperature { get; }
		internal float ref_Wafer_tape_heat_temperature = new float();

		/// <summary>
		/// Name from PLC:Wafer_Barcode_read
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005572)
		/// Size: 1
		public IBaseData<bool> Wafer_Barcode_read { get; }
		internal bool ref_Wafer_Barcode_read = new bool();

		/// <summary>
		/// Name from PLC:Order_of_wafer_load
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005573)
		/// Size: 1
		public IBaseData<bool> Order_of_wafer_load { get; }
		internal bool ref_Order_of_wafer_load = new bool();

		/// <summary>
		/// Name from PLC:Wafer_auto_unload
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005574)
		/// Size: 1
		public IBaseData<bool> Wafer_auto_unload { get; }
		internal bool ref_Wafer_auto_unload = new bool();

		/// <summary>
		/// Name from PLC:Wafer_tape_heat_temperature_range
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005576)
		/// Size: 4
		public IBaseData<float> Wafer_tape_heat_temperature_range { get; }
		internal float ref_Wafer_tape_heat_temperature_range = new float();

		/// <summary>
		/// Name from PLC:Wafer_tape_heat_temperature_offset
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005580)
		/// Size: 4
		public IBaseData<float> Wafer_tape_heat_temperature_offset { get; }
		internal float ref_Wafer_tape_heat_temperature_offset = new float();

		/// <summary>
		/// Name from PLC:Wafer_tape_heat_up_time
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005584)
		/// Size: 4
		public IBaseData<float> Wafer_tape_heat_up_time { get; }
		internal float ref_Wafer_tape_heat_up_time = new float();

		/// <summary>
		/// Name from PLC:Pre_expand_W_tape_heat_time
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005588)
		/// Size: 4
		public IBaseData<float> Pre_expand_W_tape_heat_time { get; }
		internal float ref_Pre_expand_W_tape_heat_time = new float();

		/// <summary>
		/// Name from PLC:Post_expand_W_tape_heat_time
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005592)
		/// Size: 4
		public IBaseData<float> Post_expand_W_tape_heat_time { get; }
		internal float ref_Post_expand_W_tape_heat_time = new float();

		/// <summary>
		/// Name from PLC:W_CST_height_at_wafer_unload
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005596)
		/// Size: 4
		public IBaseData<float> W_CST_height_at_wafer_unload { get; }
		internal float ref_W_CST_height_at_wafer_unload = new float();

		/// <summary>
		/// Name from PLC:W_CST_height_at_wafer_load
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005600)
		/// Size: 4
		public IBaseData<float> W_CST_height_at_wafer_load { get; }
		internal float ref_W_CST_height_at_wafer_load = new float();

		/// <summary>
		/// Name from PLC:W_CST_height_at_wafer_push
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005604)
		/// Size: 4
		public IBaseData<float> W_CST_height_at_wafer_push { get; }
		internal float ref_W_CST_height_at_wafer_push = new float();

		/// <summary>
		/// Name from PLC:W_CST_lifter_updown_speed_Fast
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005608)
		/// Size: 4
		public IBaseData<float> W_CST_lifter_updown_speed_Fast { get; }
		internal float ref_W_CST_lifter_updown_speed_Fast = new float();

		/// <summary>
		/// Name from PLC:W_cassette_change_height
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005612)
		/// Size: 4
		public IBaseData<float> W_cassette_change_height { get; }
		internal float ref_W_cassette_change_height = new float();

		/// <summary>
		/// Name from PLC:Slow_start_Pos_before_grip
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005616)
		/// Size: 4
		public IBaseData<float> Slow_start_Pos_before_grip { get; }
		internal float ref_Slow_start_Pos_before_grip = new float();

		/// <summary>
		/// Name from PLC:Slow_start_Pos_before_release
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005620)
		/// Size: 4
		public IBaseData<float> Slow_start_Pos_before_release { get; }
		internal float ref_Slow_start_Pos_before_release = new float();

		/// <summary>
		/// Name from PLC:Pre_push_position
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005624)
		/// Size: 4
		public IBaseData<float> Pre_push_position { get; }
		internal float ref_Pre_push_position = new float();

		/// <summary>
		/// Name from PLC:Extractor_speed_Fast
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005628)
		/// Size: 4
		public IBaseData<float> Extractor_speed_Fast { get; }
		internal float ref_Extractor_speed_Fast = new float();

		/// <summary>
		/// Name from PLC:Extractor_speed_Slow
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005632)
		/// Size: 4
		public IBaseData<float> Extractor_speed_Slow { get; }
		internal float ref_Extractor_speed_Slow = new float();

		/// <summary>
		/// Name from PLC:Extractor_slow_speed
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005636)
		/// Size: 4
		public IBaseData<float> Extractor_slow_speed { get; }
		internal float ref_Extractor_slow_speed = new float();

		/// <summary>
		/// Name from PLC:Pre_gripper_action_delay
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005640)
		/// Size: 4
		public IBaseData<float> Pre_gripper_action_delay { get; }
		internal float ref_Pre_gripper_action_delay = new float();

		/// <summary>
		/// Name from PLC:Griper_open_close_action_delay
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005644)
		/// Size: 4
		public IBaseData<float> Griper_open_close_action_delay { get; }
		internal float ref_Griper_open_close_action_delay = new float();

		/// <summary>
		/// Name from PLC:Regrip_distance
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005648)
		/// Size: 4
		public IBaseData<float> Regrip_distance { get; }
		internal float ref_Regrip_distance = new float();

		/// <summary>
		/// Name from PLC:Regrip_time
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005652)
		/// Size: 4
		public IBaseData<float> Regrip_time { get; }
		internal float ref_Regrip_time = new float();

		/// <summary>
		/// Name from PLC:Ring_position_offset_in_cassette
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005656)
		/// Size: 4
		public IBaseData<float> Ring_position_offset_in_cassette { get; }
		internal float ref_Ring_position_offset_in_cassette = new float();

		/// <summary>
		/// Name from PLC:Reversed_frame_Rec_mode
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005660)
		/// Size: 4
		public IBaseData<float> Reversed_frame_Rec_mode { get; }
		internal float ref_Reversed_frame_Rec_mode = new float();

		/// <summary>
		/// Name from PLC:Recognition_threshold
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005664)
		/// Size: 4
		public IBaseData<float> Recognition_threshold { get; }
		internal float ref_Recognition_threshold = new float();

		/// <summary>
		/// Name from PLC:Recognition_cutoff
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005668)
		/// Size: 4
		public IBaseData<float> Recognition_cutoff { get; }
		internal float ref_Recognition_cutoff = new float();

		/// <summary>
		/// Name from PLC:Pre_heat_temperature
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005672)
		/// Size: 4
		public IBaseData<float> Pre_heat_temperature { get; }
		internal float ref_Pre_heat_temperature = new float();

		/// <summary>
		/// Name from PLC:Pre_heat_temperature_limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005676)
		/// Size: 4
		public IBaseData<float> Pre_heat_temperature_limit { get; }
		internal float ref_Pre_heat_temperature_limit = new float();

		/// <summary>
		/// Name from PLC:Pre_heat_temperature_offset
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005680)
		/// Size: 4
		public IBaseData<float> Pre_heat_temperature_offset { get; }
		internal float ref_Pre_heat_temperature_offset = new float();

		/// <summary>
		/// Name from PLC:Pre_heat_over_time
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005684)
		/// Size: 4
		public IBaseData<float> Pre_heat_over_time { get; }
		internal float ref_Pre_heat_over_time = new float();

		/// <summary>
		/// Name from PLC:Bond_heat_temperature
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005688)
		/// Size: 4
		public IBaseData<float> Bond_heat_temperature { get; }
		internal float ref_Bond_heat_temperature = new float();

		/// <summary>
		/// Name from PLC:Bond_heat_temperature_limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005692)
		/// Size: 4
		public IBaseData<float> Bond_heat_temperature_limit { get; }
		internal float ref_Bond_heat_temperature_limit = new float();

		/// <summary>
		/// Name from PLC:Bond_heat_temperature_offset
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005696)
		/// Size: 4
		public IBaseData<float> Bond_heat_temperature_offset { get; }
		internal float ref_Bond_heat_temperature_offset = new float();

		/// <summary>
		/// Name from PLC:Bond_heat_over_time
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005700)
		/// Size: 4
		public IBaseData<float> Bond_heat_over_time { get; }
		internal float ref_Bond_heat_over_time = new float();

		/// <summary>
		/// Name from PLC:After_heat_temperature
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005704)
		/// Size: 4
		public IBaseData<float> After_heat_temperature { get; }
		internal float ref_After_heat_temperature = new float();

		/// <summary>
		/// Name from PLC:After_heat_temperature_limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005708)
		/// Size: 4
		public IBaseData<float> After_heat_temperature_limit { get; }
		internal float ref_After_heat_temperature_limit = new float();

		/// <summary>
		/// Name from PLC:After_heat_temperature_offset
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005712)
		/// Size: 4
		public IBaseData<float> After_heat_temperature_offset { get; }
		internal float ref_After_heat_temperature_offset = new float();

		/// <summary>
		/// Name from PLC:After_heat_over_time
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2005716)
		/// Size: 4
		public IBaseData<float> After_heat_over_time { get; }
		internal float ref_After_heat_over_time = new float();

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
