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
	/// Name from PLC:IMH_Unit
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class IMH_UnitWrapper : BaseData, IBaseData
	{
		public override IEnumerable<IBaseData> Children
		{
			get
			{
				yield return Home_Move;
				yield return LCase_Move;
				yield return ULCase_Move;
				yield return Auto_Move;
				yield return i;
				yield return H_DelayOn;
				yield return H_TrigOn;
				yield return L_DelayOn;
				yield return L_TrigOn;
				yield return UL_DelayOn;
				yield return UL_TrigOn;
				yield return DelayOn;
				yield return TrigOn;
				yield return Initial_DelayOn;
				yield return Initial_TrigOn;
				yield return Pos_IMH_ZM_Bottom_TO_Top;
				yield return Pos_IMH_ZM_Top_To_Bottom;
				yield return Pos_ZM_Receive_Buffer;
				yield return IMH_PosY_Loader_Buffer;
			}
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Home_Move):
					return Home_Move;
				case nameof(LCase_Move):
					return LCase_Move;
				case nameof(ULCase_Move):
					return ULCase_Move;
				case nameof(Auto_Move):
					return Auto_Move;
				case nameof(i):
					return i;
				case nameof(H_DelayOn):
					return H_DelayOn;
				case nameof(H_TrigOn):
					return H_TrigOn;
				case nameof(L_DelayOn):
					return L_DelayOn;
				case nameof(L_TrigOn):
					return L_TrigOn;
				case nameof(UL_DelayOn):
					return UL_DelayOn;
				case nameof(UL_TrigOn):
					return UL_TrigOn;
				case nameof(DelayOn):
					return DelayOn;
				case nameof(TrigOn):
					return TrigOn;
				case nameof(Initial_DelayOn):
					return Initial_DelayOn;
				case nameof(Initial_TrigOn):
					return Initial_TrigOn;
				case nameof(Pos_IMH_ZM_Bottom_TO_Top):
					return Pos_IMH_ZM_Bottom_TO_Top;
				case nameof(Pos_IMH_ZM_Top_To_Bottom):
					return Pos_IMH_ZM_Top_To_Bottom;
				case nameof(Pos_ZM_Receive_Buffer):
					return Pos_ZM_Receive_Buffer;
				case nameof(IMH_PosY_Loader_Buffer):
					return IMH_PosY_Loader_Buffer;
			}
			throw new KeyNotFoundException(name);
		}

		private readonly AdsClient client;

		public IMH_UnitWrapper(AdsClient client)
		{
			this.client = client;

			Home_Move = new BeckhoffBoolArray<Bool20>(this.GetHome_Move, client, 16448, 1167836,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1167836 ,1167837 ,1167838 ,1167839 ,1167840 ,1167841 ,1167842 ,1167843 ,1167844 ,1167845 ,1167846 ,1167847 ,1167848 ,1167849 ,1167850 ,1167851 ,1167852 ,1167853 ,1167854 ,1167855 , }, false){ Name = "Home_Move" };
			LCase_Move = new BeckhoffBoolArray<Bool20>(this.GetLCase_Move, client, 16448, 1167856,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1167856 ,1167857 ,1167858 ,1167859 ,1167860 ,1167861 ,1167862 ,1167863 ,1167864 ,1167865 ,1167866 ,1167867 ,1167868 ,1167869 ,1167870 ,1167871 ,1167872 ,1167873 ,1167874 ,1167875 , }, false){ Name = "LCase_Move" };
			ULCase_Move = new BeckhoffBoolArray<Bool20>(this.GetULCase_Move, client, 16448, 1167876,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1167876 ,1167877 ,1167878 ,1167879 ,1167880 ,1167881 ,1167882 ,1167883 ,1167884 ,1167885 ,1167886 ,1167887 ,1167888 ,1167889 ,1167890 ,1167891 ,1167892 ,1167893 ,1167894 ,1167895 , }, false){ Name = "ULCase_Move" };
			Auto_Move = new BeckhoffBoolArray<Bool20>(this.GetAuto_Move, client, 16448, 1167896,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1167896 ,1167897 ,1167898 ,1167899 ,1167900 ,1167901 ,1167902 ,1167903 ,1167904 ,1167905 ,1167906 ,1167907 ,1167908 ,1167909 ,1167910 ,1167911 ,1167912 ,1167913 ,1167914 ,1167915 , }, false){ Name = "Auto_Move" };
			i = new BeckhoffShort(this.Geti, client, 16448, 1167916){ Name = "i" };
			H_DelayOn = new BeckhoffStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON>(this.GetH_DelayOn, client, 16448, 1167920,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1167920 ,1167952 ,1167984 ,1168016 ,1168048 ,1168080 ,1168112 ,1168144 ,1168176 ,1168208 ,1168240 ,1168272 ,1168304 ,1168336 ,1168368 ,1168400 ,1168432 ,1168464 ,1168496 ,1168528 , },
				new Tc2_Standard_TONWrapper[]
				{
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn0, client, 16448, 1167920)
					{
						 Name = "Item_1",
						IN = new BeckhoffBool(this.GetH_DelayOn0_Dot_IN, client, 16448, 1167928){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn0_Dot_PT, client, 16448, 1167932){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn0_Dot_Q, client, 16448, 1167936){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn0_Dot_ET, client, 16448, 1167940){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn0_Dot_M, client, 16448, 1167944){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn0_Dot_StartTime, client, 16448, 1167948){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn1, client, 16448, 1167952)
					{
						 Name = "Item_2",
						IN = new BeckhoffBool(this.GetH_DelayOn1_Dot_IN, client, 16448, 1167960){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn1_Dot_PT, client, 16448, 1167964){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn1_Dot_Q, client, 16448, 1167968){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn1_Dot_ET, client, 16448, 1167972){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn1_Dot_M, client, 16448, 1167976){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn1_Dot_StartTime, client, 16448, 1167980){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn2, client, 16448, 1167984)
					{
						 Name = "Item_3",
						IN = new BeckhoffBool(this.GetH_DelayOn2_Dot_IN, client, 16448, 1167992){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn2_Dot_PT, client, 16448, 1167996){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn2_Dot_Q, client, 16448, 1168000){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn2_Dot_ET, client, 16448, 1168004){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn2_Dot_M, client, 16448, 1168008){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn2_Dot_StartTime, client, 16448, 1168012){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn3, client, 16448, 1168016)
					{
						 Name = "Item_4",
						IN = new BeckhoffBool(this.GetH_DelayOn3_Dot_IN, client, 16448, 1168024){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn3_Dot_PT, client, 16448, 1168028){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn3_Dot_Q, client, 16448, 1168032){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn3_Dot_ET, client, 16448, 1168036){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn3_Dot_M, client, 16448, 1168040){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn3_Dot_StartTime, client, 16448, 1168044){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn4, client, 16448, 1168048)
					{
						 Name = "Item_5",
						IN = new BeckhoffBool(this.GetH_DelayOn4_Dot_IN, client, 16448, 1168056){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn4_Dot_PT, client, 16448, 1168060){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn4_Dot_Q, client, 16448, 1168064){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn4_Dot_ET, client, 16448, 1168068){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn4_Dot_M, client, 16448, 1168072){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn4_Dot_StartTime, client, 16448, 1168076){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn5, client, 16448, 1168080)
					{
						 Name = "Item_6",
						IN = new BeckhoffBool(this.GetH_DelayOn5_Dot_IN, client, 16448, 1168088){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn5_Dot_PT, client, 16448, 1168092){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn5_Dot_Q, client, 16448, 1168096){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn5_Dot_ET, client, 16448, 1168100){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn5_Dot_M, client, 16448, 1168104){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn5_Dot_StartTime, client, 16448, 1168108){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn6, client, 16448, 1168112)
					{
						 Name = "Item_7",
						IN = new BeckhoffBool(this.GetH_DelayOn6_Dot_IN, client, 16448, 1168120){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn6_Dot_PT, client, 16448, 1168124){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn6_Dot_Q, client, 16448, 1168128){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn6_Dot_ET, client, 16448, 1168132){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn6_Dot_M, client, 16448, 1168136){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn6_Dot_StartTime, client, 16448, 1168140){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn7, client, 16448, 1168144)
					{
						 Name = "Item_8",
						IN = new BeckhoffBool(this.GetH_DelayOn7_Dot_IN, client, 16448, 1168152){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn7_Dot_PT, client, 16448, 1168156){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn7_Dot_Q, client, 16448, 1168160){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn7_Dot_ET, client, 16448, 1168164){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn7_Dot_M, client, 16448, 1168168){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn7_Dot_StartTime, client, 16448, 1168172){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn8, client, 16448, 1168176)
					{
						 Name = "Item_9",
						IN = new BeckhoffBool(this.GetH_DelayOn8_Dot_IN, client, 16448, 1168184){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn8_Dot_PT, client, 16448, 1168188){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn8_Dot_Q, client, 16448, 1168192){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn8_Dot_ET, client, 16448, 1168196){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn8_Dot_M, client, 16448, 1168200){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn8_Dot_StartTime, client, 16448, 1168204){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn9, client, 16448, 1168208)
					{
						 Name = "Item_10",
						IN = new BeckhoffBool(this.GetH_DelayOn9_Dot_IN, client, 16448, 1168216){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn9_Dot_PT, client, 16448, 1168220){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn9_Dot_Q, client, 16448, 1168224){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn9_Dot_ET, client, 16448, 1168228){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn9_Dot_M, client, 16448, 1168232){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn9_Dot_StartTime, client, 16448, 1168236){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn10, client, 16448, 1168240)
					{
						 Name = "Item_11",
						IN = new BeckhoffBool(this.GetH_DelayOn10_Dot_IN, client, 16448, 1168248){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn10_Dot_PT, client, 16448, 1168252){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn10_Dot_Q, client, 16448, 1168256){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn10_Dot_ET, client, 16448, 1168260){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn10_Dot_M, client, 16448, 1168264){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn10_Dot_StartTime, client, 16448, 1168268){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn11, client, 16448, 1168272)
					{
						 Name = "Item_12",
						IN = new BeckhoffBool(this.GetH_DelayOn11_Dot_IN, client, 16448, 1168280){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn11_Dot_PT, client, 16448, 1168284){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn11_Dot_Q, client, 16448, 1168288){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn11_Dot_ET, client, 16448, 1168292){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn11_Dot_M, client, 16448, 1168296){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn11_Dot_StartTime, client, 16448, 1168300){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn12, client, 16448, 1168304)
					{
						 Name = "Item_13",
						IN = new BeckhoffBool(this.GetH_DelayOn12_Dot_IN, client, 16448, 1168312){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn12_Dot_PT, client, 16448, 1168316){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn12_Dot_Q, client, 16448, 1168320){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn12_Dot_ET, client, 16448, 1168324){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn12_Dot_M, client, 16448, 1168328){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn12_Dot_StartTime, client, 16448, 1168332){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn13, client, 16448, 1168336)
					{
						 Name = "Item_14",
						IN = new BeckhoffBool(this.GetH_DelayOn13_Dot_IN, client, 16448, 1168344){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn13_Dot_PT, client, 16448, 1168348){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn13_Dot_Q, client, 16448, 1168352){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn13_Dot_ET, client, 16448, 1168356){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn13_Dot_M, client, 16448, 1168360){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn13_Dot_StartTime, client, 16448, 1168364){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn14, client, 16448, 1168368)
					{
						 Name = "Item_15",
						IN = new BeckhoffBool(this.GetH_DelayOn14_Dot_IN, client, 16448, 1168376){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn14_Dot_PT, client, 16448, 1168380){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn14_Dot_Q, client, 16448, 1168384){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn14_Dot_ET, client, 16448, 1168388){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn14_Dot_M, client, 16448, 1168392){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn14_Dot_StartTime, client, 16448, 1168396){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn15, client, 16448, 1168400)
					{
						 Name = "Item_16",
						IN = new BeckhoffBool(this.GetH_DelayOn15_Dot_IN, client, 16448, 1168408){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn15_Dot_PT, client, 16448, 1168412){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn15_Dot_Q, client, 16448, 1168416){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn15_Dot_ET, client, 16448, 1168420){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn15_Dot_M, client, 16448, 1168424){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn15_Dot_StartTime, client, 16448, 1168428){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn16, client, 16448, 1168432)
					{
						 Name = "Item_17",
						IN = new BeckhoffBool(this.GetH_DelayOn16_Dot_IN, client, 16448, 1168440){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn16_Dot_PT, client, 16448, 1168444){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn16_Dot_Q, client, 16448, 1168448){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn16_Dot_ET, client, 16448, 1168452){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn16_Dot_M, client, 16448, 1168456){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn16_Dot_StartTime, client, 16448, 1168460){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn17, client, 16448, 1168464)
					{
						 Name = "Item_18",
						IN = new BeckhoffBool(this.GetH_DelayOn17_Dot_IN, client, 16448, 1168472){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn17_Dot_PT, client, 16448, 1168476){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn17_Dot_Q, client, 16448, 1168480){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn17_Dot_ET, client, 16448, 1168484){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn17_Dot_M, client, 16448, 1168488){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn17_Dot_StartTime, client, 16448, 1168492){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn18, client, 16448, 1168496)
					{
						 Name = "Item_19",
						IN = new BeckhoffBool(this.GetH_DelayOn18_Dot_IN, client, 16448, 1168504){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn18_Dot_PT, client, 16448, 1168508){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn18_Dot_Q, client, 16448, 1168512){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn18_Dot_ET, client, 16448, 1168516){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn18_Dot_M, client, 16448, 1168520){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn18_Dot_StartTime, client, 16448, 1168524){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn19, client, 16448, 1168528)
					{
						 Name = "Item_20",
						IN = new BeckhoffBool(this.GetH_DelayOn19_Dot_IN, client, 16448, 1168536){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn19_Dot_PT, client, 16448, 1168540){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn19_Dot_Q, client, 16448, 1168544){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn19_Dot_ET, client, 16448, 1168548){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn19_Dot_M, client, 16448, 1168552){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn19_Dot_StartTime, client, 16448, 1168556){ Name = "StartTime" },
					},
			}, false){ Name = "H_DelayOn" };
			H_TrigOn = new BeckhoffStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG>(this.GetH_TrigOn, client, 16448, 1168560,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1168560 ,1168576 ,1168592 ,1168608 ,1168624 ,1168640 ,1168656 ,1168672 ,1168688 ,1168704 ,1168720 ,1168736 ,1168752 ,1168768 ,1168784 ,1168800 ,1168816 ,1168832 ,1168848 ,1168864 , },
				new Tc2_Standard_R_TRIGWrapper[]
				{
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn0, client, 16448, 1168560)
					{
						 Name = "Item_1",
						CLK = new BeckhoffBool(this.GetH_TrigOn0_Dot_CLK, client, 16448, 1168568){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn0_Dot_Q, client, 16448, 1168569){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn0_Dot_M, client, 16448, 1168570){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn1, client, 16448, 1168576)
					{
						 Name = "Item_2",
						CLK = new BeckhoffBool(this.GetH_TrigOn1_Dot_CLK, client, 16448, 1168584){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn1_Dot_Q, client, 16448, 1168585){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn1_Dot_M, client, 16448, 1168586){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn2, client, 16448, 1168592)
					{
						 Name = "Item_3",
						CLK = new BeckhoffBool(this.GetH_TrigOn2_Dot_CLK, client, 16448, 1168600){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn2_Dot_Q, client, 16448, 1168601){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn2_Dot_M, client, 16448, 1168602){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn3, client, 16448, 1168608)
					{
						 Name = "Item_4",
						CLK = new BeckhoffBool(this.GetH_TrigOn3_Dot_CLK, client, 16448, 1168616){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn3_Dot_Q, client, 16448, 1168617){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn3_Dot_M, client, 16448, 1168618){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn4, client, 16448, 1168624)
					{
						 Name = "Item_5",
						CLK = new BeckhoffBool(this.GetH_TrigOn4_Dot_CLK, client, 16448, 1168632){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn4_Dot_Q, client, 16448, 1168633){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn4_Dot_M, client, 16448, 1168634){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn5, client, 16448, 1168640)
					{
						 Name = "Item_6",
						CLK = new BeckhoffBool(this.GetH_TrigOn5_Dot_CLK, client, 16448, 1168648){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn5_Dot_Q, client, 16448, 1168649){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn5_Dot_M, client, 16448, 1168650){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn6, client, 16448, 1168656)
					{
						 Name = "Item_7",
						CLK = new BeckhoffBool(this.GetH_TrigOn6_Dot_CLK, client, 16448, 1168664){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn6_Dot_Q, client, 16448, 1168665){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn6_Dot_M, client, 16448, 1168666){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn7, client, 16448, 1168672)
					{
						 Name = "Item_8",
						CLK = new BeckhoffBool(this.GetH_TrigOn7_Dot_CLK, client, 16448, 1168680){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn7_Dot_Q, client, 16448, 1168681){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn7_Dot_M, client, 16448, 1168682){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn8, client, 16448, 1168688)
					{
						 Name = "Item_9",
						CLK = new BeckhoffBool(this.GetH_TrigOn8_Dot_CLK, client, 16448, 1168696){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn8_Dot_Q, client, 16448, 1168697){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn8_Dot_M, client, 16448, 1168698){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn9, client, 16448, 1168704)
					{
						 Name = "Item_10",
						CLK = new BeckhoffBool(this.GetH_TrigOn9_Dot_CLK, client, 16448, 1168712){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn9_Dot_Q, client, 16448, 1168713){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn9_Dot_M, client, 16448, 1168714){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn10, client, 16448, 1168720)
					{
						 Name = "Item_11",
						CLK = new BeckhoffBool(this.GetH_TrigOn10_Dot_CLK, client, 16448, 1168728){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn10_Dot_Q, client, 16448, 1168729){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn10_Dot_M, client, 16448, 1168730){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn11, client, 16448, 1168736)
					{
						 Name = "Item_12",
						CLK = new BeckhoffBool(this.GetH_TrigOn11_Dot_CLK, client, 16448, 1168744){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn11_Dot_Q, client, 16448, 1168745){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn11_Dot_M, client, 16448, 1168746){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn12, client, 16448, 1168752)
					{
						 Name = "Item_13",
						CLK = new BeckhoffBool(this.GetH_TrigOn12_Dot_CLK, client, 16448, 1168760){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn12_Dot_Q, client, 16448, 1168761){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn12_Dot_M, client, 16448, 1168762){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn13, client, 16448, 1168768)
					{
						 Name = "Item_14",
						CLK = new BeckhoffBool(this.GetH_TrigOn13_Dot_CLK, client, 16448, 1168776){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn13_Dot_Q, client, 16448, 1168777){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn13_Dot_M, client, 16448, 1168778){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn14, client, 16448, 1168784)
					{
						 Name = "Item_15",
						CLK = new BeckhoffBool(this.GetH_TrigOn14_Dot_CLK, client, 16448, 1168792){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn14_Dot_Q, client, 16448, 1168793){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn14_Dot_M, client, 16448, 1168794){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn15, client, 16448, 1168800)
					{
						 Name = "Item_16",
						CLK = new BeckhoffBool(this.GetH_TrigOn15_Dot_CLK, client, 16448, 1168808){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn15_Dot_Q, client, 16448, 1168809){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn15_Dot_M, client, 16448, 1168810){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn16, client, 16448, 1168816)
					{
						 Name = "Item_17",
						CLK = new BeckhoffBool(this.GetH_TrigOn16_Dot_CLK, client, 16448, 1168824){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn16_Dot_Q, client, 16448, 1168825){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn16_Dot_M, client, 16448, 1168826){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn17, client, 16448, 1168832)
					{
						 Name = "Item_18",
						CLK = new BeckhoffBool(this.GetH_TrigOn17_Dot_CLK, client, 16448, 1168840){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn17_Dot_Q, client, 16448, 1168841){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn17_Dot_M, client, 16448, 1168842){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn18, client, 16448, 1168848)
					{
						 Name = "Item_19",
						CLK = new BeckhoffBool(this.GetH_TrigOn18_Dot_CLK, client, 16448, 1168856){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn18_Dot_Q, client, 16448, 1168857){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn18_Dot_M, client, 16448, 1168858){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn19, client, 16448, 1168864)
					{
						 Name = "Item_20",
						CLK = new BeckhoffBool(this.GetH_TrigOn19_Dot_CLK, client, 16448, 1168872){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn19_Dot_Q, client, 16448, 1168873){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn19_Dot_M, client, 16448, 1168874){ Name = "M" },
					},
			}, false){ Name = "H_TrigOn" };
			L_DelayOn = new BeckhoffStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON>(this.GetL_DelayOn, client, 16448, 1168880,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1168880 ,1168912 ,1168944 ,1168976 ,1169008 ,1169040 ,1169072 ,1169104 ,1169136 ,1169168 ,1169200 ,1169232 ,1169264 ,1169296 ,1169328 ,1169360 ,1169392 ,1169424 ,1169456 ,1169488 , },
				new Tc2_Standard_TONWrapper[]
				{
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn0, client, 16448, 1168880)
					{
						 Name = "Item_1",
						IN = new BeckhoffBool(this.GetL_DelayOn0_Dot_IN, client, 16448, 1168888){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn0_Dot_PT, client, 16448, 1168892){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn0_Dot_Q, client, 16448, 1168896){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn0_Dot_ET, client, 16448, 1168900){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn0_Dot_M, client, 16448, 1168904){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn0_Dot_StartTime, client, 16448, 1168908){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn1, client, 16448, 1168912)
					{
						 Name = "Item_2",
						IN = new BeckhoffBool(this.GetL_DelayOn1_Dot_IN, client, 16448, 1168920){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn1_Dot_PT, client, 16448, 1168924){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn1_Dot_Q, client, 16448, 1168928){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn1_Dot_ET, client, 16448, 1168932){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn1_Dot_M, client, 16448, 1168936){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn1_Dot_StartTime, client, 16448, 1168940){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn2, client, 16448, 1168944)
					{
						 Name = "Item_3",
						IN = new BeckhoffBool(this.GetL_DelayOn2_Dot_IN, client, 16448, 1168952){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn2_Dot_PT, client, 16448, 1168956){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn2_Dot_Q, client, 16448, 1168960){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn2_Dot_ET, client, 16448, 1168964){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn2_Dot_M, client, 16448, 1168968){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn2_Dot_StartTime, client, 16448, 1168972){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn3, client, 16448, 1168976)
					{
						 Name = "Item_4",
						IN = new BeckhoffBool(this.GetL_DelayOn3_Dot_IN, client, 16448, 1168984){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn3_Dot_PT, client, 16448, 1168988){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn3_Dot_Q, client, 16448, 1168992){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn3_Dot_ET, client, 16448, 1168996){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn3_Dot_M, client, 16448, 1169000){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn3_Dot_StartTime, client, 16448, 1169004){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn4, client, 16448, 1169008)
					{
						 Name = "Item_5",
						IN = new BeckhoffBool(this.GetL_DelayOn4_Dot_IN, client, 16448, 1169016){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn4_Dot_PT, client, 16448, 1169020){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn4_Dot_Q, client, 16448, 1169024){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn4_Dot_ET, client, 16448, 1169028){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn4_Dot_M, client, 16448, 1169032){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn4_Dot_StartTime, client, 16448, 1169036){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn5, client, 16448, 1169040)
					{
						 Name = "Item_6",
						IN = new BeckhoffBool(this.GetL_DelayOn5_Dot_IN, client, 16448, 1169048){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn5_Dot_PT, client, 16448, 1169052){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn5_Dot_Q, client, 16448, 1169056){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn5_Dot_ET, client, 16448, 1169060){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn5_Dot_M, client, 16448, 1169064){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn5_Dot_StartTime, client, 16448, 1169068){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn6, client, 16448, 1169072)
					{
						 Name = "Item_7",
						IN = new BeckhoffBool(this.GetL_DelayOn6_Dot_IN, client, 16448, 1169080){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn6_Dot_PT, client, 16448, 1169084){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn6_Dot_Q, client, 16448, 1169088){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn6_Dot_ET, client, 16448, 1169092){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn6_Dot_M, client, 16448, 1169096){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn6_Dot_StartTime, client, 16448, 1169100){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn7, client, 16448, 1169104)
					{
						 Name = "Item_8",
						IN = new BeckhoffBool(this.GetL_DelayOn7_Dot_IN, client, 16448, 1169112){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn7_Dot_PT, client, 16448, 1169116){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn7_Dot_Q, client, 16448, 1169120){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn7_Dot_ET, client, 16448, 1169124){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn7_Dot_M, client, 16448, 1169128){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn7_Dot_StartTime, client, 16448, 1169132){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn8, client, 16448, 1169136)
					{
						 Name = "Item_9",
						IN = new BeckhoffBool(this.GetL_DelayOn8_Dot_IN, client, 16448, 1169144){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn8_Dot_PT, client, 16448, 1169148){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn8_Dot_Q, client, 16448, 1169152){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn8_Dot_ET, client, 16448, 1169156){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn8_Dot_M, client, 16448, 1169160){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn8_Dot_StartTime, client, 16448, 1169164){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn9, client, 16448, 1169168)
					{
						 Name = "Item_10",
						IN = new BeckhoffBool(this.GetL_DelayOn9_Dot_IN, client, 16448, 1169176){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn9_Dot_PT, client, 16448, 1169180){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn9_Dot_Q, client, 16448, 1169184){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn9_Dot_ET, client, 16448, 1169188){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn9_Dot_M, client, 16448, 1169192){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn9_Dot_StartTime, client, 16448, 1169196){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn10, client, 16448, 1169200)
					{
						 Name = "Item_11",
						IN = new BeckhoffBool(this.GetL_DelayOn10_Dot_IN, client, 16448, 1169208){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn10_Dot_PT, client, 16448, 1169212){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn10_Dot_Q, client, 16448, 1169216){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn10_Dot_ET, client, 16448, 1169220){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn10_Dot_M, client, 16448, 1169224){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn10_Dot_StartTime, client, 16448, 1169228){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn11, client, 16448, 1169232)
					{
						 Name = "Item_12",
						IN = new BeckhoffBool(this.GetL_DelayOn11_Dot_IN, client, 16448, 1169240){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn11_Dot_PT, client, 16448, 1169244){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn11_Dot_Q, client, 16448, 1169248){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn11_Dot_ET, client, 16448, 1169252){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn11_Dot_M, client, 16448, 1169256){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn11_Dot_StartTime, client, 16448, 1169260){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn12, client, 16448, 1169264)
					{
						 Name = "Item_13",
						IN = new BeckhoffBool(this.GetL_DelayOn12_Dot_IN, client, 16448, 1169272){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn12_Dot_PT, client, 16448, 1169276){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn12_Dot_Q, client, 16448, 1169280){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn12_Dot_ET, client, 16448, 1169284){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn12_Dot_M, client, 16448, 1169288){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn12_Dot_StartTime, client, 16448, 1169292){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn13, client, 16448, 1169296)
					{
						 Name = "Item_14",
						IN = new BeckhoffBool(this.GetL_DelayOn13_Dot_IN, client, 16448, 1169304){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn13_Dot_PT, client, 16448, 1169308){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn13_Dot_Q, client, 16448, 1169312){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn13_Dot_ET, client, 16448, 1169316){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn13_Dot_M, client, 16448, 1169320){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn13_Dot_StartTime, client, 16448, 1169324){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn14, client, 16448, 1169328)
					{
						 Name = "Item_15",
						IN = new BeckhoffBool(this.GetL_DelayOn14_Dot_IN, client, 16448, 1169336){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn14_Dot_PT, client, 16448, 1169340){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn14_Dot_Q, client, 16448, 1169344){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn14_Dot_ET, client, 16448, 1169348){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn14_Dot_M, client, 16448, 1169352){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn14_Dot_StartTime, client, 16448, 1169356){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn15, client, 16448, 1169360)
					{
						 Name = "Item_16",
						IN = new BeckhoffBool(this.GetL_DelayOn15_Dot_IN, client, 16448, 1169368){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn15_Dot_PT, client, 16448, 1169372){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn15_Dot_Q, client, 16448, 1169376){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn15_Dot_ET, client, 16448, 1169380){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn15_Dot_M, client, 16448, 1169384){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn15_Dot_StartTime, client, 16448, 1169388){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn16, client, 16448, 1169392)
					{
						 Name = "Item_17",
						IN = new BeckhoffBool(this.GetL_DelayOn16_Dot_IN, client, 16448, 1169400){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn16_Dot_PT, client, 16448, 1169404){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn16_Dot_Q, client, 16448, 1169408){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn16_Dot_ET, client, 16448, 1169412){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn16_Dot_M, client, 16448, 1169416){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn16_Dot_StartTime, client, 16448, 1169420){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn17, client, 16448, 1169424)
					{
						 Name = "Item_18",
						IN = new BeckhoffBool(this.GetL_DelayOn17_Dot_IN, client, 16448, 1169432){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn17_Dot_PT, client, 16448, 1169436){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn17_Dot_Q, client, 16448, 1169440){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn17_Dot_ET, client, 16448, 1169444){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn17_Dot_M, client, 16448, 1169448){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn17_Dot_StartTime, client, 16448, 1169452){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn18, client, 16448, 1169456)
					{
						 Name = "Item_19",
						IN = new BeckhoffBool(this.GetL_DelayOn18_Dot_IN, client, 16448, 1169464){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn18_Dot_PT, client, 16448, 1169468){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn18_Dot_Q, client, 16448, 1169472){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn18_Dot_ET, client, 16448, 1169476){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn18_Dot_M, client, 16448, 1169480){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn18_Dot_StartTime, client, 16448, 1169484){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn19, client, 16448, 1169488)
					{
						 Name = "Item_20",
						IN = new BeckhoffBool(this.GetL_DelayOn19_Dot_IN, client, 16448, 1169496){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn19_Dot_PT, client, 16448, 1169500){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn19_Dot_Q, client, 16448, 1169504){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn19_Dot_ET, client, 16448, 1169508){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn19_Dot_M, client, 16448, 1169512){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn19_Dot_StartTime, client, 16448, 1169516){ Name = "StartTime" },
					},
			}, false){ Name = "L_DelayOn" };
			L_TrigOn = new BeckhoffStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG>(this.GetL_TrigOn, client, 16448, 1169520,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1169520 ,1169536 ,1169552 ,1169568 ,1169584 ,1169600 ,1169616 ,1169632 ,1169648 ,1169664 ,1169680 ,1169696 ,1169712 ,1169728 ,1169744 ,1169760 ,1169776 ,1169792 ,1169808 ,1169824 , },
				new Tc2_Standard_R_TRIGWrapper[]
				{
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn0, client, 16448, 1169520)
					{
						 Name = "Item_1",
						CLK = new BeckhoffBool(this.GetL_TrigOn0_Dot_CLK, client, 16448, 1169528){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn0_Dot_Q, client, 16448, 1169529){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn0_Dot_M, client, 16448, 1169530){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn1, client, 16448, 1169536)
					{
						 Name = "Item_2",
						CLK = new BeckhoffBool(this.GetL_TrigOn1_Dot_CLK, client, 16448, 1169544){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn1_Dot_Q, client, 16448, 1169545){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn1_Dot_M, client, 16448, 1169546){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn2, client, 16448, 1169552)
					{
						 Name = "Item_3",
						CLK = new BeckhoffBool(this.GetL_TrigOn2_Dot_CLK, client, 16448, 1169560){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn2_Dot_Q, client, 16448, 1169561){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn2_Dot_M, client, 16448, 1169562){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn3, client, 16448, 1169568)
					{
						 Name = "Item_4",
						CLK = new BeckhoffBool(this.GetL_TrigOn3_Dot_CLK, client, 16448, 1169576){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn3_Dot_Q, client, 16448, 1169577){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn3_Dot_M, client, 16448, 1169578){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn4, client, 16448, 1169584)
					{
						 Name = "Item_5",
						CLK = new BeckhoffBool(this.GetL_TrigOn4_Dot_CLK, client, 16448, 1169592){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn4_Dot_Q, client, 16448, 1169593){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn4_Dot_M, client, 16448, 1169594){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn5, client, 16448, 1169600)
					{
						 Name = "Item_6",
						CLK = new BeckhoffBool(this.GetL_TrigOn5_Dot_CLK, client, 16448, 1169608){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn5_Dot_Q, client, 16448, 1169609){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn5_Dot_M, client, 16448, 1169610){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn6, client, 16448, 1169616)
					{
						 Name = "Item_7",
						CLK = new BeckhoffBool(this.GetL_TrigOn6_Dot_CLK, client, 16448, 1169624){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn6_Dot_Q, client, 16448, 1169625){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn6_Dot_M, client, 16448, 1169626){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn7, client, 16448, 1169632)
					{
						 Name = "Item_8",
						CLK = new BeckhoffBool(this.GetL_TrigOn7_Dot_CLK, client, 16448, 1169640){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn7_Dot_Q, client, 16448, 1169641){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn7_Dot_M, client, 16448, 1169642){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn8, client, 16448, 1169648)
					{
						 Name = "Item_9",
						CLK = new BeckhoffBool(this.GetL_TrigOn8_Dot_CLK, client, 16448, 1169656){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn8_Dot_Q, client, 16448, 1169657){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn8_Dot_M, client, 16448, 1169658){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn9, client, 16448, 1169664)
					{
						 Name = "Item_10",
						CLK = new BeckhoffBool(this.GetL_TrigOn9_Dot_CLK, client, 16448, 1169672){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn9_Dot_Q, client, 16448, 1169673){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn9_Dot_M, client, 16448, 1169674){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn10, client, 16448, 1169680)
					{
						 Name = "Item_11",
						CLK = new BeckhoffBool(this.GetL_TrigOn10_Dot_CLK, client, 16448, 1169688){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn10_Dot_Q, client, 16448, 1169689){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn10_Dot_M, client, 16448, 1169690){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn11, client, 16448, 1169696)
					{
						 Name = "Item_12",
						CLK = new BeckhoffBool(this.GetL_TrigOn11_Dot_CLK, client, 16448, 1169704){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn11_Dot_Q, client, 16448, 1169705){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn11_Dot_M, client, 16448, 1169706){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn12, client, 16448, 1169712)
					{
						 Name = "Item_13",
						CLK = new BeckhoffBool(this.GetL_TrigOn12_Dot_CLK, client, 16448, 1169720){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn12_Dot_Q, client, 16448, 1169721){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn12_Dot_M, client, 16448, 1169722){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn13, client, 16448, 1169728)
					{
						 Name = "Item_14",
						CLK = new BeckhoffBool(this.GetL_TrigOn13_Dot_CLK, client, 16448, 1169736){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn13_Dot_Q, client, 16448, 1169737){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn13_Dot_M, client, 16448, 1169738){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn14, client, 16448, 1169744)
					{
						 Name = "Item_15",
						CLK = new BeckhoffBool(this.GetL_TrigOn14_Dot_CLK, client, 16448, 1169752){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn14_Dot_Q, client, 16448, 1169753){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn14_Dot_M, client, 16448, 1169754){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn15, client, 16448, 1169760)
					{
						 Name = "Item_16",
						CLK = new BeckhoffBool(this.GetL_TrigOn15_Dot_CLK, client, 16448, 1169768){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn15_Dot_Q, client, 16448, 1169769){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn15_Dot_M, client, 16448, 1169770){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn16, client, 16448, 1169776)
					{
						 Name = "Item_17",
						CLK = new BeckhoffBool(this.GetL_TrigOn16_Dot_CLK, client, 16448, 1169784){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn16_Dot_Q, client, 16448, 1169785){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn16_Dot_M, client, 16448, 1169786){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn17, client, 16448, 1169792)
					{
						 Name = "Item_18",
						CLK = new BeckhoffBool(this.GetL_TrigOn17_Dot_CLK, client, 16448, 1169800){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn17_Dot_Q, client, 16448, 1169801){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn17_Dot_M, client, 16448, 1169802){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn18, client, 16448, 1169808)
					{
						 Name = "Item_19",
						CLK = new BeckhoffBool(this.GetL_TrigOn18_Dot_CLK, client, 16448, 1169816){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn18_Dot_Q, client, 16448, 1169817){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn18_Dot_M, client, 16448, 1169818){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn19, client, 16448, 1169824)
					{
						 Name = "Item_20",
						CLK = new BeckhoffBool(this.GetL_TrigOn19_Dot_CLK, client, 16448, 1169832){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn19_Dot_Q, client, 16448, 1169833){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn19_Dot_M, client, 16448, 1169834){ Name = "M" },
					},
			}, false){ Name = "L_TrigOn" };
			UL_DelayOn = new BeckhoffStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON>(this.GetUL_DelayOn, client, 16448, 1169840,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1169840 ,1169872 ,1169904 ,1169936 ,1169968 ,1170000 ,1170032 ,1170064 ,1170096 ,1170128 ,1170160 ,1170192 ,1170224 ,1170256 ,1170288 ,1170320 ,1170352 ,1170384 ,1170416 ,1170448 , },
				new Tc2_Standard_TONWrapper[]
				{
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn0, client, 16448, 1169840)
					{
						 Name = "Item_1",
						IN = new BeckhoffBool(this.GetUL_DelayOn0_Dot_IN, client, 16448, 1169848){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn0_Dot_PT, client, 16448, 1169852){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn0_Dot_Q, client, 16448, 1169856){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn0_Dot_ET, client, 16448, 1169860){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn0_Dot_M, client, 16448, 1169864){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn0_Dot_StartTime, client, 16448, 1169868){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn1, client, 16448, 1169872)
					{
						 Name = "Item_2",
						IN = new BeckhoffBool(this.GetUL_DelayOn1_Dot_IN, client, 16448, 1169880){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn1_Dot_PT, client, 16448, 1169884){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn1_Dot_Q, client, 16448, 1169888){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn1_Dot_ET, client, 16448, 1169892){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn1_Dot_M, client, 16448, 1169896){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn1_Dot_StartTime, client, 16448, 1169900){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn2, client, 16448, 1169904)
					{
						 Name = "Item_3",
						IN = new BeckhoffBool(this.GetUL_DelayOn2_Dot_IN, client, 16448, 1169912){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn2_Dot_PT, client, 16448, 1169916){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn2_Dot_Q, client, 16448, 1169920){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn2_Dot_ET, client, 16448, 1169924){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn2_Dot_M, client, 16448, 1169928){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn2_Dot_StartTime, client, 16448, 1169932){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn3, client, 16448, 1169936)
					{
						 Name = "Item_4",
						IN = new BeckhoffBool(this.GetUL_DelayOn3_Dot_IN, client, 16448, 1169944){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn3_Dot_PT, client, 16448, 1169948){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn3_Dot_Q, client, 16448, 1169952){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn3_Dot_ET, client, 16448, 1169956){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn3_Dot_M, client, 16448, 1169960){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn3_Dot_StartTime, client, 16448, 1169964){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn4, client, 16448, 1169968)
					{
						 Name = "Item_5",
						IN = new BeckhoffBool(this.GetUL_DelayOn4_Dot_IN, client, 16448, 1169976){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn4_Dot_PT, client, 16448, 1169980){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn4_Dot_Q, client, 16448, 1169984){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn4_Dot_ET, client, 16448, 1169988){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn4_Dot_M, client, 16448, 1169992){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn4_Dot_StartTime, client, 16448, 1169996){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn5, client, 16448, 1170000)
					{
						 Name = "Item_6",
						IN = new BeckhoffBool(this.GetUL_DelayOn5_Dot_IN, client, 16448, 1170008){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn5_Dot_PT, client, 16448, 1170012){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn5_Dot_Q, client, 16448, 1170016){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn5_Dot_ET, client, 16448, 1170020){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn5_Dot_M, client, 16448, 1170024){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn5_Dot_StartTime, client, 16448, 1170028){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn6, client, 16448, 1170032)
					{
						 Name = "Item_7",
						IN = new BeckhoffBool(this.GetUL_DelayOn6_Dot_IN, client, 16448, 1170040){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn6_Dot_PT, client, 16448, 1170044){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn6_Dot_Q, client, 16448, 1170048){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn6_Dot_ET, client, 16448, 1170052){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn6_Dot_M, client, 16448, 1170056){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn6_Dot_StartTime, client, 16448, 1170060){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn7, client, 16448, 1170064)
					{
						 Name = "Item_8",
						IN = new BeckhoffBool(this.GetUL_DelayOn7_Dot_IN, client, 16448, 1170072){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn7_Dot_PT, client, 16448, 1170076){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn7_Dot_Q, client, 16448, 1170080){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn7_Dot_ET, client, 16448, 1170084){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn7_Dot_M, client, 16448, 1170088){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn7_Dot_StartTime, client, 16448, 1170092){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn8, client, 16448, 1170096)
					{
						 Name = "Item_9",
						IN = new BeckhoffBool(this.GetUL_DelayOn8_Dot_IN, client, 16448, 1170104){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn8_Dot_PT, client, 16448, 1170108){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn8_Dot_Q, client, 16448, 1170112){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn8_Dot_ET, client, 16448, 1170116){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn8_Dot_M, client, 16448, 1170120){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn8_Dot_StartTime, client, 16448, 1170124){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn9, client, 16448, 1170128)
					{
						 Name = "Item_10",
						IN = new BeckhoffBool(this.GetUL_DelayOn9_Dot_IN, client, 16448, 1170136){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn9_Dot_PT, client, 16448, 1170140){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn9_Dot_Q, client, 16448, 1170144){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn9_Dot_ET, client, 16448, 1170148){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn9_Dot_M, client, 16448, 1170152){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn9_Dot_StartTime, client, 16448, 1170156){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn10, client, 16448, 1170160)
					{
						 Name = "Item_11",
						IN = new BeckhoffBool(this.GetUL_DelayOn10_Dot_IN, client, 16448, 1170168){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn10_Dot_PT, client, 16448, 1170172){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn10_Dot_Q, client, 16448, 1170176){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn10_Dot_ET, client, 16448, 1170180){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn10_Dot_M, client, 16448, 1170184){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn10_Dot_StartTime, client, 16448, 1170188){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn11, client, 16448, 1170192)
					{
						 Name = "Item_12",
						IN = new BeckhoffBool(this.GetUL_DelayOn11_Dot_IN, client, 16448, 1170200){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn11_Dot_PT, client, 16448, 1170204){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn11_Dot_Q, client, 16448, 1170208){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn11_Dot_ET, client, 16448, 1170212){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn11_Dot_M, client, 16448, 1170216){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn11_Dot_StartTime, client, 16448, 1170220){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn12, client, 16448, 1170224)
					{
						 Name = "Item_13",
						IN = new BeckhoffBool(this.GetUL_DelayOn12_Dot_IN, client, 16448, 1170232){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn12_Dot_PT, client, 16448, 1170236){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn12_Dot_Q, client, 16448, 1170240){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn12_Dot_ET, client, 16448, 1170244){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn12_Dot_M, client, 16448, 1170248){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn12_Dot_StartTime, client, 16448, 1170252){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn13, client, 16448, 1170256)
					{
						 Name = "Item_14",
						IN = new BeckhoffBool(this.GetUL_DelayOn13_Dot_IN, client, 16448, 1170264){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn13_Dot_PT, client, 16448, 1170268){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn13_Dot_Q, client, 16448, 1170272){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn13_Dot_ET, client, 16448, 1170276){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn13_Dot_M, client, 16448, 1170280){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn13_Dot_StartTime, client, 16448, 1170284){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn14, client, 16448, 1170288)
					{
						 Name = "Item_15",
						IN = new BeckhoffBool(this.GetUL_DelayOn14_Dot_IN, client, 16448, 1170296){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn14_Dot_PT, client, 16448, 1170300){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn14_Dot_Q, client, 16448, 1170304){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn14_Dot_ET, client, 16448, 1170308){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn14_Dot_M, client, 16448, 1170312){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn14_Dot_StartTime, client, 16448, 1170316){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn15, client, 16448, 1170320)
					{
						 Name = "Item_16",
						IN = new BeckhoffBool(this.GetUL_DelayOn15_Dot_IN, client, 16448, 1170328){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn15_Dot_PT, client, 16448, 1170332){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn15_Dot_Q, client, 16448, 1170336){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn15_Dot_ET, client, 16448, 1170340){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn15_Dot_M, client, 16448, 1170344){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn15_Dot_StartTime, client, 16448, 1170348){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn16, client, 16448, 1170352)
					{
						 Name = "Item_17",
						IN = new BeckhoffBool(this.GetUL_DelayOn16_Dot_IN, client, 16448, 1170360){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn16_Dot_PT, client, 16448, 1170364){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn16_Dot_Q, client, 16448, 1170368){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn16_Dot_ET, client, 16448, 1170372){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn16_Dot_M, client, 16448, 1170376){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn16_Dot_StartTime, client, 16448, 1170380){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn17, client, 16448, 1170384)
					{
						 Name = "Item_18",
						IN = new BeckhoffBool(this.GetUL_DelayOn17_Dot_IN, client, 16448, 1170392){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn17_Dot_PT, client, 16448, 1170396){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn17_Dot_Q, client, 16448, 1170400){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn17_Dot_ET, client, 16448, 1170404){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn17_Dot_M, client, 16448, 1170408){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn17_Dot_StartTime, client, 16448, 1170412){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn18, client, 16448, 1170416)
					{
						 Name = "Item_19",
						IN = new BeckhoffBool(this.GetUL_DelayOn18_Dot_IN, client, 16448, 1170424){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn18_Dot_PT, client, 16448, 1170428){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn18_Dot_Q, client, 16448, 1170432){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn18_Dot_ET, client, 16448, 1170436){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn18_Dot_M, client, 16448, 1170440){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn18_Dot_StartTime, client, 16448, 1170444){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn19, client, 16448, 1170448)
					{
						 Name = "Item_20",
						IN = new BeckhoffBool(this.GetUL_DelayOn19_Dot_IN, client, 16448, 1170456){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn19_Dot_PT, client, 16448, 1170460){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn19_Dot_Q, client, 16448, 1170464){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn19_Dot_ET, client, 16448, 1170468){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn19_Dot_M, client, 16448, 1170472){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn19_Dot_StartTime, client, 16448, 1170476){ Name = "StartTime" },
					},
			}, false){ Name = "UL_DelayOn" };
			UL_TrigOn = new BeckhoffStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG>(this.GetUL_TrigOn, client, 16448, 1170480,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1170480 ,1170496 ,1170512 ,1170528 ,1170544 ,1170560 ,1170576 ,1170592 ,1170608 ,1170624 ,1170640 ,1170656 ,1170672 ,1170688 ,1170704 ,1170720 ,1170736 ,1170752 ,1170768 ,1170784 , },
				new Tc2_Standard_R_TRIGWrapper[]
				{
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn0, client, 16448, 1170480)
					{
						 Name = "Item_1",
						CLK = new BeckhoffBool(this.GetUL_TrigOn0_Dot_CLK, client, 16448, 1170488){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn0_Dot_Q, client, 16448, 1170489){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn0_Dot_M, client, 16448, 1170490){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn1, client, 16448, 1170496)
					{
						 Name = "Item_2",
						CLK = new BeckhoffBool(this.GetUL_TrigOn1_Dot_CLK, client, 16448, 1170504){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn1_Dot_Q, client, 16448, 1170505){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn1_Dot_M, client, 16448, 1170506){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn2, client, 16448, 1170512)
					{
						 Name = "Item_3",
						CLK = new BeckhoffBool(this.GetUL_TrigOn2_Dot_CLK, client, 16448, 1170520){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn2_Dot_Q, client, 16448, 1170521){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn2_Dot_M, client, 16448, 1170522){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn3, client, 16448, 1170528)
					{
						 Name = "Item_4",
						CLK = new BeckhoffBool(this.GetUL_TrigOn3_Dot_CLK, client, 16448, 1170536){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn3_Dot_Q, client, 16448, 1170537){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn3_Dot_M, client, 16448, 1170538){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn4, client, 16448, 1170544)
					{
						 Name = "Item_5",
						CLK = new BeckhoffBool(this.GetUL_TrigOn4_Dot_CLK, client, 16448, 1170552){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn4_Dot_Q, client, 16448, 1170553){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn4_Dot_M, client, 16448, 1170554){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn5, client, 16448, 1170560)
					{
						 Name = "Item_6",
						CLK = new BeckhoffBool(this.GetUL_TrigOn5_Dot_CLK, client, 16448, 1170568){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn5_Dot_Q, client, 16448, 1170569){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn5_Dot_M, client, 16448, 1170570){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn6, client, 16448, 1170576)
					{
						 Name = "Item_7",
						CLK = new BeckhoffBool(this.GetUL_TrigOn6_Dot_CLK, client, 16448, 1170584){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn6_Dot_Q, client, 16448, 1170585){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn6_Dot_M, client, 16448, 1170586){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn7, client, 16448, 1170592)
					{
						 Name = "Item_8",
						CLK = new BeckhoffBool(this.GetUL_TrigOn7_Dot_CLK, client, 16448, 1170600){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn7_Dot_Q, client, 16448, 1170601){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn7_Dot_M, client, 16448, 1170602){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn8, client, 16448, 1170608)
					{
						 Name = "Item_9",
						CLK = new BeckhoffBool(this.GetUL_TrigOn8_Dot_CLK, client, 16448, 1170616){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn8_Dot_Q, client, 16448, 1170617){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn8_Dot_M, client, 16448, 1170618){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn9, client, 16448, 1170624)
					{
						 Name = "Item_10",
						CLK = new BeckhoffBool(this.GetUL_TrigOn9_Dot_CLK, client, 16448, 1170632){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn9_Dot_Q, client, 16448, 1170633){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn9_Dot_M, client, 16448, 1170634){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn10, client, 16448, 1170640)
					{
						 Name = "Item_11",
						CLK = new BeckhoffBool(this.GetUL_TrigOn10_Dot_CLK, client, 16448, 1170648){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn10_Dot_Q, client, 16448, 1170649){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn10_Dot_M, client, 16448, 1170650){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn11, client, 16448, 1170656)
					{
						 Name = "Item_12",
						CLK = new BeckhoffBool(this.GetUL_TrigOn11_Dot_CLK, client, 16448, 1170664){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn11_Dot_Q, client, 16448, 1170665){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn11_Dot_M, client, 16448, 1170666){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn12, client, 16448, 1170672)
					{
						 Name = "Item_13",
						CLK = new BeckhoffBool(this.GetUL_TrigOn12_Dot_CLK, client, 16448, 1170680){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn12_Dot_Q, client, 16448, 1170681){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn12_Dot_M, client, 16448, 1170682){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn13, client, 16448, 1170688)
					{
						 Name = "Item_14",
						CLK = new BeckhoffBool(this.GetUL_TrigOn13_Dot_CLK, client, 16448, 1170696){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn13_Dot_Q, client, 16448, 1170697){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn13_Dot_M, client, 16448, 1170698){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn14, client, 16448, 1170704)
					{
						 Name = "Item_15",
						CLK = new BeckhoffBool(this.GetUL_TrigOn14_Dot_CLK, client, 16448, 1170712){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn14_Dot_Q, client, 16448, 1170713){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn14_Dot_M, client, 16448, 1170714){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn15, client, 16448, 1170720)
					{
						 Name = "Item_16",
						CLK = new BeckhoffBool(this.GetUL_TrigOn15_Dot_CLK, client, 16448, 1170728){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn15_Dot_Q, client, 16448, 1170729){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn15_Dot_M, client, 16448, 1170730){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn16, client, 16448, 1170736)
					{
						 Name = "Item_17",
						CLK = new BeckhoffBool(this.GetUL_TrigOn16_Dot_CLK, client, 16448, 1170744){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn16_Dot_Q, client, 16448, 1170745){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn16_Dot_M, client, 16448, 1170746){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn17, client, 16448, 1170752)
					{
						 Name = "Item_18",
						CLK = new BeckhoffBool(this.GetUL_TrigOn17_Dot_CLK, client, 16448, 1170760){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn17_Dot_Q, client, 16448, 1170761){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn17_Dot_M, client, 16448, 1170762){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn18, client, 16448, 1170768)
					{
						 Name = "Item_19",
						CLK = new BeckhoffBool(this.GetUL_TrigOn18_Dot_CLK, client, 16448, 1170776){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn18_Dot_Q, client, 16448, 1170777){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn18_Dot_M, client, 16448, 1170778){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn19, client, 16448, 1170784)
					{
						 Name = "Item_20",
						CLK = new BeckhoffBool(this.GetUL_TrigOn19_Dot_CLK, client, 16448, 1170792){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn19_Dot_Q, client, 16448, 1170793){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn19_Dot_M, client, 16448, 1170794){ Name = "M" },
					},
			}, false){ Name = "UL_TrigOn" };
			DelayOn = new BeckhoffStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON>(this.GetDelayOn, client, 16448, 1170800,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1170800 ,1170832 ,1170864 ,1170896 ,1170928 ,1170960 ,1170992 ,1171024 ,1171056 ,1171088 ,1171120 ,1171152 ,1171184 ,1171216 ,1171248 ,1171280 ,1171312 ,1171344 ,1171376 ,1171408 , },
				new Tc2_Standard_TONWrapper[]
				{
					new Tc2_Standard_TONWrapper(this.GetDelayOn0, client, 16448, 1170800)
					{
						 Name = "Item_1",
						IN = new BeckhoffBool(this.GetDelayOn0_Dot_IN, client, 16448, 1170808){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn0_Dot_PT, client, 16448, 1170812){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn0_Dot_Q, client, 16448, 1170816){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn0_Dot_ET, client, 16448, 1170820){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn0_Dot_M, client, 16448, 1170824){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn0_Dot_StartTime, client, 16448, 1170828){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn1, client, 16448, 1170832)
					{
						 Name = "Item_2",
						IN = new BeckhoffBool(this.GetDelayOn1_Dot_IN, client, 16448, 1170840){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn1_Dot_PT, client, 16448, 1170844){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn1_Dot_Q, client, 16448, 1170848){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn1_Dot_ET, client, 16448, 1170852){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn1_Dot_M, client, 16448, 1170856){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn1_Dot_StartTime, client, 16448, 1170860){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn2, client, 16448, 1170864)
					{
						 Name = "Item_3",
						IN = new BeckhoffBool(this.GetDelayOn2_Dot_IN, client, 16448, 1170872){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn2_Dot_PT, client, 16448, 1170876){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn2_Dot_Q, client, 16448, 1170880){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn2_Dot_ET, client, 16448, 1170884){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn2_Dot_M, client, 16448, 1170888){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn2_Dot_StartTime, client, 16448, 1170892){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn3, client, 16448, 1170896)
					{
						 Name = "Item_4",
						IN = new BeckhoffBool(this.GetDelayOn3_Dot_IN, client, 16448, 1170904){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn3_Dot_PT, client, 16448, 1170908){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn3_Dot_Q, client, 16448, 1170912){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn3_Dot_ET, client, 16448, 1170916){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn3_Dot_M, client, 16448, 1170920){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn3_Dot_StartTime, client, 16448, 1170924){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn4, client, 16448, 1170928)
					{
						 Name = "Item_5",
						IN = new BeckhoffBool(this.GetDelayOn4_Dot_IN, client, 16448, 1170936){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn4_Dot_PT, client, 16448, 1170940){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn4_Dot_Q, client, 16448, 1170944){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn4_Dot_ET, client, 16448, 1170948){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn4_Dot_M, client, 16448, 1170952){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn4_Dot_StartTime, client, 16448, 1170956){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn5, client, 16448, 1170960)
					{
						 Name = "Item_6",
						IN = new BeckhoffBool(this.GetDelayOn5_Dot_IN, client, 16448, 1170968){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn5_Dot_PT, client, 16448, 1170972){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn5_Dot_Q, client, 16448, 1170976){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn5_Dot_ET, client, 16448, 1170980){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn5_Dot_M, client, 16448, 1170984){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn5_Dot_StartTime, client, 16448, 1170988){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn6, client, 16448, 1170992)
					{
						 Name = "Item_7",
						IN = new BeckhoffBool(this.GetDelayOn6_Dot_IN, client, 16448, 1171000){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn6_Dot_PT, client, 16448, 1171004){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn6_Dot_Q, client, 16448, 1171008){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn6_Dot_ET, client, 16448, 1171012){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn6_Dot_M, client, 16448, 1171016){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn6_Dot_StartTime, client, 16448, 1171020){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn7, client, 16448, 1171024)
					{
						 Name = "Item_8",
						IN = new BeckhoffBool(this.GetDelayOn7_Dot_IN, client, 16448, 1171032){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn7_Dot_PT, client, 16448, 1171036){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn7_Dot_Q, client, 16448, 1171040){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn7_Dot_ET, client, 16448, 1171044){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn7_Dot_M, client, 16448, 1171048){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn7_Dot_StartTime, client, 16448, 1171052){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn8, client, 16448, 1171056)
					{
						 Name = "Item_9",
						IN = new BeckhoffBool(this.GetDelayOn8_Dot_IN, client, 16448, 1171064){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn8_Dot_PT, client, 16448, 1171068){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn8_Dot_Q, client, 16448, 1171072){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn8_Dot_ET, client, 16448, 1171076){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn8_Dot_M, client, 16448, 1171080){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn8_Dot_StartTime, client, 16448, 1171084){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn9, client, 16448, 1171088)
					{
						 Name = "Item_10",
						IN = new BeckhoffBool(this.GetDelayOn9_Dot_IN, client, 16448, 1171096){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn9_Dot_PT, client, 16448, 1171100){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn9_Dot_Q, client, 16448, 1171104){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn9_Dot_ET, client, 16448, 1171108){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn9_Dot_M, client, 16448, 1171112){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn9_Dot_StartTime, client, 16448, 1171116){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn10, client, 16448, 1171120)
					{
						 Name = "Item_11",
						IN = new BeckhoffBool(this.GetDelayOn10_Dot_IN, client, 16448, 1171128){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn10_Dot_PT, client, 16448, 1171132){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn10_Dot_Q, client, 16448, 1171136){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn10_Dot_ET, client, 16448, 1171140){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn10_Dot_M, client, 16448, 1171144){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn10_Dot_StartTime, client, 16448, 1171148){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn11, client, 16448, 1171152)
					{
						 Name = "Item_12",
						IN = new BeckhoffBool(this.GetDelayOn11_Dot_IN, client, 16448, 1171160){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn11_Dot_PT, client, 16448, 1171164){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn11_Dot_Q, client, 16448, 1171168){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn11_Dot_ET, client, 16448, 1171172){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn11_Dot_M, client, 16448, 1171176){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn11_Dot_StartTime, client, 16448, 1171180){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn12, client, 16448, 1171184)
					{
						 Name = "Item_13",
						IN = new BeckhoffBool(this.GetDelayOn12_Dot_IN, client, 16448, 1171192){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn12_Dot_PT, client, 16448, 1171196){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn12_Dot_Q, client, 16448, 1171200){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn12_Dot_ET, client, 16448, 1171204){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn12_Dot_M, client, 16448, 1171208){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn12_Dot_StartTime, client, 16448, 1171212){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn13, client, 16448, 1171216)
					{
						 Name = "Item_14",
						IN = new BeckhoffBool(this.GetDelayOn13_Dot_IN, client, 16448, 1171224){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn13_Dot_PT, client, 16448, 1171228){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn13_Dot_Q, client, 16448, 1171232){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn13_Dot_ET, client, 16448, 1171236){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn13_Dot_M, client, 16448, 1171240){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn13_Dot_StartTime, client, 16448, 1171244){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn14, client, 16448, 1171248)
					{
						 Name = "Item_15",
						IN = new BeckhoffBool(this.GetDelayOn14_Dot_IN, client, 16448, 1171256){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn14_Dot_PT, client, 16448, 1171260){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn14_Dot_Q, client, 16448, 1171264){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn14_Dot_ET, client, 16448, 1171268){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn14_Dot_M, client, 16448, 1171272){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn14_Dot_StartTime, client, 16448, 1171276){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn15, client, 16448, 1171280)
					{
						 Name = "Item_16",
						IN = new BeckhoffBool(this.GetDelayOn15_Dot_IN, client, 16448, 1171288){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn15_Dot_PT, client, 16448, 1171292){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn15_Dot_Q, client, 16448, 1171296){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn15_Dot_ET, client, 16448, 1171300){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn15_Dot_M, client, 16448, 1171304){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn15_Dot_StartTime, client, 16448, 1171308){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn16, client, 16448, 1171312)
					{
						 Name = "Item_17",
						IN = new BeckhoffBool(this.GetDelayOn16_Dot_IN, client, 16448, 1171320){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn16_Dot_PT, client, 16448, 1171324){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn16_Dot_Q, client, 16448, 1171328){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn16_Dot_ET, client, 16448, 1171332){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn16_Dot_M, client, 16448, 1171336){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn16_Dot_StartTime, client, 16448, 1171340){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn17, client, 16448, 1171344)
					{
						 Name = "Item_18",
						IN = new BeckhoffBool(this.GetDelayOn17_Dot_IN, client, 16448, 1171352){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn17_Dot_PT, client, 16448, 1171356){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn17_Dot_Q, client, 16448, 1171360){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn17_Dot_ET, client, 16448, 1171364){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn17_Dot_M, client, 16448, 1171368){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn17_Dot_StartTime, client, 16448, 1171372){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn18, client, 16448, 1171376)
					{
						 Name = "Item_19",
						IN = new BeckhoffBool(this.GetDelayOn18_Dot_IN, client, 16448, 1171384){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn18_Dot_PT, client, 16448, 1171388){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn18_Dot_Q, client, 16448, 1171392){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn18_Dot_ET, client, 16448, 1171396){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn18_Dot_M, client, 16448, 1171400){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn18_Dot_StartTime, client, 16448, 1171404){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn19, client, 16448, 1171408)
					{
						 Name = "Item_20",
						IN = new BeckhoffBool(this.GetDelayOn19_Dot_IN, client, 16448, 1171416){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn19_Dot_PT, client, 16448, 1171420){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn19_Dot_Q, client, 16448, 1171424){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn19_Dot_ET, client, 16448, 1171428){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn19_Dot_M, client, 16448, 1171432){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn19_Dot_StartTime, client, 16448, 1171436){ Name = "StartTime" },
					},
			}, false){ Name = "DelayOn" };
			TrigOn = new BeckhoffStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG>(this.GetTrigOn, client, 16448, 1171440,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1171440 ,1171456 ,1171472 ,1171488 ,1171504 ,1171520 ,1171536 ,1171552 ,1171568 ,1171584 ,1171600 ,1171616 ,1171632 ,1171648 ,1171664 ,1171680 ,1171696 ,1171712 ,1171728 ,1171744 , },
				new Tc2_Standard_R_TRIGWrapper[]
				{
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn0, client, 16448, 1171440)
					{
						 Name = "Item_1",
						CLK = new BeckhoffBool(this.GetTrigOn0_Dot_CLK, client, 16448, 1171448){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn0_Dot_Q, client, 16448, 1171449){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn0_Dot_M, client, 16448, 1171450){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn1, client, 16448, 1171456)
					{
						 Name = "Item_2",
						CLK = new BeckhoffBool(this.GetTrigOn1_Dot_CLK, client, 16448, 1171464){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn1_Dot_Q, client, 16448, 1171465){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn1_Dot_M, client, 16448, 1171466){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn2, client, 16448, 1171472)
					{
						 Name = "Item_3",
						CLK = new BeckhoffBool(this.GetTrigOn2_Dot_CLK, client, 16448, 1171480){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn2_Dot_Q, client, 16448, 1171481){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn2_Dot_M, client, 16448, 1171482){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn3, client, 16448, 1171488)
					{
						 Name = "Item_4",
						CLK = new BeckhoffBool(this.GetTrigOn3_Dot_CLK, client, 16448, 1171496){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn3_Dot_Q, client, 16448, 1171497){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn3_Dot_M, client, 16448, 1171498){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn4, client, 16448, 1171504)
					{
						 Name = "Item_5",
						CLK = new BeckhoffBool(this.GetTrigOn4_Dot_CLK, client, 16448, 1171512){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn4_Dot_Q, client, 16448, 1171513){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn4_Dot_M, client, 16448, 1171514){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn5, client, 16448, 1171520)
					{
						 Name = "Item_6",
						CLK = new BeckhoffBool(this.GetTrigOn5_Dot_CLK, client, 16448, 1171528){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn5_Dot_Q, client, 16448, 1171529){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn5_Dot_M, client, 16448, 1171530){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn6, client, 16448, 1171536)
					{
						 Name = "Item_7",
						CLK = new BeckhoffBool(this.GetTrigOn6_Dot_CLK, client, 16448, 1171544){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn6_Dot_Q, client, 16448, 1171545){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn6_Dot_M, client, 16448, 1171546){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn7, client, 16448, 1171552)
					{
						 Name = "Item_8",
						CLK = new BeckhoffBool(this.GetTrigOn7_Dot_CLK, client, 16448, 1171560){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn7_Dot_Q, client, 16448, 1171561){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn7_Dot_M, client, 16448, 1171562){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn8, client, 16448, 1171568)
					{
						 Name = "Item_9",
						CLK = new BeckhoffBool(this.GetTrigOn8_Dot_CLK, client, 16448, 1171576){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn8_Dot_Q, client, 16448, 1171577){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn8_Dot_M, client, 16448, 1171578){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn9, client, 16448, 1171584)
					{
						 Name = "Item_10",
						CLK = new BeckhoffBool(this.GetTrigOn9_Dot_CLK, client, 16448, 1171592){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn9_Dot_Q, client, 16448, 1171593){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn9_Dot_M, client, 16448, 1171594){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn10, client, 16448, 1171600)
					{
						 Name = "Item_11",
						CLK = new BeckhoffBool(this.GetTrigOn10_Dot_CLK, client, 16448, 1171608){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn10_Dot_Q, client, 16448, 1171609){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn10_Dot_M, client, 16448, 1171610){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn11, client, 16448, 1171616)
					{
						 Name = "Item_12",
						CLK = new BeckhoffBool(this.GetTrigOn11_Dot_CLK, client, 16448, 1171624){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn11_Dot_Q, client, 16448, 1171625){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn11_Dot_M, client, 16448, 1171626){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn12, client, 16448, 1171632)
					{
						 Name = "Item_13",
						CLK = new BeckhoffBool(this.GetTrigOn12_Dot_CLK, client, 16448, 1171640){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn12_Dot_Q, client, 16448, 1171641){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn12_Dot_M, client, 16448, 1171642){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn13, client, 16448, 1171648)
					{
						 Name = "Item_14",
						CLK = new BeckhoffBool(this.GetTrigOn13_Dot_CLK, client, 16448, 1171656){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn13_Dot_Q, client, 16448, 1171657){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn13_Dot_M, client, 16448, 1171658){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn14, client, 16448, 1171664)
					{
						 Name = "Item_15",
						CLK = new BeckhoffBool(this.GetTrigOn14_Dot_CLK, client, 16448, 1171672){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn14_Dot_Q, client, 16448, 1171673){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn14_Dot_M, client, 16448, 1171674){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn15, client, 16448, 1171680)
					{
						 Name = "Item_16",
						CLK = new BeckhoffBool(this.GetTrigOn15_Dot_CLK, client, 16448, 1171688){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn15_Dot_Q, client, 16448, 1171689){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn15_Dot_M, client, 16448, 1171690){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn16, client, 16448, 1171696)
					{
						 Name = "Item_17",
						CLK = new BeckhoffBool(this.GetTrigOn16_Dot_CLK, client, 16448, 1171704){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn16_Dot_Q, client, 16448, 1171705){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn16_Dot_M, client, 16448, 1171706){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn17, client, 16448, 1171712)
					{
						 Name = "Item_18",
						CLK = new BeckhoffBool(this.GetTrigOn17_Dot_CLK, client, 16448, 1171720){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn17_Dot_Q, client, 16448, 1171721){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn17_Dot_M, client, 16448, 1171722){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn18, client, 16448, 1171728)
					{
						 Name = "Item_19",
						CLK = new BeckhoffBool(this.GetTrigOn18_Dot_CLK, client, 16448, 1171736){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn18_Dot_Q, client, 16448, 1171737){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn18_Dot_M, client, 16448, 1171738){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn19, client, 16448, 1171744)
					{
						 Name = "Item_20",
						CLK = new BeckhoffBool(this.GetTrigOn19_Dot_CLK, client, 16448, 1171752){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn19_Dot_Q, client, 16448, 1171753){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn19_Dot_M, client, 16448, 1171754){ Name = "M" },
					},
			}, false){ Name = "TrigOn" };
			Initial_DelayOn = new BeckhoffStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON>(this.GetInitial_DelayOn, client, 16448, 1171760,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1171760 ,1171792 ,1171824 ,1171856 ,1171888 ,1171920 ,1171952 ,1171984 ,1172016 ,1172048 ,1172080 ,1172112 ,1172144 ,1172176 ,1172208 ,1172240 ,1172272 ,1172304 ,1172336 ,1172368 , },
				new Tc2_Standard_TONWrapper[]
				{
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn0, client, 16448, 1171760)
					{
						 Name = "Item_1",
						IN = new BeckhoffBool(this.GetInitial_DelayOn0_Dot_IN, client, 16448, 1171768){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn0_Dot_PT, client, 16448, 1171772){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn0_Dot_Q, client, 16448, 1171776){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn0_Dot_ET, client, 16448, 1171780){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn0_Dot_M, client, 16448, 1171784){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn0_Dot_StartTime, client, 16448, 1171788){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn1, client, 16448, 1171792)
					{
						 Name = "Item_2",
						IN = new BeckhoffBool(this.GetInitial_DelayOn1_Dot_IN, client, 16448, 1171800){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn1_Dot_PT, client, 16448, 1171804){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn1_Dot_Q, client, 16448, 1171808){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn1_Dot_ET, client, 16448, 1171812){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn1_Dot_M, client, 16448, 1171816){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn1_Dot_StartTime, client, 16448, 1171820){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn2, client, 16448, 1171824)
					{
						 Name = "Item_3",
						IN = new BeckhoffBool(this.GetInitial_DelayOn2_Dot_IN, client, 16448, 1171832){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn2_Dot_PT, client, 16448, 1171836){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn2_Dot_Q, client, 16448, 1171840){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn2_Dot_ET, client, 16448, 1171844){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn2_Dot_M, client, 16448, 1171848){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn2_Dot_StartTime, client, 16448, 1171852){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn3, client, 16448, 1171856)
					{
						 Name = "Item_4",
						IN = new BeckhoffBool(this.GetInitial_DelayOn3_Dot_IN, client, 16448, 1171864){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn3_Dot_PT, client, 16448, 1171868){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn3_Dot_Q, client, 16448, 1171872){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn3_Dot_ET, client, 16448, 1171876){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn3_Dot_M, client, 16448, 1171880){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn3_Dot_StartTime, client, 16448, 1171884){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn4, client, 16448, 1171888)
					{
						 Name = "Item_5",
						IN = new BeckhoffBool(this.GetInitial_DelayOn4_Dot_IN, client, 16448, 1171896){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn4_Dot_PT, client, 16448, 1171900){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn4_Dot_Q, client, 16448, 1171904){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn4_Dot_ET, client, 16448, 1171908){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn4_Dot_M, client, 16448, 1171912){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn4_Dot_StartTime, client, 16448, 1171916){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn5, client, 16448, 1171920)
					{
						 Name = "Item_6",
						IN = new BeckhoffBool(this.GetInitial_DelayOn5_Dot_IN, client, 16448, 1171928){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn5_Dot_PT, client, 16448, 1171932){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn5_Dot_Q, client, 16448, 1171936){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn5_Dot_ET, client, 16448, 1171940){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn5_Dot_M, client, 16448, 1171944){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn5_Dot_StartTime, client, 16448, 1171948){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn6, client, 16448, 1171952)
					{
						 Name = "Item_7",
						IN = new BeckhoffBool(this.GetInitial_DelayOn6_Dot_IN, client, 16448, 1171960){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn6_Dot_PT, client, 16448, 1171964){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn6_Dot_Q, client, 16448, 1171968){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn6_Dot_ET, client, 16448, 1171972){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn6_Dot_M, client, 16448, 1171976){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn6_Dot_StartTime, client, 16448, 1171980){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn7, client, 16448, 1171984)
					{
						 Name = "Item_8",
						IN = new BeckhoffBool(this.GetInitial_DelayOn7_Dot_IN, client, 16448, 1171992){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn7_Dot_PT, client, 16448, 1171996){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn7_Dot_Q, client, 16448, 1172000){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn7_Dot_ET, client, 16448, 1172004){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn7_Dot_M, client, 16448, 1172008){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn7_Dot_StartTime, client, 16448, 1172012){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn8, client, 16448, 1172016)
					{
						 Name = "Item_9",
						IN = new BeckhoffBool(this.GetInitial_DelayOn8_Dot_IN, client, 16448, 1172024){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn8_Dot_PT, client, 16448, 1172028){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn8_Dot_Q, client, 16448, 1172032){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn8_Dot_ET, client, 16448, 1172036){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn8_Dot_M, client, 16448, 1172040){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn8_Dot_StartTime, client, 16448, 1172044){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn9, client, 16448, 1172048)
					{
						 Name = "Item_10",
						IN = new BeckhoffBool(this.GetInitial_DelayOn9_Dot_IN, client, 16448, 1172056){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn9_Dot_PT, client, 16448, 1172060){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn9_Dot_Q, client, 16448, 1172064){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn9_Dot_ET, client, 16448, 1172068){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn9_Dot_M, client, 16448, 1172072){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn9_Dot_StartTime, client, 16448, 1172076){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn10, client, 16448, 1172080)
					{
						 Name = "Item_11",
						IN = new BeckhoffBool(this.GetInitial_DelayOn10_Dot_IN, client, 16448, 1172088){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn10_Dot_PT, client, 16448, 1172092){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn10_Dot_Q, client, 16448, 1172096){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn10_Dot_ET, client, 16448, 1172100){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn10_Dot_M, client, 16448, 1172104){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn10_Dot_StartTime, client, 16448, 1172108){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn11, client, 16448, 1172112)
					{
						 Name = "Item_12",
						IN = new BeckhoffBool(this.GetInitial_DelayOn11_Dot_IN, client, 16448, 1172120){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn11_Dot_PT, client, 16448, 1172124){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn11_Dot_Q, client, 16448, 1172128){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn11_Dot_ET, client, 16448, 1172132){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn11_Dot_M, client, 16448, 1172136){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn11_Dot_StartTime, client, 16448, 1172140){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn12, client, 16448, 1172144)
					{
						 Name = "Item_13",
						IN = new BeckhoffBool(this.GetInitial_DelayOn12_Dot_IN, client, 16448, 1172152){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn12_Dot_PT, client, 16448, 1172156){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn12_Dot_Q, client, 16448, 1172160){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn12_Dot_ET, client, 16448, 1172164){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn12_Dot_M, client, 16448, 1172168){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn12_Dot_StartTime, client, 16448, 1172172){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn13, client, 16448, 1172176)
					{
						 Name = "Item_14",
						IN = new BeckhoffBool(this.GetInitial_DelayOn13_Dot_IN, client, 16448, 1172184){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn13_Dot_PT, client, 16448, 1172188){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn13_Dot_Q, client, 16448, 1172192){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn13_Dot_ET, client, 16448, 1172196){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn13_Dot_M, client, 16448, 1172200){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn13_Dot_StartTime, client, 16448, 1172204){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn14, client, 16448, 1172208)
					{
						 Name = "Item_15",
						IN = new BeckhoffBool(this.GetInitial_DelayOn14_Dot_IN, client, 16448, 1172216){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn14_Dot_PT, client, 16448, 1172220){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn14_Dot_Q, client, 16448, 1172224){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn14_Dot_ET, client, 16448, 1172228){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn14_Dot_M, client, 16448, 1172232){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn14_Dot_StartTime, client, 16448, 1172236){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn15, client, 16448, 1172240)
					{
						 Name = "Item_16",
						IN = new BeckhoffBool(this.GetInitial_DelayOn15_Dot_IN, client, 16448, 1172248){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn15_Dot_PT, client, 16448, 1172252){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn15_Dot_Q, client, 16448, 1172256){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn15_Dot_ET, client, 16448, 1172260){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn15_Dot_M, client, 16448, 1172264){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn15_Dot_StartTime, client, 16448, 1172268){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn16, client, 16448, 1172272)
					{
						 Name = "Item_17",
						IN = new BeckhoffBool(this.GetInitial_DelayOn16_Dot_IN, client, 16448, 1172280){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn16_Dot_PT, client, 16448, 1172284){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn16_Dot_Q, client, 16448, 1172288){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn16_Dot_ET, client, 16448, 1172292){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn16_Dot_M, client, 16448, 1172296){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn16_Dot_StartTime, client, 16448, 1172300){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn17, client, 16448, 1172304)
					{
						 Name = "Item_18",
						IN = new BeckhoffBool(this.GetInitial_DelayOn17_Dot_IN, client, 16448, 1172312){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn17_Dot_PT, client, 16448, 1172316){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn17_Dot_Q, client, 16448, 1172320){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn17_Dot_ET, client, 16448, 1172324){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn17_Dot_M, client, 16448, 1172328){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn17_Dot_StartTime, client, 16448, 1172332){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn18, client, 16448, 1172336)
					{
						 Name = "Item_19",
						IN = new BeckhoffBool(this.GetInitial_DelayOn18_Dot_IN, client, 16448, 1172344){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn18_Dot_PT, client, 16448, 1172348){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn18_Dot_Q, client, 16448, 1172352){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn18_Dot_ET, client, 16448, 1172356){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn18_Dot_M, client, 16448, 1172360){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn18_Dot_StartTime, client, 16448, 1172364){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn19, client, 16448, 1172368)
					{
						 Name = "Item_20",
						IN = new BeckhoffBool(this.GetInitial_DelayOn19_Dot_IN, client, 16448, 1172376){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn19_Dot_PT, client, 16448, 1172380){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn19_Dot_Q, client, 16448, 1172384){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn19_Dot_ET, client, 16448, 1172388){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn19_Dot_M, client, 16448, 1172392){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn19_Dot_StartTime, client, 16448, 1172396){ Name = "StartTime" },
					},
			}, false){ Name = "Initial_DelayOn" };
			Initial_TrigOn = new BeckhoffStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG>(this.GetInitial_TrigOn, client, 16448, 1172400,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1172400 ,1172416 ,1172432 ,1172448 ,1172464 ,1172480 ,1172496 ,1172512 ,1172528 ,1172544 ,1172560 ,1172576 ,1172592 ,1172608 ,1172624 ,1172640 ,1172656 ,1172672 ,1172688 ,1172704 , },
				new Tc2_Standard_R_TRIGWrapper[]
				{
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn0, client, 16448, 1172400)
					{
						 Name = "Item_1",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn0_Dot_CLK, client, 16448, 1172408){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn0_Dot_Q, client, 16448, 1172409){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn0_Dot_M, client, 16448, 1172410){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn1, client, 16448, 1172416)
					{
						 Name = "Item_2",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn1_Dot_CLK, client, 16448, 1172424){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn1_Dot_Q, client, 16448, 1172425){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn1_Dot_M, client, 16448, 1172426){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn2, client, 16448, 1172432)
					{
						 Name = "Item_3",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn2_Dot_CLK, client, 16448, 1172440){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn2_Dot_Q, client, 16448, 1172441){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn2_Dot_M, client, 16448, 1172442){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn3, client, 16448, 1172448)
					{
						 Name = "Item_4",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn3_Dot_CLK, client, 16448, 1172456){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn3_Dot_Q, client, 16448, 1172457){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn3_Dot_M, client, 16448, 1172458){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn4, client, 16448, 1172464)
					{
						 Name = "Item_5",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn4_Dot_CLK, client, 16448, 1172472){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn4_Dot_Q, client, 16448, 1172473){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn4_Dot_M, client, 16448, 1172474){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn5, client, 16448, 1172480)
					{
						 Name = "Item_6",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn5_Dot_CLK, client, 16448, 1172488){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn5_Dot_Q, client, 16448, 1172489){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn5_Dot_M, client, 16448, 1172490){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn6, client, 16448, 1172496)
					{
						 Name = "Item_7",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn6_Dot_CLK, client, 16448, 1172504){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn6_Dot_Q, client, 16448, 1172505){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn6_Dot_M, client, 16448, 1172506){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn7, client, 16448, 1172512)
					{
						 Name = "Item_8",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn7_Dot_CLK, client, 16448, 1172520){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn7_Dot_Q, client, 16448, 1172521){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn7_Dot_M, client, 16448, 1172522){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn8, client, 16448, 1172528)
					{
						 Name = "Item_9",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn8_Dot_CLK, client, 16448, 1172536){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn8_Dot_Q, client, 16448, 1172537){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn8_Dot_M, client, 16448, 1172538){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn9, client, 16448, 1172544)
					{
						 Name = "Item_10",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn9_Dot_CLK, client, 16448, 1172552){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn9_Dot_Q, client, 16448, 1172553){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn9_Dot_M, client, 16448, 1172554){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn10, client, 16448, 1172560)
					{
						 Name = "Item_11",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn10_Dot_CLK, client, 16448, 1172568){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn10_Dot_Q, client, 16448, 1172569){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn10_Dot_M, client, 16448, 1172570){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn11, client, 16448, 1172576)
					{
						 Name = "Item_12",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn11_Dot_CLK, client, 16448, 1172584){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn11_Dot_Q, client, 16448, 1172585){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn11_Dot_M, client, 16448, 1172586){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn12, client, 16448, 1172592)
					{
						 Name = "Item_13",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn12_Dot_CLK, client, 16448, 1172600){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn12_Dot_Q, client, 16448, 1172601){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn12_Dot_M, client, 16448, 1172602){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn13, client, 16448, 1172608)
					{
						 Name = "Item_14",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn13_Dot_CLK, client, 16448, 1172616){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn13_Dot_Q, client, 16448, 1172617){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn13_Dot_M, client, 16448, 1172618){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn14, client, 16448, 1172624)
					{
						 Name = "Item_15",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn14_Dot_CLK, client, 16448, 1172632){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn14_Dot_Q, client, 16448, 1172633){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn14_Dot_M, client, 16448, 1172634){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn15, client, 16448, 1172640)
					{
						 Name = "Item_16",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn15_Dot_CLK, client, 16448, 1172648){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn15_Dot_Q, client, 16448, 1172649){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn15_Dot_M, client, 16448, 1172650){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn16, client, 16448, 1172656)
					{
						 Name = "Item_17",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn16_Dot_CLK, client, 16448, 1172664){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn16_Dot_Q, client, 16448, 1172665){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn16_Dot_M, client, 16448, 1172666){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn17, client, 16448, 1172672)
					{
						 Name = "Item_18",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn17_Dot_CLK, client, 16448, 1172680){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn17_Dot_Q, client, 16448, 1172681){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn17_Dot_M, client, 16448, 1172682){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn18, client, 16448, 1172688)
					{
						 Name = "Item_19",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn18_Dot_CLK, client, 16448, 1172696){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn18_Dot_Q, client, 16448, 1172697){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn18_Dot_M, client, 16448, 1172698){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn19, client, 16448, 1172704)
					{
						 Name = "Item_20",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn19_Dot_CLK, client, 16448, 1172712){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn19_Dot_Q, client, 16448, 1172713){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn19_Dot_M, client, 16448, 1172714){ Name = "M" },
					},
			}, false){ Name = "Initial_TrigOn" };
			Pos_IMH_ZM_Bottom_TO_Top = new BeckhoffFloat(this.GetPos_IMH_ZM_Bottom_TO_Top, client, 16448, 1172720){ Name = "Pos_IMH_ZM_Bottom_TO_Top" };
			Pos_IMH_ZM_Top_To_Bottom = new BeckhoffFloat(this.GetPos_IMH_ZM_Top_To_Bottom, client, 16448, 1172724){ Name = "Pos_IMH_ZM_Top_To_Bottom" };
			Pos_ZM_Receive_Buffer = new BeckhoffFloat(this.GetPos_ZM_Receive_Buffer, client, 16448, 1172728){ Name = "Pos_ZM_Receive_Buffer" };
			IMH_PosY_Loader_Buffer = new BeckhoffDouble(this.GetIMH_PosY_Loader_Buffer, client, 16448, 1172736){ Name = "IMH_PosY_Loader_Buffer" };
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
		~IMH_UnitWrapper()
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
