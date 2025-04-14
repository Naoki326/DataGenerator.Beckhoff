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
	/// Name from PLC:GVL_Setup
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_SetupWrapper
	{

		/// <summary>
		/// Name from PLC:Frame_transfer_motion
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004407)
		/// Size: 1
		public IBaseData<bool> Frame_transfer_motion { get; }
		internal bool ref_Frame_transfer_motion = new bool();

		/// <summary>
		/// Name from PLC:IMH_Loading_Y_Origin
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004408)
		/// Size: 4
		public IBaseData<float> IMH_Loading_Y_Origin { get; }
		internal float ref_IMH_Loading_Y_Origin = new float();

		/// <summary>
		/// Name from PLC:IMH_Loading_Z_Origin
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004412)
		/// Size: 4
		public IBaseData<float> IMH_Loading_Z_Origin { get; }
		internal float ref_IMH_Loading_Z_Origin = new float();

		/// <summary>
		/// Name from PLC:IMH_Loading_Z_Limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004416)
		/// Size: 4
		public IBaseData<float> IMH_Loading_Z_Limit { get; }
		internal float ref_IMH_Loading_Z_Limit = new float();

		/// <summary>
		/// Name from PLC:IMH_Loading_Table_Height
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004420)
		/// Size: 4
		public IBaseData<float> IMH_Loading_Table_Height { get; }
		internal float ref_IMH_Loading_Table_Height = new float();

		/// <summary>
		/// Name from PLC:IMH_Loading_Height_Before
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004424)
		/// Size: 4
		public IBaseData<float> IMH_Loading_Height_Before { get; }
		internal float ref_IMH_Loading_Height_Before = new float();

		/// <summary>
		/// Name from PLC:IMH_Loading_Height_After
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004428)
		/// Size: 4
		public IBaseData<float> IMH_Loading_Height_After { get; }
		internal float ref_IMH_Loading_Height_After = new float();

		/// <summary>
		/// Name from PLC:IMH_UnLoading_Position
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004432)
		/// Size: 4
		public IBaseData<float> IMH_UnLoading_Position { get; }
		internal float ref_IMH_UnLoading_Position = new float();

		/// <summary>
		/// Name from PLC:IMH_UnLoad_Table_Height
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004436)
		/// Size: 4
		public IBaseData<float> IMH_UnLoad_Table_Height { get; }
		internal float ref_IMH_UnLoad_Table_Height = new float();

		/// <summary>
		/// Name from PLC:IMH_UnLoading_Height_Before
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004440)
		/// Size: 4
		public IBaseData<float> IMH_UnLoading_Height_Before { get; }
		internal float ref_IMH_UnLoading_Height_Before = new float();

		/// <summary>
		/// Name from PLC:IMH_UnLoading_Height_After
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004444)
		/// Size: 4
		public IBaseData<float> IMH_UnLoading_Height_After { get; }
		internal float ref_IMH_UnLoading_Height_After = new float();

		/// <summary>
		/// Name from PLC:OMH_UnLoading_Y_Origin
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004448)
		/// Size: 4
		public IBaseData<float> OMH_UnLoading_Y_Origin { get; }
		internal float ref_OMH_UnLoading_Y_Origin = new float();

		/// <summary>
		/// Name from PLC:OMH_UnLoading_Z_Origin
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004452)
		/// Size: 4
		public IBaseData<float> OMH_UnLoading_Z_Origin { get; }
		internal float ref_OMH_UnLoading_Z_Origin = new float();

		/// <summary>
		/// Name from PLC:OMH_UnLoading_Z_Limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004456)
		/// Size: 4
		public IBaseData<float> OMH_UnLoading_Z_Limit { get; }
		internal float ref_OMH_UnLoading_Z_Limit = new float();

		/// <summary>
		/// Name from PLC:OMH_Loading_Table_Height
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004460)
		/// Size: 4
		public IBaseData<float> OMH_Loading_Table_Height { get; }
		internal float ref_OMH_Loading_Table_Height = new float();

		/// <summary>
		/// Name from PLC:OMH_Loading_Height_Before
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004464)
		/// Size: 4
		public IBaseData<float> OMH_Loading_Height_Before { get; }
		internal float ref_OMH_Loading_Height_Before = new float();

		/// <summary>
		/// Name from PLC:OMH_Loading_Height_After
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004468)
		/// Size: 4
		public IBaseData<float> OMH_Loading_Height_After { get; }
		internal float ref_OMH_Loading_Height_After = new float();

		/// <summary>
		/// Name from PLC:OMH_UnLoading_Position
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004472)
		/// Size: 4
		public IBaseData<float> OMH_UnLoading_Position { get; }
		internal float ref_OMH_UnLoading_Position = new float();

		/// <summary>
		/// Name from PLC:OMH_UnLoading_Table_Height
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004476)
		/// Size: 4
		public IBaseData<float> OMH_UnLoading_Table_Height { get; }
		internal float ref_OMH_UnLoading_Table_Height = new float();

		/// <summary>
		/// Name from PLC:OMH_UnLoading_Height_Before
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004480)
		/// Size: 4
		public IBaseData<float> OMH_UnLoading_Height_Before { get; }
		internal float ref_OMH_UnLoading_Height_Before = new float();

		/// <summary>
		/// Name from PLC:OMH_UnLoading_Height_After
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004484)
		/// Size: 4
		public IBaseData<float> OMH_UnLoading_Height_After { get; }
		internal float ref_OMH_UnLoading_Height_After = new float();

		/// <summary>
		/// Name from PLC:Wafer_motion
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004488)
		/// Size: 1
		public IBaseData<bool> Wafer_motion { get; }
		internal bool ref_Wafer_motion = new bool();

		/// <summary>
		/// Name from PLC:Clean_motion
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004489)
		/// Size: 1
		public IBaseData<bool> Clean_motion { get; }
		internal bool ref_Clean_motion = new bool();

		/// <summary>
		/// Name from PLC:Frame_transfer_speed
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004490)
		/// Size: 1
		public IBaseData<bool> Frame_transfer_speed { get; }
		internal bool ref_Frame_transfer_speed = new bool();

		/// <summary>
		/// Name from PLC:Clean_speed
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004491)
		/// Size: 1
		public IBaseData<bool> Clean_speed { get; }
		internal bool ref_Clean_speed = new bool();

		/// <summary>
		/// Name from PLC:Preform_Speed
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004492)
		/// Size: 1
		public IBaseData<bool> Preform_Speed { get; }
		internal bool ref_Preform_Speed = new bool();

		/// <summary>
		/// Name from PLC:Utility_Check
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004493)
		/// Size: 1
		public IBaseData<bool> Utility_Check { get; }
		internal bool ref_Utility_Check = new bool();

		/// <summary>
		/// Name from PLC:No_frame_error_stop
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004494)
		/// Size: 1
		public IBaseData<bool> No_frame_error_stop { get; }
		internal bool ref_No_frame_error_stop = new bool();

		/// <summary>
		/// Name from PLC:Double_frame_detection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004495)
		/// Size: 1
		public IBaseData<bool> Double_frame_detection { get; }
		internal bool ref_Double_frame_detection = new bool();

		/// <summary>
		/// Name from PLC:PS_vacuum_detection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004496)
		/// Size: 1
		public IBaseData<bool> PS_vacuum_detection { get; }
		internal bool ref_PS_vacuum_detection = new bool();

		/// <summary>
		/// Name from PLC:BS_vacuum_detection
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004497)
		/// Size: 1
		public IBaseData<bool> BS_vacuum_detection { get; }
		internal bool ref_BS_vacuum_detection = new bool();

		/// <summary>
		/// Name from PLC:Stage_up_down_mechanism
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004498)
		/// Size: 1
		public IBaseData<bool> Stage_up_down_mechanism { get; }
		internal bool ref_Stage_up_down_mechanism = new bool();

		/// <summary>
		/// Name from PLC:Pre_heat
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004499)
		/// Size: 1
		public IBaseData<bool> Pre_heat { get; }
		internal bool ref_Pre_heat = new bool();

		/// <summary>
		/// Name from PLC:Bond_heat
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004500)
		/// Size: 1
		public IBaseData<bool> Bond_heat { get; }
		internal bool ref_Bond_heat = new bool();

		/// <summary>
		/// Name from PLC:After_heat
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004501)
		/// Size: 1
		public IBaseData<bool> After_heat { get; }
		internal bool ref_After_heat = new bool();

		/// <summary>
		/// Name from PLC:IMH_UnLoading_Y_Origin
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2004502)
		/// Size: 2
		public IBaseData<short> IMH_UnLoading_Y_Origin { get; }
		internal short ref_IMH_UnLoading_Y_Origin = new short();

		/// <summary>
		/// Name from PLC:Vac_source_sensor_upper_limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004504)
		/// Size: 4
		public IBaseData<float> Vac_source_sensor_upper_limit { get; }
		internal float ref_Vac_source_sensor_upper_limit = new float();

		/// <summary>
		/// Name from PLC:Vac_source_sensor_lower_limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004508)
		/// Size: 4
		public IBaseData<float> Vac_source_sensor_lower_limit { get; }
		internal float ref_Vac_source_sensor_lower_limit = new float();

		/// <summary>
		/// Name from PLC:Air_source_sensor_upper_limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004512)
		/// Size: 4
		public IBaseData<float> Air_source_sensor_upper_limit { get; }
		internal float ref_Air_source_sensor_upper_limit = new float();

		/// <summary>
		/// Name from PLC:Air_source_sensor_lower_limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004516)
		/// Size: 4
		public IBaseData<float> Air_source_sensor_lower_limit { get; }
		internal float ref_Air_source_sensor_lower_limit = new float();

		/// <summary>
		/// Name from PLC:B_force_air_sensor_upper_limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004520)
		/// Size: 4
		public IBaseData<float> B_force_air_sensor_upper_limit { get; }
		internal float ref_B_force_air_sensor_upper_limit = new float();

		/// <summary>
		/// Name from PLC:B_force_air_sensor_lower_limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004524)
		/// Size: 4
		public IBaseData<float> B_force_air_sensor_lower_limit { get; }
		internal float ref_B_force_air_sensor_lower_limit = new float();

		/// <summary>
		/// Name from PLC:PS_vacuum_sensor_offset
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004528)
		/// Size: 4
		public IBaseData<float> PS_vacuum_sensor_offset { get; }
		internal float ref_PS_vacuum_sensor_offset = new float();

		/// <summary>
		/// Name from PLC:BS_vacuum_sensor_offset
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004532)
		/// Size: 4
		public IBaseData<float> BS_vacuum_sensor_offset { get; }
		internal float ref_BS_vacuum_sensor_offset = new float();

		/// <summary>
		/// Name from PLC:Frame_vacuum_sensor_offset
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004536)
		/// Size: 4
		public IBaseData<float> Frame_vacuum_sensor_offset { get; }
		internal float ref_Frame_vacuum_sensor_offset = new float();

		/// <summary>
		/// Name from PLC:Vacuum_source_sensor_offset
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004540)
		/// Size: 4
		public IBaseData<float> Vacuum_source_sensor_offset { get; }
		internal float ref_Vacuum_source_sensor_offset = new float();

		/// <summary>
		/// Name from PLC:Air_source_sensor_offset
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004544)
		/// Size: 4
		public IBaseData<float> Air_source_sensor_offset { get; }
		internal float ref_Air_source_sensor_offset = new float();

		/// <summary>
		/// Name from PLC:Preform_CDA_Y_Axis_Origin
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004548)
		/// Size: 4
		public IBaseData<float> Preform_CDA_Y_Axis_Origin { get; }
		internal float ref_Preform_CDA_Y_Axis_Origin = new float();

		/// <summary>
		/// Name from PLC:Preform_CDA_Z_Axis_Origin
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004552)
		/// Size: 4
		public IBaseData<float> Preform_CDA_Z_Axis_Origin { get; }
		internal float ref_Preform_CDA_Z_Axis_Origin = new float();

		/// <summary>
		/// Name from PLC:Preform_Touch_Sensor_Sensitivity
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004556)
		/// Size: 4
		public IBaseData<float> Preform_Touch_Sensor_Sensitivity { get; }
		internal float ref_Preform_Touch_Sensor_Sensitivity = new float();

		/// <summary>
		/// Name from PLC:Preform_Nozzle_height_Check_Y_Pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004560)
		/// Size: 4
		public IBaseData<float> Preform_Nozzle_height_Check_Y_Pos { get; }
		internal float ref_Preform_Nozzle_height_Check_Y_Pos = new float();

		/// <summary>
		/// Name from PLC:P_Claw_Conflict_Pos_Y
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004564)
		/// Size: 4
		public IBaseData<float> P_Claw_Conflict_Pos_Y { get; }
		internal float ref_P_Claw_Conflict_Pos_Y = new float();

		/// <summary>
		/// Name from PLC:P_Clamp_Conflict_Left_Pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004568)
		/// Size: 4
		public IBaseData<float> P_Clamp_Conflict_Left_Pos { get; }
		internal float ref_P_Clamp_Conflict_Left_Pos = new float();

		/// <summary>
		/// Name from PLC:P_Clamp_Conflict_Right_Pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004572)
		/// Size: 4
		public IBaseData<float> P_Clamp_Conflict_Right_Pos { get; }
		internal float ref_P_Clamp_Conflict_Right_Pos = new float();

		/// <summary>
		/// Name from PLC:FIG_Loader_Feeder_Origin
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004576)
		/// Size: 4
		public IBaseData<float> FIG_Loader_Feeder_Origin { get; }
		internal float ref_FIG_Loader_Feeder_Origin = new float();

		/// <summary>
		/// Name from PLC:FIG_Loader_Feeder_Left_Limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004580)
		/// Size: 4
		public IBaseData<float> FIG_Loader_Feeder_Left_Limit { get; }
		internal float ref_FIG_Loader_Feeder_Left_Limit = new float();

		/// <summary>
		/// Name from PLC:FIG_Loader_Feeder_Right_Limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004584)
		/// Size: 4
		public IBaseData<float> FIG_Loader_Feeder_Right_Limit { get; }
		internal float ref_FIG_Loader_Feeder_Right_Limit = new float();

		/// <summary>
		/// Name from PLC:FIG_Clamp_Origin
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004588)
		/// Size: 4
		public IBaseData<float> FIG_Clamp_Origin { get; }
		internal float ref_FIG_Clamp_Origin = new float();

		/// <summary>
		/// Name from PLC:FIG_Preform_POs
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004592)
		/// Size: 4
		public IBaseData<float> FIG_Preform_POs { get; }
		internal float ref_FIG_Preform_POs = new float();

		/// <summary>
		/// Name from PLC:Feeder_RVS_Frame_Detect_Pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004596)
		/// Size: 4
		public IBaseData<float> Feeder_RVS_Frame_Detect_Pos { get; }
		internal float ref_Feeder_RVS_Frame_Detect_Pos = new float();

		/// <summary>
		/// Name from PLC:FCU_Main_Feeder1_Origin
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004600)
		/// Size: 4
		public IBaseData<float> FCU_Main_Feeder1_Origin { get; }
		internal float ref_FCU_Main_Feeder1_Origin = new float();

		/// <summary>
		/// Name from PLC:FCU_Main_Feeder1_Left_Limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004604)
		/// Size: 4
		public IBaseData<float> FCU_Main_Feeder1_Left_Limit { get; }
		internal float ref_FCU_Main_Feeder1_Left_Limit = new float();

		/// <summary>
		/// Name from PLC:FCU_Main_Feeder1_Right_Limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004608)
		/// Size: 4
		public IBaseData<float> FCU_Main_Feeder1_Right_Limit { get; }
		internal float ref_FCU_Main_Feeder1_Right_Limit = new float();

		/// <summary>
		/// Name from PLC:FCU_Main_Feeder_Claw_Width
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004612)
		/// Size: 4
		public IBaseData<float> FCU_Main_Feeder_Claw_Width { get; }
		internal float ref_FCU_Main_Feeder_Claw_Width = new float();

		/// <summary>
		/// Name from PLC:FCU_Clamp_Origin
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004616)
		/// Size: 4
		public IBaseData<float> FCU_Clamp_Origin { get; }
		internal float ref_FCU_Clamp_Origin = new float();

		/// <summary>
		/// Name from PLC:FBU_Main_Feeder2_Origin
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004620)
		/// Size: 4
		public IBaseData<float> FBU_Main_Feeder2_Origin { get; }
		internal float ref_FBU_Main_Feeder2_Origin = new float();

		/// <summary>
		/// Name from PLC:FBU_Main_Feeder2_Left_Limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004624)
		/// Size: 4
		public IBaseData<float> FBU_Main_Feeder2_Left_Limit { get; }
		internal float ref_FBU_Main_Feeder2_Left_Limit = new float();

		/// <summary>
		/// Name from PLC:FBU_Main_Feeder2_Right_Limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004628)
		/// Size: 4
		public IBaseData<float> FBU_Main_Feeder2_Right_Limit { get; }
		internal float ref_FBU_Main_Feeder2_Right_Limit = new float();

		/// <summary>
		/// Name from PLC:FBU_Main_Feeder2_Claw_Width
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004632)
		/// Size: 4
		public IBaseData<float> FBU_Main_Feeder2_Claw_Width { get; }
		internal float ref_FBU_Main_Feeder2_Claw_Width = new float();

		/// <summary>
		/// Name from PLC:FBU_Clamp_Origin
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004636)
		/// Size: 4
		public IBaseData<float> FBU_Clamp_Origin { get; }
		internal float ref_FBU_Clamp_Origin = new float();

		/// <summary>
		/// Name from PLC:FOG_UF_Claw_Open_Close_Origin
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004640)
		/// Size: 4
		public IBaseData<float> FOG_UF_Claw_Open_Close_Origin { get; }
		internal float ref_FOG_UF_Claw_Open_Close_Origin = new float();

		/// <summary>
		/// Name from PLC:FOG_Unloader_Feeder_Origin
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004644)
		/// Size: 4
		public IBaseData<float> FOG_Unloader_Feeder_Origin { get; }
		internal float ref_FOG_Unloader_Feeder_Origin = new float();

		/// <summary>
		/// Name from PLC:FOG_Unloader_Feeder_Left_Limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004648)
		/// Size: 4
		public IBaseData<float> FOG_Unloader_Feeder_Left_Limit { get; }
		internal float ref_FOG_Unloader_Feeder_Left_Limit = new float();

		/// <summary>
		/// Name from PLC:FOG_Unloader_Feeder_Right_Limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004652)
		/// Size: 4
		public IBaseData<float> FOG_Unloader_Feeder_Right_Limit { get; }
		internal float ref_FOG_Unloader_Feeder_Right_Limit = new float();

		/// <summary>
		/// Name from PLC:FOG_Unloading_Detect_Pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004656)
		/// Size: 4
		public IBaseData<float> FOG_Unloading_Detect_Pos { get; }
		internal float ref_FOG_Unloading_Detect_Pos = new float();

		/// <summary>
		/// Name from PLC:Track_Width_Origin
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004660)
		/// Size: 4
		public IBaseData<float> Track_Width_Origin { get; }
		internal float ref_Track_Width_Origin = new float();

		/// <summary>
		/// Name from PLC:Track_Width_Close_Limit
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004664)
		/// Size: 4
		public IBaseData<float> Track_Width_Close_Limit { get; }
		internal float ref_Track_Width_Close_Limit = new float();

		/// <summary>
		/// Name from PLC:Track_Left_Edge_Pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004668)
		/// Size: 4
		public IBaseData<float> Track_Left_Edge_Pos { get; }
		internal float ref_Track_Left_Edge_Pos = new float();

		/// <summary>
		/// Name from PLC:Track_Right_Edge_Pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004672)
		/// Size: 4
		public IBaseData<float> Track_Right_Edge_Pos { get; }
		internal float ref_Track_Right_Edge_Pos = new float();

		/// <summary>
		/// Name from PLC:WAF_Case_Lifter_Origin
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004676)
		/// Size: 4
		public IBaseData<float> WAF_Case_Lifter_Origin { get; }
		internal float ref_WAF_Case_Lifter_Origin = new float();

		/// <summary>
		/// Name from PLC:WAF_Case_Lifter_Wait_Height
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004680)
		/// Size: 4
		public IBaseData<float> WAF_Case_Lifter_Wait_Height { get; }
		internal float ref_WAF_Case_Lifter_Wait_Height = new float();

		/// <summary>
		/// Name from PLC:WAF_Case_Lifter_Heat_Plate_Height
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004684)
		/// Size: 4
		public IBaseData<float> WAF_Case_Lifter_Heat_Plate_Height { get; }
		internal float ref_WAF_Case_Lifter_Heat_Plate_Height = new float();

		/// <summary>
		/// Name from PLC:WAF_Case_Lifter_6inch_Heat_Height
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004688)
		/// Size: 4
		public IBaseData<float> WAF_Case_Lifter_6inch_Heat_Height { get; }
		internal float ref_WAF_Case_Lifter_6inch_Heat_Height = new float();

		/// <summary>
		/// Name from PLC:WAF_Case_Lifter_8inch_Heat_Height
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004692)
		/// Size: 4
		public IBaseData<float> WAF_Case_Lifter_8inch_Heat_Height { get; }
		internal float ref_WAF_Case_Lifter_8inch_Heat_Height = new float();

		/// <summary>
		/// Name from PLC:WAF_Case_Lifter_12inch_Heat_Height
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004696)
		/// Size: 4
		public IBaseData<float> WAF_Case_Lifter_12inch_Heat_Height { get; }
		internal float ref_WAF_Case_Lifter_12inch_Heat_Height = new float();

		/// <summary>
		/// Name from PLC:WAF_Extrator_Origin
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004700)
		/// Size: 4
		public IBaseData<float> WAF_Extrator_Origin { get; }
		internal float ref_WAF_Extrator_Origin = new float();

		/// <summary>
		/// Name from PLC:WAF_Pull_Position
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004704)
		/// Size: 4
		public IBaseData<float> WAF_Pull_Position { get; }
		internal float ref_WAF_Pull_Position = new float();

		/// <summary>
		/// Name from PLC:WAF_Adjust_Track_Pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004708)
		/// Size: 4
		public IBaseData<float> WAF_Adjust_Track_Pos { get; }
		internal float ref_WAF_Adjust_Track_Pos = new float();

		/// <summary>
		/// Name from PLC:WAF_Holder_Set_Release_Pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004712)
		/// Size: 4
		public IBaseData<float> WAF_Holder_Set_Release_Pos { get; }
		internal float ref_WAF_Holder_Set_Release_Pos = new float();

		/// <summary>
		/// Name from PLC:WAF_Putin_Pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004716)
		/// Size: 4
		public IBaseData<float> WAF_Putin_Pos { get; }
		internal float ref_WAF_Putin_Pos = new float();

		/// <summary>
		/// Name from PLC:WAF_Lifter_Wait_Pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004720)
		/// Size: 4
		public IBaseData<float> WAF_Lifter_Wait_Pos { get; }
		internal float ref_WAF_Lifter_Wait_Pos = new float();

		/// <summary>
		/// Name from PLC:WAF_Push_Pos
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,2004724)
		/// Size: 4
		public IBaseData<float> WAF_Push_Pos { get; }
		internal float ref_WAF_Push_Pos = new float();

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
