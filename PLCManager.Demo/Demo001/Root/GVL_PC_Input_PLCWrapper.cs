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
	/// Name from PLC:GVL_PC_Input_PLC
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_PC_Input_PLCWrapper
	{

		/// <summary>
		/// Name from PLC:G_In_bAllHome
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003237)
		/// Size: 1
		public IBaseData<bool> G_In_bAllHome { get; }
		internal bool ref_G_In_bAllHome = new bool();

		/// <summary>
		/// Name from PLC:G_IN_bAutoRun
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003238)
		/// Size: 1
		public IBaseData<bool> G_IN_bAutoRun { get; }
		internal bool ref_G_IN_bAutoRun = new bool();

		/// <summary>
		/// Name from PLC:G_IN_bInitial
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003239)
		/// Size: 1
		public IBaseData<bool> G_IN_bInitial { get; }
		internal bool ref_G_IN_bInitial = new bool();

		/// <summary>
		/// Name from PLC:G_In_Manual_Axis_bHomeStart
		/// TypeName from PLC: ARRAY [1..30] OF BOOL
		/// (IndexGroup, IndexOffset): (16448,2003240)
		/// Size: 30
		public IBaseArray<Bool30, bool> G_In_Manual_Axis_bHomeStart { get; }
		internal Bool30 ref_G_In_Manual_Axis_bHomeStart = new Bool30();

		/// <summary>
		/// Name from PLC:G_In_Manual_Axis_AbsStart
		/// TypeName from PLC: ARRAY [1..30] OF BOOL
		/// (IndexGroup, IndexOffset): (16448,2003270)
		/// Size: 30
		public IBaseArray<Bool30, bool> G_In_Manual_Axis_AbsStart { get; }
		internal Bool30 ref_G_In_Manual_Axis_AbsStart = new Bool30();

		/// <summary>
		/// Name from PLC:G_IN_bIMH_Home
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003300)
		/// Size: 1
		public IBaseData<bool> G_IN_bIMH_Home { get; }
		internal bool ref_G_IN_bIMH_Home = new bool();

		/// <summary>
		/// Name from PLC:G_IN_bIMH_loadCase
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003301)
		/// Size: 1
		public IBaseData<bool> G_IN_bIMH_loadCase { get; }
		internal bool ref_G_IN_bIMH_loadCase = new bool();

		/// <summary>
		/// Name from PLC:G_IN_bIMH_UnloadCase
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003302)
		/// Size: 1
		public IBaseData<bool> G_IN_bIMH_UnloadCase { get; }
		internal bool ref_G_IN_bIMH_UnloadCase = new bool();

		/// <summary>
		/// Name from PLC:G_In_bIMH_Start
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003303)
		/// Size: 1
		public IBaseData<bool> G_In_bIMH_Start { get; }
		internal bool ref_G_In_bIMH_Start = new bool();

		/// <summary>
		/// Name from PLC:G_Out_Axis_AbsPos
		/// TypeName from PLC: ARRAY [1..30] OF LREAL
		/// (IndexGroup, IndexOffset): (16448,2003304)
		/// Size: 240
		public IBaseArray<Double30, double> G_Out_Axis_AbsPos { get; }
		internal Double30 ref_G_Out_Axis_AbsPos = new Double30();

		/// <summary>
		/// Name from PLC:G_In_bIMH_Auto_Run
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003544)
		/// Size: 1
		public IBaseData<bool> G_In_bIMH_Auto_Run { get; }
		internal bool ref_G_In_bIMH_Auto_Run = new bool();

		/// <summary>
		/// Name from PLC:G_IN_bOMH_Home
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003545)
		/// Size: 1
		public IBaseData<bool> G_IN_bOMH_Home { get; }
		internal bool ref_G_IN_bOMH_Home = new bool();

		/// <summary>
		/// Name from PLC:G_IN_bOMH_loadCase
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003546)
		/// Size: 1
		public IBaseData<bool> G_IN_bOMH_loadCase { get; }
		internal bool ref_G_IN_bOMH_loadCase = new bool();

		/// <summary>
		/// Name from PLC:G_IN_bOMH_UnloadCase
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003547)
		/// Size: 1
		public IBaseData<bool> G_IN_bOMH_UnloadCase { get; }
		internal bool ref_G_IN_bOMH_UnloadCase = new bool();

		/// <summary>
		/// Name from PLC:G_In_bOMH_Start
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003548)
		/// Size: 1
		public IBaseData<bool> G_In_bOMH_Start { get; }
		internal bool ref_G_In_bOMH_Start = new bool();

		/// <summary>
		/// Name from PLC:G_In_bOMH_Auto_Run
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003549)
		/// Size: 1
		public IBaseData<bool> G_In_bOMH_Auto_Run { get; }
		internal bool ref_G_In_bOMH_Auto_Run = new bool();

		/// <summary>
		/// Name from PLC:G_IN_bFSU_Home
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003550)
		/// Size: 1
		public IBaseData<bool> G_IN_bFSU_Home { get; }
		internal bool ref_G_IN_bFSU_Home = new bool();

		/// <summary>
		/// Name from PLC:G_IN_bFSU_Strat
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003551)
		/// Size: 1
		public IBaseData<bool> G_IN_bFSU_Strat { get; }
		internal bool ref_G_IN_bFSU_Strat = new bool();

		/// <summary>
		/// Name from PLC:G_Alarm_Index
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,2003552)
		/// Size: 2
		public IBaseData<ushort> G_Alarm_Index { get; }
		internal ushort ref_G_Alarm_Index = new ushort();

		/// <summary>
		/// Name from PLC:G_IN_Valve_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2003554)
		/// Size: 2
		public IBaseData<short> G_IN_Valve_Index { get; }
		internal short ref_G_IN_Valve_Index = new short();

		/// <summary>
		/// Name from PLC:G_IN_Sensor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2003556)
		/// Size: 2
		public IBaseData<short> G_IN_Sensor_Index { get; }
		internal short ref_G_IN_Sensor_Index = new short();

		/// <summary>
		/// Name from PLC:G_IN_Manual_Axis_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2003558)
		/// Size: 2
		public IBaseData<short> G_IN_Manual_Axis_Index { get; }
		internal short ref_G_IN_Manual_Axis_Index = new short();

		/// <summary>
		/// Name from PLC:G_IN_Manual_Axis_Home_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2003560)
		/// Size: 2
		public IBaseData<short> G_IN_Manual_Axis_Home_Index { get; }
		internal short ref_G_IN_Manual_Axis_Home_Index = new short();

		/// <summary>
		/// Name from PLC:G_IN_Barcode_Suceess
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003562)
		/// Size: 1
		public IBaseData<bool> G_IN_Barcode_Suceess { get; }
		internal bool ref_G_IN_Barcode_Suceess = new bool();

		/// <summary>
		/// Name from PLC:G_IN_Barcode_Fail
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003563)
		/// Size: 1
		public IBaseData<bool> G_IN_Barcode_Fail { get; }
		internal bool ref_G_IN_Barcode_Fail = new bool();

		/// <summary>
		/// Name from PLC:G_IN_CleanVision_Sucess
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003564)
		/// Size: 1
		public IBaseData<bool> G_IN_CleanVision_Sucess { get; }
		internal bool ref_G_IN_CleanVision_Sucess = new bool();

		/// <summary>
		/// Name from PLC:G_IN_CleanVision_Fail
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003565)
		/// Size: 1
		public IBaseData<bool> G_IN_CleanVision_Fail { get; }
		internal bool ref_G_IN_CleanVision_Fail = new bool();

		/// <summary>
		/// Name from PLC:G_IN_TransBase_Bonding_Pos
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2003566)
		/// Size: 2
		public IBaseData<short> G_IN_TransBase_Bonding_Pos { get; }
		internal short ref_G_IN_TransBase_Bonding_Pos = new short();

		/// <summary>
		/// Name from PLC:G_IN_TransBase_Request
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003568)
		/// Size: 1
		public IBaseData<bool> G_IN_TransBase_Request { get; }
		internal bool ref_G_IN_TransBase_Request = new bool();

		/// <summary>
		/// Name from PLC:G_IN_Bonding_Cam_Result
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003569)
		/// Size: 1
		public IBaseData<bool> G_IN_Bonding_Cam_Result { get; }
		internal bool ref_G_IN_Bonding_Cam_Result = new bool();

		/// <summary>
		/// Name from PLC:G_IN_Bonding_Visoion_Sucess
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003570)
		/// Size: 1
		public IBaseData<bool> G_IN_Bonding_Visoion_Sucess { get; }
		internal bool ref_G_IN_Bonding_Visoion_Sucess = new bool();

		/// <summary>
		/// Name from PLC:G_IN_WAF_LOAD_Start
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003571)
		/// Size: 1
		public IBaseData<bool> G_IN_WAF_LOAD_Start { get; }
		internal bool ref_G_IN_WAF_LOAD_Start = new bool();

		/// <summary>
		/// Name from PLC:G_IN_WAF_Unload_Start
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003572)
		/// Size: 1
		public IBaseData<bool> G_IN_WAF_Unload_Start { get; }
		internal bool ref_G_IN_WAF_Unload_Start = new bool();

		/// <summary>
		/// Name from PLC:G_IN_bWLU_Start
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003573)
		/// Size: 1
		public IBaseData<bool> G_IN_bWLU_Start { get; }
		internal bool ref_G_IN_bWLU_Start = new bool();

		/// <summary>
		/// Name from PLC:G_IN_bWLU_Home
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003574)
		/// Size: 1
		public IBaseData<bool> G_IN_bWLU_Home { get; }
		internal bool ref_G_IN_bWLU_Home = new bool();

		/// <summary>
		/// Name from PLC:G_IN_bWLU_Table_Receive_Ready
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003575)
		/// Size: 1
		public IBaseData<bool> G_IN_bWLU_Table_Receive_Ready { get; }
		internal bool ref_G_IN_bWLU_Table_Receive_Ready = new bool();

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
