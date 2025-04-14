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
	/// Name from PLC:GVL_Sensor_Used
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_Sensor_UsedWrapper
	{

		/// <summary>
		/// Name from PLC:G_I_IMH_ZM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004271)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_ZM_PL { get; }
		internal bool ref_G_I_IMH_ZM_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_IMH_ZM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004278)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_ZM_OL { get; }
		internal bool ref_G_I_IMH_ZM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_IMH_ZM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004279)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_ZM_NL { get; }
		internal bool ref_G_I_IMH_ZM_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_IMH_YM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004280)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_YM_PL { get; }
		internal bool ref_G_I_IMH_YM_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_IMH_YM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004281)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_YM_OL { get; }
		internal bool ref_G_I_IMH_YM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_IMH_YM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004282)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_YM_NL { get; }
		internal bool ref_G_I_IMH_YM_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_IMH_LDF_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004283)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_LDF_PL { get; }
		internal bool ref_G_I_IMH_LDF_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_IMH_LDF_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004284)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_LDF_NL { get; }
		internal bool ref_G_I_IMH_LDF_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_IMH_ZC_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004285)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_ZC_PL { get; }
		internal bool ref_G_I_IMH_ZC_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_IMH_ZC_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004286)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_ZC_NL { get; }
		internal bool ref_G_I_IMH_ZC_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_IMH_YC_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004287)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_YC_PL { get; }
		internal bool ref_G_I_IMH_YC_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_IMH_YC_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004288)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_YC_NL { get; }
		internal bool ref_G_I_IMH_YC_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_IMH_SPC_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004289)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_SPC_PL { get; }
		internal bool ref_G_I_IMH_SPC_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_IMH_SPC_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004290)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_SPC_NL { get; }
		internal bool ref_G_I_IMH_SPC_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_IMH_SAC_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004291)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_SAC_SR { get; }
		internal bool ref_G_I_IMH_SAC_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_IMH_SDD_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004292)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_SDD_SR { get; }
		internal bool ref_G_I_IMH_SDD_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_IMH_MPD_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004293)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_MPD_SR { get; }
		internal bool ref_G_I_IMH_MPD_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_IMH_MFD_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004294)
		/// Size: 1
		public IBaseData<bool> G_I_IMH_MFD_SR { get; }
		internal bool ref_G_I_IMH_MFD_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_OMH_ZM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004295)
		/// Size: 1
		public IBaseData<bool> G_I_OMH_ZM_PL { get; }
		internal bool ref_G_I_OMH_ZM_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_OMH_ZM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004296)
		/// Size: 1
		public IBaseData<bool> G_I_OMH_ZM_OL { get; }
		internal bool ref_G_I_OMH_ZM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_OMH_ZM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004297)
		/// Size: 1
		public IBaseData<bool> G_I_OMH_ZM_NL { get; }
		internal bool ref_G_I_OMH_ZM_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_OMH_YM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004298)
		/// Size: 1
		public IBaseData<bool> G_I_OMH_YM_PL { get; }
		internal bool ref_G_I_OMH_YM_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_OMH_YM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004299)
		/// Size: 1
		public IBaseData<bool> G_I_OMH_YM_OL { get; }
		internal bool ref_G_I_OMH_YM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_OMH_YM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004300)
		/// Size: 1
		public IBaseData<bool> G_I_OMH_YM_NL { get; }
		internal bool ref_G_I_OMH_YM_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_OMH_LDF_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004301)
		/// Size: 1
		public IBaseData<bool> G_I_OMH_LDF_PL { get; }
		internal bool ref_G_I_OMH_LDF_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_OMH_LDF_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004302)
		/// Size: 1
		public IBaseData<bool> G_I_OMH_LDF_NL { get; }
		internal bool ref_G_I_OMH_LDF_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_OMH_ZC_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004303)
		/// Size: 1
		public IBaseData<bool> G_I_OMH_ZC_PL { get; }
		internal bool ref_G_I_OMH_ZC_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_OMH_ZC_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004304)
		/// Size: 1
		public IBaseData<bool> G_I_OMH_ZC_NL { get; }
		internal bool ref_G_I_OMH_ZC_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_OMH_YC_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004305)
		/// Size: 1
		public IBaseData<bool> G_I_OMH_YC_PL { get; }
		internal bool ref_G_I_OMH_YC_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_OMH_YC_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004306)
		/// Size: 1
		public IBaseData<bool> G_I_OMH_YC_NL { get; }
		internal bool ref_G_I_OMH_YC_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_OMH_SDD_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004307)
		/// Size: 1
		public IBaseData<bool> G_I_OMH_SDD_SR { get; }
		internal bool ref_G_I_OMH_SDD_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_OMH_MPD_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004308)
		/// Size: 1
		public IBaseData<bool> G_I_OMH_MPD_SR { get; }
		internal bool ref_G_I_OMH_MPD_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_OMH_MFD_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004309)
		/// Size: 1
		public IBaseData<bool> G_I_OMH_MFD_SR { get; }
		internal bool ref_G_I_OMH_MFD_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_FIG_SFP_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004310)
		/// Size: 1
		public IBaseData<bool> G_I_FIG_SFP_SR { get; }
		internal bool ref_G_I_FIG_SFP_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_FIG_SPD_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004311)
		/// Size: 1
		public IBaseData<bool> G_I_FIG_SPD_SR { get; }
		internal bool ref_G_I_FIG_SPD_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_FIG_RVS_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004312)
		/// Size: 1
		public IBaseData<bool> G_I_FIG_RVS_SR { get; }
		internal bool ref_G_I_FIG_RVS_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_FIG_IFO_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004313)
		/// Size: 1
		public IBaseData<bool> G_I_FIG_IFO_SR { get; }
		internal bool ref_G_I_FIG_IFO_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_FIG_CM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004314)
		/// Size: 1
		public IBaseData<bool> G_I_FIG_CM_OL { get; }
		internal bool ref_G_I_FIG_CM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FIG_XM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004315)
		/// Size: 1
		public IBaseData<bool> G_I_FIG_XM_PL { get; }
		internal bool ref_G_I_FIG_XM_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FIG_XM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004316)
		/// Size: 1
		public IBaseData<bool> G_I_FIG_XM_OL { get; }
		internal bool ref_G_I_FIG_XM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FIG_XM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004317)
		/// Size: 1
		public IBaseData<bool> G_I_FIG_XM_NL { get; }
		internal bool ref_G_I_FIG_XM_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FCU_SIP_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004318)
		/// Size: 1
		public IBaseData<bool> G_I_FCU_SIP_SR { get; }
		internal bool ref_G_I_FCU_SIP_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_FCU_TRC_SR1
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004319)
		/// Size: 1
		public IBaseData<bool> G_I_FCU_TRC_SR1 { get; }
		internal bool ref_G_I_FCU_TRC_SR1 = new bool();

		/// <summary>
		/// Name from PLC:G_I_FCU_TRC_SR2
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004320)
		/// Size: 1
		public IBaseData<bool> G_I_FCU_TRC_SR2 { get; }
		internal bool ref_G_I_FCU_TRC_SR2 = new bool();

		/// <summary>
		/// Name from PLC:G_I_FCU_PRA_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004321)
		/// Size: 1
		public IBaseData<bool> G_I_FCU_PRA_SR { get; }
		internal bool ref_G_I_FCU_PRA_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_FCU_NRA_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004322)
		/// Size: 1
		public IBaseData<bool> G_I_FCU_NRA_SR { get; }
		internal bool ref_G_I_FCU_NRA_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_FCU_LXM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004323)
		/// Size: 1
		public IBaseData<bool> G_I_FCU_LXM_PL { get; }
		internal bool ref_G_I_FCU_LXM_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FCU_LXM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004324)
		/// Size: 1
		public IBaseData<bool> G_I_FCU_LXM_OL { get; }
		internal bool ref_G_I_FCU_LXM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FCU_LXM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004325)
		/// Size: 1
		public IBaseData<bool> G_I_FCU_LXM_NL { get; }
		internal bool ref_G_I_FCU_LXM_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FCU_CM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004326)
		/// Size: 1
		public IBaseData<bool> G_I_FCU_CM_OL { get; }
		internal bool ref_G_I_FCU_CM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FCU_CDA_YM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004327)
		/// Size: 1
		public IBaseData<bool> G_I_FCU_CDA_YM_OL { get; }
		internal bool ref_G_I_FCU_CDA_YM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FCU_CDA_ZM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004328)
		/// Size: 1
		public IBaseData<bool> G_I_FCU_CDA_ZM_PL { get; }
		internal bool ref_G_I_FCU_CDA_ZM_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FCU_CDA_ZM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004329)
		/// Size: 1
		public IBaseData<bool> G_I_FCU_CDA_ZM_NL { get; }
		internal bool ref_G_I_FCU_CDA_ZM_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FCU_PCM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004330)
		/// Size: 1
		public IBaseData<bool> G_I_FCU_PCM_OL { get; }
		internal bool ref_G_I_FCU_PCM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FCU_SZM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004331)
		/// Size: 1
		public IBaseData<bool> G_I_FCU_SZM_PL { get; }
		internal bool ref_G_I_FCU_SZM_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FCU_SZM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004332)
		/// Size: 1
		public IBaseData<bool> G_I_FCU_SZM_OL { get; }
		internal bool ref_G_I_FCU_SZM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FCU_SZM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004333)
		/// Size: 1
		public IBaseData<bool> G_I_FCU_SZM_NL { get; }
		internal bool ref_G_I_FCU_SZM_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_UTC_SR1
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004334)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_UTC_SR1 { get; }
		internal bool ref_G_I_FBU_UTC_SR1 = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_UTC_SR2
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004335)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_UTC_SR2 { get; }
		internal bool ref_G_I_FBU_UTC_SR2 = new bool();

		/// <summary>
		/// Name from PLC:G_AI_FCU_PHT
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,2004336)
		/// Size: 4
		public IBaseData<int> G_AI_FCU_PHT { get; }
		internal int ref_G_AI_FCU_PHT = new int();

		/// <summary>
		/// Name from PLC:G_AI_FCU_HCM
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,2004340)
		/// Size: 4
		public IBaseData<int> G_AI_FCU_HCM { get; }
		internal int ref_G_AI_FCU_HCM = new int();

		/// <summary>
		/// Name from PLC:G_AI_FCU_RDV
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,2004344)
		/// Size: 4
		public IBaseData<int> G_AI_FCU_RDV { get; }
		internal int ref_G_AI_FCU_RDV = new int();

		/// <summary>
		/// Name from PLC:G_I_FBU_BCM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004348)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_BCM_OL { get; }
		internal bool ref_G_I_FBU_BCM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_BZ1M_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004349)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_BZ1M_PL { get; }
		internal bool ref_G_I_FBU_BZ1M_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_BZ1M_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004350)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_BZ1M_OL { get; }
		internal bool ref_G_I_FBU_BZ1M_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_BZ1M_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004351)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_BZ1M_NL { get; }
		internal bool ref_G_I_FBU_BZ1M_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_BZ2M_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004352)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_BZ2M_PL { get; }
		internal bool ref_G_I_FBU_BZ2M_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_BZ2M_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004353)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_BZ2M_OL { get; }
		internal bool ref_G_I_FBU_BZ2M_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_BZ2M_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004354)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_BZ2M_NL { get; }
		internal bool ref_G_I_FBU_BZ2M_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_LXM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004355)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_LXM_PL { get; }
		internal bool ref_G_I_FBU_LXM_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_LXM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004356)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_LXM_OL { get; }
		internal bool ref_G_I_FBU_LXM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_LXM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004357)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_LXM_NL { get; }
		internal bool ref_G_I_FBU_LXM_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_CM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004358)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_CM_OL { get; }
		internal bool ref_G_I_FBU_CM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_V_XM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004359)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_V_XM_PL { get; }
		internal bool ref_G_I_FBU_V_XM_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_V_XM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004360)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_V_XM_OL { get; }
		internal bool ref_G_I_FBU_V_XM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_V_XM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004361)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_V_XM_NL { get; }
		internal bool ref_G_I_FBU_V_XM_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_V_YM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004362)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_V_YM_PL { get; }
		internal bool ref_G_I_FBU_V_YM_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_V_YM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004363)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_V_YM_OL { get; }
		internal bool ref_G_I_FBU_V_YM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_V_YM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004364)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_V_YM_NL { get; }
		internal bool ref_G_I_FBU_V_YM_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_AZM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004365)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_AZM_PL { get; }
		internal bool ref_G_I_FBU_AZM_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_AZM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004366)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_AZM_OL { get; }
		internal bool ref_G_I_FBU_AZM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_AZM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004367)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_AZM_NL { get; }
		internal bool ref_G_I_FBU_AZM_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FBU_TWM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004368)
		/// Size: 1
		public IBaseData<bool> G_I_FBU_TWM_OL { get; }
		internal bool ref_G_I_FBU_TWM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FOG_USS_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004369)
		/// Size: 1
		public IBaseData<bool> G_I_FOG_USS_PL { get; }
		internal bool ref_G_I_FOG_USS_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FOG_LXM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004370)
		/// Size: 1
		public IBaseData<bool> G_I_FOG_LXM_PL { get; }
		internal bool ref_G_I_FOG_LXM_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FOG_LXM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004371)
		/// Size: 1
		public IBaseData<bool> G_I_FOG_LXM_OL { get; }
		internal bool ref_G_I_FOG_LXM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_AI_FBU_HTR
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,2004372)
		/// Size: 4
		public IBaseData<int> G_AI_FBU_HTR { get; }
		internal int ref_G_AI_FBU_HTR = new int();

		/// <summary>
		/// Name from PLC:G_AI1_FBU_NPA
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,2004376)
		/// Size: 4
		public IBaseData<int> G_AI1_FBU_NPA { get; }
		internal int ref_G_AI1_FBU_NPA = new int();

		/// <summary>
		/// Name from PLC:G_AI2_FBU_NPA
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,2004380)
		/// Size: 4
		public IBaseData<int> G_AI2_FBU_NPA { get; }
		internal int ref_G_AI2_FBU_NPA = new int();

		/// <summary>
		/// Name from PLC:G_AI3_FBU_NPA
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,2004384)
		/// Size: 4
		public IBaseData<int> G_AI3_FBU_NPA { get; }
		internal int ref_G_AI3_FBU_NPA = new int();

		/// <summary>
		/// Name from PLC:G_I_FOG_LXM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004388)
		/// Size: 1
		public IBaseData<bool> G_I_FOG_LXM_NL { get; }
		internal bool ref_G_I_FOG_LXM_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_FOG_ZM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004389)
		/// Size: 1
		public IBaseData<bool> G_I_FOG_ZM_OL { get; }
		internal bool ref_G_I_FOG_ZM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_WLU_FRI_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004390)
		/// Size: 1
		public IBaseData<bool> G_I_WLU_FRI_SR { get; }
		internal bool ref_G_I_WLU_FRI_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_WLU_RRI_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004391)
		/// Size: 1
		public IBaseData<bool> G_I_WLU_RRI_SR { get; }
		internal bool ref_G_I_WLU_RRI_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_WLU_FRO_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004392)
		/// Size: 1
		public IBaseData<bool> G_I_WLU_FRO_SR { get; }
		internal bool ref_G_I_WLU_FRO_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_WLU_RRO_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004393)
		/// Size: 1
		public IBaseData<bool> G_I_WLU_RRO_SR { get; }
		internal bool ref_G_I_WLU_RRO_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_WLU_WTS_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004394)
		/// Size: 1
		public IBaseData<bool> G_I_WLU_WTS_SR { get; }
		internal bool ref_G_I_WLU_WTS_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_WLU_WRS_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004395)
		/// Size: 1
		public IBaseData<bool> G_I_WLU_WRS_SR { get; }
		internal bool ref_G_I_WLU_WRS_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_WLU_WPD_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004396)
		/// Size: 1
		public IBaseData<bool> G_I_WLU_WPD_SR { get; }
		internal bool ref_G_I_WLU_WPD_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_WLU_WJS_SR
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004397)
		/// Size: 1
		public IBaseData<bool> G_I_WLU_WJS_SR { get; }
		internal bool ref_G_I_WLU_WJS_SR = new bool();

		/// <summary>
		/// Name from PLC:G_I_WLU_CAP_SR1
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004398)
		/// Size: 1
		public IBaseData<bool> G_I_WLU_CAP_SR1 { get; }
		internal bool ref_G_I_WLU_CAP_SR1 = new bool();

		/// <summary>
		/// Name from PLC:G_I_WLU_CAP_SR2
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2004399)
		/// Size: 1
		public IBaseData<bool> G_I_WLU_CAP_SR2 { get; }
		internal bool ref_G_I_WLU_CAP_SR2 = new bool();

		/// <summary>
		/// Name from PLC:G_I_WLU_ZM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2004400)
		/// Size: 1
		public IBaseData<bool> G_I_WLU_ZM_PL { get; }
		internal bool ref_G_I_WLU_ZM_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_WLU_ZM_WL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2004401)
		/// Size: 1
		public IBaseData<bool> G_I_WLU_ZM_WL { get; }
		internal bool ref_G_I_WLU_ZM_WL = new bool();

		/// <summary>
		/// Name from PLC:G_I_WLU_ZM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2004402)
		/// Size: 1
		public IBaseData<bool> G_I_WLU_ZM_OL { get; }
		internal bool ref_G_I_WLU_ZM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_WLU_ZM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2004403)
		/// Size: 1
		public IBaseData<bool> G_I_WLU_ZM_NL { get; }
		internal bool ref_G_I_WLU_ZM_NL = new bool();

		/// <summary>
		/// Name from PLC:G_I_WLU_XM_PL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2004404)
		/// Size: 1
		public IBaseData<bool> G_I_WLU_XM_PL { get; }
		internal bool ref_G_I_WLU_XM_PL = new bool();

		/// <summary>
		/// Name from PLC:G_I_WLU_XM_OL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2004405)
		/// Size: 1
		public IBaseData<bool> G_I_WLU_XM_OL { get; }
		internal bool ref_G_I_WLU_XM_OL = new bool();

		/// <summary>
		/// Name from PLC:G_I_WLU_XM_NL
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (61472,2004406)
		/// Size: 1
		public IBaseData<bool> G_I_WLU_XM_NL { get; }
		internal bool ref_G_I_WLU_XM_NL = new bool();

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
