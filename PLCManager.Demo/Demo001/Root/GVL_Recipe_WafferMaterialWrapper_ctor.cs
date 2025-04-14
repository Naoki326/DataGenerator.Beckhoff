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
	/// Name from PLC:GVL_Recipe_WafferMaterial
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_Recipe_WafferMaterialWrapper : BaseData, IBaseData
	{
		public override IEnumerable<IBaseData> Children
		{
			get
			{
				yield return Wafer_radius;
				yield return Wafer_ring_diameter;
				yield return Wafer_ring_thickness;
				yield return No_of_W_cassette_slots;
				yield return W_cassette_slot_pitch;
				yield return W_CST_bottom_slot_height;
				yield return No_of_W_cassette_stack;
				yield return W_cassette_height;
				yield return Wafer_tape_heat_temperature;
				yield return Wafer_Barcode_read;
				yield return Order_of_wafer_load;
				yield return Wafer_auto_unload;
				yield return Wafer_tape_heat_temperature_range;
				yield return Wafer_tape_heat_temperature_offset;
				yield return Wafer_tape_heat_up_time;
				yield return Pre_expand_W_tape_heat_time;
				yield return Post_expand_W_tape_heat_time;
				yield return W_CST_height_at_wafer_unload;
				yield return W_CST_height_at_wafer_load;
				yield return W_CST_height_at_wafer_push;
				yield return W_CST_lifter_updown_speed_Fast;
				yield return W_cassette_change_height;
				yield return Slow_start_Pos_before_grip;
				yield return Slow_start_Pos_before_release;
				yield return Pre_push_position;
				yield return Extractor_speed_Fast;
				yield return Extractor_speed_Slow;
				yield return Extractor_slow_speed;
				yield return Pre_gripper_action_delay;
				yield return Griper_open_close_action_delay;
				yield return Regrip_distance;
				yield return Regrip_time;
				yield return Ring_position_offset_in_cassette;
				yield return Reversed_frame_Rec_mode;
				yield return Recognition_threshold;
				yield return Recognition_cutoff;
				yield return Pre_heat_temperature;
				yield return Pre_heat_temperature_limit;
				yield return Pre_heat_temperature_offset;
				yield return Pre_heat_over_time;
				yield return Bond_heat_temperature;
				yield return Bond_heat_temperature_limit;
				yield return Bond_heat_temperature_offset;
				yield return Bond_heat_over_time;
				yield return After_heat_temperature;
				yield return After_heat_temperature_limit;
				yield return After_heat_temperature_offset;
				yield return After_heat_over_time;
			}
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Wafer_radius):
					return Wafer_radius;
				case nameof(Wafer_ring_diameter):
					return Wafer_ring_diameter;
				case nameof(Wafer_ring_thickness):
					return Wafer_ring_thickness;
				case nameof(No_of_W_cassette_slots):
					return No_of_W_cassette_slots;
				case nameof(W_cassette_slot_pitch):
					return W_cassette_slot_pitch;
				case nameof(W_CST_bottom_slot_height):
					return W_CST_bottom_slot_height;
				case nameof(No_of_W_cassette_stack):
					return No_of_W_cassette_stack;
				case nameof(W_cassette_height):
					return W_cassette_height;
				case nameof(Wafer_tape_heat_temperature):
					return Wafer_tape_heat_temperature;
				case nameof(Wafer_Barcode_read):
					return Wafer_Barcode_read;
				case nameof(Order_of_wafer_load):
					return Order_of_wafer_load;
				case nameof(Wafer_auto_unload):
					return Wafer_auto_unload;
				case nameof(Wafer_tape_heat_temperature_range):
					return Wafer_tape_heat_temperature_range;
				case nameof(Wafer_tape_heat_temperature_offset):
					return Wafer_tape_heat_temperature_offset;
				case nameof(Wafer_tape_heat_up_time):
					return Wafer_tape_heat_up_time;
				case nameof(Pre_expand_W_tape_heat_time):
					return Pre_expand_W_tape_heat_time;
				case nameof(Post_expand_W_tape_heat_time):
					return Post_expand_W_tape_heat_time;
				case nameof(W_CST_height_at_wafer_unload):
					return W_CST_height_at_wafer_unload;
				case nameof(W_CST_height_at_wafer_load):
					return W_CST_height_at_wafer_load;
				case nameof(W_CST_height_at_wafer_push):
					return W_CST_height_at_wafer_push;
				case nameof(W_CST_lifter_updown_speed_Fast):
					return W_CST_lifter_updown_speed_Fast;
				case nameof(W_cassette_change_height):
					return W_cassette_change_height;
				case nameof(Slow_start_Pos_before_grip):
					return Slow_start_Pos_before_grip;
				case nameof(Slow_start_Pos_before_release):
					return Slow_start_Pos_before_release;
				case nameof(Pre_push_position):
					return Pre_push_position;
				case nameof(Extractor_speed_Fast):
					return Extractor_speed_Fast;
				case nameof(Extractor_speed_Slow):
					return Extractor_speed_Slow;
				case nameof(Extractor_slow_speed):
					return Extractor_slow_speed;
				case nameof(Pre_gripper_action_delay):
					return Pre_gripper_action_delay;
				case nameof(Griper_open_close_action_delay):
					return Griper_open_close_action_delay;
				case nameof(Regrip_distance):
					return Regrip_distance;
				case nameof(Regrip_time):
					return Regrip_time;
				case nameof(Ring_position_offset_in_cassette):
					return Ring_position_offset_in_cassette;
				case nameof(Reversed_frame_Rec_mode):
					return Reversed_frame_Rec_mode;
				case nameof(Recognition_threshold):
					return Recognition_threshold;
				case nameof(Recognition_cutoff):
					return Recognition_cutoff;
				case nameof(Pre_heat_temperature):
					return Pre_heat_temperature;
				case nameof(Pre_heat_temperature_limit):
					return Pre_heat_temperature_limit;
				case nameof(Pre_heat_temperature_offset):
					return Pre_heat_temperature_offset;
				case nameof(Pre_heat_over_time):
					return Pre_heat_over_time;
				case nameof(Bond_heat_temperature):
					return Bond_heat_temperature;
				case nameof(Bond_heat_temperature_limit):
					return Bond_heat_temperature_limit;
				case nameof(Bond_heat_temperature_offset):
					return Bond_heat_temperature_offset;
				case nameof(Bond_heat_over_time):
					return Bond_heat_over_time;
				case nameof(After_heat_temperature):
					return After_heat_temperature;
				case nameof(After_heat_temperature_limit):
					return After_heat_temperature_limit;
				case nameof(After_heat_temperature_offset):
					return After_heat_temperature_offset;
				case nameof(After_heat_over_time):
					return After_heat_over_time;
			}
			throw new KeyNotFoundException(name);
		}

		private readonly AdsClient client;

		public GVL_Recipe_WafferMaterialWrapper(AdsClient client)
		{
			this.client = client;

			Wafer_radius = new BeckhoffFloat(this.GetWafer_radius, client, 16448, 2005536){ Name = "Wafer_radius" };
			Wafer_ring_diameter = new BeckhoffFloat(this.GetWafer_ring_diameter, client, 16448, 2005540){ Name = "Wafer_ring_diameter" };
			Wafer_ring_thickness = new BeckhoffFloat(this.GetWafer_ring_thickness, client, 16448, 2005544){ Name = "Wafer_ring_thickness" };
			No_of_W_cassette_slots = new BeckhoffFloat(this.GetNo_of_W_cassette_slots, client, 16448, 2005548){ Name = "No_of_W_cassette_slots" };
			W_cassette_slot_pitch = new BeckhoffFloat(this.GetW_cassette_slot_pitch, client, 16448, 2005552){ Name = "W_cassette_slot_pitch" };
			W_CST_bottom_slot_height = new BeckhoffFloat(this.GetW_CST_bottom_slot_height, client, 16448, 2005556){ Name = "W_CST_bottom_slot_height" };
			No_of_W_cassette_stack = new BeckhoffFloat(this.GetNo_of_W_cassette_stack, client, 16448, 2005560){ Name = "No_of_W_cassette_stack" };
			W_cassette_height = new BeckhoffFloat(this.GetW_cassette_height, client, 16448, 2005564){ Name = "W_cassette_height" };
			Wafer_tape_heat_temperature = new BeckhoffFloat(this.GetWafer_tape_heat_temperature, client, 16448, 2005568){ Name = "Wafer_tape_heat_temperature" };
			Wafer_Barcode_read = new BeckhoffBool(this.GetWafer_Barcode_read, client, 16448, 2005572){ Name = "Wafer_Barcode_read" };
			Order_of_wafer_load = new BeckhoffBool(this.GetOrder_of_wafer_load, client, 16448, 2005573){ Name = "Order_of_wafer_load" };
			Wafer_auto_unload = new BeckhoffBool(this.GetWafer_auto_unload, client, 16448, 2005574){ Name = "Wafer_auto_unload" };
			Wafer_tape_heat_temperature_range = new BeckhoffFloat(this.GetWafer_tape_heat_temperature_range, client, 16448, 2005576){ Name = "Wafer_tape_heat_temperature_range" };
			Wafer_tape_heat_temperature_offset = new BeckhoffFloat(this.GetWafer_tape_heat_temperature_offset, client, 16448, 2005580){ Name = "Wafer_tape_heat_temperature_offset" };
			Wafer_tape_heat_up_time = new BeckhoffFloat(this.GetWafer_tape_heat_up_time, client, 16448, 2005584){ Name = "Wafer_tape_heat_up_time" };
			Pre_expand_W_tape_heat_time = new BeckhoffFloat(this.GetPre_expand_W_tape_heat_time, client, 16448, 2005588){ Name = "Pre_expand_W_tape_heat_time" };
			Post_expand_W_tape_heat_time = new BeckhoffFloat(this.GetPost_expand_W_tape_heat_time, client, 16448, 2005592){ Name = "Post_expand_W_tape_heat_time" };
			W_CST_height_at_wafer_unload = new BeckhoffFloat(this.GetW_CST_height_at_wafer_unload, client, 16448, 2005596){ Name = "W_CST_height_at_wafer_unload" };
			W_CST_height_at_wafer_load = new BeckhoffFloat(this.GetW_CST_height_at_wafer_load, client, 16448, 2005600){ Name = "W_CST_height_at_wafer_load" };
			W_CST_height_at_wafer_push = new BeckhoffFloat(this.GetW_CST_height_at_wafer_push, client, 16448, 2005604){ Name = "W_CST_height_at_wafer_push" };
			W_CST_lifter_updown_speed_Fast = new BeckhoffFloat(this.GetW_CST_lifter_updown_speed_Fast, client, 16448, 2005608){ Name = "W_CST_lifter_updown_speed_Fast" };
			W_cassette_change_height = new BeckhoffFloat(this.GetW_cassette_change_height, client, 16448, 2005612){ Name = "W_cassette_change_height" };
			Slow_start_Pos_before_grip = new BeckhoffFloat(this.GetSlow_start_Pos_before_grip, client, 16448, 2005616){ Name = "Slow_start_Pos_before_grip" };
			Slow_start_Pos_before_release = new BeckhoffFloat(this.GetSlow_start_Pos_before_release, client, 16448, 2005620){ Name = "Slow_start_Pos_before_release" };
			Pre_push_position = new BeckhoffFloat(this.GetPre_push_position, client, 16448, 2005624){ Name = "Pre_push_position" };
			Extractor_speed_Fast = new BeckhoffFloat(this.GetExtractor_speed_Fast, client, 16448, 2005628){ Name = "Extractor_speed_Fast" };
			Extractor_speed_Slow = new BeckhoffFloat(this.GetExtractor_speed_Slow, client, 16448, 2005632){ Name = "Extractor_speed_Slow" };
			Extractor_slow_speed = new BeckhoffFloat(this.GetExtractor_slow_speed, client, 16448, 2005636){ Name = "Extractor_slow_speed" };
			Pre_gripper_action_delay = new BeckhoffFloat(this.GetPre_gripper_action_delay, client, 16448, 2005640){ Name = "Pre_gripper_action_delay" };
			Griper_open_close_action_delay = new BeckhoffFloat(this.GetGriper_open_close_action_delay, client, 16448, 2005644){ Name = "Griper_open_close_action_delay" };
			Regrip_distance = new BeckhoffFloat(this.GetRegrip_distance, client, 16448, 2005648){ Name = "Regrip_distance" };
			Regrip_time = new BeckhoffFloat(this.GetRegrip_time, client, 16448, 2005652){ Name = "Regrip_time" };
			Ring_position_offset_in_cassette = new BeckhoffFloat(this.GetRing_position_offset_in_cassette, client, 16448, 2005656){ Name = "Ring_position_offset_in_cassette" };
			Reversed_frame_Rec_mode = new BeckhoffFloat(this.GetReversed_frame_Rec_mode, client, 16448, 2005660){ Name = "Reversed_frame_Rec_mode" };
			Recognition_threshold = new BeckhoffFloat(this.GetRecognition_threshold, client, 16448, 2005664){ Name = "Recognition_threshold" };
			Recognition_cutoff = new BeckhoffFloat(this.GetRecognition_cutoff, client, 16448, 2005668){ Name = "Recognition_cutoff" };
			Pre_heat_temperature = new BeckhoffFloat(this.GetPre_heat_temperature, client, 16448, 2005672){ Name = "Pre_heat_temperature" };
			Pre_heat_temperature_limit = new BeckhoffFloat(this.GetPre_heat_temperature_limit, client, 16448, 2005676){ Name = "Pre_heat_temperature_limit" };
			Pre_heat_temperature_offset = new BeckhoffFloat(this.GetPre_heat_temperature_offset, client, 16448, 2005680){ Name = "Pre_heat_temperature_offset" };
			Pre_heat_over_time = new BeckhoffFloat(this.GetPre_heat_over_time, client, 16448, 2005684){ Name = "Pre_heat_over_time" };
			Bond_heat_temperature = new BeckhoffFloat(this.GetBond_heat_temperature, client, 16448, 2005688){ Name = "Bond_heat_temperature" };
			Bond_heat_temperature_limit = new BeckhoffFloat(this.GetBond_heat_temperature_limit, client, 16448, 2005692){ Name = "Bond_heat_temperature_limit" };
			Bond_heat_temperature_offset = new BeckhoffFloat(this.GetBond_heat_temperature_offset, client, 16448, 2005696){ Name = "Bond_heat_temperature_offset" };
			Bond_heat_over_time = new BeckhoffFloat(this.GetBond_heat_over_time, client, 16448, 2005700){ Name = "Bond_heat_over_time" };
			After_heat_temperature = new BeckhoffFloat(this.GetAfter_heat_temperature, client, 16448, 2005704){ Name = "After_heat_temperature" };
			After_heat_temperature_limit = new BeckhoffFloat(this.GetAfter_heat_temperature_limit, client, 16448, 2005708){ Name = "After_heat_temperature_limit" };
			After_heat_temperature_offset = new BeckhoffFloat(this.GetAfter_heat_temperature_offset, client, 16448, 2005712){ Name = "After_heat_temperature_offset" };
			After_heat_over_time = new BeckhoffFloat(this.GetAfter_heat_over_time, client, 16448, 2005716){ Name = "After_heat_over_time" };
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
		~GVL_Recipe_WafferMaterialWrapper()
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
