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
	/// Name from PLC:GVL_PLC_Output_PC
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_PLC_Output_PCWrapper : BaseData, IBaseData
	{
		public override IEnumerable<IBaseData> Children
		{
			get
			{
				yield return G_Out_bIMH_Home_Done;
				yield return G_Out_bOMH_Home_Done;
				yield return G_Out_bFSU_Home_Done;
				yield return G_OUT_Barcode_Start_Request;
				yield return G_OUT_CleanVision_Request;
				yield return G_OUT_TransBonding_Suceess;
				yield return G_OUT_TransBonding_Fail;
				yield return G_OUT_Bonding_Vision_Request;
				yield return G_OUT_Substrate_InCleanPos;
				yield return G_OUT_Preform_Inspection_Start;
				yield return G_Out_CDA_Inspect_Result;
				yield return G_Out_Bonding_Ready;
				yield return G_OUT_WLU_Wafer_Ready;
				yield return G_Out_bWLU_Home_Done;
				yield return G_Out_bJOG_HighSpeed_Move;
				yield return G_Out_bJOG_LowSpeed_Move;
				yield return G_Out_Cursor_Speed;
			}
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(G_Out_bIMH_Home_Done):
					return G_Out_bIMH_Home_Done;
				case nameof(G_Out_bOMH_Home_Done):
					return G_Out_bOMH_Home_Done;
				case nameof(G_Out_bFSU_Home_Done):
					return G_Out_bFSU_Home_Done;
				case nameof(G_OUT_Barcode_Start_Request):
					return G_OUT_Barcode_Start_Request;
				case nameof(G_OUT_CleanVision_Request):
					return G_OUT_CleanVision_Request;
				case nameof(G_OUT_TransBonding_Suceess):
					return G_OUT_TransBonding_Suceess;
				case nameof(G_OUT_TransBonding_Fail):
					return G_OUT_TransBonding_Fail;
				case nameof(G_OUT_Bonding_Vision_Request):
					return G_OUT_Bonding_Vision_Request;
				case nameof(G_OUT_Substrate_InCleanPos):
					return G_OUT_Substrate_InCleanPos;
				case nameof(G_OUT_Preform_Inspection_Start):
					return G_OUT_Preform_Inspection_Start;
				case nameof(G_Out_CDA_Inspect_Result):
					return G_Out_CDA_Inspect_Result;
				case nameof(G_Out_Bonding_Ready):
					return G_Out_Bonding_Ready;
				case nameof(G_OUT_WLU_Wafer_Ready):
					return G_OUT_WLU_Wafer_Ready;
				case nameof(G_Out_bWLU_Home_Done):
					return G_Out_bWLU_Home_Done;
				case nameof(G_Out_bJOG_HighSpeed_Move):
					return G_Out_bJOG_HighSpeed_Move;
				case nameof(G_Out_bJOG_LowSpeed_Move):
					return G_Out_bJOG_LowSpeed_Move;
				case nameof(G_Out_Cursor_Speed):
					return G_Out_Cursor_Speed;
			}
			throw new KeyNotFoundException(name);
		}

		private readonly AdsClient client;

		public GVL_PLC_Output_PCWrapper(AdsClient client)
		{
			this.client = client;

			G_Out_bIMH_Home_Done = new BeckhoffBool(this.GetG_Out_bIMH_Home_Done, client, 16448, 2003576){ Name = "G_Out_bIMH_Home_Done" };
			G_Out_bOMH_Home_Done = new BeckhoffBool(this.GetG_Out_bOMH_Home_Done, client, 16448, 2003577){ Name = "G_Out_bOMH_Home_Done" };
			G_Out_bFSU_Home_Done = new BeckhoffBool(this.GetG_Out_bFSU_Home_Done, client, 16448, 2003578){ Name = "G_Out_bFSU_Home_Done" };
			G_OUT_Barcode_Start_Request = new BeckhoffBool(this.GetG_OUT_Barcode_Start_Request, client, 16448, 2003579){ Name = "G_OUT_Barcode_Start_Request" };
			G_OUT_CleanVision_Request = new BeckhoffBool(this.GetG_OUT_CleanVision_Request, client, 16448, 2003580){ Name = "G_OUT_CleanVision_Request" };
			G_OUT_TransBonding_Suceess = new BeckhoffBool(this.GetG_OUT_TransBonding_Suceess, client, 16448, 2003581){ Name = "G_OUT_TransBonding_Suceess" };
			G_OUT_TransBonding_Fail = new BeckhoffBool(this.GetG_OUT_TransBonding_Fail, client, 16448, 2003582){ Name = "G_OUT_TransBonding_Fail" };
			G_OUT_Bonding_Vision_Request = new BeckhoffBool(this.GetG_OUT_Bonding_Vision_Request, client, 16448, 2003583){ Name = "G_OUT_Bonding_Vision_Request" };
			G_OUT_Substrate_InCleanPos = new BeckhoffBool(this.GetG_OUT_Substrate_InCleanPos, client, 16448, 2003584){ Name = "G_OUT_Substrate_InCleanPos" };
			G_OUT_Preform_Inspection_Start = new BeckhoffBool(this.GetG_OUT_Preform_Inspection_Start, client, 16448, 2003585){ Name = "G_OUT_Preform_Inspection_Start" };
			G_Out_CDA_Inspect_Result = new BeckhoffShort(this.GetG_Out_CDA_Inspect_Result, client, 16448, 2003586){ Name = "G_Out_CDA_Inspect_Result" };
			G_Out_Bonding_Ready = new BeckhoffBool(this.GetG_Out_Bonding_Ready, client, 16448, 2003588){ Name = "G_Out_Bonding_Ready" };
			G_OUT_WLU_Wafer_Ready = new BeckhoffBool(this.GetG_OUT_WLU_Wafer_Ready, client, 16448, 2003589){ Name = "G_OUT_WLU_Wafer_Ready" };
			G_Out_bWLU_Home_Done = new BeckhoffBool(this.GetG_Out_bWLU_Home_Done, client, 16448, 2003590){ Name = "G_Out_bWLU_Home_Done" };
			G_Out_bJOG_HighSpeed_Move = new BeckhoffBool(this.GetG_Out_bJOG_HighSpeed_Move, client, 16448, 2003591){ Name = "G_Out_bJOG_HighSpeed_Move" };
			G_Out_bJOG_LowSpeed_Move = new BeckhoffBool(this.GetG_Out_bJOG_LowSpeed_Move, client, 16448, 2003592){ Name = "G_Out_bJOG_LowSpeed_Move" };
			G_Out_Cursor_Speed = new BeckhoffShort(this.GetG_Out_Cursor_Speed, client, 16448, 2003594){ Name = "G_Out_Cursor_Speed" };
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
		~GVL_PLC_Output_PCWrapper()
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
