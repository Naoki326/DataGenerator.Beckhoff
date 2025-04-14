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
	
	internal static class GetClass_89e50a6dcb8d484395f6b1368e7ee508
	{
		internal static ref float GetWafer_radius(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Wafer_radius;
		internal static ref float GetWafer_ring_diameter(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Wafer_ring_diameter;
		internal static ref float GetWafer_ring_thickness(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Wafer_ring_thickness;
		internal static ref float GetNo_of_W_cassette_slots(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_No_of_W_cassette_slots;
		internal static ref float GetW_cassette_slot_pitch(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_W_cassette_slot_pitch;
		internal static ref float GetW_CST_bottom_slot_height(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_W_CST_bottom_slot_height;
		internal static ref float GetNo_of_W_cassette_stack(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_No_of_W_cassette_stack;
		internal static ref float GetW_cassette_height(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_W_cassette_height;
		internal static ref float GetWafer_tape_heat_temperature(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Wafer_tape_heat_temperature;
		internal static ref bool GetWafer_Barcode_read(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Wafer_Barcode_read;
		internal static ref bool GetOrder_of_wafer_load(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Order_of_wafer_load;
		internal static ref bool GetWafer_auto_unload(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Wafer_auto_unload;
		internal static ref float GetWafer_tape_heat_temperature_range(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Wafer_tape_heat_temperature_range;
		internal static ref float GetWafer_tape_heat_temperature_offset(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Wafer_tape_heat_temperature_offset;
		internal static ref float GetWafer_tape_heat_up_time(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Wafer_tape_heat_up_time;
		internal static ref float GetPre_expand_W_tape_heat_time(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Pre_expand_W_tape_heat_time;
		internal static ref float GetPost_expand_W_tape_heat_time(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Post_expand_W_tape_heat_time;
		internal static ref float GetW_CST_height_at_wafer_unload(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_W_CST_height_at_wafer_unload;
		internal static ref float GetW_CST_height_at_wafer_load(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_W_CST_height_at_wafer_load;
		internal static ref float GetW_CST_height_at_wafer_push(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_W_CST_height_at_wafer_push;
		internal static ref float GetW_CST_lifter_updown_speed_Fast(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_W_CST_lifter_updown_speed_Fast;
		internal static ref float GetW_cassette_change_height(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_W_cassette_change_height;
		internal static ref float GetSlow_start_Pos_before_grip(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Slow_start_Pos_before_grip;
		internal static ref float GetSlow_start_Pos_before_release(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Slow_start_Pos_before_release;
		internal static ref float GetPre_push_position(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Pre_push_position;
		internal static ref float GetExtractor_speed_Fast(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Extractor_speed_Fast;
		internal static ref float GetExtractor_speed_Slow(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Extractor_speed_Slow;
		internal static ref float GetExtractor_slow_speed(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Extractor_slow_speed;
		internal static ref float GetPre_gripper_action_delay(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Pre_gripper_action_delay;
		internal static ref float GetGriper_open_close_action_delay(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Griper_open_close_action_delay;
		internal static ref float GetRegrip_distance(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Regrip_distance;
		internal static ref float GetRegrip_time(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Regrip_time;
		internal static ref float GetRing_position_offset_in_cassette(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Ring_position_offset_in_cassette;
		internal static ref float GetReversed_frame_Rec_mode(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Reversed_frame_Rec_mode;
		internal static ref float GetRecognition_threshold(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Recognition_threshold;
		internal static ref float GetRecognition_cutoff(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Recognition_cutoff;
		internal static ref float GetPre_heat_temperature(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Pre_heat_temperature;
		internal static ref float GetPre_heat_temperature_limit(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Pre_heat_temperature_limit;
		internal static ref float GetPre_heat_temperature_offset(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Pre_heat_temperature_offset;
		internal static ref float GetPre_heat_over_time(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Pre_heat_over_time;
		internal static ref float GetBond_heat_temperature(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Bond_heat_temperature;
		internal static ref float GetBond_heat_temperature_limit(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Bond_heat_temperature_limit;
		internal static ref float GetBond_heat_temperature_offset(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Bond_heat_temperature_offset;
		internal static ref float GetBond_heat_over_time(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_Bond_heat_over_time;
		internal static ref float GetAfter_heat_temperature(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_After_heat_temperature;
		internal static ref float GetAfter_heat_temperature_limit(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_After_heat_temperature_limit;
		internal static ref float GetAfter_heat_temperature_offset(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_After_heat_temperature_offset;
		internal static ref float GetAfter_heat_over_time(this GVL_Recipe_WafferMaterialWrapper parent) => ref parent.ref_After_heat_over_time;
	}

}
