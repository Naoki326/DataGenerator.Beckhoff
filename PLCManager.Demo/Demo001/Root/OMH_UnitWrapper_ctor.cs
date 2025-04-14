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
	/// Name from PLC:OMH_Unit
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class OMH_UnitWrapper : BaseData, IBaseData
	{
		public override IEnumerable<IBaseData> Children
		{
			get
			{
				yield return i;
				yield return car;
				yield return logon;
				yield return LCase_Move;
				yield return ULCase_Move;
				yield return Auto_Move;
				yield return Pos_YM_Loading_Case_Buffer;
				yield return Initial_DelayOn;
				yield return Initial_TrigOn;
				yield return H_DelayOn;
				yield return H_TrigOn;
				yield return L_DelayOn;
				yield return L_TrigOn;
				yield return UL_DelayOn;
				yield return UL_TrigOn;
				yield return DelayOn;
				yield return TrigOn;
				yield return Pos_YM_Receive_Base_Buffer;
				yield return Pos_YM_UnLoading_Case_Buffer;
				yield return Pos_ZM_Receive_Buffer;
				yield return Pos_ZM_Top_TO_Bottom;
				yield return Pos_ZM_Bottom_TO_Top;
				yield return AlarmCode;
				yield return Pos_YM_Loading_Case;
				yield return Pos_YM_Receive_Base;
			}
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(i):
					return i;
				case nameof(car):
					return car;
				case nameof(logon):
					return logon;
				case nameof(LCase_Move):
					return LCase_Move;
				case nameof(ULCase_Move):
					return ULCase_Move;
				case nameof(Auto_Move):
					return Auto_Move;
				case nameof(Pos_YM_Loading_Case_Buffer):
					return Pos_YM_Loading_Case_Buffer;
				case nameof(Initial_DelayOn):
					return Initial_DelayOn;
				case nameof(Initial_TrigOn):
					return Initial_TrigOn;
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
				case nameof(Pos_YM_Receive_Base_Buffer):
					return Pos_YM_Receive_Base_Buffer;
				case nameof(Pos_YM_UnLoading_Case_Buffer):
					return Pos_YM_UnLoading_Case_Buffer;
				case nameof(Pos_ZM_Receive_Buffer):
					return Pos_ZM_Receive_Buffer;
				case nameof(Pos_ZM_Top_TO_Bottom):
					return Pos_ZM_Top_TO_Bottom;
				case nameof(Pos_ZM_Bottom_TO_Top):
					return Pos_ZM_Bottom_TO_Top;
				case nameof(AlarmCode):
					return AlarmCode;
				case nameof(Pos_YM_Loading_Case):
					return Pos_YM_Loading_Case;
				case nameof(Pos_YM_Receive_Base):
					return Pos_YM_Receive_Base;
			}
			throw new KeyNotFoundException(name);
		}

		private readonly AdsClient client;

		public OMH_UnitWrapper(AdsClient client)
		{
			this.client = client;

			i = new BeckhoffShort(this.Geti, client, 16448, 1167918){ Name = "i" };
			car = new BeckhoffShort(this.Getcar, client, 16448, 1172732){ Name = "car" };
			logon = new BeckhoffShort(this.Getlogon, client, 16448, 1172734){ Name = "logon" };
			LCase_Move = new BeckhoffBoolArray<Bool20>(this.GetLCase_Move, client, 16448, 1172744,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1172744 ,1172745 ,1172746 ,1172747 ,1172748 ,1172749 ,1172750 ,1172751 ,1172752 ,1172753 ,1172754 ,1172755 ,1172756 ,1172757 ,1172758 ,1172759 ,1172760 ,1172761 ,1172762 ,1172763 , }, false){ Name = "LCase_Move" };
			ULCase_Move = new BeckhoffBoolArray<Bool20>(this.GetULCase_Move, client, 16448, 1172764,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1172764 ,1172765 ,1172766 ,1172767 ,1172768 ,1172769 ,1172770 ,1172771 ,1172772 ,1172773 ,1172774 ,1172775 ,1172776 ,1172777 ,1172778 ,1172779 ,1172780 ,1172781 ,1172782 ,1172783 , }, false){ Name = "ULCase_Move" };
			Auto_Move = new BeckhoffBoolArray<Bool20>(this.GetAuto_Move, client, 16448, 1172784,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1172784 ,1172785 ,1172786 ,1172787 ,1172788 ,1172789 ,1172790 ,1172791 ,1172792 ,1172793 ,1172794 ,1172795 ,1172796 ,1172797 ,1172798 ,1172799 ,1172800 ,1172801 ,1172802 ,1172803 , }, false){ Name = "Auto_Move" };
			Pos_YM_Loading_Case_Buffer = new BeckhoffFloat(this.GetPos_YM_Loading_Case_Buffer, client, 16448, 1172804){ Name = "Pos_YM_Loading_Case_Buffer" };
			Initial_DelayOn = new BeckhoffStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON>(this.GetInitial_DelayOn, client, 16448, 1172808,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1172808 ,1172840 ,1172872 ,1172904 ,1172936 ,1172968 ,1173000 ,1173032 ,1173064 ,1173096 ,1173128 ,1173160 ,1173192 ,1173224 ,1173256 ,1173288 ,1173320 ,1173352 ,1173384 ,1173416 , },
				new Tc2_Standard_TONWrapper[]
				{
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn0, client, 16448, 1172808)
					{
						 Name = "Item_1",
						IN = new BeckhoffBool(this.GetInitial_DelayOn0_Dot_IN, client, 16448, 1172816){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn0_Dot_PT, client, 16448, 1172820){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn0_Dot_Q, client, 16448, 1172824){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn0_Dot_ET, client, 16448, 1172828){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn0_Dot_M, client, 16448, 1172832){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn0_Dot_StartTime, client, 16448, 1172836){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn1, client, 16448, 1172840)
					{
						 Name = "Item_2",
						IN = new BeckhoffBool(this.GetInitial_DelayOn1_Dot_IN, client, 16448, 1172848){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn1_Dot_PT, client, 16448, 1172852){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn1_Dot_Q, client, 16448, 1172856){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn1_Dot_ET, client, 16448, 1172860){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn1_Dot_M, client, 16448, 1172864){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn1_Dot_StartTime, client, 16448, 1172868){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn2, client, 16448, 1172872)
					{
						 Name = "Item_3",
						IN = new BeckhoffBool(this.GetInitial_DelayOn2_Dot_IN, client, 16448, 1172880){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn2_Dot_PT, client, 16448, 1172884){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn2_Dot_Q, client, 16448, 1172888){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn2_Dot_ET, client, 16448, 1172892){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn2_Dot_M, client, 16448, 1172896){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn2_Dot_StartTime, client, 16448, 1172900){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn3, client, 16448, 1172904)
					{
						 Name = "Item_4",
						IN = new BeckhoffBool(this.GetInitial_DelayOn3_Dot_IN, client, 16448, 1172912){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn3_Dot_PT, client, 16448, 1172916){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn3_Dot_Q, client, 16448, 1172920){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn3_Dot_ET, client, 16448, 1172924){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn3_Dot_M, client, 16448, 1172928){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn3_Dot_StartTime, client, 16448, 1172932){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn4, client, 16448, 1172936)
					{
						 Name = "Item_5",
						IN = new BeckhoffBool(this.GetInitial_DelayOn4_Dot_IN, client, 16448, 1172944){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn4_Dot_PT, client, 16448, 1172948){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn4_Dot_Q, client, 16448, 1172952){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn4_Dot_ET, client, 16448, 1172956){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn4_Dot_M, client, 16448, 1172960){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn4_Dot_StartTime, client, 16448, 1172964){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn5, client, 16448, 1172968)
					{
						 Name = "Item_6",
						IN = new BeckhoffBool(this.GetInitial_DelayOn5_Dot_IN, client, 16448, 1172976){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn5_Dot_PT, client, 16448, 1172980){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn5_Dot_Q, client, 16448, 1172984){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn5_Dot_ET, client, 16448, 1172988){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn5_Dot_M, client, 16448, 1172992){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn5_Dot_StartTime, client, 16448, 1172996){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn6, client, 16448, 1173000)
					{
						 Name = "Item_7",
						IN = new BeckhoffBool(this.GetInitial_DelayOn6_Dot_IN, client, 16448, 1173008){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn6_Dot_PT, client, 16448, 1173012){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn6_Dot_Q, client, 16448, 1173016){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn6_Dot_ET, client, 16448, 1173020){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn6_Dot_M, client, 16448, 1173024){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn6_Dot_StartTime, client, 16448, 1173028){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn7, client, 16448, 1173032)
					{
						 Name = "Item_8",
						IN = new BeckhoffBool(this.GetInitial_DelayOn7_Dot_IN, client, 16448, 1173040){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn7_Dot_PT, client, 16448, 1173044){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn7_Dot_Q, client, 16448, 1173048){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn7_Dot_ET, client, 16448, 1173052){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn7_Dot_M, client, 16448, 1173056){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn7_Dot_StartTime, client, 16448, 1173060){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn8, client, 16448, 1173064)
					{
						 Name = "Item_9",
						IN = new BeckhoffBool(this.GetInitial_DelayOn8_Dot_IN, client, 16448, 1173072){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn8_Dot_PT, client, 16448, 1173076){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn8_Dot_Q, client, 16448, 1173080){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn8_Dot_ET, client, 16448, 1173084){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn8_Dot_M, client, 16448, 1173088){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn8_Dot_StartTime, client, 16448, 1173092){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn9, client, 16448, 1173096)
					{
						 Name = "Item_10",
						IN = new BeckhoffBool(this.GetInitial_DelayOn9_Dot_IN, client, 16448, 1173104){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn9_Dot_PT, client, 16448, 1173108){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn9_Dot_Q, client, 16448, 1173112){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn9_Dot_ET, client, 16448, 1173116){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn9_Dot_M, client, 16448, 1173120){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn9_Dot_StartTime, client, 16448, 1173124){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn10, client, 16448, 1173128)
					{
						 Name = "Item_11",
						IN = new BeckhoffBool(this.GetInitial_DelayOn10_Dot_IN, client, 16448, 1173136){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn10_Dot_PT, client, 16448, 1173140){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn10_Dot_Q, client, 16448, 1173144){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn10_Dot_ET, client, 16448, 1173148){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn10_Dot_M, client, 16448, 1173152){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn10_Dot_StartTime, client, 16448, 1173156){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn11, client, 16448, 1173160)
					{
						 Name = "Item_12",
						IN = new BeckhoffBool(this.GetInitial_DelayOn11_Dot_IN, client, 16448, 1173168){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn11_Dot_PT, client, 16448, 1173172){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn11_Dot_Q, client, 16448, 1173176){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn11_Dot_ET, client, 16448, 1173180){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn11_Dot_M, client, 16448, 1173184){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn11_Dot_StartTime, client, 16448, 1173188){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn12, client, 16448, 1173192)
					{
						 Name = "Item_13",
						IN = new BeckhoffBool(this.GetInitial_DelayOn12_Dot_IN, client, 16448, 1173200){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn12_Dot_PT, client, 16448, 1173204){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn12_Dot_Q, client, 16448, 1173208){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn12_Dot_ET, client, 16448, 1173212){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn12_Dot_M, client, 16448, 1173216){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn12_Dot_StartTime, client, 16448, 1173220){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn13, client, 16448, 1173224)
					{
						 Name = "Item_14",
						IN = new BeckhoffBool(this.GetInitial_DelayOn13_Dot_IN, client, 16448, 1173232){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn13_Dot_PT, client, 16448, 1173236){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn13_Dot_Q, client, 16448, 1173240){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn13_Dot_ET, client, 16448, 1173244){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn13_Dot_M, client, 16448, 1173248){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn13_Dot_StartTime, client, 16448, 1173252){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn14, client, 16448, 1173256)
					{
						 Name = "Item_15",
						IN = new BeckhoffBool(this.GetInitial_DelayOn14_Dot_IN, client, 16448, 1173264){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn14_Dot_PT, client, 16448, 1173268){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn14_Dot_Q, client, 16448, 1173272){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn14_Dot_ET, client, 16448, 1173276){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn14_Dot_M, client, 16448, 1173280){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn14_Dot_StartTime, client, 16448, 1173284){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn15, client, 16448, 1173288)
					{
						 Name = "Item_16",
						IN = new BeckhoffBool(this.GetInitial_DelayOn15_Dot_IN, client, 16448, 1173296){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn15_Dot_PT, client, 16448, 1173300){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn15_Dot_Q, client, 16448, 1173304){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn15_Dot_ET, client, 16448, 1173308){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn15_Dot_M, client, 16448, 1173312){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn15_Dot_StartTime, client, 16448, 1173316){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn16, client, 16448, 1173320)
					{
						 Name = "Item_17",
						IN = new BeckhoffBool(this.GetInitial_DelayOn16_Dot_IN, client, 16448, 1173328){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn16_Dot_PT, client, 16448, 1173332){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn16_Dot_Q, client, 16448, 1173336){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn16_Dot_ET, client, 16448, 1173340){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn16_Dot_M, client, 16448, 1173344){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn16_Dot_StartTime, client, 16448, 1173348){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn17, client, 16448, 1173352)
					{
						 Name = "Item_18",
						IN = new BeckhoffBool(this.GetInitial_DelayOn17_Dot_IN, client, 16448, 1173360){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn17_Dot_PT, client, 16448, 1173364){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn17_Dot_Q, client, 16448, 1173368){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn17_Dot_ET, client, 16448, 1173372){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn17_Dot_M, client, 16448, 1173376){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn17_Dot_StartTime, client, 16448, 1173380){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn18, client, 16448, 1173384)
					{
						 Name = "Item_19",
						IN = new BeckhoffBool(this.GetInitial_DelayOn18_Dot_IN, client, 16448, 1173392){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn18_Dot_PT, client, 16448, 1173396){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn18_Dot_Q, client, 16448, 1173400){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn18_Dot_ET, client, 16448, 1173404){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn18_Dot_M, client, 16448, 1173408){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn18_Dot_StartTime, client, 16448, 1173412){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetInitial_DelayOn19, client, 16448, 1173416)
					{
						 Name = "Item_20",
						IN = new BeckhoffBool(this.GetInitial_DelayOn19_Dot_IN, client, 16448, 1173424){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetInitial_DelayOn19_Dot_PT, client, 16448, 1173428){ Name = "PT" },
						Q = new BeckhoffBool(this.GetInitial_DelayOn19_Dot_Q, client, 16448, 1173432){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetInitial_DelayOn19_Dot_ET, client, 16448, 1173436){ Name = "ET" },
						M = new BeckhoffBool(this.GetInitial_DelayOn19_Dot_M, client, 16448, 1173440){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetInitial_DelayOn19_Dot_StartTime, client, 16448, 1173444){ Name = "StartTime" },
					},
			}, false){ Name = "Initial_DelayOn" };
			Initial_TrigOn = new BeckhoffStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG>(this.GetInitial_TrigOn, client, 16448, 1173448,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1173448 ,1173464 ,1173480 ,1173496 ,1173512 ,1173528 ,1173544 ,1173560 ,1173576 ,1173592 ,1173608 ,1173624 ,1173640 ,1173656 ,1173672 ,1173688 ,1173704 ,1173720 ,1173736 ,1173752 , },
				new Tc2_Standard_R_TRIGWrapper[]
				{
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn0, client, 16448, 1173448)
					{
						 Name = "Item_1",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn0_Dot_CLK, client, 16448, 1173456){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn0_Dot_Q, client, 16448, 1173457){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn0_Dot_M, client, 16448, 1173458){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn1, client, 16448, 1173464)
					{
						 Name = "Item_2",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn1_Dot_CLK, client, 16448, 1173472){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn1_Dot_Q, client, 16448, 1173473){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn1_Dot_M, client, 16448, 1173474){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn2, client, 16448, 1173480)
					{
						 Name = "Item_3",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn2_Dot_CLK, client, 16448, 1173488){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn2_Dot_Q, client, 16448, 1173489){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn2_Dot_M, client, 16448, 1173490){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn3, client, 16448, 1173496)
					{
						 Name = "Item_4",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn3_Dot_CLK, client, 16448, 1173504){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn3_Dot_Q, client, 16448, 1173505){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn3_Dot_M, client, 16448, 1173506){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn4, client, 16448, 1173512)
					{
						 Name = "Item_5",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn4_Dot_CLK, client, 16448, 1173520){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn4_Dot_Q, client, 16448, 1173521){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn4_Dot_M, client, 16448, 1173522){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn5, client, 16448, 1173528)
					{
						 Name = "Item_6",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn5_Dot_CLK, client, 16448, 1173536){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn5_Dot_Q, client, 16448, 1173537){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn5_Dot_M, client, 16448, 1173538){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn6, client, 16448, 1173544)
					{
						 Name = "Item_7",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn6_Dot_CLK, client, 16448, 1173552){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn6_Dot_Q, client, 16448, 1173553){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn6_Dot_M, client, 16448, 1173554){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn7, client, 16448, 1173560)
					{
						 Name = "Item_8",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn7_Dot_CLK, client, 16448, 1173568){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn7_Dot_Q, client, 16448, 1173569){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn7_Dot_M, client, 16448, 1173570){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn8, client, 16448, 1173576)
					{
						 Name = "Item_9",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn8_Dot_CLK, client, 16448, 1173584){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn8_Dot_Q, client, 16448, 1173585){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn8_Dot_M, client, 16448, 1173586){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn9, client, 16448, 1173592)
					{
						 Name = "Item_10",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn9_Dot_CLK, client, 16448, 1173600){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn9_Dot_Q, client, 16448, 1173601){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn9_Dot_M, client, 16448, 1173602){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn10, client, 16448, 1173608)
					{
						 Name = "Item_11",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn10_Dot_CLK, client, 16448, 1173616){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn10_Dot_Q, client, 16448, 1173617){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn10_Dot_M, client, 16448, 1173618){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn11, client, 16448, 1173624)
					{
						 Name = "Item_12",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn11_Dot_CLK, client, 16448, 1173632){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn11_Dot_Q, client, 16448, 1173633){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn11_Dot_M, client, 16448, 1173634){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn12, client, 16448, 1173640)
					{
						 Name = "Item_13",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn12_Dot_CLK, client, 16448, 1173648){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn12_Dot_Q, client, 16448, 1173649){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn12_Dot_M, client, 16448, 1173650){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn13, client, 16448, 1173656)
					{
						 Name = "Item_14",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn13_Dot_CLK, client, 16448, 1173664){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn13_Dot_Q, client, 16448, 1173665){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn13_Dot_M, client, 16448, 1173666){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn14, client, 16448, 1173672)
					{
						 Name = "Item_15",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn14_Dot_CLK, client, 16448, 1173680){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn14_Dot_Q, client, 16448, 1173681){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn14_Dot_M, client, 16448, 1173682){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn15, client, 16448, 1173688)
					{
						 Name = "Item_16",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn15_Dot_CLK, client, 16448, 1173696){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn15_Dot_Q, client, 16448, 1173697){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn15_Dot_M, client, 16448, 1173698){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn16, client, 16448, 1173704)
					{
						 Name = "Item_17",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn16_Dot_CLK, client, 16448, 1173712){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn16_Dot_Q, client, 16448, 1173713){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn16_Dot_M, client, 16448, 1173714){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn17, client, 16448, 1173720)
					{
						 Name = "Item_18",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn17_Dot_CLK, client, 16448, 1173728){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn17_Dot_Q, client, 16448, 1173729){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn17_Dot_M, client, 16448, 1173730){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn18, client, 16448, 1173736)
					{
						 Name = "Item_19",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn18_Dot_CLK, client, 16448, 1173744){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn18_Dot_Q, client, 16448, 1173745){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn18_Dot_M, client, 16448, 1173746){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetInitial_TrigOn19, client, 16448, 1173752)
					{
						 Name = "Item_20",
						CLK = new BeckhoffBool(this.GetInitial_TrigOn19_Dot_CLK, client, 16448, 1173760){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetInitial_TrigOn19_Dot_Q, client, 16448, 1173761){ Name = "Q" },
						M = new BeckhoffBool(this.GetInitial_TrigOn19_Dot_M, client, 16448, 1173762){ Name = "M" },
					},
			}, false){ Name = "Initial_TrigOn" };
			H_DelayOn = new BeckhoffStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON>(this.GetH_DelayOn, client, 16448, 1173768,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1173768 ,1173800 ,1173832 ,1173864 ,1173896 ,1173928 ,1173960 ,1173992 ,1174024 ,1174056 ,1174088 ,1174120 ,1174152 ,1174184 ,1174216 ,1174248 ,1174280 ,1174312 ,1174344 ,1174376 , },
				new Tc2_Standard_TONWrapper[]
				{
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn0, client, 16448, 1173768)
					{
						 Name = "Item_1",
						IN = new BeckhoffBool(this.GetH_DelayOn0_Dot_IN, client, 16448, 1173776){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn0_Dot_PT, client, 16448, 1173780){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn0_Dot_Q, client, 16448, 1173784){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn0_Dot_ET, client, 16448, 1173788){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn0_Dot_M, client, 16448, 1173792){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn0_Dot_StartTime, client, 16448, 1173796){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn1, client, 16448, 1173800)
					{
						 Name = "Item_2",
						IN = new BeckhoffBool(this.GetH_DelayOn1_Dot_IN, client, 16448, 1173808){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn1_Dot_PT, client, 16448, 1173812){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn1_Dot_Q, client, 16448, 1173816){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn1_Dot_ET, client, 16448, 1173820){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn1_Dot_M, client, 16448, 1173824){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn1_Dot_StartTime, client, 16448, 1173828){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn2, client, 16448, 1173832)
					{
						 Name = "Item_3",
						IN = new BeckhoffBool(this.GetH_DelayOn2_Dot_IN, client, 16448, 1173840){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn2_Dot_PT, client, 16448, 1173844){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn2_Dot_Q, client, 16448, 1173848){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn2_Dot_ET, client, 16448, 1173852){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn2_Dot_M, client, 16448, 1173856){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn2_Dot_StartTime, client, 16448, 1173860){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn3, client, 16448, 1173864)
					{
						 Name = "Item_4",
						IN = new BeckhoffBool(this.GetH_DelayOn3_Dot_IN, client, 16448, 1173872){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn3_Dot_PT, client, 16448, 1173876){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn3_Dot_Q, client, 16448, 1173880){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn3_Dot_ET, client, 16448, 1173884){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn3_Dot_M, client, 16448, 1173888){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn3_Dot_StartTime, client, 16448, 1173892){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn4, client, 16448, 1173896)
					{
						 Name = "Item_5",
						IN = new BeckhoffBool(this.GetH_DelayOn4_Dot_IN, client, 16448, 1173904){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn4_Dot_PT, client, 16448, 1173908){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn4_Dot_Q, client, 16448, 1173912){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn4_Dot_ET, client, 16448, 1173916){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn4_Dot_M, client, 16448, 1173920){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn4_Dot_StartTime, client, 16448, 1173924){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn5, client, 16448, 1173928)
					{
						 Name = "Item_6",
						IN = new BeckhoffBool(this.GetH_DelayOn5_Dot_IN, client, 16448, 1173936){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn5_Dot_PT, client, 16448, 1173940){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn5_Dot_Q, client, 16448, 1173944){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn5_Dot_ET, client, 16448, 1173948){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn5_Dot_M, client, 16448, 1173952){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn5_Dot_StartTime, client, 16448, 1173956){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn6, client, 16448, 1173960)
					{
						 Name = "Item_7",
						IN = new BeckhoffBool(this.GetH_DelayOn6_Dot_IN, client, 16448, 1173968){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn6_Dot_PT, client, 16448, 1173972){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn6_Dot_Q, client, 16448, 1173976){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn6_Dot_ET, client, 16448, 1173980){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn6_Dot_M, client, 16448, 1173984){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn6_Dot_StartTime, client, 16448, 1173988){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn7, client, 16448, 1173992)
					{
						 Name = "Item_8",
						IN = new BeckhoffBool(this.GetH_DelayOn7_Dot_IN, client, 16448, 1174000){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn7_Dot_PT, client, 16448, 1174004){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn7_Dot_Q, client, 16448, 1174008){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn7_Dot_ET, client, 16448, 1174012){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn7_Dot_M, client, 16448, 1174016){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn7_Dot_StartTime, client, 16448, 1174020){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn8, client, 16448, 1174024)
					{
						 Name = "Item_9",
						IN = new BeckhoffBool(this.GetH_DelayOn8_Dot_IN, client, 16448, 1174032){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn8_Dot_PT, client, 16448, 1174036){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn8_Dot_Q, client, 16448, 1174040){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn8_Dot_ET, client, 16448, 1174044){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn8_Dot_M, client, 16448, 1174048){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn8_Dot_StartTime, client, 16448, 1174052){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn9, client, 16448, 1174056)
					{
						 Name = "Item_10",
						IN = new BeckhoffBool(this.GetH_DelayOn9_Dot_IN, client, 16448, 1174064){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn9_Dot_PT, client, 16448, 1174068){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn9_Dot_Q, client, 16448, 1174072){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn9_Dot_ET, client, 16448, 1174076){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn9_Dot_M, client, 16448, 1174080){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn9_Dot_StartTime, client, 16448, 1174084){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn10, client, 16448, 1174088)
					{
						 Name = "Item_11",
						IN = new BeckhoffBool(this.GetH_DelayOn10_Dot_IN, client, 16448, 1174096){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn10_Dot_PT, client, 16448, 1174100){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn10_Dot_Q, client, 16448, 1174104){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn10_Dot_ET, client, 16448, 1174108){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn10_Dot_M, client, 16448, 1174112){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn10_Dot_StartTime, client, 16448, 1174116){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn11, client, 16448, 1174120)
					{
						 Name = "Item_12",
						IN = new BeckhoffBool(this.GetH_DelayOn11_Dot_IN, client, 16448, 1174128){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn11_Dot_PT, client, 16448, 1174132){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn11_Dot_Q, client, 16448, 1174136){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn11_Dot_ET, client, 16448, 1174140){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn11_Dot_M, client, 16448, 1174144){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn11_Dot_StartTime, client, 16448, 1174148){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn12, client, 16448, 1174152)
					{
						 Name = "Item_13",
						IN = new BeckhoffBool(this.GetH_DelayOn12_Dot_IN, client, 16448, 1174160){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn12_Dot_PT, client, 16448, 1174164){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn12_Dot_Q, client, 16448, 1174168){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn12_Dot_ET, client, 16448, 1174172){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn12_Dot_M, client, 16448, 1174176){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn12_Dot_StartTime, client, 16448, 1174180){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn13, client, 16448, 1174184)
					{
						 Name = "Item_14",
						IN = new BeckhoffBool(this.GetH_DelayOn13_Dot_IN, client, 16448, 1174192){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn13_Dot_PT, client, 16448, 1174196){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn13_Dot_Q, client, 16448, 1174200){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn13_Dot_ET, client, 16448, 1174204){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn13_Dot_M, client, 16448, 1174208){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn13_Dot_StartTime, client, 16448, 1174212){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn14, client, 16448, 1174216)
					{
						 Name = "Item_15",
						IN = new BeckhoffBool(this.GetH_DelayOn14_Dot_IN, client, 16448, 1174224){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn14_Dot_PT, client, 16448, 1174228){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn14_Dot_Q, client, 16448, 1174232){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn14_Dot_ET, client, 16448, 1174236){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn14_Dot_M, client, 16448, 1174240){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn14_Dot_StartTime, client, 16448, 1174244){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn15, client, 16448, 1174248)
					{
						 Name = "Item_16",
						IN = new BeckhoffBool(this.GetH_DelayOn15_Dot_IN, client, 16448, 1174256){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn15_Dot_PT, client, 16448, 1174260){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn15_Dot_Q, client, 16448, 1174264){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn15_Dot_ET, client, 16448, 1174268){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn15_Dot_M, client, 16448, 1174272){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn15_Dot_StartTime, client, 16448, 1174276){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn16, client, 16448, 1174280)
					{
						 Name = "Item_17",
						IN = new BeckhoffBool(this.GetH_DelayOn16_Dot_IN, client, 16448, 1174288){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn16_Dot_PT, client, 16448, 1174292){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn16_Dot_Q, client, 16448, 1174296){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn16_Dot_ET, client, 16448, 1174300){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn16_Dot_M, client, 16448, 1174304){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn16_Dot_StartTime, client, 16448, 1174308){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn17, client, 16448, 1174312)
					{
						 Name = "Item_18",
						IN = new BeckhoffBool(this.GetH_DelayOn17_Dot_IN, client, 16448, 1174320){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn17_Dot_PT, client, 16448, 1174324){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn17_Dot_Q, client, 16448, 1174328){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn17_Dot_ET, client, 16448, 1174332){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn17_Dot_M, client, 16448, 1174336){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn17_Dot_StartTime, client, 16448, 1174340){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn18, client, 16448, 1174344)
					{
						 Name = "Item_19",
						IN = new BeckhoffBool(this.GetH_DelayOn18_Dot_IN, client, 16448, 1174352){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn18_Dot_PT, client, 16448, 1174356){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn18_Dot_Q, client, 16448, 1174360){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn18_Dot_ET, client, 16448, 1174364){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn18_Dot_M, client, 16448, 1174368){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn18_Dot_StartTime, client, 16448, 1174372){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetH_DelayOn19, client, 16448, 1174376)
					{
						 Name = "Item_20",
						IN = new BeckhoffBool(this.GetH_DelayOn19_Dot_IN, client, 16448, 1174384){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetH_DelayOn19_Dot_PT, client, 16448, 1174388){ Name = "PT" },
						Q = new BeckhoffBool(this.GetH_DelayOn19_Dot_Q, client, 16448, 1174392){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetH_DelayOn19_Dot_ET, client, 16448, 1174396){ Name = "ET" },
						M = new BeckhoffBool(this.GetH_DelayOn19_Dot_M, client, 16448, 1174400){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetH_DelayOn19_Dot_StartTime, client, 16448, 1174404){ Name = "StartTime" },
					},
			}, false){ Name = "H_DelayOn" };
			H_TrigOn = new BeckhoffStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG>(this.GetH_TrigOn, client, 16448, 1174408,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1174408 ,1174424 ,1174440 ,1174456 ,1174472 ,1174488 ,1174504 ,1174520 ,1174536 ,1174552 ,1174568 ,1174584 ,1174600 ,1174616 ,1174632 ,1174648 ,1174664 ,1174680 ,1174696 ,1174712 , },
				new Tc2_Standard_R_TRIGWrapper[]
				{
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn0, client, 16448, 1174408)
					{
						 Name = "Item_1",
						CLK = new BeckhoffBool(this.GetH_TrigOn0_Dot_CLK, client, 16448, 1174416){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn0_Dot_Q, client, 16448, 1174417){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn0_Dot_M, client, 16448, 1174418){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn1, client, 16448, 1174424)
					{
						 Name = "Item_2",
						CLK = new BeckhoffBool(this.GetH_TrigOn1_Dot_CLK, client, 16448, 1174432){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn1_Dot_Q, client, 16448, 1174433){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn1_Dot_M, client, 16448, 1174434){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn2, client, 16448, 1174440)
					{
						 Name = "Item_3",
						CLK = new BeckhoffBool(this.GetH_TrigOn2_Dot_CLK, client, 16448, 1174448){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn2_Dot_Q, client, 16448, 1174449){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn2_Dot_M, client, 16448, 1174450){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn3, client, 16448, 1174456)
					{
						 Name = "Item_4",
						CLK = new BeckhoffBool(this.GetH_TrigOn3_Dot_CLK, client, 16448, 1174464){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn3_Dot_Q, client, 16448, 1174465){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn3_Dot_M, client, 16448, 1174466){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn4, client, 16448, 1174472)
					{
						 Name = "Item_5",
						CLK = new BeckhoffBool(this.GetH_TrigOn4_Dot_CLK, client, 16448, 1174480){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn4_Dot_Q, client, 16448, 1174481){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn4_Dot_M, client, 16448, 1174482){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn5, client, 16448, 1174488)
					{
						 Name = "Item_6",
						CLK = new BeckhoffBool(this.GetH_TrigOn5_Dot_CLK, client, 16448, 1174496){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn5_Dot_Q, client, 16448, 1174497){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn5_Dot_M, client, 16448, 1174498){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn6, client, 16448, 1174504)
					{
						 Name = "Item_7",
						CLK = new BeckhoffBool(this.GetH_TrigOn6_Dot_CLK, client, 16448, 1174512){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn6_Dot_Q, client, 16448, 1174513){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn6_Dot_M, client, 16448, 1174514){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn7, client, 16448, 1174520)
					{
						 Name = "Item_8",
						CLK = new BeckhoffBool(this.GetH_TrigOn7_Dot_CLK, client, 16448, 1174528){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn7_Dot_Q, client, 16448, 1174529){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn7_Dot_M, client, 16448, 1174530){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn8, client, 16448, 1174536)
					{
						 Name = "Item_9",
						CLK = new BeckhoffBool(this.GetH_TrigOn8_Dot_CLK, client, 16448, 1174544){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn8_Dot_Q, client, 16448, 1174545){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn8_Dot_M, client, 16448, 1174546){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn9, client, 16448, 1174552)
					{
						 Name = "Item_10",
						CLK = new BeckhoffBool(this.GetH_TrigOn9_Dot_CLK, client, 16448, 1174560){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn9_Dot_Q, client, 16448, 1174561){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn9_Dot_M, client, 16448, 1174562){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn10, client, 16448, 1174568)
					{
						 Name = "Item_11",
						CLK = new BeckhoffBool(this.GetH_TrigOn10_Dot_CLK, client, 16448, 1174576){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn10_Dot_Q, client, 16448, 1174577){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn10_Dot_M, client, 16448, 1174578){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn11, client, 16448, 1174584)
					{
						 Name = "Item_12",
						CLK = new BeckhoffBool(this.GetH_TrigOn11_Dot_CLK, client, 16448, 1174592){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn11_Dot_Q, client, 16448, 1174593){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn11_Dot_M, client, 16448, 1174594){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn12, client, 16448, 1174600)
					{
						 Name = "Item_13",
						CLK = new BeckhoffBool(this.GetH_TrigOn12_Dot_CLK, client, 16448, 1174608){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn12_Dot_Q, client, 16448, 1174609){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn12_Dot_M, client, 16448, 1174610){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn13, client, 16448, 1174616)
					{
						 Name = "Item_14",
						CLK = new BeckhoffBool(this.GetH_TrigOn13_Dot_CLK, client, 16448, 1174624){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn13_Dot_Q, client, 16448, 1174625){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn13_Dot_M, client, 16448, 1174626){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn14, client, 16448, 1174632)
					{
						 Name = "Item_15",
						CLK = new BeckhoffBool(this.GetH_TrigOn14_Dot_CLK, client, 16448, 1174640){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn14_Dot_Q, client, 16448, 1174641){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn14_Dot_M, client, 16448, 1174642){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn15, client, 16448, 1174648)
					{
						 Name = "Item_16",
						CLK = new BeckhoffBool(this.GetH_TrigOn15_Dot_CLK, client, 16448, 1174656){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn15_Dot_Q, client, 16448, 1174657){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn15_Dot_M, client, 16448, 1174658){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn16, client, 16448, 1174664)
					{
						 Name = "Item_17",
						CLK = new BeckhoffBool(this.GetH_TrigOn16_Dot_CLK, client, 16448, 1174672){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn16_Dot_Q, client, 16448, 1174673){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn16_Dot_M, client, 16448, 1174674){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn17, client, 16448, 1174680)
					{
						 Name = "Item_18",
						CLK = new BeckhoffBool(this.GetH_TrigOn17_Dot_CLK, client, 16448, 1174688){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn17_Dot_Q, client, 16448, 1174689){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn17_Dot_M, client, 16448, 1174690){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn18, client, 16448, 1174696)
					{
						 Name = "Item_19",
						CLK = new BeckhoffBool(this.GetH_TrigOn18_Dot_CLK, client, 16448, 1174704){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn18_Dot_Q, client, 16448, 1174705){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn18_Dot_M, client, 16448, 1174706){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetH_TrigOn19, client, 16448, 1174712)
					{
						 Name = "Item_20",
						CLK = new BeckhoffBool(this.GetH_TrigOn19_Dot_CLK, client, 16448, 1174720){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetH_TrigOn19_Dot_Q, client, 16448, 1174721){ Name = "Q" },
						M = new BeckhoffBool(this.GetH_TrigOn19_Dot_M, client, 16448, 1174722){ Name = "M" },
					},
			}, false){ Name = "H_TrigOn" };
			L_DelayOn = new BeckhoffStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON>(this.GetL_DelayOn, client, 16448, 1174728,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1174728 ,1174760 ,1174792 ,1174824 ,1174856 ,1174888 ,1174920 ,1174952 ,1174984 ,1175016 ,1175048 ,1175080 ,1175112 ,1175144 ,1175176 ,1175208 ,1175240 ,1175272 ,1175304 ,1175336 , },
				new Tc2_Standard_TONWrapper[]
				{
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn0, client, 16448, 1174728)
					{
						 Name = "Item_1",
						IN = new BeckhoffBool(this.GetL_DelayOn0_Dot_IN, client, 16448, 1174736){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn0_Dot_PT, client, 16448, 1174740){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn0_Dot_Q, client, 16448, 1174744){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn0_Dot_ET, client, 16448, 1174748){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn0_Dot_M, client, 16448, 1174752){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn0_Dot_StartTime, client, 16448, 1174756){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn1, client, 16448, 1174760)
					{
						 Name = "Item_2",
						IN = new BeckhoffBool(this.GetL_DelayOn1_Dot_IN, client, 16448, 1174768){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn1_Dot_PT, client, 16448, 1174772){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn1_Dot_Q, client, 16448, 1174776){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn1_Dot_ET, client, 16448, 1174780){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn1_Dot_M, client, 16448, 1174784){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn1_Dot_StartTime, client, 16448, 1174788){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn2, client, 16448, 1174792)
					{
						 Name = "Item_3",
						IN = new BeckhoffBool(this.GetL_DelayOn2_Dot_IN, client, 16448, 1174800){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn2_Dot_PT, client, 16448, 1174804){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn2_Dot_Q, client, 16448, 1174808){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn2_Dot_ET, client, 16448, 1174812){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn2_Dot_M, client, 16448, 1174816){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn2_Dot_StartTime, client, 16448, 1174820){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn3, client, 16448, 1174824)
					{
						 Name = "Item_4",
						IN = new BeckhoffBool(this.GetL_DelayOn3_Dot_IN, client, 16448, 1174832){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn3_Dot_PT, client, 16448, 1174836){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn3_Dot_Q, client, 16448, 1174840){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn3_Dot_ET, client, 16448, 1174844){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn3_Dot_M, client, 16448, 1174848){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn3_Dot_StartTime, client, 16448, 1174852){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn4, client, 16448, 1174856)
					{
						 Name = "Item_5",
						IN = new BeckhoffBool(this.GetL_DelayOn4_Dot_IN, client, 16448, 1174864){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn4_Dot_PT, client, 16448, 1174868){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn4_Dot_Q, client, 16448, 1174872){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn4_Dot_ET, client, 16448, 1174876){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn4_Dot_M, client, 16448, 1174880){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn4_Dot_StartTime, client, 16448, 1174884){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn5, client, 16448, 1174888)
					{
						 Name = "Item_6",
						IN = new BeckhoffBool(this.GetL_DelayOn5_Dot_IN, client, 16448, 1174896){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn5_Dot_PT, client, 16448, 1174900){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn5_Dot_Q, client, 16448, 1174904){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn5_Dot_ET, client, 16448, 1174908){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn5_Dot_M, client, 16448, 1174912){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn5_Dot_StartTime, client, 16448, 1174916){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn6, client, 16448, 1174920)
					{
						 Name = "Item_7",
						IN = new BeckhoffBool(this.GetL_DelayOn6_Dot_IN, client, 16448, 1174928){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn6_Dot_PT, client, 16448, 1174932){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn6_Dot_Q, client, 16448, 1174936){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn6_Dot_ET, client, 16448, 1174940){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn6_Dot_M, client, 16448, 1174944){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn6_Dot_StartTime, client, 16448, 1174948){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn7, client, 16448, 1174952)
					{
						 Name = "Item_8",
						IN = new BeckhoffBool(this.GetL_DelayOn7_Dot_IN, client, 16448, 1174960){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn7_Dot_PT, client, 16448, 1174964){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn7_Dot_Q, client, 16448, 1174968){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn7_Dot_ET, client, 16448, 1174972){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn7_Dot_M, client, 16448, 1174976){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn7_Dot_StartTime, client, 16448, 1174980){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn8, client, 16448, 1174984)
					{
						 Name = "Item_9",
						IN = new BeckhoffBool(this.GetL_DelayOn8_Dot_IN, client, 16448, 1174992){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn8_Dot_PT, client, 16448, 1174996){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn8_Dot_Q, client, 16448, 1175000){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn8_Dot_ET, client, 16448, 1175004){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn8_Dot_M, client, 16448, 1175008){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn8_Dot_StartTime, client, 16448, 1175012){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn9, client, 16448, 1175016)
					{
						 Name = "Item_10",
						IN = new BeckhoffBool(this.GetL_DelayOn9_Dot_IN, client, 16448, 1175024){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn9_Dot_PT, client, 16448, 1175028){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn9_Dot_Q, client, 16448, 1175032){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn9_Dot_ET, client, 16448, 1175036){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn9_Dot_M, client, 16448, 1175040){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn9_Dot_StartTime, client, 16448, 1175044){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn10, client, 16448, 1175048)
					{
						 Name = "Item_11",
						IN = new BeckhoffBool(this.GetL_DelayOn10_Dot_IN, client, 16448, 1175056){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn10_Dot_PT, client, 16448, 1175060){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn10_Dot_Q, client, 16448, 1175064){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn10_Dot_ET, client, 16448, 1175068){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn10_Dot_M, client, 16448, 1175072){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn10_Dot_StartTime, client, 16448, 1175076){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn11, client, 16448, 1175080)
					{
						 Name = "Item_12",
						IN = new BeckhoffBool(this.GetL_DelayOn11_Dot_IN, client, 16448, 1175088){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn11_Dot_PT, client, 16448, 1175092){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn11_Dot_Q, client, 16448, 1175096){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn11_Dot_ET, client, 16448, 1175100){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn11_Dot_M, client, 16448, 1175104){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn11_Dot_StartTime, client, 16448, 1175108){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn12, client, 16448, 1175112)
					{
						 Name = "Item_13",
						IN = new BeckhoffBool(this.GetL_DelayOn12_Dot_IN, client, 16448, 1175120){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn12_Dot_PT, client, 16448, 1175124){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn12_Dot_Q, client, 16448, 1175128){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn12_Dot_ET, client, 16448, 1175132){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn12_Dot_M, client, 16448, 1175136){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn12_Dot_StartTime, client, 16448, 1175140){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn13, client, 16448, 1175144)
					{
						 Name = "Item_14",
						IN = new BeckhoffBool(this.GetL_DelayOn13_Dot_IN, client, 16448, 1175152){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn13_Dot_PT, client, 16448, 1175156){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn13_Dot_Q, client, 16448, 1175160){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn13_Dot_ET, client, 16448, 1175164){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn13_Dot_M, client, 16448, 1175168){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn13_Dot_StartTime, client, 16448, 1175172){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn14, client, 16448, 1175176)
					{
						 Name = "Item_15",
						IN = new BeckhoffBool(this.GetL_DelayOn14_Dot_IN, client, 16448, 1175184){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn14_Dot_PT, client, 16448, 1175188){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn14_Dot_Q, client, 16448, 1175192){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn14_Dot_ET, client, 16448, 1175196){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn14_Dot_M, client, 16448, 1175200){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn14_Dot_StartTime, client, 16448, 1175204){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn15, client, 16448, 1175208)
					{
						 Name = "Item_16",
						IN = new BeckhoffBool(this.GetL_DelayOn15_Dot_IN, client, 16448, 1175216){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn15_Dot_PT, client, 16448, 1175220){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn15_Dot_Q, client, 16448, 1175224){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn15_Dot_ET, client, 16448, 1175228){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn15_Dot_M, client, 16448, 1175232){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn15_Dot_StartTime, client, 16448, 1175236){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn16, client, 16448, 1175240)
					{
						 Name = "Item_17",
						IN = new BeckhoffBool(this.GetL_DelayOn16_Dot_IN, client, 16448, 1175248){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn16_Dot_PT, client, 16448, 1175252){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn16_Dot_Q, client, 16448, 1175256){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn16_Dot_ET, client, 16448, 1175260){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn16_Dot_M, client, 16448, 1175264){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn16_Dot_StartTime, client, 16448, 1175268){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn17, client, 16448, 1175272)
					{
						 Name = "Item_18",
						IN = new BeckhoffBool(this.GetL_DelayOn17_Dot_IN, client, 16448, 1175280){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn17_Dot_PT, client, 16448, 1175284){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn17_Dot_Q, client, 16448, 1175288){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn17_Dot_ET, client, 16448, 1175292){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn17_Dot_M, client, 16448, 1175296){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn17_Dot_StartTime, client, 16448, 1175300){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn18, client, 16448, 1175304)
					{
						 Name = "Item_19",
						IN = new BeckhoffBool(this.GetL_DelayOn18_Dot_IN, client, 16448, 1175312){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn18_Dot_PT, client, 16448, 1175316){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn18_Dot_Q, client, 16448, 1175320){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn18_Dot_ET, client, 16448, 1175324){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn18_Dot_M, client, 16448, 1175328){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn18_Dot_StartTime, client, 16448, 1175332){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetL_DelayOn19, client, 16448, 1175336)
					{
						 Name = "Item_20",
						IN = new BeckhoffBool(this.GetL_DelayOn19_Dot_IN, client, 16448, 1175344){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetL_DelayOn19_Dot_PT, client, 16448, 1175348){ Name = "PT" },
						Q = new BeckhoffBool(this.GetL_DelayOn19_Dot_Q, client, 16448, 1175352){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetL_DelayOn19_Dot_ET, client, 16448, 1175356){ Name = "ET" },
						M = new BeckhoffBool(this.GetL_DelayOn19_Dot_M, client, 16448, 1175360){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetL_DelayOn19_Dot_StartTime, client, 16448, 1175364){ Name = "StartTime" },
					},
			}, false){ Name = "L_DelayOn" };
			L_TrigOn = new BeckhoffStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG>(this.GetL_TrigOn, client, 16448, 1175368,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1175368 ,1175384 ,1175400 ,1175416 ,1175432 ,1175448 ,1175464 ,1175480 ,1175496 ,1175512 ,1175528 ,1175544 ,1175560 ,1175576 ,1175592 ,1175608 ,1175624 ,1175640 ,1175656 ,1175672 , },
				new Tc2_Standard_R_TRIGWrapper[]
				{
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn0, client, 16448, 1175368)
					{
						 Name = "Item_1",
						CLK = new BeckhoffBool(this.GetL_TrigOn0_Dot_CLK, client, 16448, 1175376){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn0_Dot_Q, client, 16448, 1175377){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn0_Dot_M, client, 16448, 1175378){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn1, client, 16448, 1175384)
					{
						 Name = "Item_2",
						CLK = new BeckhoffBool(this.GetL_TrigOn1_Dot_CLK, client, 16448, 1175392){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn1_Dot_Q, client, 16448, 1175393){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn1_Dot_M, client, 16448, 1175394){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn2, client, 16448, 1175400)
					{
						 Name = "Item_3",
						CLK = new BeckhoffBool(this.GetL_TrigOn2_Dot_CLK, client, 16448, 1175408){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn2_Dot_Q, client, 16448, 1175409){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn2_Dot_M, client, 16448, 1175410){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn3, client, 16448, 1175416)
					{
						 Name = "Item_4",
						CLK = new BeckhoffBool(this.GetL_TrigOn3_Dot_CLK, client, 16448, 1175424){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn3_Dot_Q, client, 16448, 1175425){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn3_Dot_M, client, 16448, 1175426){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn4, client, 16448, 1175432)
					{
						 Name = "Item_5",
						CLK = new BeckhoffBool(this.GetL_TrigOn4_Dot_CLK, client, 16448, 1175440){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn4_Dot_Q, client, 16448, 1175441){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn4_Dot_M, client, 16448, 1175442){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn5, client, 16448, 1175448)
					{
						 Name = "Item_6",
						CLK = new BeckhoffBool(this.GetL_TrigOn5_Dot_CLK, client, 16448, 1175456){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn5_Dot_Q, client, 16448, 1175457){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn5_Dot_M, client, 16448, 1175458){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn6, client, 16448, 1175464)
					{
						 Name = "Item_7",
						CLK = new BeckhoffBool(this.GetL_TrigOn6_Dot_CLK, client, 16448, 1175472){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn6_Dot_Q, client, 16448, 1175473){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn6_Dot_M, client, 16448, 1175474){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn7, client, 16448, 1175480)
					{
						 Name = "Item_8",
						CLK = new BeckhoffBool(this.GetL_TrigOn7_Dot_CLK, client, 16448, 1175488){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn7_Dot_Q, client, 16448, 1175489){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn7_Dot_M, client, 16448, 1175490){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn8, client, 16448, 1175496)
					{
						 Name = "Item_9",
						CLK = new BeckhoffBool(this.GetL_TrigOn8_Dot_CLK, client, 16448, 1175504){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn8_Dot_Q, client, 16448, 1175505){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn8_Dot_M, client, 16448, 1175506){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn9, client, 16448, 1175512)
					{
						 Name = "Item_10",
						CLK = new BeckhoffBool(this.GetL_TrigOn9_Dot_CLK, client, 16448, 1175520){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn9_Dot_Q, client, 16448, 1175521){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn9_Dot_M, client, 16448, 1175522){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn10, client, 16448, 1175528)
					{
						 Name = "Item_11",
						CLK = new BeckhoffBool(this.GetL_TrigOn10_Dot_CLK, client, 16448, 1175536){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn10_Dot_Q, client, 16448, 1175537){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn10_Dot_M, client, 16448, 1175538){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn11, client, 16448, 1175544)
					{
						 Name = "Item_12",
						CLK = new BeckhoffBool(this.GetL_TrigOn11_Dot_CLK, client, 16448, 1175552){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn11_Dot_Q, client, 16448, 1175553){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn11_Dot_M, client, 16448, 1175554){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn12, client, 16448, 1175560)
					{
						 Name = "Item_13",
						CLK = new BeckhoffBool(this.GetL_TrigOn12_Dot_CLK, client, 16448, 1175568){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn12_Dot_Q, client, 16448, 1175569){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn12_Dot_M, client, 16448, 1175570){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn13, client, 16448, 1175576)
					{
						 Name = "Item_14",
						CLK = new BeckhoffBool(this.GetL_TrigOn13_Dot_CLK, client, 16448, 1175584){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn13_Dot_Q, client, 16448, 1175585){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn13_Dot_M, client, 16448, 1175586){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn14, client, 16448, 1175592)
					{
						 Name = "Item_15",
						CLK = new BeckhoffBool(this.GetL_TrigOn14_Dot_CLK, client, 16448, 1175600){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn14_Dot_Q, client, 16448, 1175601){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn14_Dot_M, client, 16448, 1175602){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn15, client, 16448, 1175608)
					{
						 Name = "Item_16",
						CLK = new BeckhoffBool(this.GetL_TrigOn15_Dot_CLK, client, 16448, 1175616){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn15_Dot_Q, client, 16448, 1175617){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn15_Dot_M, client, 16448, 1175618){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn16, client, 16448, 1175624)
					{
						 Name = "Item_17",
						CLK = new BeckhoffBool(this.GetL_TrigOn16_Dot_CLK, client, 16448, 1175632){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn16_Dot_Q, client, 16448, 1175633){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn16_Dot_M, client, 16448, 1175634){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn17, client, 16448, 1175640)
					{
						 Name = "Item_18",
						CLK = new BeckhoffBool(this.GetL_TrigOn17_Dot_CLK, client, 16448, 1175648){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn17_Dot_Q, client, 16448, 1175649){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn17_Dot_M, client, 16448, 1175650){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn18, client, 16448, 1175656)
					{
						 Name = "Item_19",
						CLK = new BeckhoffBool(this.GetL_TrigOn18_Dot_CLK, client, 16448, 1175664){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn18_Dot_Q, client, 16448, 1175665){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn18_Dot_M, client, 16448, 1175666){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetL_TrigOn19, client, 16448, 1175672)
					{
						 Name = "Item_20",
						CLK = new BeckhoffBool(this.GetL_TrigOn19_Dot_CLK, client, 16448, 1175680){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetL_TrigOn19_Dot_Q, client, 16448, 1175681){ Name = "Q" },
						M = new BeckhoffBool(this.GetL_TrigOn19_Dot_M, client, 16448, 1175682){ Name = "M" },
					},
			}, false){ Name = "L_TrigOn" };
			UL_DelayOn = new BeckhoffStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON>(this.GetUL_DelayOn, client, 16448, 1175688,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1175688 ,1175720 ,1175752 ,1175784 ,1175816 ,1175848 ,1175880 ,1175912 ,1175944 ,1175976 ,1176008 ,1176040 ,1176072 ,1176104 ,1176136 ,1176168 ,1176200 ,1176232 ,1176264 ,1176296 , },
				new Tc2_Standard_TONWrapper[]
				{
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn0, client, 16448, 1175688)
					{
						 Name = "Item_1",
						IN = new BeckhoffBool(this.GetUL_DelayOn0_Dot_IN, client, 16448, 1175696){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn0_Dot_PT, client, 16448, 1175700){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn0_Dot_Q, client, 16448, 1175704){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn0_Dot_ET, client, 16448, 1175708){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn0_Dot_M, client, 16448, 1175712){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn0_Dot_StartTime, client, 16448, 1175716){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn1, client, 16448, 1175720)
					{
						 Name = "Item_2",
						IN = new BeckhoffBool(this.GetUL_DelayOn1_Dot_IN, client, 16448, 1175728){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn1_Dot_PT, client, 16448, 1175732){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn1_Dot_Q, client, 16448, 1175736){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn1_Dot_ET, client, 16448, 1175740){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn1_Dot_M, client, 16448, 1175744){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn1_Dot_StartTime, client, 16448, 1175748){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn2, client, 16448, 1175752)
					{
						 Name = "Item_3",
						IN = new BeckhoffBool(this.GetUL_DelayOn2_Dot_IN, client, 16448, 1175760){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn2_Dot_PT, client, 16448, 1175764){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn2_Dot_Q, client, 16448, 1175768){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn2_Dot_ET, client, 16448, 1175772){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn2_Dot_M, client, 16448, 1175776){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn2_Dot_StartTime, client, 16448, 1175780){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn3, client, 16448, 1175784)
					{
						 Name = "Item_4",
						IN = new BeckhoffBool(this.GetUL_DelayOn3_Dot_IN, client, 16448, 1175792){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn3_Dot_PT, client, 16448, 1175796){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn3_Dot_Q, client, 16448, 1175800){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn3_Dot_ET, client, 16448, 1175804){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn3_Dot_M, client, 16448, 1175808){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn3_Dot_StartTime, client, 16448, 1175812){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn4, client, 16448, 1175816)
					{
						 Name = "Item_5",
						IN = new BeckhoffBool(this.GetUL_DelayOn4_Dot_IN, client, 16448, 1175824){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn4_Dot_PT, client, 16448, 1175828){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn4_Dot_Q, client, 16448, 1175832){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn4_Dot_ET, client, 16448, 1175836){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn4_Dot_M, client, 16448, 1175840){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn4_Dot_StartTime, client, 16448, 1175844){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn5, client, 16448, 1175848)
					{
						 Name = "Item_6",
						IN = new BeckhoffBool(this.GetUL_DelayOn5_Dot_IN, client, 16448, 1175856){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn5_Dot_PT, client, 16448, 1175860){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn5_Dot_Q, client, 16448, 1175864){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn5_Dot_ET, client, 16448, 1175868){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn5_Dot_M, client, 16448, 1175872){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn5_Dot_StartTime, client, 16448, 1175876){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn6, client, 16448, 1175880)
					{
						 Name = "Item_7",
						IN = new BeckhoffBool(this.GetUL_DelayOn6_Dot_IN, client, 16448, 1175888){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn6_Dot_PT, client, 16448, 1175892){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn6_Dot_Q, client, 16448, 1175896){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn6_Dot_ET, client, 16448, 1175900){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn6_Dot_M, client, 16448, 1175904){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn6_Dot_StartTime, client, 16448, 1175908){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn7, client, 16448, 1175912)
					{
						 Name = "Item_8",
						IN = new BeckhoffBool(this.GetUL_DelayOn7_Dot_IN, client, 16448, 1175920){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn7_Dot_PT, client, 16448, 1175924){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn7_Dot_Q, client, 16448, 1175928){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn7_Dot_ET, client, 16448, 1175932){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn7_Dot_M, client, 16448, 1175936){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn7_Dot_StartTime, client, 16448, 1175940){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn8, client, 16448, 1175944)
					{
						 Name = "Item_9",
						IN = new BeckhoffBool(this.GetUL_DelayOn8_Dot_IN, client, 16448, 1175952){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn8_Dot_PT, client, 16448, 1175956){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn8_Dot_Q, client, 16448, 1175960){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn8_Dot_ET, client, 16448, 1175964){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn8_Dot_M, client, 16448, 1175968){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn8_Dot_StartTime, client, 16448, 1175972){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn9, client, 16448, 1175976)
					{
						 Name = "Item_10",
						IN = new BeckhoffBool(this.GetUL_DelayOn9_Dot_IN, client, 16448, 1175984){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn9_Dot_PT, client, 16448, 1175988){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn9_Dot_Q, client, 16448, 1175992){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn9_Dot_ET, client, 16448, 1175996){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn9_Dot_M, client, 16448, 1176000){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn9_Dot_StartTime, client, 16448, 1176004){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn10, client, 16448, 1176008)
					{
						 Name = "Item_11",
						IN = new BeckhoffBool(this.GetUL_DelayOn10_Dot_IN, client, 16448, 1176016){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn10_Dot_PT, client, 16448, 1176020){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn10_Dot_Q, client, 16448, 1176024){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn10_Dot_ET, client, 16448, 1176028){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn10_Dot_M, client, 16448, 1176032){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn10_Dot_StartTime, client, 16448, 1176036){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn11, client, 16448, 1176040)
					{
						 Name = "Item_12",
						IN = new BeckhoffBool(this.GetUL_DelayOn11_Dot_IN, client, 16448, 1176048){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn11_Dot_PT, client, 16448, 1176052){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn11_Dot_Q, client, 16448, 1176056){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn11_Dot_ET, client, 16448, 1176060){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn11_Dot_M, client, 16448, 1176064){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn11_Dot_StartTime, client, 16448, 1176068){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn12, client, 16448, 1176072)
					{
						 Name = "Item_13",
						IN = new BeckhoffBool(this.GetUL_DelayOn12_Dot_IN, client, 16448, 1176080){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn12_Dot_PT, client, 16448, 1176084){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn12_Dot_Q, client, 16448, 1176088){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn12_Dot_ET, client, 16448, 1176092){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn12_Dot_M, client, 16448, 1176096){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn12_Dot_StartTime, client, 16448, 1176100){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn13, client, 16448, 1176104)
					{
						 Name = "Item_14",
						IN = new BeckhoffBool(this.GetUL_DelayOn13_Dot_IN, client, 16448, 1176112){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn13_Dot_PT, client, 16448, 1176116){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn13_Dot_Q, client, 16448, 1176120){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn13_Dot_ET, client, 16448, 1176124){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn13_Dot_M, client, 16448, 1176128){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn13_Dot_StartTime, client, 16448, 1176132){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn14, client, 16448, 1176136)
					{
						 Name = "Item_15",
						IN = new BeckhoffBool(this.GetUL_DelayOn14_Dot_IN, client, 16448, 1176144){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn14_Dot_PT, client, 16448, 1176148){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn14_Dot_Q, client, 16448, 1176152){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn14_Dot_ET, client, 16448, 1176156){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn14_Dot_M, client, 16448, 1176160){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn14_Dot_StartTime, client, 16448, 1176164){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn15, client, 16448, 1176168)
					{
						 Name = "Item_16",
						IN = new BeckhoffBool(this.GetUL_DelayOn15_Dot_IN, client, 16448, 1176176){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn15_Dot_PT, client, 16448, 1176180){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn15_Dot_Q, client, 16448, 1176184){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn15_Dot_ET, client, 16448, 1176188){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn15_Dot_M, client, 16448, 1176192){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn15_Dot_StartTime, client, 16448, 1176196){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn16, client, 16448, 1176200)
					{
						 Name = "Item_17",
						IN = new BeckhoffBool(this.GetUL_DelayOn16_Dot_IN, client, 16448, 1176208){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn16_Dot_PT, client, 16448, 1176212){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn16_Dot_Q, client, 16448, 1176216){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn16_Dot_ET, client, 16448, 1176220){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn16_Dot_M, client, 16448, 1176224){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn16_Dot_StartTime, client, 16448, 1176228){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn17, client, 16448, 1176232)
					{
						 Name = "Item_18",
						IN = new BeckhoffBool(this.GetUL_DelayOn17_Dot_IN, client, 16448, 1176240){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn17_Dot_PT, client, 16448, 1176244){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn17_Dot_Q, client, 16448, 1176248){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn17_Dot_ET, client, 16448, 1176252){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn17_Dot_M, client, 16448, 1176256){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn17_Dot_StartTime, client, 16448, 1176260){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn18, client, 16448, 1176264)
					{
						 Name = "Item_19",
						IN = new BeckhoffBool(this.GetUL_DelayOn18_Dot_IN, client, 16448, 1176272){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn18_Dot_PT, client, 16448, 1176276){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn18_Dot_Q, client, 16448, 1176280){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn18_Dot_ET, client, 16448, 1176284){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn18_Dot_M, client, 16448, 1176288){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn18_Dot_StartTime, client, 16448, 1176292){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetUL_DelayOn19, client, 16448, 1176296)
					{
						 Name = "Item_20",
						IN = new BeckhoffBool(this.GetUL_DelayOn19_Dot_IN, client, 16448, 1176304){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetUL_DelayOn19_Dot_PT, client, 16448, 1176308){ Name = "PT" },
						Q = new BeckhoffBool(this.GetUL_DelayOn19_Dot_Q, client, 16448, 1176312){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetUL_DelayOn19_Dot_ET, client, 16448, 1176316){ Name = "ET" },
						M = new BeckhoffBool(this.GetUL_DelayOn19_Dot_M, client, 16448, 1176320){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetUL_DelayOn19_Dot_StartTime, client, 16448, 1176324){ Name = "StartTime" },
					},
			}, false){ Name = "UL_DelayOn" };
			UL_TrigOn = new BeckhoffStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG>(this.GetUL_TrigOn, client, 16448, 1176328,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1176328 ,1176344 ,1176360 ,1176376 ,1176392 ,1176408 ,1176424 ,1176440 ,1176456 ,1176472 ,1176488 ,1176504 ,1176520 ,1176536 ,1176552 ,1176568 ,1176584 ,1176600 ,1176616 ,1176632 , },
				new Tc2_Standard_R_TRIGWrapper[]
				{
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn0, client, 16448, 1176328)
					{
						 Name = "Item_1",
						CLK = new BeckhoffBool(this.GetUL_TrigOn0_Dot_CLK, client, 16448, 1176336){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn0_Dot_Q, client, 16448, 1176337){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn0_Dot_M, client, 16448, 1176338){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn1, client, 16448, 1176344)
					{
						 Name = "Item_2",
						CLK = new BeckhoffBool(this.GetUL_TrigOn1_Dot_CLK, client, 16448, 1176352){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn1_Dot_Q, client, 16448, 1176353){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn1_Dot_M, client, 16448, 1176354){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn2, client, 16448, 1176360)
					{
						 Name = "Item_3",
						CLK = new BeckhoffBool(this.GetUL_TrigOn2_Dot_CLK, client, 16448, 1176368){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn2_Dot_Q, client, 16448, 1176369){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn2_Dot_M, client, 16448, 1176370){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn3, client, 16448, 1176376)
					{
						 Name = "Item_4",
						CLK = new BeckhoffBool(this.GetUL_TrigOn3_Dot_CLK, client, 16448, 1176384){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn3_Dot_Q, client, 16448, 1176385){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn3_Dot_M, client, 16448, 1176386){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn4, client, 16448, 1176392)
					{
						 Name = "Item_5",
						CLK = new BeckhoffBool(this.GetUL_TrigOn4_Dot_CLK, client, 16448, 1176400){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn4_Dot_Q, client, 16448, 1176401){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn4_Dot_M, client, 16448, 1176402){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn5, client, 16448, 1176408)
					{
						 Name = "Item_6",
						CLK = new BeckhoffBool(this.GetUL_TrigOn5_Dot_CLK, client, 16448, 1176416){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn5_Dot_Q, client, 16448, 1176417){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn5_Dot_M, client, 16448, 1176418){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn6, client, 16448, 1176424)
					{
						 Name = "Item_7",
						CLK = new BeckhoffBool(this.GetUL_TrigOn6_Dot_CLK, client, 16448, 1176432){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn6_Dot_Q, client, 16448, 1176433){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn6_Dot_M, client, 16448, 1176434){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn7, client, 16448, 1176440)
					{
						 Name = "Item_8",
						CLK = new BeckhoffBool(this.GetUL_TrigOn7_Dot_CLK, client, 16448, 1176448){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn7_Dot_Q, client, 16448, 1176449){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn7_Dot_M, client, 16448, 1176450){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn8, client, 16448, 1176456)
					{
						 Name = "Item_9",
						CLK = new BeckhoffBool(this.GetUL_TrigOn8_Dot_CLK, client, 16448, 1176464){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn8_Dot_Q, client, 16448, 1176465){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn8_Dot_M, client, 16448, 1176466){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn9, client, 16448, 1176472)
					{
						 Name = "Item_10",
						CLK = new BeckhoffBool(this.GetUL_TrigOn9_Dot_CLK, client, 16448, 1176480){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn9_Dot_Q, client, 16448, 1176481){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn9_Dot_M, client, 16448, 1176482){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn10, client, 16448, 1176488)
					{
						 Name = "Item_11",
						CLK = new BeckhoffBool(this.GetUL_TrigOn10_Dot_CLK, client, 16448, 1176496){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn10_Dot_Q, client, 16448, 1176497){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn10_Dot_M, client, 16448, 1176498){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn11, client, 16448, 1176504)
					{
						 Name = "Item_12",
						CLK = new BeckhoffBool(this.GetUL_TrigOn11_Dot_CLK, client, 16448, 1176512){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn11_Dot_Q, client, 16448, 1176513){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn11_Dot_M, client, 16448, 1176514){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn12, client, 16448, 1176520)
					{
						 Name = "Item_13",
						CLK = new BeckhoffBool(this.GetUL_TrigOn12_Dot_CLK, client, 16448, 1176528){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn12_Dot_Q, client, 16448, 1176529){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn12_Dot_M, client, 16448, 1176530){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn13, client, 16448, 1176536)
					{
						 Name = "Item_14",
						CLK = new BeckhoffBool(this.GetUL_TrigOn13_Dot_CLK, client, 16448, 1176544){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn13_Dot_Q, client, 16448, 1176545){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn13_Dot_M, client, 16448, 1176546){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn14, client, 16448, 1176552)
					{
						 Name = "Item_15",
						CLK = new BeckhoffBool(this.GetUL_TrigOn14_Dot_CLK, client, 16448, 1176560){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn14_Dot_Q, client, 16448, 1176561){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn14_Dot_M, client, 16448, 1176562){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn15, client, 16448, 1176568)
					{
						 Name = "Item_16",
						CLK = new BeckhoffBool(this.GetUL_TrigOn15_Dot_CLK, client, 16448, 1176576){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn15_Dot_Q, client, 16448, 1176577){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn15_Dot_M, client, 16448, 1176578){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn16, client, 16448, 1176584)
					{
						 Name = "Item_17",
						CLK = new BeckhoffBool(this.GetUL_TrigOn16_Dot_CLK, client, 16448, 1176592){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn16_Dot_Q, client, 16448, 1176593){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn16_Dot_M, client, 16448, 1176594){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn17, client, 16448, 1176600)
					{
						 Name = "Item_18",
						CLK = new BeckhoffBool(this.GetUL_TrigOn17_Dot_CLK, client, 16448, 1176608){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn17_Dot_Q, client, 16448, 1176609){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn17_Dot_M, client, 16448, 1176610){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn18, client, 16448, 1176616)
					{
						 Name = "Item_19",
						CLK = new BeckhoffBool(this.GetUL_TrigOn18_Dot_CLK, client, 16448, 1176624){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn18_Dot_Q, client, 16448, 1176625){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn18_Dot_M, client, 16448, 1176626){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetUL_TrigOn19, client, 16448, 1176632)
					{
						 Name = "Item_20",
						CLK = new BeckhoffBool(this.GetUL_TrigOn19_Dot_CLK, client, 16448, 1176640){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetUL_TrigOn19_Dot_Q, client, 16448, 1176641){ Name = "Q" },
						M = new BeckhoffBool(this.GetUL_TrigOn19_Dot_M, client, 16448, 1176642){ Name = "M" },
					},
			}, false){ Name = "UL_TrigOn" };
			DelayOn = new BeckhoffStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON>(this.GetDelayOn, client, 16448, 1176648,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1176648 ,1176680 ,1176712 ,1176744 ,1176776 ,1176808 ,1176840 ,1176872 ,1176904 ,1176936 ,1176968 ,1177000 ,1177032 ,1177064 ,1177096 ,1177128 ,1177160 ,1177192 ,1177224 ,1177256 , },
				new Tc2_Standard_TONWrapper[]
				{
					new Tc2_Standard_TONWrapper(this.GetDelayOn0, client, 16448, 1176648)
					{
						 Name = "Item_1",
						IN = new BeckhoffBool(this.GetDelayOn0_Dot_IN, client, 16448, 1176656){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn0_Dot_PT, client, 16448, 1176660){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn0_Dot_Q, client, 16448, 1176664){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn0_Dot_ET, client, 16448, 1176668){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn0_Dot_M, client, 16448, 1176672){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn0_Dot_StartTime, client, 16448, 1176676){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn1, client, 16448, 1176680)
					{
						 Name = "Item_2",
						IN = new BeckhoffBool(this.GetDelayOn1_Dot_IN, client, 16448, 1176688){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn1_Dot_PT, client, 16448, 1176692){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn1_Dot_Q, client, 16448, 1176696){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn1_Dot_ET, client, 16448, 1176700){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn1_Dot_M, client, 16448, 1176704){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn1_Dot_StartTime, client, 16448, 1176708){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn2, client, 16448, 1176712)
					{
						 Name = "Item_3",
						IN = new BeckhoffBool(this.GetDelayOn2_Dot_IN, client, 16448, 1176720){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn2_Dot_PT, client, 16448, 1176724){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn2_Dot_Q, client, 16448, 1176728){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn2_Dot_ET, client, 16448, 1176732){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn2_Dot_M, client, 16448, 1176736){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn2_Dot_StartTime, client, 16448, 1176740){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn3, client, 16448, 1176744)
					{
						 Name = "Item_4",
						IN = new BeckhoffBool(this.GetDelayOn3_Dot_IN, client, 16448, 1176752){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn3_Dot_PT, client, 16448, 1176756){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn3_Dot_Q, client, 16448, 1176760){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn3_Dot_ET, client, 16448, 1176764){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn3_Dot_M, client, 16448, 1176768){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn3_Dot_StartTime, client, 16448, 1176772){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn4, client, 16448, 1176776)
					{
						 Name = "Item_5",
						IN = new BeckhoffBool(this.GetDelayOn4_Dot_IN, client, 16448, 1176784){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn4_Dot_PT, client, 16448, 1176788){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn4_Dot_Q, client, 16448, 1176792){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn4_Dot_ET, client, 16448, 1176796){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn4_Dot_M, client, 16448, 1176800){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn4_Dot_StartTime, client, 16448, 1176804){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn5, client, 16448, 1176808)
					{
						 Name = "Item_6",
						IN = new BeckhoffBool(this.GetDelayOn5_Dot_IN, client, 16448, 1176816){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn5_Dot_PT, client, 16448, 1176820){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn5_Dot_Q, client, 16448, 1176824){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn5_Dot_ET, client, 16448, 1176828){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn5_Dot_M, client, 16448, 1176832){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn5_Dot_StartTime, client, 16448, 1176836){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn6, client, 16448, 1176840)
					{
						 Name = "Item_7",
						IN = new BeckhoffBool(this.GetDelayOn6_Dot_IN, client, 16448, 1176848){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn6_Dot_PT, client, 16448, 1176852){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn6_Dot_Q, client, 16448, 1176856){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn6_Dot_ET, client, 16448, 1176860){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn6_Dot_M, client, 16448, 1176864){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn6_Dot_StartTime, client, 16448, 1176868){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn7, client, 16448, 1176872)
					{
						 Name = "Item_8",
						IN = new BeckhoffBool(this.GetDelayOn7_Dot_IN, client, 16448, 1176880){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn7_Dot_PT, client, 16448, 1176884){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn7_Dot_Q, client, 16448, 1176888){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn7_Dot_ET, client, 16448, 1176892){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn7_Dot_M, client, 16448, 1176896){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn7_Dot_StartTime, client, 16448, 1176900){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn8, client, 16448, 1176904)
					{
						 Name = "Item_9",
						IN = new BeckhoffBool(this.GetDelayOn8_Dot_IN, client, 16448, 1176912){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn8_Dot_PT, client, 16448, 1176916){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn8_Dot_Q, client, 16448, 1176920){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn8_Dot_ET, client, 16448, 1176924){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn8_Dot_M, client, 16448, 1176928){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn8_Dot_StartTime, client, 16448, 1176932){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn9, client, 16448, 1176936)
					{
						 Name = "Item_10",
						IN = new BeckhoffBool(this.GetDelayOn9_Dot_IN, client, 16448, 1176944){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn9_Dot_PT, client, 16448, 1176948){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn9_Dot_Q, client, 16448, 1176952){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn9_Dot_ET, client, 16448, 1176956){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn9_Dot_M, client, 16448, 1176960){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn9_Dot_StartTime, client, 16448, 1176964){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn10, client, 16448, 1176968)
					{
						 Name = "Item_11",
						IN = new BeckhoffBool(this.GetDelayOn10_Dot_IN, client, 16448, 1176976){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn10_Dot_PT, client, 16448, 1176980){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn10_Dot_Q, client, 16448, 1176984){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn10_Dot_ET, client, 16448, 1176988){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn10_Dot_M, client, 16448, 1176992){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn10_Dot_StartTime, client, 16448, 1176996){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn11, client, 16448, 1177000)
					{
						 Name = "Item_12",
						IN = new BeckhoffBool(this.GetDelayOn11_Dot_IN, client, 16448, 1177008){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn11_Dot_PT, client, 16448, 1177012){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn11_Dot_Q, client, 16448, 1177016){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn11_Dot_ET, client, 16448, 1177020){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn11_Dot_M, client, 16448, 1177024){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn11_Dot_StartTime, client, 16448, 1177028){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn12, client, 16448, 1177032)
					{
						 Name = "Item_13",
						IN = new BeckhoffBool(this.GetDelayOn12_Dot_IN, client, 16448, 1177040){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn12_Dot_PT, client, 16448, 1177044){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn12_Dot_Q, client, 16448, 1177048){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn12_Dot_ET, client, 16448, 1177052){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn12_Dot_M, client, 16448, 1177056){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn12_Dot_StartTime, client, 16448, 1177060){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn13, client, 16448, 1177064)
					{
						 Name = "Item_14",
						IN = new BeckhoffBool(this.GetDelayOn13_Dot_IN, client, 16448, 1177072){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn13_Dot_PT, client, 16448, 1177076){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn13_Dot_Q, client, 16448, 1177080){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn13_Dot_ET, client, 16448, 1177084){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn13_Dot_M, client, 16448, 1177088){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn13_Dot_StartTime, client, 16448, 1177092){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn14, client, 16448, 1177096)
					{
						 Name = "Item_15",
						IN = new BeckhoffBool(this.GetDelayOn14_Dot_IN, client, 16448, 1177104){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn14_Dot_PT, client, 16448, 1177108){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn14_Dot_Q, client, 16448, 1177112){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn14_Dot_ET, client, 16448, 1177116){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn14_Dot_M, client, 16448, 1177120){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn14_Dot_StartTime, client, 16448, 1177124){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn15, client, 16448, 1177128)
					{
						 Name = "Item_16",
						IN = new BeckhoffBool(this.GetDelayOn15_Dot_IN, client, 16448, 1177136){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn15_Dot_PT, client, 16448, 1177140){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn15_Dot_Q, client, 16448, 1177144){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn15_Dot_ET, client, 16448, 1177148){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn15_Dot_M, client, 16448, 1177152){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn15_Dot_StartTime, client, 16448, 1177156){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn16, client, 16448, 1177160)
					{
						 Name = "Item_17",
						IN = new BeckhoffBool(this.GetDelayOn16_Dot_IN, client, 16448, 1177168){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn16_Dot_PT, client, 16448, 1177172){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn16_Dot_Q, client, 16448, 1177176){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn16_Dot_ET, client, 16448, 1177180){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn16_Dot_M, client, 16448, 1177184){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn16_Dot_StartTime, client, 16448, 1177188){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn17, client, 16448, 1177192)
					{
						 Name = "Item_18",
						IN = new BeckhoffBool(this.GetDelayOn17_Dot_IN, client, 16448, 1177200){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn17_Dot_PT, client, 16448, 1177204){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn17_Dot_Q, client, 16448, 1177208){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn17_Dot_ET, client, 16448, 1177212){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn17_Dot_M, client, 16448, 1177216){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn17_Dot_StartTime, client, 16448, 1177220){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn18, client, 16448, 1177224)
					{
						 Name = "Item_19",
						IN = new BeckhoffBool(this.GetDelayOn18_Dot_IN, client, 16448, 1177232){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn18_Dot_PT, client, 16448, 1177236){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn18_Dot_Q, client, 16448, 1177240){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn18_Dot_ET, client, 16448, 1177244){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn18_Dot_M, client, 16448, 1177248){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn18_Dot_StartTime, client, 16448, 1177252){ Name = "StartTime" },
					},
					new Tc2_Standard_TONWrapper(this.GetDelayOn19, client, 16448, 1177256)
					{
						 Name = "Item_20",
						IN = new BeckhoffBool(this.GetDelayOn19_Dot_IN, client, 16448, 1177264){ Name = "IN" },
						PT = new BeckhoffUInt(this.GetDelayOn19_Dot_PT, client, 16448, 1177268){ Name = "PT" },
						Q = new BeckhoffBool(this.GetDelayOn19_Dot_Q, client, 16448, 1177272){ Name = "Q" },
						ET = new BeckhoffUInt(this.GetDelayOn19_Dot_ET, client, 16448, 1177276){ Name = "ET" },
						M = new BeckhoffBool(this.GetDelayOn19_Dot_M, client, 16448, 1177280){ Name = "M" },
						StartTime = new BeckhoffUInt(this.GetDelayOn19_Dot_StartTime, client, 16448, 1177284){ Name = "StartTime" },
					},
			}, false){ Name = "DelayOn" };
			TrigOn = new BeckhoffStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG>(this.GetTrigOn, client, 16448, 1177288,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 1177288 ,1177304 ,1177320 ,1177336 ,1177352 ,1177368 ,1177384 ,1177400 ,1177416 ,1177432 ,1177448 ,1177464 ,1177480 ,1177496 ,1177512 ,1177528 ,1177544 ,1177560 ,1177576 ,1177592 , },
				new Tc2_Standard_R_TRIGWrapper[]
				{
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn0, client, 16448, 1177288)
					{
						 Name = "Item_1",
						CLK = new BeckhoffBool(this.GetTrigOn0_Dot_CLK, client, 16448, 1177296){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn0_Dot_Q, client, 16448, 1177297){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn0_Dot_M, client, 16448, 1177298){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn1, client, 16448, 1177304)
					{
						 Name = "Item_2",
						CLK = new BeckhoffBool(this.GetTrigOn1_Dot_CLK, client, 16448, 1177312){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn1_Dot_Q, client, 16448, 1177313){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn1_Dot_M, client, 16448, 1177314){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn2, client, 16448, 1177320)
					{
						 Name = "Item_3",
						CLK = new BeckhoffBool(this.GetTrigOn2_Dot_CLK, client, 16448, 1177328){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn2_Dot_Q, client, 16448, 1177329){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn2_Dot_M, client, 16448, 1177330){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn3, client, 16448, 1177336)
					{
						 Name = "Item_4",
						CLK = new BeckhoffBool(this.GetTrigOn3_Dot_CLK, client, 16448, 1177344){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn3_Dot_Q, client, 16448, 1177345){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn3_Dot_M, client, 16448, 1177346){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn4, client, 16448, 1177352)
					{
						 Name = "Item_5",
						CLK = new BeckhoffBool(this.GetTrigOn4_Dot_CLK, client, 16448, 1177360){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn4_Dot_Q, client, 16448, 1177361){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn4_Dot_M, client, 16448, 1177362){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn5, client, 16448, 1177368)
					{
						 Name = "Item_6",
						CLK = new BeckhoffBool(this.GetTrigOn5_Dot_CLK, client, 16448, 1177376){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn5_Dot_Q, client, 16448, 1177377){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn5_Dot_M, client, 16448, 1177378){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn6, client, 16448, 1177384)
					{
						 Name = "Item_7",
						CLK = new BeckhoffBool(this.GetTrigOn6_Dot_CLK, client, 16448, 1177392){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn6_Dot_Q, client, 16448, 1177393){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn6_Dot_M, client, 16448, 1177394){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn7, client, 16448, 1177400)
					{
						 Name = "Item_8",
						CLK = new BeckhoffBool(this.GetTrigOn7_Dot_CLK, client, 16448, 1177408){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn7_Dot_Q, client, 16448, 1177409){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn7_Dot_M, client, 16448, 1177410){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn8, client, 16448, 1177416)
					{
						 Name = "Item_9",
						CLK = new BeckhoffBool(this.GetTrigOn8_Dot_CLK, client, 16448, 1177424){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn8_Dot_Q, client, 16448, 1177425){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn8_Dot_M, client, 16448, 1177426){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn9, client, 16448, 1177432)
					{
						 Name = "Item_10",
						CLK = new BeckhoffBool(this.GetTrigOn9_Dot_CLK, client, 16448, 1177440){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn9_Dot_Q, client, 16448, 1177441){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn9_Dot_M, client, 16448, 1177442){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn10, client, 16448, 1177448)
					{
						 Name = "Item_11",
						CLK = new BeckhoffBool(this.GetTrigOn10_Dot_CLK, client, 16448, 1177456){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn10_Dot_Q, client, 16448, 1177457){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn10_Dot_M, client, 16448, 1177458){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn11, client, 16448, 1177464)
					{
						 Name = "Item_12",
						CLK = new BeckhoffBool(this.GetTrigOn11_Dot_CLK, client, 16448, 1177472){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn11_Dot_Q, client, 16448, 1177473){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn11_Dot_M, client, 16448, 1177474){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn12, client, 16448, 1177480)
					{
						 Name = "Item_13",
						CLK = new BeckhoffBool(this.GetTrigOn12_Dot_CLK, client, 16448, 1177488){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn12_Dot_Q, client, 16448, 1177489){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn12_Dot_M, client, 16448, 1177490){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn13, client, 16448, 1177496)
					{
						 Name = "Item_14",
						CLK = new BeckhoffBool(this.GetTrigOn13_Dot_CLK, client, 16448, 1177504){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn13_Dot_Q, client, 16448, 1177505){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn13_Dot_M, client, 16448, 1177506){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn14, client, 16448, 1177512)
					{
						 Name = "Item_15",
						CLK = new BeckhoffBool(this.GetTrigOn14_Dot_CLK, client, 16448, 1177520){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn14_Dot_Q, client, 16448, 1177521){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn14_Dot_M, client, 16448, 1177522){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn15, client, 16448, 1177528)
					{
						 Name = "Item_16",
						CLK = new BeckhoffBool(this.GetTrigOn15_Dot_CLK, client, 16448, 1177536){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn15_Dot_Q, client, 16448, 1177537){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn15_Dot_M, client, 16448, 1177538){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn16, client, 16448, 1177544)
					{
						 Name = "Item_17",
						CLK = new BeckhoffBool(this.GetTrigOn16_Dot_CLK, client, 16448, 1177552){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn16_Dot_Q, client, 16448, 1177553){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn16_Dot_M, client, 16448, 1177554){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn17, client, 16448, 1177560)
					{
						 Name = "Item_18",
						CLK = new BeckhoffBool(this.GetTrigOn17_Dot_CLK, client, 16448, 1177568){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn17_Dot_Q, client, 16448, 1177569){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn17_Dot_M, client, 16448, 1177570){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn18, client, 16448, 1177576)
					{
						 Name = "Item_19",
						CLK = new BeckhoffBool(this.GetTrigOn18_Dot_CLK, client, 16448, 1177584){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn18_Dot_Q, client, 16448, 1177585){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn18_Dot_M, client, 16448, 1177586){ Name = "M" },
					},
					new Tc2_Standard_R_TRIGWrapper(this.GetTrigOn19, client, 16448, 1177592)
					{
						 Name = "Item_20",
						CLK = new BeckhoffBool(this.GetTrigOn19_Dot_CLK, client, 16448, 1177600){ Name = "CLK" },
						Q = new BeckhoffBool(this.GetTrigOn19_Dot_Q, client, 16448, 1177601){ Name = "Q" },
						M = new BeckhoffBool(this.GetTrigOn19_Dot_M, client, 16448, 1177602){ Name = "M" },
					},
			}, false){ Name = "TrigOn" };
			Pos_YM_Receive_Base_Buffer = new BeckhoffFloat(this.GetPos_YM_Receive_Base_Buffer, client, 16448, 1177608){ Name = "Pos_YM_Receive_Base_Buffer" };
			Pos_YM_UnLoading_Case_Buffer = new BeckhoffFloat(this.GetPos_YM_UnLoading_Case_Buffer, client, 16448, 1177612){ Name = "Pos_YM_UnLoading_Case_Buffer" };
			Pos_ZM_Receive_Buffer = new BeckhoffFloat(this.GetPos_ZM_Receive_Buffer, client, 16448, 1177616){ Name = "Pos_ZM_Receive_Buffer" };
			Pos_ZM_Top_TO_Bottom = new BeckhoffFloat(this.GetPos_ZM_Top_TO_Bottom, client, 16448, 1177620){ Name = "Pos_ZM_Top_TO_Bottom" };
			Pos_ZM_Bottom_TO_Top = new BeckhoffFloat(this.GetPos_ZM_Bottom_TO_Top, client, 16448, 1177624){ Name = "Pos_ZM_Bottom_TO_Top" };
			AlarmCode = new BeckhoffUInt(this.GetAlarmCode, client, 16448, 1177628){ Name = "AlarmCode" };
			Pos_YM_Loading_Case = new BeckhoffDouble(this.GetPos_YM_Loading_Case, client, 16448, 1177632){ Name = "Pos_YM_Loading_Case" };
			Pos_YM_Receive_Base = new BeckhoffDouble(this.GetPos_YM_Receive_Base, client, 16448, 1177640){ Name = "Pos_YM_Receive_Base" };
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
		~OMH_UnitWrapper()
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
