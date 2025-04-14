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
	/// Name from PLC:GVL_IO_Index
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_IO_IndexWrapper : BaseData, IBaseData
	{
		public override IEnumerable<IBaseData> Children
		{
			get
			{
				yield return MaxCYnum;
				yield return MaxSRnum;
				yield return SV_Index;
				yield return CY_Manual_CMD;
				yield return CY_AUTO_CMD;
				yield return CY_State;
				yield return SR_Index;
				yield return SR_Manual_CMD;
				yield return SR_AUTO_CMD;
				yield return SR_State;
				yield return G_M_MainPower_Signal_Index;
				yield return IMH_Z_Axis_Input;
				yield return IMH_Y_Axis_Input;
				yield return OMH_Z_Axis_Input;
				yield return OMH_Y_Axis_Input;
				yield return G_M_Safety_Door_1_Index;
				yield return G_M_Safety_Door_2_Index;
				yield return G_M_Safety_Door_3_Index;
				yield return I_IMH_ZM_PL_Index;
				yield return I_IMH_ZM_OL_Index;
				yield return I_IMH_ZM_NL_Index;
				yield return I_IMH_YM_PL_Index;
				yield return I_IMH_YM_OL_Index;
				yield return I_IMH_YM_NL_Index;
				yield return I_IMH_LDF_PL_Index;
				yield return I_IMH_LDF_NL_Index;
				yield return I_IMH_ZC_PL_Index;
				yield return I_IMH_SPC_PL_Index;
				yield return I_IMH_SPC_NL_Index;
				yield return I_IMH_SAC_SR_Index;
				yield return I_IMH_SDD_SR_Index;
				yield return I_IMH_MPD_SR_Index;
				yield return I_IMH_MFD_SR_Index;
				yield return Q_IMH_LDF_SV_Index;
				yield return Q_IMH_ZC_SV_Index;
				yield return Q_IMH_YC_SV_Index;
				yield return Q_IMH_SPC_SV_Index;
				yield return I_OMH_ZM_PL_Index;
				yield return I_OMH_ZM_OL_Index;
				yield return I_OMH_ZM_NL_Index;
				yield return I_OMH_YM_PL_Index;
				yield return I_OMH_YM_OL_Index;
				yield return I_OMH_YM_NL_Index;
				yield return I_OMH_LDF_PL_Index;
				yield return I_OMH_LDF_NL_Index;
				yield return I_OMH_ZC_PL_Index;
				yield return I_OMH_SDD_SR_Index;
				yield return I_OMH_MPD_SR_Index;
				yield return I_OMH_MFD_SR_Index;
				yield return Q_OMH_LDF_SV_Index;
				yield return Q_OMH_ZC_SV_Index;
				yield return Q_OMH_ZC_SV2_Index;
				yield return Q_OMH_YC_SV_Index;
				yield return I_FIG_SFP_SR_Index;
				yield return I_FIG_SPD_SR_Index;
				yield return I_FIG_RVS_SR_Index;
				yield return I_FIG_IFS_SR_Index;
				yield return I_FIG_IFO_SR_Index;
				yield return I_FIG_CM_OL_Index;
				yield return I_FIG_XM_PL_Index;
				yield return I_FIG_XM_OL_Index;
				yield return I_FIG_XM_NL_Index;
				yield return Q_FIG_IFS_SV_Index;
				yield return I_FCU_SIP_SR_Index;
				yield return I_FCU_TRC_SR1_Index;
				yield return I_FCU_TRC_SR2_Index;
				yield return I_FCU_PRA_SR_Index;
				yield return I_FCU_NRA_SR_Index;
				yield return I_FCU_XM_PL_Index;
				yield return I_FCU_XM_OL_Index;
				yield return I_FCU_XM_NL_Index;
				yield return I_FCU_CM_OL_Index;
				yield return I_FCU_PCM_OL_Index;
				yield return I_FCU_SZM_PL_Index;
				yield return I_FCU_SZM_OL_Index;
				yield return I_FCU_SZM_NL_Index;
				yield return AI_FCU_PHT_SAI_Index;
				yield return AI_FCU_HCM_SAI_Index;
				yield return AI_FCU_RDV_SAI_Index;
				yield return Q_FCU_RDV_SV_Index;
				yield return Q_FCU_RBV_SV_Index;
				yield return Q_FCU_IFS_SV_Index;
				yield return Q_FCU_IFO_SV_Index;
				yield return Q_FCU_SGV_SV_Index;
				yield return Q_FCU_SBV_SV_Index;
				yield return I_FBU_UTC_SR1_Index;
				yield return I_FBU_UTC_SR2_Index;
				yield return I_FBU_BCM_OL_Index;
				yield return I_FBU_BZ1M_PL_Index;
				yield return I_FBU_BZ1M_OL_Index;
				yield return I_FBU_BZ1M_NL_Index;
				yield return I_FBU_BZ2M_PL_Index;
				yield return I_FBU_BZ2M_OL_Index;
				yield return I_FBU_BZ2M_NL_Index;
				yield return AI_FBU_HTR_AI_Index;
				yield return AI_FBU_NRA_AI1_Index;
				yield return AI_FBU_NRA_AI2_Index;
				yield return AI_FBU_NRA_AI3_Index;
				yield return Q_FBU_SFG_SV1_Index;
				yield return Q_FBU_SFB_SV1_Index;
				yield return Q_FBU_SFG_SV2_Index;
				yield return Q_FBU_SFB_SV2_Index;
				yield return Q_FBU_SFG_SV3_Index;
				yield return Q_FBU_SFB_SV3_Index;
				yield return I_FOG_USS_PL_Index;
				yield return Q_FOG_USS_SV_Index;
				yield return I_WLU_FRI_SR_Index;
				yield return I_WLU_RRI_SR_Index;
				yield return I_WLU_FRO_SR_Index;
				yield return I_WLU_RRO_SR_Index;
				yield return I_WLU_WPD_SR_Index;
				yield return I_WLU_WRS_SR_Index;
				yield return I_WLU_WJS_SR_Index;
				yield return I_WLU_WTS_SR_Index;
				yield return I_WLU_CAP_SR1_Index;
				yield return I_WLU_CAP_SR2_Index;
				yield return I_WLU_ZM_PL_Index;
				yield return I_WLU_ZM_WL_Index;
				yield return I_WLU_ZM_OL_Index;
				yield return I_WLU_ZM_NL_Index;
				yield return I_WLU_XM_PL_Index;
				yield return I_WLU_XM_OL_Index;
				yield return I_WLU_XM_NL_Index;
				yield return Q_WLU_CC_SV_Index;
			}
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(MaxCYnum):
					return MaxCYnum;
				case nameof(MaxSRnum):
					return MaxSRnum;
				case nameof(SV_Index):
					return SV_Index;
				case nameof(CY_Manual_CMD):
					return CY_Manual_CMD;
				case nameof(CY_AUTO_CMD):
					return CY_AUTO_CMD;
				case nameof(CY_State):
					return CY_State;
				case nameof(SR_Index):
					return SR_Index;
				case nameof(SR_Manual_CMD):
					return SR_Manual_CMD;
				case nameof(SR_AUTO_CMD):
					return SR_AUTO_CMD;
				case nameof(SR_State):
					return SR_State;
				case nameof(G_M_MainPower_Signal_Index):
					return G_M_MainPower_Signal_Index;
				case nameof(IMH_Z_Axis_Input):
					return IMH_Z_Axis_Input;
				case nameof(IMH_Y_Axis_Input):
					return IMH_Y_Axis_Input;
				case nameof(OMH_Z_Axis_Input):
					return OMH_Z_Axis_Input;
				case nameof(OMH_Y_Axis_Input):
					return OMH_Y_Axis_Input;
				case nameof(G_M_Safety_Door_1_Index):
					return G_M_Safety_Door_1_Index;
				case nameof(G_M_Safety_Door_2_Index):
					return G_M_Safety_Door_2_Index;
				case nameof(G_M_Safety_Door_3_Index):
					return G_M_Safety_Door_3_Index;
				case nameof(I_IMH_ZM_PL_Index):
					return I_IMH_ZM_PL_Index;
				case nameof(I_IMH_ZM_OL_Index):
					return I_IMH_ZM_OL_Index;
				case nameof(I_IMH_ZM_NL_Index):
					return I_IMH_ZM_NL_Index;
				case nameof(I_IMH_YM_PL_Index):
					return I_IMH_YM_PL_Index;
				case nameof(I_IMH_YM_OL_Index):
					return I_IMH_YM_OL_Index;
				case nameof(I_IMH_YM_NL_Index):
					return I_IMH_YM_NL_Index;
				case nameof(I_IMH_LDF_PL_Index):
					return I_IMH_LDF_PL_Index;
				case nameof(I_IMH_LDF_NL_Index):
					return I_IMH_LDF_NL_Index;
				case nameof(I_IMH_ZC_PL_Index):
					return I_IMH_ZC_PL_Index;
				case nameof(I_IMH_SPC_PL_Index):
					return I_IMH_SPC_PL_Index;
				case nameof(I_IMH_SPC_NL_Index):
					return I_IMH_SPC_NL_Index;
				case nameof(I_IMH_SAC_SR_Index):
					return I_IMH_SAC_SR_Index;
				case nameof(I_IMH_SDD_SR_Index):
					return I_IMH_SDD_SR_Index;
				case nameof(I_IMH_MPD_SR_Index):
					return I_IMH_MPD_SR_Index;
				case nameof(I_IMH_MFD_SR_Index):
					return I_IMH_MFD_SR_Index;
				case nameof(Q_IMH_LDF_SV_Index):
					return Q_IMH_LDF_SV_Index;
				case nameof(Q_IMH_ZC_SV_Index):
					return Q_IMH_ZC_SV_Index;
				case nameof(Q_IMH_YC_SV_Index):
					return Q_IMH_YC_SV_Index;
				case nameof(Q_IMH_SPC_SV_Index):
					return Q_IMH_SPC_SV_Index;
				case nameof(I_OMH_ZM_PL_Index):
					return I_OMH_ZM_PL_Index;
				case nameof(I_OMH_ZM_OL_Index):
					return I_OMH_ZM_OL_Index;
				case nameof(I_OMH_ZM_NL_Index):
					return I_OMH_ZM_NL_Index;
				case nameof(I_OMH_YM_PL_Index):
					return I_OMH_YM_PL_Index;
				case nameof(I_OMH_YM_OL_Index):
					return I_OMH_YM_OL_Index;
				case nameof(I_OMH_YM_NL_Index):
					return I_OMH_YM_NL_Index;
				case nameof(I_OMH_LDF_PL_Index):
					return I_OMH_LDF_PL_Index;
				case nameof(I_OMH_LDF_NL_Index):
					return I_OMH_LDF_NL_Index;
				case nameof(I_OMH_ZC_PL_Index):
					return I_OMH_ZC_PL_Index;
				case nameof(I_OMH_SDD_SR_Index):
					return I_OMH_SDD_SR_Index;
				case nameof(I_OMH_MPD_SR_Index):
					return I_OMH_MPD_SR_Index;
				case nameof(I_OMH_MFD_SR_Index):
					return I_OMH_MFD_SR_Index;
				case nameof(Q_OMH_LDF_SV_Index):
					return Q_OMH_LDF_SV_Index;
				case nameof(Q_OMH_ZC_SV_Index):
					return Q_OMH_ZC_SV_Index;
				case nameof(Q_OMH_ZC_SV2_Index):
					return Q_OMH_ZC_SV2_Index;
				case nameof(Q_OMH_YC_SV_Index):
					return Q_OMH_YC_SV_Index;
				case nameof(I_FIG_SFP_SR_Index):
					return I_FIG_SFP_SR_Index;
				case nameof(I_FIG_SPD_SR_Index):
					return I_FIG_SPD_SR_Index;
				case nameof(I_FIG_RVS_SR_Index):
					return I_FIG_RVS_SR_Index;
				case nameof(I_FIG_IFS_SR_Index):
					return I_FIG_IFS_SR_Index;
				case nameof(I_FIG_IFO_SR_Index):
					return I_FIG_IFO_SR_Index;
				case nameof(I_FIG_CM_OL_Index):
					return I_FIG_CM_OL_Index;
				case nameof(I_FIG_XM_PL_Index):
					return I_FIG_XM_PL_Index;
				case nameof(I_FIG_XM_OL_Index):
					return I_FIG_XM_OL_Index;
				case nameof(I_FIG_XM_NL_Index):
					return I_FIG_XM_NL_Index;
				case nameof(Q_FIG_IFS_SV_Index):
					return Q_FIG_IFS_SV_Index;
				case nameof(I_FCU_SIP_SR_Index):
					return I_FCU_SIP_SR_Index;
				case nameof(I_FCU_TRC_SR1_Index):
					return I_FCU_TRC_SR1_Index;
				case nameof(I_FCU_TRC_SR2_Index):
					return I_FCU_TRC_SR2_Index;
				case nameof(I_FCU_PRA_SR_Index):
					return I_FCU_PRA_SR_Index;
				case nameof(I_FCU_NRA_SR_Index):
					return I_FCU_NRA_SR_Index;
				case nameof(I_FCU_XM_PL_Index):
					return I_FCU_XM_PL_Index;
				case nameof(I_FCU_XM_OL_Index):
					return I_FCU_XM_OL_Index;
				case nameof(I_FCU_XM_NL_Index):
					return I_FCU_XM_NL_Index;
				case nameof(I_FCU_CM_OL_Index):
					return I_FCU_CM_OL_Index;
				case nameof(I_FCU_PCM_OL_Index):
					return I_FCU_PCM_OL_Index;
				case nameof(I_FCU_SZM_PL_Index):
					return I_FCU_SZM_PL_Index;
				case nameof(I_FCU_SZM_OL_Index):
					return I_FCU_SZM_OL_Index;
				case nameof(I_FCU_SZM_NL_Index):
					return I_FCU_SZM_NL_Index;
				case nameof(AI_FCU_PHT_SAI_Index):
					return AI_FCU_PHT_SAI_Index;
				case nameof(AI_FCU_HCM_SAI_Index):
					return AI_FCU_HCM_SAI_Index;
				case nameof(AI_FCU_RDV_SAI_Index):
					return AI_FCU_RDV_SAI_Index;
				case nameof(Q_FCU_RDV_SV_Index):
					return Q_FCU_RDV_SV_Index;
				case nameof(Q_FCU_RBV_SV_Index):
					return Q_FCU_RBV_SV_Index;
				case nameof(Q_FCU_IFS_SV_Index):
					return Q_FCU_IFS_SV_Index;
				case nameof(Q_FCU_IFO_SV_Index):
					return Q_FCU_IFO_SV_Index;
				case nameof(Q_FCU_SGV_SV_Index):
					return Q_FCU_SGV_SV_Index;
				case nameof(Q_FCU_SBV_SV_Index):
					return Q_FCU_SBV_SV_Index;
				case nameof(I_FBU_UTC_SR1_Index):
					return I_FBU_UTC_SR1_Index;
				case nameof(I_FBU_UTC_SR2_Index):
					return I_FBU_UTC_SR2_Index;
				case nameof(I_FBU_BCM_OL_Index):
					return I_FBU_BCM_OL_Index;
				case nameof(I_FBU_BZ1M_PL_Index):
					return I_FBU_BZ1M_PL_Index;
				case nameof(I_FBU_BZ1M_OL_Index):
					return I_FBU_BZ1M_OL_Index;
				case nameof(I_FBU_BZ1M_NL_Index):
					return I_FBU_BZ1M_NL_Index;
				case nameof(I_FBU_BZ2M_PL_Index):
					return I_FBU_BZ2M_PL_Index;
				case nameof(I_FBU_BZ2M_OL_Index):
					return I_FBU_BZ2M_OL_Index;
				case nameof(I_FBU_BZ2M_NL_Index):
					return I_FBU_BZ2M_NL_Index;
				case nameof(AI_FBU_HTR_AI_Index):
					return AI_FBU_HTR_AI_Index;
				case nameof(AI_FBU_NRA_AI1_Index):
					return AI_FBU_NRA_AI1_Index;
				case nameof(AI_FBU_NRA_AI2_Index):
					return AI_FBU_NRA_AI2_Index;
				case nameof(AI_FBU_NRA_AI3_Index):
					return AI_FBU_NRA_AI3_Index;
				case nameof(Q_FBU_SFG_SV1_Index):
					return Q_FBU_SFG_SV1_Index;
				case nameof(Q_FBU_SFB_SV1_Index):
					return Q_FBU_SFB_SV1_Index;
				case nameof(Q_FBU_SFG_SV2_Index):
					return Q_FBU_SFG_SV2_Index;
				case nameof(Q_FBU_SFB_SV2_Index):
					return Q_FBU_SFB_SV2_Index;
				case nameof(Q_FBU_SFG_SV3_Index):
					return Q_FBU_SFG_SV3_Index;
				case nameof(Q_FBU_SFB_SV3_Index):
					return Q_FBU_SFB_SV3_Index;
				case nameof(I_FOG_USS_PL_Index):
					return I_FOG_USS_PL_Index;
				case nameof(Q_FOG_USS_SV_Index):
					return Q_FOG_USS_SV_Index;
				case nameof(I_WLU_FRI_SR_Index):
					return I_WLU_FRI_SR_Index;
				case nameof(I_WLU_RRI_SR_Index):
					return I_WLU_RRI_SR_Index;
				case nameof(I_WLU_FRO_SR_Index):
					return I_WLU_FRO_SR_Index;
				case nameof(I_WLU_RRO_SR_Index):
					return I_WLU_RRO_SR_Index;
				case nameof(I_WLU_WPD_SR_Index):
					return I_WLU_WPD_SR_Index;
				case nameof(I_WLU_WRS_SR_Index):
					return I_WLU_WRS_SR_Index;
				case nameof(I_WLU_WJS_SR_Index):
					return I_WLU_WJS_SR_Index;
				case nameof(I_WLU_WTS_SR_Index):
					return I_WLU_WTS_SR_Index;
				case nameof(I_WLU_CAP_SR1_Index):
					return I_WLU_CAP_SR1_Index;
				case nameof(I_WLU_CAP_SR2_Index):
					return I_WLU_CAP_SR2_Index;
				case nameof(I_WLU_ZM_PL_Index):
					return I_WLU_ZM_PL_Index;
				case nameof(I_WLU_ZM_WL_Index):
					return I_WLU_ZM_WL_Index;
				case nameof(I_WLU_ZM_OL_Index):
					return I_WLU_ZM_OL_Index;
				case nameof(I_WLU_ZM_NL_Index):
					return I_WLU_ZM_NL_Index;
				case nameof(I_WLU_XM_PL_Index):
					return I_WLU_XM_PL_Index;
				case nameof(I_WLU_XM_OL_Index):
					return I_WLU_XM_OL_Index;
				case nameof(I_WLU_XM_NL_Index):
					return I_WLU_XM_NL_Index;
				case nameof(Q_WLU_CC_SV_Index):
					return Q_WLU_CC_SV_Index;
			}
			throw new KeyNotFoundException(name);
		}

		private readonly AdsClient client;

		public GVL_IO_IndexWrapper(AdsClient client)
		{
			this.client = client;

			MaxCYnum = new BeckhoffShort(this.GetMaxCYnum, client, 16448, 1178018){ Name = "MaxCYnum" };
			MaxSRnum = new BeckhoffShort(this.GetMaxSRnum, client, 16448, 1178020){ Name = "MaxSRnum" };
			SV_Index = new BeckhoffShort(this.GetSV_Index, client, 16448, 1178022){ Name = "SV_Index" };
			CY_Manual_CMD = new BeckhoffStructArray<DUT_CY_CMD100, DUT_CY_CMDWrapper, DUT_CY_CMD>(this.GetCY_Manual_CMD, client, 16448, 1222824,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1222824 ,1222830 ,1222836 ,1222842 ,1222848 ,1222854 ,1222860 ,1222866 ,1222872 ,1222878 ,1222884 ,1222890 ,1222896 ,1222902 ,1222908 ,1222914 ,1222920 ,1222926 ,1222932 ,1222938 ,1222944 ,1222950 ,1222956 ,1222962 ,1222968 ,1222974 ,1222980 ,1222986 ,1222992 ,1222998 ,1223004 ,1223010 ,1223016 ,1223022 ,1223028 ,1223034 ,1223040 ,1223046 ,1223052 ,1223058 ,1223064 ,1223070 ,1223076 ,1223082 ,1223088 ,1223094 ,1223100 ,1223106 ,1223112 ,1223118 ,1223124 ,1223130 ,1223136 ,1223142 ,1223148 ,1223154 ,1223160 ,1223166 ,1223172 ,1223178 ,1223184 ,1223190 ,1223196 ,1223202 ,1223208 ,1223214 ,1223220 ,1223226 ,1223232 ,1223238 ,1223244 ,1223250 ,1223256 ,1223262 ,1223268 ,1223274 ,1223280 ,1223286 ,1223292 ,1223298 ,1223304 ,1223310 ,1223316 ,1223322 ,1223328 ,1223334 ,1223340 ,1223346 ,1223352 ,1223358 ,1223364 ,1223370 ,1223376 ,1223382 ,1223388 ,1223394 ,1223400 ,1223406 ,1223412 ,1223418 , },
				new DUT_CY_CMDWrapper[]
				{
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD0, client, 16448, 1222824)
					{
						 Name = "Item_1",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD0_Dot_Extend_CMD, client, 16448, 1222824){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD0_Dot_Retract_CMD, client, 16448, 1222825){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD0_Dot_CY_PL, client, 16448, 1222826){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD0_Dot_CY_NL, client, 16448, 1222827){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD0_Dot_Coil_Num, client, 16448, 1222828){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD1, client, 16448, 1222830)
					{
						 Name = "Item_2",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD1_Dot_Extend_CMD, client, 16448, 1222830){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD1_Dot_Retract_CMD, client, 16448, 1222831){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD1_Dot_CY_PL, client, 16448, 1222832){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD1_Dot_CY_NL, client, 16448, 1222833){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD1_Dot_Coil_Num, client, 16448, 1222834){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD2, client, 16448, 1222836)
					{
						 Name = "Item_3",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD2_Dot_Extend_CMD, client, 16448, 1222836){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD2_Dot_Retract_CMD, client, 16448, 1222837){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD2_Dot_CY_PL, client, 16448, 1222838){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD2_Dot_CY_NL, client, 16448, 1222839){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD2_Dot_Coil_Num, client, 16448, 1222840){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD3, client, 16448, 1222842)
					{
						 Name = "Item_4",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD3_Dot_Extend_CMD, client, 16448, 1222842){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD3_Dot_Retract_CMD, client, 16448, 1222843){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD3_Dot_CY_PL, client, 16448, 1222844){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD3_Dot_CY_NL, client, 16448, 1222845){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD3_Dot_Coil_Num, client, 16448, 1222846){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD4, client, 16448, 1222848)
					{
						 Name = "Item_5",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD4_Dot_Extend_CMD, client, 16448, 1222848){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD4_Dot_Retract_CMD, client, 16448, 1222849){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD4_Dot_CY_PL, client, 16448, 1222850){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD4_Dot_CY_NL, client, 16448, 1222851){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD4_Dot_Coil_Num, client, 16448, 1222852){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD5, client, 16448, 1222854)
					{
						 Name = "Item_6",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD5_Dot_Extend_CMD, client, 16448, 1222854){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD5_Dot_Retract_CMD, client, 16448, 1222855){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD5_Dot_CY_PL, client, 16448, 1222856){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD5_Dot_CY_NL, client, 16448, 1222857){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD5_Dot_Coil_Num, client, 16448, 1222858){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD6, client, 16448, 1222860)
					{
						 Name = "Item_7",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD6_Dot_Extend_CMD, client, 16448, 1222860){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD6_Dot_Retract_CMD, client, 16448, 1222861){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD6_Dot_CY_PL, client, 16448, 1222862){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD6_Dot_CY_NL, client, 16448, 1222863){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD6_Dot_Coil_Num, client, 16448, 1222864){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD7, client, 16448, 1222866)
					{
						 Name = "Item_8",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD7_Dot_Extend_CMD, client, 16448, 1222866){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD7_Dot_Retract_CMD, client, 16448, 1222867){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD7_Dot_CY_PL, client, 16448, 1222868){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD7_Dot_CY_NL, client, 16448, 1222869){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD7_Dot_Coil_Num, client, 16448, 1222870){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD8, client, 16448, 1222872)
					{
						 Name = "Item_9",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD8_Dot_Extend_CMD, client, 16448, 1222872){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD8_Dot_Retract_CMD, client, 16448, 1222873){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD8_Dot_CY_PL, client, 16448, 1222874){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD8_Dot_CY_NL, client, 16448, 1222875){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD8_Dot_Coil_Num, client, 16448, 1222876){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD9, client, 16448, 1222878)
					{
						 Name = "Item_10",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD9_Dot_Extend_CMD, client, 16448, 1222878){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD9_Dot_Retract_CMD, client, 16448, 1222879){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD9_Dot_CY_PL, client, 16448, 1222880){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD9_Dot_CY_NL, client, 16448, 1222881){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD9_Dot_Coil_Num, client, 16448, 1222882){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD10, client, 16448, 1222884)
					{
						 Name = "Item_11",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD10_Dot_Extend_CMD, client, 16448, 1222884){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD10_Dot_Retract_CMD, client, 16448, 1222885){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD10_Dot_CY_PL, client, 16448, 1222886){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD10_Dot_CY_NL, client, 16448, 1222887){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD10_Dot_Coil_Num, client, 16448, 1222888){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD11, client, 16448, 1222890)
					{
						 Name = "Item_12",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD11_Dot_Extend_CMD, client, 16448, 1222890){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD11_Dot_Retract_CMD, client, 16448, 1222891){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD11_Dot_CY_PL, client, 16448, 1222892){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD11_Dot_CY_NL, client, 16448, 1222893){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD11_Dot_Coil_Num, client, 16448, 1222894){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD12, client, 16448, 1222896)
					{
						 Name = "Item_13",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD12_Dot_Extend_CMD, client, 16448, 1222896){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD12_Dot_Retract_CMD, client, 16448, 1222897){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD12_Dot_CY_PL, client, 16448, 1222898){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD12_Dot_CY_NL, client, 16448, 1222899){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD12_Dot_Coil_Num, client, 16448, 1222900){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD13, client, 16448, 1222902)
					{
						 Name = "Item_14",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD13_Dot_Extend_CMD, client, 16448, 1222902){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD13_Dot_Retract_CMD, client, 16448, 1222903){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD13_Dot_CY_PL, client, 16448, 1222904){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD13_Dot_CY_NL, client, 16448, 1222905){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD13_Dot_Coil_Num, client, 16448, 1222906){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD14, client, 16448, 1222908)
					{
						 Name = "Item_15",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD14_Dot_Extend_CMD, client, 16448, 1222908){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD14_Dot_Retract_CMD, client, 16448, 1222909){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD14_Dot_CY_PL, client, 16448, 1222910){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD14_Dot_CY_NL, client, 16448, 1222911){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD14_Dot_Coil_Num, client, 16448, 1222912){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD15, client, 16448, 1222914)
					{
						 Name = "Item_16",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD15_Dot_Extend_CMD, client, 16448, 1222914){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD15_Dot_Retract_CMD, client, 16448, 1222915){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD15_Dot_CY_PL, client, 16448, 1222916){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD15_Dot_CY_NL, client, 16448, 1222917){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD15_Dot_Coil_Num, client, 16448, 1222918){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD16, client, 16448, 1222920)
					{
						 Name = "Item_17",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD16_Dot_Extend_CMD, client, 16448, 1222920){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD16_Dot_Retract_CMD, client, 16448, 1222921){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD16_Dot_CY_PL, client, 16448, 1222922){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD16_Dot_CY_NL, client, 16448, 1222923){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD16_Dot_Coil_Num, client, 16448, 1222924){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD17, client, 16448, 1222926)
					{
						 Name = "Item_18",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD17_Dot_Extend_CMD, client, 16448, 1222926){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD17_Dot_Retract_CMD, client, 16448, 1222927){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD17_Dot_CY_PL, client, 16448, 1222928){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD17_Dot_CY_NL, client, 16448, 1222929){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD17_Dot_Coil_Num, client, 16448, 1222930){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD18, client, 16448, 1222932)
					{
						 Name = "Item_19",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD18_Dot_Extend_CMD, client, 16448, 1222932){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD18_Dot_Retract_CMD, client, 16448, 1222933){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD18_Dot_CY_PL, client, 16448, 1222934){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD18_Dot_CY_NL, client, 16448, 1222935){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD18_Dot_Coil_Num, client, 16448, 1222936){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD19, client, 16448, 1222938)
					{
						 Name = "Item_20",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD19_Dot_Extend_CMD, client, 16448, 1222938){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD19_Dot_Retract_CMD, client, 16448, 1222939){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD19_Dot_CY_PL, client, 16448, 1222940){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD19_Dot_CY_NL, client, 16448, 1222941){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD19_Dot_Coil_Num, client, 16448, 1222942){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD20, client, 16448, 1222944)
					{
						 Name = "Item_21",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD20_Dot_Extend_CMD, client, 16448, 1222944){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD20_Dot_Retract_CMD, client, 16448, 1222945){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD20_Dot_CY_PL, client, 16448, 1222946){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD20_Dot_CY_NL, client, 16448, 1222947){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD20_Dot_Coil_Num, client, 16448, 1222948){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD21, client, 16448, 1222950)
					{
						 Name = "Item_22",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD21_Dot_Extend_CMD, client, 16448, 1222950){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD21_Dot_Retract_CMD, client, 16448, 1222951){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD21_Dot_CY_PL, client, 16448, 1222952){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD21_Dot_CY_NL, client, 16448, 1222953){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD21_Dot_Coil_Num, client, 16448, 1222954){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD22, client, 16448, 1222956)
					{
						 Name = "Item_23",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD22_Dot_Extend_CMD, client, 16448, 1222956){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD22_Dot_Retract_CMD, client, 16448, 1222957){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD22_Dot_CY_PL, client, 16448, 1222958){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD22_Dot_CY_NL, client, 16448, 1222959){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD22_Dot_Coil_Num, client, 16448, 1222960){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD23, client, 16448, 1222962)
					{
						 Name = "Item_24",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD23_Dot_Extend_CMD, client, 16448, 1222962){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD23_Dot_Retract_CMD, client, 16448, 1222963){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD23_Dot_CY_PL, client, 16448, 1222964){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD23_Dot_CY_NL, client, 16448, 1222965){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD23_Dot_Coil_Num, client, 16448, 1222966){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD24, client, 16448, 1222968)
					{
						 Name = "Item_25",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD24_Dot_Extend_CMD, client, 16448, 1222968){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD24_Dot_Retract_CMD, client, 16448, 1222969){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD24_Dot_CY_PL, client, 16448, 1222970){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD24_Dot_CY_NL, client, 16448, 1222971){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD24_Dot_Coil_Num, client, 16448, 1222972){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD25, client, 16448, 1222974)
					{
						 Name = "Item_26",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD25_Dot_Extend_CMD, client, 16448, 1222974){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD25_Dot_Retract_CMD, client, 16448, 1222975){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD25_Dot_CY_PL, client, 16448, 1222976){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD25_Dot_CY_NL, client, 16448, 1222977){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD25_Dot_Coil_Num, client, 16448, 1222978){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD26, client, 16448, 1222980)
					{
						 Name = "Item_27",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD26_Dot_Extend_CMD, client, 16448, 1222980){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD26_Dot_Retract_CMD, client, 16448, 1222981){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD26_Dot_CY_PL, client, 16448, 1222982){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD26_Dot_CY_NL, client, 16448, 1222983){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD26_Dot_Coil_Num, client, 16448, 1222984){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD27, client, 16448, 1222986)
					{
						 Name = "Item_28",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD27_Dot_Extend_CMD, client, 16448, 1222986){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD27_Dot_Retract_CMD, client, 16448, 1222987){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD27_Dot_CY_PL, client, 16448, 1222988){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD27_Dot_CY_NL, client, 16448, 1222989){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD27_Dot_Coil_Num, client, 16448, 1222990){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD28, client, 16448, 1222992)
					{
						 Name = "Item_29",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD28_Dot_Extend_CMD, client, 16448, 1222992){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD28_Dot_Retract_CMD, client, 16448, 1222993){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD28_Dot_CY_PL, client, 16448, 1222994){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD28_Dot_CY_NL, client, 16448, 1222995){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD28_Dot_Coil_Num, client, 16448, 1222996){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD29, client, 16448, 1222998)
					{
						 Name = "Item_30",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD29_Dot_Extend_CMD, client, 16448, 1222998){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD29_Dot_Retract_CMD, client, 16448, 1222999){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD29_Dot_CY_PL, client, 16448, 1223000){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD29_Dot_CY_NL, client, 16448, 1223001){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD29_Dot_Coil_Num, client, 16448, 1223002){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD30, client, 16448, 1223004)
					{
						 Name = "Item_31",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD30_Dot_Extend_CMD, client, 16448, 1223004){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD30_Dot_Retract_CMD, client, 16448, 1223005){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD30_Dot_CY_PL, client, 16448, 1223006){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD30_Dot_CY_NL, client, 16448, 1223007){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD30_Dot_Coil_Num, client, 16448, 1223008){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD31, client, 16448, 1223010)
					{
						 Name = "Item_32",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD31_Dot_Extend_CMD, client, 16448, 1223010){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD31_Dot_Retract_CMD, client, 16448, 1223011){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD31_Dot_CY_PL, client, 16448, 1223012){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD31_Dot_CY_NL, client, 16448, 1223013){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD31_Dot_Coil_Num, client, 16448, 1223014){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD32, client, 16448, 1223016)
					{
						 Name = "Item_33",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD32_Dot_Extend_CMD, client, 16448, 1223016){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD32_Dot_Retract_CMD, client, 16448, 1223017){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD32_Dot_CY_PL, client, 16448, 1223018){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD32_Dot_CY_NL, client, 16448, 1223019){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD32_Dot_Coil_Num, client, 16448, 1223020){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD33, client, 16448, 1223022)
					{
						 Name = "Item_34",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD33_Dot_Extend_CMD, client, 16448, 1223022){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD33_Dot_Retract_CMD, client, 16448, 1223023){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD33_Dot_CY_PL, client, 16448, 1223024){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD33_Dot_CY_NL, client, 16448, 1223025){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD33_Dot_Coil_Num, client, 16448, 1223026){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD34, client, 16448, 1223028)
					{
						 Name = "Item_35",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD34_Dot_Extend_CMD, client, 16448, 1223028){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD34_Dot_Retract_CMD, client, 16448, 1223029){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD34_Dot_CY_PL, client, 16448, 1223030){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD34_Dot_CY_NL, client, 16448, 1223031){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD34_Dot_Coil_Num, client, 16448, 1223032){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD35, client, 16448, 1223034)
					{
						 Name = "Item_36",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD35_Dot_Extend_CMD, client, 16448, 1223034){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD35_Dot_Retract_CMD, client, 16448, 1223035){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD35_Dot_CY_PL, client, 16448, 1223036){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD35_Dot_CY_NL, client, 16448, 1223037){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD35_Dot_Coil_Num, client, 16448, 1223038){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD36, client, 16448, 1223040)
					{
						 Name = "Item_37",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD36_Dot_Extend_CMD, client, 16448, 1223040){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD36_Dot_Retract_CMD, client, 16448, 1223041){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD36_Dot_CY_PL, client, 16448, 1223042){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD36_Dot_CY_NL, client, 16448, 1223043){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD36_Dot_Coil_Num, client, 16448, 1223044){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD37, client, 16448, 1223046)
					{
						 Name = "Item_38",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD37_Dot_Extend_CMD, client, 16448, 1223046){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD37_Dot_Retract_CMD, client, 16448, 1223047){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD37_Dot_CY_PL, client, 16448, 1223048){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD37_Dot_CY_NL, client, 16448, 1223049){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD37_Dot_Coil_Num, client, 16448, 1223050){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD38, client, 16448, 1223052)
					{
						 Name = "Item_39",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD38_Dot_Extend_CMD, client, 16448, 1223052){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD38_Dot_Retract_CMD, client, 16448, 1223053){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD38_Dot_CY_PL, client, 16448, 1223054){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD38_Dot_CY_NL, client, 16448, 1223055){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD38_Dot_Coil_Num, client, 16448, 1223056){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD39, client, 16448, 1223058)
					{
						 Name = "Item_40",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD39_Dot_Extend_CMD, client, 16448, 1223058){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD39_Dot_Retract_CMD, client, 16448, 1223059){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD39_Dot_CY_PL, client, 16448, 1223060){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD39_Dot_CY_NL, client, 16448, 1223061){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD39_Dot_Coil_Num, client, 16448, 1223062){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD40, client, 16448, 1223064)
					{
						 Name = "Item_41",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD40_Dot_Extend_CMD, client, 16448, 1223064){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD40_Dot_Retract_CMD, client, 16448, 1223065){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD40_Dot_CY_PL, client, 16448, 1223066){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD40_Dot_CY_NL, client, 16448, 1223067){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD40_Dot_Coil_Num, client, 16448, 1223068){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD41, client, 16448, 1223070)
					{
						 Name = "Item_42",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD41_Dot_Extend_CMD, client, 16448, 1223070){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD41_Dot_Retract_CMD, client, 16448, 1223071){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD41_Dot_CY_PL, client, 16448, 1223072){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD41_Dot_CY_NL, client, 16448, 1223073){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD41_Dot_Coil_Num, client, 16448, 1223074){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD42, client, 16448, 1223076)
					{
						 Name = "Item_43",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD42_Dot_Extend_CMD, client, 16448, 1223076){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD42_Dot_Retract_CMD, client, 16448, 1223077){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD42_Dot_CY_PL, client, 16448, 1223078){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD42_Dot_CY_NL, client, 16448, 1223079){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD42_Dot_Coil_Num, client, 16448, 1223080){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD43, client, 16448, 1223082)
					{
						 Name = "Item_44",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD43_Dot_Extend_CMD, client, 16448, 1223082){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD43_Dot_Retract_CMD, client, 16448, 1223083){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD43_Dot_CY_PL, client, 16448, 1223084){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD43_Dot_CY_NL, client, 16448, 1223085){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD43_Dot_Coil_Num, client, 16448, 1223086){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD44, client, 16448, 1223088)
					{
						 Name = "Item_45",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD44_Dot_Extend_CMD, client, 16448, 1223088){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD44_Dot_Retract_CMD, client, 16448, 1223089){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD44_Dot_CY_PL, client, 16448, 1223090){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD44_Dot_CY_NL, client, 16448, 1223091){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD44_Dot_Coil_Num, client, 16448, 1223092){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD45, client, 16448, 1223094)
					{
						 Name = "Item_46",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD45_Dot_Extend_CMD, client, 16448, 1223094){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD45_Dot_Retract_CMD, client, 16448, 1223095){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD45_Dot_CY_PL, client, 16448, 1223096){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD45_Dot_CY_NL, client, 16448, 1223097){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD45_Dot_Coil_Num, client, 16448, 1223098){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD46, client, 16448, 1223100)
					{
						 Name = "Item_47",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD46_Dot_Extend_CMD, client, 16448, 1223100){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD46_Dot_Retract_CMD, client, 16448, 1223101){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD46_Dot_CY_PL, client, 16448, 1223102){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD46_Dot_CY_NL, client, 16448, 1223103){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD46_Dot_Coil_Num, client, 16448, 1223104){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD47, client, 16448, 1223106)
					{
						 Name = "Item_48",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD47_Dot_Extend_CMD, client, 16448, 1223106){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD47_Dot_Retract_CMD, client, 16448, 1223107){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD47_Dot_CY_PL, client, 16448, 1223108){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD47_Dot_CY_NL, client, 16448, 1223109){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD47_Dot_Coil_Num, client, 16448, 1223110){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD48, client, 16448, 1223112)
					{
						 Name = "Item_49",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD48_Dot_Extend_CMD, client, 16448, 1223112){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD48_Dot_Retract_CMD, client, 16448, 1223113){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD48_Dot_CY_PL, client, 16448, 1223114){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD48_Dot_CY_NL, client, 16448, 1223115){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD48_Dot_Coil_Num, client, 16448, 1223116){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD49, client, 16448, 1223118)
					{
						 Name = "Item_50",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD49_Dot_Extend_CMD, client, 16448, 1223118){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD49_Dot_Retract_CMD, client, 16448, 1223119){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD49_Dot_CY_PL, client, 16448, 1223120){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD49_Dot_CY_NL, client, 16448, 1223121){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD49_Dot_Coil_Num, client, 16448, 1223122){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD50, client, 16448, 1223124)
					{
						 Name = "Item_51",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD50_Dot_Extend_CMD, client, 16448, 1223124){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD50_Dot_Retract_CMD, client, 16448, 1223125){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD50_Dot_CY_PL, client, 16448, 1223126){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD50_Dot_CY_NL, client, 16448, 1223127){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD50_Dot_Coil_Num, client, 16448, 1223128){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD51, client, 16448, 1223130)
					{
						 Name = "Item_52",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD51_Dot_Extend_CMD, client, 16448, 1223130){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD51_Dot_Retract_CMD, client, 16448, 1223131){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD51_Dot_CY_PL, client, 16448, 1223132){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD51_Dot_CY_NL, client, 16448, 1223133){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD51_Dot_Coil_Num, client, 16448, 1223134){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD52, client, 16448, 1223136)
					{
						 Name = "Item_53",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD52_Dot_Extend_CMD, client, 16448, 1223136){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD52_Dot_Retract_CMD, client, 16448, 1223137){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD52_Dot_CY_PL, client, 16448, 1223138){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD52_Dot_CY_NL, client, 16448, 1223139){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD52_Dot_Coil_Num, client, 16448, 1223140){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD53, client, 16448, 1223142)
					{
						 Name = "Item_54",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD53_Dot_Extend_CMD, client, 16448, 1223142){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD53_Dot_Retract_CMD, client, 16448, 1223143){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD53_Dot_CY_PL, client, 16448, 1223144){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD53_Dot_CY_NL, client, 16448, 1223145){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD53_Dot_Coil_Num, client, 16448, 1223146){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD54, client, 16448, 1223148)
					{
						 Name = "Item_55",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD54_Dot_Extend_CMD, client, 16448, 1223148){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD54_Dot_Retract_CMD, client, 16448, 1223149){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD54_Dot_CY_PL, client, 16448, 1223150){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD54_Dot_CY_NL, client, 16448, 1223151){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD54_Dot_Coil_Num, client, 16448, 1223152){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD55, client, 16448, 1223154)
					{
						 Name = "Item_56",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD55_Dot_Extend_CMD, client, 16448, 1223154){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD55_Dot_Retract_CMD, client, 16448, 1223155){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD55_Dot_CY_PL, client, 16448, 1223156){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD55_Dot_CY_NL, client, 16448, 1223157){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD55_Dot_Coil_Num, client, 16448, 1223158){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD56, client, 16448, 1223160)
					{
						 Name = "Item_57",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD56_Dot_Extend_CMD, client, 16448, 1223160){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD56_Dot_Retract_CMD, client, 16448, 1223161){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD56_Dot_CY_PL, client, 16448, 1223162){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD56_Dot_CY_NL, client, 16448, 1223163){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD56_Dot_Coil_Num, client, 16448, 1223164){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD57, client, 16448, 1223166)
					{
						 Name = "Item_58",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD57_Dot_Extend_CMD, client, 16448, 1223166){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD57_Dot_Retract_CMD, client, 16448, 1223167){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD57_Dot_CY_PL, client, 16448, 1223168){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD57_Dot_CY_NL, client, 16448, 1223169){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD57_Dot_Coil_Num, client, 16448, 1223170){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD58, client, 16448, 1223172)
					{
						 Name = "Item_59",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD58_Dot_Extend_CMD, client, 16448, 1223172){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD58_Dot_Retract_CMD, client, 16448, 1223173){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD58_Dot_CY_PL, client, 16448, 1223174){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD58_Dot_CY_NL, client, 16448, 1223175){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD58_Dot_Coil_Num, client, 16448, 1223176){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD59, client, 16448, 1223178)
					{
						 Name = "Item_60",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD59_Dot_Extend_CMD, client, 16448, 1223178){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD59_Dot_Retract_CMD, client, 16448, 1223179){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD59_Dot_CY_PL, client, 16448, 1223180){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD59_Dot_CY_NL, client, 16448, 1223181){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD59_Dot_Coil_Num, client, 16448, 1223182){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD60, client, 16448, 1223184)
					{
						 Name = "Item_61",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD60_Dot_Extend_CMD, client, 16448, 1223184){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD60_Dot_Retract_CMD, client, 16448, 1223185){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD60_Dot_CY_PL, client, 16448, 1223186){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD60_Dot_CY_NL, client, 16448, 1223187){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD60_Dot_Coil_Num, client, 16448, 1223188){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD61, client, 16448, 1223190)
					{
						 Name = "Item_62",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD61_Dot_Extend_CMD, client, 16448, 1223190){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD61_Dot_Retract_CMD, client, 16448, 1223191){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD61_Dot_CY_PL, client, 16448, 1223192){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD61_Dot_CY_NL, client, 16448, 1223193){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD61_Dot_Coil_Num, client, 16448, 1223194){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD62, client, 16448, 1223196)
					{
						 Name = "Item_63",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD62_Dot_Extend_CMD, client, 16448, 1223196){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD62_Dot_Retract_CMD, client, 16448, 1223197){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD62_Dot_CY_PL, client, 16448, 1223198){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD62_Dot_CY_NL, client, 16448, 1223199){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD62_Dot_Coil_Num, client, 16448, 1223200){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD63, client, 16448, 1223202)
					{
						 Name = "Item_64",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD63_Dot_Extend_CMD, client, 16448, 1223202){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD63_Dot_Retract_CMD, client, 16448, 1223203){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD63_Dot_CY_PL, client, 16448, 1223204){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD63_Dot_CY_NL, client, 16448, 1223205){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD63_Dot_Coil_Num, client, 16448, 1223206){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD64, client, 16448, 1223208)
					{
						 Name = "Item_65",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD64_Dot_Extend_CMD, client, 16448, 1223208){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD64_Dot_Retract_CMD, client, 16448, 1223209){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD64_Dot_CY_PL, client, 16448, 1223210){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD64_Dot_CY_NL, client, 16448, 1223211){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD64_Dot_Coil_Num, client, 16448, 1223212){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD65, client, 16448, 1223214)
					{
						 Name = "Item_66",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD65_Dot_Extend_CMD, client, 16448, 1223214){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD65_Dot_Retract_CMD, client, 16448, 1223215){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD65_Dot_CY_PL, client, 16448, 1223216){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD65_Dot_CY_NL, client, 16448, 1223217){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD65_Dot_Coil_Num, client, 16448, 1223218){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD66, client, 16448, 1223220)
					{
						 Name = "Item_67",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD66_Dot_Extend_CMD, client, 16448, 1223220){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD66_Dot_Retract_CMD, client, 16448, 1223221){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD66_Dot_CY_PL, client, 16448, 1223222){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD66_Dot_CY_NL, client, 16448, 1223223){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD66_Dot_Coil_Num, client, 16448, 1223224){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD67, client, 16448, 1223226)
					{
						 Name = "Item_68",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD67_Dot_Extend_CMD, client, 16448, 1223226){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD67_Dot_Retract_CMD, client, 16448, 1223227){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD67_Dot_CY_PL, client, 16448, 1223228){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD67_Dot_CY_NL, client, 16448, 1223229){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD67_Dot_Coil_Num, client, 16448, 1223230){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD68, client, 16448, 1223232)
					{
						 Name = "Item_69",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD68_Dot_Extend_CMD, client, 16448, 1223232){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD68_Dot_Retract_CMD, client, 16448, 1223233){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD68_Dot_CY_PL, client, 16448, 1223234){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD68_Dot_CY_NL, client, 16448, 1223235){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD68_Dot_Coil_Num, client, 16448, 1223236){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD69, client, 16448, 1223238)
					{
						 Name = "Item_70",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD69_Dot_Extend_CMD, client, 16448, 1223238){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD69_Dot_Retract_CMD, client, 16448, 1223239){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD69_Dot_CY_PL, client, 16448, 1223240){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD69_Dot_CY_NL, client, 16448, 1223241){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD69_Dot_Coil_Num, client, 16448, 1223242){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD70, client, 16448, 1223244)
					{
						 Name = "Item_71",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD70_Dot_Extend_CMD, client, 16448, 1223244){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD70_Dot_Retract_CMD, client, 16448, 1223245){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD70_Dot_CY_PL, client, 16448, 1223246){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD70_Dot_CY_NL, client, 16448, 1223247){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD70_Dot_Coil_Num, client, 16448, 1223248){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD71, client, 16448, 1223250)
					{
						 Name = "Item_72",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD71_Dot_Extend_CMD, client, 16448, 1223250){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD71_Dot_Retract_CMD, client, 16448, 1223251){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD71_Dot_CY_PL, client, 16448, 1223252){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD71_Dot_CY_NL, client, 16448, 1223253){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD71_Dot_Coil_Num, client, 16448, 1223254){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD72, client, 16448, 1223256)
					{
						 Name = "Item_73",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD72_Dot_Extend_CMD, client, 16448, 1223256){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD72_Dot_Retract_CMD, client, 16448, 1223257){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD72_Dot_CY_PL, client, 16448, 1223258){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD72_Dot_CY_NL, client, 16448, 1223259){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD72_Dot_Coil_Num, client, 16448, 1223260){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD73, client, 16448, 1223262)
					{
						 Name = "Item_74",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD73_Dot_Extend_CMD, client, 16448, 1223262){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD73_Dot_Retract_CMD, client, 16448, 1223263){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD73_Dot_CY_PL, client, 16448, 1223264){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD73_Dot_CY_NL, client, 16448, 1223265){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD73_Dot_Coil_Num, client, 16448, 1223266){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD74, client, 16448, 1223268)
					{
						 Name = "Item_75",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD74_Dot_Extend_CMD, client, 16448, 1223268){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD74_Dot_Retract_CMD, client, 16448, 1223269){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD74_Dot_CY_PL, client, 16448, 1223270){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD74_Dot_CY_NL, client, 16448, 1223271){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD74_Dot_Coil_Num, client, 16448, 1223272){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD75, client, 16448, 1223274)
					{
						 Name = "Item_76",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD75_Dot_Extend_CMD, client, 16448, 1223274){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD75_Dot_Retract_CMD, client, 16448, 1223275){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD75_Dot_CY_PL, client, 16448, 1223276){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD75_Dot_CY_NL, client, 16448, 1223277){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD75_Dot_Coil_Num, client, 16448, 1223278){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD76, client, 16448, 1223280)
					{
						 Name = "Item_77",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD76_Dot_Extend_CMD, client, 16448, 1223280){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD76_Dot_Retract_CMD, client, 16448, 1223281){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD76_Dot_CY_PL, client, 16448, 1223282){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD76_Dot_CY_NL, client, 16448, 1223283){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD76_Dot_Coil_Num, client, 16448, 1223284){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD77, client, 16448, 1223286)
					{
						 Name = "Item_78",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD77_Dot_Extend_CMD, client, 16448, 1223286){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD77_Dot_Retract_CMD, client, 16448, 1223287){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD77_Dot_CY_PL, client, 16448, 1223288){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD77_Dot_CY_NL, client, 16448, 1223289){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD77_Dot_Coil_Num, client, 16448, 1223290){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD78, client, 16448, 1223292)
					{
						 Name = "Item_79",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD78_Dot_Extend_CMD, client, 16448, 1223292){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD78_Dot_Retract_CMD, client, 16448, 1223293){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD78_Dot_CY_PL, client, 16448, 1223294){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD78_Dot_CY_NL, client, 16448, 1223295){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD78_Dot_Coil_Num, client, 16448, 1223296){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD79, client, 16448, 1223298)
					{
						 Name = "Item_80",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD79_Dot_Extend_CMD, client, 16448, 1223298){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD79_Dot_Retract_CMD, client, 16448, 1223299){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD79_Dot_CY_PL, client, 16448, 1223300){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD79_Dot_CY_NL, client, 16448, 1223301){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD79_Dot_Coil_Num, client, 16448, 1223302){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD80, client, 16448, 1223304)
					{
						 Name = "Item_81",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD80_Dot_Extend_CMD, client, 16448, 1223304){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD80_Dot_Retract_CMD, client, 16448, 1223305){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD80_Dot_CY_PL, client, 16448, 1223306){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD80_Dot_CY_NL, client, 16448, 1223307){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD80_Dot_Coil_Num, client, 16448, 1223308){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD81, client, 16448, 1223310)
					{
						 Name = "Item_82",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD81_Dot_Extend_CMD, client, 16448, 1223310){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD81_Dot_Retract_CMD, client, 16448, 1223311){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD81_Dot_CY_PL, client, 16448, 1223312){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD81_Dot_CY_NL, client, 16448, 1223313){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD81_Dot_Coil_Num, client, 16448, 1223314){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD82, client, 16448, 1223316)
					{
						 Name = "Item_83",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD82_Dot_Extend_CMD, client, 16448, 1223316){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD82_Dot_Retract_CMD, client, 16448, 1223317){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD82_Dot_CY_PL, client, 16448, 1223318){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD82_Dot_CY_NL, client, 16448, 1223319){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD82_Dot_Coil_Num, client, 16448, 1223320){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD83, client, 16448, 1223322)
					{
						 Name = "Item_84",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD83_Dot_Extend_CMD, client, 16448, 1223322){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD83_Dot_Retract_CMD, client, 16448, 1223323){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD83_Dot_CY_PL, client, 16448, 1223324){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD83_Dot_CY_NL, client, 16448, 1223325){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD83_Dot_Coil_Num, client, 16448, 1223326){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD84, client, 16448, 1223328)
					{
						 Name = "Item_85",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD84_Dot_Extend_CMD, client, 16448, 1223328){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD84_Dot_Retract_CMD, client, 16448, 1223329){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD84_Dot_CY_PL, client, 16448, 1223330){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD84_Dot_CY_NL, client, 16448, 1223331){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD84_Dot_Coil_Num, client, 16448, 1223332){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD85, client, 16448, 1223334)
					{
						 Name = "Item_86",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD85_Dot_Extend_CMD, client, 16448, 1223334){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD85_Dot_Retract_CMD, client, 16448, 1223335){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD85_Dot_CY_PL, client, 16448, 1223336){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD85_Dot_CY_NL, client, 16448, 1223337){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD85_Dot_Coil_Num, client, 16448, 1223338){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD86, client, 16448, 1223340)
					{
						 Name = "Item_87",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD86_Dot_Extend_CMD, client, 16448, 1223340){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD86_Dot_Retract_CMD, client, 16448, 1223341){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD86_Dot_CY_PL, client, 16448, 1223342){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD86_Dot_CY_NL, client, 16448, 1223343){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD86_Dot_Coil_Num, client, 16448, 1223344){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD87, client, 16448, 1223346)
					{
						 Name = "Item_88",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD87_Dot_Extend_CMD, client, 16448, 1223346){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD87_Dot_Retract_CMD, client, 16448, 1223347){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD87_Dot_CY_PL, client, 16448, 1223348){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD87_Dot_CY_NL, client, 16448, 1223349){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD87_Dot_Coil_Num, client, 16448, 1223350){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD88, client, 16448, 1223352)
					{
						 Name = "Item_89",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD88_Dot_Extend_CMD, client, 16448, 1223352){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD88_Dot_Retract_CMD, client, 16448, 1223353){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD88_Dot_CY_PL, client, 16448, 1223354){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD88_Dot_CY_NL, client, 16448, 1223355){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD88_Dot_Coil_Num, client, 16448, 1223356){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD89, client, 16448, 1223358)
					{
						 Name = "Item_90",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD89_Dot_Extend_CMD, client, 16448, 1223358){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD89_Dot_Retract_CMD, client, 16448, 1223359){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD89_Dot_CY_PL, client, 16448, 1223360){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD89_Dot_CY_NL, client, 16448, 1223361){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD89_Dot_Coil_Num, client, 16448, 1223362){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD90, client, 16448, 1223364)
					{
						 Name = "Item_91",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD90_Dot_Extend_CMD, client, 16448, 1223364){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD90_Dot_Retract_CMD, client, 16448, 1223365){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD90_Dot_CY_PL, client, 16448, 1223366){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD90_Dot_CY_NL, client, 16448, 1223367){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD90_Dot_Coil_Num, client, 16448, 1223368){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD91, client, 16448, 1223370)
					{
						 Name = "Item_92",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD91_Dot_Extend_CMD, client, 16448, 1223370){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD91_Dot_Retract_CMD, client, 16448, 1223371){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD91_Dot_CY_PL, client, 16448, 1223372){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD91_Dot_CY_NL, client, 16448, 1223373){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD91_Dot_Coil_Num, client, 16448, 1223374){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD92, client, 16448, 1223376)
					{
						 Name = "Item_93",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD92_Dot_Extend_CMD, client, 16448, 1223376){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD92_Dot_Retract_CMD, client, 16448, 1223377){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD92_Dot_CY_PL, client, 16448, 1223378){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD92_Dot_CY_NL, client, 16448, 1223379){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD92_Dot_Coil_Num, client, 16448, 1223380){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD93, client, 16448, 1223382)
					{
						 Name = "Item_94",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD93_Dot_Extend_CMD, client, 16448, 1223382){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD93_Dot_Retract_CMD, client, 16448, 1223383){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD93_Dot_CY_PL, client, 16448, 1223384){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD93_Dot_CY_NL, client, 16448, 1223385){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD93_Dot_Coil_Num, client, 16448, 1223386){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD94, client, 16448, 1223388)
					{
						 Name = "Item_95",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD94_Dot_Extend_CMD, client, 16448, 1223388){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD94_Dot_Retract_CMD, client, 16448, 1223389){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD94_Dot_CY_PL, client, 16448, 1223390){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD94_Dot_CY_NL, client, 16448, 1223391){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD94_Dot_Coil_Num, client, 16448, 1223392){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD95, client, 16448, 1223394)
					{
						 Name = "Item_96",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD95_Dot_Extend_CMD, client, 16448, 1223394){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD95_Dot_Retract_CMD, client, 16448, 1223395){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD95_Dot_CY_PL, client, 16448, 1223396){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD95_Dot_CY_NL, client, 16448, 1223397){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD95_Dot_Coil_Num, client, 16448, 1223398){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD96, client, 16448, 1223400)
					{
						 Name = "Item_97",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD96_Dot_Extend_CMD, client, 16448, 1223400){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD96_Dot_Retract_CMD, client, 16448, 1223401){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD96_Dot_CY_PL, client, 16448, 1223402){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD96_Dot_CY_NL, client, 16448, 1223403){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD96_Dot_Coil_Num, client, 16448, 1223404){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD97, client, 16448, 1223406)
					{
						 Name = "Item_98",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD97_Dot_Extend_CMD, client, 16448, 1223406){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD97_Dot_Retract_CMD, client, 16448, 1223407){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD97_Dot_CY_PL, client, 16448, 1223408){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD97_Dot_CY_NL, client, 16448, 1223409){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD97_Dot_Coil_Num, client, 16448, 1223410){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD98, client, 16448, 1223412)
					{
						 Name = "Item_99",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD98_Dot_Extend_CMD, client, 16448, 1223412){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD98_Dot_Retract_CMD, client, 16448, 1223413){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD98_Dot_CY_PL, client, 16448, 1223414){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD98_Dot_CY_NL, client, 16448, 1223415){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD98_Dot_Coil_Num, client, 16448, 1223416){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_Manual_CMD99, client, 16448, 1223418)
					{
						 Name = "Item_100",
						Extend_CMD = new BeckhoffBool(this.GetCY_Manual_CMD99_Dot_Extend_CMD, client, 16448, 1223418){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_Manual_CMD99_Dot_Retract_CMD, client, 16448, 1223419){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_Manual_CMD99_Dot_CY_PL, client, 16448, 1223420){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_Manual_CMD99_Dot_CY_NL, client, 16448, 1223421){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_Manual_CMD99_Dot_Coil_Num, client, 16448, 1223422){ Name = "Coil_Num" },
					},
			}, false){ Name = "CY_Manual_CMD" };
			CY_AUTO_CMD = new BeckhoffStructArray<DUT_CY_CMD100, DUT_CY_CMDWrapper, DUT_CY_CMD>(this.GetCY_AUTO_CMD, client, 16448, 1223424,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1223424 ,1223430 ,1223436 ,1223442 ,1223448 ,1223454 ,1223460 ,1223466 ,1223472 ,1223478 ,1223484 ,1223490 ,1223496 ,1223502 ,1223508 ,1223514 ,1223520 ,1223526 ,1223532 ,1223538 ,1223544 ,1223550 ,1223556 ,1223562 ,1223568 ,1223574 ,1223580 ,1223586 ,1223592 ,1223598 ,1223604 ,1223610 ,1223616 ,1223622 ,1223628 ,1223634 ,1223640 ,1223646 ,1223652 ,1223658 ,1223664 ,1223670 ,1223676 ,1223682 ,1223688 ,1223694 ,1223700 ,1223706 ,1223712 ,1223718 ,1223724 ,1223730 ,1223736 ,1223742 ,1223748 ,1223754 ,1223760 ,1223766 ,1223772 ,1223778 ,1223784 ,1223790 ,1223796 ,1223802 ,1223808 ,1223814 ,1223820 ,1223826 ,1223832 ,1223838 ,1223844 ,1223850 ,1223856 ,1223862 ,1223868 ,1223874 ,1223880 ,1223886 ,1223892 ,1223898 ,1223904 ,1223910 ,1223916 ,1223922 ,1223928 ,1223934 ,1223940 ,1223946 ,1223952 ,1223958 ,1223964 ,1223970 ,1223976 ,1223982 ,1223988 ,1223994 ,1224000 ,1224006 ,1224012 ,1224018 , },
				new DUT_CY_CMDWrapper[]
				{
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD0, client, 16448, 1223424)
					{
						 Name = "Item_1",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD0_Dot_Extend_CMD, client, 16448, 1223424){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD0_Dot_Retract_CMD, client, 16448, 1223425){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD0_Dot_CY_PL, client, 16448, 1223426){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD0_Dot_CY_NL, client, 16448, 1223427){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD0_Dot_Coil_Num, client, 16448, 1223428){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD1, client, 16448, 1223430)
					{
						 Name = "Item_2",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD1_Dot_Extend_CMD, client, 16448, 1223430){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD1_Dot_Retract_CMD, client, 16448, 1223431){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD1_Dot_CY_PL, client, 16448, 1223432){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD1_Dot_CY_NL, client, 16448, 1223433){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD1_Dot_Coil_Num, client, 16448, 1223434){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD2, client, 16448, 1223436)
					{
						 Name = "Item_3",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD2_Dot_Extend_CMD, client, 16448, 1223436){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD2_Dot_Retract_CMD, client, 16448, 1223437){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD2_Dot_CY_PL, client, 16448, 1223438){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD2_Dot_CY_NL, client, 16448, 1223439){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD2_Dot_Coil_Num, client, 16448, 1223440){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD3, client, 16448, 1223442)
					{
						 Name = "Item_4",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD3_Dot_Extend_CMD, client, 16448, 1223442){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD3_Dot_Retract_CMD, client, 16448, 1223443){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD3_Dot_CY_PL, client, 16448, 1223444){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD3_Dot_CY_NL, client, 16448, 1223445){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD3_Dot_Coil_Num, client, 16448, 1223446){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD4, client, 16448, 1223448)
					{
						 Name = "Item_5",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD4_Dot_Extend_CMD, client, 16448, 1223448){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD4_Dot_Retract_CMD, client, 16448, 1223449){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD4_Dot_CY_PL, client, 16448, 1223450){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD4_Dot_CY_NL, client, 16448, 1223451){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD4_Dot_Coil_Num, client, 16448, 1223452){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD5, client, 16448, 1223454)
					{
						 Name = "Item_6",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD5_Dot_Extend_CMD, client, 16448, 1223454){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD5_Dot_Retract_CMD, client, 16448, 1223455){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD5_Dot_CY_PL, client, 16448, 1223456){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD5_Dot_CY_NL, client, 16448, 1223457){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD5_Dot_Coil_Num, client, 16448, 1223458){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD6, client, 16448, 1223460)
					{
						 Name = "Item_7",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD6_Dot_Extend_CMD, client, 16448, 1223460){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD6_Dot_Retract_CMD, client, 16448, 1223461){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD6_Dot_CY_PL, client, 16448, 1223462){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD6_Dot_CY_NL, client, 16448, 1223463){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD6_Dot_Coil_Num, client, 16448, 1223464){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD7, client, 16448, 1223466)
					{
						 Name = "Item_8",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD7_Dot_Extend_CMD, client, 16448, 1223466){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD7_Dot_Retract_CMD, client, 16448, 1223467){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD7_Dot_CY_PL, client, 16448, 1223468){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD7_Dot_CY_NL, client, 16448, 1223469){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD7_Dot_Coil_Num, client, 16448, 1223470){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD8, client, 16448, 1223472)
					{
						 Name = "Item_9",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD8_Dot_Extend_CMD, client, 16448, 1223472){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD8_Dot_Retract_CMD, client, 16448, 1223473){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD8_Dot_CY_PL, client, 16448, 1223474){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD8_Dot_CY_NL, client, 16448, 1223475){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD8_Dot_Coil_Num, client, 16448, 1223476){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD9, client, 16448, 1223478)
					{
						 Name = "Item_10",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD9_Dot_Extend_CMD, client, 16448, 1223478){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD9_Dot_Retract_CMD, client, 16448, 1223479){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD9_Dot_CY_PL, client, 16448, 1223480){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD9_Dot_CY_NL, client, 16448, 1223481){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD9_Dot_Coil_Num, client, 16448, 1223482){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD10, client, 16448, 1223484)
					{
						 Name = "Item_11",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD10_Dot_Extend_CMD, client, 16448, 1223484){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD10_Dot_Retract_CMD, client, 16448, 1223485){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD10_Dot_CY_PL, client, 16448, 1223486){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD10_Dot_CY_NL, client, 16448, 1223487){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD10_Dot_Coil_Num, client, 16448, 1223488){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD11, client, 16448, 1223490)
					{
						 Name = "Item_12",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD11_Dot_Extend_CMD, client, 16448, 1223490){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD11_Dot_Retract_CMD, client, 16448, 1223491){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD11_Dot_CY_PL, client, 16448, 1223492){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD11_Dot_CY_NL, client, 16448, 1223493){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD11_Dot_Coil_Num, client, 16448, 1223494){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD12, client, 16448, 1223496)
					{
						 Name = "Item_13",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD12_Dot_Extend_CMD, client, 16448, 1223496){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD12_Dot_Retract_CMD, client, 16448, 1223497){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD12_Dot_CY_PL, client, 16448, 1223498){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD12_Dot_CY_NL, client, 16448, 1223499){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD12_Dot_Coil_Num, client, 16448, 1223500){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD13, client, 16448, 1223502)
					{
						 Name = "Item_14",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD13_Dot_Extend_CMD, client, 16448, 1223502){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD13_Dot_Retract_CMD, client, 16448, 1223503){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD13_Dot_CY_PL, client, 16448, 1223504){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD13_Dot_CY_NL, client, 16448, 1223505){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD13_Dot_Coil_Num, client, 16448, 1223506){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD14, client, 16448, 1223508)
					{
						 Name = "Item_15",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD14_Dot_Extend_CMD, client, 16448, 1223508){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD14_Dot_Retract_CMD, client, 16448, 1223509){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD14_Dot_CY_PL, client, 16448, 1223510){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD14_Dot_CY_NL, client, 16448, 1223511){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD14_Dot_Coil_Num, client, 16448, 1223512){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD15, client, 16448, 1223514)
					{
						 Name = "Item_16",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD15_Dot_Extend_CMD, client, 16448, 1223514){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD15_Dot_Retract_CMD, client, 16448, 1223515){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD15_Dot_CY_PL, client, 16448, 1223516){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD15_Dot_CY_NL, client, 16448, 1223517){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD15_Dot_Coil_Num, client, 16448, 1223518){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD16, client, 16448, 1223520)
					{
						 Name = "Item_17",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD16_Dot_Extend_CMD, client, 16448, 1223520){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD16_Dot_Retract_CMD, client, 16448, 1223521){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD16_Dot_CY_PL, client, 16448, 1223522){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD16_Dot_CY_NL, client, 16448, 1223523){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD16_Dot_Coil_Num, client, 16448, 1223524){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD17, client, 16448, 1223526)
					{
						 Name = "Item_18",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD17_Dot_Extend_CMD, client, 16448, 1223526){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD17_Dot_Retract_CMD, client, 16448, 1223527){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD17_Dot_CY_PL, client, 16448, 1223528){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD17_Dot_CY_NL, client, 16448, 1223529){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD17_Dot_Coil_Num, client, 16448, 1223530){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD18, client, 16448, 1223532)
					{
						 Name = "Item_19",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD18_Dot_Extend_CMD, client, 16448, 1223532){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD18_Dot_Retract_CMD, client, 16448, 1223533){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD18_Dot_CY_PL, client, 16448, 1223534){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD18_Dot_CY_NL, client, 16448, 1223535){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD18_Dot_Coil_Num, client, 16448, 1223536){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD19, client, 16448, 1223538)
					{
						 Name = "Item_20",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD19_Dot_Extend_CMD, client, 16448, 1223538){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD19_Dot_Retract_CMD, client, 16448, 1223539){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD19_Dot_CY_PL, client, 16448, 1223540){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD19_Dot_CY_NL, client, 16448, 1223541){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD19_Dot_Coil_Num, client, 16448, 1223542){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD20, client, 16448, 1223544)
					{
						 Name = "Item_21",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD20_Dot_Extend_CMD, client, 16448, 1223544){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD20_Dot_Retract_CMD, client, 16448, 1223545){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD20_Dot_CY_PL, client, 16448, 1223546){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD20_Dot_CY_NL, client, 16448, 1223547){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD20_Dot_Coil_Num, client, 16448, 1223548){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD21, client, 16448, 1223550)
					{
						 Name = "Item_22",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD21_Dot_Extend_CMD, client, 16448, 1223550){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD21_Dot_Retract_CMD, client, 16448, 1223551){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD21_Dot_CY_PL, client, 16448, 1223552){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD21_Dot_CY_NL, client, 16448, 1223553){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD21_Dot_Coil_Num, client, 16448, 1223554){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD22, client, 16448, 1223556)
					{
						 Name = "Item_23",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD22_Dot_Extend_CMD, client, 16448, 1223556){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD22_Dot_Retract_CMD, client, 16448, 1223557){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD22_Dot_CY_PL, client, 16448, 1223558){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD22_Dot_CY_NL, client, 16448, 1223559){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD22_Dot_Coil_Num, client, 16448, 1223560){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD23, client, 16448, 1223562)
					{
						 Name = "Item_24",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD23_Dot_Extend_CMD, client, 16448, 1223562){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD23_Dot_Retract_CMD, client, 16448, 1223563){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD23_Dot_CY_PL, client, 16448, 1223564){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD23_Dot_CY_NL, client, 16448, 1223565){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD23_Dot_Coil_Num, client, 16448, 1223566){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD24, client, 16448, 1223568)
					{
						 Name = "Item_25",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD24_Dot_Extend_CMD, client, 16448, 1223568){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD24_Dot_Retract_CMD, client, 16448, 1223569){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD24_Dot_CY_PL, client, 16448, 1223570){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD24_Dot_CY_NL, client, 16448, 1223571){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD24_Dot_Coil_Num, client, 16448, 1223572){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD25, client, 16448, 1223574)
					{
						 Name = "Item_26",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD25_Dot_Extend_CMD, client, 16448, 1223574){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD25_Dot_Retract_CMD, client, 16448, 1223575){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD25_Dot_CY_PL, client, 16448, 1223576){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD25_Dot_CY_NL, client, 16448, 1223577){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD25_Dot_Coil_Num, client, 16448, 1223578){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD26, client, 16448, 1223580)
					{
						 Name = "Item_27",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD26_Dot_Extend_CMD, client, 16448, 1223580){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD26_Dot_Retract_CMD, client, 16448, 1223581){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD26_Dot_CY_PL, client, 16448, 1223582){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD26_Dot_CY_NL, client, 16448, 1223583){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD26_Dot_Coil_Num, client, 16448, 1223584){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD27, client, 16448, 1223586)
					{
						 Name = "Item_28",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD27_Dot_Extend_CMD, client, 16448, 1223586){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD27_Dot_Retract_CMD, client, 16448, 1223587){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD27_Dot_CY_PL, client, 16448, 1223588){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD27_Dot_CY_NL, client, 16448, 1223589){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD27_Dot_Coil_Num, client, 16448, 1223590){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD28, client, 16448, 1223592)
					{
						 Name = "Item_29",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD28_Dot_Extend_CMD, client, 16448, 1223592){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD28_Dot_Retract_CMD, client, 16448, 1223593){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD28_Dot_CY_PL, client, 16448, 1223594){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD28_Dot_CY_NL, client, 16448, 1223595){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD28_Dot_Coil_Num, client, 16448, 1223596){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD29, client, 16448, 1223598)
					{
						 Name = "Item_30",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD29_Dot_Extend_CMD, client, 16448, 1223598){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD29_Dot_Retract_CMD, client, 16448, 1223599){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD29_Dot_CY_PL, client, 16448, 1223600){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD29_Dot_CY_NL, client, 16448, 1223601){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD29_Dot_Coil_Num, client, 16448, 1223602){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD30, client, 16448, 1223604)
					{
						 Name = "Item_31",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD30_Dot_Extend_CMD, client, 16448, 1223604){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD30_Dot_Retract_CMD, client, 16448, 1223605){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD30_Dot_CY_PL, client, 16448, 1223606){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD30_Dot_CY_NL, client, 16448, 1223607){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD30_Dot_Coil_Num, client, 16448, 1223608){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD31, client, 16448, 1223610)
					{
						 Name = "Item_32",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD31_Dot_Extend_CMD, client, 16448, 1223610){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD31_Dot_Retract_CMD, client, 16448, 1223611){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD31_Dot_CY_PL, client, 16448, 1223612){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD31_Dot_CY_NL, client, 16448, 1223613){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD31_Dot_Coil_Num, client, 16448, 1223614){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD32, client, 16448, 1223616)
					{
						 Name = "Item_33",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD32_Dot_Extend_CMD, client, 16448, 1223616){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD32_Dot_Retract_CMD, client, 16448, 1223617){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD32_Dot_CY_PL, client, 16448, 1223618){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD32_Dot_CY_NL, client, 16448, 1223619){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD32_Dot_Coil_Num, client, 16448, 1223620){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD33, client, 16448, 1223622)
					{
						 Name = "Item_34",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD33_Dot_Extend_CMD, client, 16448, 1223622){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD33_Dot_Retract_CMD, client, 16448, 1223623){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD33_Dot_CY_PL, client, 16448, 1223624){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD33_Dot_CY_NL, client, 16448, 1223625){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD33_Dot_Coil_Num, client, 16448, 1223626){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD34, client, 16448, 1223628)
					{
						 Name = "Item_35",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD34_Dot_Extend_CMD, client, 16448, 1223628){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD34_Dot_Retract_CMD, client, 16448, 1223629){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD34_Dot_CY_PL, client, 16448, 1223630){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD34_Dot_CY_NL, client, 16448, 1223631){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD34_Dot_Coil_Num, client, 16448, 1223632){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD35, client, 16448, 1223634)
					{
						 Name = "Item_36",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD35_Dot_Extend_CMD, client, 16448, 1223634){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD35_Dot_Retract_CMD, client, 16448, 1223635){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD35_Dot_CY_PL, client, 16448, 1223636){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD35_Dot_CY_NL, client, 16448, 1223637){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD35_Dot_Coil_Num, client, 16448, 1223638){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD36, client, 16448, 1223640)
					{
						 Name = "Item_37",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD36_Dot_Extend_CMD, client, 16448, 1223640){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD36_Dot_Retract_CMD, client, 16448, 1223641){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD36_Dot_CY_PL, client, 16448, 1223642){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD36_Dot_CY_NL, client, 16448, 1223643){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD36_Dot_Coil_Num, client, 16448, 1223644){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD37, client, 16448, 1223646)
					{
						 Name = "Item_38",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD37_Dot_Extend_CMD, client, 16448, 1223646){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD37_Dot_Retract_CMD, client, 16448, 1223647){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD37_Dot_CY_PL, client, 16448, 1223648){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD37_Dot_CY_NL, client, 16448, 1223649){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD37_Dot_Coil_Num, client, 16448, 1223650){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD38, client, 16448, 1223652)
					{
						 Name = "Item_39",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD38_Dot_Extend_CMD, client, 16448, 1223652){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD38_Dot_Retract_CMD, client, 16448, 1223653){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD38_Dot_CY_PL, client, 16448, 1223654){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD38_Dot_CY_NL, client, 16448, 1223655){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD38_Dot_Coil_Num, client, 16448, 1223656){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD39, client, 16448, 1223658)
					{
						 Name = "Item_40",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD39_Dot_Extend_CMD, client, 16448, 1223658){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD39_Dot_Retract_CMD, client, 16448, 1223659){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD39_Dot_CY_PL, client, 16448, 1223660){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD39_Dot_CY_NL, client, 16448, 1223661){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD39_Dot_Coil_Num, client, 16448, 1223662){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD40, client, 16448, 1223664)
					{
						 Name = "Item_41",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD40_Dot_Extend_CMD, client, 16448, 1223664){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD40_Dot_Retract_CMD, client, 16448, 1223665){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD40_Dot_CY_PL, client, 16448, 1223666){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD40_Dot_CY_NL, client, 16448, 1223667){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD40_Dot_Coil_Num, client, 16448, 1223668){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD41, client, 16448, 1223670)
					{
						 Name = "Item_42",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD41_Dot_Extend_CMD, client, 16448, 1223670){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD41_Dot_Retract_CMD, client, 16448, 1223671){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD41_Dot_CY_PL, client, 16448, 1223672){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD41_Dot_CY_NL, client, 16448, 1223673){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD41_Dot_Coil_Num, client, 16448, 1223674){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD42, client, 16448, 1223676)
					{
						 Name = "Item_43",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD42_Dot_Extend_CMD, client, 16448, 1223676){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD42_Dot_Retract_CMD, client, 16448, 1223677){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD42_Dot_CY_PL, client, 16448, 1223678){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD42_Dot_CY_NL, client, 16448, 1223679){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD42_Dot_Coil_Num, client, 16448, 1223680){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD43, client, 16448, 1223682)
					{
						 Name = "Item_44",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD43_Dot_Extend_CMD, client, 16448, 1223682){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD43_Dot_Retract_CMD, client, 16448, 1223683){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD43_Dot_CY_PL, client, 16448, 1223684){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD43_Dot_CY_NL, client, 16448, 1223685){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD43_Dot_Coil_Num, client, 16448, 1223686){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD44, client, 16448, 1223688)
					{
						 Name = "Item_45",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD44_Dot_Extend_CMD, client, 16448, 1223688){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD44_Dot_Retract_CMD, client, 16448, 1223689){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD44_Dot_CY_PL, client, 16448, 1223690){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD44_Dot_CY_NL, client, 16448, 1223691){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD44_Dot_Coil_Num, client, 16448, 1223692){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD45, client, 16448, 1223694)
					{
						 Name = "Item_46",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD45_Dot_Extend_CMD, client, 16448, 1223694){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD45_Dot_Retract_CMD, client, 16448, 1223695){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD45_Dot_CY_PL, client, 16448, 1223696){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD45_Dot_CY_NL, client, 16448, 1223697){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD45_Dot_Coil_Num, client, 16448, 1223698){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD46, client, 16448, 1223700)
					{
						 Name = "Item_47",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD46_Dot_Extend_CMD, client, 16448, 1223700){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD46_Dot_Retract_CMD, client, 16448, 1223701){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD46_Dot_CY_PL, client, 16448, 1223702){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD46_Dot_CY_NL, client, 16448, 1223703){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD46_Dot_Coil_Num, client, 16448, 1223704){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD47, client, 16448, 1223706)
					{
						 Name = "Item_48",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD47_Dot_Extend_CMD, client, 16448, 1223706){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD47_Dot_Retract_CMD, client, 16448, 1223707){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD47_Dot_CY_PL, client, 16448, 1223708){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD47_Dot_CY_NL, client, 16448, 1223709){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD47_Dot_Coil_Num, client, 16448, 1223710){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD48, client, 16448, 1223712)
					{
						 Name = "Item_49",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD48_Dot_Extend_CMD, client, 16448, 1223712){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD48_Dot_Retract_CMD, client, 16448, 1223713){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD48_Dot_CY_PL, client, 16448, 1223714){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD48_Dot_CY_NL, client, 16448, 1223715){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD48_Dot_Coil_Num, client, 16448, 1223716){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD49, client, 16448, 1223718)
					{
						 Name = "Item_50",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD49_Dot_Extend_CMD, client, 16448, 1223718){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD49_Dot_Retract_CMD, client, 16448, 1223719){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD49_Dot_CY_PL, client, 16448, 1223720){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD49_Dot_CY_NL, client, 16448, 1223721){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD49_Dot_Coil_Num, client, 16448, 1223722){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD50, client, 16448, 1223724)
					{
						 Name = "Item_51",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD50_Dot_Extend_CMD, client, 16448, 1223724){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD50_Dot_Retract_CMD, client, 16448, 1223725){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD50_Dot_CY_PL, client, 16448, 1223726){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD50_Dot_CY_NL, client, 16448, 1223727){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD50_Dot_Coil_Num, client, 16448, 1223728){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD51, client, 16448, 1223730)
					{
						 Name = "Item_52",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD51_Dot_Extend_CMD, client, 16448, 1223730){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD51_Dot_Retract_CMD, client, 16448, 1223731){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD51_Dot_CY_PL, client, 16448, 1223732){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD51_Dot_CY_NL, client, 16448, 1223733){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD51_Dot_Coil_Num, client, 16448, 1223734){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD52, client, 16448, 1223736)
					{
						 Name = "Item_53",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD52_Dot_Extend_CMD, client, 16448, 1223736){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD52_Dot_Retract_CMD, client, 16448, 1223737){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD52_Dot_CY_PL, client, 16448, 1223738){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD52_Dot_CY_NL, client, 16448, 1223739){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD52_Dot_Coil_Num, client, 16448, 1223740){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD53, client, 16448, 1223742)
					{
						 Name = "Item_54",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD53_Dot_Extend_CMD, client, 16448, 1223742){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD53_Dot_Retract_CMD, client, 16448, 1223743){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD53_Dot_CY_PL, client, 16448, 1223744){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD53_Dot_CY_NL, client, 16448, 1223745){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD53_Dot_Coil_Num, client, 16448, 1223746){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD54, client, 16448, 1223748)
					{
						 Name = "Item_55",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD54_Dot_Extend_CMD, client, 16448, 1223748){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD54_Dot_Retract_CMD, client, 16448, 1223749){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD54_Dot_CY_PL, client, 16448, 1223750){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD54_Dot_CY_NL, client, 16448, 1223751){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD54_Dot_Coil_Num, client, 16448, 1223752){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD55, client, 16448, 1223754)
					{
						 Name = "Item_56",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD55_Dot_Extend_CMD, client, 16448, 1223754){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD55_Dot_Retract_CMD, client, 16448, 1223755){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD55_Dot_CY_PL, client, 16448, 1223756){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD55_Dot_CY_NL, client, 16448, 1223757){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD55_Dot_Coil_Num, client, 16448, 1223758){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD56, client, 16448, 1223760)
					{
						 Name = "Item_57",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD56_Dot_Extend_CMD, client, 16448, 1223760){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD56_Dot_Retract_CMD, client, 16448, 1223761){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD56_Dot_CY_PL, client, 16448, 1223762){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD56_Dot_CY_NL, client, 16448, 1223763){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD56_Dot_Coil_Num, client, 16448, 1223764){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD57, client, 16448, 1223766)
					{
						 Name = "Item_58",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD57_Dot_Extend_CMD, client, 16448, 1223766){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD57_Dot_Retract_CMD, client, 16448, 1223767){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD57_Dot_CY_PL, client, 16448, 1223768){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD57_Dot_CY_NL, client, 16448, 1223769){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD57_Dot_Coil_Num, client, 16448, 1223770){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD58, client, 16448, 1223772)
					{
						 Name = "Item_59",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD58_Dot_Extend_CMD, client, 16448, 1223772){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD58_Dot_Retract_CMD, client, 16448, 1223773){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD58_Dot_CY_PL, client, 16448, 1223774){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD58_Dot_CY_NL, client, 16448, 1223775){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD58_Dot_Coil_Num, client, 16448, 1223776){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD59, client, 16448, 1223778)
					{
						 Name = "Item_60",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD59_Dot_Extend_CMD, client, 16448, 1223778){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD59_Dot_Retract_CMD, client, 16448, 1223779){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD59_Dot_CY_PL, client, 16448, 1223780){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD59_Dot_CY_NL, client, 16448, 1223781){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD59_Dot_Coil_Num, client, 16448, 1223782){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD60, client, 16448, 1223784)
					{
						 Name = "Item_61",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD60_Dot_Extend_CMD, client, 16448, 1223784){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD60_Dot_Retract_CMD, client, 16448, 1223785){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD60_Dot_CY_PL, client, 16448, 1223786){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD60_Dot_CY_NL, client, 16448, 1223787){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD60_Dot_Coil_Num, client, 16448, 1223788){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD61, client, 16448, 1223790)
					{
						 Name = "Item_62",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD61_Dot_Extend_CMD, client, 16448, 1223790){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD61_Dot_Retract_CMD, client, 16448, 1223791){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD61_Dot_CY_PL, client, 16448, 1223792){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD61_Dot_CY_NL, client, 16448, 1223793){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD61_Dot_Coil_Num, client, 16448, 1223794){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD62, client, 16448, 1223796)
					{
						 Name = "Item_63",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD62_Dot_Extend_CMD, client, 16448, 1223796){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD62_Dot_Retract_CMD, client, 16448, 1223797){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD62_Dot_CY_PL, client, 16448, 1223798){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD62_Dot_CY_NL, client, 16448, 1223799){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD62_Dot_Coil_Num, client, 16448, 1223800){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD63, client, 16448, 1223802)
					{
						 Name = "Item_64",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD63_Dot_Extend_CMD, client, 16448, 1223802){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD63_Dot_Retract_CMD, client, 16448, 1223803){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD63_Dot_CY_PL, client, 16448, 1223804){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD63_Dot_CY_NL, client, 16448, 1223805){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD63_Dot_Coil_Num, client, 16448, 1223806){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD64, client, 16448, 1223808)
					{
						 Name = "Item_65",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD64_Dot_Extend_CMD, client, 16448, 1223808){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD64_Dot_Retract_CMD, client, 16448, 1223809){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD64_Dot_CY_PL, client, 16448, 1223810){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD64_Dot_CY_NL, client, 16448, 1223811){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD64_Dot_Coil_Num, client, 16448, 1223812){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD65, client, 16448, 1223814)
					{
						 Name = "Item_66",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD65_Dot_Extend_CMD, client, 16448, 1223814){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD65_Dot_Retract_CMD, client, 16448, 1223815){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD65_Dot_CY_PL, client, 16448, 1223816){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD65_Dot_CY_NL, client, 16448, 1223817){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD65_Dot_Coil_Num, client, 16448, 1223818){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD66, client, 16448, 1223820)
					{
						 Name = "Item_67",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD66_Dot_Extend_CMD, client, 16448, 1223820){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD66_Dot_Retract_CMD, client, 16448, 1223821){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD66_Dot_CY_PL, client, 16448, 1223822){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD66_Dot_CY_NL, client, 16448, 1223823){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD66_Dot_Coil_Num, client, 16448, 1223824){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD67, client, 16448, 1223826)
					{
						 Name = "Item_68",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD67_Dot_Extend_CMD, client, 16448, 1223826){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD67_Dot_Retract_CMD, client, 16448, 1223827){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD67_Dot_CY_PL, client, 16448, 1223828){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD67_Dot_CY_NL, client, 16448, 1223829){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD67_Dot_Coil_Num, client, 16448, 1223830){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD68, client, 16448, 1223832)
					{
						 Name = "Item_69",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD68_Dot_Extend_CMD, client, 16448, 1223832){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD68_Dot_Retract_CMD, client, 16448, 1223833){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD68_Dot_CY_PL, client, 16448, 1223834){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD68_Dot_CY_NL, client, 16448, 1223835){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD68_Dot_Coil_Num, client, 16448, 1223836){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD69, client, 16448, 1223838)
					{
						 Name = "Item_70",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD69_Dot_Extend_CMD, client, 16448, 1223838){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD69_Dot_Retract_CMD, client, 16448, 1223839){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD69_Dot_CY_PL, client, 16448, 1223840){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD69_Dot_CY_NL, client, 16448, 1223841){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD69_Dot_Coil_Num, client, 16448, 1223842){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD70, client, 16448, 1223844)
					{
						 Name = "Item_71",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD70_Dot_Extend_CMD, client, 16448, 1223844){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD70_Dot_Retract_CMD, client, 16448, 1223845){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD70_Dot_CY_PL, client, 16448, 1223846){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD70_Dot_CY_NL, client, 16448, 1223847){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD70_Dot_Coil_Num, client, 16448, 1223848){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD71, client, 16448, 1223850)
					{
						 Name = "Item_72",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD71_Dot_Extend_CMD, client, 16448, 1223850){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD71_Dot_Retract_CMD, client, 16448, 1223851){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD71_Dot_CY_PL, client, 16448, 1223852){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD71_Dot_CY_NL, client, 16448, 1223853){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD71_Dot_Coil_Num, client, 16448, 1223854){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD72, client, 16448, 1223856)
					{
						 Name = "Item_73",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD72_Dot_Extend_CMD, client, 16448, 1223856){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD72_Dot_Retract_CMD, client, 16448, 1223857){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD72_Dot_CY_PL, client, 16448, 1223858){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD72_Dot_CY_NL, client, 16448, 1223859){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD72_Dot_Coil_Num, client, 16448, 1223860){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD73, client, 16448, 1223862)
					{
						 Name = "Item_74",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD73_Dot_Extend_CMD, client, 16448, 1223862){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD73_Dot_Retract_CMD, client, 16448, 1223863){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD73_Dot_CY_PL, client, 16448, 1223864){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD73_Dot_CY_NL, client, 16448, 1223865){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD73_Dot_Coil_Num, client, 16448, 1223866){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD74, client, 16448, 1223868)
					{
						 Name = "Item_75",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD74_Dot_Extend_CMD, client, 16448, 1223868){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD74_Dot_Retract_CMD, client, 16448, 1223869){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD74_Dot_CY_PL, client, 16448, 1223870){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD74_Dot_CY_NL, client, 16448, 1223871){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD74_Dot_Coil_Num, client, 16448, 1223872){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD75, client, 16448, 1223874)
					{
						 Name = "Item_76",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD75_Dot_Extend_CMD, client, 16448, 1223874){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD75_Dot_Retract_CMD, client, 16448, 1223875){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD75_Dot_CY_PL, client, 16448, 1223876){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD75_Dot_CY_NL, client, 16448, 1223877){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD75_Dot_Coil_Num, client, 16448, 1223878){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD76, client, 16448, 1223880)
					{
						 Name = "Item_77",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD76_Dot_Extend_CMD, client, 16448, 1223880){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD76_Dot_Retract_CMD, client, 16448, 1223881){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD76_Dot_CY_PL, client, 16448, 1223882){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD76_Dot_CY_NL, client, 16448, 1223883){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD76_Dot_Coil_Num, client, 16448, 1223884){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD77, client, 16448, 1223886)
					{
						 Name = "Item_78",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD77_Dot_Extend_CMD, client, 16448, 1223886){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD77_Dot_Retract_CMD, client, 16448, 1223887){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD77_Dot_CY_PL, client, 16448, 1223888){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD77_Dot_CY_NL, client, 16448, 1223889){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD77_Dot_Coil_Num, client, 16448, 1223890){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD78, client, 16448, 1223892)
					{
						 Name = "Item_79",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD78_Dot_Extend_CMD, client, 16448, 1223892){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD78_Dot_Retract_CMD, client, 16448, 1223893){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD78_Dot_CY_PL, client, 16448, 1223894){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD78_Dot_CY_NL, client, 16448, 1223895){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD78_Dot_Coil_Num, client, 16448, 1223896){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD79, client, 16448, 1223898)
					{
						 Name = "Item_80",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD79_Dot_Extend_CMD, client, 16448, 1223898){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD79_Dot_Retract_CMD, client, 16448, 1223899){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD79_Dot_CY_PL, client, 16448, 1223900){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD79_Dot_CY_NL, client, 16448, 1223901){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD79_Dot_Coil_Num, client, 16448, 1223902){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD80, client, 16448, 1223904)
					{
						 Name = "Item_81",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD80_Dot_Extend_CMD, client, 16448, 1223904){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD80_Dot_Retract_CMD, client, 16448, 1223905){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD80_Dot_CY_PL, client, 16448, 1223906){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD80_Dot_CY_NL, client, 16448, 1223907){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD80_Dot_Coil_Num, client, 16448, 1223908){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD81, client, 16448, 1223910)
					{
						 Name = "Item_82",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD81_Dot_Extend_CMD, client, 16448, 1223910){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD81_Dot_Retract_CMD, client, 16448, 1223911){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD81_Dot_CY_PL, client, 16448, 1223912){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD81_Dot_CY_NL, client, 16448, 1223913){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD81_Dot_Coil_Num, client, 16448, 1223914){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD82, client, 16448, 1223916)
					{
						 Name = "Item_83",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD82_Dot_Extend_CMD, client, 16448, 1223916){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD82_Dot_Retract_CMD, client, 16448, 1223917){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD82_Dot_CY_PL, client, 16448, 1223918){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD82_Dot_CY_NL, client, 16448, 1223919){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD82_Dot_Coil_Num, client, 16448, 1223920){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD83, client, 16448, 1223922)
					{
						 Name = "Item_84",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD83_Dot_Extend_CMD, client, 16448, 1223922){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD83_Dot_Retract_CMD, client, 16448, 1223923){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD83_Dot_CY_PL, client, 16448, 1223924){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD83_Dot_CY_NL, client, 16448, 1223925){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD83_Dot_Coil_Num, client, 16448, 1223926){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD84, client, 16448, 1223928)
					{
						 Name = "Item_85",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD84_Dot_Extend_CMD, client, 16448, 1223928){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD84_Dot_Retract_CMD, client, 16448, 1223929){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD84_Dot_CY_PL, client, 16448, 1223930){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD84_Dot_CY_NL, client, 16448, 1223931){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD84_Dot_Coil_Num, client, 16448, 1223932){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD85, client, 16448, 1223934)
					{
						 Name = "Item_86",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD85_Dot_Extend_CMD, client, 16448, 1223934){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD85_Dot_Retract_CMD, client, 16448, 1223935){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD85_Dot_CY_PL, client, 16448, 1223936){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD85_Dot_CY_NL, client, 16448, 1223937){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD85_Dot_Coil_Num, client, 16448, 1223938){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD86, client, 16448, 1223940)
					{
						 Name = "Item_87",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD86_Dot_Extend_CMD, client, 16448, 1223940){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD86_Dot_Retract_CMD, client, 16448, 1223941){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD86_Dot_CY_PL, client, 16448, 1223942){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD86_Dot_CY_NL, client, 16448, 1223943){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD86_Dot_Coil_Num, client, 16448, 1223944){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD87, client, 16448, 1223946)
					{
						 Name = "Item_88",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD87_Dot_Extend_CMD, client, 16448, 1223946){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD87_Dot_Retract_CMD, client, 16448, 1223947){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD87_Dot_CY_PL, client, 16448, 1223948){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD87_Dot_CY_NL, client, 16448, 1223949){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD87_Dot_Coil_Num, client, 16448, 1223950){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD88, client, 16448, 1223952)
					{
						 Name = "Item_89",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD88_Dot_Extend_CMD, client, 16448, 1223952){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD88_Dot_Retract_CMD, client, 16448, 1223953){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD88_Dot_CY_PL, client, 16448, 1223954){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD88_Dot_CY_NL, client, 16448, 1223955){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD88_Dot_Coil_Num, client, 16448, 1223956){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD89, client, 16448, 1223958)
					{
						 Name = "Item_90",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD89_Dot_Extend_CMD, client, 16448, 1223958){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD89_Dot_Retract_CMD, client, 16448, 1223959){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD89_Dot_CY_PL, client, 16448, 1223960){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD89_Dot_CY_NL, client, 16448, 1223961){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD89_Dot_Coil_Num, client, 16448, 1223962){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD90, client, 16448, 1223964)
					{
						 Name = "Item_91",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD90_Dot_Extend_CMD, client, 16448, 1223964){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD90_Dot_Retract_CMD, client, 16448, 1223965){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD90_Dot_CY_PL, client, 16448, 1223966){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD90_Dot_CY_NL, client, 16448, 1223967){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD90_Dot_Coil_Num, client, 16448, 1223968){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD91, client, 16448, 1223970)
					{
						 Name = "Item_92",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD91_Dot_Extend_CMD, client, 16448, 1223970){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD91_Dot_Retract_CMD, client, 16448, 1223971){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD91_Dot_CY_PL, client, 16448, 1223972){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD91_Dot_CY_NL, client, 16448, 1223973){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD91_Dot_Coil_Num, client, 16448, 1223974){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD92, client, 16448, 1223976)
					{
						 Name = "Item_93",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD92_Dot_Extend_CMD, client, 16448, 1223976){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD92_Dot_Retract_CMD, client, 16448, 1223977){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD92_Dot_CY_PL, client, 16448, 1223978){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD92_Dot_CY_NL, client, 16448, 1223979){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD92_Dot_Coil_Num, client, 16448, 1223980){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD93, client, 16448, 1223982)
					{
						 Name = "Item_94",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD93_Dot_Extend_CMD, client, 16448, 1223982){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD93_Dot_Retract_CMD, client, 16448, 1223983){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD93_Dot_CY_PL, client, 16448, 1223984){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD93_Dot_CY_NL, client, 16448, 1223985){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD93_Dot_Coil_Num, client, 16448, 1223986){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD94, client, 16448, 1223988)
					{
						 Name = "Item_95",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD94_Dot_Extend_CMD, client, 16448, 1223988){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD94_Dot_Retract_CMD, client, 16448, 1223989){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD94_Dot_CY_PL, client, 16448, 1223990){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD94_Dot_CY_NL, client, 16448, 1223991){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD94_Dot_Coil_Num, client, 16448, 1223992){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD95, client, 16448, 1223994)
					{
						 Name = "Item_96",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD95_Dot_Extend_CMD, client, 16448, 1223994){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD95_Dot_Retract_CMD, client, 16448, 1223995){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD95_Dot_CY_PL, client, 16448, 1223996){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD95_Dot_CY_NL, client, 16448, 1223997){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD95_Dot_Coil_Num, client, 16448, 1223998){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD96, client, 16448, 1224000)
					{
						 Name = "Item_97",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD96_Dot_Extend_CMD, client, 16448, 1224000){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD96_Dot_Retract_CMD, client, 16448, 1224001){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD96_Dot_CY_PL, client, 16448, 1224002){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD96_Dot_CY_NL, client, 16448, 1224003){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD96_Dot_Coil_Num, client, 16448, 1224004){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD97, client, 16448, 1224006)
					{
						 Name = "Item_98",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD97_Dot_Extend_CMD, client, 16448, 1224006){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD97_Dot_Retract_CMD, client, 16448, 1224007){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD97_Dot_CY_PL, client, 16448, 1224008){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD97_Dot_CY_NL, client, 16448, 1224009){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD97_Dot_Coil_Num, client, 16448, 1224010){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD98, client, 16448, 1224012)
					{
						 Name = "Item_99",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD98_Dot_Extend_CMD, client, 16448, 1224012){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD98_Dot_Retract_CMD, client, 16448, 1224013){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD98_Dot_CY_PL, client, 16448, 1224014){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD98_Dot_CY_NL, client, 16448, 1224015){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD98_Dot_Coil_Num, client, 16448, 1224016){ Name = "Coil_Num" },
					},
					new DUT_CY_CMDWrapper(this.GetCY_AUTO_CMD99, client, 16448, 1224018)
					{
						 Name = "Item_100",
						Extend_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD99_Dot_Extend_CMD, client, 16448, 1224018){ Name = "Extend_CMD" },
						Retract_CMD = new BeckhoffBool(this.GetCY_AUTO_CMD99_Dot_Retract_CMD, client, 16448, 1224019){ Name = "Retract_CMD" },
						CY_PL = new BeckhoffBool(this.GetCY_AUTO_CMD99_Dot_CY_PL, client, 16448, 1224020){ Name = "CY_PL" },
						CY_NL = new BeckhoffBool(this.GetCY_AUTO_CMD99_Dot_CY_NL, client, 16448, 1224021){ Name = "CY_NL" },
						Coil_Num = new BeckhoffUShort(this.GetCY_AUTO_CMD99_Dot_Coil_Num, client, 16448, 1224022){ Name = "Coil_Num" },
					},
			}, false){ Name = "CY_AUTO_CMD" };
			CY_State = new BeckhoffStructArray<DUT_CY_STATE100, DUT_CY_STATEWrapper, DUT_CY_STATE>(this.GetCY_State, client, 16448, 1224024,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1224024 ,1224027 ,1224030 ,1224033 ,1224036 ,1224039 ,1224042 ,1224045 ,1224048 ,1224051 ,1224054 ,1224057 ,1224060 ,1224063 ,1224066 ,1224069 ,1224072 ,1224075 ,1224078 ,1224081 ,1224084 ,1224087 ,1224090 ,1224093 ,1224096 ,1224099 ,1224102 ,1224105 ,1224108 ,1224111 ,1224114 ,1224117 ,1224120 ,1224123 ,1224126 ,1224129 ,1224132 ,1224135 ,1224138 ,1224141 ,1224144 ,1224147 ,1224150 ,1224153 ,1224156 ,1224159 ,1224162 ,1224165 ,1224168 ,1224171 ,1224174 ,1224177 ,1224180 ,1224183 ,1224186 ,1224189 ,1224192 ,1224195 ,1224198 ,1224201 ,1224204 ,1224207 ,1224210 ,1224213 ,1224216 ,1224219 ,1224222 ,1224225 ,1224228 ,1224231 ,1224234 ,1224237 ,1224240 ,1224243 ,1224246 ,1224249 ,1224252 ,1224255 ,1224258 ,1224261 ,1224264 ,1224267 ,1224270 ,1224273 ,1224276 ,1224279 ,1224282 ,1224285 ,1224288 ,1224291 ,1224294 ,1224297 ,1224300 ,1224303 ,1224306 ,1224309 ,1224312 ,1224315 ,1224318 ,1224321 , },
				new DUT_CY_STATEWrapper[]
				{
					new DUT_CY_STATEWrapper(this.GetCY_State0, client, 16448, 1224024)
					{
						 Name = "Item_1",
						Out_Retract = new BeckhoffBool(this.GetCY_State0_Dot_Out_Retract, client, 16448, 1224024){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State0_Dot_Out_Extend, client, 16448, 1224025){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State0_Dot_Out_Fault_Alarm, client, 16448, 1224026){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State1, client, 16448, 1224027)
					{
						 Name = "Item_2",
						Out_Retract = new BeckhoffBool(this.GetCY_State1_Dot_Out_Retract, client, 16448, 1224027){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State1_Dot_Out_Extend, client, 16448, 1224028){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State1_Dot_Out_Fault_Alarm, client, 16448, 1224029){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State2, client, 16448, 1224030)
					{
						 Name = "Item_3",
						Out_Retract = new BeckhoffBool(this.GetCY_State2_Dot_Out_Retract, client, 16448, 1224030){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State2_Dot_Out_Extend, client, 16448, 1224031){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State2_Dot_Out_Fault_Alarm, client, 16448, 1224032){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State3, client, 16448, 1224033)
					{
						 Name = "Item_4",
						Out_Retract = new BeckhoffBool(this.GetCY_State3_Dot_Out_Retract, client, 16448, 1224033){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State3_Dot_Out_Extend, client, 16448, 1224034){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State3_Dot_Out_Fault_Alarm, client, 16448, 1224035){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State4, client, 16448, 1224036)
					{
						 Name = "Item_5",
						Out_Retract = new BeckhoffBool(this.GetCY_State4_Dot_Out_Retract, client, 16448, 1224036){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State4_Dot_Out_Extend, client, 16448, 1224037){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State4_Dot_Out_Fault_Alarm, client, 16448, 1224038){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State5, client, 16448, 1224039)
					{
						 Name = "Item_6",
						Out_Retract = new BeckhoffBool(this.GetCY_State5_Dot_Out_Retract, client, 16448, 1224039){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State5_Dot_Out_Extend, client, 16448, 1224040){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State5_Dot_Out_Fault_Alarm, client, 16448, 1224041){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State6, client, 16448, 1224042)
					{
						 Name = "Item_7",
						Out_Retract = new BeckhoffBool(this.GetCY_State6_Dot_Out_Retract, client, 16448, 1224042){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State6_Dot_Out_Extend, client, 16448, 1224043){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State6_Dot_Out_Fault_Alarm, client, 16448, 1224044){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State7, client, 16448, 1224045)
					{
						 Name = "Item_8",
						Out_Retract = new BeckhoffBool(this.GetCY_State7_Dot_Out_Retract, client, 16448, 1224045){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State7_Dot_Out_Extend, client, 16448, 1224046){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State7_Dot_Out_Fault_Alarm, client, 16448, 1224047){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State8, client, 16448, 1224048)
					{
						 Name = "Item_9",
						Out_Retract = new BeckhoffBool(this.GetCY_State8_Dot_Out_Retract, client, 16448, 1224048){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State8_Dot_Out_Extend, client, 16448, 1224049){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State8_Dot_Out_Fault_Alarm, client, 16448, 1224050){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State9, client, 16448, 1224051)
					{
						 Name = "Item_10",
						Out_Retract = new BeckhoffBool(this.GetCY_State9_Dot_Out_Retract, client, 16448, 1224051){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State9_Dot_Out_Extend, client, 16448, 1224052){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State9_Dot_Out_Fault_Alarm, client, 16448, 1224053){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State10, client, 16448, 1224054)
					{
						 Name = "Item_11",
						Out_Retract = new BeckhoffBool(this.GetCY_State10_Dot_Out_Retract, client, 16448, 1224054){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State10_Dot_Out_Extend, client, 16448, 1224055){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State10_Dot_Out_Fault_Alarm, client, 16448, 1224056){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State11, client, 16448, 1224057)
					{
						 Name = "Item_12",
						Out_Retract = new BeckhoffBool(this.GetCY_State11_Dot_Out_Retract, client, 16448, 1224057){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State11_Dot_Out_Extend, client, 16448, 1224058){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State11_Dot_Out_Fault_Alarm, client, 16448, 1224059){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State12, client, 16448, 1224060)
					{
						 Name = "Item_13",
						Out_Retract = new BeckhoffBool(this.GetCY_State12_Dot_Out_Retract, client, 16448, 1224060){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State12_Dot_Out_Extend, client, 16448, 1224061){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State12_Dot_Out_Fault_Alarm, client, 16448, 1224062){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State13, client, 16448, 1224063)
					{
						 Name = "Item_14",
						Out_Retract = new BeckhoffBool(this.GetCY_State13_Dot_Out_Retract, client, 16448, 1224063){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State13_Dot_Out_Extend, client, 16448, 1224064){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State13_Dot_Out_Fault_Alarm, client, 16448, 1224065){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State14, client, 16448, 1224066)
					{
						 Name = "Item_15",
						Out_Retract = new BeckhoffBool(this.GetCY_State14_Dot_Out_Retract, client, 16448, 1224066){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State14_Dot_Out_Extend, client, 16448, 1224067){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State14_Dot_Out_Fault_Alarm, client, 16448, 1224068){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State15, client, 16448, 1224069)
					{
						 Name = "Item_16",
						Out_Retract = new BeckhoffBool(this.GetCY_State15_Dot_Out_Retract, client, 16448, 1224069){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State15_Dot_Out_Extend, client, 16448, 1224070){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State15_Dot_Out_Fault_Alarm, client, 16448, 1224071){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State16, client, 16448, 1224072)
					{
						 Name = "Item_17",
						Out_Retract = new BeckhoffBool(this.GetCY_State16_Dot_Out_Retract, client, 16448, 1224072){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State16_Dot_Out_Extend, client, 16448, 1224073){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State16_Dot_Out_Fault_Alarm, client, 16448, 1224074){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State17, client, 16448, 1224075)
					{
						 Name = "Item_18",
						Out_Retract = new BeckhoffBool(this.GetCY_State17_Dot_Out_Retract, client, 16448, 1224075){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State17_Dot_Out_Extend, client, 16448, 1224076){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State17_Dot_Out_Fault_Alarm, client, 16448, 1224077){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State18, client, 16448, 1224078)
					{
						 Name = "Item_19",
						Out_Retract = new BeckhoffBool(this.GetCY_State18_Dot_Out_Retract, client, 16448, 1224078){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State18_Dot_Out_Extend, client, 16448, 1224079){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State18_Dot_Out_Fault_Alarm, client, 16448, 1224080){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State19, client, 16448, 1224081)
					{
						 Name = "Item_20",
						Out_Retract = new BeckhoffBool(this.GetCY_State19_Dot_Out_Retract, client, 16448, 1224081){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State19_Dot_Out_Extend, client, 16448, 1224082){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State19_Dot_Out_Fault_Alarm, client, 16448, 1224083){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State20, client, 16448, 1224084)
					{
						 Name = "Item_21",
						Out_Retract = new BeckhoffBool(this.GetCY_State20_Dot_Out_Retract, client, 16448, 1224084){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State20_Dot_Out_Extend, client, 16448, 1224085){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State20_Dot_Out_Fault_Alarm, client, 16448, 1224086){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State21, client, 16448, 1224087)
					{
						 Name = "Item_22",
						Out_Retract = new BeckhoffBool(this.GetCY_State21_Dot_Out_Retract, client, 16448, 1224087){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State21_Dot_Out_Extend, client, 16448, 1224088){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State21_Dot_Out_Fault_Alarm, client, 16448, 1224089){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State22, client, 16448, 1224090)
					{
						 Name = "Item_23",
						Out_Retract = new BeckhoffBool(this.GetCY_State22_Dot_Out_Retract, client, 16448, 1224090){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State22_Dot_Out_Extend, client, 16448, 1224091){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State22_Dot_Out_Fault_Alarm, client, 16448, 1224092){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State23, client, 16448, 1224093)
					{
						 Name = "Item_24",
						Out_Retract = new BeckhoffBool(this.GetCY_State23_Dot_Out_Retract, client, 16448, 1224093){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State23_Dot_Out_Extend, client, 16448, 1224094){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State23_Dot_Out_Fault_Alarm, client, 16448, 1224095){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State24, client, 16448, 1224096)
					{
						 Name = "Item_25",
						Out_Retract = new BeckhoffBool(this.GetCY_State24_Dot_Out_Retract, client, 16448, 1224096){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State24_Dot_Out_Extend, client, 16448, 1224097){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State24_Dot_Out_Fault_Alarm, client, 16448, 1224098){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State25, client, 16448, 1224099)
					{
						 Name = "Item_26",
						Out_Retract = new BeckhoffBool(this.GetCY_State25_Dot_Out_Retract, client, 16448, 1224099){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State25_Dot_Out_Extend, client, 16448, 1224100){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State25_Dot_Out_Fault_Alarm, client, 16448, 1224101){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State26, client, 16448, 1224102)
					{
						 Name = "Item_27",
						Out_Retract = new BeckhoffBool(this.GetCY_State26_Dot_Out_Retract, client, 16448, 1224102){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State26_Dot_Out_Extend, client, 16448, 1224103){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State26_Dot_Out_Fault_Alarm, client, 16448, 1224104){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State27, client, 16448, 1224105)
					{
						 Name = "Item_28",
						Out_Retract = new BeckhoffBool(this.GetCY_State27_Dot_Out_Retract, client, 16448, 1224105){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State27_Dot_Out_Extend, client, 16448, 1224106){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State27_Dot_Out_Fault_Alarm, client, 16448, 1224107){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State28, client, 16448, 1224108)
					{
						 Name = "Item_29",
						Out_Retract = new BeckhoffBool(this.GetCY_State28_Dot_Out_Retract, client, 16448, 1224108){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State28_Dot_Out_Extend, client, 16448, 1224109){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State28_Dot_Out_Fault_Alarm, client, 16448, 1224110){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State29, client, 16448, 1224111)
					{
						 Name = "Item_30",
						Out_Retract = new BeckhoffBool(this.GetCY_State29_Dot_Out_Retract, client, 16448, 1224111){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State29_Dot_Out_Extend, client, 16448, 1224112){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State29_Dot_Out_Fault_Alarm, client, 16448, 1224113){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State30, client, 16448, 1224114)
					{
						 Name = "Item_31",
						Out_Retract = new BeckhoffBool(this.GetCY_State30_Dot_Out_Retract, client, 16448, 1224114){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State30_Dot_Out_Extend, client, 16448, 1224115){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State30_Dot_Out_Fault_Alarm, client, 16448, 1224116){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State31, client, 16448, 1224117)
					{
						 Name = "Item_32",
						Out_Retract = new BeckhoffBool(this.GetCY_State31_Dot_Out_Retract, client, 16448, 1224117){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State31_Dot_Out_Extend, client, 16448, 1224118){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State31_Dot_Out_Fault_Alarm, client, 16448, 1224119){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State32, client, 16448, 1224120)
					{
						 Name = "Item_33",
						Out_Retract = new BeckhoffBool(this.GetCY_State32_Dot_Out_Retract, client, 16448, 1224120){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State32_Dot_Out_Extend, client, 16448, 1224121){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State32_Dot_Out_Fault_Alarm, client, 16448, 1224122){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State33, client, 16448, 1224123)
					{
						 Name = "Item_34",
						Out_Retract = new BeckhoffBool(this.GetCY_State33_Dot_Out_Retract, client, 16448, 1224123){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State33_Dot_Out_Extend, client, 16448, 1224124){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State33_Dot_Out_Fault_Alarm, client, 16448, 1224125){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State34, client, 16448, 1224126)
					{
						 Name = "Item_35",
						Out_Retract = new BeckhoffBool(this.GetCY_State34_Dot_Out_Retract, client, 16448, 1224126){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State34_Dot_Out_Extend, client, 16448, 1224127){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State34_Dot_Out_Fault_Alarm, client, 16448, 1224128){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State35, client, 16448, 1224129)
					{
						 Name = "Item_36",
						Out_Retract = new BeckhoffBool(this.GetCY_State35_Dot_Out_Retract, client, 16448, 1224129){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State35_Dot_Out_Extend, client, 16448, 1224130){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State35_Dot_Out_Fault_Alarm, client, 16448, 1224131){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State36, client, 16448, 1224132)
					{
						 Name = "Item_37",
						Out_Retract = new BeckhoffBool(this.GetCY_State36_Dot_Out_Retract, client, 16448, 1224132){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State36_Dot_Out_Extend, client, 16448, 1224133){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State36_Dot_Out_Fault_Alarm, client, 16448, 1224134){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State37, client, 16448, 1224135)
					{
						 Name = "Item_38",
						Out_Retract = new BeckhoffBool(this.GetCY_State37_Dot_Out_Retract, client, 16448, 1224135){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State37_Dot_Out_Extend, client, 16448, 1224136){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State37_Dot_Out_Fault_Alarm, client, 16448, 1224137){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State38, client, 16448, 1224138)
					{
						 Name = "Item_39",
						Out_Retract = new BeckhoffBool(this.GetCY_State38_Dot_Out_Retract, client, 16448, 1224138){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State38_Dot_Out_Extend, client, 16448, 1224139){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State38_Dot_Out_Fault_Alarm, client, 16448, 1224140){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State39, client, 16448, 1224141)
					{
						 Name = "Item_40",
						Out_Retract = new BeckhoffBool(this.GetCY_State39_Dot_Out_Retract, client, 16448, 1224141){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State39_Dot_Out_Extend, client, 16448, 1224142){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State39_Dot_Out_Fault_Alarm, client, 16448, 1224143){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State40, client, 16448, 1224144)
					{
						 Name = "Item_41",
						Out_Retract = new BeckhoffBool(this.GetCY_State40_Dot_Out_Retract, client, 16448, 1224144){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State40_Dot_Out_Extend, client, 16448, 1224145){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State40_Dot_Out_Fault_Alarm, client, 16448, 1224146){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State41, client, 16448, 1224147)
					{
						 Name = "Item_42",
						Out_Retract = new BeckhoffBool(this.GetCY_State41_Dot_Out_Retract, client, 16448, 1224147){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State41_Dot_Out_Extend, client, 16448, 1224148){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State41_Dot_Out_Fault_Alarm, client, 16448, 1224149){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State42, client, 16448, 1224150)
					{
						 Name = "Item_43",
						Out_Retract = new BeckhoffBool(this.GetCY_State42_Dot_Out_Retract, client, 16448, 1224150){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State42_Dot_Out_Extend, client, 16448, 1224151){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State42_Dot_Out_Fault_Alarm, client, 16448, 1224152){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State43, client, 16448, 1224153)
					{
						 Name = "Item_44",
						Out_Retract = new BeckhoffBool(this.GetCY_State43_Dot_Out_Retract, client, 16448, 1224153){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State43_Dot_Out_Extend, client, 16448, 1224154){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State43_Dot_Out_Fault_Alarm, client, 16448, 1224155){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State44, client, 16448, 1224156)
					{
						 Name = "Item_45",
						Out_Retract = new BeckhoffBool(this.GetCY_State44_Dot_Out_Retract, client, 16448, 1224156){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State44_Dot_Out_Extend, client, 16448, 1224157){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State44_Dot_Out_Fault_Alarm, client, 16448, 1224158){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State45, client, 16448, 1224159)
					{
						 Name = "Item_46",
						Out_Retract = new BeckhoffBool(this.GetCY_State45_Dot_Out_Retract, client, 16448, 1224159){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State45_Dot_Out_Extend, client, 16448, 1224160){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State45_Dot_Out_Fault_Alarm, client, 16448, 1224161){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State46, client, 16448, 1224162)
					{
						 Name = "Item_47",
						Out_Retract = new BeckhoffBool(this.GetCY_State46_Dot_Out_Retract, client, 16448, 1224162){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State46_Dot_Out_Extend, client, 16448, 1224163){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State46_Dot_Out_Fault_Alarm, client, 16448, 1224164){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State47, client, 16448, 1224165)
					{
						 Name = "Item_48",
						Out_Retract = new BeckhoffBool(this.GetCY_State47_Dot_Out_Retract, client, 16448, 1224165){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State47_Dot_Out_Extend, client, 16448, 1224166){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State47_Dot_Out_Fault_Alarm, client, 16448, 1224167){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State48, client, 16448, 1224168)
					{
						 Name = "Item_49",
						Out_Retract = new BeckhoffBool(this.GetCY_State48_Dot_Out_Retract, client, 16448, 1224168){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State48_Dot_Out_Extend, client, 16448, 1224169){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State48_Dot_Out_Fault_Alarm, client, 16448, 1224170){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State49, client, 16448, 1224171)
					{
						 Name = "Item_50",
						Out_Retract = new BeckhoffBool(this.GetCY_State49_Dot_Out_Retract, client, 16448, 1224171){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State49_Dot_Out_Extend, client, 16448, 1224172){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State49_Dot_Out_Fault_Alarm, client, 16448, 1224173){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State50, client, 16448, 1224174)
					{
						 Name = "Item_51",
						Out_Retract = new BeckhoffBool(this.GetCY_State50_Dot_Out_Retract, client, 16448, 1224174){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State50_Dot_Out_Extend, client, 16448, 1224175){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State50_Dot_Out_Fault_Alarm, client, 16448, 1224176){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State51, client, 16448, 1224177)
					{
						 Name = "Item_52",
						Out_Retract = new BeckhoffBool(this.GetCY_State51_Dot_Out_Retract, client, 16448, 1224177){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State51_Dot_Out_Extend, client, 16448, 1224178){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State51_Dot_Out_Fault_Alarm, client, 16448, 1224179){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State52, client, 16448, 1224180)
					{
						 Name = "Item_53",
						Out_Retract = new BeckhoffBool(this.GetCY_State52_Dot_Out_Retract, client, 16448, 1224180){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State52_Dot_Out_Extend, client, 16448, 1224181){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State52_Dot_Out_Fault_Alarm, client, 16448, 1224182){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State53, client, 16448, 1224183)
					{
						 Name = "Item_54",
						Out_Retract = new BeckhoffBool(this.GetCY_State53_Dot_Out_Retract, client, 16448, 1224183){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State53_Dot_Out_Extend, client, 16448, 1224184){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State53_Dot_Out_Fault_Alarm, client, 16448, 1224185){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State54, client, 16448, 1224186)
					{
						 Name = "Item_55",
						Out_Retract = new BeckhoffBool(this.GetCY_State54_Dot_Out_Retract, client, 16448, 1224186){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State54_Dot_Out_Extend, client, 16448, 1224187){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State54_Dot_Out_Fault_Alarm, client, 16448, 1224188){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State55, client, 16448, 1224189)
					{
						 Name = "Item_56",
						Out_Retract = new BeckhoffBool(this.GetCY_State55_Dot_Out_Retract, client, 16448, 1224189){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State55_Dot_Out_Extend, client, 16448, 1224190){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State55_Dot_Out_Fault_Alarm, client, 16448, 1224191){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State56, client, 16448, 1224192)
					{
						 Name = "Item_57",
						Out_Retract = new BeckhoffBool(this.GetCY_State56_Dot_Out_Retract, client, 16448, 1224192){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State56_Dot_Out_Extend, client, 16448, 1224193){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State56_Dot_Out_Fault_Alarm, client, 16448, 1224194){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State57, client, 16448, 1224195)
					{
						 Name = "Item_58",
						Out_Retract = new BeckhoffBool(this.GetCY_State57_Dot_Out_Retract, client, 16448, 1224195){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State57_Dot_Out_Extend, client, 16448, 1224196){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State57_Dot_Out_Fault_Alarm, client, 16448, 1224197){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State58, client, 16448, 1224198)
					{
						 Name = "Item_59",
						Out_Retract = new BeckhoffBool(this.GetCY_State58_Dot_Out_Retract, client, 16448, 1224198){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State58_Dot_Out_Extend, client, 16448, 1224199){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State58_Dot_Out_Fault_Alarm, client, 16448, 1224200){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State59, client, 16448, 1224201)
					{
						 Name = "Item_60",
						Out_Retract = new BeckhoffBool(this.GetCY_State59_Dot_Out_Retract, client, 16448, 1224201){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State59_Dot_Out_Extend, client, 16448, 1224202){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State59_Dot_Out_Fault_Alarm, client, 16448, 1224203){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State60, client, 16448, 1224204)
					{
						 Name = "Item_61",
						Out_Retract = new BeckhoffBool(this.GetCY_State60_Dot_Out_Retract, client, 16448, 1224204){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State60_Dot_Out_Extend, client, 16448, 1224205){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State60_Dot_Out_Fault_Alarm, client, 16448, 1224206){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State61, client, 16448, 1224207)
					{
						 Name = "Item_62",
						Out_Retract = new BeckhoffBool(this.GetCY_State61_Dot_Out_Retract, client, 16448, 1224207){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State61_Dot_Out_Extend, client, 16448, 1224208){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State61_Dot_Out_Fault_Alarm, client, 16448, 1224209){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State62, client, 16448, 1224210)
					{
						 Name = "Item_63",
						Out_Retract = new BeckhoffBool(this.GetCY_State62_Dot_Out_Retract, client, 16448, 1224210){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State62_Dot_Out_Extend, client, 16448, 1224211){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State62_Dot_Out_Fault_Alarm, client, 16448, 1224212){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State63, client, 16448, 1224213)
					{
						 Name = "Item_64",
						Out_Retract = new BeckhoffBool(this.GetCY_State63_Dot_Out_Retract, client, 16448, 1224213){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State63_Dot_Out_Extend, client, 16448, 1224214){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State63_Dot_Out_Fault_Alarm, client, 16448, 1224215){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State64, client, 16448, 1224216)
					{
						 Name = "Item_65",
						Out_Retract = new BeckhoffBool(this.GetCY_State64_Dot_Out_Retract, client, 16448, 1224216){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State64_Dot_Out_Extend, client, 16448, 1224217){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State64_Dot_Out_Fault_Alarm, client, 16448, 1224218){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State65, client, 16448, 1224219)
					{
						 Name = "Item_66",
						Out_Retract = new BeckhoffBool(this.GetCY_State65_Dot_Out_Retract, client, 16448, 1224219){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State65_Dot_Out_Extend, client, 16448, 1224220){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State65_Dot_Out_Fault_Alarm, client, 16448, 1224221){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State66, client, 16448, 1224222)
					{
						 Name = "Item_67",
						Out_Retract = new BeckhoffBool(this.GetCY_State66_Dot_Out_Retract, client, 16448, 1224222){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State66_Dot_Out_Extend, client, 16448, 1224223){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State66_Dot_Out_Fault_Alarm, client, 16448, 1224224){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State67, client, 16448, 1224225)
					{
						 Name = "Item_68",
						Out_Retract = new BeckhoffBool(this.GetCY_State67_Dot_Out_Retract, client, 16448, 1224225){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State67_Dot_Out_Extend, client, 16448, 1224226){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State67_Dot_Out_Fault_Alarm, client, 16448, 1224227){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State68, client, 16448, 1224228)
					{
						 Name = "Item_69",
						Out_Retract = new BeckhoffBool(this.GetCY_State68_Dot_Out_Retract, client, 16448, 1224228){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State68_Dot_Out_Extend, client, 16448, 1224229){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State68_Dot_Out_Fault_Alarm, client, 16448, 1224230){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State69, client, 16448, 1224231)
					{
						 Name = "Item_70",
						Out_Retract = new BeckhoffBool(this.GetCY_State69_Dot_Out_Retract, client, 16448, 1224231){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State69_Dot_Out_Extend, client, 16448, 1224232){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State69_Dot_Out_Fault_Alarm, client, 16448, 1224233){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State70, client, 16448, 1224234)
					{
						 Name = "Item_71",
						Out_Retract = new BeckhoffBool(this.GetCY_State70_Dot_Out_Retract, client, 16448, 1224234){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State70_Dot_Out_Extend, client, 16448, 1224235){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State70_Dot_Out_Fault_Alarm, client, 16448, 1224236){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State71, client, 16448, 1224237)
					{
						 Name = "Item_72",
						Out_Retract = new BeckhoffBool(this.GetCY_State71_Dot_Out_Retract, client, 16448, 1224237){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State71_Dot_Out_Extend, client, 16448, 1224238){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State71_Dot_Out_Fault_Alarm, client, 16448, 1224239){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State72, client, 16448, 1224240)
					{
						 Name = "Item_73",
						Out_Retract = new BeckhoffBool(this.GetCY_State72_Dot_Out_Retract, client, 16448, 1224240){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State72_Dot_Out_Extend, client, 16448, 1224241){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State72_Dot_Out_Fault_Alarm, client, 16448, 1224242){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State73, client, 16448, 1224243)
					{
						 Name = "Item_74",
						Out_Retract = new BeckhoffBool(this.GetCY_State73_Dot_Out_Retract, client, 16448, 1224243){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State73_Dot_Out_Extend, client, 16448, 1224244){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State73_Dot_Out_Fault_Alarm, client, 16448, 1224245){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State74, client, 16448, 1224246)
					{
						 Name = "Item_75",
						Out_Retract = new BeckhoffBool(this.GetCY_State74_Dot_Out_Retract, client, 16448, 1224246){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State74_Dot_Out_Extend, client, 16448, 1224247){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State74_Dot_Out_Fault_Alarm, client, 16448, 1224248){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State75, client, 16448, 1224249)
					{
						 Name = "Item_76",
						Out_Retract = new BeckhoffBool(this.GetCY_State75_Dot_Out_Retract, client, 16448, 1224249){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State75_Dot_Out_Extend, client, 16448, 1224250){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State75_Dot_Out_Fault_Alarm, client, 16448, 1224251){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State76, client, 16448, 1224252)
					{
						 Name = "Item_77",
						Out_Retract = new BeckhoffBool(this.GetCY_State76_Dot_Out_Retract, client, 16448, 1224252){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State76_Dot_Out_Extend, client, 16448, 1224253){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State76_Dot_Out_Fault_Alarm, client, 16448, 1224254){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State77, client, 16448, 1224255)
					{
						 Name = "Item_78",
						Out_Retract = new BeckhoffBool(this.GetCY_State77_Dot_Out_Retract, client, 16448, 1224255){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State77_Dot_Out_Extend, client, 16448, 1224256){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State77_Dot_Out_Fault_Alarm, client, 16448, 1224257){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State78, client, 16448, 1224258)
					{
						 Name = "Item_79",
						Out_Retract = new BeckhoffBool(this.GetCY_State78_Dot_Out_Retract, client, 16448, 1224258){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State78_Dot_Out_Extend, client, 16448, 1224259){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State78_Dot_Out_Fault_Alarm, client, 16448, 1224260){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State79, client, 16448, 1224261)
					{
						 Name = "Item_80",
						Out_Retract = new BeckhoffBool(this.GetCY_State79_Dot_Out_Retract, client, 16448, 1224261){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State79_Dot_Out_Extend, client, 16448, 1224262){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State79_Dot_Out_Fault_Alarm, client, 16448, 1224263){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State80, client, 16448, 1224264)
					{
						 Name = "Item_81",
						Out_Retract = new BeckhoffBool(this.GetCY_State80_Dot_Out_Retract, client, 16448, 1224264){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State80_Dot_Out_Extend, client, 16448, 1224265){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State80_Dot_Out_Fault_Alarm, client, 16448, 1224266){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State81, client, 16448, 1224267)
					{
						 Name = "Item_82",
						Out_Retract = new BeckhoffBool(this.GetCY_State81_Dot_Out_Retract, client, 16448, 1224267){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State81_Dot_Out_Extend, client, 16448, 1224268){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State81_Dot_Out_Fault_Alarm, client, 16448, 1224269){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State82, client, 16448, 1224270)
					{
						 Name = "Item_83",
						Out_Retract = new BeckhoffBool(this.GetCY_State82_Dot_Out_Retract, client, 16448, 1224270){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State82_Dot_Out_Extend, client, 16448, 1224271){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State82_Dot_Out_Fault_Alarm, client, 16448, 1224272){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State83, client, 16448, 1224273)
					{
						 Name = "Item_84",
						Out_Retract = new BeckhoffBool(this.GetCY_State83_Dot_Out_Retract, client, 16448, 1224273){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State83_Dot_Out_Extend, client, 16448, 1224274){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State83_Dot_Out_Fault_Alarm, client, 16448, 1224275){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State84, client, 16448, 1224276)
					{
						 Name = "Item_85",
						Out_Retract = new BeckhoffBool(this.GetCY_State84_Dot_Out_Retract, client, 16448, 1224276){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State84_Dot_Out_Extend, client, 16448, 1224277){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State84_Dot_Out_Fault_Alarm, client, 16448, 1224278){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State85, client, 16448, 1224279)
					{
						 Name = "Item_86",
						Out_Retract = new BeckhoffBool(this.GetCY_State85_Dot_Out_Retract, client, 16448, 1224279){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State85_Dot_Out_Extend, client, 16448, 1224280){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State85_Dot_Out_Fault_Alarm, client, 16448, 1224281){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State86, client, 16448, 1224282)
					{
						 Name = "Item_87",
						Out_Retract = new BeckhoffBool(this.GetCY_State86_Dot_Out_Retract, client, 16448, 1224282){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State86_Dot_Out_Extend, client, 16448, 1224283){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State86_Dot_Out_Fault_Alarm, client, 16448, 1224284){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State87, client, 16448, 1224285)
					{
						 Name = "Item_88",
						Out_Retract = new BeckhoffBool(this.GetCY_State87_Dot_Out_Retract, client, 16448, 1224285){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State87_Dot_Out_Extend, client, 16448, 1224286){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State87_Dot_Out_Fault_Alarm, client, 16448, 1224287){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State88, client, 16448, 1224288)
					{
						 Name = "Item_89",
						Out_Retract = new BeckhoffBool(this.GetCY_State88_Dot_Out_Retract, client, 16448, 1224288){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State88_Dot_Out_Extend, client, 16448, 1224289){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State88_Dot_Out_Fault_Alarm, client, 16448, 1224290){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State89, client, 16448, 1224291)
					{
						 Name = "Item_90",
						Out_Retract = new BeckhoffBool(this.GetCY_State89_Dot_Out_Retract, client, 16448, 1224291){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State89_Dot_Out_Extend, client, 16448, 1224292){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State89_Dot_Out_Fault_Alarm, client, 16448, 1224293){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State90, client, 16448, 1224294)
					{
						 Name = "Item_91",
						Out_Retract = new BeckhoffBool(this.GetCY_State90_Dot_Out_Retract, client, 16448, 1224294){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State90_Dot_Out_Extend, client, 16448, 1224295){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State90_Dot_Out_Fault_Alarm, client, 16448, 1224296){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State91, client, 16448, 1224297)
					{
						 Name = "Item_92",
						Out_Retract = new BeckhoffBool(this.GetCY_State91_Dot_Out_Retract, client, 16448, 1224297){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State91_Dot_Out_Extend, client, 16448, 1224298){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State91_Dot_Out_Fault_Alarm, client, 16448, 1224299){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State92, client, 16448, 1224300)
					{
						 Name = "Item_93",
						Out_Retract = new BeckhoffBool(this.GetCY_State92_Dot_Out_Retract, client, 16448, 1224300){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State92_Dot_Out_Extend, client, 16448, 1224301){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State92_Dot_Out_Fault_Alarm, client, 16448, 1224302){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State93, client, 16448, 1224303)
					{
						 Name = "Item_94",
						Out_Retract = new BeckhoffBool(this.GetCY_State93_Dot_Out_Retract, client, 16448, 1224303){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State93_Dot_Out_Extend, client, 16448, 1224304){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State93_Dot_Out_Fault_Alarm, client, 16448, 1224305){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State94, client, 16448, 1224306)
					{
						 Name = "Item_95",
						Out_Retract = new BeckhoffBool(this.GetCY_State94_Dot_Out_Retract, client, 16448, 1224306){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State94_Dot_Out_Extend, client, 16448, 1224307){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State94_Dot_Out_Fault_Alarm, client, 16448, 1224308){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State95, client, 16448, 1224309)
					{
						 Name = "Item_96",
						Out_Retract = new BeckhoffBool(this.GetCY_State95_Dot_Out_Retract, client, 16448, 1224309){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State95_Dot_Out_Extend, client, 16448, 1224310){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State95_Dot_Out_Fault_Alarm, client, 16448, 1224311){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State96, client, 16448, 1224312)
					{
						 Name = "Item_97",
						Out_Retract = new BeckhoffBool(this.GetCY_State96_Dot_Out_Retract, client, 16448, 1224312){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State96_Dot_Out_Extend, client, 16448, 1224313){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State96_Dot_Out_Fault_Alarm, client, 16448, 1224314){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State97, client, 16448, 1224315)
					{
						 Name = "Item_98",
						Out_Retract = new BeckhoffBool(this.GetCY_State97_Dot_Out_Retract, client, 16448, 1224315){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State97_Dot_Out_Extend, client, 16448, 1224316){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State97_Dot_Out_Fault_Alarm, client, 16448, 1224317){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State98, client, 16448, 1224318)
					{
						 Name = "Item_99",
						Out_Retract = new BeckhoffBool(this.GetCY_State98_Dot_Out_Retract, client, 16448, 1224318){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State98_Dot_Out_Extend, client, 16448, 1224319){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State98_Dot_Out_Fault_Alarm, client, 16448, 1224320){ Name = "Out_Fault_Alarm" },
					},
					new DUT_CY_STATEWrapper(this.GetCY_State99, client, 16448, 1224321)
					{
						 Name = "Item_100",
						Out_Retract = new BeckhoffBool(this.GetCY_State99_Dot_Out_Retract, client, 16448, 1224321){ Name = "Out_Retract" },
						Out_Extend = new BeckhoffBool(this.GetCY_State99_Dot_Out_Extend, client, 16448, 1224322){ Name = "Out_Extend" },
						Out_Fault_Alarm = new BeckhoffBool(this.GetCY_State99_Dot_Out_Fault_Alarm, client, 16448, 1224323){ Name = "Out_Fault_Alarm" },
					},
			}, false){ Name = "CY_State" };
			SR_Index = new BeckhoffShort(this.GetSR_Index, client, 16448, 1224324){ Name = "SR_Index" };
			SR_Manual_CMD = new BeckhoffStructArray<DUT_SR_CMD100, DUT_SR_CMDWrapper, DUT_SR_CMD>(this.GetSR_Manual_CMD, client, 16448, 1224326,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1224326 ,1224328 ,1224330 ,1224332 ,1224334 ,1224336 ,1224338 ,1224340 ,1224342 ,1224344 ,1224346 ,1224348 ,1224350 ,1224352 ,1224354 ,1224356 ,1224358 ,1224360 ,1224362 ,1224364 ,1224366 ,1224368 ,1224370 ,1224372 ,1224374 ,1224376 ,1224378 ,1224380 ,1224382 ,1224384 ,1224386 ,1224388 ,1224390 ,1224392 ,1224394 ,1224396 ,1224398 ,1224400 ,1224402 ,1224404 ,1224406 ,1224408 ,1224410 ,1224412 ,1224414 ,1224416 ,1224418 ,1224420 ,1224422 ,1224424 ,1224426 ,1224428 ,1224430 ,1224432 ,1224434 ,1224436 ,1224438 ,1224440 ,1224442 ,1224444 ,1224446 ,1224448 ,1224450 ,1224452 ,1224454 ,1224456 ,1224458 ,1224460 ,1224462 ,1224464 ,1224466 ,1224468 ,1224470 ,1224472 ,1224474 ,1224476 ,1224478 ,1224480 ,1224482 ,1224484 ,1224486 ,1224488 ,1224490 ,1224492 ,1224494 ,1224496 ,1224498 ,1224500 ,1224502 ,1224504 ,1224506 ,1224508 ,1224510 ,1224512 ,1224514 ,1224516 ,1224518 ,1224520 ,1224522 ,1224524 , },
				new DUT_SR_CMDWrapper[]
				{
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD0, client, 16448, 1224326)
					{
						 Name = "Item_1",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD0_Dot_ManualDisable, client, 16448, 1224326){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD0_Dot_Sensor_In_Signal, client, 16448, 1224327){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD1, client, 16448, 1224328)
					{
						 Name = "Item_2",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD1_Dot_ManualDisable, client, 16448, 1224328){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD1_Dot_Sensor_In_Signal, client, 16448, 1224329){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD2, client, 16448, 1224330)
					{
						 Name = "Item_3",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD2_Dot_ManualDisable, client, 16448, 1224330){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD2_Dot_Sensor_In_Signal, client, 16448, 1224331){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD3, client, 16448, 1224332)
					{
						 Name = "Item_4",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD3_Dot_ManualDisable, client, 16448, 1224332){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD3_Dot_Sensor_In_Signal, client, 16448, 1224333){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD4, client, 16448, 1224334)
					{
						 Name = "Item_5",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD4_Dot_ManualDisable, client, 16448, 1224334){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD4_Dot_Sensor_In_Signal, client, 16448, 1224335){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD5, client, 16448, 1224336)
					{
						 Name = "Item_6",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD5_Dot_ManualDisable, client, 16448, 1224336){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD5_Dot_Sensor_In_Signal, client, 16448, 1224337){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD6, client, 16448, 1224338)
					{
						 Name = "Item_7",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD6_Dot_ManualDisable, client, 16448, 1224338){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD6_Dot_Sensor_In_Signal, client, 16448, 1224339){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD7, client, 16448, 1224340)
					{
						 Name = "Item_8",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD7_Dot_ManualDisable, client, 16448, 1224340){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD7_Dot_Sensor_In_Signal, client, 16448, 1224341){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD8, client, 16448, 1224342)
					{
						 Name = "Item_9",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD8_Dot_ManualDisable, client, 16448, 1224342){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD8_Dot_Sensor_In_Signal, client, 16448, 1224343){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD9, client, 16448, 1224344)
					{
						 Name = "Item_10",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD9_Dot_ManualDisable, client, 16448, 1224344){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD9_Dot_Sensor_In_Signal, client, 16448, 1224345){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD10, client, 16448, 1224346)
					{
						 Name = "Item_11",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD10_Dot_ManualDisable, client, 16448, 1224346){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD10_Dot_Sensor_In_Signal, client, 16448, 1224347){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD11, client, 16448, 1224348)
					{
						 Name = "Item_12",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD11_Dot_ManualDisable, client, 16448, 1224348){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD11_Dot_Sensor_In_Signal, client, 16448, 1224349){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD12, client, 16448, 1224350)
					{
						 Name = "Item_13",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD12_Dot_ManualDisable, client, 16448, 1224350){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD12_Dot_Sensor_In_Signal, client, 16448, 1224351){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD13, client, 16448, 1224352)
					{
						 Name = "Item_14",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD13_Dot_ManualDisable, client, 16448, 1224352){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD13_Dot_Sensor_In_Signal, client, 16448, 1224353){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD14, client, 16448, 1224354)
					{
						 Name = "Item_15",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD14_Dot_ManualDisable, client, 16448, 1224354){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD14_Dot_Sensor_In_Signal, client, 16448, 1224355){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD15, client, 16448, 1224356)
					{
						 Name = "Item_16",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD15_Dot_ManualDisable, client, 16448, 1224356){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD15_Dot_Sensor_In_Signal, client, 16448, 1224357){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD16, client, 16448, 1224358)
					{
						 Name = "Item_17",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD16_Dot_ManualDisable, client, 16448, 1224358){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD16_Dot_Sensor_In_Signal, client, 16448, 1224359){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD17, client, 16448, 1224360)
					{
						 Name = "Item_18",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD17_Dot_ManualDisable, client, 16448, 1224360){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD17_Dot_Sensor_In_Signal, client, 16448, 1224361){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD18, client, 16448, 1224362)
					{
						 Name = "Item_19",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD18_Dot_ManualDisable, client, 16448, 1224362){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD18_Dot_Sensor_In_Signal, client, 16448, 1224363){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD19, client, 16448, 1224364)
					{
						 Name = "Item_20",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD19_Dot_ManualDisable, client, 16448, 1224364){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD19_Dot_Sensor_In_Signal, client, 16448, 1224365){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD20, client, 16448, 1224366)
					{
						 Name = "Item_21",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD20_Dot_ManualDisable, client, 16448, 1224366){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD20_Dot_Sensor_In_Signal, client, 16448, 1224367){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD21, client, 16448, 1224368)
					{
						 Name = "Item_22",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD21_Dot_ManualDisable, client, 16448, 1224368){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD21_Dot_Sensor_In_Signal, client, 16448, 1224369){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD22, client, 16448, 1224370)
					{
						 Name = "Item_23",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD22_Dot_ManualDisable, client, 16448, 1224370){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD22_Dot_Sensor_In_Signal, client, 16448, 1224371){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD23, client, 16448, 1224372)
					{
						 Name = "Item_24",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD23_Dot_ManualDisable, client, 16448, 1224372){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD23_Dot_Sensor_In_Signal, client, 16448, 1224373){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD24, client, 16448, 1224374)
					{
						 Name = "Item_25",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD24_Dot_ManualDisable, client, 16448, 1224374){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD24_Dot_Sensor_In_Signal, client, 16448, 1224375){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD25, client, 16448, 1224376)
					{
						 Name = "Item_26",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD25_Dot_ManualDisable, client, 16448, 1224376){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD25_Dot_Sensor_In_Signal, client, 16448, 1224377){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD26, client, 16448, 1224378)
					{
						 Name = "Item_27",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD26_Dot_ManualDisable, client, 16448, 1224378){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD26_Dot_Sensor_In_Signal, client, 16448, 1224379){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD27, client, 16448, 1224380)
					{
						 Name = "Item_28",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD27_Dot_ManualDisable, client, 16448, 1224380){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD27_Dot_Sensor_In_Signal, client, 16448, 1224381){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD28, client, 16448, 1224382)
					{
						 Name = "Item_29",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD28_Dot_ManualDisable, client, 16448, 1224382){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD28_Dot_Sensor_In_Signal, client, 16448, 1224383){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD29, client, 16448, 1224384)
					{
						 Name = "Item_30",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD29_Dot_ManualDisable, client, 16448, 1224384){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD29_Dot_Sensor_In_Signal, client, 16448, 1224385){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD30, client, 16448, 1224386)
					{
						 Name = "Item_31",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD30_Dot_ManualDisable, client, 16448, 1224386){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD30_Dot_Sensor_In_Signal, client, 16448, 1224387){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD31, client, 16448, 1224388)
					{
						 Name = "Item_32",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD31_Dot_ManualDisable, client, 16448, 1224388){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD31_Dot_Sensor_In_Signal, client, 16448, 1224389){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD32, client, 16448, 1224390)
					{
						 Name = "Item_33",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD32_Dot_ManualDisable, client, 16448, 1224390){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD32_Dot_Sensor_In_Signal, client, 16448, 1224391){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD33, client, 16448, 1224392)
					{
						 Name = "Item_34",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD33_Dot_ManualDisable, client, 16448, 1224392){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD33_Dot_Sensor_In_Signal, client, 16448, 1224393){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD34, client, 16448, 1224394)
					{
						 Name = "Item_35",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD34_Dot_ManualDisable, client, 16448, 1224394){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD34_Dot_Sensor_In_Signal, client, 16448, 1224395){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD35, client, 16448, 1224396)
					{
						 Name = "Item_36",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD35_Dot_ManualDisable, client, 16448, 1224396){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD35_Dot_Sensor_In_Signal, client, 16448, 1224397){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD36, client, 16448, 1224398)
					{
						 Name = "Item_37",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD36_Dot_ManualDisable, client, 16448, 1224398){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD36_Dot_Sensor_In_Signal, client, 16448, 1224399){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD37, client, 16448, 1224400)
					{
						 Name = "Item_38",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD37_Dot_ManualDisable, client, 16448, 1224400){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD37_Dot_Sensor_In_Signal, client, 16448, 1224401){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD38, client, 16448, 1224402)
					{
						 Name = "Item_39",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD38_Dot_ManualDisable, client, 16448, 1224402){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD38_Dot_Sensor_In_Signal, client, 16448, 1224403){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD39, client, 16448, 1224404)
					{
						 Name = "Item_40",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD39_Dot_ManualDisable, client, 16448, 1224404){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD39_Dot_Sensor_In_Signal, client, 16448, 1224405){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD40, client, 16448, 1224406)
					{
						 Name = "Item_41",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD40_Dot_ManualDisable, client, 16448, 1224406){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD40_Dot_Sensor_In_Signal, client, 16448, 1224407){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD41, client, 16448, 1224408)
					{
						 Name = "Item_42",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD41_Dot_ManualDisable, client, 16448, 1224408){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD41_Dot_Sensor_In_Signal, client, 16448, 1224409){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD42, client, 16448, 1224410)
					{
						 Name = "Item_43",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD42_Dot_ManualDisable, client, 16448, 1224410){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD42_Dot_Sensor_In_Signal, client, 16448, 1224411){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD43, client, 16448, 1224412)
					{
						 Name = "Item_44",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD43_Dot_ManualDisable, client, 16448, 1224412){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD43_Dot_Sensor_In_Signal, client, 16448, 1224413){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD44, client, 16448, 1224414)
					{
						 Name = "Item_45",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD44_Dot_ManualDisable, client, 16448, 1224414){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD44_Dot_Sensor_In_Signal, client, 16448, 1224415){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD45, client, 16448, 1224416)
					{
						 Name = "Item_46",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD45_Dot_ManualDisable, client, 16448, 1224416){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD45_Dot_Sensor_In_Signal, client, 16448, 1224417){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD46, client, 16448, 1224418)
					{
						 Name = "Item_47",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD46_Dot_ManualDisable, client, 16448, 1224418){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD46_Dot_Sensor_In_Signal, client, 16448, 1224419){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD47, client, 16448, 1224420)
					{
						 Name = "Item_48",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD47_Dot_ManualDisable, client, 16448, 1224420){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD47_Dot_Sensor_In_Signal, client, 16448, 1224421){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD48, client, 16448, 1224422)
					{
						 Name = "Item_49",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD48_Dot_ManualDisable, client, 16448, 1224422){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD48_Dot_Sensor_In_Signal, client, 16448, 1224423){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD49, client, 16448, 1224424)
					{
						 Name = "Item_50",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD49_Dot_ManualDisable, client, 16448, 1224424){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD49_Dot_Sensor_In_Signal, client, 16448, 1224425){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD50, client, 16448, 1224426)
					{
						 Name = "Item_51",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD50_Dot_ManualDisable, client, 16448, 1224426){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD50_Dot_Sensor_In_Signal, client, 16448, 1224427){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD51, client, 16448, 1224428)
					{
						 Name = "Item_52",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD51_Dot_ManualDisable, client, 16448, 1224428){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD51_Dot_Sensor_In_Signal, client, 16448, 1224429){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD52, client, 16448, 1224430)
					{
						 Name = "Item_53",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD52_Dot_ManualDisable, client, 16448, 1224430){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD52_Dot_Sensor_In_Signal, client, 16448, 1224431){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD53, client, 16448, 1224432)
					{
						 Name = "Item_54",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD53_Dot_ManualDisable, client, 16448, 1224432){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD53_Dot_Sensor_In_Signal, client, 16448, 1224433){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD54, client, 16448, 1224434)
					{
						 Name = "Item_55",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD54_Dot_ManualDisable, client, 16448, 1224434){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD54_Dot_Sensor_In_Signal, client, 16448, 1224435){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD55, client, 16448, 1224436)
					{
						 Name = "Item_56",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD55_Dot_ManualDisable, client, 16448, 1224436){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD55_Dot_Sensor_In_Signal, client, 16448, 1224437){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD56, client, 16448, 1224438)
					{
						 Name = "Item_57",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD56_Dot_ManualDisable, client, 16448, 1224438){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD56_Dot_Sensor_In_Signal, client, 16448, 1224439){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD57, client, 16448, 1224440)
					{
						 Name = "Item_58",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD57_Dot_ManualDisable, client, 16448, 1224440){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD57_Dot_Sensor_In_Signal, client, 16448, 1224441){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD58, client, 16448, 1224442)
					{
						 Name = "Item_59",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD58_Dot_ManualDisable, client, 16448, 1224442){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD58_Dot_Sensor_In_Signal, client, 16448, 1224443){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD59, client, 16448, 1224444)
					{
						 Name = "Item_60",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD59_Dot_ManualDisable, client, 16448, 1224444){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD59_Dot_Sensor_In_Signal, client, 16448, 1224445){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD60, client, 16448, 1224446)
					{
						 Name = "Item_61",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD60_Dot_ManualDisable, client, 16448, 1224446){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD60_Dot_Sensor_In_Signal, client, 16448, 1224447){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD61, client, 16448, 1224448)
					{
						 Name = "Item_62",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD61_Dot_ManualDisable, client, 16448, 1224448){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD61_Dot_Sensor_In_Signal, client, 16448, 1224449){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD62, client, 16448, 1224450)
					{
						 Name = "Item_63",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD62_Dot_ManualDisable, client, 16448, 1224450){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD62_Dot_Sensor_In_Signal, client, 16448, 1224451){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD63, client, 16448, 1224452)
					{
						 Name = "Item_64",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD63_Dot_ManualDisable, client, 16448, 1224452){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD63_Dot_Sensor_In_Signal, client, 16448, 1224453){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD64, client, 16448, 1224454)
					{
						 Name = "Item_65",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD64_Dot_ManualDisable, client, 16448, 1224454){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD64_Dot_Sensor_In_Signal, client, 16448, 1224455){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD65, client, 16448, 1224456)
					{
						 Name = "Item_66",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD65_Dot_ManualDisable, client, 16448, 1224456){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD65_Dot_Sensor_In_Signal, client, 16448, 1224457){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD66, client, 16448, 1224458)
					{
						 Name = "Item_67",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD66_Dot_ManualDisable, client, 16448, 1224458){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD66_Dot_Sensor_In_Signal, client, 16448, 1224459){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD67, client, 16448, 1224460)
					{
						 Name = "Item_68",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD67_Dot_ManualDisable, client, 16448, 1224460){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD67_Dot_Sensor_In_Signal, client, 16448, 1224461){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD68, client, 16448, 1224462)
					{
						 Name = "Item_69",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD68_Dot_ManualDisable, client, 16448, 1224462){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD68_Dot_Sensor_In_Signal, client, 16448, 1224463){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD69, client, 16448, 1224464)
					{
						 Name = "Item_70",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD69_Dot_ManualDisable, client, 16448, 1224464){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD69_Dot_Sensor_In_Signal, client, 16448, 1224465){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD70, client, 16448, 1224466)
					{
						 Name = "Item_71",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD70_Dot_ManualDisable, client, 16448, 1224466){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD70_Dot_Sensor_In_Signal, client, 16448, 1224467){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD71, client, 16448, 1224468)
					{
						 Name = "Item_72",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD71_Dot_ManualDisable, client, 16448, 1224468){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD71_Dot_Sensor_In_Signal, client, 16448, 1224469){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD72, client, 16448, 1224470)
					{
						 Name = "Item_73",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD72_Dot_ManualDisable, client, 16448, 1224470){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD72_Dot_Sensor_In_Signal, client, 16448, 1224471){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD73, client, 16448, 1224472)
					{
						 Name = "Item_74",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD73_Dot_ManualDisable, client, 16448, 1224472){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD73_Dot_Sensor_In_Signal, client, 16448, 1224473){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD74, client, 16448, 1224474)
					{
						 Name = "Item_75",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD74_Dot_ManualDisable, client, 16448, 1224474){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD74_Dot_Sensor_In_Signal, client, 16448, 1224475){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD75, client, 16448, 1224476)
					{
						 Name = "Item_76",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD75_Dot_ManualDisable, client, 16448, 1224476){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD75_Dot_Sensor_In_Signal, client, 16448, 1224477){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD76, client, 16448, 1224478)
					{
						 Name = "Item_77",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD76_Dot_ManualDisable, client, 16448, 1224478){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD76_Dot_Sensor_In_Signal, client, 16448, 1224479){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD77, client, 16448, 1224480)
					{
						 Name = "Item_78",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD77_Dot_ManualDisable, client, 16448, 1224480){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD77_Dot_Sensor_In_Signal, client, 16448, 1224481){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD78, client, 16448, 1224482)
					{
						 Name = "Item_79",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD78_Dot_ManualDisable, client, 16448, 1224482){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD78_Dot_Sensor_In_Signal, client, 16448, 1224483){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD79, client, 16448, 1224484)
					{
						 Name = "Item_80",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD79_Dot_ManualDisable, client, 16448, 1224484){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD79_Dot_Sensor_In_Signal, client, 16448, 1224485){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD80, client, 16448, 1224486)
					{
						 Name = "Item_81",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD80_Dot_ManualDisable, client, 16448, 1224486){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD80_Dot_Sensor_In_Signal, client, 16448, 1224487){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD81, client, 16448, 1224488)
					{
						 Name = "Item_82",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD81_Dot_ManualDisable, client, 16448, 1224488){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD81_Dot_Sensor_In_Signal, client, 16448, 1224489){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD82, client, 16448, 1224490)
					{
						 Name = "Item_83",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD82_Dot_ManualDisable, client, 16448, 1224490){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD82_Dot_Sensor_In_Signal, client, 16448, 1224491){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD83, client, 16448, 1224492)
					{
						 Name = "Item_84",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD83_Dot_ManualDisable, client, 16448, 1224492){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD83_Dot_Sensor_In_Signal, client, 16448, 1224493){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD84, client, 16448, 1224494)
					{
						 Name = "Item_85",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD84_Dot_ManualDisable, client, 16448, 1224494){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD84_Dot_Sensor_In_Signal, client, 16448, 1224495){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD85, client, 16448, 1224496)
					{
						 Name = "Item_86",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD85_Dot_ManualDisable, client, 16448, 1224496){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD85_Dot_Sensor_In_Signal, client, 16448, 1224497){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD86, client, 16448, 1224498)
					{
						 Name = "Item_87",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD86_Dot_ManualDisable, client, 16448, 1224498){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD86_Dot_Sensor_In_Signal, client, 16448, 1224499){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD87, client, 16448, 1224500)
					{
						 Name = "Item_88",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD87_Dot_ManualDisable, client, 16448, 1224500){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD87_Dot_Sensor_In_Signal, client, 16448, 1224501){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD88, client, 16448, 1224502)
					{
						 Name = "Item_89",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD88_Dot_ManualDisable, client, 16448, 1224502){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD88_Dot_Sensor_In_Signal, client, 16448, 1224503){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD89, client, 16448, 1224504)
					{
						 Name = "Item_90",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD89_Dot_ManualDisable, client, 16448, 1224504){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD89_Dot_Sensor_In_Signal, client, 16448, 1224505){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD90, client, 16448, 1224506)
					{
						 Name = "Item_91",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD90_Dot_ManualDisable, client, 16448, 1224506){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD90_Dot_Sensor_In_Signal, client, 16448, 1224507){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD91, client, 16448, 1224508)
					{
						 Name = "Item_92",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD91_Dot_ManualDisable, client, 16448, 1224508){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD91_Dot_Sensor_In_Signal, client, 16448, 1224509){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD92, client, 16448, 1224510)
					{
						 Name = "Item_93",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD92_Dot_ManualDisable, client, 16448, 1224510){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD92_Dot_Sensor_In_Signal, client, 16448, 1224511){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD93, client, 16448, 1224512)
					{
						 Name = "Item_94",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD93_Dot_ManualDisable, client, 16448, 1224512){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD93_Dot_Sensor_In_Signal, client, 16448, 1224513){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD94, client, 16448, 1224514)
					{
						 Name = "Item_95",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD94_Dot_ManualDisable, client, 16448, 1224514){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD94_Dot_Sensor_In_Signal, client, 16448, 1224515){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD95, client, 16448, 1224516)
					{
						 Name = "Item_96",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD95_Dot_ManualDisable, client, 16448, 1224516){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD95_Dot_Sensor_In_Signal, client, 16448, 1224517){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD96, client, 16448, 1224518)
					{
						 Name = "Item_97",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD96_Dot_ManualDisable, client, 16448, 1224518){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD96_Dot_Sensor_In_Signal, client, 16448, 1224519){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD97, client, 16448, 1224520)
					{
						 Name = "Item_98",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD97_Dot_ManualDisable, client, 16448, 1224520){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD97_Dot_Sensor_In_Signal, client, 16448, 1224521){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD98, client, 16448, 1224522)
					{
						 Name = "Item_99",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD98_Dot_ManualDisable, client, 16448, 1224522){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD98_Dot_Sensor_In_Signal, client, 16448, 1224523){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_Manual_CMD99, client, 16448, 1224524)
					{
						 Name = "Item_100",
						ManualDisable = new BeckhoffBool(this.GetSR_Manual_CMD99_Dot_ManualDisable, client, 16448, 1224524){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_Manual_CMD99_Dot_Sensor_In_Signal, client, 16448, 1224525){ Name = "Sensor_In_Signal" },
					},
			}, false){ Name = "SR_Manual_CMD" };
			SR_AUTO_CMD = new BeckhoffStructArray<DUT_SR_CMD100, DUT_SR_CMDWrapper, DUT_SR_CMD>(this.GetSR_AUTO_CMD, client, 16448, 1224526,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1224526 ,1224528 ,1224530 ,1224532 ,1224534 ,1224536 ,1224538 ,1224540 ,1224542 ,1224544 ,1224546 ,1224548 ,1224550 ,1224552 ,1224554 ,1224556 ,1224558 ,1224560 ,1224562 ,1224564 ,1224566 ,1224568 ,1224570 ,1224572 ,1224574 ,1224576 ,1224578 ,1224580 ,1224582 ,1224584 ,1224586 ,1224588 ,1224590 ,1224592 ,1224594 ,1224596 ,1224598 ,1224600 ,1224602 ,1224604 ,1224606 ,1224608 ,1224610 ,1224612 ,1224614 ,1224616 ,1224618 ,1224620 ,1224622 ,1224624 ,1224626 ,1224628 ,1224630 ,1224632 ,1224634 ,1224636 ,1224638 ,1224640 ,1224642 ,1224644 ,1224646 ,1224648 ,1224650 ,1224652 ,1224654 ,1224656 ,1224658 ,1224660 ,1224662 ,1224664 ,1224666 ,1224668 ,1224670 ,1224672 ,1224674 ,1224676 ,1224678 ,1224680 ,1224682 ,1224684 ,1224686 ,1224688 ,1224690 ,1224692 ,1224694 ,1224696 ,1224698 ,1224700 ,1224702 ,1224704 ,1224706 ,1224708 ,1224710 ,1224712 ,1224714 ,1224716 ,1224718 ,1224720 ,1224722 ,1224724 , },
				new DUT_SR_CMDWrapper[]
				{
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD0, client, 16448, 1224526)
					{
						 Name = "Item_1",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD0_Dot_ManualDisable, client, 16448, 1224526){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD0_Dot_Sensor_In_Signal, client, 16448, 1224527){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD1, client, 16448, 1224528)
					{
						 Name = "Item_2",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD1_Dot_ManualDisable, client, 16448, 1224528){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD1_Dot_Sensor_In_Signal, client, 16448, 1224529){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD2, client, 16448, 1224530)
					{
						 Name = "Item_3",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD2_Dot_ManualDisable, client, 16448, 1224530){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD2_Dot_Sensor_In_Signal, client, 16448, 1224531){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD3, client, 16448, 1224532)
					{
						 Name = "Item_4",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD3_Dot_ManualDisable, client, 16448, 1224532){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD3_Dot_Sensor_In_Signal, client, 16448, 1224533){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD4, client, 16448, 1224534)
					{
						 Name = "Item_5",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD4_Dot_ManualDisable, client, 16448, 1224534){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD4_Dot_Sensor_In_Signal, client, 16448, 1224535){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD5, client, 16448, 1224536)
					{
						 Name = "Item_6",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD5_Dot_ManualDisable, client, 16448, 1224536){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD5_Dot_Sensor_In_Signal, client, 16448, 1224537){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD6, client, 16448, 1224538)
					{
						 Name = "Item_7",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD6_Dot_ManualDisable, client, 16448, 1224538){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD6_Dot_Sensor_In_Signal, client, 16448, 1224539){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD7, client, 16448, 1224540)
					{
						 Name = "Item_8",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD7_Dot_ManualDisable, client, 16448, 1224540){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD7_Dot_Sensor_In_Signal, client, 16448, 1224541){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD8, client, 16448, 1224542)
					{
						 Name = "Item_9",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD8_Dot_ManualDisable, client, 16448, 1224542){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD8_Dot_Sensor_In_Signal, client, 16448, 1224543){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD9, client, 16448, 1224544)
					{
						 Name = "Item_10",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD9_Dot_ManualDisable, client, 16448, 1224544){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD9_Dot_Sensor_In_Signal, client, 16448, 1224545){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD10, client, 16448, 1224546)
					{
						 Name = "Item_11",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD10_Dot_ManualDisable, client, 16448, 1224546){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD10_Dot_Sensor_In_Signal, client, 16448, 1224547){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD11, client, 16448, 1224548)
					{
						 Name = "Item_12",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD11_Dot_ManualDisable, client, 16448, 1224548){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD11_Dot_Sensor_In_Signal, client, 16448, 1224549){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD12, client, 16448, 1224550)
					{
						 Name = "Item_13",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD12_Dot_ManualDisable, client, 16448, 1224550){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD12_Dot_Sensor_In_Signal, client, 16448, 1224551){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD13, client, 16448, 1224552)
					{
						 Name = "Item_14",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD13_Dot_ManualDisable, client, 16448, 1224552){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD13_Dot_Sensor_In_Signal, client, 16448, 1224553){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD14, client, 16448, 1224554)
					{
						 Name = "Item_15",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD14_Dot_ManualDisable, client, 16448, 1224554){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD14_Dot_Sensor_In_Signal, client, 16448, 1224555){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD15, client, 16448, 1224556)
					{
						 Name = "Item_16",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD15_Dot_ManualDisable, client, 16448, 1224556){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD15_Dot_Sensor_In_Signal, client, 16448, 1224557){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD16, client, 16448, 1224558)
					{
						 Name = "Item_17",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD16_Dot_ManualDisable, client, 16448, 1224558){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD16_Dot_Sensor_In_Signal, client, 16448, 1224559){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD17, client, 16448, 1224560)
					{
						 Name = "Item_18",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD17_Dot_ManualDisable, client, 16448, 1224560){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD17_Dot_Sensor_In_Signal, client, 16448, 1224561){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD18, client, 16448, 1224562)
					{
						 Name = "Item_19",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD18_Dot_ManualDisable, client, 16448, 1224562){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD18_Dot_Sensor_In_Signal, client, 16448, 1224563){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD19, client, 16448, 1224564)
					{
						 Name = "Item_20",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD19_Dot_ManualDisable, client, 16448, 1224564){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD19_Dot_Sensor_In_Signal, client, 16448, 1224565){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD20, client, 16448, 1224566)
					{
						 Name = "Item_21",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD20_Dot_ManualDisable, client, 16448, 1224566){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD20_Dot_Sensor_In_Signal, client, 16448, 1224567){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD21, client, 16448, 1224568)
					{
						 Name = "Item_22",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD21_Dot_ManualDisable, client, 16448, 1224568){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD21_Dot_Sensor_In_Signal, client, 16448, 1224569){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD22, client, 16448, 1224570)
					{
						 Name = "Item_23",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD22_Dot_ManualDisable, client, 16448, 1224570){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD22_Dot_Sensor_In_Signal, client, 16448, 1224571){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD23, client, 16448, 1224572)
					{
						 Name = "Item_24",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD23_Dot_ManualDisable, client, 16448, 1224572){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD23_Dot_Sensor_In_Signal, client, 16448, 1224573){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD24, client, 16448, 1224574)
					{
						 Name = "Item_25",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD24_Dot_ManualDisable, client, 16448, 1224574){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD24_Dot_Sensor_In_Signal, client, 16448, 1224575){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD25, client, 16448, 1224576)
					{
						 Name = "Item_26",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD25_Dot_ManualDisable, client, 16448, 1224576){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD25_Dot_Sensor_In_Signal, client, 16448, 1224577){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD26, client, 16448, 1224578)
					{
						 Name = "Item_27",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD26_Dot_ManualDisable, client, 16448, 1224578){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD26_Dot_Sensor_In_Signal, client, 16448, 1224579){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD27, client, 16448, 1224580)
					{
						 Name = "Item_28",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD27_Dot_ManualDisable, client, 16448, 1224580){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD27_Dot_Sensor_In_Signal, client, 16448, 1224581){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD28, client, 16448, 1224582)
					{
						 Name = "Item_29",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD28_Dot_ManualDisable, client, 16448, 1224582){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD28_Dot_Sensor_In_Signal, client, 16448, 1224583){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD29, client, 16448, 1224584)
					{
						 Name = "Item_30",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD29_Dot_ManualDisable, client, 16448, 1224584){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD29_Dot_Sensor_In_Signal, client, 16448, 1224585){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD30, client, 16448, 1224586)
					{
						 Name = "Item_31",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD30_Dot_ManualDisable, client, 16448, 1224586){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD30_Dot_Sensor_In_Signal, client, 16448, 1224587){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD31, client, 16448, 1224588)
					{
						 Name = "Item_32",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD31_Dot_ManualDisable, client, 16448, 1224588){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD31_Dot_Sensor_In_Signal, client, 16448, 1224589){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD32, client, 16448, 1224590)
					{
						 Name = "Item_33",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD32_Dot_ManualDisable, client, 16448, 1224590){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD32_Dot_Sensor_In_Signal, client, 16448, 1224591){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD33, client, 16448, 1224592)
					{
						 Name = "Item_34",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD33_Dot_ManualDisable, client, 16448, 1224592){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD33_Dot_Sensor_In_Signal, client, 16448, 1224593){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD34, client, 16448, 1224594)
					{
						 Name = "Item_35",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD34_Dot_ManualDisable, client, 16448, 1224594){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD34_Dot_Sensor_In_Signal, client, 16448, 1224595){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD35, client, 16448, 1224596)
					{
						 Name = "Item_36",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD35_Dot_ManualDisable, client, 16448, 1224596){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD35_Dot_Sensor_In_Signal, client, 16448, 1224597){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD36, client, 16448, 1224598)
					{
						 Name = "Item_37",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD36_Dot_ManualDisable, client, 16448, 1224598){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD36_Dot_Sensor_In_Signal, client, 16448, 1224599){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD37, client, 16448, 1224600)
					{
						 Name = "Item_38",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD37_Dot_ManualDisable, client, 16448, 1224600){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD37_Dot_Sensor_In_Signal, client, 16448, 1224601){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD38, client, 16448, 1224602)
					{
						 Name = "Item_39",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD38_Dot_ManualDisable, client, 16448, 1224602){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD38_Dot_Sensor_In_Signal, client, 16448, 1224603){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD39, client, 16448, 1224604)
					{
						 Name = "Item_40",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD39_Dot_ManualDisable, client, 16448, 1224604){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD39_Dot_Sensor_In_Signal, client, 16448, 1224605){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD40, client, 16448, 1224606)
					{
						 Name = "Item_41",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD40_Dot_ManualDisable, client, 16448, 1224606){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD40_Dot_Sensor_In_Signal, client, 16448, 1224607){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD41, client, 16448, 1224608)
					{
						 Name = "Item_42",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD41_Dot_ManualDisable, client, 16448, 1224608){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD41_Dot_Sensor_In_Signal, client, 16448, 1224609){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD42, client, 16448, 1224610)
					{
						 Name = "Item_43",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD42_Dot_ManualDisable, client, 16448, 1224610){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD42_Dot_Sensor_In_Signal, client, 16448, 1224611){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD43, client, 16448, 1224612)
					{
						 Name = "Item_44",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD43_Dot_ManualDisable, client, 16448, 1224612){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD43_Dot_Sensor_In_Signal, client, 16448, 1224613){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD44, client, 16448, 1224614)
					{
						 Name = "Item_45",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD44_Dot_ManualDisable, client, 16448, 1224614){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD44_Dot_Sensor_In_Signal, client, 16448, 1224615){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD45, client, 16448, 1224616)
					{
						 Name = "Item_46",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD45_Dot_ManualDisable, client, 16448, 1224616){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD45_Dot_Sensor_In_Signal, client, 16448, 1224617){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD46, client, 16448, 1224618)
					{
						 Name = "Item_47",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD46_Dot_ManualDisable, client, 16448, 1224618){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD46_Dot_Sensor_In_Signal, client, 16448, 1224619){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD47, client, 16448, 1224620)
					{
						 Name = "Item_48",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD47_Dot_ManualDisable, client, 16448, 1224620){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD47_Dot_Sensor_In_Signal, client, 16448, 1224621){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD48, client, 16448, 1224622)
					{
						 Name = "Item_49",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD48_Dot_ManualDisable, client, 16448, 1224622){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD48_Dot_Sensor_In_Signal, client, 16448, 1224623){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD49, client, 16448, 1224624)
					{
						 Name = "Item_50",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD49_Dot_ManualDisable, client, 16448, 1224624){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD49_Dot_Sensor_In_Signal, client, 16448, 1224625){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD50, client, 16448, 1224626)
					{
						 Name = "Item_51",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD50_Dot_ManualDisable, client, 16448, 1224626){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD50_Dot_Sensor_In_Signal, client, 16448, 1224627){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD51, client, 16448, 1224628)
					{
						 Name = "Item_52",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD51_Dot_ManualDisable, client, 16448, 1224628){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD51_Dot_Sensor_In_Signal, client, 16448, 1224629){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD52, client, 16448, 1224630)
					{
						 Name = "Item_53",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD52_Dot_ManualDisable, client, 16448, 1224630){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD52_Dot_Sensor_In_Signal, client, 16448, 1224631){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD53, client, 16448, 1224632)
					{
						 Name = "Item_54",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD53_Dot_ManualDisable, client, 16448, 1224632){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD53_Dot_Sensor_In_Signal, client, 16448, 1224633){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD54, client, 16448, 1224634)
					{
						 Name = "Item_55",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD54_Dot_ManualDisable, client, 16448, 1224634){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD54_Dot_Sensor_In_Signal, client, 16448, 1224635){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD55, client, 16448, 1224636)
					{
						 Name = "Item_56",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD55_Dot_ManualDisable, client, 16448, 1224636){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD55_Dot_Sensor_In_Signal, client, 16448, 1224637){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD56, client, 16448, 1224638)
					{
						 Name = "Item_57",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD56_Dot_ManualDisable, client, 16448, 1224638){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD56_Dot_Sensor_In_Signal, client, 16448, 1224639){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD57, client, 16448, 1224640)
					{
						 Name = "Item_58",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD57_Dot_ManualDisable, client, 16448, 1224640){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD57_Dot_Sensor_In_Signal, client, 16448, 1224641){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD58, client, 16448, 1224642)
					{
						 Name = "Item_59",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD58_Dot_ManualDisable, client, 16448, 1224642){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD58_Dot_Sensor_In_Signal, client, 16448, 1224643){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD59, client, 16448, 1224644)
					{
						 Name = "Item_60",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD59_Dot_ManualDisable, client, 16448, 1224644){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD59_Dot_Sensor_In_Signal, client, 16448, 1224645){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD60, client, 16448, 1224646)
					{
						 Name = "Item_61",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD60_Dot_ManualDisable, client, 16448, 1224646){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD60_Dot_Sensor_In_Signal, client, 16448, 1224647){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD61, client, 16448, 1224648)
					{
						 Name = "Item_62",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD61_Dot_ManualDisable, client, 16448, 1224648){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD61_Dot_Sensor_In_Signal, client, 16448, 1224649){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD62, client, 16448, 1224650)
					{
						 Name = "Item_63",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD62_Dot_ManualDisable, client, 16448, 1224650){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD62_Dot_Sensor_In_Signal, client, 16448, 1224651){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD63, client, 16448, 1224652)
					{
						 Name = "Item_64",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD63_Dot_ManualDisable, client, 16448, 1224652){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD63_Dot_Sensor_In_Signal, client, 16448, 1224653){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD64, client, 16448, 1224654)
					{
						 Name = "Item_65",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD64_Dot_ManualDisable, client, 16448, 1224654){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD64_Dot_Sensor_In_Signal, client, 16448, 1224655){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD65, client, 16448, 1224656)
					{
						 Name = "Item_66",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD65_Dot_ManualDisable, client, 16448, 1224656){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD65_Dot_Sensor_In_Signal, client, 16448, 1224657){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD66, client, 16448, 1224658)
					{
						 Name = "Item_67",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD66_Dot_ManualDisable, client, 16448, 1224658){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD66_Dot_Sensor_In_Signal, client, 16448, 1224659){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD67, client, 16448, 1224660)
					{
						 Name = "Item_68",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD67_Dot_ManualDisable, client, 16448, 1224660){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD67_Dot_Sensor_In_Signal, client, 16448, 1224661){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD68, client, 16448, 1224662)
					{
						 Name = "Item_69",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD68_Dot_ManualDisable, client, 16448, 1224662){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD68_Dot_Sensor_In_Signal, client, 16448, 1224663){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD69, client, 16448, 1224664)
					{
						 Name = "Item_70",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD69_Dot_ManualDisable, client, 16448, 1224664){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD69_Dot_Sensor_In_Signal, client, 16448, 1224665){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD70, client, 16448, 1224666)
					{
						 Name = "Item_71",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD70_Dot_ManualDisable, client, 16448, 1224666){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD70_Dot_Sensor_In_Signal, client, 16448, 1224667){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD71, client, 16448, 1224668)
					{
						 Name = "Item_72",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD71_Dot_ManualDisable, client, 16448, 1224668){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD71_Dot_Sensor_In_Signal, client, 16448, 1224669){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD72, client, 16448, 1224670)
					{
						 Name = "Item_73",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD72_Dot_ManualDisable, client, 16448, 1224670){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD72_Dot_Sensor_In_Signal, client, 16448, 1224671){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD73, client, 16448, 1224672)
					{
						 Name = "Item_74",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD73_Dot_ManualDisable, client, 16448, 1224672){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD73_Dot_Sensor_In_Signal, client, 16448, 1224673){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD74, client, 16448, 1224674)
					{
						 Name = "Item_75",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD74_Dot_ManualDisable, client, 16448, 1224674){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD74_Dot_Sensor_In_Signal, client, 16448, 1224675){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD75, client, 16448, 1224676)
					{
						 Name = "Item_76",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD75_Dot_ManualDisable, client, 16448, 1224676){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD75_Dot_Sensor_In_Signal, client, 16448, 1224677){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD76, client, 16448, 1224678)
					{
						 Name = "Item_77",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD76_Dot_ManualDisable, client, 16448, 1224678){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD76_Dot_Sensor_In_Signal, client, 16448, 1224679){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD77, client, 16448, 1224680)
					{
						 Name = "Item_78",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD77_Dot_ManualDisable, client, 16448, 1224680){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD77_Dot_Sensor_In_Signal, client, 16448, 1224681){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD78, client, 16448, 1224682)
					{
						 Name = "Item_79",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD78_Dot_ManualDisable, client, 16448, 1224682){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD78_Dot_Sensor_In_Signal, client, 16448, 1224683){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD79, client, 16448, 1224684)
					{
						 Name = "Item_80",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD79_Dot_ManualDisable, client, 16448, 1224684){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD79_Dot_Sensor_In_Signal, client, 16448, 1224685){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD80, client, 16448, 1224686)
					{
						 Name = "Item_81",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD80_Dot_ManualDisable, client, 16448, 1224686){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD80_Dot_Sensor_In_Signal, client, 16448, 1224687){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD81, client, 16448, 1224688)
					{
						 Name = "Item_82",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD81_Dot_ManualDisable, client, 16448, 1224688){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD81_Dot_Sensor_In_Signal, client, 16448, 1224689){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD82, client, 16448, 1224690)
					{
						 Name = "Item_83",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD82_Dot_ManualDisable, client, 16448, 1224690){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD82_Dot_Sensor_In_Signal, client, 16448, 1224691){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD83, client, 16448, 1224692)
					{
						 Name = "Item_84",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD83_Dot_ManualDisable, client, 16448, 1224692){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD83_Dot_Sensor_In_Signal, client, 16448, 1224693){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD84, client, 16448, 1224694)
					{
						 Name = "Item_85",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD84_Dot_ManualDisable, client, 16448, 1224694){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD84_Dot_Sensor_In_Signal, client, 16448, 1224695){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD85, client, 16448, 1224696)
					{
						 Name = "Item_86",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD85_Dot_ManualDisable, client, 16448, 1224696){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD85_Dot_Sensor_In_Signal, client, 16448, 1224697){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD86, client, 16448, 1224698)
					{
						 Name = "Item_87",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD86_Dot_ManualDisable, client, 16448, 1224698){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD86_Dot_Sensor_In_Signal, client, 16448, 1224699){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD87, client, 16448, 1224700)
					{
						 Name = "Item_88",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD87_Dot_ManualDisable, client, 16448, 1224700){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD87_Dot_Sensor_In_Signal, client, 16448, 1224701){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD88, client, 16448, 1224702)
					{
						 Name = "Item_89",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD88_Dot_ManualDisable, client, 16448, 1224702){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD88_Dot_Sensor_In_Signal, client, 16448, 1224703){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD89, client, 16448, 1224704)
					{
						 Name = "Item_90",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD89_Dot_ManualDisable, client, 16448, 1224704){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD89_Dot_Sensor_In_Signal, client, 16448, 1224705){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD90, client, 16448, 1224706)
					{
						 Name = "Item_91",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD90_Dot_ManualDisable, client, 16448, 1224706){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD90_Dot_Sensor_In_Signal, client, 16448, 1224707){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD91, client, 16448, 1224708)
					{
						 Name = "Item_92",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD91_Dot_ManualDisable, client, 16448, 1224708){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD91_Dot_Sensor_In_Signal, client, 16448, 1224709){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD92, client, 16448, 1224710)
					{
						 Name = "Item_93",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD92_Dot_ManualDisable, client, 16448, 1224710){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD92_Dot_Sensor_In_Signal, client, 16448, 1224711){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD93, client, 16448, 1224712)
					{
						 Name = "Item_94",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD93_Dot_ManualDisable, client, 16448, 1224712){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD93_Dot_Sensor_In_Signal, client, 16448, 1224713){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD94, client, 16448, 1224714)
					{
						 Name = "Item_95",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD94_Dot_ManualDisable, client, 16448, 1224714){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD94_Dot_Sensor_In_Signal, client, 16448, 1224715){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD95, client, 16448, 1224716)
					{
						 Name = "Item_96",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD95_Dot_ManualDisable, client, 16448, 1224716){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD95_Dot_Sensor_In_Signal, client, 16448, 1224717){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD96, client, 16448, 1224718)
					{
						 Name = "Item_97",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD96_Dot_ManualDisable, client, 16448, 1224718){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD96_Dot_Sensor_In_Signal, client, 16448, 1224719){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD97, client, 16448, 1224720)
					{
						 Name = "Item_98",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD97_Dot_ManualDisable, client, 16448, 1224720){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD97_Dot_Sensor_In_Signal, client, 16448, 1224721){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD98, client, 16448, 1224722)
					{
						 Name = "Item_99",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD98_Dot_ManualDisable, client, 16448, 1224722){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD98_Dot_Sensor_In_Signal, client, 16448, 1224723){ Name = "Sensor_In_Signal" },
					},
					new DUT_SR_CMDWrapper(this.GetSR_AUTO_CMD99, client, 16448, 1224724)
					{
						 Name = "Item_100",
						ManualDisable = new BeckhoffBool(this.GetSR_AUTO_CMD99_Dot_ManualDisable, client, 16448, 1224724){ Name = "ManualDisable" },
						Sensor_In_Signal = new BeckhoffBool(this.GetSR_AUTO_CMD99_Dot_Sensor_In_Signal, client, 16448, 1224725){ Name = "Sensor_In_Signal" },
					},
			}, false){ Name = "SR_AUTO_CMD" };
			SR_State = new BeckhoffStructArray<DUT_SR_STATE100, DUT_SR_STATEWrapper, DUT_SR_STATE>(this.GetSR_State, client, 16448, 1224726,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1224726 ,1224728 ,1224730 ,1224732 ,1224734 ,1224736 ,1224738 ,1224740 ,1224742 ,1224744 ,1224746 ,1224748 ,1224750 ,1224752 ,1224754 ,1224756 ,1224758 ,1224760 ,1224762 ,1224764 ,1224766 ,1224768 ,1224770 ,1224772 ,1224774 ,1224776 ,1224778 ,1224780 ,1224782 ,1224784 ,1224786 ,1224788 ,1224790 ,1224792 ,1224794 ,1224796 ,1224798 ,1224800 ,1224802 ,1224804 ,1224806 ,1224808 ,1224810 ,1224812 ,1224814 ,1224816 ,1224818 ,1224820 ,1224822 ,1224824 ,1224826 ,1224828 ,1224830 ,1224832 ,1224834 ,1224836 ,1224838 ,1224840 ,1224842 ,1224844 ,1224846 ,1224848 ,1224850 ,1224852 ,1224854 ,1224856 ,1224858 ,1224860 ,1224862 ,1224864 ,1224866 ,1224868 ,1224870 ,1224872 ,1224874 ,1224876 ,1224878 ,1224880 ,1224882 ,1224884 ,1224886 ,1224888 ,1224890 ,1224892 ,1224894 ,1224896 ,1224898 ,1224900 ,1224902 ,1224904 ,1224906 ,1224908 ,1224910 ,1224912 ,1224914 ,1224916 ,1224918 ,1224920 ,1224922 ,1224924 , },
				new DUT_SR_STATEWrapper[]
				{
					new DUT_SR_STATEWrapper(this.GetSR_State0, client, 16448, 1224726)
					{
						 Name = "Item_1",
						Sensor_Act = new BeckhoffBool(this.GetSR_State0_Dot_Sensor_Act, client, 16448, 1224726){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State0_Dot_Sensor_Fault_Alarm, client, 16448, 1224727){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State1, client, 16448, 1224728)
					{
						 Name = "Item_2",
						Sensor_Act = new BeckhoffBool(this.GetSR_State1_Dot_Sensor_Act, client, 16448, 1224728){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State1_Dot_Sensor_Fault_Alarm, client, 16448, 1224729){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State2, client, 16448, 1224730)
					{
						 Name = "Item_3",
						Sensor_Act = new BeckhoffBool(this.GetSR_State2_Dot_Sensor_Act, client, 16448, 1224730){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State2_Dot_Sensor_Fault_Alarm, client, 16448, 1224731){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State3, client, 16448, 1224732)
					{
						 Name = "Item_4",
						Sensor_Act = new BeckhoffBool(this.GetSR_State3_Dot_Sensor_Act, client, 16448, 1224732){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State3_Dot_Sensor_Fault_Alarm, client, 16448, 1224733){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State4, client, 16448, 1224734)
					{
						 Name = "Item_5",
						Sensor_Act = new BeckhoffBool(this.GetSR_State4_Dot_Sensor_Act, client, 16448, 1224734){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State4_Dot_Sensor_Fault_Alarm, client, 16448, 1224735){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State5, client, 16448, 1224736)
					{
						 Name = "Item_6",
						Sensor_Act = new BeckhoffBool(this.GetSR_State5_Dot_Sensor_Act, client, 16448, 1224736){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State5_Dot_Sensor_Fault_Alarm, client, 16448, 1224737){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State6, client, 16448, 1224738)
					{
						 Name = "Item_7",
						Sensor_Act = new BeckhoffBool(this.GetSR_State6_Dot_Sensor_Act, client, 16448, 1224738){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State6_Dot_Sensor_Fault_Alarm, client, 16448, 1224739){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State7, client, 16448, 1224740)
					{
						 Name = "Item_8",
						Sensor_Act = new BeckhoffBool(this.GetSR_State7_Dot_Sensor_Act, client, 16448, 1224740){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State7_Dot_Sensor_Fault_Alarm, client, 16448, 1224741){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State8, client, 16448, 1224742)
					{
						 Name = "Item_9",
						Sensor_Act = new BeckhoffBool(this.GetSR_State8_Dot_Sensor_Act, client, 16448, 1224742){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State8_Dot_Sensor_Fault_Alarm, client, 16448, 1224743){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State9, client, 16448, 1224744)
					{
						 Name = "Item_10",
						Sensor_Act = new BeckhoffBool(this.GetSR_State9_Dot_Sensor_Act, client, 16448, 1224744){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State9_Dot_Sensor_Fault_Alarm, client, 16448, 1224745){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State10, client, 16448, 1224746)
					{
						 Name = "Item_11",
						Sensor_Act = new BeckhoffBool(this.GetSR_State10_Dot_Sensor_Act, client, 16448, 1224746){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State10_Dot_Sensor_Fault_Alarm, client, 16448, 1224747){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State11, client, 16448, 1224748)
					{
						 Name = "Item_12",
						Sensor_Act = new BeckhoffBool(this.GetSR_State11_Dot_Sensor_Act, client, 16448, 1224748){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State11_Dot_Sensor_Fault_Alarm, client, 16448, 1224749){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State12, client, 16448, 1224750)
					{
						 Name = "Item_13",
						Sensor_Act = new BeckhoffBool(this.GetSR_State12_Dot_Sensor_Act, client, 16448, 1224750){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State12_Dot_Sensor_Fault_Alarm, client, 16448, 1224751){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State13, client, 16448, 1224752)
					{
						 Name = "Item_14",
						Sensor_Act = new BeckhoffBool(this.GetSR_State13_Dot_Sensor_Act, client, 16448, 1224752){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State13_Dot_Sensor_Fault_Alarm, client, 16448, 1224753){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State14, client, 16448, 1224754)
					{
						 Name = "Item_15",
						Sensor_Act = new BeckhoffBool(this.GetSR_State14_Dot_Sensor_Act, client, 16448, 1224754){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State14_Dot_Sensor_Fault_Alarm, client, 16448, 1224755){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State15, client, 16448, 1224756)
					{
						 Name = "Item_16",
						Sensor_Act = new BeckhoffBool(this.GetSR_State15_Dot_Sensor_Act, client, 16448, 1224756){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State15_Dot_Sensor_Fault_Alarm, client, 16448, 1224757){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State16, client, 16448, 1224758)
					{
						 Name = "Item_17",
						Sensor_Act = new BeckhoffBool(this.GetSR_State16_Dot_Sensor_Act, client, 16448, 1224758){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State16_Dot_Sensor_Fault_Alarm, client, 16448, 1224759){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State17, client, 16448, 1224760)
					{
						 Name = "Item_18",
						Sensor_Act = new BeckhoffBool(this.GetSR_State17_Dot_Sensor_Act, client, 16448, 1224760){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State17_Dot_Sensor_Fault_Alarm, client, 16448, 1224761){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State18, client, 16448, 1224762)
					{
						 Name = "Item_19",
						Sensor_Act = new BeckhoffBool(this.GetSR_State18_Dot_Sensor_Act, client, 16448, 1224762){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State18_Dot_Sensor_Fault_Alarm, client, 16448, 1224763){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State19, client, 16448, 1224764)
					{
						 Name = "Item_20",
						Sensor_Act = new BeckhoffBool(this.GetSR_State19_Dot_Sensor_Act, client, 16448, 1224764){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State19_Dot_Sensor_Fault_Alarm, client, 16448, 1224765){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State20, client, 16448, 1224766)
					{
						 Name = "Item_21",
						Sensor_Act = new BeckhoffBool(this.GetSR_State20_Dot_Sensor_Act, client, 16448, 1224766){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State20_Dot_Sensor_Fault_Alarm, client, 16448, 1224767){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State21, client, 16448, 1224768)
					{
						 Name = "Item_22",
						Sensor_Act = new BeckhoffBool(this.GetSR_State21_Dot_Sensor_Act, client, 16448, 1224768){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State21_Dot_Sensor_Fault_Alarm, client, 16448, 1224769){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State22, client, 16448, 1224770)
					{
						 Name = "Item_23",
						Sensor_Act = new BeckhoffBool(this.GetSR_State22_Dot_Sensor_Act, client, 16448, 1224770){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State22_Dot_Sensor_Fault_Alarm, client, 16448, 1224771){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State23, client, 16448, 1224772)
					{
						 Name = "Item_24",
						Sensor_Act = new BeckhoffBool(this.GetSR_State23_Dot_Sensor_Act, client, 16448, 1224772){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State23_Dot_Sensor_Fault_Alarm, client, 16448, 1224773){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State24, client, 16448, 1224774)
					{
						 Name = "Item_25",
						Sensor_Act = new BeckhoffBool(this.GetSR_State24_Dot_Sensor_Act, client, 16448, 1224774){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State24_Dot_Sensor_Fault_Alarm, client, 16448, 1224775){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State25, client, 16448, 1224776)
					{
						 Name = "Item_26",
						Sensor_Act = new BeckhoffBool(this.GetSR_State25_Dot_Sensor_Act, client, 16448, 1224776){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State25_Dot_Sensor_Fault_Alarm, client, 16448, 1224777){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State26, client, 16448, 1224778)
					{
						 Name = "Item_27",
						Sensor_Act = new BeckhoffBool(this.GetSR_State26_Dot_Sensor_Act, client, 16448, 1224778){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State26_Dot_Sensor_Fault_Alarm, client, 16448, 1224779){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State27, client, 16448, 1224780)
					{
						 Name = "Item_28",
						Sensor_Act = new BeckhoffBool(this.GetSR_State27_Dot_Sensor_Act, client, 16448, 1224780){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State27_Dot_Sensor_Fault_Alarm, client, 16448, 1224781){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State28, client, 16448, 1224782)
					{
						 Name = "Item_29",
						Sensor_Act = new BeckhoffBool(this.GetSR_State28_Dot_Sensor_Act, client, 16448, 1224782){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State28_Dot_Sensor_Fault_Alarm, client, 16448, 1224783){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State29, client, 16448, 1224784)
					{
						 Name = "Item_30",
						Sensor_Act = new BeckhoffBool(this.GetSR_State29_Dot_Sensor_Act, client, 16448, 1224784){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State29_Dot_Sensor_Fault_Alarm, client, 16448, 1224785){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State30, client, 16448, 1224786)
					{
						 Name = "Item_31",
						Sensor_Act = new BeckhoffBool(this.GetSR_State30_Dot_Sensor_Act, client, 16448, 1224786){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State30_Dot_Sensor_Fault_Alarm, client, 16448, 1224787){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State31, client, 16448, 1224788)
					{
						 Name = "Item_32",
						Sensor_Act = new BeckhoffBool(this.GetSR_State31_Dot_Sensor_Act, client, 16448, 1224788){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State31_Dot_Sensor_Fault_Alarm, client, 16448, 1224789){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State32, client, 16448, 1224790)
					{
						 Name = "Item_33",
						Sensor_Act = new BeckhoffBool(this.GetSR_State32_Dot_Sensor_Act, client, 16448, 1224790){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State32_Dot_Sensor_Fault_Alarm, client, 16448, 1224791){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State33, client, 16448, 1224792)
					{
						 Name = "Item_34",
						Sensor_Act = new BeckhoffBool(this.GetSR_State33_Dot_Sensor_Act, client, 16448, 1224792){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State33_Dot_Sensor_Fault_Alarm, client, 16448, 1224793){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State34, client, 16448, 1224794)
					{
						 Name = "Item_35",
						Sensor_Act = new BeckhoffBool(this.GetSR_State34_Dot_Sensor_Act, client, 16448, 1224794){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State34_Dot_Sensor_Fault_Alarm, client, 16448, 1224795){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State35, client, 16448, 1224796)
					{
						 Name = "Item_36",
						Sensor_Act = new BeckhoffBool(this.GetSR_State35_Dot_Sensor_Act, client, 16448, 1224796){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State35_Dot_Sensor_Fault_Alarm, client, 16448, 1224797){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State36, client, 16448, 1224798)
					{
						 Name = "Item_37",
						Sensor_Act = new BeckhoffBool(this.GetSR_State36_Dot_Sensor_Act, client, 16448, 1224798){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State36_Dot_Sensor_Fault_Alarm, client, 16448, 1224799){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State37, client, 16448, 1224800)
					{
						 Name = "Item_38",
						Sensor_Act = new BeckhoffBool(this.GetSR_State37_Dot_Sensor_Act, client, 16448, 1224800){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State37_Dot_Sensor_Fault_Alarm, client, 16448, 1224801){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State38, client, 16448, 1224802)
					{
						 Name = "Item_39",
						Sensor_Act = new BeckhoffBool(this.GetSR_State38_Dot_Sensor_Act, client, 16448, 1224802){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State38_Dot_Sensor_Fault_Alarm, client, 16448, 1224803){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State39, client, 16448, 1224804)
					{
						 Name = "Item_40",
						Sensor_Act = new BeckhoffBool(this.GetSR_State39_Dot_Sensor_Act, client, 16448, 1224804){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State39_Dot_Sensor_Fault_Alarm, client, 16448, 1224805){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State40, client, 16448, 1224806)
					{
						 Name = "Item_41",
						Sensor_Act = new BeckhoffBool(this.GetSR_State40_Dot_Sensor_Act, client, 16448, 1224806){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State40_Dot_Sensor_Fault_Alarm, client, 16448, 1224807){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State41, client, 16448, 1224808)
					{
						 Name = "Item_42",
						Sensor_Act = new BeckhoffBool(this.GetSR_State41_Dot_Sensor_Act, client, 16448, 1224808){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State41_Dot_Sensor_Fault_Alarm, client, 16448, 1224809){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State42, client, 16448, 1224810)
					{
						 Name = "Item_43",
						Sensor_Act = new BeckhoffBool(this.GetSR_State42_Dot_Sensor_Act, client, 16448, 1224810){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State42_Dot_Sensor_Fault_Alarm, client, 16448, 1224811){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State43, client, 16448, 1224812)
					{
						 Name = "Item_44",
						Sensor_Act = new BeckhoffBool(this.GetSR_State43_Dot_Sensor_Act, client, 16448, 1224812){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State43_Dot_Sensor_Fault_Alarm, client, 16448, 1224813){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State44, client, 16448, 1224814)
					{
						 Name = "Item_45",
						Sensor_Act = new BeckhoffBool(this.GetSR_State44_Dot_Sensor_Act, client, 16448, 1224814){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State44_Dot_Sensor_Fault_Alarm, client, 16448, 1224815){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State45, client, 16448, 1224816)
					{
						 Name = "Item_46",
						Sensor_Act = new BeckhoffBool(this.GetSR_State45_Dot_Sensor_Act, client, 16448, 1224816){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State45_Dot_Sensor_Fault_Alarm, client, 16448, 1224817){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State46, client, 16448, 1224818)
					{
						 Name = "Item_47",
						Sensor_Act = new BeckhoffBool(this.GetSR_State46_Dot_Sensor_Act, client, 16448, 1224818){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State46_Dot_Sensor_Fault_Alarm, client, 16448, 1224819){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State47, client, 16448, 1224820)
					{
						 Name = "Item_48",
						Sensor_Act = new BeckhoffBool(this.GetSR_State47_Dot_Sensor_Act, client, 16448, 1224820){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State47_Dot_Sensor_Fault_Alarm, client, 16448, 1224821){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State48, client, 16448, 1224822)
					{
						 Name = "Item_49",
						Sensor_Act = new BeckhoffBool(this.GetSR_State48_Dot_Sensor_Act, client, 16448, 1224822){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State48_Dot_Sensor_Fault_Alarm, client, 16448, 1224823){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State49, client, 16448, 1224824)
					{
						 Name = "Item_50",
						Sensor_Act = new BeckhoffBool(this.GetSR_State49_Dot_Sensor_Act, client, 16448, 1224824){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State49_Dot_Sensor_Fault_Alarm, client, 16448, 1224825){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State50, client, 16448, 1224826)
					{
						 Name = "Item_51",
						Sensor_Act = new BeckhoffBool(this.GetSR_State50_Dot_Sensor_Act, client, 16448, 1224826){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State50_Dot_Sensor_Fault_Alarm, client, 16448, 1224827){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State51, client, 16448, 1224828)
					{
						 Name = "Item_52",
						Sensor_Act = new BeckhoffBool(this.GetSR_State51_Dot_Sensor_Act, client, 16448, 1224828){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State51_Dot_Sensor_Fault_Alarm, client, 16448, 1224829){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State52, client, 16448, 1224830)
					{
						 Name = "Item_53",
						Sensor_Act = new BeckhoffBool(this.GetSR_State52_Dot_Sensor_Act, client, 16448, 1224830){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State52_Dot_Sensor_Fault_Alarm, client, 16448, 1224831){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State53, client, 16448, 1224832)
					{
						 Name = "Item_54",
						Sensor_Act = new BeckhoffBool(this.GetSR_State53_Dot_Sensor_Act, client, 16448, 1224832){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State53_Dot_Sensor_Fault_Alarm, client, 16448, 1224833){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State54, client, 16448, 1224834)
					{
						 Name = "Item_55",
						Sensor_Act = new BeckhoffBool(this.GetSR_State54_Dot_Sensor_Act, client, 16448, 1224834){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State54_Dot_Sensor_Fault_Alarm, client, 16448, 1224835){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State55, client, 16448, 1224836)
					{
						 Name = "Item_56",
						Sensor_Act = new BeckhoffBool(this.GetSR_State55_Dot_Sensor_Act, client, 16448, 1224836){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State55_Dot_Sensor_Fault_Alarm, client, 16448, 1224837){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State56, client, 16448, 1224838)
					{
						 Name = "Item_57",
						Sensor_Act = new BeckhoffBool(this.GetSR_State56_Dot_Sensor_Act, client, 16448, 1224838){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State56_Dot_Sensor_Fault_Alarm, client, 16448, 1224839){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State57, client, 16448, 1224840)
					{
						 Name = "Item_58",
						Sensor_Act = new BeckhoffBool(this.GetSR_State57_Dot_Sensor_Act, client, 16448, 1224840){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State57_Dot_Sensor_Fault_Alarm, client, 16448, 1224841){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State58, client, 16448, 1224842)
					{
						 Name = "Item_59",
						Sensor_Act = new BeckhoffBool(this.GetSR_State58_Dot_Sensor_Act, client, 16448, 1224842){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State58_Dot_Sensor_Fault_Alarm, client, 16448, 1224843){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State59, client, 16448, 1224844)
					{
						 Name = "Item_60",
						Sensor_Act = new BeckhoffBool(this.GetSR_State59_Dot_Sensor_Act, client, 16448, 1224844){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State59_Dot_Sensor_Fault_Alarm, client, 16448, 1224845){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State60, client, 16448, 1224846)
					{
						 Name = "Item_61",
						Sensor_Act = new BeckhoffBool(this.GetSR_State60_Dot_Sensor_Act, client, 16448, 1224846){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State60_Dot_Sensor_Fault_Alarm, client, 16448, 1224847){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State61, client, 16448, 1224848)
					{
						 Name = "Item_62",
						Sensor_Act = new BeckhoffBool(this.GetSR_State61_Dot_Sensor_Act, client, 16448, 1224848){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State61_Dot_Sensor_Fault_Alarm, client, 16448, 1224849){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State62, client, 16448, 1224850)
					{
						 Name = "Item_63",
						Sensor_Act = new BeckhoffBool(this.GetSR_State62_Dot_Sensor_Act, client, 16448, 1224850){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State62_Dot_Sensor_Fault_Alarm, client, 16448, 1224851){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State63, client, 16448, 1224852)
					{
						 Name = "Item_64",
						Sensor_Act = new BeckhoffBool(this.GetSR_State63_Dot_Sensor_Act, client, 16448, 1224852){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State63_Dot_Sensor_Fault_Alarm, client, 16448, 1224853){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State64, client, 16448, 1224854)
					{
						 Name = "Item_65",
						Sensor_Act = new BeckhoffBool(this.GetSR_State64_Dot_Sensor_Act, client, 16448, 1224854){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State64_Dot_Sensor_Fault_Alarm, client, 16448, 1224855){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State65, client, 16448, 1224856)
					{
						 Name = "Item_66",
						Sensor_Act = new BeckhoffBool(this.GetSR_State65_Dot_Sensor_Act, client, 16448, 1224856){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State65_Dot_Sensor_Fault_Alarm, client, 16448, 1224857){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State66, client, 16448, 1224858)
					{
						 Name = "Item_67",
						Sensor_Act = new BeckhoffBool(this.GetSR_State66_Dot_Sensor_Act, client, 16448, 1224858){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State66_Dot_Sensor_Fault_Alarm, client, 16448, 1224859){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State67, client, 16448, 1224860)
					{
						 Name = "Item_68",
						Sensor_Act = new BeckhoffBool(this.GetSR_State67_Dot_Sensor_Act, client, 16448, 1224860){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State67_Dot_Sensor_Fault_Alarm, client, 16448, 1224861){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State68, client, 16448, 1224862)
					{
						 Name = "Item_69",
						Sensor_Act = new BeckhoffBool(this.GetSR_State68_Dot_Sensor_Act, client, 16448, 1224862){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State68_Dot_Sensor_Fault_Alarm, client, 16448, 1224863){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State69, client, 16448, 1224864)
					{
						 Name = "Item_70",
						Sensor_Act = new BeckhoffBool(this.GetSR_State69_Dot_Sensor_Act, client, 16448, 1224864){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State69_Dot_Sensor_Fault_Alarm, client, 16448, 1224865){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State70, client, 16448, 1224866)
					{
						 Name = "Item_71",
						Sensor_Act = new BeckhoffBool(this.GetSR_State70_Dot_Sensor_Act, client, 16448, 1224866){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State70_Dot_Sensor_Fault_Alarm, client, 16448, 1224867){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State71, client, 16448, 1224868)
					{
						 Name = "Item_72",
						Sensor_Act = new BeckhoffBool(this.GetSR_State71_Dot_Sensor_Act, client, 16448, 1224868){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State71_Dot_Sensor_Fault_Alarm, client, 16448, 1224869){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State72, client, 16448, 1224870)
					{
						 Name = "Item_73",
						Sensor_Act = new BeckhoffBool(this.GetSR_State72_Dot_Sensor_Act, client, 16448, 1224870){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State72_Dot_Sensor_Fault_Alarm, client, 16448, 1224871){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State73, client, 16448, 1224872)
					{
						 Name = "Item_74",
						Sensor_Act = new BeckhoffBool(this.GetSR_State73_Dot_Sensor_Act, client, 16448, 1224872){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State73_Dot_Sensor_Fault_Alarm, client, 16448, 1224873){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State74, client, 16448, 1224874)
					{
						 Name = "Item_75",
						Sensor_Act = new BeckhoffBool(this.GetSR_State74_Dot_Sensor_Act, client, 16448, 1224874){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State74_Dot_Sensor_Fault_Alarm, client, 16448, 1224875){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State75, client, 16448, 1224876)
					{
						 Name = "Item_76",
						Sensor_Act = new BeckhoffBool(this.GetSR_State75_Dot_Sensor_Act, client, 16448, 1224876){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State75_Dot_Sensor_Fault_Alarm, client, 16448, 1224877){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State76, client, 16448, 1224878)
					{
						 Name = "Item_77",
						Sensor_Act = new BeckhoffBool(this.GetSR_State76_Dot_Sensor_Act, client, 16448, 1224878){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State76_Dot_Sensor_Fault_Alarm, client, 16448, 1224879){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State77, client, 16448, 1224880)
					{
						 Name = "Item_78",
						Sensor_Act = new BeckhoffBool(this.GetSR_State77_Dot_Sensor_Act, client, 16448, 1224880){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State77_Dot_Sensor_Fault_Alarm, client, 16448, 1224881){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State78, client, 16448, 1224882)
					{
						 Name = "Item_79",
						Sensor_Act = new BeckhoffBool(this.GetSR_State78_Dot_Sensor_Act, client, 16448, 1224882){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State78_Dot_Sensor_Fault_Alarm, client, 16448, 1224883){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State79, client, 16448, 1224884)
					{
						 Name = "Item_80",
						Sensor_Act = new BeckhoffBool(this.GetSR_State79_Dot_Sensor_Act, client, 16448, 1224884){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State79_Dot_Sensor_Fault_Alarm, client, 16448, 1224885){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State80, client, 16448, 1224886)
					{
						 Name = "Item_81",
						Sensor_Act = new BeckhoffBool(this.GetSR_State80_Dot_Sensor_Act, client, 16448, 1224886){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State80_Dot_Sensor_Fault_Alarm, client, 16448, 1224887){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State81, client, 16448, 1224888)
					{
						 Name = "Item_82",
						Sensor_Act = new BeckhoffBool(this.GetSR_State81_Dot_Sensor_Act, client, 16448, 1224888){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State81_Dot_Sensor_Fault_Alarm, client, 16448, 1224889){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State82, client, 16448, 1224890)
					{
						 Name = "Item_83",
						Sensor_Act = new BeckhoffBool(this.GetSR_State82_Dot_Sensor_Act, client, 16448, 1224890){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State82_Dot_Sensor_Fault_Alarm, client, 16448, 1224891){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State83, client, 16448, 1224892)
					{
						 Name = "Item_84",
						Sensor_Act = new BeckhoffBool(this.GetSR_State83_Dot_Sensor_Act, client, 16448, 1224892){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State83_Dot_Sensor_Fault_Alarm, client, 16448, 1224893){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State84, client, 16448, 1224894)
					{
						 Name = "Item_85",
						Sensor_Act = new BeckhoffBool(this.GetSR_State84_Dot_Sensor_Act, client, 16448, 1224894){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State84_Dot_Sensor_Fault_Alarm, client, 16448, 1224895){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State85, client, 16448, 1224896)
					{
						 Name = "Item_86",
						Sensor_Act = new BeckhoffBool(this.GetSR_State85_Dot_Sensor_Act, client, 16448, 1224896){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State85_Dot_Sensor_Fault_Alarm, client, 16448, 1224897){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State86, client, 16448, 1224898)
					{
						 Name = "Item_87",
						Sensor_Act = new BeckhoffBool(this.GetSR_State86_Dot_Sensor_Act, client, 16448, 1224898){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State86_Dot_Sensor_Fault_Alarm, client, 16448, 1224899){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State87, client, 16448, 1224900)
					{
						 Name = "Item_88",
						Sensor_Act = new BeckhoffBool(this.GetSR_State87_Dot_Sensor_Act, client, 16448, 1224900){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State87_Dot_Sensor_Fault_Alarm, client, 16448, 1224901){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State88, client, 16448, 1224902)
					{
						 Name = "Item_89",
						Sensor_Act = new BeckhoffBool(this.GetSR_State88_Dot_Sensor_Act, client, 16448, 1224902){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State88_Dot_Sensor_Fault_Alarm, client, 16448, 1224903){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State89, client, 16448, 1224904)
					{
						 Name = "Item_90",
						Sensor_Act = new BeckhoffBool(this.GetSR_State89_Dot_Sensor_Act, client, 16448, 1224904){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State89_Dot_Sensor_Fault_Alarm, client, 16448, 1224905){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State90, client, 16448, 1224906)
					{
						 Name = "Item_91",
						Sensor_Act = new BeckhoffBool(this.GetSR_State90_Dot_Sensor_Act, client, 16448, 1224906){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State90_Dot_Sensor_Fault_Alarm, client, 16448, 1224907){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State91, client, 16448, 1224908)
					{
						 Name = "Item_92",
						Sensor_Act = new BeckhoffBool(this.GetSR_State91_Dot_Sensor_Act, client, 16448, 1224908){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State91_Dot_Sensor_Fault_Alarm, client, 16448, 1224909){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State92, client, 16448, 1224910)
					{
						 Name = "Item_93",
						Sensor_Act = new BeckhoffBool(this.GetSR_State92_Dot_Sensor_Act, client, 16448, 1224910){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State92_Dot_Sensor_Fault_Alarm, client, 16448, 1224911){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State93, client, 16448, 1224912)
					{
						 Name = "Item_94",
						Sensor_Act = new BeckhoffBool(this.GetSR_State93_Dot_Sensor_Act, client, 16448, 1224912){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State93_Dot_Sensor_Fault_Alarm, client, 16448, 1224913){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State94, client, 16448, 1224914)
					{
						 Name = "Item_95",
						Sensor_Act = new BeckhoffBool(this.GetSR_State94_Dot_Sensor_Act, client, 16448, 1224914){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State94_Dot_Sensor_Fault_Alarm, client, 16448, 1224915){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State95, client, 16448, 1224916)
					{
						 Name = "Item_96",
						Sensor_Act = new BeckhoffBool(this.GetSR_State95_Dot_Sensor_Act, client, 16448, 1224916){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State95_Dot_Sensor_Fault_Alarm, client, 16448, 1224917){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State96, client, 16448, 1224918)
					{
						 Name = "Item_97",
						Sensor_Act = new BeckhoffBool(this.GetSR_State96_Dot_Sensor_Act, client, 16448, 1224918){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State96_Dot_Sensor_Fault_Alarm, client, 16448, 1224919){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State97, client, 16448, 1224920)
					{
						 Name = "Item_98",
						Sensor_Act = new BeckhoffBool(this.GetSR_State97_Dot_Sensor_Act, client, 16448, 1224920){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State97_Dot_Sensor_Fault_Alarm, client, 16448, 1224921){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State98, client, 16448, 1224922)
					{
						 Name = "Item_99",
						Sensor_Act = new BeckhoffBool(this.GetSR_State98_Dot_Sensor_Act, client, 16448, 1224922){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State98_Dot_Sensor_Fault_Alarm, client, 16448, 1224923){ Name = "Sensor_Fault_Alarm" },
					},
					new DUT_SR_STATEWrapper(this.GetSR_State99, client, 16448, 1224924)
					{
						 Name = "Item_100",
						Sensor_Act = new BeckhoffBool(this.GetSR_State99_Dot_Sensor_Act, client, 16448, 1224924){ Name = "Sensor_Act" },
						Sensor_Fault_Alarm = new BeckhoffBool(this.GetSR_State99_Dot_Sensor_Fault_Alarm, client, 16448, 1224925){ Name = "Sensor_Fault_Alarm" },
					},
			}, false){ Name = "SR_State" };
			G_M_MainPower_Signal_Index = new BeckhoffShort(this.GetG_M_MainPower_Signal_Index, client, 16448, 1224926){ Name = "G_M_MainPower_Signal_Index" };
			IMH_Z_Axis_Input = new BeckhoffUInt(this.GetIMH_Z_Axis_Input, client, 16448, 1224928){ Name = "IMH_Z_Axis_Input" };
			IMH_Y_Axis_Input = new BeckhoffUInt(this.GetIMH_Y_Axis_Input, client, 16448, 1224932){ Name = "IMH_Y_Axis_Input" };
			OMH_Z_Axis_Input = new BeckhoffUInt(this.GetOMH_Z_Axis_Input, client, 16448, 1224936){ Name = "OMH_Z_Axis_Input" };
			OMH_Y_Axis_Input = new BeckhoffUInt(this.GetOMH_Y_Axis_Input, client, 16448, 1224940){ Name = "OMH_Y_Axis_Input" };
			G_M_Safety_Door_1_Index = new BeckhoffShort(this.GetG_M_Safety_Door_1_Index, client, 16448, 1224944){ Name = "G_M_Safety_Door_1_Index" };
			G_M_Safety_Door_2_Index = new BeckhoffShort(this.GetG_M_Safety_Door_2_Index, client, 16448, 1224946){ Name = "G_M_Safety_Door_2_Index" };
			G_M_Safety_Door_3_Index = new BeckhoffShort(this.GetG_M_Safety_Door_3_Index, client, 16448, 1224948){ Name = "G_M_Safety_Door_3_Index" };
			I_IMH_ZM_PL_Index = new BeckhoffShort(this.GetI_IMH_ZM_PL_Index, client, 16448, 1224950){ Name = "I_IMH_ZM_PL_Index" };
			I_IMH_ZM_OL_Index = new BeckhoffShort(this.GetI_IMH_ZM_OL_Index, client, 16448, 1224952){ Name = "I_IMH_ZM_OL_Index" };
			I_IMH_ZM_NL_Index = new BeckhoffShort(this.GetI_IMH_ZM_NL_Index, client, 16448, 1224954){ Name = "I_IMH_ZM_NL_Index" };
			I_IMH_YM_PL_Index = new BeckhoffShort(this.GetI_IMH_YM_PL_Index, client, 16448, 1224956){ Name = "I_IMH_YM_PL_Index" };
			I_IMH_YM_OL_Index = new BeckhoffShort(this.GetI_IMH_YM_OL_Index, client, 16448, 1224958){ Name = "I_IMH_YM_OL_Index" };
			I_IMH_YM_NL_Index = new BeckhoffShort(this.GetI_IMH_YM_NL_Index, client, 16448, 1224960){ Name = "I_IMH_YM_NL_Index" };
			I_IMH_LDF_PL_Index = new BeckhoffShort(this.GetI_IMH_LDF_PL_Index, client, 16448, 1224962){ Name = "I_IMH_LDF_PL_Index" };
			I_IMH_LDF_NL_Index = new BeckhoffShort(this.GetI_IMH_LDF_NL_Index, client, 16448, 1224964){ Name = "I_IMH_LDF_NL_Index" };
			I_IMH_ZC_PL_Index = new BeckhoffShort(this.GetI_IMH_ZC_PL_Index, client, 16448, 1224966){ Name = "I_IMH_ZC_PL_Index" };
			I_IMH_SPC_PL_Index = new BeckhoffShort(this.GetI_IMH_SPC_PL_Index, client, 16448, 1224968){ Name = "I_IMH_SPC_PL_Index" };
			I_IMH_SPC_NL_Index = new BeckhoffShort(this.GetI_IMH_SPC_NL_Index, client, 16448, 1224970){ Name = "I_IMH_SPC_NL_Index" };
			I_IMH_SAC_SR_Index = new BeckhoffShort(this.GetI_IMH_SAC_SR_Index, client, 16448, 1224972){ Name = "I_IMH_SAC_SR_Index" };
			I_IMH_SDD_SR_Index = new BeckhoffShort(this.GetI_IMH_SDD_SR_Index, client, 16448, 1224974){ Name = "I_IMH_SDD_SR_Index" };
			I_IMH_MPD_SR_Index = new BeckhoffShort(this.GetI_IMH_MPD_SR_Index, client, 16448, 1224976){ Name = "I_IMH_MPD_SR_Index" };
			I_IMH_MFD_SR_Index = new BeckhoffShort(this.GetI_IMH_MFD_SR_Index, client, 16448, 1224978){ Name = "I_IMH_MFD_SR_Index" };
			Q_IMH_LDF_SV_Index = new BeckhoffShort(this.GetQ_IMH_LDF_SV_Index, client, 16448, 1224980){ Name = "Q_IMH_LDF_SV_Index" };
			Q_IMH_ZC_SV_Index = new BeckhoffShort(this.GetQ_IMH_ZC_SV_Index, client, 16448, 1224982){ Name = "Q_IMH_ZC_SV_Index" };
			Q_IMH_YC_SV_Index = new BeckhoffShort(this.GetQ_IMH_YC_SV_Index, client, 16448, 1224984){ Name = "Q_IMH_YC_SV_Index" };
			Q_IMH_SPC_SV_Index = new BeckhoffShort(this.GetQ_IMH_SPC_SV_Index, client, 16448, 1224986){ Name = "Q_IMH_SPC_SV_Index" };
			I_OMH_ZM_PL_Index = new BeckhoffShort(this.GetI_OMH_ZM_PL_Index, client, 16448, 1224988){ Name = "I_OMH_ZM_PL_Index" };
			I_OMH_ZM_OL_Index = new BeckhoffShort(this.GetI_OMH_ZM_OL_Index, client, 16448, 1224990){ Name = "I_OMH_ZM_OL_Index" };
			I_OMH_ZM_NL_Index = new BeckhoffShort(this.GetI_OMH_ZM_NL_Index, client, 16448, 1224992){ Name = "I_OMH_ZM_NL_Index" };
			I_OMH_YM_PL_Index = new BeckhoffShort(this.GetI_OMH_YM_PL_Index, client, 16448, 1224994){ Name = "I_OMH_YM_PL_Index" };
			I_OMH_YM_OL_Index = new BeckhoffShort(this.GetI_OMH_YM_OL_Index, client, 16448, 1224996){ Name = "I_OMH_YM_OL_Index" };
			I_OMH_YM_NL_Index = new BeckhoffShort(this.GetI_OMH_YM_NL_Index, client, 16448, 1224998){ Name = "I_OMH_YM_NL_Index" };
			I_OMH_LDF_PL_Index = new BeckhoffShort(this.GetI_OMH_LDF_PL_Index, client, 16448, 1225000){ Name = "I_OMH_LDF_PL_Index" };
			I_OMH_LDF_NL_Index = new BeckhoffShort(this.GetI_OMH_LDF_NL_Index, client, 16448, 1225002){ Name = "I_OMH_LDF_NL_Index" };
			I_OMH_ZC_PL_Index = new BeckhoffShort(this.GetI_OMH_ZC_PL_Index, client, 16448, 1225004){ Name = "I_OMH_ZC_PL_Index" };
			I_OMH_SDD_SR_Index = new BeckhoffShort(this.GetI_OMH_SDD_SR_Index, client, 16448, 1225006){ Name = "I_OMH_SDD_SR_Index" };
			I_OMH_MPD_SR_Index = new BeckhoffShort(this.GetI_OMH_MPD_SR_Index, client, 16448, 1225008){ Name = "I_OMH_MPD_SR_Index" };
			I_OMH_MFD_SR_Index = new BeckhoffShort(this.GetI_OMH_MFD_SR_Index, client, 16448, 1225010){ Name = "I_OMH_MFD_SR_Index" };
			Q_OMH_LDF_SV_Index = new BeckhoffShort(this.GetQ_OMH_LDF_SV_Index, client, 16448, 1225012){ Name = "Q_OMH_LDF_SV_Index" };
			Q_OMH_ZC_SV_Index = new BeckhoffShort(this.GetQ_OMH_ZC_SV_Index, client, 16448, 1225014){ Name = "Q_OMH_ZC_SV_Index" };
			Q_OMH_ZC_SV2_Index = new BeckhoffShort(this.GetQ_OMH_ZC_SV2_Index, client, 16448, 1225016){ Name = "Q_OMH_ZC_SV2_Index" };
			Q_OMH_YC_SV_Index = new BeckhoffShort(this.GetQ_OMH_YC_SV_Index, client, 16448, 1225018){ Name = "Q_OMH_YC_SV_Index" };
			I_FIG_SFP_SR_Index = new BeckhoffShort(this.GetI_FIG_SFP_SR_Index, client, 16448, 1225020){ Name = "I_FIG_SFP_SR_Index" };
			I_FIG_SPD_SR_Index = new BeckhoffShort(this.GetI_FIG_SPD_SR_Index, client, 16448, 1225022){ Name = "I_FIG_SPD_SR_Index" };
			I_FIG_RVS_SR_Index = new BeckhoffShort(this.GetI_FIG_RVS_SR_Index, client, 16448, 1225024){ Name = "I_FIG_RVS_SR_Index" };
			I_FIG_IFS_SR_Index = new BeckhoffShort(this.GetI_FIG_IFS_SR_Index, client, 16448, 1225026){ Name = "I_FIG_IFS_SR_Index" };
			I_FIG_IFO_SR_Index = new BeckhoffShort(this.GetI_FIG_IFO_SR_Index, client, 16448, 1225028){ Name = "I_FIG_IFO_SR_Index" };
			I_FIG_CM_OL_Index = new BeckhoffShort(this.GetI_FIG_CM_OL_Index, client, 16448, 1225030){ Name = "I_FIG_CM_OL_Index" };
			I_FIG_XM_PL_Index = new BeckhoffShort(this.GetI_FIG_XM_PL_Index, client, 16448, 1225032){ Name = "I_FIG_XM_PL_Index" };
			I_FIG_XM_OL_Index = new BeckhoffShort(this.GetI_FIG_XM_OL_Index, client, 16448, 1225034){ Name = "I_FIG_XM_OL_Index" };
			I_FIG_XM_NL_Index = new BeckhoffShort(this.GetI_FIG_XM_NL_Index, client, 16448, 1225036){ Name = "I_FIG_XM_NL_Index" };
			Q_FIG_IFS_SV_Index = new BeckhoffShort(this.GetQ_FIG_IFS_SV_Index, client, 16448, 1225038){ Name = "Q_FIG_IFS_SV_Index" };
			I_FCU_SIP_SR_Index = new BeckhoffShort(this.GetI_FCU_SIP_SR_Index, client, 16448, 1225040){ Name = "I_FCU_SIP_SR_Index" };
			I_FCU_TRC_SR1_Index = new BeckhoffShort(this.GetI_FCU_TRC_SR1_Index, client, 16448, 1225042){ Name = "I_FCU_TRC_SR1_Index" };
			I_FCU_TRC_SR2_Index = new BeckhoffShort(this.GetI_FCU_TRC_SR2_Index, client, 16448, 1225044){ Name = "I_FCU_TRC_SR2_Index" };
			I_FCU_PRA_SR_Index = new BeckhoffShort(this.GetI_FCU_PRA_SR_Index, client, 16448, 1225046){ Name = "I_FCU_PRA_SR_Index" };
			I_FCU_NRA_SR_Index = new BeckhoffShort(this.GetI_FCU_NRA_SR_Index, client, 16448, 1225048){ Name = "I_FCU_NRA_SR_Index" };
			I_FCU_XM_PL_Index = new BeckhoffShort(this.GetI_FCU_XM_PL_Index, client, 16448, 1225050){ Name = "I_FCU_XM_PL_Index" };
			I_FCU_XM_OL_Index = new BeckhoffShort(this.GetI_FCU_XM_OL_Index, client, 16448, 1225052){ Name = "I_FCU_XM_OL_Index" };
			I_FCU_XM_NL_Index = new BeckhoffShort(this.GetI_FCU_XM_NL_Index, client, 16448, 1225054){ Name = "I_FCU_XM_NL_Index" };
			I_FCU_CM_OL_Index = new BeckhoffShort(this.GetI_FCU_CM_OL_Index, client, 16448, 1225056){ Name = "I_FCU_CM_OL_Index" };
			I_FCU_PCM_OL_Index = new BeckhoffShort(this.GetI_FCU_PCM_OL_Index, client, 16448, 1225058){ Name = "I_FCU_PCM_OL_Index" };
			I_FCU_SZM_PL_Index = new BeckhoffShort(this.GetI_FCU_SZM_PL_Index, client, 16448, 1225060){ Name = "I_FCU_SZM_PL_Index" };
			I_FCU_SZM_OL_Index = new BeckhoffShort(this.GetI_FCU_SZM_OL_Index, client, 16448, 1225062){ Name = "I_FCU_SZM_OL_Index" };
			I_FCU_SZM_NL_Index = new BeckhoffShort(this.GetI_FCU_SZM_NL_Index, client, 16448, 1225064){ Name = "I_FCU_SZM_NL_Index" };
			AI_FCU_PHT_SAI_Index = new BeckhoffShort(this.GetAI_FCU_PHT_SAI_Index, client, 16448, 1225066){ Name = "AI_FCU_PHT_SAI_Index" };
			AI_FCU_HCM_SAI_Index = new BeckhoffShort(this.GetAI_FCU_HCM_SAI_Index, client, 16448, 1225068){ Name = "AI_FCU_HCM_SAI_Index" };
			AI_FCU_RDV_SAI_Index = new BeckhoffShort(this.GetAI_FCU_RDV_SAI_Index, client, 16448, 1225070){ Name = "AI_FCU_RDV_SAI_Index" };
			Q_FCU_RDV_SV_Index = new BeckhoffShort(this.GetQ_FCU_RDV_SV_Index, client, 16448, 1225072){ Name = "Q_FCU_RDV_SV_Index" };
			Q_FCU_RBV_SV_Index = new BeckhoffShort(this.GetQ_FCU_RBV_SV_Index, client, 16448, 1225074){ Name = "Q_FCU_RBV_SV_Index" };
			Q_FCU_IFS_SV_Index = new BeckhoffShort(this.GetQ_FCU_IFS_SV_Index, client, 16448, 1225076){ Name = "Q_FCU_IFS_SV_Index" };
			Q_FCU_IFO_SV_Index = new BeckhoffShort(this.GetQ_FCU_IFO_SV_Index, client, 16448, 1225078){ Name = "Q_FCU_IFO_SV_Index" };
			Q_FCU_SGV_SV_Index = new BeckhoffShort(this.GetQ_FCU_SGV_SV_Index, client, 16448, 1225080){ Name = "Q_FCU_SGV_SV_Index" };
			Q_FCU_SBV_SV_Index = new BeckhoffShort(this.GetQ_FCU_SBV_SV_Index, client, 16448, 1225082){ Name = "Q_FCU_SBV_SV_Index" };
			I_FBU_UTC_SR1_Index = new BeckhoffShort(this.GetI_FBU_UTC_SR1_Index, client, 16448, 1225084){ Name = "I_FBU_UTC_SR1_Index" };
			I_FBU_UTC_SR2_Index = new BeckhoffShort(this.GetI_FBU_UTC_SR2_Index, client, 16448, 1225086){ Name = "I_FBU_UTC_SR2_Index" };
			I_FBU_BCM_OL_Index = new BeckhoffShort(this.GetI_FBU_BCM_OL_Index, client, 16448, 1225088){ Name = "I_FBU_BCM_OL_Index" };
			I_FBU_BZ1M_PL_Index = new BeckhoffShort(this.GetI_FBU_BZ1M_PL_Index, client, 16448, 1225090){ Name = "I_FBU_BZ1M_PL_Index" };
			I_FBU_BZ1M_OL_Index = new BeckhoffShort(this.GetI_FBU_BZ1M_OL_Index, client, 16448, 1225092){ Name = "I_FBU_BZ1M_OL_Index" };
			I_FBU_BZ1M_NL_Index = new BeckhoffShort(this.GetI_FBU_BZ1M_NL_Index, client, 16448, 1225094){ Name = "I_FBU_BZ1M_NL_Index" };
			I_FBU_BZ2M_PL_Index = new BeckhoffShort(this.GetI_FBU_BZ2M_PL_Index, client, 16448, 1225096){ Name = "I_FBU_BZ2M_PL_Index" };
			I_FBU_BZ2M_OL_Index = new BeckhoffShort(this.GetI_FBU_BZ2M_OL_Index, client, 16448, 1225098){ Name = "I_FBU_BZ2M_OL_Index" };
			I_FBU_BZ2M_NL_Index = new BeckhoffShort(this.GetI_FBU_BZ2M_NL_Index, client, 16448, 1225100){ Name = "I_FBU_BZ2M_NL_Index" };
			AI_FBU_HTR_AI_Index = new BeckhoffShort(this.GetAI_FBU_HTR_AI_Index, client, 16448, 1225102){ Name = "AI_FBU_HTR_AI_Index" };
			AI_FBU_NRA_AI1_Index = new BeckhoffShort(this.GetAI_FBU_NRA_AI1_Index, client, 16448, 1225104){ Name = "AI_FBU_NRA_AI1_Index" };
			AI_FBU_NRA_AI2_Index = new BeckhoffShort(this.GetAI_FBU_NRA_AI2_Index, client, 16448, 1225106){ Name = "AI_FBU_NRA_AI2_Index" };
			AI_FBU_NRA_AI3_Index = new BeckhoffShort(this.GetAI_FBU_NRA_AI3_Index, client, 16448, 1225108){ Name = "AI_FBU_NRA_AI3_Index" };
			Q_FBU_SFG_SV1_Index = new BeckhoffShort(this.GetQ_FBU_SFG_SV1_Index, client, 16448, 1225110){ Name = "Q_FBU_SFG_SV1_Index" };
			Q_FBU_SFB_SV1_Index = new BeckhoffShort(this.GetQ_FBU_SFB_SV1_Index, client, 16448, 1225112){ Name = "Q_FBU_SFB_SV1_Index" };
			Q_FBU_SFG_SV2_Index = new BeckhoffShort(this.GetQ_FBU_SFG_SV2_Index, client, 16448, 1225114){ Name = "Q_FBU_SFG_SV2_Index" };
			Q_FBU_SFB_SV2_Index = new BeckhoffShort(this.GetQ_FBU_SFB_SV2_Index, client, 16448, 1225116){ Name = "Q_FBU_SFB_SV2_Index" };
			Q_FBU_SFG_SV3_Index = new BeckhoffShort(this.GetQ_FBU_SFG_SV3_Index, client, 16448, 1225118){ Name = "Q_FBU_SFG_SV3_Index" };
			Q_FBU_SFB_SV3_Index = new BeckhoffShort(this.GetQ_FBU_SFB_SV3_Index, client, 16448, 1225120){ Name = "Q_FBU_SFB_SV3_Index" };
			I_FOG_USS_PL_Index = new BeckhoffShort(this.GetI_FOG_USS_PL_Index, client, 16448, 1225122){ Name = "I_FOG_USS_PL_Index" };
			Q_FOG_USS_SV_Index = new BeckhoffShort(this.GetQ_FOG_USS_SV_Index, client, 16448, 1225124){ Name = "Q_FOG_USS_SV_Index" };
			I_WLU_FRI_SR_Index = new BeckhoffShort(this.GetI_WLU_FRI_SR_Index, client, 16448, 1225126){ Name = "I_WLU_FRI_SR_Index" };
			I_WLU_RRI_SR_Index = new BeckhoffShort(this.GetI_WLU_RRI_SR_Index, client, 16448, 1225128){ Name = "I_WLU_RRI_SR_Index" };
			I_WLU_FRO_SR_Index = new BeckhoffShort(this.GetI_WLU_FRO_SR_Index, client, 16448, 1225130){ Name = "I_WLU_FRO_SR_Index" };
			I_WLU_RRO_SR_Index = new BeckhoffShort(this.GetI_WLU_RRO_SR_Index, client, 16448, 1225132){ Name = "I_WLU_RRO_SR_Index" };
			I_WLU_WPD_SR_Index = new BeckhoffShort(this.GetI_WLU_WPD_SR_Index, client, 16448, 1225134){ Name = "I_WLU_WPD_SR_Index" };
			I_WLU_WRS_SR_Index = new BeckhoffShort(this.GetI_WLU_WRS_SR_Index, client, 16448, 1225136){ Name = "I_WLU_WRS_SR_Index" };
			I_WLU_WJS_SR_Index = new BeckhoffShort(this.GetI_WLU_WJS_SR_Index, client, 16448, 1225138){ Name = "I_WLU_WJS_SR_Index" };
			I_WLU_WTS_SR_Index = new BeckhoffShort(this.GetI_WLU_WTS_SR_Index, client, 16448, 1225140){ Name = "I_WLU_WTS_SR_Index" };
			I_WLU_CAP_SR1_Index = new BeckhoffShort(this.GetI_WLU_CAP_SR1_Index, client, 16448, 1225142){ Name = "I_WLU_CAP_SR1_Index" };
			I_WLU_CAP_SR2_Index = new BeckhoffShort(this.GetI_WLU_CAP_SR2_Index, client, 16448, 1225144){ Name = "I_WLU_CAP_SR2_Index" };
			I_WLU_ZM_PL_Index = new BeckhoffShort(this.GetI_WLU_ZM_PL_Index, client, 16448, 1225146){ Name = "I_WLU_ZM_PL_Index" };
			I_WLU_ZM_WL_Index = new BeckhoffShort(this.GetI_WLU_ZM_WL_Index, client, 16448, 1225148){ Name = "I_WLU_ZM_WL_Index" };
			I_WLU_ZM_OL_Index = new BeckhoffShort(this.GetI_WLU_ZM_OL_Index, client, 16448, 1225150){ Name = "I_WLU_ZM_OL_Index" };
			I_WLU_ZM_NL_Index = new BeckhoffShort(this.GetI_WLU_ZM_NL_Index, client, 16448, 1225152){ Name = "I_WLU_ZM_NL_Index" };
			I_WLU_XM_PL_Index = new BeckhoffShort(this.GetI_WLU_XM_PL_Index, client, 16448, 1225154){ Name = "I_WLU_XM_PL_Index" };
			I_WLU_XM_OL_Index = new BeckhoffShort(this.GetI_WLU_XM_OL_Index, client, 16448, 1225156){ Name = "I_WLU_XM_OL_Index" };
			I_WLU_XM_NL_Index = new BeckhoffShort(this.GetI_WLU_XM_NL_Index, client, 16448, 1225158){ Name = "I_WLU_XM_NL_Index" };
			Q_WLU_CC_SV_Index = new BeckhoffShort(this.GetQ_WLU_CC_SV_Index, client, 16448, 1225160){ Name = "Q_WLU_CC_SV_Index" };
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
		~GVL_IO_IndexWrapper()
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
