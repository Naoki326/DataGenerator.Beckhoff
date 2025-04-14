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
	/// Name from PLC:GVL_Unit
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_UnitWrapper
	{

		/// <summary>
		/// Name from PLC:G_MotionMode
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004728)
		/// Size: 1
		public IBaseData<bool> G_MotionMode { get; }
		internal bool ref_G_MotionMode = new bool();

		/// <summary>
		/// Name from PLC:G_SemiAuto
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004729)
		/// Size: 1
		public IBaseData<bool> G_SemiAuto { get; }
		internal bool ref_G_SemiAuto = new bool();

		/// <summary>
		/// Name from PLC:G_Axis_Manual_Home
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004730)
		/// Size: 1
		public IBaseData<bool> G_Axis_Manual_Home { get; }
		internal bool ref_G_Axis_Manual_Home = new bool();

		/// <summary>
		/// Name from PLC:G_I_MANUAL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004731)
		/// Size: 1
		public IBaseData<bool> G_I_MANUAL { get; }
		internal bool ref_G_I_MANUAL = new bool();

		/// <summary>
		/// Name from PLC:SystemStatus
		/// TypeName from PLC: DUT_Systemstate
		/// (IndexGroup, IndexOffset): (16448,2004732)
		/// Size: 10
		public DUT_SystemstateWrapper SystemStatus { get; }
		internal DUT_Systemstate ref_SystemStatus = new DUT_Systemstate();

		/// <summary>
		/// Name from PLC:G_I_AUTO_Button
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004742)
		/// Size: 1
		public IBaseData<bool> G_I_AUTO_Button { get; }
		internal bool ref_G_I_AUTO_Button = new bool();

		/// <summary>
		/// Name from PLC:G_I_SAFETY_DOOR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004752)
		/// Size: 1
		public IBaseData<bool> G_I_SAFETY_DOOR { get; }
		internal bool ref_G_I_SAFETY_DOOR = new bool();

		/// <summary>
		/// Name from PLC:G_CY_Selected
		/// TypeName from PLC: ARRAY [1..100] OF BOOL
		/// (IndexGroup, IndexOffset): (16448,2004753)
		/// Size: 100
		public IBaseArray<Bool100, bool> G_CY_Selected { get; }
		internal Bool100 ref_G_CY_Selected = new Bool100();

		/// <summary>
		/// Name from PLC:G_SR_Disenable
		/// TypeName from PLC: ARRAY [1..100] OF BOOL
		/// (IndexGroup, IndexOffset): (16448,2004853)
		/// Size: 100
		public IBaseArray<Bool100, bool> G_SR_Disenable { get; }
		internal Bool100 ref_G_SR_Disenable = new Bool100();

		/// <summary>
		/// Name from PLC:G_Auto_CY_Extend
		/// TypeName from PLC: ARRAY [1..100] OF BOOL
		/// (IndexGroup, IndexOffset): (16448,2004953)
		/// Size: 100
		public IBaseArray<Bool100, bool> G_Auto_CY_Extend { get; }
		internal Bool100 ref_G_Auto_CY_Extend = new Bool100();

		/// <summary>
		/// Name from PLC:G_Auto_CY_Retract
		/// TypeName from PLC: ARRAY [1..100] OF BOOL
		/// (IndexGroup, IndexOffset): (16448,2005053)
		/// Size: 100
		public IBaseArray<Bool100, bool> G_Auto_CY_Retract { get; }
		internal Bool100 ref_G_Auto_CY_Retract = new Bool100();

		/// <summary>
		/// Name from PLC:G_AllCell_Home_Done
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005153)
		/// Size: 1
		public IBaseData<bool> G_AllCell_Home_Done { get; }
		internal bool ref_G_AllCell_Home_Done = new bool();

		/// <summary>
		/// Name from PLC:G_LoadBufferStatus
		/// TypeName from PLC: DUT_BufferStatus
		/// (IndexGroup, IndexOffset): (16448,2005154)
		/// Size: 6
		public DUT_BufferStatusWrapper G_LoadBufferStatus { get; }
		internal DUT_BufferStatus ref_G_LoadBufferStatus = new DUT_BufferStatus();

		/// <summary>
		/// Name from PLC:G_AllAxis_Home_Done
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005160)
		/// Size: 1
		public IBaseData<bool> G_AllAxis_Home_Done { get; }
		internal bool ref_G_AllAxis_Home_Done = new bool();

		/// <summary>
		/// Name from PLC:G_AllValve_Home_Done
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005161)
		/// Size: 1
		public IBaseData<bool> G_AllValve_Home_Done { get; }
		internal bool ref_G_AllValve_Home_Done = new bool();

		/// <summary>
		/// Name from PLC:G_AutoAllowed
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005162)
		/// Size: 1
		public IBaseData<bool> G_AutoAllowed { get; }
		internal bool ref_G_AutoAllowed = new bool();

		/// <summary>
		/// Name from PLC:G_bDrive_Valve
		/// TypeName from PLC: ARRAY [1..50] OF BOOL
		/// (IndexGroup, IndexOffset): (16448,2005163)
		/// Size: 50
		public IBaseArray<Bool50, bool> G_bDrive_Valve { get; }
		internal Bool50 ref_G_bDrive_Valve = new Bool50();

		/// <summary>
		/// Name from PLC:G_bDrive_Sensor
		/// TypeName from PLC: ARRAY [1..50] OF BOOL
		/// (IndexGroup, IndexOffset): (16448,2005213)
		/// Size: 50
		public IBaseArray<Bool50, bool> G_bDrive_Sensor { get; }
		internal Bool50 ref_G_bDrive_Sensor = new Bool50();

		/// <summary>
		/// Name from PLC:G_bIMH_BackHome
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005263)
		/// Size: 1
		public IBaseData<bool> G_bIMH_BackHome { get; }
		internal bool ref_G_bIMH_BackHome = new bool();

		/// <summary>
		/// Name from PLC:G_IMH_AUTO_Step
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005264)
		/// Size: 2
		public IBaseData<short> G_IMH_AUTO_Step { get; }
		internal short ref_G_IMH_AUTO_Step = new short();

		/// <summary>
		/// Name from PLC:G_IMH_Manual_LoadCase_Step
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005266)
		/// Size: 2
		public IBaseData<short> G_IMH_Manual_LoadCase_Step { get; }
		internal short ref_G_IMH_Manual_LoadCase_Step = new short();

		/// <summary>
		/// Name from PLC:G_IMH_Set_Time
		/// TypeName from PLC: ARRAY [0..10] OF TIME
		/// (IndexGroup, IndexOffset): (16448,2005268)
		/// Size: 44
		public IBaseArray<UInt11, uint> G_IMH_Set_Time { get; }
		internal UInt11 ref_G_IMH_Set_Time = new UInt11();

		/// <summary>
		/// Name from PLC:G_IMH_Manual_UnLoadCase_Step
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005312)
		/// Size: 2
		public IBaseData<short> G_IMH_Manual_UnLoadCase_Step { get; }
		internal short ref_G_IMH_Manual_UnLoadCase_Step = new short();

		/// <summary>
		/// Name from PLC:G_IMH_Manual_BackHome_Step
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005314)
		/// Size: 2
		public IBaseData<short> G_IMH_Manual_BackHome_Step { get; }
		internal short ref_G_IMH_Manual_BackHome_Step = new short();

		/// <summary>
		/// Name from PLC:G_bIMH_Manual_UnLoad_Case
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005316)
		/// Size: 1
		public IBaseData<bool> G_bIMH_Manual_UnLoad_Case { get; }
		internal bool ref_G_bIMH_Manual_UnLoad_Case = new bool();

		/// <summary>
		/// Name from PLC:G_bIMH_Manual_Load_Case
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005317)
		/// Size: 1
		public IBaseData<bool> G_bIMH_Manual_Load_Case { get; }
		internal bool ref_G_bIMH_Manual_Load_Case = new bool();

		/// <summary>
		/// Name from PLC:G_bIMH_Auto_Load_Case
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005318)
		/// Size: 1
		public IBaseData<bool> G_bIMH_Auto_Load_Case { get; }
		internal bool ref_G_bIMH_Auto_Load_Case = new bool();

		/// <summary>
		/// Name from PLC:I_IMH_ZM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005319)
		/// Size: 1
		public IBaseData<bool> I_IMH_ZM_PL { get; }
		internal bool ref_I_IMH_ZM_PL = new bool();

		/// <summary>
		/// Name from PLC:G_IMH_Real_Pushed_Slot
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005320)
		/// Size: 2
		public IBaseData<short> G_IMH_Real_Pushed_Slot { get; }
		internal short ref_G_IMH_Real_Pushed_Slot = new short();

		/// <summary>
		/// Name from PLC:I_IMH_ZM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005322)
		/// Size: 1
		public IBaseData<bool> I_IMH_ZM_OL { get; }
		internal bool ref_I_IMH_ZM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_IMH_ZM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005323)
		/// Size: 1
		public IBaseData<bool> I_IMH_ZM_NL { get; }
		internal bool ref_I_IMH_ZM_NL = new bool();

		/// <summary>
		/// Name from PLC:I_IMH_YM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005324)
		/// Size: 1
		public IBaseData<bool> I_IMH_YM_PL { get; }
		internal bool ref_I_IMH_YM_PL = new bool();

		/// <summary>
		/// Name from PLC:I_IMH_YM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005325)
		/// Size: 1
		public IBaseData<bool> I_IMH_YM_OL { get; }
		internal bool ref_I_IMH_YM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_IMH_YM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005326)
		/// Size: 1
		public IBaseData<bool> I_IMH_YM_NL { get; }
		internal bool ref_I_IMH_YM_NL = new bool();

		/// <summary>
		/// Name from PLC:bAllowLoadEmptyMagazine
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005341)
		/// Size: 1
		public IBaseData<bool> bAllowLoadEmptyMagazine { get; }
		internal bool ref_bAllowLoadEmptyMagazine = new bool();

		/// <summary>
		/// Name from PLC:bLoadEmptyMagazineDone
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005342)
		/// Size: 1
		public IBaseData<bool> bLoadEmptyMagazineDone { get; }
		internal bool ref_bLoadEmptyMagazineDone = new bool();

		/// <summary>
		/// Name from PLC:bAllowLoadSubstrate
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005343)
		/// Size: 1
		public IBaseData<bool> bAllowLoadSubstrate { get; }
		internal bool ref_bAllowLoadSubstrate = new bool();

		/// <summary>
		/// Name from PLC:bLoadSubstrateDone
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005344)
		/// Size: 1
		public IBaseData<bool> bLoadSubstrateDone { get; }
		internal bool ref_bLoadSubstrateDone = new bool();

		/// <summary>
		/// Name from PLC:bAllowUnLoadCase
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005345)
		/// Size: 1
		public IBaseData<bool> bAllowUnLoadCase { get; }
		internal bool ref_bAllowUnLoadCase = new bool();

		/// <summary>
		/// Name from PLC:bUnLoadCaseDone
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005346)
		/// Size: 1
		public IBaseData<bool> bUnLoadCaseDone { get; }
		internal bool ref_bUnLoadCaseDone = new bool();

		/// <summary>
		/// Name from PLC:G_bOMH_BackHome
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005347)
		/// Size: 1
		public IBaseData<bool> G_bOMH_BackHome { get; }
		internal bool ref_G_bOMH_BackHome = new bool();

		/// <summary>
		/// Name from PLC:G_OMH_AUTO_Step
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005348)
		/// Size: 2
		public IBaseData<short> G_OMH_AUTO_Step { get; }
		internal short ref_G_OMH_AUTO_Step = new short();

		/// <summary>
		/// Name from PLC:G_OMH_AUTO_Run_Step
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005350)
		/// Size: 2
		public IBaseData<short> G_OMH_AUTO_Run_Step { get; }
		internal short ref_G_OMH_AUTO_Run_Step = new short();

		/// <summary>
		/// Name from PLC:G_OMH_Manual_BackHome_Step
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005352)
		/// Size: 2
		public IBaseData<short> G_OMH_Manual_BackHome_Step { get; }
		internal short ref_G_OMH_Manual_BackHome_Step = new short();

		/// <summary>
		/// Name from PLC:G_OMH_Manual_LoadCase_Step
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005354)
		/// Size: 2
		public IBaseData<short> G_OMH_Manual_LoadCase_Step { get; }
		internal short ref_G_OMH_Manual_LoadCase_Step = new short();

		/// <summary>
		/// Name from PLC:G_OMH_Manual_UnLoadCase_Step
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005356)
		/// Size: 2
		public IBaseData<short> G_OMH_Manual_UnLoadCase_Step { get; }
		internal short ref_G_OMH_Manual_UnLoadCase_Step = new short();

		/// <summary>
		/// Name from PLC:G_bOMH_Manual_UnLoad_Case
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005358)
		/// Size: 1
		public IBaseData<bool> G_bOMH_Manual_UnLoad_Case { get; }
		internal bool ref_G_bOMH_Manual_UnLoad_Case = new bool();

		/// <summary>
		/// Name from PLC:G_bOMH_Manual_Load_Case
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005359)
		/// Size: 1
		public IBaseData<bool> G_bOMH_Manual_Load_Case { get; }
		internal bool ref_G_bOMH_Manual_Load_Case = new bool();

		/// <summary>
		/// Name from PLC:G_bOMH_Auto_Loading_Case
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005360)
		/// Size: 1
		public IBaseData<bool> G_bOMH_Auto_Loading_Case { get; }
		internal bool ref_G_bOMH_Auto_Loading_Case = new bool();

		/// <summary>
		/// Name from PLC:I_OMH_ZM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005361)
		/// Size: 1
		public IBaseData<bool> I_OMH_ZM_PL { get; }
		internal bool ref_I_OMH_ZM_PL = new bool();

		/// <summary>
		/// Name from PLC:I_OMH_ZM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005362)
		/// Size: 1
		public IBaseData<bool> I_OMH_ZM_OL { get; }
		internal bool ref_I_OMH_ZM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_OMH_ZM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005363)
		/// Size: 1
		public IBaseData<bool> I_OMH_ZM_NL { get; }
		internal bool ref_I_OMH_ZM_NL = new bool();

		/// <summary>
		/// Name from PLC:I_OMH_YM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005364)
		/// Size: 1
		public IBaseData<bool> I_OMH_YM_PL { get; }
		internal bool ref_I_OMH_YM_PL = new bool();

		/// <summary>
		/// Name from PLC:I_OMH_YM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005365)
		/// Size: 1
		public IBaseData<bool> I_OMH_YM_OL { get; }
		internal bool ref_I_OMH_YM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_OMH_YM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005366)
		/// Size: 1
		public IBaseData<bool> I_OMH_YM_NL { get; }
		internal bool ref_I_OMH_YM_NL = new bool();

		/// <summary>
		/// Name from PLC:G_OMH_Ready_For_Recive_Substrate
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005377)
		/// Size: 1
		public IBaseData<bool> G_OMH_Ready_For_Recive_Substrate { get; }
		internal bool ref_G_OMH_Ready_For_Recive_Substrate = new bool();

		/// <summary>
		/// Name from PLC:G_FOG_Tranfer_Substrate_Moving
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005378)
		/// Size: 1
		public IBaseData<bool> G_FOG_Tranfer_Substrate_Moving { get; }
		internal bool ref_G_FOG_Tranfer_Substrate_Moving = new bool();

		/// <summary>
		/// Name from PLC:G_FOG_Tranfer_Substrate_Done
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005379)
		/// Size: 1
		public IBaseData<bool> G_FOG_Tranfer_Substrate_Done { get; }
		internal bool ref_G_FOG_Tranfer_Substrate_Done = new bool();

		/// <summary>
		/// Name from PLC:G_OMH_Receive_Number_Slot
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005380)
		/// Size: 2
		public IBaseData<short> G_OMH_Receive_Number_Slot { get; }
		internal short ref_G_OMH_Receive_Number_Slot = new short();

		/// <summary>
		/// Name from PLC:G_OMH_bAxis_AbsMove
		/// TypeName from PLC: ARRAY [1..20] OF BOOL
		/// (IndexGroup, IndexOffset): (16448,2005382)
		/// Size: 20
		public IBaseArray<Bool20, bool> G_OMH_bAxis_AbsMove { get; }
		internal Bool20 ref_G_OMH_bAxis_AbsMove = new Bool20();

		/// <summary>
		/// Name from PLC:G_OMH_bAxis_RelMove
		/// TypeName from PLC: ARRAY [1..20] OF BOOL
		/// (IndexGroup, IndexOffset): (16448,2005402)
		/// Size: 20
		public IBaseArray<Bool20, bool> G_OMH_bAxis_RelMove { get; }
		internal Bool20 ref_G_OMH_bAxis_RelMove = new Bool20();

		/// <summary>
		/// Name from PLC:G_FIG_Auto_Step
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005422)
		/// Size: 2
		public IBaseData<short> G_FIG_Auto_Step { get; }
		internal short ref_G_FIG_Auto_Step = new short();

		/// <summary>
		/// Name from PLC:G_FCU_Auto_Step
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005424)
		/// Size: 2
		public IBaseData<short> G_FCU_Auto_Step { get; }
		internal short ref_G_FCU_Auto_Step = new short();

		/// <summary>
		/// Name from PLC:G_FBU_Auto_Step
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005426)
		/// Size: 2
		public IBaseData<short> G_FBU_Auto_Step { get; }
		internal short ref_G_FBU_Auto_Step = new short();

		/// <summary>
		/// Name from PLC:G_FOG_Auto_Step
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005428)
		/// Size: 2
		public IBaseData<short> G_FOG_Auto_Step { get; }
		internal short ref_G_FOG_Auto_Step = new short();

		/// <summary>
		/// Name from PLC:G_FSU_BackHome_Step
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005430)
		/// Size: 2
		public IBaseData<short> G_FSU_BackHome_Step { get; }
		internal short ref_G_FSU_BackHome_Step = new short();

		/// <summary>
		/// Name from PLC:G_FSU_bBackHome
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005432)
		/// Size: 1
		public IBaseData<bool> G_FSU_bBackHome { get; }
		internal bool ref_G_FSU_bBackHome = new bool();

		/// <summary>
		/// Name from PLC:G_Manual_bMove_Base
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005433)
		/// Size: 1
		public IBaseData<bool> G_Manual_bMove_Base { get; }
		internal bool ref_G_Manual_bMove_Base = new bool();

		/// <summary>
		/// Name from PLC:G_Manual_Move_Base_Step
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005434)
		/// Size: 2
		public IBaseData<short> G_Manual_Move_Base_Step { get; }
		internal short ref_G_Manual_Move_Base_Step = new short();

		/// <summary>
		/// Name from PLC:G_FBU_bManual_BondBase
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005436)
		/// Size: 1
		public IBaseData<bool> G_FBU_bManual_BondBase { get; }
		internal bool ref_G_FBU_bManual_BondBase = new bool();

		/// <summary>
		/// Name from PLC:G_Preform_Clean_All_Done
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005468)
		/// Size: 1
		public IBaseData<bool> G_Preform_Clean_All_Done { get; }
		internal bool ref_G_Preform_Clean_All_Done = new bool();

		/// <summary>
		/// Name from PLC:G_CDA_Inspect_Sucessful
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005469)
		/// Size: 1
		public IBaseData<bool> G_CDA_Inspect_Sucessful { get; }
		internal bool ref_G_CDA_Inspect_Sucessful = new bool();

		/// <summary>
		/// Name from PLC:G_FOG_TransferBasr_Ready
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005499)
		/// Size: 1
		public IBaseData<bool> G_FOG_TransferBasr_Ready { get; }
		internal bool ref_G_FOG_TransferBasr_Ready = new bool();

		/// <summary>
		/// Name from PLC:G_Move_Base_Finished
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005506)
		/// Size: 1
		public IBaseData<bool> G_Move_Base_Finished { get; }
		internal bool ref_G_Move_Base_Finished = new bool();

		/// <summary>
		/// Name from PLC:G_bWLU_Home
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005525)
		/// Size: 1
		public IBaseData<bool> G_bWLU_Home { get; }
		internal bool ref_G_bWLU_Home = new bool();

		/// <summary>
		/// Name from PLC:G_bWLU_Manual_Load_WAF
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005526)
		/// Size: 1
		public IBaseData<bool> G_bWLU_Manual_Load_WAF { get; }
		internal bool ref_G_bWLU_Manual_Load_WAF = new bool();

		/// <summary>
		/// Name from PLC:G_bWLU_Manual_UnLoad_WAF
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2005527)
		/// Size: 1
		public IBaseData<bool> G_bWLU_Manual_UnLoad_WAF { get; }
		internal bool ref_G_bWLU_Manual_UnLoad_WAF = new bool();

		/// <summary>
		/// Name from PLC:G_WLU_Auto_STEP
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005528)
		/// Size: 2
		public IBaseData<short> G_WLU_Auto_STEP { get; }
		internal short ref_G_WLU_Auto_STEP = new short();

		/// <summary>
		/// Name from PLC:G_WLU_Home_STEP
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005530)
		/// Size: 2
		public IBaseData<short> G_WLU_Home_STEP { get; }
		internal short ref_G_WLU_Home_STEP = new short();

		/// <summary>
		/// Name from PLC:G_WLU_Manual_Load_STEP
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005532)
		/// Size: 2
		public IBaseData<short> G_WLU_Manual_Load_STEP { get; }
		internal short ref_G_WLU_Manual_Load_STEP = new short();

		/// <summary>
		/// Name from PLC:G_WLU_Manual_UnLoad_STEP
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2005534)
		/// Size: 2
		public IBaseData<short> G_WLU_Manual_UnLoad_STEP { get; }
		internal short ref_G_WLU_Manual_UnLoad_STEP = new short();

		/// <summary>
		/// Name from PLC:I_FCU_PHT_AI
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (61472,128000)
		/// Size: 4
		public IBaseData<int> I_FCU_PHT_AI { get; }
		internal int ref_I_FCU_PHT_AI = new int();

		/// <summary>
		/// Name from PLC:I_FCU_HCM_AI
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (61472,128002)
		/// Size: 4
		public IBaseData<int> I_FCU_HCM_AI { get; }
		internal int ref_I_FCU_HCM_AI = new int();

		/// <summary>
		/// Name from PLC:I_FCU_RDV_AI
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (61472,128004)
		/// Size: 4
		public IBaseData<int> I_FCU_RDV_AI { get; }
		internal int ref_I_FCU_RDV_AI = new int();

		/// <summary>
		/// Name from PLC:I_FBU_HTR_AI
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (61472,128006)
		/// Size: 4
		public IBaseData<int> I_FBU_HTR_AI { get; }
		internal int ref_I_FBU_HTR_AI = new int();

		/// <summary>
		/// Name from PLC:I_FBU_NPA_AI1
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (61472,128008)
		/// Size: 4
		public IBaseData<int> I_FBU_NPA_AI1 { get; }
		internal int ref_I_FBU_NPA_AI1 = new int();

		/// <summary>
		/// Name from PLC:I_FBU_NPA_AI2
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (61472,128010)
		/// Size: 4
		public IBaseData<int> I_FBU_NPA_AI2 { get; }
		internal int ref_I_FBU_NPA_AI2 = new int();

		/// <summary>
		/// Name from PLC:I_FBU_NPA_AI3
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (61472,128012)
		/// Size: 4
		public IBaseData<int> I_FBU_NPA_AI3 { get; }
		internal int ref_I_FBU_NPA_AI3 = new int();

		/// <summary>
		/// Name from PLC:G_I_START
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2004743)
		/// Size: 1
		public IBaseData<bool> G_I_START { get; }
		internal bool ref_G_I_START = new bool();

		/// <summary>
		/// Name from PLC:G_I_STOP
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2004744)
		/// Size: 1
		public IBaseData<bool> G_I_STOP { get; }
		internal bool ref_G_I_STOP = new bool();

		/// <summary>
		/// Name from PLC:G_I_HIGHSPEED
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2004745)
		/// Size: 1
		public IBaseData<bool> G_I_HIGHSPEED { get; }
		internal bool ref_G_I_HIGHSPEED = new bool();

		/// <summary>
		/// Name from PLC:G_I_UP
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2004746)
		/// Size: 1
		public IBaseData<bool> G_I_UP { get; }
		internal bool ref_G_I_UP = new bool();

		/// <summary>
		/// Name from PLC:G_I_DOWN
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2004747)
		/// Size: 1
		public IBaseData<bool> G_I_DOWN { get; }
		internal bool ref_G_I_DOWN = new bool();

		/// <summary>
		/// Name from PLC:G_I_LEFT
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2004748)
		/// Size: 1
		public IBaseData<bool> G_I_LEFT { get; }
		internal bool ref_G_I_LEFT = new bool();

		/// <summary>
		/// Name from PLC:G_I_RIGHT
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2004749)
		/// Size: 1
		public IBaseData<bool> G_I_RIGHT { get; }
		internal bool ref_G_I_RIGHT = new bool();

		/// <summary>
		/// Name from PLC:G_I_RESET
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2004750)
		/// Size: 1
		public IBaseData<bool> G_I_RESET { get; }
		internal bool ref_G_I_RESET = new bool();

		/// <summary>
		/// Name from PLC:G_I_SIMULATE
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2004751)
		/// Size: 1
		public IBaseData<bool> G_I_SIMULATE { get; }
		internal bool ref_G_I_SIMULATE = new bool();

		/// <summary>
		/// Name from PLC:I_IMH_LDF_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005327)
		/// Size: 1
		public IBaseData<bool> I_IMH_LDF_PL { get; }
		internal bool ref_I_IMH_LDF_PL = new bool();

		/// <summary>
		/// Name from PLC:I_IMH_LDF_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005328)
		/// Size: 1
		public IBaseData<bool> I_IMH_LDF_NL { get; }
		internal bool ref_I_IMH_LDF_NL = new bool();

		/// <summary>
		/// Name from PLC:I_IMH_ZC_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005329)
		/// Size: 1
		public IBaseData<bool> I_IMH_ZC_PL { get; }
		internal bool ref_I_IMH_ZC_PL = new bool();

		/// <summary>
		/// Name from PLC:I_IMH_SPC_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005330)
		/// Size: 1
		public IBaseData<bool> I_IMH_SPC_PL { get; }
		internal bool ref_I_IMH_SPC_PL = new bool();

		/// <summary>
		/// Name from PLC:I_IMH_SPC_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005331)
		/// Size: 1
		public IBaseData<bool> I_IMH_SPC_NL { get; }
		internal bool ref_I_IMH_SPC_NL = new bool();

		/// <summary>
		/// Name from PLC:I_IMH_SAC_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005332)
		/// Size: 1
		public IBaseData<bool> I_IMH_SAC_SR { get; }
		internal bool ref_I_IMH_SAC_SR = new bool();

		/// <summary>
		/// Name from PLC:I_IMH_SDD_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005333)
		/// Size: 1
		public IBaseData<bool> I_IMH_SDD_SR { get; }
		internal bool ref_I_IMH_SDD_SR = new bool();

		/// <summary>
		/// Name from PLC:I_IMH_MPD_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005334)
		/// Size: 1
		public IBaseData<bool> I_IMH_MPD_SR { get; }
		internal bool ref_I_IMH_MPD_SR = new bool();

		/// <summary>
		/// Name from PLC:I_IMH_MFD_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005335)
		/// Size: 1
		public IBaseData<bool> I_IMH_MFD_SR { get; }
		internal bool ref_I_IMH_MFD_SR = new bool();

		/// <summary>
		/// Name from PLC:I_OMH_LDF_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005367)
		/// Size: 1
		public IBaseData<bool> I_OMH_LDF_PL { get; }
		internal bool ref_I_OMH_LDF_PL = new bool();

		/// <summary>
		/// Name from PLC:I_OMH_LDF_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005368)
		/// Size: 1
		public IBaseData<bool> I_OMH_LDF_NL { get; }
		internal bool ref_I_OMH_LDF_NL = new bool();

		/// <summary>
		/// Name from PLC:I_OMH_ZC_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005369)
		/// Size: 1
		public IBaseData<bool> I_OMH_ZC_PL { get; }
		internal bool ref_I_OMH_ZC_PL = new bool();

		/// <summary>
		/// Name from PLC:I_OMH_SDD_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005370)
		/// Size: 1
		public IBaseData<bool> I_OMH_SDD_SR { get; }
		internal bool ref_I_OMH_SDD_SR = new bool();

		/// <summary>
		/// Name from PLC:I_OMH_MPD_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005371)
		/// Size: 1
		public IBaseData<bool> I_OMH_MPD_SR { get; }
		internal bool ref_I_OMH_MPD_SR = new bool();

		/// <summary>
		/// Name from PLC:I_OMH_MFD_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005372)
		/// Size: 1
		public IBaseData<bool> I_OMH_MFD_SR { get; }
		internal bool ref_I_OMH_MFD_SR = new bool();

		/// <summary>
		/// Name from PLC:I_FIG_SFP_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005437)
		/// Size: 1
		public IBaseData<bool> I_FIG_SFP_SR { get; }
		internal bool ref_I_FIG_SFP_SR = new bool();

		/// <summary>
		/// Name from PLC:I_FIG_SPD_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005438)
		/// Size: 1
		public IBaseData<bool> I_FIG_SPD_SR { get; }
		internal bool ref_I_FIG_SPD_SR = new bool();

		/// <summary>
		/// Name from PLC:I_FIG_RVS_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005439)
		/// Size: 1
		public IBaseData<bool> I_FIG_RVS_SR { get; }
		internal bool ref_I_FIG_RVS_SR = new bool();

		/// <summary>
		/// Name from PLC:I_FIG_IFO_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005440)
		/// Size: 1
		public IBaseData<bool> I_FIG_IFO_SR { get; }
		internal bool ref_I_FIG_IFO_SR = new bool();

		/// <summary>
		/// Name from PLC:I_FIG_CM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005441)
		/// Size: 1
		public IBaseData<bool> I_FIG_CM_OL { get; }
		internal bool ref_I_FIG_CM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_FIG_XM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005442)
		/// Size: 1
		public IBaseData<bool> I_FIG_XM_PL { get; }
		internal bool ref_I_FIG_XM_PL = new bool();

		/// <summary>
		/// Name from PLC:I_FIG_XM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005443)
		/// Size: 1
		public IBaseData<bool> I_FIG_XM_OL { get; }
		internal bool ref_I_FIG_XM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_FIG_XM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005444)
		/// Size: 1
		public IBaseData<bool> I_FIG_XM_NL { get; }
		internal bool ref_I_FIG_XM_NL = new bool();

		/// <summary>
		/// Name from PLC:I_FCU_SIP_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005446)
		/// Size: 1
		public IBaseData<bool> I_FCU_SIP_SR { get; }
		internal bool ref_I_FCU_SIP_SR = new bool();

		/// <summary>
		/// Name from PLC:I_FCU_TRC_SR1
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005447)
		/// Size: 1
		public IBaseData<bool> I_FCU_TRC_SR1 { get; }
		internal bool ref_I_FCU_TRC_SR1 = new bool();

		/// <summary>
		/// Name from PLC:I_FCU_TRC_SR2
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005448)
		/// Size: 1
		public IBaseData<bool> I_FCU_TRC_SR2 { get; }
		internal bool ref_I_FCU_TRC_SR2 = new bool();

		/// <summary>
		/// Name from PLC:I_FCU_PRA_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005449)
		/// Size: 1
		public IBaseData<bool> I_FCU_PRA_SR { get; }
		internal bool ref_I_FCU_PRA_SR = new bool();

		/// <summary>
		/// Name from PLC:I_FCU_NRA_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005450)
		/// Size: 1
		public IBaseData<bool> I_FCU_NRA_SR { get; }
		internal bool ref_I_FCU_NRA_SR = new bool();

		/// <summary>
		/// Name from PLC:I_FCU_LXM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005451)
		/// Size: 1
		public IBaseData<bool> I_FCU_LXM_PL { get; }
		internal bool ref_I_FCU_LXM_PL = new bool();

		/// <summary>
		/// Name from PLC:I_FCU_LXM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005452)
		/// Size: 1
		public IBaseData<bool> I_FCU_LXM_OL { get; }
		internal bool ref_I_FCU_LXM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_FCU_LXM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005453)
		/// Size: 1
		public IBaseData<bool> I_FCU_LXM_NL { get; }
		internal bool ref_I_FCU_LXM_NL = new bool();

		/// <summary>
		/// Name from PLC:I_FCU_CM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005454)
		/// Size: 1
		public IBaseData<bool> I_FCU_CM_OL { get; }
		internal bool ref_I_FCU_CM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_FCU_CDA_YM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005455)
		/// Size: 1
		public IBaseData<bool> I_FCU_CDA_YM_OL { get; }
		internal bool ref_I_FCU_CDA_YM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_FCU_CDA_ZM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005456)
		/// Size: 1
		public IBaseData<bool> I_FCU_CDA_ZM_PL { get; }
		internal bool ref_I_FCU_CDA_ZM_PL = new bool();

		/// <summary>
		/// Name from PLC:I_FCU_CDA_ZM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005457)
		/// Size: 1
		public IBaseData<bool> I_FCU_CDA_ZM_NL { get; }
		internal bool ref_I_FCU_CDA_ZM_NL = new bool();

		/// <summary>
		/// Name from PLC:I_FCU_PCM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005458)
		/// Size: 1
		public IBaseData<bool> I_FCU_PCM_OL { get; }
		internal bool ref_I_FCU_PCM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_FCU_SZM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005459)
		/// Size: 1
		public IBaseData<bool> I_FCU_SZM_PL { get; }
		internal bool ref_I_FCU_SZM_PL = new bool();

		/// <summary>
		/// Name from PLC:I_FCU_SZM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005460)
		/// Size: 1
		public IBaseData<bool> I_FCU_SZM_OL { get; }
		internal bool ref_I_FCU_SZM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_FCU_SZM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005461)
		/// Size: 1
		public IBaseData<bool> I_FCU_SZM_NL { get; }
		internal bool ref_I_FCU_SZM_NL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_UTC_SR1
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005470)
		/// Size: 1
		public IBaseData<bool> I_FBU_UTC_SR1 { get; }
		internal bool ref_I_FBU_UTC_SR1 = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_UTC_SR2
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005471)
		/// Size: 1
		public IBaseData<bool> I_FBU_UTC_SR2 { get; }
		internal bool ref_I_FBU_UTC_SR2 = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_BCM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005472)
		/// Size: 1
		public IBaseData<bool> I_FBU_BCM_OL { get; }
		internal bool ref_I_FBU_BCM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_BZ1M_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005473)
		/// Size: 1
		public IBaseData<bool> I_FBU_BZ1M_PL { get; }
		internal bool ref_I_FBU_BZ1M_PL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_BZ1M_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005474)
		/// Size: 1
		public IBaseData<bool> I_FBU_BZ1M_OL { get; }
		internal bool ref_I_FBU_BZ1M_OL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_BZ1M_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005475)
		/// Size: 1
		public IBaseData<bool> I_FBU_BZ1M_NL { get; }
		internal bool ref_I_FBU_BZ1M_NL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_BZ2M_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005476)
		/// Size: 1
		public IBaseData<bool> I_FBU_BZ2M_PL { get; }
		internal bool ref_I_FBU_BZ2M_PL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_BZ2M_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005477)
		/// Size: 1
		public IBaseData<bool> I_FBU_BZ2M_OL { get; }
		internal bool ref_I_FBU_BZ2M_OL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_BZ2M_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005478)
		/// Size: 1
		public IBaseData<bool> I_FBU_BZ2M_NL { get; }
		internal bool ref_I_FBU_BZ2M_NL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_LXM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005479)
		/// Size: 1
		public IBaseData<bool> I_FBU_LXM_PL { get; }
		internal bool ref_I_FBU_LXM_PL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_LXM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005480)
		/// Size: 1
		public IBaseData<bool> I_FBU_LXM_OL { get; }
		internal bool ref_I_FBU_LXM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_LXM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005481)
		/// Size: 1
		public IBaseData<bool> I_FBU_LXM_NL { get; }
		internal bool ref_I_FBU_LXM_NL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_CM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005482)
		/// Size: 1
		public IBaseData<bool> I_FBU_CM_OL { get; }
		internal bool ref_I_FBU_CM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_V_XM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005483)
		/// Size: 1
		public IBaseData<bool> I_FBU_V_XM_PL { get; }
		internal bool ref_I_FBU_V_XM_PL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_V_XM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005484)
		/// Size: 1
		public IBaseData<bool> I_FBU_V_XM_OL { get; }
		internal bool ref_I_FBU_V_XM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_V_XM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005485)
		/// Size: 1
		public IBaseData<bool> I_FBU_V_XM_NL { get; }
		internal bool ref_I_FBU_V_XM_NL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_V_YM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005486)
		/// Size: 1
		public IBaseData<bool> I_FBU_V_YM_PL { get; }
		internal bool ref_I_FBU_V_YM_PL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_V_YM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005487)
		/// Size: 1
		public IBaseData<bool> I_FBU_V_YM_OL { get; }
		internal bool ref_I_FBU_V_YM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_V_YM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005488)
		/// Size: 1
		public IBaseData<bool> I_FBU_V_YM_NL { get; }
		internal bool ref_I_FBU_V_YM_NL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_AZM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005489)
		/// Size: 1
		public IBaseData<bool> I_FBU_AZM_PL { get; }
		internal bool ref_I_FBU_AZM_PL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_AZM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005490)
		/// Size: 1
		public IBaseData<bool> I_FBU_AZM_OL { get; }
		internal bool ref_I_FBU_AZM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_AZM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005491)
		/// Size: 1
		public IBaseData<bool> I_FBU_AZM_NL { get; }
		internal bool ref_I_FBU_AZM_NL = new bool();

		/// <summary>
		/// Name from PLC:I_FBU_TWM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005492)
		/// Size: 1
		public IBaseData<bool> I_FBU_TWM_OL { get; }
		internal bool ref_I_FBU_TWM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_FOG_USS_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005501)
		/// Size: 1
		public IBaseData<bool> I_FOG_USS_PL { get; }
		internal bool ref_I_FOG_USS_PL = new bool();

		/// <summary>
		/// Name from PLC:I_FOG_LXM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005502)
		/// Size: 1
		public IBaseData<bool> I_FOG_LXM_PL { get; }
		internal bool ref_I_FOG_LXM_PL = new bool();

		/// <summary>
		/// Name from PLC:I_FOG_LXM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005503)
		/// Size: 1
		public IBaseData<bool> I_FOG_LXM_OL { get; }
		internal bool ref_I_FOG_LXM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_FOG_LXM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005504)
		/// Size: 1
		public IBaseData<bool> I_FOG_LXM_NL { get; }
		internal bool ref_I_FOG_LXM_NL = new bool();

		/// <summary>
		/// Name from PLC:I_FOG_ZM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005505)
		/// Size: 1
		public IBaseData<bool> I_FOG_ZM_OL { get; }
		internal bool ref_I_FOG_ZM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_WLU_FRI_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005507)
		/// Size: 1
		public IBaseData<bool> I_WLU_FRI_SR { get; }
		internal bool ref_I_WLU_FRI_SR = new bool();

		/// <summary>
		/// Name from PLC:I_WLU_RRI_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005508)
		/// Size: 1
		public IBaseData<bool> I_WLU_RRI_SR { get; }
		internal bool ref_I_WLU_RRI_SR = new bool();

		/// <summary>
		/// Name from PLC:I_WLU_FRO_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005509)
		/// Size: 1
		public IBaseData<bool> I_WLU_FRO_SR { get; }
		internal bool ref_I_WLU_FRO_SR = new bool();

		/// <summary>
		/// Name from PLC:I_WLU_RRO_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005510)
		/// Size: 1
		public IBaseData<bool> I_WLU_RRO_SR { get; }
		internal bool ref_I_WLU_RRO_SR = new bool();

		/// <summary>
		/// Name from PLC:I_WLU_WTS_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005511)
		/// Size: 1
		public IBaseData<bool> I_WLU_WTS_SR { get; }
		internal bool ref_I_WLU_WTS_SR = new bool();

		/// <summary>
		/// Name from PLC:I_WLU_WRS_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005512)
		/// Size: 1
		public IBaseData<bool> I_WLU_WRS_SR { get; }
		internal bool ref_I_WLU_WRS_SR = new bool();

		/// <summary>
		/// Name from PLC:I_WLU_WPD_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005513)
		/// Size: 1
		public IBaseData<bool> I_WLU_WPD_SR { get; }
		internal bool ref_I_WLU_WPD_SR = new bool();

		/// <summary>
		/// Name from PLC:I_WLU_WJS_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005514)
		/// Size: 1
		public IBaseData<bool> I_WLU_WJS_SR { get; }
		internal bool ref_I_WLU_WJS_SR = new bool();

		/// <summary>
		/// Name from PLC:I_WLU_CAP_SR1
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005515)
		/// Size: 1
		public IBaseData<bool> I_WLU_CAP_SR1 { get; }
		internal bool ref_I_WLU_CAP_SR1 = new bool();

		/// <summary>
		/// Name from PLC:I_WLU_CAP_SR2
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005516)
		/// Size: 1
		public IBaseData<bool> I_WLU_CAP_SR2 { get; }
		internal bool ref_I_WLU_CAP_SR2 = new bool();

		/// <summary>
		/// Name from PLC:I_WLU_ZM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005517)
		/// Size: 1
		public IBaseData<bool> I_WLU_ZM_PL { get; }
		internal bool ref_I_WLU_ZM_PL = new bool();

		/// <summary>
		/// Name from PLC:I_WLU_ZM_WL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005518)
		/// Size: 1
		public IBaseData<bool> I_WLU_ZM_WL { get; }
		internal bool ref_I_WLU_ZM_WL = new bool();

		/// <summary>
		/// Name from PLC:I_WLU_ZM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005519)
		/// Size: 1
		public IBaseData<bool> I_WLU_ZM_OL { get; }
		internal bool ref_I_WLU_ZM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_WLU_ZM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005520)
		/// Size: 1
		public IBaseData<bool> I_WLU_ZM_NL { get; }
		internal bool ref_I_WLU_ZM_NL = new bool();

		/// <summary>
		/// Name from PLC:I_WLU_XM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005521)
		/// Size: 1
		public IBaseData<bool> I_WLU_XM_PL { get; }
		internal bool ref_I_WLU_XM_PL = new bool();

		/// <summary>
		/// Name from PLC:I_WLU_XM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005522)
		/// Size: 1
		public IBaseData<bool> I_WLU_XM_OL { get; }
		internal bool ref_I_WLU_XM_OL = new bool();

		/// <summary>
		/// Name from PLC:I_WLU_XM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2005523)
		/// Size: 1
		public IBaseData<bool> I_WLU_XM_NL { get; }
		internal bool ref_I_WLU_XM_NL = new bool();

		/// <summary>
		/// Name from PLC:Q_IMH_LDF_SV
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005336)
		/// Size: 1
		public IBaseData<bool> Q_IMH_LDF_SV { get; }
		internal bool ref_Q_IMH_LDF_SV = new bool();

		/// <summary>
		/// Name from PLC:Q_IMH_ZC_SV
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005337)
		/// Size: 1
		public IBaseData<bool> Q_IMH_ZC_SV { get; }
		internal bool ref_Q_IMH_ZC_SV = new bool();

		/// <summary>
		/// Name from PLC:Q_IMH_ZC_SV2
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005338)
		/// Size: 1
		public IBaseData<bool> Q_IMH_ZC_SV2 { get; }
		internal bool ref_Q_IMH_ZC_SV2 = new bool();

		/// <summary>
		/// Name from PLC:Q_IMH_YC_SV
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005339)
		/// Size: 1
		public IBaseData<bool> Q_IMH_YC_SV { get; }
		internal bool ref_Q_IMH_YC_SV = new bool();

		/// <summary>
		/// Name from PLC:Q_IMH_SPC_SV
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005340)
		/// Size: 1
		public IBaseData<bool> Q_IMH_SPC_SV { get; }
		internal bool ref_Q_IMH_SPC_SV = new bool();

		/// <summary>
		/// Name from PLC:Q_OMH_LDF_SV
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005373)
		/// Size: 1
		public IBaseData<bool> Q_OMH_LDF_SV { get; }
		internal bool ref_Q_OMH_LDF_SV = new bool();

		/// <summary>
		/// Name from PLC:Q_OMH_ZC_SV
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005374)
		/// Size: 1
		public IBaseData<bool> Q_OMH_ZC_SV { get; }
		internal bool ref_Q_OMH_ZC_SV = new bool();

		/// <summary>
		/// Name from PLC:Q_OMH_ZC_SV2
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005375)
		/// Size: 1
		public IBaseData<bool> Q_OMH_ZC_SV2 { get; }
		internal bool ref_Q_OMH_ZC_SV2 = new bool();

		/// <summary>
		/// Name from PLC:Q_OMH_YC_SV
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005376)
		/// Size: 1
		public IBaseData<bool> Q_OMH_YC_SV { get; }
		internal bool ref_Q_OMH_YC_SV = new bool();

		/// <summary>
		/// Name from PLC:Q_FIG_IFS_SV
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005445)
		/// Size: 1
		public IBaseData<bool> Q_FIG_IFS_SV { get; }
		internal bool ref_Q_FIG_IFS_SV = new bool();

		/// <summary>
		/// Name from PLC:Q_FCU_RDV_SV
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005462)
		/// Size: 1
		public IBaseData<bool> Q_FCU_RDV_SV { get; }
		internal bool ref_Q_FCU_RDV_SV = new bool();

		/// <summary>
		/// Name from PLC:Q_FCU_RBV_SV
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005463)
		/// Size: 1
		public IBaseData<bool> Q_FCU_RBV_SV { get; }
		internal bool ref_Q_FCU_RBV_SV = new bool();

		/// <summary>
		/// Name from PLC:Q_FCU_IFS_SV
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005464)
		/// Size: 1
		public IBaseData<bool> Q_FCU_IFS_SV { get; }
		internal bool ref_Q_FCU_IFS_SV = new bool();

		/// <summary>
		/// Name from PLC:Q_FCU_IFO_SV
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005465)
		/// Size: 1
		public IBaseData<bool> Q_FCU_IFO_SV { get; }
		internal bool ref_Q_FCU_IFO_SV = new bool();

		/// <summary>
		/// Name from PLC:Q_FCU_SGV_SV
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005466)
		/// Size: 1
		public IBaseData<bool> Q_FCU_SGV_SV { get; }
		internal bool ref_Q_FCU_SGV_SV = new bool();

		/// <summary>
		/// Name from PLC:Q_FCU_SBV_SV
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005467)
		/// Size: 1
		public IBaseData<bool> Q_FCU_SBV_SV { get; }
		internal bool ref_Q_FCU_SBV_SV = new bool();

		/// <summary>
		/// Name from PLC:Q_FBU_SFG_SV1
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005493)
		/// Size: 1
		public IBaseData<bool> Q_FBU_SFG_SV1 { get; }
		internal bool ref_Q_FBU_SFG_SV1 = new bool();

		/// <summary>
		/// Name from PLC:Q_FBU_SFB_SV1
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005494)
		/// Size: 1
		public IBaseData<bool> Q_FBU_SFB_SV1 { get; }
		internal bool ref_Q_FBU_SFB_SV1 = new bool();

		/// <summary>
		/// Name from PLC:Q_FBU_SFG_SV2
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005495)
		/// Size: 1
		public IBaseData<bool> Q_FBU_SFG_SV2 { get; }
		internal bool ref_Q_FBU_SFG_SV2 = new bool();

		/// <summary>
		/// Name from PLC:Q_FBU_SFB_SV2
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005496)
		/// Size: 1
		public IBaseData<bool> Q_FBU_SFB_SV2 { get; }
		internal bool ref_Q_FBU_SFB_SV2 = new bool();

		/// <summary>
		/// Name from PLC:Q_FBU_SFG_SV3
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005497)
		/// Size: 1
		public IBaseData<bool> Q_FBU_SFG_SV3 { get; }
		internal bool ref_Q_FBU_SFG_SV3 = new bool();

		/// <summary>
		/// Name from PLC:Q_FBU_SFB_SV3
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005498)
		/// Size: 1
		public IBaseData<bool> Q_FBU_SFB_SV3 { get; }
		internal bool ref_Q_FBU_SFB_SV3 = new bool();

		/// <summary>
		/// Name from PLC:Q_FOG_USS_SV
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005500)
		/// Size: 1
		public IBaseData<bool> Q_FOG_USS_SV { get; }
		internal bool ref_Q_FOG_USS_SV = new bool();

		/// <summary>
		/// Name from PLC:Q_WLU_CC_SV
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61488,2005524)
		/// Size: 1
		public IBaseData<bool> Q_WLU_CC_SV { get; }
		internal bool ref_Q_WLU_CC_SV = new bool();

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
