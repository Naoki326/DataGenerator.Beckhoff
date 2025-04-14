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
	/// Name from PLC:GVL_Alarm_Error
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_Alarm_ErrorWrapper
	{

		/// <summary>
		/// Name from PLC:Max_SYS_AlarmNum
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177664)
		/// Size: 2
		public IBaseData<short> Max_SYS_AlarmNum { get; }
		internal short ref_Max_SYS_AlarmNum = new short();

		/// <summary>
		/// Name from PLC:Max_IMH_AlarmNum
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177666)
		/// Size: 2
		public IBaseData<short> Max_IMH_AlarmNum { get; }
		internal short ref_Max_IMH_AlarmNum = new short();

		/// <summary>
		/// Name from PLC:Max_OMH_AlarmNum
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177668)
		/// Size: 2
		public IBaseData<short> Max_OMH_AlarmNum { get; }
		internal short ref_Max_OMH_AlarmNum = new short();

		/// <summary>
		/// Name from PLC:Max_FSU_AlarmNum
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177670)
		/// Size: 2
		public IBaseData<short> Max_FSU_AlarmNum { get; }
		internal short ref_Max_FSU_AlarmNum = new short();
		public BeckhoffString<String81> Version;
		internal String81  ref_Version = new String81();

		public BeckhoffString<String81> LocalSystemTime;
		internal String81  ref_LocalSystemTime = new String81();


		/// <summary>
		/// Name from PLC:G_Manual_Alarm_Reset
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,1177834)
		/// Size: 1
		public IBaseData<bool> G_Manual_Alarm_Reset { get; }
		internal bool ref_G_Manual_Alarm_Reset = new bool();

		/// <summary>
		/// Name from PLC:G_Manual_Alarm_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177836)
		/// Size: 2
		public IBaseData<short> G_Manual_Alarm_Index { get; }
		internal short ref_G_Manual_Alarm_Index = new short();

		/// <summary>
		/// Name from PLC:G_M_MainPower_Signal_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177838)
		/// Size: 2
		public IBaseData<short> G_M_MainPower_Signal_Err { get; }
		internal short ref_G_M_MainPower_Signal_Err = new short();

		/// <summary>
		/// Name from PLC:G_M_Safety_Door_1_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177840)
		/// Size: 2
		public IBaseData<short> G_M_Safety_Door_1_Err { get; }
		internal short ref_G_M_Safety_Door_1_Err = new short();

		/// <summary>
		/// Name from PLC:G_M_Safety_Door_2_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177842)
		/// Size: 2
		public IBaseData<short> G_M_Safety_Door_2_Err { get; }
		internal short ref_G_M_Safety_Door_2_Err = new short();

		/// <summary>
		/// Name from PLC:G_M_Safety_Door_3_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177844)
		/// Size: 2
		public IBaseData<short> G_M_Safety_Door_3_Err { get; }
		internal short ref_G_M_Safety_Door_3_Err = new short();

		/// <summary>
		/// Name from PLC:I_IMH_ZM_PL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177846)
		/// Size: 2
		public IBaseData<short> I_IMH_ZM_PL_Err { get; }
		internal short ref_I_IMH_ZM_PL_Err = new short();

		/// <summary>
		/// Name from PLC:I_IMH_ZM_OL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177848)
		/// Size: 2
		public IBaseData<short> I_IMH_ZM_OL_Err { get; }
		internal short ref_I_IMH_ZM_OL_Err = new short();

		/// <summary>
		/// Name from PLC:I_IMH_ZM_NL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177850)
		/// Size: 2
		public IBaseData<short> I_IMH_ZM_NL_Err { get; }
		internal short ref_I_IMH_ZM_NL_Err = new short();

		/// <summary>
		/// Name from PLC:I_IMH_YM_PL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177852)
		/// Size: 2
		public IBaseData<short> I_IMH_YM_PL_Err { get; }
		internal short ref_I_IMH_YM_PL_Err = new short();

		/// <summary>
		/// Name from PLC:I_IMH_YM_NL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177854)
		/// Size: 2
		public IBaseData<short> I_IMH_YM_NL_Err { get; }
		internal short ref_I_IMH_YM_NL_Err = new short();

		/// <summary>
		/// Name from PLC:I_IMH_MPC_PL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177856)
		/// Size: 2
		public IBaseData<short> I_IMH_MPC_PL_Err { get; }
		internal short ref_I_IMH_MPC_PL_Err = new short();

		/// <summary>
		/// Name from PLC:I_IMH_MPC_NL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177858)
		/// Size: 2
		public IBaseData<short> I_IMH_MPC_NL_Err { get; }
		internal short ref_I_IMH_MPC_NL_Err = new short();

		/// <summary>
		/// Name from PLC:I_IMH_TCC_PL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177860)
		/// Size: 2
		public IBaseData<short> I_IMH_TCC_PL_Err { get; }
		internal short ref_I_IMH_TCC_PL_Err = new short();

		/// <summary>
		/// Name from PLC:I_IMH_TCC_NL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177862)
		/// Size: 2
		public IBaseData<short> I_IMH_TCC_NL_Err { get; }
		internal short ref_I_IMH_TCC_NL_Err = new short();

		/// <summary>
		/// Name from PLC:I_IMH_YMC_PL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177864)
		/// Size: 2
		public IBaseData<short> I_IMH_YMC_PL_Err { get; }
		internal short ref_I_IMH_YMC_PL_Err = new short();

		/// <summary>
		/// Name from PLC:I_IMH_YMC_NL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177866)
		/// Size: 2
		public IBaseData<short> I_IMH_YMC_NL_Err { get; }
		internal short ref_I_IMH_YMC_NL_Err = new short();

		/// <summary>
		/// Name from PLC:I_IMH_SPC_PL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177868)
		/// Size: 2
		public IBaseData<short> I_IMH_SPC_PL_Err { get; }
		internal short ref_I_IMH_SPC_PL_Err = new short();

		/// <summary>
		/// Name from PLC:I_IMH_SPC_NL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177870)
		/// Size: 2
		public IBaseData<short> I_IMH_SPC_NL_Err { get; }
		internal short ref_I_IMH_SPC_NL_Err = new short();

		/// <summary>
		/// Name from PLC:I_IMH_MAC_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177872)
		/// Size: 2
		public IBaseData<short> I_IMH_MAC_SR_Err { get; }
		internal short ref_I_IMH_MAC_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_IMH_MTD_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177874)
		/// Size: 2
		public IBaseData<short> I_IMH_MTD_SR_Err { get; }
		internal short ref_I_IMH_MTD_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_IMH_MPD_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177876)
		/// Size: 2
		public IBaseData<short> I_IMH_MPD_SR_Err { get; }
		internal short ref_I_IMH_MPD_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_IMH_FUD_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177878)
		/// Size: 2
		public IBaseData<short> I_IMH_FUD_SR_Err { get; }
		internal short ref_I_IMH_FUD_SR_Err = new short();

		/// <summary>
		/// Name from PLC:Q_IMH_LDF_SV_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177880)
		/// Size: 2
		public IBaseData<short> Q_IMH_LDF_SV_Err { get; }
		internal short ref_Q_IMH_LDF_SV_Err = new short();

		/// <summary>
		/// Name from PLC:Q_IMH_ZCM_SV_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177882)
		/// Size: 2
		public IBaseData<short> Q_IMH_ZCM_SV_Err { get; }
		internal short ref_Q_IMH_ZCM_SV_Err = new short();

		/// <summary>
		/// Name from PLC:Q_IMH_YCM_SV_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177884)
		/// Size: 2
		public IBaseData<short> Q_IMH_YCM_SV_Err { get; }
		internal short ref_Q_IMH_YCM_SV_Err = new short();

		/// <summary>
		/// Name from PLC:Q_IMH_SPC_SV_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177886)
		/// Size: 2
		public IBaseData<short> Q_IMH_SPC_SV_Err { get; }
		internal short ref_Q_IMH_SPC_SV_Err = new short();

		/// <summary>
		/// Name from PLC:Unit_IMH_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177888)
		/// Size: 2
		public IBaseData<short> Unit_IMH_Err { get; }
		internal short ref_Unit_IMH_Err = new short();

		/// <summary>
		/// Name from PLC:I_OMH_ZM_PL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177890)
		/// Size: 2
		public IBaseData<short> I_OMH_ZM_PL_Err { get; }
		internal short ref_I_OMH_ZM_PL_Err = new short();

		/// <summary>
		/// Name from PLC:I_OMH_ZM_OL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177892)
		/// Size: 2
		public IBaseData<short> I_OMH_ZM_OL_Err { get; }
		internal short ref_I_OMH_ZM_OL_Err = new short();

		/// <summary>
		/// Name from PLC:I_OMH_ZM_NL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177894)
		/// Size: 2
		public IBaseData<short> I_OMH_ZM_NL_Err { get; }
		internal short ref_I_OMH_ZM_NL_Err = new short();

		/// <summary>
		/// Name from PLC:I_OMH_YM_PL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177896)
		/// Size: 2
		public IBaseData<short> I_OMH_YM_PL_Err { get; }
		internal short ref_I_OMH_YM_PL_Err = new short();

		/// <summary>
		/// Name from PLC:I_OMH_YM_NL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177898)
		/// Size: 2
		public IBaseData<short> I_OMH_YM_NL_Err { get; }
		internal short ref_I_OMH_YM_NL_Err = new short();

		/// <summary>
		/// Name from PLC:I_OMH_MPC_PL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177900)
		/// Size: 2
		public IBaseData<short> I_OMH_MPC_PL_Err { get; }
		internal short ref_I_OMH_MPC_PL_Err = new short();

		/// <summary>
		/// Name from PLC:I_OMH_MPC_NL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177902)
		/// Size: 2
		public IBaseData<short> I_OMH_MPC_NL_Err { get; }
		internal short ref_I_OMH_MPC_NL_Err = new short();

		/// <summary>
		/// Name from PLC:I_OMH_TCC_PL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177904)
		/// Size: 2
		public IBaseData<short> I_OMH_TCC_PL_Err { get; }
		internal short ref_I_OMH_TCC_PL_Err = new short();

		/// <summary>
		/// Name from PLC:I_OMH_TCC_NL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177906)
		/// Size: 2
		public IBaseData<short> I_OMH_TCC_NL_Err { get; }
		internal short ref_I_OMH_TCC_NL_Err = new short();

		/// <summary>
		/// Name from PLC:I_OMH_YMC_PL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177908)
		/// Size: 2
		public IBaseData<short> I_OMH_YMC_PL_Err { get; }
		internal short ref_I_OMH_YMC_PL_Err = new short();

		/// <summary>
		/// Name from PLC:I_OMH_YMC_NL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177910)
		/// Size: 2
		public IBaseData<short> I_OMH_YMC_NL_Err { get; }
		internal short ref_I_OMH_YMC_NL_Err = new short();

		/// <summary>
		/// Name from PLC:I_OMH_MAC_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177912)
		/// Size: 2
		public IBaseData<short> I_OMH_MAC_SR_Err { get; }
		internal short ref_I_OMH_MAC_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_OMH_MTD_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177914)
		/// Size: 2
		public IBaseData<short> I_OMH_MTD_SR_Err { get; }
		internal short ref_I_OMH_MTD_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_OMH_MPD_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177916)
		/// Size: 2
		public IBaseData<short> I_OMH_MPD_SR_Err { get; }
		internal short ref_I_OMH_MPD_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_OMH_FUD_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177918)
		/// Size: 2
		public IBaseData<short> I_OMH_FUD_SR_Err { get; }
		internal short ref_I_OMH_FUD_SR_Err = new short();

		/// <summary>
		/// Name from PLC:OMH_AXIS_YM_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177920)
		/// Size: 2
		public IBaseData<short> OMH_AXIS_YM_Err { get; }
		internal short ref_OMH_AXIS_YM_Err = new short();

		/// <summary>
		/// Name from PLC:OMH_AXIS_ZM_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177922)
		/// Size: 2
		public IBaseData<short> OMH_AXIS_ZM_Err { get; }
		internal short ref_OMH_AXIS_ZM_Err = new short();

		/// <summary>
		/// Name from PLC:Q_OMH_LDF_SV_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177924)
		/// Size: 2
		public IBaseData<short> Q_OMH_LDF_SV_Err { get; }
		internal short ref_Q_OMH_LDF_SV_Err = new short();

		/// <summary>
		/// Name from PLC:Q_OMH_ZCM_SV_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177926)
		/// Size: 2
		public IBaseData<short> Q_OMH_ZCM_SV_Err { get; }
		internal short ref_Q_OMH_ZCM_SV_Err = new short();

		/// <summary>
		/// Name from PLC:Q_OMH_YCM_SV_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177928)
		/// Size: 2
		public IBaseData<short> Q_OMH_YCM_SV_Err { get; }
		internal short ref_Q_OMH_YCM_SV_Err = new short();

		/// <summary>
		/// Name from PLC:Unit_OMH_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177930)
		/// Size: 2
		public IBaseData<short> Unit_OMH_Err { get; }
		internal short ref_Unit_OMH_Err = new short();

		/// <summary>
		/// Name from PLC:FCU_Barcode_Read_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177932)
		/// Size: 2
		public IBaseData<short> FCU_Barcode_Read_Err { get; }
		internal short ref_FCU_Barcode_Read_Err = new short();

		/// <summary>
		/// Name from PLC:FCU_CDA_Inspect_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177934)
		/// Size: 2
		public IBaseData<short> FCU_CDA_Inspect_Err { get; }
		internal short ref_FCU_CDA_Inspect_Err = new short();

		/// <summary>
		/// Name from PLC:I_FIG_FIP_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177936)
		/// Size: 2
		public IBaseData<short> I_FIG_FIP_SR_Err { get; }
		internal short ref_I_FIG_FIP_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_FIG_SPD_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177938)
		/// Size: 2
		public IBaseData<short> I_FIG_SPD_SR_Err { get; }
		internal short ref_I_FIG_SPD_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_FIG_RVS_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177940)
		/// Size: 2
		public IBaseData<short> I_FIG_RVS_SR_Err { get; }
		internal short ref_I_FIG_RVS_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_FIG_ISP_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177942)
		/// Size: 2
		public IBaseData<short> I_FIG_ISP_SR_Err { get; }
		internal short ref_I_FIG_ISP_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_FIG_FOL_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177944)
		/// Size: 2
		public IBaseData<short> I_FIG_FOL_SR_Err { get; }
		internal short ref_I_FIG_FOL_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_FCU_SIP_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177946)
		/// Size: 2
		public IBaseData<short> I_FCU_SIP_SR_Err { get; }
		internal short ref_I_FCU_SIP_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_FCU_TRC_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177948)
		/// Size: 2
		public IBaseData<short> I_FCU_TRC_SR_Err { get; }
		internal short ref_I_FCU_TRC_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_FCU_TRR_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177950)
		/// Size: 2
		public IBaseData<short> I_FCU_TRR_SR_Err { get; }
		internal short ref_I_FCU_TRR_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_FSU_PST_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177952)
		/// Size: 2
		public IBaseData<short> I_FSU_PST_SR_Err { get; }
		internal short ref_I_FSU_PST_SR_Err = new short();

		/// <summary>
		/// Name from PLC:AI_FCU_RDV_SAI_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177954)
		/// Size: 2
		public IBaseData<short> AI_FCU_RDV_SAI_Err { get; }
		internal short ref_AI_FCU_RDV_SAI_Err = new short();

		/// <summary>
		/// Name from PLC:AI_FCU_RBV_SAI_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177956)
		/// Size: 2
		public IBaseData<short> AI_FCU_RBV_SAI_Err { get; }
		internal short ref_AI_FCU_RBV_SAI_Err = new short();

		/// <summary>
		/// Name from PLC:AI_FCU_PHT_SAI_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177958)
		/// Size: 2
		public IBaseData<short> AI_FCU_PHT_SAI_Err { get; }
		internal short ref_AI_FCU_PHT_SAI_Err = new short();

		/// <summary>
		/// Name from PLC:AI_FCU_HMZ_SAI_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177960)
		/// Size: 2
		public IBaseData<short> AI_FCU_HMZ_SAI_Err { get; }
		internal short ref_AI_FCU_HMZ_SAI_Err = new short();

		/// <summary>
		/// Name from PLC:Q_FCU_RDV_SV_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177962)
		/// Size: 2
		public IBaseData<short> Q_FCU_RDV_SV_Err { get; }
		internal short ref_Q_FCU_RDV_SV_Err = new short();

		/// <summary>
		/// Name from PLC:Q_FCU_RBV_SV_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177964)
		/// Size: 2
		public IBaseData<short> Q_FCU_RBV_SV_Err { get; }
		internal short ref_Q_FCU_RBV_SV_Err = new short();

		/// <summary>
		/// Name from PLC:Q_FCU_IFS_SV_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177966)
		/// Size: 2
		public IBaseData<short> Q_FCU_IFS_SV_Err { get; }
		internal short ref_Q_FCU_IFS_SV_Err = new short();

		/// <summary>
		/// Name from PLC:Q_FCU_IFO_SV_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177968)
		/// Size: 2
		public IBaseData<short> Q_FCU_IFO_SV_Err { get; }
		internal short ref_Q_FCU_IFO_SV_Err = new short();

		/// <summary>
		/// Name from PLC:Q_FCU_FGV_SV_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177970)
		/// Size: 2
		public IBaseData<short> Q_FCU_FGV_SV_Err { get; }
		internal short ref_Q_FCU_FGV_SV_Err = new short();

		/// <summary>
		/// Name from PLC:Q_FCU_FBV_SV_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177972)
		/// Size: 2
		public IBaseData<short> Q_FCU_FBV_SV_Err { get; }
		internal short ref_Q_FCU_FBV_SV_Err = new short();

		/// <summary>
		/// Name from PLC:I_FBU_TRC_SR1_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177974)
		/// Size: 2
		public IBaseData<short> I_FBU_TRC_SR1_Err { get; }
		internal short ref_I_FBU_TRC_SR1_Err = new short();

		/// <summary>
		/// Name from PLC:I_FBU_TRC_SR2_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177976)
		/// Size: 2
		public IBaseData<short> I_FBU_TRC_SR2_Err { get; }
		internal short ref_I_FBU_TRC_SR2_Err = new short();

		/// <summary>
		/// Name from PLC:I_FBU_NRA_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177978)
		/// Size: 2
		public IBaseData<short> I_FBU_NRA_SR_Err { get; }
		internal short ref_I_FBU_NRA_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_FBU_PRA_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177980)
		/// Size: 2
		public IBaseData<short> I_FBU_PRA_SR_Err { get; }
		internal short ref_I_FBU_PRA_SR_Err = new short();

		/// <summary>
		/// Name from PLC:AI_FBU_HRT_SAI_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177982)
		/// Size: 2
		public IBaseData<short> AI_FBU_HRT_SAI_Err { get; }
		internal short ref_AI_FBU_HRT_SAI_Err = new short();

		/// <summary>
		/// Name from PLC:Q_FBU_FGV_SV_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177984)
		/// Size: 2
		public IBaseData<short> Q_FBU_FGV_SV_Err { get; }
		internal short ref_Q_FBU_FGV_SV_Err = new short();

		/// <summary>
		/// Name from PLC:Q_FBU_FBV_SV_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177986)
		/// Size: 2
		public IBaseData<short> Q_FBU_FBV_SV_Err { get; }
		internal short ref_Q_FBU_FBV_SV_Err = new short();

		/// <summary>
		/// Name from PLC:I_FOU_AJC_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177988)
		/// Size: 2
		public IBaseData<short> I_FOU_AJC_SR_Err { get; }
		internal short ref_I_FOU_AJC_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_FOU_SOB_PL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177990)
		/// Size: 2
		public IBaseData<short> I_FOU_SOB_PL_Err { get; }
		internal short ref_I_FOU_SOB_PL_Err = new short();

		/// <summary>
		/// Name from PLC:I_FOU_SOB_NL_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177992)
		/// Size: 2
		public IBaseData<short> I_FOU_SOB_NL_Err { get; }
		internal short ref_I_FOU_SOB_NL_Err = new short();

		/// <summary>
		/// Name from PLC:Q_FOU_SOB_SV_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177994)
		/// Size: 2
		public IBaseData<short> Q_FOU_SOB_SV_Err { get; }
		internal short ref_Q_FOU_SOB_SV_Err = new short();

		/// <summary>
		/// Name from PLC:Unit_FSU_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177996)
		/// Size: 2
		public IBaseData<short> Unit_FSU_Err { get; }
		internal short ref_Unit_FSU_Err = new short();

		/// <summary>
		/// Name from PLC:I_WLU_FRI_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1177998)
		/// Size: 2
		public IBaseData<short> I_WLU_FRI_SR_Err { get; }
		internal short ref_I_WLU_FRI_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_WLU_RRI_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1178000)
		/// Size: 2
		public IBaseData<short> I_WLU_RRI_SR_Err { get; }
		internal short ref_I_WLU_RRI_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_WLU_FRO_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1178002)
		/// Size: 2
		public IBaseData<short> I_WLU_FRO_SR_Err { get; }
		internal short ref_I_WLU_FRO_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_WLU_RRO_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1178004)
		/// Size: 2
		public IBaseData<short> I_WLU_RRO_SR_Err { get; }
		internal short ref_I_WLU_RRO_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_WLU_WTS_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1178006)
		/// Size: 2
		public IBaseData<short> I_WLU_WTS_SR_Err { get; }
		internal short ref_I_WLU_WTS_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_WLU_WRS_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1178008)
		/// Size: 2
		public IBaseData<short> I_WLU_WRS_SR_Err { get; }
		internal short ref_I_WLU_WRS_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_WLU_WPD_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1178010)
		/// Size: 2
		public IBaseData<short> I_WLU_WPD_SR_Err { get; }
		internal short ref_I_WLU_WPD_SR_Err = new short();

		/// <summary>
		/// Name from PLC:I_WLU_WJS_SR_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1178012)
		/// Size: 2
		public IBaseData<short> I_WLU_WJS_SR_Err { get; }
		internal short ref_I_WLU_WJS_SR_Err = new short();

		/// <summary>
		/// Name from PLC:Q_WLU_CC_SV_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1178014)
		/// Size: 2
		public IBaseData<short> Q_WLU_CC_SV_Err { get; }
		internal short ref_Q_WLU_CC_SV_Err = new short();

		/// <summary>
		/// Name from PLC:Unit_WLU_Err
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1178016)
		/// Size: 2
		public IBaseData<short> Unit_WLU_Err { get; }
		internal short ref_Unit_WLU_Err = new short();

		/// <summary>
		/// Name from PLC:FaultEvents
		/// TypeName from PLC: ARRAY [1..800] OF Struct_FaultEvents
		/// (IndexGroup, IndexOffset): (16448,1178024)
		/// Size: 44800
		public IStructArray<Struct_FaultEvents800, Struct_FaultEventsWrapper, Struct_FaultEvents> FaultEvents { get; }
		internal Struct_FaultEvents800 ref_FaultEvents = new Struct_FaultEvents800();

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
