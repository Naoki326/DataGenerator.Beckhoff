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
	/// Name from PLC:GVL_Unit
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_UnitWrapper : BaseData, IBaseData
	{
		public override IEnumerable<IBaseData> Children
		{
			get
			{
				yield return G_MotionMode;
				yield return G_SemiAuto;
				yield return G_Axis_Manual_Home;
				yield return G_I_MANUAL;
				yield return SystemStatus;
				yield return G_I_AUTO_Button;
				yield return G_I_SAFETY_DOOR;
				yield return G_CY_Selected;
				yield return G_SR_Disenable;
				yield return G_Auto_CY_Extend;
				yield return G_Auto_CY_Retract;
				yield return G_AllCell_Home_Done;
				yield return G_LoadBufferStatus;
				yield return G_AllAxis_Home_Done;
				yield return G_AllValve_Home_Done;
				yield return G_AutoAllowed;
				yield return G_bDrive_Valve;
				yield return G_bDrive_Sensor;
				yield return G_bIMH_BackHome;
				yield return G_IMH_AUTO_Step;
				yield return G_IMH_Manual_LoadCase_Step;
				yield return G_IMH_Set_Time;
				yield return G_IMH_Manual_UnLoadCase_Step;
				yield return G_IMH_Manual_BackHome_Step;
				yield return G_bIMH_Manual_UnLoad_Case;
				yield return G_bIMH_Manual_Load_Case;
				yield return G_bIMH_Auto_Load_Case;
				yield return I_IMH_ZM_PL;
				yield return G_IMH_Real_Pushed_Slot;
				yield return I_IMH_ZM_OL;
				yield return I_IMH_ZM_NL;
				yield return I_IMH_YM_PL;
				yield return I_IMH_YM_OL;
				yield return I_IMH_YM_NL;
				yield return bAllowLoadEmptyMagazine;
				yield return bLoadEmptyMagazineDone;
				yield return bAllowLoadSubstrate;
				yield return bLoadSubstrateDone;
				yield return bAllowUnLoadCase;
				yield return bUnLoadCaseDone;
				yield return G_bOMH_BackHome;
				yield return G_OMH_AUTO_Step;
				yield return G_OMH_AUTO_Run_Step;
				yield return G_OMH_Manual_BackHome_Step;
				yield return G_OMH_Manual_LoadCase_Step;
				yield return G_OMH_Manual_UnLoadCase_Step;
				yield return G_bOMH_Manual_UnLoad_Case;
				yield return G_bOMH_Manual_Load_Case;
				yield return G_bOMH_Auto_Loading_Case;
				yield return I_OMH_ZM_PL;
				yield return I_OMH_ZM_OL;
				yield return I_OMH_ZM_NL;
				yield return I_OMH_YM_PL;
				yield return I_OMH_YM_OL;
				yield return I_OMH_YM_NL;
				yield return G_OMH_Ready_For_Recive_Substrate;
				yield return G_FOG_Tranfer_Substrate_Moving;
				yield return G_FOG_Tranfer_Substrate_Done;
				yield return G_OMH_Receive_Number_Slot;
				yield return G_OMH_bAxis_AbsMove;
				yield return G_OMH_bAxis_RelMove;
				yield return G_FIG_Auto_Step;
				yield return G_FCU_Auto_Step;
				yield return G_FBU_Auto_Step;
				yield return G_FOG_Auto_Step;
				yield return G_FSU_BackHome_Step;
				yield return G_FSU_bBackHome;
				yield return G_Manual_bMove_Base;
				yield return G_Manual_Move_Base_Step;
				yield return G_FBU_bManual_BondBase;
				yield return G_Preform_Clean_All_Done;
				yield return G_CDA_Inspect_Sucessful;
				yield return G_FOG_TransferBasr_Ready;
				yield return G_Move_Base_Finished;
				yield return G_bWLU_Home;
				yield return G_bWLU_Manual_Load_WAF;
				yield return G_bWLU_Manual_UnLoad_WAF;
				yield return G_WLU_Auto_STEP;
				yield return G_WLU_Home_STEP;
				yield return G_WLU_Manual_Load_STEP;
				yield return G_WLU_Manual_UnLoad_STEP;
				yield return I_FCU_PHT_AI;
				yield return I_FCU_HCM_AI;
				yield return I_FCU_RDV_AI;
				yield return I_FBU_HTR_AI;
				yield return I_FBU_NPA_AI1;
				yield return I_FBU_NPA_AI2;
				yield return I_FBU_NPA_AI3;
				yield return G_I_START;
				yield return G_I_STOP;
				yield return G_I_HIGHSPEED;
				yield return G_I_UP;
				yield return G_I_DOWN;
				yield return G_I_LEFT;
				yield return G_I_RIGHT;
				yield return G_I_RESET;
				yield return G_I_SIMULATE;
				yield return I_IMH_LDF_PL;
				yield return I_IMH_LDF_NL;
				yield return I_IMH_ZC_PL;
				yield return I_IMH_SPC_PL;
				yield return I_IMH_SPC_NL;
				yield return I_IMH_SAC_SR;
				yield return I_IMH_SDD_SR;
				yield return I_IMH_MPD_SR;
				yield return I_IMH_MFD_SR;
				yield return I_OMH_LDF_PL;
				yield return I_OMH_LDF_NL;
				yield return I_OMH_ZC_PL;
				yield return I_OMH_SDD_SR;
				yield return I_OMH_MPD_SR;
				yield return I_OMH_MFD_SR;
				yield return I_FIG_SFP_SR;
				yield return I_FIG_SPD_SR;
				yield return I_FIG_RVS_SR;
				yield return I_FIG_IFO_SR;
				yield return I_FIG_CM_OL;
				yield return I_FIG_XM_PL;
				yield return I_FIG_XM_OL;
				yield return I_FIG_XM_NL;
				yield return I_FCU_SIP_SR;
				yield return I_FCU_TRC_SR1;
				yield return I_FCU_TRC_SR2;
				yield return I_FCU_PRA_SR;
				yield return I_FCU_NRA_SR;
				yield return I_FCU_LXM_PL;
				yield return I_FCU_LXM_OL;
				yield return I_FCU_LXM_NL;
				yield return I_FCU_CM_OL;
				yield return I_FCU_CDA_YM_OL;
				yield return I_FCU_CDA_ZM_PL;
				yield return I_FCU_CDA_ZM_NL;
				yield return I_FCU_PCM_OL;
				yield return I_FCU_SZM_PL;
				yield return I_FCU_SZM_OL;
				yield return I_FCU_SZM_NL;
				yield return I_FBU_UTC_SR1;
				yield return I_FBU_UTC_SR2;
				yield return I_FBU_BCM_OL;
				yield return I_FBU_BZ1M_PL;
				yield return I_FBU_BZ1M_OL;
				yield return I_FBU_BZ1M_NL;
				yield return I_FBU_BZ2M_PL;
				yield return I_FBU_BZ2M_OL;
				yield return I_FBU_BZ2M_NL;
				yield return I_FBU_LXM_PL;
				yield return I_FBU_LXM_OL;
				yield return I_FBU_LXM_NL;
				yield return I_FBU_CM_OL;
				yield return I_FBU_V_XM_PL;
				yield return I_FBU_V_XM_OL;
				yield return I_FBU_V_XM_NL;
				yield return I_FBU_V_YM_PL;
				yield return I_FBU_V_YM_OL;
				yield return I_FBU_V_YM_NL;
				yield return I_FBU_AZM_PL;
				yield return I_FBU_AZM_OL;
				yield return I_FBU_AZM_NL;
				yield return I_FBU_TWM_OL;
				yield return I_FOG_USS_PL;
				yield return I_FOG_LXM_PL;
				yield return I_FOG_LXM_OL;
				yield return I_FOG_LXM_NL;
				yield return I_FOG_ZM_OL;
				yield return I_WLU_FRI_SR;
				yield return I_WLU_RRI_SR;
				yield return I_WLU_FRO_SR;
				yield return I_WLU_RRO_SR;
				yield return I_WLU_WTS_SR;
				yield return I_WLU_WRS_SR;
				yield return I_WLU_WPD_SR;
				yield return I_WLU_WJS_SR;
				yield return I_WLU_CAP_SR1;
				yield return I_WLU_CAP_SR2;
				yield return I_WLU_ZM_PL;
				yield return I_WLU_ZM_WL;
				yield return I_WLU_ZM_OL;
				yield return I_WLU_ZM_NL;
				yield return I_WLU_XM_PL;
				yield return I_WLU_XM_OL;
				yield return I_WLU_XM_NL;
				yield return Q_IMH_LDF_SV;
				yield return Q_IMH_ZC_SV;
				yield return Q_IMH_ZC_SV2;
				yield return Q_IMH_YC_SV;
				yield return Q_IMH_SPC_SV;
				yield return Q_OMH_LDF_SV;
				yield return Q_OMH_ZC_SV;
				yield return Q_OMH_ZC_SV2;
				yield return Q_OMH_YC_SV;
				yield return Q_FIG_IFS_SV;
				yield return Q_FCU_RDV_SV;
				yield return Q_FCU_RBV_SV;
				yield return Q_FCU_IFS_SV;
				yield return Q_FCU_IFO_SV;
				yield return Q_FCU_SGV_SV;
				yield return Q_FCU_SBV_SV;
				yield return Q_FBU_SFG_SV1;
				yield return Q_FBU_SFB_SV1;
				yield return Q_FBU_SFG_SV2;
				yield return Q_FBU_SFB_SV2;
				yield return Q_FBU_SFG_SV3;
				yield return Q_FBU_SFB_SV3;
				yield return Q_FOG_USS_SV;
				yield return Q_WLU_CC_SV;
			}
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(G_MotionMode):
					return G_MotionMode;
				case nameof(G_SemiAuto):
					return G_SemiAuto;
				case nameof(G_Axis_Manual_Home):
					return G_Axis_Manual_Home;
				case nameof(G_I_MANUAL):
					return G_I_MANUAL;
				case nameof(SystemStatus):
					return SystemStatus;
				case nameof(G_I_AUTO_Button):
					return G_I_AUTO_Button;
				case nameof(G_I_SAFETY_DOOR):
					return G_I_SAFETY_DOOR;
				case nameof(G_CY_Selected):
					return G_CY_Selected;
				case nameof(G_SR_Disenable):
					return G_SR_Disenable;
				case nameof(G_Auto_CY_Extend):
					return G_Auto_CY_Extend;
				case nameof(G_Auto_CY_Retract):
					return G_Auto_CY_Retract;
				case nameof(G_AllCell_Home_Done):
					return G_AllCell_Home_Done;
				case nameof(G_LoadBufferStatus):
					return G_LoadBufferStatus;
				case nameof(G_AllAxis_Home_Done):
					return G_AllAxis_Home_Done;
				case nameof(G_AllValve_Home_Done):
					return G_AllValve_Home_Done;
				case nameof(G_AutoAllowed):
					return G_AutoAllowed;
				case nameof(G_bDrive_Valve):
					return G_bDrive_Valve;
				case nameof(G_bDrive_Sensor):
					return G_bDrive_Sensor;
				case nameof(G_bIMH_BackHome):
					return G_bIMH_BackHome;
				case nameof(G_IMH_AUTO_Step):
					return G_IMH_AUTO_Step;
				case nameof(G_IMH_Manual_LoadCase_Step):
					return G_IMH_Manual_LoadCase_Step;
				case nameof(G_IMH_Set_Time):
					return G_IMH_Set_Time;
				case nameof(G_IMH_Manual_UnLoadCase_Step):
					return G_IMH_Manual_UnLoadCase_Step;
				case nameof(G_IMH_Manual_BackHome_Step):
					return G_IMH_Manual_BackHome_Step;
				case nameof(G_bIMH_Manual_UnLoad_Case):
					return G_bIMH_Manual_UnLoad_Case;
				case nameof(G_bIMH_Manual_Load_Case):
					return G_bIMH_Manual_Load_Case;
				case nameof(G_bIMH_Auto_Load_Case):
					return G_bIMH_Auto_Load_Case;
				case nameof(I_IMH_ZM_PL):
					return I_IMH_ZM_PL;
				case nameof(G_IMH_Real_Pushed_Slot):
					return G_IMH_Real_Pushed_Slot;
				case nameof(I_IMH_ZM_OL):
					return I_IMH_ZM_OL;
				case nameof(I_IMH_ZM_NL):
					return I_IMH_ZM_NL;
				case nameof(I_IMH_YM_PL):
					return I_IMH_YM_PL;
				case nameof(I_IMH_YM_OL):
					return I_IMH_YM_OL;
				case nameof(I_IMH_YM_NL):
					return I_IMH_YM_NL;
				case nameof(bAllowLoadEmptyMagazine):
					return bAllowLoadEmptyMagazine;
				case nameof(bLoadEmptyMagazineDone):
					return bLoadEmptyMagazineDone;
				case nameof(bAllowLoadSubstrate):
					return bAllowLoadSubstrate;
				case nameof(bLoadSubstrateDone):
					return bLoadSubstrateDone;
				case nameof(bAllowUnLoadCase):
					return bAllowUnLoadCase;
				case nameof(bUnLoadCaseDone):
					return bUnLoadCaseDone;
				case nameof(G_bOMH_BackHome):
					return G_bOMH_BackHome;
				case nameof(G_OMH_AUTO_Step):
					return G_OMH_AUTO_Step;
				case nameof(G_OMH_AUTO_Run_Step):
					return G_OMH_AUTO_Run_Step;
				case nameof(G_OMH_Manual_BackHome_Step):
					return G_OMH_Manual_BackHome_Step;
				case nameof(G_OMH_Manual_LoadCase_Step):
					return G_OMH_Manual_LoadCase_Step;
				case nameof(G_OMH_Manual_UnLoadCase_Step):
					return G_OMH_Manual_UnLoadCase_Step;
				case nameof(G_bOMH_Manual_UnLoad_Case):
					return G_bOMH_Manual_UnLoad_Case;
				case nameof(G_bOMH_Manual_Load_Case):
					return G_bOMH_Manual_Load_Case;
				case nameof(G_bOMH_Auto_Loading_Case):
					return G_bOMH_Auto_Loading_Case;
				case nameof(I_OMH_ZM_PL):
					return I_OMH_ZM_PL;
				case nameof(I_OMH_ZM_OL):
					return I_OMH_ZM_OL;
				case nameof(I_OMH_ZM_NL):
					return I_OMH_ZM_NL;
				case nameof(I_OMH_YM_PL):
					return I_OMH_YM_PL;
				case nameof(I_OMH_YM_OL):
					return I_OMH_YM_OL;
				case nameof(I_OMH_YM_NL):
					return I_OMH_YM_NL;
				case nameof(G_OMH_Ready_For_Recive_Substrate):
					return G_OMH_Ready_For_Recive_Substrate;
				case nameof(G_FOG_Tranfer_Substrate_Moving):
					return G_FOG_Tranfer_Substrate_Moving;
				case nameof(G_FOG_Tranfer_Substrate_Done):
					return G_FOG_Tranfer_Substrate_Done;
				case nameof(G_OMH_Receive_Number_Slot):
					return G_OMH_Receive_Number_Slot;
				case nameof(G_OMH_bAxis_AbsMove):
					return G_OMH_bAxis_AbsMove;
				case nameof(G_OMH_bAxis_RelMove):
					return G_OMH_bAxis_RelMove;
				case nameof(G_FIG_Auto_Step):
					return G_FIG_Auto_Step;
				case nameof(G_FCU_Auto_Step):
					return G_FCU_Auto_Step;
				case nameof(G_FBU_Auto_Step):
					return G_FBU_Auto_Step;
				case nameof(G_FOG_Auto_Step):
					return G_FOG_Auto_Step;
				case nameof(G_FSU_BackHome_Step):
					return G_FSU_BackHome_Step;
				case nameof(G_FSU_bBackHome):
					return G_FSU_bBackHome;
				case nameof(G_Manual_bMove_Base):
					return G_Manual_bMove_Base;
				case nameof(G_Manual_Move_Base_Step):
					return G_Manual_Move_Base_Step;
				case nameof(G_FBU_bManual_BondBase):
					return G_FBU_bManual_BondBase;
				case nameof(G_Preform_Clean_All_Done):
					return G_Preform_Clean_All_Done;
				case nameof(G_CDA_Inspect_Sucessful):
					return G_CDA_Inspect_Sucessful;
				case nameof(G_FOG_TransferBasr_Ready):
					return G_FOG_TransferBasr_Ready;
				case nameof(G_Move_Base_Finished):
					return G_Move_Base_Finished;
				case nameof(G_bWLU_Home):
					return G_bWLU_Home;
				case nameof(G_bWLU_Manual_Load_WAF):
					return G_bWLU_Manual_Load_WAF;
				case nameof(G_bWLU_Manual_UnLoad_WAF):
					return G_bWLU_Manual_UnLoad_WAF;
				case nameof(G_WLU_Auto_STEP):
					return G_WLU_Auto_STEP;
				case nameof(G_WLU_Home_STEP):
					return G_WLU_Home_STEP;
				case nameof(G_WLU_Manual_Load_STEP):
					return G_WLU_Manual_Load_STEP;
				case nameof(G_WLU_Manual_UnLoad_STEP):
					return G_WLU_Manual_UnLoad_STEP;
				case nameof(I_FCU_PHT_AI):
					return I_FCU_PHT_AI;
				case nameof(I_FCU_HCM_AI):
					return I_FCU_HCM_AI;
				case nameof(I_FCU_RDV_AI):
					return I_FCU_RDV_AI;
				case nameof(I_FBU_HTR_AI):
					return I_FBU_HTR_AI;
				case nameof(I_FBU_NPA_AI1):
					return I_FBU_NPA_AI1;
				case nameof(I_FBU_NPA_AI2):
					return I_FBU_NPA_AI2;
				case nameof(I_FBU_NPA_AI3):
					return I_FBU_NPA_AI3;
				case nameof(G_I_START):
					return G_I_START;
				case nameof(G_I_STOP):
					return G_I_STOP;
				case nameof(G_I_HIGHSPEED):
					return G_I_HIGHSPEED;
				case nameof(G_I_UP):
					return G_I_UP;
				case nameof(G_I_DOWN):
					return G_I_DOWN;
				case nameof(G_I_LEFT):
					return G_I_LEFT;
				case nameof(G_I_RIGHT):
					return G_I_RIGHT;
				case nameof(G_I_RESET):
					return G_I_RESET;
				case nameof(G_I_SIMULATE):
					return G_I_SIMULATE;
				case nameof(I_IMH_LDF_PL):
					return I_IMH_LDF_PL;
				case nameof(I_IMH_LDF_NL):
					return I_IMH_LDF_NL;
				case nameof(I_IMH_ZC_PL):
					return I_IMH_ZC_PL;
				case nameof(I_IMH_SPC_PL):
					return I_IMH_SPC_PL;
				case nameof(I_IMH_SPC_NL):
					return I_IMH_SPC_NL;
				case nameof(I_IMH_SAC_SR):
					return I_IMH_SAC_SR;
				case nameof(I_IMH_SDD_SR):
					return I_IMH_SDD_SR;
				case nameof(I_IMH_MPD_SR):
					return I_IMH_MPD_SR;
				case nameof(I_IMH_MFD_SR):
					return I_IMH_MFD_SR;
				case nameof(I_OMH_LDF_PL):
					return I_OMH_LDF_PL;
				case nameof(I_OMH_LDF_NL):
					return I_OMH_LDF_NL;
				case nameof(I_OMH_ZC_PL):
					return I_OMH_ZC_PL;
				case nameof(I_OMH_SDD_SR):
					return I_OMH_SDD_SR;
				case nameof(I_OMH_MPD_SR):
					return I_OMH_MPD_SR;
				case nameof(I_OMH_MFD_SR):
					return I_OMH_MFD_SR;
				case nameof(I_FIG_SFP_SR):
					return I_FIG_SFP_SR;
				case nameof(I_FIG_SPD_SR):
					return I_FIG_SPD_SR;
				case nameof(I_FIG_RVS_SR):
					return I_FIG_RVS_SR;
				case nameof(I_FIG_IFO_SR):
					return I_FIG_IFO_SR;
				case nameof(I_FIG_CM_OL):
					return I_FIG_CM_OL;
				case nameof(I_FIG_XM_PL):
					return I_FIG_XM_PL;
				case nameof(I_FIG_XM_OL):
					return I_FIG_XM_OL;
				case nameof(I_FIG_XM_NL):
					return I_FIG_XM_NL;
				case nameof(I_FCU_SIP_SR):
					return I_FCU_SIP_SR;
				case nameof(I_FCU_TRC_SR1):
					return I_FCU_TRC_SR1;
				case nameof(I_FCU_TRC_SR2):
					return I_FCU_TRC_SR2;
				case nameof(I_FCU_PRA_SR):
					return I_FCU_PRA_SR;
				case nameof(I_FCU_NRA_SR):
					return I_FCU_NRA_SR;
				case nameof(I_FCU_LXM_PL):
					return I_FCU_LXM_PL;
				case nameof(I_FCU_LXM_OL):
					return I_FCU_LXM_OL;
				case nameof(I_FCU_LXM_NL):
					return I_FCU_LXM_NL;
				case nameof(I_FCU_CM_OL):
					return I_FCU_CM_OL;
				case nameof(I_FCU_CDA_YM_OL):
					return I_FCU_CDA_YM_OL;
				case nameof(I_FCU_CDA_ZM_PL):
					return I_FCU_CDA_ZM_PL;
				case nameof(I_FCU_CDA_ZM_NL):
					return I_FCU_CDA_ZM_NL;
				case nameof(I_FCU_PCM_OL):
					return I_FCU_PCM_OL;
				case nameof(I_FCU_SZM_PL):
					return I_FCU_SZM_PL;
				case nameof(I_FCU_SZM_OL):
					return I_FCU_SZM_OL;
				case nameof(I_FCU_SZM_NL):
					return I_FCU_SZM_NL;
				case nameof(I_FBU_UTC_SR1):
					return I_FBU_UTC_SR1;
				case nameof(I_FBU_UTC_SR2):
					return I_FBU_UTC_SR2;
				case nameof(I_FBU_BCM_OL):
					return I_FBU_BCM_OL;
				case nameof(I_FBU_BZ1M_PL):
					return I_FBU_BZ1M_PL;
				case nameof(I_FBU_BZ1M_OL):
					return I_FBU_BZ1M_OL;
				case nameof(I_FBU_BZ1M_NL):
					return I_FBU_BZ1M_NL;
				case nameof(I_FBU_BZ2M_PL):
					return I_FBU_BZ2M_PL;
				case nameof(I_FBU_BZ2M_OL):
					return I_FBU_BZ2M_OL;
				case nameof(I_FBU_BZ2M_NL):
					return I_FBU_BZ2M_NL;
				case nameof(I_FBU_LXM_PL):
					return I_FBU_LXM_PL;
				case nameof(I_FBU_LXM_OL):
					return I_FBU_LXM_OL;
				case nameof(I_FBU_LXM_NL):
					return I_FBU_LXM_NL;
				case nameof(I_FBU_CM_OL):
					return I_FBU_CM_OL;
				case nameof(I_FBU_V_XM_PL):
					return I_FBU_V_XM_PL;
				case nameof(I_FBU_V_XM_OL):
					return I_FBU_V_XM_OL;
				case nameof(I_FBU_V_XM_NL):
					return I_FBU_V_XM_NL;
				case nameof(I_FBU_V_YM_PL):
					return I_FBU_V_YM_PL;
				case nameof(I_FBU_V_YM_OL):
					return I_FBU_V_YM_OL;
				case nameof(I_FBU_V_YM_NL):
					return I_FBU_V_YM_NL;
				case nameof(I_FBU_AZM_PL):
					return I_FBU_AZM_PL;
				case nameof(I_FBU_AZM_OL):
					return I_FBU_AZM_OL;
				case nameof(I_FBU_AZM_NL):
					return I_FBU_AZM_NL;
				case nameof(I_FBU_TWM_OL):
					return I_FBU_TWM_OL;
				case nameof(I_FOG_USS_PL):
					return I_FOG_USS_PL;
				case nameof(I_FOG_LXM_PL):
					return I_FOG_LXM_PL;
				case nameof(I_FOG_LXM_OL):
					return I_FOG_LXM_OL;
				case nameof(I_FOG_LXM_NL):
					return I_FOG_LXM_NL;
				case nameof(I_FOG_ZM_OL):
					return I_FOG_ZM_OL;
				case nameof(I_WLU_FRI_SR):
					return I_WLU_FRI_SR;
				case nameof(I_WLU_RRI_SR):
					return I_WLU_RRI_SR;
				case nameof(I_WLU_FRO_SR):
					return I_WLU_FRO_SR;
				case nameof(I_WLU_RRO_SR):
					return I_WLU_RRO_SR;
				case nameof(I_WLU_WTS_SR):
					return I_WLU_WTS_SR;
				case nameof(I_WLU_WRS_SR):
					return I_WLU_WRS_SR;
				case nameof(I_WLU_WPD_SR):
					return I_WLU_WPD_SR;
				case nameof(I_WLU_WJS_SR):
					return I_WLU_WJS_SR;
				case nameof(I_WLU_CAP_SR1):
					return I_WLU_CAP_SR1;
				case nameof(I_WLU_CAP_SR2):
					return I_WLU_CAP_SR2;
				case nameof(I_WLU_ZM_PL):
					return I_WLU_ZM_PL;
				case nameof(I_WLU_ZM_WL):
					return I_WLU_ZM_WL;
				case nameof(I_WLU_ZM_OL):
					return I_WLU_ZM_OL;
				case nameof(I_WLU_ZM_NL):
					return I_WLU_ZM_NL;
				case nameof(I_WLU_XM_PL):
					return I_WLU_XM_PL;
				case nameof(I_WLU_XM_OL):
					return I_WLU_XM_OL;
				case nameof(I_WLU_XM_NL):
					return I_WLU_XM_NL;
				case nameof(Q_IMH_LDF_SV):
					return Q_IMH_LDF_SV;
				case nameof(Q_IMH_ZC_SV):
					return Q_IMH_ZC_SV;
				case nameof(Q_IMH_ZC_SV2):
					return Q_IMH_ZC_SV2;
				case nameof(Q_IMH_YC_SV):
					return Q_IMH_YC_SV;
				case nameof(Q_IMH_SPC_SV):
					return Q_IMH_SPC_SV;
				case nameof(Q_OMH_LDF_SV):
					return Q_OMH_LDF_SV;
				case nameof(Q_OMH_ZC_SV):
					return Q_OMH_ZC_SV;
				case nameof(Q_OMH_ZC_SV2):
					return Q_OMH_ZC_SV2;
				case nameof(Q_OMH_YC_SV):
					return Q_OMH_YC_SV;
				case nameof(Q_FIG_IFS_SV):
					return Q_FIG_IFS_SV;
				case nameof(Q_FCU_RDV_SV):
					return Q_FCU_RDV_SV;
				case nameof(Q_FCU_RBV_SV):
					return Q_FCU_RBV_SV;
				case nameof(Q_FCU_IFS_SV):
					return Q_FCU_IFS_SV;
				case nameof(Q_FCU_IFO_SV):
					return Q_FCU_IFO_SV;
				case nameof(Q_FCU_SGV_SV):
					return Q_FCU_SGV_SV;
				case nameof(Q_FCU_SBV_SV):
					return Q_FCU_SBV_SV;
				case nameof(Q_FBU_SFG_SV1):
					return Q_FBU_SFG_SV1;
				case nameof(Q_FBU_SFB_SV1):
					return Q_FBU_SFB_SV1;
				case nameof(Q_FBU_SFG_SV2):
					return Q_FBU_SFG_SV2;
				case nameof(Q_FBU_SFB_SV2):
					return Q_FBU_SFB_SV2;
				case nameof(Q_FBU_SFG_SV3):
					return Q_FBU_SFG_SV3;
				case nameof(Q_FBU_SFB_SV3):
					return Q_FBU_SFB_SV3;
				case nameof(Q_FOG_USS_SV):
					return Q_FOG_USS_SV;
				case nameof(Q_WLU_CC_SV):
					return Q_WLU_CC_SV;
			}
			throw new KeyNotFoundException(name);
		}

		private readonly AdsClient client;

		public GVL_UnitWrapper(AdsClient client)
		{
			this.client = client;

			G_MotionMode = new BeckhoffBool(this.GetG_MotionMode, client, 16448, 2004728){ Name = "G_MotionMode" };
			G_SemiAuto = new BeckhoffBool(this.GetG_SemiAuto, client, 16448, 2004729){ Name = "G_SemiAuto" };
			G_Axis_Manual_Home = new BeckhoffBool(this.GetG_Axis_Manual_Home, client, 16448, 2004730){ Name = "G_Axis_Manual_Home" };
			G_I_MANUAL = new BeckhoffBool(this.GetG_I_MANUAL, client, 16448, 2004731){ Name = "G_I_MANUAL" };
			SystemStatus = new DUT_SystemstateWrapper(this.GetSystemStatus, client, 16448, 2004732)
			{
				Name = "SystemStatus",
				AutoAllow = new BeckhoffBool(this.GetSystemStatus_Dot_AutoAllow, client, 16448, 2004732){ Name = "AutoAllow" },
				HomeRequest = new BeckhoffBool(this.GetSystemStatus_Dot_HomeRequest, client, 16448, 2004733){ Name = "HomeRequest" },
				HomeStep = new BeckhoffShort(this.GetSystemStatus_Dot_HomeStep, client, 16448, 2004734){ Name = "HomeStep" },
				HomeAllow = new BeckhoffBool(this.GetSystemStatus_Dot_HomeAllow, client, 16448, 2004736){ Name = "HomeAllow" },
				Homing = new BeckhoffBool(this.GetSystemStatus_Dot_Homing, client, 16448, 2004737){ Name = "Homing" },
				HomeFinished = new BeckhoffBool(this.GetSystemStatus_Dot_HomeFinished, client, 16448, 2004738){ Name = "HomeFinished" },
				AutoRun = new BeckhoffBool(this.GetSystemStatus_Dot_AutoRun, client, 16448, 2004739){ Name = "AutoRun" },
				Fault = new BeckhoffBool(this.GetSystemStatus_Dot_Fault, client, 16448, 2004740){ Name = "Fault" },
				OnlineTcpAlarm = new BeckhoffBool(this.GetSystemStatus_Dot_OnlineTcpAlarm, client, 16448, 2004741){ Name = "OnlineTcpAlarm" },
			};
			G_I_AUTO_Button = new BeckhoffBool(this.GetG_I_AUTO_Button, client, 16448, 2004742){ Name = "G_I_AUTO_Button" };
			G_I_SAFETY_DOOR = new BeckhoffBool(this.GetG_I_SAFETY_DOOR, client, 16448, 2004752){ Name = "G_I_SAFETY_DOOR" };
			G_CY_Selected = new BeckhoffBoolArray<Bool100>(this.GetG_CY_Selected, client, 16448, 2004753,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 2004753 ,2004754 ,2004755 ,2004756 ,2004757 ,2004758 ,2004759 ,2004760 ,2004761 ,2004762 ,2004763 ,2004764 ,2004765 ,2004766 ,2004767 ,2004768 ,2004769 ,2004770 ,2004771 ,2004772 ,2004773 ,2004774 ,2004775 ,2004776 ,2004777 ,2004778 ,2004779 ,2004780 ,2004781 ,2004782 ,2004783 ,2004784 ,2004785 ,2004786 ,2004787 ,2004788 ,2004789 ,2004790 ,2004791 ,2004792 ,2004793 ,2004794 ,2004795 ,2004796 ,2004797 ,2004798 ,2004799 ,2004800 ,2004801 ,2004802 ,2004803 ,2004804 ,2004805 ,2004806 ,2004807 ,2004808 ,2004809 ,2004810 ,2004811 ,2004812 ,2004813 ,2004814 ,2004815 ,2004816 ,2004817 ,2004818 ,2004819 ,2004820 ,2004821 ,2004822 ,2004823 ,2004824 ,2004825 ,2004826 ,2004827 ,2004828 ,2004829 ,2004830 ,2004831 ,2004832 ,2004833 ,2004834 ,2004835 ,2004836 ,2004837 ,2004838 ,2004839 ,2004840 ,2004841 ,2004842 ,2004843 ,2004844 ,2004845 ,2004846 ,2004847 ,2004848 ,2004849 ,2004850 ,2004851 ,2004852 , }, false){ Name = "G_CY_Selected" };
			G_SR_Disenable = new BeckhoffBoolArray<Bool100>(this.GetG_SR_Disenable, client, 16448, 2004853,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 2004853 ,2004854 ,2004855 ,2004856 ,2004857 ,2004858 ,2004859 ,2004860 ,2004861 ,2004862 ,2004863 ,2004864 ,2004865 ,2004866 ,2004867 ,2004868 ,2004869 ,2004870 ,2004871 ,2004872 ,2004873 ,2004874 ,2004875 ,2004876 ,2004877 ,2004878 ,2004879 ,2004880 ,2004881 ,2004882 ,2004883 ,2004884 ,2004885 ,2004886 ,2004887 ,2004888 ,2004889 ,2004890 ,2004891 ,2004892 ,2004893 ,2004894 ,2004895 ,2004896 ,2004897 ,2004898 ,2004899 ,2004900 ,2004901 ,2004902 ,2004903 ,2004904 ,2004905 ,2004906 ,2004907 ,2004908 ,2004909 ,2004910 ,2004911 ,2004912 ,2004913 ,2004914 ,2004915 ,2004916 ,2004917 ,2004918 ,2004919 ,2004920 ,2004921 ,2004922 ,2004923 ,2004924 ,2004925 ,2004926 ,2004927 ,2004928 ,2004929 ,2004930 ,2004931 ,2004932 ,2004933 ,2004934 ,2004935 ,2004936 ,2004937 ,2004938 ,2004939 ,2004940 ,2004941 ,2004942 ,2004943 ,2004944 ,2004945 ,2004946 ,2004947 ,2004948 ,2004949 ,2004950 ,2004951 ,2004952 , }, false){ Name = "G_SR_Disenable" };
			G_Auto_CY_Extend = new BeckhoffBoolArray<Bool100>(this.GetG_Auto_CY_Extend, client, 16448, 2004953,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 2004953 ,2004954 ,2004955 ,2004956 ,2004957 ,2004958 ,2004959 ,2004960 ,2004961 ,2004962 ,2004963 ,2004964 ,2004965 ,2004966 ,2004967 ,2004968 ,2004969 ,2004970 ,2004971 ,2004972 ,2004973 ,2004974 ,2004975 ,2004976 ,2004977 ,2004978 ,2004979 ,2004980 ,2004981 ,2004982 ,2004983 ,2004984 ,2004985 ,2004986 ,2004987 ,2004988 ,2004989 ,2004990 ,2004991 ,2004992 ,2004993 ,2004994 ,2004995 ,2004996 ,2004997 ,2004998 ,2004999 ,2005000 ,2005001 ,2005002 ,2005003 ,2005004 ,2005005 ,2005006 ,2005007 ,2005008 ,2005009 ,2005010 ,2005011 ,2005012 ,2005013 ,2005014 ,2005015 ,2005016 ,2005017 ,2005018 ,2005019 ,2005020 ,2005021 ,2005022 ,2005023 ,2005024 ,2005025 ,2005026 ,2005027 ,2005028 ,2005029 ,2005030 ,2005031 ,2005032 ,2005033 ,2005034 ,2005035 ,2005036 ,2005037 ,2005038 ,2005039 ,2005040 ,2005041 ,2005042 ,2005043 ,2005044 ,2005045 ,2005046 ,2005047 ,2005048 ,2005049 ,2005050 ,2005051 ,2005052 , }, false){ Name = "G_Auto_CY_Extend" };
			G_Auto_CY_Retract = new BeckhoffBoolArray<Bool100>(this.GetG_Auto_CY_Retract, client, 16448, 2005053,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 2005053 ,2005054 ,2005055 ,2005056 ,2005057 ,2005058 ,2005059 ,2005060 ,2005061 ,2005062 ,2005063 ,2005064 ,2005065 ,2005066 ,2005067 ,2005068 ,2005069 ,2005070 ,2005071 ,2005072 ,2005073 ,2005074 ,2005075 ,2005076 ,2005077 ,2005078 ,2005079 ,2005080 ,2005081 ,2005082 ,2005083 ,2005084 ,2005085 ,2005086 ,2005087 ,2005088 ,2005089 ,2005090 ,2005091 ,2005092 ,2005093 ,2005094 ,2005095 ,2005096 ,2005097 ,2005098 ,2005099 ,2005100 ,2005101 ,2005102 ,2005103 ,2005104 ,2005105 ,2005106 ,2005107 ,2005108 ,2005109 ,2005110 ,2005111 ,2005112 ,2005113 ,2005114 ,2005115 ,2005116 ,2005117 ,2005118 ,2005119 ,2005120 ,2005121 ,2005122 ,2005123 ,2005124 ,2005125 ,2005126 ,2005127 ,2005128 ,2005129 ,2005130 ,2005131 ,2005132 ,2005133 ,2005134 ,2005135 ,2005136 ,2005137 ,2005138 ,2005139 ,2005140 ,2005141 ,2005142 ,2005143 ,2005144 ,2005145 ,2005146 ,2005147 ,2005148 ,2005149 ,2005150 ,2005151 ,2005152 , }, false){ Name = "G_Auto_CY_Retract" };
			G_AllCell_Home_Done = new BeckhoffBool(this.GetG_AllCell_Home_Done, client, 16448, 2005153){ Name = "G_AllCell_Home_Done" };
			G_LoadBufferStatus = new DUT_BufferStatusWrapper(this.GetG_LoadBufferStatus, client, 16448, 2005154)
			{
				Name = "G_LoadBufferStatus",
				iCellNo = new BeckhoffShort(this.GetG_LoadBufferStatus_Dot_iCellNo, client, 16448, 2005154){ Name = "iCellNo" },
				bHomeDone = new BeckhoffShort(this.GetG_LoadBufferStatus_Dot_bHomeDone, client, 16448, 2005156){ Name = "bHomeDone" },
				Step = new BeckhoffShort(this.GetG_LoadBufferStatus_Dot_Step, client, 16448, 2005158){ Name = "Step" },
			};
			G_AllAxis_Home_Done = new BeckhoffBool(this.GetG_AllAxis_Home_Done, client, 16448, 2005160){ Name = "G_AllAxis_Home_Done" };
			G_AllValve_Home_Done = new BeckhoffBool(this.GetG_AllValve_Home_Done, client, 16448, 2005161){ Name = "G_AllValve_Home_Done" };
			G_AutoAllowed = new BeckhoffBool(this.GetG_AutoAllowed, client, 16448, 2005162){ Name = "G_AutoAllowed" };
			G_bDrive_Valve = new BeckhoffBoolArray<Bool50>(this.GetG_bDrive_Valve, client, 16448, 2005163,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 2005163 ,2005164 ,2005165 ,2005166 ,2005167 ,2005168 ,2005169 ,2005170 ,2005171 ,2005172 ,2005173 ,2005174 ,2005175 ,2005176 ,2005177 ,2005178 ,2005179 ,2005180 ,2005181 ,2005182 ,2005183 ,2005184 ,2005185 ,2005186 ,2005187 ,2005188 ,2005189 ,2005190 ,2005191 ,2005192 ,2005193 ,2005194 ,2005195 ,2005196 ,2005197 ,2005198 ,2005199 ,2005200 ,2005201 ,2005202 ,2005203 ,2005204 ,2005205 ,2005206 ,2005207 ,2005208 ,2005209 ,2005210 ,2005211 ,2005212 , }, false){ Name = "G_bDrive_Valve" };
			G_bDrive_Sensor = new BeckhoffBoolArray<Bool50>(this.GetG_bDrive_Sensor, client, 16448, 2005213,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 2005213 ,2005214 ,2005215 ,2005216 ,2005217 ,2005218 ,2005219 ,2005220 ,2005221 ,2005222 ,2005223 ,2005224 ,2005225 ,2005226 ,2005227 ,2005228 ,2005229 ,2005230 ,2005231 ,2005232 ,2005233 ,2005234 ,2005235 ,2005236 ,2005237 ,2005238 ,2005239 ,2005240 ,2005241 ,2005242 ,2005243 ,2005244 ,2005245 ,2005246 ,2005247 ,2005248 ,2005249 ,2005250 ,2005251 ,2005252 ,2005253 ,2005254 ,2005255 ,2005256 ,2005257 ,2005258 ,2005259 ,2005260 ,2005261 ,2005262 , }, false){ Name = "G_bDrive_Sensor" };
			G_bIMH_BackHome = new BeckhoffBool(this.GetG_bIMH_BackHome, client, 16448, 2005263){ Name = "G_bIMH_BackHome" };
			G_IMH_AUTO_Step = new BeckhoffShort(this.GetG_IMH_AUTO_Step, client, 16448, 2005264){ Name = "G_IMH_AUTO_Step" };
			G_IMH_Manual_LoadCase_Step = new BeckhoffShort(this.GetG_IMH_Manual_LoadCase_Step, client, 16448, 2005266){ Name = "G_IMH_Manual_LoadCase_Step" };
			G_IMH_Set_Time = new BeckhoffUIntArray<UInt11>(this.GetG_IMH_Set_Time, client, 16448, 2005268,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 2005268 ,2005272 ,2005276 ,2005280 ,2005284 ,2005288 ,2005292 ,2005296 ,2005300 ,2005304 ,2005308 , }, true){ Name = "G_IMH_Set_Time" };
			G_IMH_Manual_UnLoadCase_Step = new BeckhoffShort(this.GetG_IMH_Manual_UnLoadCase_Step, client, 16448, 2005312){ Name = "G_IMH_Manual_UnLoadCase_Step" };
			G_IMH_Manual_BackHome_Step = new BeckhoffShort(this.GetG_IMH_Manual_BackHome_Step, client, 16448, 2005314){ Name = "G_IMH_Manual_BackHome_Step" };
			G_bIMH_Manual_UnLoad_Case = new BeckhoffBool(this.GetG_bIMH_Manual_UnLoad_Case, client, 16448, 2005316){ Name = "G_bIMH_Manual_UnLoad_Case" };
			G_bIMH_Manual_Load_Case = new BeckhoffBool(this.GetG_bIMH_Manual_Load_Case, client, 16448, 2005317){ Name = "G_bIMH_Manual_Load_Case" };
			G_bIMH_Auto_Load_Case = new BeckhoffBool(this.GetG_bIMH_Auto_Load_Case, client, 16448, 2005318){ Name = "G_bIMH_Auto_Load_Case" };
			I_IMH_ZM_PL = new BeckhoffBool(this.GetI_IMH_ZM_PL, client, 16448, 2005319){ Name = "I_IMH_ZM_PL" };
			G_IMH_Real_Pushed_Slot = new BeckhoffShort(this.GetG_IMH_Real_Pushed_Slot, client, 16448, 2005320){ Name = "G_IMH_Real_Pushed_Slot" };
			I_IMH_ZM_OL = new BeckhoffBool(this.GetI_IMH_ZM_OL, client, 16448, 2005322){ Name = "I_IMH_ZM_OL" };
			I_IMH_ZM_NL = new BeckhoffBool(this.GetI_IMH_ZM_NL, client, 16448, 2005323){ Name = "I_IMH_ZM_NL" };
			I_IMH_YM_PL = new BeckhoffBool(this.GetI_IMH_YM_PL, client, 16448, 2005324){ Name = "I_IMH_YM_PL" };
			I_IMH_YM_OL = new BeckhoffBool(this.GetI_IMH_YM_OL, client, 16448, 2005325){ Name = "I_IMH_YM_OL" };
			I_IMH_YM_NL = new BeckhoffBool(this.GetI_IMH_YM_NL, client, 16448, 2005326){ Name = "I_IMH_YM_NL" };
			bAllowLoadEmptyMagazine = new BeckhoffBool(this.GetbAllowLoadEmptyMagazine, client, 16448, 2005341){ Name = "bAllowLoadEmptyMagazine" };
			bLoadEmptyMagazineDone = new BeckhoffBool(this.GetbLoadEmptyMagazineDone, client, 16448, 2005342){ Name = "bLoadEmptyMagazineDone" };
			bAllowLoadSubstrate = new BeckhoffBool(this.GetbAllowLoadSubstrate, client, 16448, 2005343){ Name = "bAllowLoadSubstrate" };
			bLoadSubstrateDone = new BeckhoffBool(this.GetbLoadSubstrateDone, client, 16448, 2005344){ Name = "bLoadSubstrateDone" };
			bAllowUnLoadCase = new BeckhoffBool(this.GetbAllowUnLoadCase, client, 16448, 2005345){ Name = "bAllowUnLoadCase" };
			bUnLoadCaseDone = new BeckhoffBool(this.GetbUnLoadCaseDone, client, 16448, 2005346){ Name = "bUnLoadCaseDone" };
			G_bOMH_BackHome = new BeckhoffBool(this.GetG_bOMH_BackHome, client, 16448, 2005347){ Name = "G_bOMH_BackHome" };
			G_OMH_AUTO_Step = new BeckhoffShort(this.GetG_OMH_AUTO_Step, client, 16448, 2005348){ Name = "G_OMH_AUTO_Step" };
			G_OMH_AUTO_Run_Step = new BeckhoffShort(this.GetG_OMH_AUTO_Run_Step, client, 16448, 2005350){ Name = "G_OMH_AUTO_Run_Step" };
			G_OMH_Manual_BackHome_Step = new BeckhoffShort(this.GetG_OMH_Manual_BackHome_Step, client, 16448, 2005352){ Name = "G_OMH_Manual_BackHome_Step" };
			G_OMH_Manual_LoadCase_Step = new BeckhoffShort(this.GetG_OMH_Manual_LoadCase_Step, client, 16448, 2005354){ Name = "G_OMH_Manual_LoadCase_Step" };
			G_OMH_Manual_UnLoadCase_Step = new BeckhoffShort(this.GetG_OMH_Manual_UnLoadCase_Step, client, 16448, 2005356){ Name = "G_OMH_Manual_UnLoadCase_Step" };
			G_bOMH_Manual_UnLoad_Case = new BeckhoffBool(this.GetG_bOMH_Manual_UnLoad_Case, client, 16448, 2005358){ Name = "G_bOMH_Manual_UnLoad_Case" };
			G_bOMH_Manual_Load_Case = new BeckhoffBool(this.GetG_bOMH_Manual_Load_Case, client, 16448, 2005359){ Name = "G_bOMH_Manual_Load_Case" };
			G_bOMH_Auto_Loading_Case = new BeckhoffBool(this.GetG_bOMH_Auto_Loading_Case, client, 16448, 2005360){ Name = "G_bOMH_Auto_Loading_Case" };
			I_OMH_ZM_PL = new BeckhoffBool(this.GetI_OMH_ZM_PL, client, 16448, 2005361){ Name = "I_OMH_ZM_PL" };
			I_OMH_ZM_OL = new BeckhoffBool(this.GetI_OMH_ZM_OL, client, 16448, 2005362){ Name = "I_OMH_ZM_OL" };
			I_OMH_ZM_NL = new BeckhoffBool(this.GetI_OMH_ZM_NL, client, 16448, 2005363){ Name = "I_OMH_ZM_NL" };
			I_OMH_YM_PL = new BeckhoffBool(this.GetI_OMH_YM_PL, client, 16448, 2005364){ Name = "I_OMH_YM_PL" };
			I_OMH_YM_OL = new BeckhoffBool(this.GetI_OMH_YM_OL, client, 16448, 2005365){ Name = "I_OMH_YM_OL" };
			I_OMH_YM_NL = new BeckhoffBool(this.GetI_OMH_YM_NL, client, 16448, 2005366){ Name = "I_OMH_YM_NL" };
			G_OMH_Ready_For_Recive_Substrate = new BeckhoffBool(this.GetG_OMH_Ready_For_Recive_Substrate, client, 16448, 2005377){ Name = "G_OMH_Ready_For_Recive_Substrate" };
			G_FOG_Tranfer_Substrate_Moving = new BeckhoffBool(this.GetG_FOG_Tranfer_Substrate_Moving, client, 16448, 2005378){ Name = "G_FOG_Tranfer_Substrate_Moving" };
			G_FOG_Tranfer_Substrate_Done = new BeckhoffBool(this.GetG_FOG_Tranfer_Substrate_Done, client, 16448, 2005379){ Name = "G_FOG_Tranfer_Substrate_Done" };
			G_OMH_Receive_Number_Slot = new BeckhoffShort(this.GetG_OMH_Receive_Number_Slot, client, 16448, 2005380){ Name = "G_OMH_Receive_Number_Slot" };
			G_OMH_bAxis_AbsMove = new BeckhoffBoolArray<Bool20>(this.GetG_OMH_bAxis_AbsMove, client, 16448, 2005382,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 2005382 ,2005383 ,2005384 ,2005385 ,2005386 ,2005387 ,2005388 ,2005389 ,2005390 ,2005391 ,2005392 ,2005393 ,2005394 ,2005395 ,2005396 ,2005397 ,2005398 ,2005399 ,2005400 ,2005401 , }, false){ Name = "G_OMH_bAxis_AbsMove" };
			G_OMH_bAxis_RelMove = new BeckhoffBoolArray<Bool20>(this.GetG_OMH_bAxis_RelMove, client, 16448, 2005402,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 2005402 ,2005403 ,2005404 ,2005405 ,2005406 ,2005407 ,2005408 ,2005409 ,2005410 ,2005411 ,2005412 ,2005413 ,2005414 ,2005415 ,2005416 ,2005417 ,2005418 ,2005419 ,2005420 ,2005421 , }, false){ Name = "G_OMH_bAxis_RelMove" };
			G_FIG_Auto_Step = new BeckhoffShort(this.GetG_FIG_Auto_Step, client, 16448, 2005422){ Name = "G_FIG_Auto_Step" };
			G_FCU_Auto_Step = new BeckhoffShort(this.GetG_FCU_Auto_Step, client, 16448, 2005424){ Name = "G_FCU_Auto_Step" };
			G_FBU_Auto_Step = new BeckhoffShort(this.GetG_FBU_Auto_Step, client, 16448, 2005426){ Name = "G_FBU_Auto_Step" };
			G_FOG_Auto_Step = new BeckhoffShort(this.GetG_FOG_Auto_Step, client, 16448, 2005428){ Name = "G_FOG_Auto_Step" };
			G_FSU_BackHome_Step = new BeckhoffShort(this.GetG_FSU_BackHome_Step, client, 16448, 2005430){ Name = "G_FSU_BackHome_Step" };
			G_FSU_bBackHome = new BeckhoffBool(this.GetG_FSU_bBackHome, client, 16448, 2005432){ Name = "G_FSU_bBackHome" };
			G_Manual_bMove_Base = new BeckhoffBool(this.GetG_Manual_bMove_Base, client, 16448, 2005433){ Name = "G_Manual_bMove_Base" };
			G_Manual_Move_Base_Step = new BeckhoffShort(this.GetG_Manual_Move_Base_Step, client, 16448, 2005434){ Name = "G_Manual_Move_Base_Step" };
			G_FBU_bManual_BondBase = new BeckhoffBool(this.GetG_FBU_bManual_BondBase, client, 16448, 2005436){ Name = "G_FBU_bManual_BondBase" };
			G_Preform_Clean_All_Done = new BeckhoffBool(this.GetG_Preform_Clean_All_Done, client, 16448, 2005468){ Name = "G_Preform_Clean_All_Done" };
			G_CDA_Inspect_Sucessful = new BeckhoffBool(this.GetG_CDA_Inspect_Sucessful, client, 16448, 2005469){ Name = "G_CDA_Inspect_Sucessful" };
			G_FOG_TransferBasr_Ready = new BeckhoffBool(this.GetG_FOG_TransferBasr_Ready, client, 16448, 2005499){ Name = "G_FOG_TransferBasr_Ready" };
			G_Move_Base_Finished = new BeckhoffBool(this.GetG_Move_Base_Finished, client, 16448, 2005506){ Name = "G_Move_Base_Finished" };
			G_bWLU_Home = new BeckhoffBool(this.GetG_bWLU_Home, client, 16448, 2005525){ Name = "G_bWLU_Home" };
			G_bWLU_Manual_Load_WAF = new BeckhoffBool(this.GetG_bWLU_Manual_Load_WAF, client, 16448, 2005526){ Name = "G_bWLU_Manual_Load_WAF" };
			G_bWLU_Manual_UnLoad_WAF = new BeckhoffBool(this.GetG_bWLU_Manual_UnLoad_WAF, client, 16448, 2005527){ Name = "G_bWLU_Manual_UnLoad_WAF" };
			G_WLU_Auto_STEP = new BeckhoffShort(this.GetG_WLU_Auto_STEP, client, 16448, 2005528){ Name = "G_WLU_Auto_STEP" };
			G_WLU_Home_STEP = new BeckhoffShort(this.GetG_WLU_Home_STEP, client, 16448, 2005530){ Name = "G_WLU_Home_STEP" };
			G_WLU_Manual_Load_STEP = new BeckhoffShort(this.GetG_WLU_Manual_Load_STEP, client, 16448, 2005532){ Name = "G_WLU_Manual_Load_STEP" };
			G_WLU_Manual_UnLoad_STEP = new BeckhoffShort(this.GetG_WLU_Manual_UnLoad_STEP, client, 16448, 2005534){ Name = "G_WLU_Manual_UnLoad_STEP" };
			I_FCU_PHT_AI = new BeckhoffInt(this.GetI_FCU_PHT_AI, client, 61472, 128000){ Name = "I_FCU_PHT_AI" };
			I_FCU_HCM_AI = new BeckhoffInt(this.GetI_FCU_HCM_AI, client, 61472, 128002){ Name = "I_FCU_HCM_AI" };
			I_FCU_RDV_AI = new BeckhoffInt(this.GetI_FCU_RDV_AI, client, 61472, 128004){ Name = "I_FCU_RDV_AI" };
			I_FBU_HTR_AI = new BeckhoffInt(this.GetI_FBU_HTR_AI, client, 61472, 128006){ Name = "I_FBU_HTR_AI" };
			I_FBU_NPA_AI1 = new BeckhoffInt(this.GetI_FBU_NPA_AI1, client, 61472, 128008){ Name = "I_FBU_NPA_AI1" };
			I_FBU_NPA_AI2 = new BeckhoffInt(this.GetI_FBU_NPA_AI2, client, 61472, 128010){ Name = "I_FBU_NPA_AI2" };
			I_FBU_NPA_AI3 = new BeckhoffInt(this.GetI_FBU_NPA_AI3, client, 61472, 128012){ Name = "I_FBU_NPA_AI3" };
			G_I_START = new BeckhoffBool(this.GetG_I_START, client, 61472, 2004743){ Name = "G_I_START" };
			G_I_STOP = new BeckhoffBool(this.GetG_I_STOP, client, 61472, 2004744){ Name = "G_I_STOP" };
			G_I_HIGHSPEED = new BeckhoffBool(this.GetG_I_HIGHSPEED, client, 61472, 2004745){ Name = "G_I_HIGHSPEED" };
			G_I_UP = new BeckhoffBool(this.GetG_I_UP, client, 61472, 2004746){ Name = "G_I_UP" };
			G_I_DOWN = new BeckhoffBool(this.GetG_I_DOWN, client, 61472, 2004747){ Name = "G_I_DOWN" };
			G_I_LEFT = new BeckhoffBool(this.GetG_I_LEFT, client, 61472, 2004748){ Name = "G_I_LEFT" };
			G_I_RIGHT = new BeckhoffBool(this.GetG_I_RIGHT, client, 61472, 2004749){ Name = "G_I_RIGHT" };
			G_I_RESET = new BeckhoffBool(this.GetG_I_RESET, client, 61472, 2004750){ Name = "G_I_RESET" };
			G_I_SIMULATE = new BeckhoffBool(this.GetG_I_SIMULATE, client, 61472, 2004751){ Name = "G_I_SIMULATE" };
			I_IMH_LDF_PL = new BeckhoffBool(this.GetI_IMH_LDF_PL, client, 61472, 2005327){ Name = "I_IMH_LDF_PL" };
			I_IMH_LDF_NL = new BeckhoffBool(this.GetI_IMH_LDF_NL, client, 61472, 2005328){ Name = "I_IMH_LDF_NL" };
			I_IMH_ZC_PL = new BeckhoffBool(this.GetI_IMH_ZC_PL, client, 61472, 2005329){ Name = "I_IMH_ZC_PL" };
			I_IMH_SPC_PL = new BeckhoffBool(this.GetI_IMH_SPC_PL, client, 61472, 2005330){ Name = "I_IMH_SPC_PL" };
			I_IMH_SPC_NL = new BeckhoffBool(this.GetI_IMH_SPC_NL, client, 61472, 2005331){ Name = "I_IMH_SPC_NL" };
			I_IMH_SAC_SR = new BeckhoffBool(this.GetI_IMH_SAC_SR, client, 61472, 2005332){ Name = "I_IMH_SAC_SR" };
			I_IMH_SDD_SR = new BeckhoffBool(this.GetI_IMH_SDD_SR, client, 61472, 2005333){ Name = "I_IMH_SDD_SR" };
			I_IMH_MPD_SR = new BeckhoffBool(this.GetI_IMH_MPD_SR, client, 61472, 2005334){ Name = "I_IMH_MPD_SR" };
			I_IMH_MFD_SR = new BeckhoffBool(this.GetI_IMH_MFD_SR, client, 61472, 2005335){ Name = "I_IMH_MFD_SR" };
			I_OMH_LDF_PL = new BeckhoffBool(this.GetI_OMH_LDF_PL, client, 61472, 2005367){ Name = "I_OMH_LDF_PL" };
			I_OMH_LDF_NL = new BeckhoffBool(this.GetI_OMH_LDF_NL, client, 61472, 2005368){ Name = "I_OMH_LDF_NL" };
			I_OMH_ZC_PL = new BeckhoffBool(this.GetI_OMH_ZC_PL, client, 61472, 2005369){ Name = "I_OMH_ZC_PL" };
			I_OMH_SDD_SR = new BeckhoffBool(this.GetI_OMH_SDD_SR, client, 61472, 2005370){ Name = "I_OMH_SDD_SR" };
			I_OMH_MPD_SR = new BeckhoffBool(this.GetI_OMH_MPD_SR, client, 61472, 2005371){ Name = "I_OMH_MPD_SR" };
			I_OMH_MFD_SR = new BeckhoffBool(this.GetI_OMH_MFD_SR, client, 61472, 2005372){ Name = "I_OMH_MFD_SR" };
			I_FIG_SFP_SR = new BeckhoffBool(this.GetI_FIG_SFP_SR, client, 61472, 2005437){ Name = "I_FIG_SFP_SR" };
			I_FIG_SPD_SR = new BeckhoffBool(this.GetI_FIG_SPD_SR, client, 61472, 2005438){ Name = "I_FIG_SPD_SR" };
			I_FIG_RVS_SR = new BeckhoffBool(this.GetI_FIG_RVS_SR, client, 61472, 2005439){ Name = "I_FIG_RVS_SR" };
			I_FIG_IFO_SR = new BeckhoffBool(this.GetI_FIG_IFO_SR, client, 61472, 2005440){ Name = "I_FIG_IFO_SR" };
			I_FIG_CM_OL = new BeckhoffBool(this.GetI_FIG_CM_OL, client, 61472, 2005441){ Name = "I_FIG_CM_OL" };
			I_FIG_XM_PL = new BeckhoffBool(this.GetI_FIG_XM_PL, client, 61472, 2005442){ Name = "I_FIG_XM_PL" };
			I_FIG_XM_OL = new BeckhoffBool(this.GetI_FIG_XM_OL, client, 61472, 2005443){ Name = "I_FIG_XM_OL" };
			I_FIG_XM_NL = new BeckhoffBool(this.GetI_FIG_XM_NL, client, 61472, 2005444){ Name = "I_FIG_XM_NL" };
			I_FCU_SIP_SR = new BeckhoffBool(this.GetI_FCU_SIP_SR, client, 61472, 2005446){ Name = "I_FCU_SIP_SR" };
			I_FCU_TRC_SR1 = new BeckhoffBool(this.GetI_FCU_TRC_SR1, client, 61472, 2005447){ Name = "I_FCU_TRC_SR1" };
			I_FCU_TRC_SR2 = new BeckhoffBool(this.GetI_FCU_TRC_SR2, client, 61472, 2005448){ Name = "I_FCU_TRC_SR2" };
			I_FCU_PRA_SR = new BeckhoffBool(this.GetI_FCU_PRA_SR, client, 61472, 2005449){ Name = "I_FCU_PRA_SR" };
			I_FCU_NRA_SR = new BeckhoffBool(this.GetI_FCU_NRA_SR, client, 61472, 2005450){ Name = "I_FCU_NRA_SR" };
			I_FCU_LXM_PL = new BeckhoffBool(this.GetI_FCU_LXM_PL, client, 61472, 2005451){ Name = "I_FCU_LXM_PL" };
			I_FCU_LXM_OL = new BeckhoffBool(this.GetI_FCU_LXM_OL, client, 61472, 2005452){ Name = "I_FCU_LXM_OL" };
			I_FCU_LXM_NL = new BeckhoffBool(this.GetI_FCU_LXM_NL, client, 61472, 2005453){ Name = "I_FCU_LXM_NL" };
			I_FCU_CM_OL = new BeckhoffBool(this.GetI_FCU_CM_OL, client, 61472, 2005454){ Name = "I_FCU_CM_OL" };
			I_FCU_CDA_YM_OL = new BeckhoffBool(this.GetI_FCU_CDA_YM_OL, client, 61472, 2005455){ Name = "I_FCU_CDA_YM_OL" };
			I_FCU_CDA_ZM_PL = new BeckhoffBool(this.GetI_FCU_CDA_ZM_PL, client, 61472, 2005456){ Name = "I_FCU_CDA_ZM_PL" };
			I_FCU_CDA_ZM_NL = new BeckhoffBool(this.GetI_FCU_CDA_ZM_NL, client, 61472, 2005457){ Name = "I_FCU_CDA_ZM_NL" };
			I_FCU_PCM_OL = new BeckhoffBool(this.GetI_FCU_PCM_OL, client, 61472, 2005458){ Name = "I_FCU_PCM_OL" };
			I_FCU_SZM_PL = new BeckhoffBool(this.GetI_FCU_SZM_PL, client, 61472, 2005459){ Name = "I_FCU_SZM_PL" };
			I_FCU_SZM_OL = new BeckhoffBool(this.GetI_FCU_SZM_OL, client, 61472, 2005460){ Name = "I_FCU_SZM_OL" };
			I_FCU_SZM_NL = new BeckhoffBool(this.GetI_FCU_SZM_NL, client, 61472, 2005461){ Name = "I_FCU_SZM_NL" };
			I_FBU_UTC_SR1 = new BeckhoffBool(this.GetI_FBU_UTC_SR1, client, 61472, 2005470){ Name = "I_FBU_UTC_SR1" };
			I_FBU_UTC_SR2 = new BeckhoffBool(this.GetI_FBU_UTC_SR2, client, 61472, 2005471){ Name = "I_FBU_UTC_SR2" };
			I_FBU_BCM_OL = new BeckhoffBool(this.GetI_FBU_BCM_OL, client, 61472, 2005472){ Name = "I_FBU_BCM_OL" };
			I_FBU_BZ1M_PL = new BeckhoffBool(this.GetI_FBU_BZ1M_PL, client, 61472, 2005473){ Name = "I_FBU_BZ1M_PL" };
			I_FBU_BZ1M_OL = new BeckhoffBool(this.GetI_FBU_BZ1M_OL, client, 61472, 2005474){ Name = "I_FBU_BZ1M_OL" };
			I_FBU_BZ1M_NL = new BeckhoffBool(this.GetI_FBU_BZ1M_NL, client, 61472, 2005475){ Name = "I_FBU_BZ1M_NL" };
			I_FBU_BZ2M_PL = new BeckhoffBool(this.GetI_FBU_BZ2M_PL, client, 61472, 2005476){ Name = "I_FBU_BZ2M_PL" };
			I_FBU_BZ2M_OL = new BeckhoffBool(this.GetI_FBU_BZ2M_OL, client, 61472, 2005477){ Name = "I_FBU_BZ2M_OL" };
			I_FBU_BZ2M_NL = new BeckhoffBool(this.GetI_FBU_BZ2M_NL, client, 61472, 2005478){ Name = "I_FBU_BZ2M_NL" };
			I_FBU_LXM_PL = new BeckhoffBool(this.GetI_FBU_LXM_PL, client, 61472, 2005479){ Name = "I_FBU_LXM_PL" };
			I_FBU_LXM_OL = new BeckhoffBool(this.GetI_FBU_LXM_OL, client, 61472, 2005480){ Name = "I_FBU_LXM_OL" };
			I_FBU_LXM_NL = new BeckhoffBool(this.GetI_FBU_LXM_NL, client, 61472, 2005481){ Name = "I_FBU_LXM_NL" };
			I_FBU_CM_OL = new BeckhoffBool(this.GetI_FBU_CM_OL, client, 61472, 2005482){ Name = "I_FBU_CM_OL" };
			I_FBU_V_XM_PL = new BeckhoffBool(this.GetI_FBU_V_XM_PL, client, 61472, 2005483){ Name = "I_FBU_V_XM_PL" };
			I_FBU_V_XM_OL = new BeckhoffBool(this.GetI_FBU_V_XM_OL, client, 61472, 2005484){ Name = "I_FBU_V_XM_OL" };
			I_FBU_V_XM_NL = new BeckhoffBool(this.GetI_FBU_V_XM_NL, client, 61472, 2005485){ Name = "I_FBU_V_XM_NL" };
			I_FBU_V_YM_PL = new BeckhoffBool(this.GetI_FBU_V_YM_PL, client, 61472, 2005486){ Name = "I_FBU_V_YM_PL" };
			I_FBU_V_YM_OL = new BeckhoffBool(this.GetI_FBU_V_YM_OL, client, 61472, 2005487){ Name = "I_FBU_V_YM_OL" };
			I_FBU_V_YM_NL = new BeckhoffBool(this.GetI_FBU_V_YM_NL, client, 61472, 2005488){ Name = "I_FBU_V_YM_NL" };
			I_FBU_AZM_PL = new BeckhoffBool(this.GetI_FBU_AZM_PL, client, 61472, 2005489){ Name = "I_FBU_AZM_PL" };
			I_FBU_AZM_OL = new BeckhoffBool(this.GetI_FBU_AZM_OL, client, 61472, 2005490){ Name = "I_FBU_AZM_OL" };
			I_FBU_AZM_NL = new BeckhoffBool(this.GetI_FBU_AZM_NL, client, 61472, 2005491){ Name = "I_FBU_AZM_NL" };
			I_FBU_TWM_OL = new BeckhoffBool(this.GetI_FBU_TWM_OL, client, 61472, 2005492){ Name = "I_FBU_TWM_OL" };
			I_FOG_USS_PL = new BeckhoffBool(this.GetI_FOG_USS_PL, client, 61472, 2005501){ Name = "I_FOG_USS_PL" };
			I_FOG_LXM_PL = new BeckhoffBool(this.GetI_FOG_LXM_PL, client, 61472, 2005502){ Name = "I_FOG_LXM_PL" };
			I_FOG_LXM_OL = new BeckhoffBool(this.GetI_FOG_LXM_OL, client, 61472, 2005503){ Name = "I_FOG_LXM_OL" };
			I_FOG_LXM_NL = new BeckhoffBool(this.GetI_FOG_LXM_NL, client, 61472, 2005504){ Name = "I_FOG_LXM_NL" };
			I_FOG_ZM_OL = new BeckhoffBool(this.GetI_FOG_ZM_OL, client, 61472, 2005505){ Name = "I_FOG_ZM_OL" };
			I_WLU_FRI_SR = new BeckhoffBool(this.GetI_WLU_FRI_SR, client, 61472, 2005507){ Name = "I_WLU_FRI_SR" };
			I_WLU_RRI_SR = new BeckhoffBool(this.GetI_WLU_RRI_SR, client, 61472, 2005508){ Name = "I_WLU_RRI_SR" };
			I_WLU_FRO_SR = new BeckhoffBool(this.GetI_WLU_FRO_SR, client, 61472, 2005509){ Name = "I_WLU_FRO_SR" };
			I_WLU_RRO_SR = new BeckhoffBool(this.GetI_WLU_RRO_SR, client, 61472, 2005510){ Name = "I_WLU_RRO_SR" };
			I_WLU_WTS_SR = new BeckhoffBool(this.GetI_WLU_WTS_SR, client, 61472, 2005511){ Name = "I_WLU_WTS_SR" };
			I_WLU_WRS_SR = new BeckhoffBool(this.GetI_WLU_WRS_SR, client, 61472, 2005512){ Name = "I_WLU_WRS_SR" };
			I_WLU_WPD_SR = new BeckhoffBool(this.GetI_WLU_WPD_SR, client, 61472, 2005513){ Name = "I_WLU_WPD_SR" };
			I_WLU_WJS_SR = new BeckhoffBool(this.GetI_WLU_WJS_SR, client, 61472, 2005514){ Name = "I_WLU_WJS_SR" };
			I_WLU_CAP_SR1 = new BeckhoffBool(this.GetI_WLU_CAP_SR1, client, 61472, 2005515){ Name = "I_WLU_CAP_SR1" };
			I_WLU_CAP_SR2 = new BeckhoffBool(this.GetI_WLU_CAP_SR2, client, 61472, 2005516){ Name = "I_WLU_CAP_SR2" };
			I_WLU_ZM_PL = new BeckhoffBool(this.GetI_WLU_ZM_PL, client, 61472, 2005517){ Name = "I_WLU_ZM_PL" };
			I_WLU_ZM_WL = new BeckhoffBool(this.GetI_WLU_ZM_WL, client, 61472, 2005518){ Name = "I_WLU_ZM_WL" };
			I_WLU_ZM_OL = new BeckhoffBool(this.GetI_WLU_ZM_OL, client, 61472, 2005519){ Name = "I_WLU_ZM_OL" };
			I_WLU_ZM_NL = new BeckhoffBool(this.GetI_WLU_ZM_NL, client, 61472, 2005520){ Name = "I_WLU_ZM_NL" };
			I_WLU_XM_PL = new BeckhoffBool(this.GetI_WLU_XM_PL, client, 61472, 2005521){ Name = "I_WLU_XM_PL" };
			I_WLU_XM_OL = new BeckhoffBool(this.GetI_WLU_XM_OL, client, 61472, 2005522){ Name = "I_WLU_XM_OL" };
			I_WLU_XM_NL = new BeckhoffBool(this.GetI_WLU_XM_NL, client, 61472, 2005523){ Name = "I_WLU_XM_NL" };
			Q_IMH_LDF_SV = new BeckhoffBool(this.GetQ_IMH_LDF_SV, client, 61488, 2005336){ Name = "Q_IMH_LDF_SV" };
			Q_IMH_ZC_SV = new BeckhoffBool(this.GetQ_IMH_ZC_SV, client, 61488, 2005337){ Name = "Q_IMH_ZC_SV" };
			Q_IMH_ZC_SV2 = new BeckhoffBool(this.GetQ_IMH_ZC_SV2, client, 61488, 2005338){ Name = "Q_IMH_ZC_SV2" };
			Q_IMH_YC_SV = new BeckhoffBool(this.GetQ_IMH_YC_SV, client, 61488, 2005339){ Name = "Q_IMH_YC_SV" };
			Q_IMH_SPC_SV = new BeckhoffBool(this.GetQ_IMH_SPC_SV, client, 61488, 2005340){ Name = "Q_IMH_SPC_SV" };
			Q_OMH_LDF_SV = new BeckhoffBool(this.GetQ_OMH_LDF_SV, client, 61488, 2005373){ Name = "Q_OMH_LDF_SV" };
			Q_OMH_ZC_SV = new BeckhoffBool(this.GetQ_OMH_ZC_SV, client, 61488, 2005374){ Name = "Q_OMH_ZC_SV" };
			Q_OMH_ZC_SV2 = new BeckhoffBool(this.GetQ_OMH_ZC_SV2, client, 61488, 2005375){ Name = "Q_OMH_ZC_SV2" };
			Q_OMH_YC_SV = new BeckhoffBool(this.GetQ_OMH_YC_SV, client, 61488, 2005376){ Name = "Q_OMH_YC_SV" };
			Q_FIG_IFS_SV = new BeckhoffBool(this.GetQ_FIG_IFS_SV, client, 61488, 2005445){ Name = "Q_FIG_IFS_SV" };
			Q_FCU_RDV_SV = new BeckhoffBool(this.GetQ_FCU_RDV_SV, client, 61488, 2005462){ Name = "Q_FCU_RDV_SV" };
			Q_FCU_RBV_SV = new BeckhoffBool(this.GetQ_FCU_RBV_SV, client, 61488, 2005463){ Name = "Q_FCU_RBV_SV" };
			Q_FCU_IFS_SV = new BeckhoffBool(this.GetQ_FCU_IFS_SV, client, 61488, 2005464){ Name = "Q_FCU_IFS_SV" };
			Q_FCU_IFO_SV = new BeckhoffBool(this.GetQ_FCU_IFO_SV, client, 61488, 2005465){ Name = "Q_FCU_IFO_SV" };
			Q_FCU_SGV_SV = new BeckhoffBool(this.GetQ_FCU_SGV_SV, client, 61488, 2005466){ Name = "Q_FCU_SGV_SV" };
			Q_FCU_SBV_SV = new BeckhoffBool(this.GetQ_FCU_SBV_SV, client, 61488, 2005467){ Name = "Q_FCU_SBV_SV" };
			Q_FBU_SFG_SV1 = new BeckhoffBool(this.GetQ_FBU_SFG_SV1, client, 61488, 2005493){ Name = "Q_FBU_SFG_SV1" };
			Q_FBU_SFB_SV1 = new BeckhoffBool(this.GetQ_FBU_SFB_SV1, client, 61488, 2005494){ Name = "Q_FBU_SFB_SV1" };
			Q_FBU_SFG_SV2 = new BeckhoffBool(this.GetQ_FBU_SFG_SV2, client, 61488, 2005495){ Name = "Q_FBU_SFG_SV2" };
			Q_FBU_SFB_SV2 = new BeckhoffBool(this.GetQ_FBU_SFB_SV2, client, 61488, 2005496){ Name = "Q_FBU_SFB_SV2" };
			Q_FBU_SFG_SV3 = new BeckhoffBool(this.GetQ_FBU_SFG_SV3, client, 61488, 2005497){ Name = "Q_FBU_SFG_SV3" };
			Q_FBU_SFB_SV3 = new BeckhoffBool(this.GetQ_FBU_SFB_SV3, client, 61488, 2005498){ Name = "Q_FBU_SFB_SV3" };
			Q_FOG_USS_SV = new BeckhoffBool(this.GetQ_FOG_USS_SV, client, 61488, 2005500){ Name = "Q_FOG_USS_SV" };
			Q_WLU_CC_SV = new BeckhoffBool(this.GetQ_WLU_CC_SV, client, 61488, 2005524){ Name = "Q_WLU_CC_SV" };
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
		~GVL_UnitWrapper()
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
