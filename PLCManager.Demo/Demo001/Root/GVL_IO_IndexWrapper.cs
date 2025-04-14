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
	/// Name from PLC:GVL_IO_Index
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_IO_IndexWrapper
	{

		/// <summary>
		/// Name from PLC:MaxCYnum
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1178018)
		/// Size: 2
		public IBaseData<short> MaxCYnum { get; }
		internal short ref_MaxCYnum = new short();

		/// <summary>
		/// Name from PLC:MaxSRnum
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1178020)
		/// Size: 2
		public IBaseData<short> MaxSRnum { get; }
		internal short ref_MaxSRnum = new short();

		/// <summary>
		/// Name from PLC:SV_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1178022)
		/// Size: 2
		public IBaseData<short> SV_Index { get; }
		internal short ref_SV_Index = new short();

		/// <summary>
		/// Name from PLC:CY_Manual_CMD
		/// TypeName from PLC: ARRAY [1..100] OF DUT_CY_CMD
		/// (IndexGroup, IndexOffset): (16448,1222824)
		/// Size: 600
		public IStructArray<DUT_CY_CMD100, DUT_CY_CMDWrapper, DUT_CY_CMD> CY_Manual_CMD { get; }
		internal DUT_CY_CMD100 ref_CY_Manual_CMD = new DUT_CY_CMD100();

		/// <summary>
		/// Name from PLC:CY_AUTO_CMD
		/// TypeName from PLC: ARRAY [1..100] OF DUT_CY_CMD
		/// (IndexGroup, IndexOffset): (16448,1223424)
		/// Size: 600
		public IStructArray<DUT_CY_CMD100, DUT_CY_CMDWrapper, DUT_CY_CMD> CY_AUTO_CMD { get; }
		internal DUT_CY_CMD100 ref_CY_AUTO_CMD = new DUT_CY_CMD100();

		/// <summary>
		/// Name from PLC:CY_State
		/// TypeName from PLC: ARRAY [1..100] OF DUT_CY_STATE
		/// (IndexGroup, IndexOffset): (16448,1224024)
		/// Size: 300
		public IStructArray<DUT_CY_STATE100, DUT_CY_STATEWrapper, DUT_CY_STATE> CY_State { get; }
		internal DUT_CY_STATE100 ref_CY_State = new DUT_CY_STATE100();

		/// <summary>
		/// Name from PLC:SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224324)
		/// Size: 2
		public IBaseData<short> SR_Index { get; }
		internal short ref_SR_Index = new short();

		/// <summary>
		/// Name from PLC:SR_Manual_CMD
		/// TypeName from PLC: ARRAY [1..100] OF DUT_SR_CMD
		/// (IndexGroup, IndexOffset): (16448,1224326)
		/// Size: 200
		public IStructArray<DUT_SR_CMD100, DUT_SR_CMDWrapper, DUT_SR_CMD> SR_Manual_CMD { get; }
		internal DUT_SR_CMD100 ref_SR_Manual_CMD = new DUT_SR_CMD100();

		/// <summary>
		/// Name from PLC:SR_AUTO_CMD
		/// TypeName from PLC: ARRAY [1..100] OF DUT_SR_CMD
		/// (IndexGroup, IndexOffset): (16448,1224526)
		/// Size: 200
		public IStructArray<DUT_SR_CMD100, DUT_SR_CMDWrapper, DUT_SR_CMD> SR_AUTO_CMD { get; }
		internal DUT_SR_CMD100 ref_SR_AUTO_CMD = new DUT_SR_CMD100();

		/// <summary>
		/// Name from PLC:SR_State
		/// TypeName from PLC: ARRAY [1..100] OF DUT_SR_STATE
		/// (IndexGroup, IndexOffset): (16448,1224726)
		/// Size: 200
		public IStructArray<DUT_SR_STATE100, DUT_SR_STATEWrapper, DUT_SR_STATE> SR_State { get; }
		internal DUT_SR_STATE100 ref_SR_State = new DUT_SR_STATE100();

		/// <summary>
		/// Name from PLC:G_M_MainPower_Signal_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224926)
		/// Size: 2
		public IBaseData<short> G_M_MainPower_Signal_Index { get; }
		internal short ref_G_M_MainPower_Signal_Index = new short();

		/// <summary>
		/// Name from PLC:IMH_Z_Axis_Input
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,1224928)
		/// Size: 4
		public IBaseData<uint> IMH_Z_Axis_Input { get; }
		internal uint ref_IMH_Z_Axis_Input = new uint();

		/// <summary>
		/// Name from PLC:IMH_Y_Axis_Input
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,1224932)
		/// Size: 4
		public IBaseData<uint> IMH_Y_Axis_Input { get; }
		internal uint ref_IMH_Y_Axis_Input = new uint();

		/// <summary>
		/// Name from PLC:OMH_Z_Axis_Input
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,1224936)
		/// Size: 4
		public IBaseData<uint> OMH_Z_Axis_Input { get; }
		internal uint ref_OMH_Z_Axis_Input = new uint();

		/// <summary>
		/// Name from PLC:OMH_Y_Axis_Input
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,1224940)
		/// Size: 4
		public IBaseData<uint> OMH_Y_Axis_Input { get; }
		internal uint ref_OMH_Y_Axis_Input = new uint();

		/// <summary>
		/// Name from PLC:G_M_Safety_Door_1_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224944)
		/// Size: 2
		public IBaseData<short> G_M_Safety_Door_1_Index { get; }
		internal short ref_G_M_Safety_Door_1_Index = new short();

		/// <summary>
		/// Name from PLC:G_M_Safety_Door_2_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224946)
		/// Size: 2
		public IBaseData<short> G_M_Safety_Door_2_Index { get; }
		internal short ref_G_M_Safety_Door_2_Index = new short();

		/// <summary>
		/// Name from PLC:G_M_Safety_Door_3_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224948)
		/// Size: 2
		public IBaseData<short> G_M_Safety_Door_3_Index { get; }
		internal short ref_G_M_Safety_Door_3_Index = new short();

		/// <summary>
		/// Name from PLC:I_IMH_ZM_PL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224950)
		/// Size: 2
		public IBaseData<short> I_IMH_ZM_PL_Index { get; }
		internal short ref_I_IMH_ZM_PL_Index = new short();

		/// <summary>
		/// Name from PLC:I_IMH_ZM_OL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224952)
		/// Size: 2
		public IBaseData<short> I_IMH_ZM_OL_Index { get; }
		internal short ref_I_IMH_ZM_OL_Index = new short();

		/// <summary>
		/// Name from PLC:I_IMH_ZM_NL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224954)
		/// Size: 2
		public IBaseData<short> I_IMH_ZM_NL_Index { get; }
		internal short ref_I_IMH_ZM_NL_Index = new short();

		/// <summary>
		/// Name from PLC:I_IMH_YM_PL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224956)
		/// Size: 2
		public IBaseData<short> I_IMH_YM_PL_Index { get; }
		internal short ref_I_IMH_YM_PL_Index = new short();

		/// <summary>
		/// Name from PLC:I_IMH_YM_OL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224958)
		/// Size: 2
		public IBaseData<short> I_IMH_YM_OL_Index { get; }
		internal short ref_I_IMH_YM_OL_Index = new short();

		/// <summary>
		/// Name from PLC:I_IMH_YM_NL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224960)
		/// Size: 2
		public IBaseData<short> I_IMH_YM_NL_Index { get; }
		internal short ref_I_IMH_YM_NL_Index = new short();

		/// <summary>
		/// Name from PLC:I_IMH_LDF_PL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224962)
		/// Size: 2
		public IBaseData<short> I_IMH_LDF_PL_Index { get; }
		internal short ref_I_IMH_LDF_PL_Index = new short();

		/// <summary>
		/// Name from PLC:I_IMH_LDF_NL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224964)
		/// Size: 2
		public IBaseData<short> I_IMH_LDF_NL_Index { get; }
		internal short ref_I_IMH_LDF_NL_Index = new short();

		/// <summary>
		/// Name from PLC:I_IMH_ZC_PL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224966)
		/// Size: 2
		public IBaseData<short> I_IMH_ZC_PL_Index { get; }
		internal short ref_I_IMH_ZC_PL_Index = new short();

		/// <summary>
		/// Name from PLC:I_IMH_SPC_PL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224968)
		/// Size: 2
		public IBaseData<short> I_IMH_SPC_PL_Index { get; }
		internal short ref_I_IMH_SPC_PL_Index = new short();

		/// <summary>
		/// Name from PLC:I_IMH_SPC_NL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224970)
		/// Size: 2
		public IBaseData<short> I_IMH_SPC_NL_Index { get; }
		internal short ref_I_IMH_SPC_NL_Index = new short();

		/// <summary>
		/// Name from PLC:I_IMH_SAC_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224972)
		/// Size: 2
		public IBaseData<short> I_IMH_SAC_SR_Index { get; }
		internal short ref_I_IMH_SAC_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_IMH_SDD_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224974)
		/// Size: 2
		public IBaseData<short> I_IMH_SDD_SR_Index { get; }
		internal short ref_I_IMH_SDD_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_IMH_MPD_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224976)
		/// Size: 2
		public IBaseData<short> I_IMH_MPD_SR_Index { get; }
		internal short ref_I_IMH_MPD_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_IMH_MFD_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224978)
		/// Size: 2
		public IBaseData<short> I_IMH_MFD_SR_Index { get; }
		internal short ref_I_IMH_MFD_SR_Index = new short();

		/// <summary>
		/// Name from PLC:Q_IMH_LDF_SV_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224980)
		/// Size: 2
		public IBaseData<short> Q_IMH_LDF_SV_Index { get; }
		internal short ref_Q_IMH_LDF_SV_Index = new short();

		/// <summary>
		/// Name from PLC:Q_IMH_ZC_SV_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224982)
		/// Size: 2
		public IBaseData<short> Q_IMH_ZC_SV_Index { get; }
		internal short ref_Q_IMH_ZC_SV_Index = new short();

		/// <summary>
		/// Name from PLC:Q_IMH_YC_SV_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224984)
		/// Size: 2
		public IBaseData<short> Q_IMH_YC_SV_Index { get; }
		internal short ref_Q_IMH_YC_SV_Index = new short();

		/// <summary>
		/// Name from PLC:Q_IMH_SPC_SV_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224986)
		/// Size: 2
		public IBaseData<short> Q_IMH_SPC_SV_Index { get; }
		internal short ref_Q_IMH_SPC_SV_Index = new short();

		/// <summary>
		/// Name from PLC:I_OMH_ZM_PL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224988)
		/// Size: 2
		public IBaseData<short> I_OMH_ZM_PL_Index { get; }
		internal short ref_I_OMH_ZM_PL_Index = new short();

		/// <summary>
		/// Name from PLC:I_OMH_ZM_OL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224990)
		/// Size: 2
		public IBaseData<short> I_OMH_ZM_OL_Index { get; }
		internal short ref_I_OMH_ZM_OL_Index = new short();

		/// <summary>
		/// Name from PLC:I_OMH_ZM_NL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224992)
		/// Size: 2
		public IBaseData<short> I_OMH_ZM_NL_Index { get; }
		internal short ref_I_OMH_ZM_NL_Index = new short();

		/// <summary>
		/// Name from PLC:I_OMH_YM_PL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224994)
		/// Size: 2
		public IBaseData<short> I_OMH_YM_PL_Index { get; }
		internal short ref_I_OMH_YM_PL_Index = new short();

		/// <summary>
		/// Name from PLC:I_OMH_YM_OL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224996)
		/// Size: 2
		public IBaseData<short> I_OMH_YM_OL_Index { get; }
		internal short ref_I_OMH_YM_OL_Index = new short();

		/// <summary>
		/// Name from PLC:I_OMH_YM_NL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1224998)
		/// Size: 2
		public IBaseData<short> I_OMH_YM_NL_Index { get; }
		internal short ref_I_OMH_YM_NL_Index = new short();

		/// <summary>
		/// Name from PLC:I_OMH_LDF_PL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225000)
		/// Size: 2
		public IBaseData<short> I_OMH_LDF_PL_Index { get; }
		internal short ref_I_OMH_LDF_PL_Index = new short();

		/// <summary>
		/// Name from PLC:I_OMH_LDF_NL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225002)
		/// Size: 2
		public IBaseData<short> I_OMH_LDF_NL_Index { get; }
		internal short ref_I_OMH_LDF_NL_Index = new short();

		/// <summary>
		/// Name from PLC:I_OMH_ZC_PL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225004)
		/// Size: 2
		public IBaseData<short> I_OMH_ZC_PL_Index { get; }
		internal short ref_I_OMH_ZC_PL_Index = new short();

		/// <summary>
		/// Name from PLC:I_OMH_SDD_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225006)
		/// Size: 2
		public IBaseData<short> I_OMH_SDD_SR_Index { get; }
		internal short ref_I_OMH_SDD_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_OMH_MPD_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225008)
		/// Size: 2
		public IBaseData<short> I_OMH_MPD_SR_Index { get; }
		internal short ref_I_OMH_MPD_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_OMH_MFD_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225010)
		/// Size: 2
		public IBaseData<short> I_OMH_MFD_SR_Index { get; }
		internal short ref_I_OMH_MFD_SR_Index = new short();

		/// <summary>
		/// Name from PLC:Q_OMH_LDF_SV_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225012)
		/// Size: 2
		public IBaseData<short> Q_OMH_LDF_SV_Index { get; }
		internal short ref_Q_OMH_LDF_SV_Index = new short();

		/// <summary>
		/// Name from PLC:Q_OMH_ZC_SV_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225014)
		/// Size: 2
		public IBaseData<short> Q_OMH_ZC_SV_Index { get; }
		internal short ref_Q_OMH_ZC_SV_Index = new short();

		/// <summary>
		/// Name from PLC:Q_OMH_ZC_SV2_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225016)
		/// Size: 2
		public IBaseData<short> Q_OMH_ZC_SV2_Index { get; }
		internal short ref_Q_OMH_ZC_SV2_Index = new short();

		/// <summary>
		/// Name from PLC:Q_OMH_YC_SV_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225018)
		/// Size: 2
		public IBaseData<short> Q_OMH_YC_SV_Index { get; }
		internal short ref_Q_OMH_YC_SV_Index = new short();

		/// <summary>
		/// Name from PLC:I_FIG_SFP_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225020)
		/// Size: 2
		public IBaseData<short> I_FIG_SFP_SR_Index { get; }
		internal short ref_I_FIG_SFP_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_FIG_SPD_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225022)
		/// Size: 2
		public IBaseData<short> I_FIG_SPD_SR_Index { get; }
		internal short ref_I_FIG_SPD_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_FIG_RVS_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225024)
		/// Size: 2
		public IBaseData<short> I_FIG_RVS_SR_Index { get; }
		internal short ref_I_FIG_RVS_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_FIG_IFS_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225026)
		/// Size: 2
		public IBaseData<short> I_FIG_IFS_SR_Index { get; }
		internal short ref_I_FIG_IFS_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_FIG_IFO_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225028)
		/// Size: 2
		public IBaseData<short> I_FIG_IFO_SR_Index { get; }
		internal short ref_I_FIG_IFO_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_FIG_CM_OL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225030)
		/// Size: 2
		public IBaseData<short> I_FIG_CM_OL_Index { get; }
		internal short ref_I_FIG_CM_OL_Index = new short();

		/// <summary>
		/// Name from PLC:I_FIG_XM_PL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225032)
		/// Size: 2
		public IBaseData<short> I_FIG_XM_PL_Index { get; }
		internal short ref_I_FIG_XM_PL_Index = new short();

		/// <summary>
		/// Name from PLC:I_FIG_XM_OL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225034)
		/// Size: 2
		public IBaseData<short> I_FIG_XM_OL_Index { get; }
		internal short ref_I_FIG_XM_OL_Index = new short();

		/// <summary>
		/// Name from PLC:I_FIG_XM_NL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225036)
		/// Size: 2
		public IBaseData<short> I_FIG_XM_NL_Index { get; }
		internal short ref_I_FIG_XM_NL_Index = new short();

		/// <summary>
		/// Name from PLC:Q_FIG_IFS_SV_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225038)
		/// Size: 2
		public IBaseData<short> Q_FIG_IFS_SV_Index { get; }
		internal short ref_Q_FIG_IFS_SV_Index = new short();

		/// <summary>
		/// Name from PLC:I_FCU_SIP_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225040)
		/// Size: 2
		public IBaseData<short> I_FCU_SIP_SR_Index { get; }
		internal short ref_I_FCU_SIP_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_FCU_TRC_SR1_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225042)
		/// Size: 2
		public IBaseData<short> I_FCU_TRC_SR1_Index { get; }
		internal short ref_I_FCU_TRC_SR1_Index = new short();

		/// <summary>
		/// Name from PLC:I_FCU_TRC_SR2_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225044)
		/// Size: 2
		public IBaseData<short> I_FCU_TRC_SR2_Index { get; }
		internal short ref_I_FCU_TRC_SR2_Index = new short();

		/// <summary>
		/// Name from PLC:I_FCU_PRA_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225046)
		/// Size: 2
		public IBaseData<short> I_FCU_PRA_SR_Index { get; }
		internal short ref_I_FCU_PRA_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_FCU_NRA_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225048)
		/// Size: 2
		public IBaseData<short> I_FCU_NRA_SR_Index { get; }
		internal short ref_I_FCU_NRA_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_FCU_XM_PL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225050)
		/// Size: 2
		public IBaseData<short> I_FCU_XM_PL_Index { get; }
		internal short ref_I_FCU_XM_PL_Index = new short();

		/// <summary>
		/// Name from PLC:I_FCU_XM_OL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225052)
		/// Size: 2
		public IBaseData<short> I_FCU_XM_OL_Index { get; }
		internal short ref_I_FCU_XM_OL_Index = new short();

		/// <summary>
		/// Name from PLC:I_FCU_XM_NL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225054)
		/// Size: 2
		public IBaseData<short> I_FCU_XM_NL_Index { get; }
		internal short ref_I_FCU_XM_NL_Index = new short();

		/// <summary>
		/// Name from PLC:I_FCU_CM_OL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225056)
		/// Size: 2
		public IBaseData<short> I_FCU_CM_OL_Index { get; }
		internal short ref_I_FCU_CM_OL_Index = new short();

		/// <summary>
		/// Name from PLC:I_FCU_PCM_OL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225058)
		/// Size: 2
		public IBaseData<short> I_FCU_PCM_OL_Index { get; }
		internal short ref_I_FCU_PCM_OL_Index = new short();

		/// <summary>
		/// Name from PLC:I_FCU_SZM_PL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225060)
		/// Size: 2
		public IBaseData<short> I_FCU_SZM_PL_Index { get; }
		internal short ref_I_FCU_SZM_PL_Index = new short();

		/// <summary>
		/// Name from PLC:I_FCU_SZM_OL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225062)
		/// Size: 2
		public IBaseData<short> I_FCU_SZM_OL_Index { get; }
		internal short ref_I_FCU_SZM_OL_Index = new short();

		/// <summary>
		/// Name from PLC:I_FCU_SZM_NL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225064)
		/// Size: 2
		public IBaseData<short> I_FCU_SZM_NL_Index { get; }
		internal short ref_I_FCU_SZM_NL_Index = new short();

		/// <summary>
		/// Name from PLC:AI_FCU_PHT_SAI_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225066)
		/// Size: 2
		public IBaseData<short> AI_FCU_PHT_SAI_Index { get; }
		internal short ref_AI_FCU_PHT_SAI_Index = new short();

		/// <summary>
		/// Name from PLC:AI_FCU_HCM_SAI_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225068)
		/// Size: 2
		public IBaseData<short> AI_FCU_HCM_SAI_Index { get; }
		internal short ref_AI_FCU_HCM_SAI_Index = new short();

		/// <summary>
		/// Name from PLC:AI_FCU_RDV_SAI_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225070)
		/// Size: 2
		public IBaseData<short> AI_FCU_RDV_SAI_Index { get; }
		internal short ref_AI_FCU_RDV_SAI_Index = new short();

		/// <summary>
		/// Name from PLC:Q_FCU_RDV_SV_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225072)
		/// Size: 2
		public IBaseData<short> Q_FCU_RDV_SV_Index { get; }
		internal short ref_Q_FCU_RDV_SV_Index = new short();

		/// <summary>
		/// Name from PLC:Q_FCU_RBV_SV_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225074)
		/// Size: 2
		public IBaseData<short> Q_FCU_RBV_SV_Index { get; }
		internal short ref_Q_FCU_RBV_SV_Index = new short();

		/// <summary>
		/// Name from PLC:Q_FCU_IFS_SV_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225076)
		/// Size: 2
		public IBaseData<short> Q_FCU_IFS_SV_Index { get; }
		internal short ref_Q_FCU_IFS_SV_Index = new short();

		/// <summary>
		/// Name from PLC:Q_FCU_IFO_SV_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225078)
		/// Size: 2
		public IBaseData<short> Q_FCU_IFO_SV_Index { get; }
		internal short ref_Q_FCU_IFO_SV_Index = new short();

		/// <summary>
		/// Name from PLC:Q_FCU_SGV_SV_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225080)
		/// Size: 2
		public IBaseData<short> Q_FCU_SGV_SV_Index { get; }
		internal short ref_Q_FCU_SGV_SV_Index = new short();

		/// <summary>
		/// Name from PLC:Q_FCU_SBV_SV_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225082)
		/// Size: 2
		public IBaseData<short> Q_FCU_SBV_SV_Index { get; }
		internal short ref_Q_FCU_SBV_SV_Index = new short();

		/// <summary>
		/// Name from PLC:I_FBU_UTC_SR1_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225084)
		/// Size: 2
		public IBaseData<short> I_FBU_UTC_SR1_Index { get; }
		internal short ref_I_FBU_UTC_SR1_Index = new short();

		/// <summary>
		/// Name from PLC:I_FBU_UTC_SR2_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225086)
		/// Size: 2
		public IBaseData<short> I_FBU_UTC_SR2_Index { get; }
		internal short ref_I_FBU_UTC_SR2_Index = new short();

		/// <summary>
		/// Name from PLC:I_FBU_BCM_OL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225088)
		/// Size: 2
		public IBaseData<short> I_FBU_BCM_OL_Index { get; }
		internal short ref_I_FBU_BCM_OL_Index = new short();

		/// <summary>
		/// Name from PLC:I_FBU_BZ1M_PL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225090)
		/// Size: 2
		public IBaseData<short> I_FBU_BZ1M_PL_Index { get; }
		internal short ref_I_FBU_BZ1M_PL_Index = new short();

		/// <summary>
		/// Name from PLC:I_FBU_BZ1M_OL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225092)
		/// Size: 2
		public IBaseData<short> I_FBU_BZ1M_OL_Index { get; }
		internal short ref_I_FBU_BZ1M_OL_Index = new short();

		/// <summary>
		/// Name from PLC:I_FBU_BZ1M_NL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225094)
		/// Size: 2
		public IBaseData<short> I_FBU_BZ1M_NL_Index { get; }
		internal short ref_I_FBU_BZ1M_NL_Index = new short();

		/// <summary>
		/// Name from PLC:I_FBU_BZ2M_PL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225096)
		/// Size: 2
		public IBaseData<short> I_FBU_BZ2M_PL_Index { get; }
		internal short ref_I_FBU_BZ2M_PL_Index = new short();

		/// <summary>
		/// Name from PLC:I_FBU_BZ2M_OL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225098)
		/// Size: 2
		public IBaseData<short> I_FBU_BZ2M_OL_Index { get; }
		internal short ref_I_FBU_BZ2M_OL_Index = new short();

		/// <summary>
		/// Name from PLC:I_FBU_BZ2M_NL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225100)
		/// Size: 2
		public IBaseData<short> I_FBU_BZ2M_NL_Index { get; }
		internal short ref_I_FBU_BZ2M_NL_Index = new short();

		/// <summary>
		/// Name from PLC:AI_FBU_HTR_AI_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225102)
		/// Size: 2
		public IBaseData<short> AI_FBU_HTR_AI_Index { get; }
		internal short ref_AI_FBU_HTR_AI_Index = new short();

		/// <summary>
		/// Name from PLC:AI_FBU_NRA_AI1_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225104)
		/// Size: 2
		public IBaseData<short> AI_FBU_NRA_AI1_Index { get; }
		internal short ref_AI_FBU_NRA_AI1_Index = new short();

		/// <summary>
		/// Name from PLC:AI_FBU_NRA_AI2_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225106)
		/// Size: 2
		public IBaseData<short> AI_FBU_NRA_AI2_Index { get; }
		internal short ref_AI_FBU_NRA_AI2_Index = new short();

		/// <summary>
		/// Name from PLC:AI_FBU_NRA_AI3_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225108)
		/// Size: 2
		public IBaseData<short> AI_FBU_NRA_AI3_Index { get; }
		internal short ref_AI_FBU_NRA_AI3_Index = new short();

		/// <summary>
		/// Name from PLC:Q_FBU_SFG_SV1_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225110)
		/// Size: 2
		public IBaseData<short> Q_FBU_SFG_SV1_Index { get; }
		internal short ref_Q_FBU_SFG_SV1_Index = new short();

		/// <summary>
		/// Name from PLC:Q_FBU_SFB_SV1_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225112)
		/// Size: 2
		public IBaseData<short> Q_FBU_SFB_SV1_Index { get; }
		internal short ref_Q_FBU_SFB_SV1_Index = new short();

		/// <summary>
		/// Name from PLC:Q_FBU_SFG_SV2_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225114)
		/// Size: 2
		public IBaseData<short> Q_FBU_SFG_SV2_Index { get; }
		internal short ref_Q_FBU_SFG_SV2_Index = new short();

		/// <summary>
		/// Name from PLC:Q_FBU_SFB_SV2_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225116)
		/// Size: 2
		public IBaseData<short> Q_FBU_SFB_SV2_Index { get; }
		internal short ref_Q_FBU_SFB_SV2_Index = new short();

		/// <summary>
		/// Name from PLC:Q_FBU_SFG_SV3_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225118)
		/// Size: 2
		public IBaseData<short> Q_FBU_SFG_SV3_Index { get; }
		internal short ref_Q_FBU_SFG_SV3_Index = new short();

		/// <summary>
		/// Name from PLC:Q_FBU_SFB_SV3_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225120)
		/// Size: 2
		public IBaseData<short> Q_FBU_SFB_SV3_Index { get; }
		internal short ref_Q_FBU_SFB_SV3_Index = new short();

		/// <summary>
		/// Name from PLC:I_FOG_USS_PL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225122)
		/// Size: 2
		public IBaseData<short> I_FOG_USS_PL_Index { get; }
		internal short ref_I_FOG_USS_PL_Index = new short();

		/// <summary>
		/// Name from PLC:Q_FOG_USS_SV_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225124)
		/// Size: 2
		public IBaseData<short> Q_FOG_USS_SV_Index { get; }
		internal short ref_Q_FOG_USS_SV_Index = new short();

		/// <summary>
		/// Name from PLC:I_WLU_FRI_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225126)
		/// Size: 2
		public IBaseData<short> I_WLU_FRI_SR_Index { get; }
		internal short ref_I_WLU_FRI_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_WLU_RRI_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225128)
		/// Size: 2
		public IBaseData<short> I_WLU_RRI_SR_Index { get; }
		internal short ref_I_WLU_RRI_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_WLU_FRO_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225130)
		/// Size: 2
		public IBaseData<short> I_WLU_FRO_SR_Index { get; }
		internal short ref_I_WLU_FRO_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_WLU_RRO_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225132)
		/// Size: 2
		public IBaseData<short> I_WLU_RRO_SR_Index { get; }
		internal short ref_I_WLU_RRO_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_WLU_WPD_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225134)
		/// Size: 2
		public IBaseData<short> I_WLU_WPD_SR_Index { get; }
		internal short ref_I_WLU_WPD_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_WLU_WRS_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225136)
		/// Size: 2
		public IBaseData<short> I_WLU_WRS_SR_Index { get; }
		internal short ref_I_WLU_WRS_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_WLU_WJS_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225138)
		/// Size: 2
		public IBaseData<short> I_WLU_WJS_SR_Index { get; }
		internal short ref_I_WLU_WJS_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_WLU_WTS_SR_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225140)
		/// Size: 2
		public IBaseData<short> I_WLU_WTS_SR_Index { get; }
		internal short ref_I_WLU_WTS_SR_Index = new short();

		/// <summary>
		/// Name from PLC:I_WLU_CAP_SR1_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225142)
		/// Size: 2
		public IBaseData<short> I_WLU_CAP_SR1_Index { get; }
		internal short ref_I_WLU_CAP_SR1_Index = new short();

		/// <summary>
		/// Name from PLC:I_WLU_CAP_SR2_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225144)
		/// Size: 2
		public IBaseData<short> I_WLU_CAP_SR2_Index { get; }
		internal short ref_I_WLU_CAP_SR2_Index = new short();

		/// <summary>
		/// Name from PLC:I_WLU_ZM_PL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225146)
		/// Size: 2
		public IBaseData<short> I_WLU_ZM_PL_Index { get; }
		internal short ref_I_WLU_ZM_PL_Index = new short();

		/// <summary>
		/// Name from PLC:I_WLU_ZM_WL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225148)
		/// Size: 2
		public IBaseData<short> I_WLU_ZM_WL_Index { get; }
		internal short ref_I_WLU_ZM_WL_Index = new short();

		/// <summary>
		/// Name from PLC:I_WLU_ZM_OL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225150)
		/// Size: 2
		public IBaseData<short> I_WLU_ZM_OL_Index { get; }
		internal short ref_I_WLU_ZM_OL_Index = new short();

		/// <summary>
		/// Name from PLC:I_WLU_ZM_NL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225152)
		/// Size: 2
		public IBaseData<short> I_WLU_ZM_NL_Index { get; }
		internal short ref_I_WLU_ZM_NL_Index = new short();

		/// <summary>
		/// Name from PLC:I_WLU_XM_PL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225154)
		/// Size: 2
		public IBaseData<short> I_WLU_XM_PL_Index { get; }
		internal short ref_I_WLU_XM_PL_Index = new short();

		/// <summary>
		/// Name from PLC:I_WLU_XM_OL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225156)
		/// Size: 2
		public IBaseData<short> I_WLU_XM_OL_Index { get; }
		internal short ref_I_WLU_XM_OL_Index = new short();

		/// <summary>
		/// Name from PLC:I_WLU_XM_NL_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225158)
		/// Size: 2
		public IBaseData<short> I_WLU_XM_NL_Index { get; }
		internal short ref_I_WLU_XM_NL_Index = new short();

		/// <summary>
		/// Name from PLC:Q_WLU_CC_SV_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225160)
		/// Size: 2
		public IBaseData<short> Q_WLU_CC_SV_Index { get; }
		internal short ref_Q_WLU_CC_SV_Index = new short();

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
