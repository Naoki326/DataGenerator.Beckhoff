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
	/// Name from PLC:GVL_Sensor_Used
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_Sensor_UsedWrapper : BaseData, IBaseData
	{
		public override IEnumerable<IBaseData> Children
		{
			get
			{
				yield return G_I_IMH_ZM_PL;
				yield return G_I_IMH_ZM_OL;
				yield return G_I_IMH_ZM_NL;
				yield return G_I_IMH_YM_PL;
				yield return G_I_IMH_YM_OL;
				yield return G_I_IMH_YM_NL;
				yield return G_I_IMH_LDF_PL;
				yield return G_I_IMH_LDF_NL;
				yield return G_I_IMH_ZC_PL;
				yield return G_I_IMH_ZC_NL;
				yield return G_I_IMH_YC_PL;
				yield return G_I_IMH_YC_NL;
				yield return G_I_IMH_SPC_PL;
				yield return G_I_IMH_SPC_NL;
				yield return G_I_IMH_SAC_SR;
				yield return G_I_IMH_SDD_SR;
				yield return G_I_IMH_MPD_SR;
				yield return G_I_IMH_MFD_SR;
				yield return G_I_OMH_ZM_PL;
				yield return G_I_OMH_ZM_OL;
				yield return G_I_OMH_ZM_NL;
				yield return G_I_OMH_YM_PL;
				yield return G_I_OMH_YM_OL;
				yield return G_I_OMH_YM_NL;
				yield return G_I_OMH_LDF_PL;
				yield return G_I_OMH_LDF_NL;
				yield return G_I_OMH_ZC_PL;
				yield return G_I_OMH_ZC_NL;
				yield return G_I_OMH_YC_PL;
				yield return G_I_OMH_YC_NL;
				yield return G_I_OMH_SDD_SR;
				yield return G_I_OMH_MPD_SR;
				yield return G_I_OMH_MFD_SR;
				yield return G_I_FIG_SFP_SR;
				yield return G_I_FIG_SPD_SR;
				yield return G_I_FIG_RVS_SR;
				yield return G_I_FIG_IFO_SR;
				yield return G_I_FIG_CM_OL;
				yield return G_I_FIG_XM_PL;
				yield return G_I_FIG_XM_OL;
				yield return G_I_FIG_XM_NL;
				yield return G_I_FCU_SIP_SR;
				yield return G_I_FCU_TRC_SR1;
				yield return G_I_FCU_TRC_SR2;
				yield return G_I_FCU_PRA_SR;
				yield return G_I_FCU_NRA_SR;
				yield return G_I_FCU_LXM_PL;
				yield return G_I_FCU_LXM_OL;
				yield return G_I_FCU_LXM_NL;
				yield return G_I_FCU_CM_OL;
				yield return G_I_FCU_CDA_YM_OL;
				yield return G_I_FCU_CDA_ZM_PL;
				yield return G_I_FCU_CDA_ZM_NL;
				yield return G_I_FCU_PCM_OL;
				yield return G_I_FCU_SZM_PL;
				yield return G_I_FCU_SZM_OL;
				yield return G_I_FCU_SZM_NL;
				yield return G_I_FBU_UTC_SR1;
				yield return G_I_FBU_UTC_SR2;
				yield return G_AI_FCU_PHT;
				yield return G_AI_FCU_HCM;
				yield return G_AI_FCU_RDV;
				yield return G_I_FBU_BCM_OL;
				yield return G_I_FBU_BZ1M_PL;
				yield return G_I_FBU_BZ1M_OL;
				yield return G_I_FBU_BZ1M_NL;
				yield return G_I_FBU_BZ2M_PL;
				yield return G_I_FBU_BZ2M_OL;
				yield return G_I_FBU_BZ2M_NL;
				yield return G_I_FBU_LXM_PL;
				yield return G_I_FBU_LXM_OL;
				yield return G_I_FBU_LXM_NL;
				yield return G_I_FBU_CM_OL;
				yield return G_I_FBU_V_XM_PL;
				yield return G_I_FBU_V_XM_OL;
				yield return G_I_FBU_V_XM_NL;
				yield return G_I_FBU_V_YM_PL;
				yield return G_I_FBU_V_YM_OL;
				yield return G_I_FBU_V_YM_NL;
				yield return G_I_FBU_AZM_PL;
				yield return G_I_FBU_AZM_OL;
				yield return G_I_FBU_AZM_NL;
				yield return G_I_FBU_TWM_OL;
				yield return G_I_FOG_USS_PL;
				yield return G_I_FOG_LXM_PL;
				yield return G_I_FOG_LXM_OL;
				yield return G_AI_FBU_HTR;
				yield return G_AI1_FBU_NPA;
				yield return G_AI2_FBU_NPA;
				yield return G_AI3_FBU_NPA;
				yield return G_I_FOG_LXM_NL;
				yield return G_I_FOG_ZM_OL;
				yield return G_I_WLU_FRI_SR;
				yield return G_I_WLU_RRI_SR;
				yield return G_I_WLU_FRO_SR;
				yield return G_I_WLU_RRO_SR;
				yield return G_I_WLU_WTS_SR;
				yield return G_I_WLU_WRS_SR;
				yield return G_I_WLU_WPD_SR;
				yield return G_I_WLU_WJS_SR;
				yield return G_I_WLU_CAP_SR1;
				yield return G_I_WLU_CAP_SR2;
				yield return G_I_WLU_ZM_PL;
				yield return G_I_WLU_ZM_WL;
				yield return G_I_WLU_ZM_OL;
				yield return G_I_WLU_ZM_NL;
				yield return G_I_WLU_XM_PL;
				yield return G_I_WLU_XM_OL;
				yield return G_I_WLU_XM_NL;
			}
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(G_I_IMH_ZM_PL):
					return G_I_IMH_ZM_PL;
				case nameof(G_I_IMH_ZM_OL):
					return G_I_IMH_ZM_OL;
				case nameof(G_I_IMH_ZM_NL):
					return G_I_IMH_ZM_NL;
				case nameof(G_I_IMH_YM_PL):
					return G_I_IMH_YM_PL;
				case nameof(G_I_IMH_YM_OL):
					return G_I_IMH_YM_OL;
				case nameof(G_I_IMH_YM_NL):
					return G_I_IMH_YM_NL;
				case nameof(G_I_IMH_LDF_PL):
					return G_I_IMH_LDF_PL;
				case nameof(G_I_IMH_LDF_NL):
					return G_I_IMH_LDF_NL;
				case nameof(G_I_IMH_ZC_PL):
					return G_I_IMH_ZC_PL;
				case nameof(G_I_IMH_ZC_NL):
					return G_I_IMH_ZC_NL;
				case nameof(G_I_IMH_YC_PL):
					return G_I_IMH_YC_PL;
				case nameof(G_I_IMH_YC_NL):
					return G_I_IMH_YC_NL;
				case nameof(G_I_IMH_SPC_PL):
					return G_I_IMH_SPC_PL;
				case nameof(G_I_IMH_SPC_NL):
					return G_I_IMH_SPC_NL;
				case nameof(G_I_IMH_SAC_SR):
					return G_I_IMH_SAC_SR;
				case nameof(G_I_IMH_SDD_SR):
					return G_I_IMH_SDD_SR;
				case nameof(G_I_IMH_MPD_SR):
					return G_I_IMH_MPD_SR;
				case nameof(G_I_IMH_MFD_SR):
					return G_I_IMH_MFD_SR;
				case nameof(G_I_OMH_ZM_PL):
					return G_I_OMH_ZM_PL;
				case nameof(G_I_OMH_ZM_OL):
					return G_I_OMH_ZM_OL;
				case nameof(G_I_OMH_ZM_NL):
					return G_I_OMH_ZM_NL;
				case nameof(G_I_OMH_YM_PL):
					return G_I_OMH_YM_PL;
				case nameof(G_I_OMH_YM_OL):
					return G_I_OMH_YM_OL;
				case nameof(G_I_OMH_YM_NL):
					return G_I_OMH_YM_NL;
				case nameof(G_I_OMH_LDF_PL):
					return G_I_OMH_LDF_PL;
				case nameof(G_I_OMH_LDF_NL):
					return G_I_OMH_LDF_NL;
				case nameof(G_I_OMH_ZC_PL):
					return G_I_OMH_ZC_PL;
				case nameof(G_I_OMH_ZC_NL):
					return G_I_OMH_ZC_NL;
				case nameof(G_I_OMH_YC_PL):
					return G_I_OMH_YC_PL;
				case nameof(G_I_OMH_YC_NL):
					return G_I_OMH_YC_NL;
				case nameof(G_I_OMH_SDD_SR):
					return G_I_OMH_SDD_SR;
				case nameof(G_I_OMH_MPD_SR):
					return G_I_OMH_MPD_SR;
				case nameof(G_I_OMH_MFD_SR):
					return G_I_OMH_MFD_SR;
				case nameof(G_I_FIG_SFP_SR):
					return G_I_FIG_SFP_SR;
				case nameof(G_I_FIG_SPD_SR):
					return G_I_FIG_SPD_SR;
				case nameof(G_I_FIG_RVS_SR):
					return G_I_FIG_RVS_SR;
				case nameof(G_I_FIG_IFO_SR):
					return G_I_FIG_IFO_SR;
				case nameof(G_I_FIG_CM_OL):
					return G_I_FIG_CM_OL;
				case nameof(G_I_FIG_XM_PL):
					return G_I_FIG_XM_PL;
				case nameof(G_I_FIG_XM_OL):
					return G_I_FIG_XM_OL;
				case nameof(G_I_FIG_XM_NL):
					return G_I_FIG_XM_NL;
				case nameof(G_I_FCU_SIP_SR):
					return G_I_FCU_SIP_SR;
				case nameof(G_I_FCU_TRC_SR1):
					return G_I_FCU_TRC_SR1;
				case nameof(G_I_FCU_TRC_SR2):
					return G_I_FCU_TRC_SR2;
				case nameof(G_I_FCU_PRA_SR):
					return G_I_FCU_PRA_SR;
				case nameof(G_I_FCU_NRA_SR):
					return G_I_FCU_NRA_SR;
				case nameof(G_I_FCU_LXM_PL):
					return G_I_FCU_LXM_PL;
				case nameof(G_I_FCU_LXM_OL):
					return G_I_FCU_LXM_OL;
				case nameof(G_I_FCU_LXM_NL):
					return G_I_FCU_LXM_NL;
				case nameof(G_I_FCU_CM_OL):
					return G_I_FCU_CM_OL;
				case nameof(G_I_FCU_CDA_YM_OL):
					return G_I_FCU_CDA_YM_OL;
				case nameof(G_I_FCU_CDA_ZM_PL):
					return G_I_FCU_CDA_ZM_PL;
				case nameof(G_I_FCU_CDA_ZM_NL):
					return G_I_FCU_CDA_ZM_NL;
				case nameof(G_I_FCU_PCM_OL):
					return G_I_FCU_PCM_OL;
				case nameof(G_I_FCU_SZM_PL):
					return G_I_FCU_SZM_PL;
				case nameof(G_I_FCU_SZM_OL):
					return G_I_FCU_SZM_OL;
				case nameof(G_I_FCU_SZM_NL):
					return G_I_FCU_SZM_NL;
				case nameof(G_I_FBU_UTC_SR1):
					return G_I_FBU_UTC_SR1;
				case nameof(G_I_FBU_UTC_SR2):
					return G_I_FBU_UTC_SR2;
				case nameof(G_AI_FCU_PHT):
					return G_AI_FCU_PHT;
				case nameof(G_AI_FCU_HCM):
					return G_AI_FCU_HCM;
				case nameof(G_AI_FCU_RDV):
					return G_AI_FCU_RDV;
				case nameof(G_I_FBU_BCM_OL):
					return G_I_FBU_BCM_OL;
				case nameof(G_I_FBU_BZ1M_PL):
					return G_I_FBU_BZ1M_PL;
				case nameof(G_I_FBU_BZ1M_OL):
					return G_I_FBU_BZ1M_OL;
				case nameof(G_I_FBU_BZ1M_NL):
					return G_I_FBU_BZ1M_NL;
				case nameof(G_I_FBU_BZ2M_PL):
					return G_I_FBU_BZ2M_PL;
				case nameof(G_I_FBU_BZ2M_OL):
					return G_I_FBU_BZ2M_OL;
				case nameof(G_I_FBU_BZ2M_NL):
					return G_I_FBU_BZ2M_NL;
				case nameof(G_I_FBU_LXM_PL):
					return G_I_FBU_LXM_PL;
				case nameof(G_I_FBU_LXM_OL):
					return G_I_FBU_LXM_OL;
				case nameof(G_I_FBU_LXM_NL):
					return G_I_FBU_LXM_NL;
				case nameof(G_I_FBU_CM_OL):
					return G_I_FBU_CM_OL;
				case nameof(G_I_FBU_V_XM_PL):
					return G_I_FBU_V_XM_PL;
				case nameof(G_I_FBU_V_XM_OL):
					return G_I_FBU_V_XM_OL;
				case nameof(G_I_FBU_V_XM_NL):
					return G_I_FBU_V_XM_NL;
				case nameof(G_I_FBU_V_YM_PL):
					return G_I_FBU_V_YM_PL;
				case nameof(G_I_FBU_V_YM_OL):
					return G_I_FBU_V_YM_OL;
				case nameof(G_I_FBU_V_YM_NL):
					return G_I_FBU_V_YM_NL;
				case nameof(G_I_FBU_AZM_PL):
					return G_I_FBU_AZM_PL;
				case nameof(G_I_FBU_AZM_OL):
					return G_I_FBU_AZM_OL;
				case nameof(G_I_FBU_AZM_NL):
					return G_I_FBU_AZM_NL;
				case nameof(G_I_FBU_TWM_OL):
					return G_I_FBU_TWM_OL;
				case nameof(G_I_FOG_USS_PL):
					return G_I_FOG_USS_PL;
				case nameof(G_I_FOG_LXM_PL):
					return G_I_FOG_LXM_PL;
				case nameof(G_I_FOG_LXM_OL):
					return G_I_FOG_LXM_OL;
				case nameof(G_AI_FBU_HTR):
					return G_AI_FBU_HTR;
				case nameof(G_AI1_FBU_NPA):
					return G_AI1_FBU_NPA;
				case nameof(G_AI2_FBU_NPA):
					return G_AI2_FBU_NPA;
				case nameof(G_AI3_FBU_NPA):
					return G_AI3_FBU_NPA;
				case nameof(G_I_FOG_LXM_NL):
					return G_I_FOG_LXM_NL;
				case nameof(G_I_FOG_ZM_OL):
					return G_I_FOG_ZM_OL;
				case nameof(G_I_WLU_FRI_SR):
					return G_I_WLU_FRI_SR;
				case nameof(G_I_WLU_RRI_SR):
					return G_I_WLU_RRI_SR;
				case nameof(G_I_WLU_FRO_SR):
					return G_I_WLU_FRO_SR;
				case nameof(G_I_WLU_RRO_SR):
					return G_I_WLU_RRO_SR;
				case nameof(G_I_WLU_WTS_SR):
					return G_I_WLU_WTS_SR;
				case nameof(G_I_WLU_WRS_SR):
					return G_I_WLU_WRS_SR;
				case nameof(G_I_WLU_WPD_SR):
					return G_I_WLU_WPD_SR;
				case nameof(G_I_WLU_WJS_SR):
					return G_I_WLU_WJS_SR;
				case nameof(G_I_WLU_CAP_SR1):
					return G_I_WLU_CAP_SR1;
				case nameof(G_I_WLU_CAP_SR2):
					return G_I_WLU_CAP_SR2;
				case nameof(G_I_WLU_ZM_PL):
					return G_I_WLU_ZM_PL;
				case nameof(G_I_WLU_ZM_WL):
					return G_I_WLU_ZM_WL;
				case nameof(G_I_WLU_ZM_OL):
					return G_I_WLU_ZM_OL;
				case nameof(G_I_WLU_ZM_NL):
					return G_I_WLU_ZM_NL;
				case nameof(G_I_WLU_XM_PL):
					return G_I_WLU_XM_PL;
				case nameof(G_I_WLU_XM_OL):
					return G_I_WLU_XM_OL;
				case nameof(G_I_WLU_XM_NL):
					return G_I_WLU_XM_NL;
			}
			throw new KeyNotFoundException(name);
		}

		private readonly AdsClient client;

		public GVL_Sensor_UsedWrapper(AdsClient client)
		{
			this.client = client;

			G_I_IMH_ZM_PL = new BeckhoffBool(this.GetG_I_IMH_ZM_PL, client, 16448, 2004271){ Name = "G_I_IMH_ZM_PL" };
			G_I_IMH_ZM_OL = new BeckhoffBool(this.GetG_I_IMH_ZM_OL, client, 16448, 2004278){ Name = "G_I_IMH_ZM_OL" };
			G_I_IMH_ZM_NL = new BeckhoffBool(this.GetG_I_IMH_ZM_NL, client, 16448, 2004279){ Name = "G_I_IMH_ZM_NL" };
			G_I_IMH_YM_PL = new BeckhoffBool(this.GetG_I_IMH_YM_PL, client, 16448, 2004280){ Name = "G_I_IMH_YM_PL" };
			G_I_IMH_YM_OL = new BeckhoffBool(this.GetG_I_IMH_YM_OL, client, 16448, 2004281){ Name = "G_I_IMH_YM_OL" };
			G_I_IMH_YM_NL = new BeckhoffBool(this.GetG_I_IMH_YM_NL, client, 16448, 2004282){ Name = "G_I_IMH_YM_NL" };
			G_I_IMH_LDF_PL = new BeckhoffBool(this.GetG_I_IMH_LDF_PL, client, 16448, 2004283){ Name = "G_I_IMH_LDF_PL" };
			G_I_IMH_LDF_NL = new BeckhoffBool(this.GetG_I_IMH_LDF_NL, client, 16448, 2004284){ Name = "G_I_IMH_LDF_NL" };
			G_I_IMH_ZC_PL = new BeckhoffBool(this.GetG_I_IMH_ZC_PL, client, 16448, 2004285){ Name = "G_I_IMH_ZC_PL" };
			G_I_IMH_ZC_NL = new BeckhoffBool(this.GetG_I_IMH_ZC_NL, client, 16448, 2004286){ Name = "G_I_IMH_ZC_NL" };
			G_I_IMH_YC_PL = new BeckhoffBool(this.GetG_I_IMH_YC_PL, client, 16448, 2004287){ Name = "G_I_IMH_YC_PL" };
			G_I_IMH_YC_NL = new BeckhoffBool(this.GetG_I_IMH_YC_NL, client, 16448, 2004288){ Name = "G_I_IMH_YC_NL" };
			G_I_IMH_SPC_PL = new BeckhoffBool(this.GetG_I_IMH_SPC_PL, client, 16448, 2004289){ Name = "G_I_IMH_SPC_PL" };
			G_I_IMH_SPC_NL = new BeckhoffBool(this.GetG_I_IMH_SPC_NL, client, 16448, 2004290){ Name = "G_I_IMH_SPC_NL" };
			G_I_IMH_SAC_SR = new BeckhoffBool(this.GetG_I_IMH_SAC_SR, client, 16448, 2004291){ Name = "G_I_IMH_SAC_SR" };
			G_I_IMH_SDD_SR = new BeckhoffBool(this.GetG_I_IMH_SDD_SR, client, 16448, 2004292){ Name = "G_I_IMH_SDD_SR" };
			G_I_IMH_MPD_SR = new BeckhoffBool(this.GetG_I_IMH_MPD_SR, client, 16448, 2004293){ Name = "G_I_IMH_MPD_SR" };
			G_I_IMH_MFD_SR = new BeckhoffBool(this.GetG_I_IMH_MFD_SR, client, 16448, 2004294){ Name = "G_I_IMH_MFD_SR" };
			G_I_OMH_ZM_PL = new BeckhoffBool(this.GetG_I_OMH_ZM_PL, client, 16448, 2004295){ Name = "G_I_OMH_ZM_PL" };
			G_I_OMH_ZM_OL = new BeckhoffBool(this.GetG_I_OMH_ZM_OL, client, 16448, 2004296){ Name = "G_I_OMH_ZM_OL" };
			G_I_OMH_ZM_NL = new BeckhoffBool(this.GetG_I_OMH_ZM_NL, client, 16448, 2004297){ Name = "G_I_OMH_ZM_NL" };
			G_I_OMH_YM_PL = new BeckhoffBool(this.GetG_I_OMH_YM_PL, client, 16448, 2004298){ Name = "G_I_OMH_YM_PL" };
			G_I_OMH_YM_OL = new BeckhoffBool(this.GetG_I_OMH_YM_OL, client, 16448, 2004299){ Name = "G_I_OMH_YM_OL" };
			G_I_OMH_YM_NL = new BeckhoffBool(this.GetG_I_OMH_YM_NL, client, 16448, 2004300){ Name = "G_I_OMH_YM_NL" };
			G_I_OMH_LDF_PL = new BeckhoffBool(this.GetG_I_OMH_LDF_PL, client, 16448, 2004301){ Name = "G_I_OMH_LDF_PL" };
			G_I_OMH_LDF_NL = new BeckhoffBool(this.GetG_I_OMH_LDF_NL, client, 16448, 2004302){ Name = "G_I_OMH_LDF_NL" };
			G_I_OMH_ZC_PL = new BeckhoffBool(this.GetG_I_OMH_ZC_PL, client, 16448, 2004303){ Name = "G_I_OMH_ZC_PL" };
			G_I_OMH_ZC_NL = new BeckhoffBool(this.GetG_I_OMH_ZC_NL, client, 16448, 2004304){ Name = "G_I_OMH_ZC_NL" };
			G_I_OMH_YC_PL = new BeckhoffBool(this.GetG_I_OMH_YC_PL, client, 16448, 2004305){ Name = "G_I_OMH_YC_PL" };
			G_I_OMH_YC_NL = new BeckhoffBool(this.GetG_I_OMH_YC_NL, client, 16448, 2004306){ Name = "G_I_OMH_YC_NL" };
			G_I_OMH_SDD_SR = new BeckhoffBool(this.GetG_I_OMH_SDD_SR, client, 16448, 2004307){ Name = "G_I_OMH_SDD_SR" };
			G_I_OMH_MPD_SR = new BeckhoffBool(this.GetG_I_OMH_MPD_SR, client, 16448, 2004308){ Name = "G_I_OMH_MPD_SR" };
			G_I_OMH_MFD_SR = new BeckhoffBool(this.GetG_I_OMH_MFD_SR, client, 16448, 2004309){ Name = "G_I_OMH_MFD_SR" };
			G_I_FIG_SFP_SR = new BeckhoffBool(this.GetG_I_FIG_SFP_SR, client, 16448, 2004310){ Name = "G_I_FIG_SFP_SR" };
			G_I_FIG_SPD_SR = new BeckhoffBool(this.GetG_I_FIG_SPD_SR, client, 16448, 2004311){ Name = "G_I_FIG_SPD_SR" };
			G_I_FIG_RVS_SR = new BeckhoffBool(this.GetG_I_FIG_RVS_SR, client, 16448, 2004312){ Name = "G_I_FIG_RVS_SR" };
			G_I_FIG_IFO_SR = new BeckhoffBool(this.GetG_I_FIG_IFO_SR, client, 16448, 2004313){ Name = "G_I_FIG_IFO_SR" };
			G_I_FIG_CM_OL = new BeckhoffBool(this.GetG_I_FIG_CM_OL, client, 16448, 2004314){ Name = "G_I_FIG_CM_OL" };
			G_I_FIG_XM_PL = new BeckhoffBool(this.GetG_I_FIG_XM_PL, client, 16448, 2004315){ Name = "G_I_FIG_XM_PL" };
			G_I_FIG_XM_OL = new BeckhoffBool(this.GetG_I_FIG_XM_OL, client, 16448, 2004316){ Name = "G_I_FIG_XM_OL" };
			G_I_FIG_XM_NL = new BeckhoffBool(this.GetG_I_FIG_XM_NL, client, 16448, 2004317){ Name = "G_I_FIG_XM_NL" };
			G_I_FCU_SIP_SR = new BeckhoffBool(this.GetG_I_FCU_SIP_SR, client, 16448, 2004318){ Name = "G_I_FCU_SIP_SR" };
			G_I_FCU_TRC_SR1 = new BeckhoffBool(this.GetG_I_FCU_TRC_SR1, client, 16448, 2004319){ Name = "G_I_FCU_TRC_SR1" };
			G_I_FCU_TRC_SR2 = new BeckhoffBool(this.GetG_I_FCU_TRC_SR2, client, 16448, 2004320){ Name = "G_I_FCU_TRC_SR2" };
			G_I_FCU_PRA_SR = new BeckhoffBool(this.GetG_I_FCU_PRA_SR, client, 16448, 2004321){ Name = "G_I_FCU_PRA_SR" };
			G_I_FCU_NRA_SR = new BeckhoffBool(this.GetG_I_FCU_NRA_SR, client, 16448, 2004322){ Name = "G_I_FCU_NRA_SR" };
			G_I_FCU_LXM_PL = new BeckhoffBool(this.GetG_I_FCU_LXM_PL, client, 16448, 2004323){ Name = "G_I_FCU_LXM_PL" };
			G_I_FCU_LXM_OL = new BeckhoffBool(this.GetG_I_FCU_LXM_OL, client, 16448, 2004324){ Name = "G_I_FCU_LXM_OL" };
			G_I_FCU_LXM_NL = new BeckhoffBool(this.GetG_I_FCU_LXM_NL, client, 16448, 2004325){ Name = "G_I_FCU_LXM_NL" };
			G_I_FCU_CM_OL = new BeckhoffBool(this.GetG_I_FCU_CM_OL, client, 16448, 2004326){ Name = "G_I_FCU_CM_OL" };
			G_I_FCU_CDA_YM_OL = new BeckhoffBool(this.GetG_I_FCU_CDA_YM_OL, client, 16448, 2004327){ Name = "G_I_FCU_CDA_YM_OL" };
			G_I_FCU_CDA_ZM_PL = new BeckhoffBool(this.GetG_I_FCU_CDA_ZM_PL, client, 16448, 2004328){ Name = "G_I_FCU_CDA_ZM_PL" };
			G_I_FCU_CDA_ZM_NL = new BeckhoffBool(this.GetG_I_FCU_CDA_ZM_NL, client, 16448, 2004329){ Name = "G_I_FCU_CDA_ZM_NL" };
			G_I_FCU_PCM_OL = new BeckhoffBool(this.GetG_I_FCU_PCM_OL, client, 16448, 2004330){ Name = "G_I_FCU_PCM_OL" };
			G_I_FCU_SZM_PL = new BeckhoffBool(this.GetG_I_FCU_SZM_PL, client, 16448, 2004331){ Name = "G_I_FCU_SZM_PL" };
			G_I_FCU_SZM_OL = new BeckhoffBool(this.GetG_I_FCU_SZM_OL, client, 16448, 2004332){ Name = "G_I_FCU_SZM_OL" };
			G_I_FCU_SZM_NL = new BeckhoffBool(this.GetG_I_FCU_SZM_NL, client, 16448, 2004333){ Name = "G_I_FCU_SZM_NL" };
			G_I_FBU_UTC_SR1 = new BeckhoffBool(this.GetG_I_FBU_UTC_SR1, client, 16448, 2004334){ Name = "G_I_FBU_UTC_SR1" };
			G_I_FBU_UTC_SR2 = new BeckhoffBool(this.GetG_I_FBU_UTC_SR2, client, 16448, 2004335){ Name = "G_I_FBU_UTC_SR2" };
			G_AI_FCU_PHT = new BeckhoffInt(this.GetG_AI_FCU_PHT, client, 16448, 2004336){ Name = "G_AI_FCU_PHT" };
			G_AI_FCU_HCM = new BeckhoffInt(this.GetG_AI_FCU_HCM, client, 16448, 2004340){ Name = "G_AI_FCU_HCM" };
			G_AI_FCU_RDV = new BeckhoffInt(this.GetG_AI_FCU_RDV, client, 16448, 2004344){ Name = "G_AI_FCU_RDV" };
			G_I_FBU_BCM_OL = new BeckhoffBool(this.GetG_I_FBU_BCM_OL, client, 16448, 2004348){ Name = "G_I_FBU_BCM_OL" };
			G_I_FBU_BZ1M_PL = new BeckhoffBool(this.GetG_I_FBU_BZ1M_PL, client, 16448, 2004349){ Name = "G_I_FBU_BZ1M_PL" };
			G_I_FBU_BZ1M_OL = new BeckhoffBool(this.GetG_I_FBU_BZ1M_OL, client, 16448, 2004350){ Name = "G_I_FBU_BZ1M_OL" };
			G_I_FBU_BZ1M_NL = new BeckhoffBool(this.GetG_I_FBU_BZ1M_NL, client, 16448, 2004351){ Name = "G_I_FBU_BZ1M_NL" };
			G_I_FBU_BZ2M_PL = new BeckhoffBool(this.GetG_I_FBU_BZ2M_PL, client, 16448, 2004352){ Name = "G_I_FBU_BZ2M_PL" };
			G_I_FBU_BZ2M_OL = new BeckhoffBool(this.GetG_I_FBU_BZ2M_OL, client, 16448, 2004353){ Name = "G_I_FBU_BZ2M_OL" };
			G_I_FBU_BZ2M_NL = new BeckhoffBool(this.GetG_I_FBU_BZ2M_NL, client, 16448, 2004354){ Name = "G_I_FBU_BZ2M_NL" };
			G_I_FBU_LXM_PL = new BeckhoffBool(this.GetG_I_FBU_LXM_PL, client, 16448, 2004355){ Name = "G_I_FBU_LXM_PL" };
			G_I_FBU_LXM_OL = new BeckhoffBool(this.GetG_I_FBU_LXM_OL, client, 16448, 2004356){ Name = "G_I_FBU_LXM_OL" };
			G_I_FBU_LXM_NL = new BeckhoffBool(this.GetG_I_FBU_LXM_NL, client, 16448, 2004357){ Name = "G_I_FBU_LXM_NL" };
			G_I_FBU_CM_OL = new BeckhoffBool(this.GetG_I_FBU_CM_OL, client, 16448, 2004358){ Name = "G_I_FBU_CM_OL" };
			G_I_FBU_V_XM_PL = new BeckhoffBool(this.GetG_I_FBU_V_XM_PL, client, 16448, 2004359){ Name = "G_I_FBU_V_XM_PL" };
			G_I_FBU_V_XM_OL = new BeckhoffBool(this.GetG_I_FBU_V_XM_OL, client, 16448, 2004360){ Name = "G_I_FBU_V_XM_OL" };
			G_I_FBU_V_XM_NL = new BeckhoffBool(this.GetG_I_FBU_V_XM_NL, client, 16448, 2004361){ Name = "G_I_FBU_V_XM_NL" };
			G_I_FBU_V_YM_PL = new BeckhoffBool(this.GetG_I_FBU_V_YM_PL, client, 16448, 2004362){ Name = "G_I_FBU_V_YM_PL" };
			G_I_FBU_V_YM_OL = new BeckhoffBool(this.GetG_I_FBU_V_YM_OL, client, 16448, 2004363){ Name = "G_I_FBU_V_YM_OL" };
			G_I_FBU_V_YM_NL = new BeckhoffBool(this.GetG_I_FBU_V_YM_NL, client, 16448, 2004364){ Name = "G_I_FBU_V_YM_NL" };
			G_I_FBU_AZM_PL = new BeckhoffBool(this.GetG_I_FBU_AZM_PL, client, 16448, 2004365){ Name = "G_I_FBU_AZM_PL" };
			G_I_FBU_AZM_OL = new BeckhoffBool(this.GetG_I_FBU_AZM_OL, client, 16448, 2004366){ Name = "G_I_FBU_AZM_OL" };
			G_I_FBU_AZM_NL = new BeckhoffBool(this.GetG_I_FBU_AZM_NL, client, 16448, 2004367){ Name = "G_I_FBU_AZM_NL" };
			G_I_FBU_TWM_OL = new BeckhoffBool(this.GetG_I_FBU_TWM_OL, client, 16448, 2004368){ Name = "G_I_FBU_TWM_OL" };
			G_I_FOG_USS_PL = new BeckhoffBool(this.GetG_I_FOG_USS_PL, client, 16448, 2004369){ Name = "G_I_FOG_USS_PL" };
			G_I_FOG_LXM_PL = new BeckhoffBool(this.GetG_I_FOG_LXM_PL, client, 16448, 2004370){ Name = "G_I_FOG_LXM_PL" };
			G_I_FOG_LXM_OL = new BeckhoffBool(this.GetG_I_FOG_LXM_OL, client, 16448, 2004371){ Name = "G_I_FOG_LXM_OL" };
			G_AI_FBU_HTR = new BeckhoffInt(this.GetG_AI_FBU_HTR, client, 16448, 2004372){ Name = "G_AI_FBU_HTR" };
			G_AI1_FBU_NPA = new BeckhoffInt(this.GetG_AI1_FBU_NPA, client, 16448, 2004376){ Name = "G_AI1_FBU_NPA" };
			G_AI2_FBU_NPA = new BeckhoffInt(this.GetG_AI2_FBU_NPA, client, 16448, 2004380){ Name = "G_AI2_FBU_NPA" };
			G_AI3_FBU_NPA = new BeckhoffInt(this.GetG_AI3_FBU_NPA, client, 16448, 2004384){ Name = "G_AI3_FBU_NPA" };
			G_I_FOG_LXM_NL = new BeckhoffBool(this.GetG_I_FOG_LXM_NL, client, 16448, 2004388){ Name = "G_I_FOG_LXM_NL" };
			G_I_FOG_ZM_OL = new BeckhoffBool(this.GetG_I_FOG_ZM_OL, client, 16448, 2004389){ Name = "G_I_FOG_ZM_OL" };
			G_I_WLU_FRI_SR = new BeckhoffBool(this.GetG_I_WLU_FRI_SR, client, 16448, 2004390){ Name = "G_I_WLU_FRI_SR" };
			G_I_WLU_RRI_SR = new BeckhoffBool(this.GetG_I_WLU_RRI_SR, client, 16448, 2004391){ Name = "G_I_WLU_RRI_SR" };
			G_I_WLU_FRO_SR = new BeckhoffBool(this.GetG_I_WLU_FRO_SR, client, 16448, 2004392){ Name = "G_I_WLU_FRO_SR" };
			G_I_WLU_RRO_SR = new BeckhoffBool(this.GetG_I_WLU_RRO_SR, client, 16448, 2004393){ Name = "G_I_WLU_RRO_SR" };
			G_I_WLU_WTS_SR = new BeckhoffBool(this.GetG_I_WLU_WTS_SR, client, 16448, 2004394){ Name = "G_I_WLU_WTS_SR" };
			G_I_WLU_WRS_SR = new BeckhoffBool(this.GetG_I_WLU_WRS_SR, client, 16448, 2004395){ Name = "G_I_WLU_WRS_SR" };
			G_I_WLU_WPD_SR = new BeckhoffBool(this.GetG_I_WLU_WPD_SR, client, 16448, 2004396){ Name = "G_I_WLU_WPD_SR" };
			G_I_WLU_WJS_SR = new BeckhoffBool(this.GetG_I_WLU_WJS_SR, client, 16448, 2004397){ Name = "G_I_WLU_WJS_SR" };
			G_I_WLU_CAP_SR1 = new BeckhoffBool(this.GetG_I_WLU_CAP_SR1, client, 16448, 2004398){ Name = "G_I_WLU_CAP_SR1" };
			G_I_WLU_CAP_SR2 = new BeckhoffBool(this.GetG_I_WLU_CAP_SR2, client, 16448, 2004399){ Name = "G_I_WLU_CAP_SR2" };
			G_I_WLU_ZM_PL = new BeckhoffBool(this.GetG_I_WLU_ZM_PL, client, 61472, 2004400){ Name = "G_I_WLU_ZM_PL" };
			G_I_WLU_ZM_WL = new BeckhoffBool(this.GetG_I_WLU_ZM_WL, client, 61472, 2004401){ Name = "G_I_WLU_ZM_WL" };
			G_I_WLU_ZM_OL = new BeckhoffBool(this.GetG_I_WLU_ZM_OL, client, 61472, 2004402){ Name = "G_I_WLU_ZM_OL" };
			G_I_WLU_ZM_NL = new BeckhoffBool(this.GetG_I_WLU_ZM_NL, client, 61472, 2004403){ Name = "G_I_WLU_ZM_NL" };
			G_I_WLU_XM_PL = new BeckhoffBool(this.GetG_I_WLU_XM_PL, client, 61472, 2004404){ Name = "G_I_WLU_XM_PL" };
			G_I_WLU_XM_OL = new BeckhoffBool(this.GetG_I_WLU_XM_OL, client, 61472, 2004405){ Name = "G_I_WLU_XM_OL" };
			G_I_WLU_XM_NL = new BeckhoffBool(this.GetG_I_WLU_XM_NL, client, 61472, 2004406){ Name = "G_I_WLU_XM_NL" };
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
		~GVL_Sensor_UsedWrapper()
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
