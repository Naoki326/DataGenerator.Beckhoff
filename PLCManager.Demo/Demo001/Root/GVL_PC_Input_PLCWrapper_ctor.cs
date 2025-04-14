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
	/// Name from PLC:GVL_PC_Input_PLC
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_PC_Input_PLCWrapper : BaseData, IBaseData
	{
		public override IEnumerable<IBaseData> Children
		{
			get
			{
				yield return G_In_bAllHome;
				yield return G_IN_bAutoRun;
				yield return G_IN_bInitial;
				yield return G_In_Manual_Axis_bHomeStart;
				yield return G_In_Manual_Axis_AbsStart;
				yield return G_IN_bIMH_Home;
				yield return G_IN_bIMH_loadCase;
				yield return G_IN_bIMH_UnloadCase;
				yield return G_In_bIMH_Start;
				yield return G_Out_Axis_AbsPos;
				yield return G_In_bIMH_Auto_Run;
				yield return G_IN_bOMH_Home;
				yield return G_IN_bOMH_loadCase;
				yield return G_IN_bOMH_UnloadCase;
				yield return G_In_bOMH_Start;
				yield return G_In_bOMH_Auto_Run;
				yield return G_IN_bFSU_Home;
				yield return G_IN_bFSU_Strat;
				yield return G_Alarm_Index;
				yield return G_IN_Valve_Index;
				yield return G_IN_Sensor_Index;
				yield return G_IN_Manual_Axis_Index;
				yield return G_IN_Manual_Axis_Home_Index;
				yield return G_IN_Barcode_Suceess;
				yield return G_IN_Barcode_Fail;
				yield return G_IN_CleanVision_Sucess;
				yield return G_IN_CleanVision_Fail;
				yield return G_IN_TransBase_Bonding_Pos;
				yield return G_IN_TransBase_Request;
				yield return G_IN_Bonding_Cam_Result;
				yield return G_IN_Bonding_Visoion_Sucess;
				yield return G_IN_WAF_LOAD_Start;
				yield return G_IN_WAF_Unload_Start;
				yield return G_IN_bWLU_Start;
				yield return G_IN_bWLU_Home;
				yield return G_IN_bWLU_Table_Receive_Ready;
			}
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(G_In_bAllHome):
					return G_In_bAllHome;
				case nameof(G_IN_bAutoRun):
					return G_IN_bAutoRun;
				case nameof(G_IN_bInitial):
					return G_IN_bInitial;
				case nameof(G_In_Manual_Axis_bHomeStart):
					return G_In_Manual_Axis_bHomeStart;
				case nameof(G_In_Manual_Axis_AbsStart):
					return G_In_Manual_Axis_AbsStart;
				case nameof(G_IN_bIMH_Home):
					return G_IN_bIMH_Home;
				case nameof(G_IN_bIMH_loadCase):
					return G_IN_bIMH_loadCase;
				case nameof(G_IN_bIMH_UnloadCase):
					return G_IN_bIMH_UnloadCase;
				case nameof(G_In_bIMH_Start):
					return G_In_bIMH_Start;
				case nameof(G_Out_Axis_AbsPos):
					return G_Out_Axis_AbsPos;
				case nameof(G_In_bIMH_Auto_Run):
					return G_In_bIMH_Auto_Run;
				case nameof(G_IN_bOMH_Home):
					return G_IN_bOMH_Home;
				case nameof(G_IN_bOMH_loadCase):
					return G_IN_bOMH_loadCase;
				case nameof(G_IN_bOMH_UnloadCase):
					return G_IN_bOMH_UnloadCase;
				case nameof(G_In_bOMH_Start):
					return G_In_bOMH_Start;
				case nameof(G_In_bOMH_Auto_Run):
					return G_In_bOMH_Auto_Run;
				case nameof(G_IN_bFSU_Home):
					return G_IN_bFSU_Home;
				case nameof(G_IN_bFSU_Strat):
					return G_IN_bFSU_Strat;
				case nameof(G_Alarm_Index):
					return G_Alarm_Index;
				case nameof(G_IN_Valve_Index):
					return G_IN_Valve_Index;
				case nameof(G_IN_Sensor_Index):
					return G_IN_Sensor_Index;
				case nameof(G_IN_Manual_Axis_Index):
					return G_IN_Manual_Axis_Index;
				case nameof(G_IN_Manual_Axis_Home_Index):
					return G_IN_Manual_Axis_Home_Index;
				case nameof(G_IN_Barcode_Suceess):
					return G_IN_Barcode_Suceess;
				case nameof(G_IN_Barcode_Fail):
					return G_IN_Barcode_Fail;
				case nameof(G_IN_CleanVision_Sucess):
					return G_IN_CleanVision_Sucess;
				case nameof(G_IN_CleanVision_Fail):
					return G_IN_CleanVision_Fail;
				case nameof(G_IN_TransBase_Bonding_Pos):
					return G_IN_TransBase_Bonding_Pos;
				case nameof(G_IN_TransBase_Request):
					return G_IN_TransBase_Request;
				case nameof(G_IN_Bonding_Cam_Result):
					return G_IN_Bonding_Cam_Result;
				case nameof(G_IN_Bonding_Visoion_Sucess):
					return G_IN_Bonding_Visoion_Sucess;
				case nameof(G_IN_WAF_LOAD_Start):
					return G_IN_WAF_LOAD_Start;
				case nameof(G_IN_WAF_Unload_Start):
					return G_IN_WAF_Unload_Start;
				case nameof(G_IN_bWLU_Start):
					return G_IN_bWLU_Start;
				case nameof(G_IN_bWLU_Home):
					return G_IN_bWLU_Home;
				case nameof(G_IN_bWLU_Table_Receive_Ready):
					return G_IN_bWLU_Table_Receive_Ready;
			}
			throw new KeyNotFoundException(name);
		}

		private readonly AdsClient client;

		public GVL_PC_Input_PLCWrapper(AdsClient client)
		{
			this.client = client;

			G_In_bAllHome = new BeckhoffBool(this.GetG_In_bAllHome, client, 16448, 2003237){ Name = "G_In_bAllHome" };
			G_IN_bAutoRun = new BeckhoffBool(this.GetG_IN_bAutoRun, client, 16448, 2003238){ Name = "G_IN_bAutoRun" };
			G_IN_bInitial = new BeckhoffBool(this.GetG_IN_bInitial, client, 16448, 2003239){ Name = "G_IN_bInitial" };
			G_In_Manual_Axis_bHomeStart = new BeckhoffBoolArray<Bool30>(this.GetG_In_Manual_Axis_bHomeStart, client, 16448, 2003240,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 2003240 ,2003241 ,2003242 ,2003243 ,2003244 ,2003245 ,2003246 ,2003247 ,2003248 ,2003249 ,2003250 ,2003251 ,2003252 ,2003253 ,2003254 ,2003255 ,2003256 ,2003257 ,2003258 ,2003259 ,2003260 ,2003261 ,2003262 ,2003263 ,2003264 ,2003265 ,2003266 ,2003267 ,2003268 ,2003269 , }, false){ Name = "G_In_Manual_Axis_bHomeStart" };
			G_In_Manual_Axis_AbsStart = new BeckhoffBoolArray<Bool30>(this.GetG_In_Manual_Axis_AbsStart, client, 16448, 2003270,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 2003270 ,2003271 ,2003272 ,2003273 ,2003274 ,2003275 ,2003276 ,2003277 ,2003278 ,2003279 ,2003280 ,2003281 ,2003282 ,2003283 ,2003284 ,2003285 ,2003286 ,2003287 ,2003288 ,2003289 ,2003290 ,2003291 ,2003292 ,2003293 ,2003294 ,2003295 ,2003296 ,2003297 ,2003298 ,2003299 , }, false){ Name = "G_In_Manual_Axis_AbsStart" };
			G_IN_bIMH_Home = new BeckhoffBool(this.GetG_IN_bIMH_Home, client, 16448, 2003300){ Name = "G_IN_bIMH_Home" };
			G_IN_bIMH_loadCase = new BeckhoffBool(this.GetG_IN_bIMH_loadCase, client, 16448, 2003301){ Name = "G_IN_bIMH_loadCase" };
			G_IN_bIMH_UnloadCase = new BeckhoffBool(this.GetG_IN_bIMH_UnloadCase, client, 16448, 2003302){ Name = "G_IN_bIMH_UnloadCase" };
			G_In_bIMH_Start = new BeckhoffBool(this.GetG_In_bIMH_Start, client, 16448, 2003303){ Name = "G_In_bIMH_Start" };
			G_Out_Axis_AbsPos = new BeckhoffDoubleArray<Double30>(this.GetG_Out_Axis_AbsPos, client, 16448, 2003304,
				new uint[] { 16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 ,16448 , },
				new uint[] { 2003304 ,2003312 ,2003320 ,2003328 ,2003336 ,2003344 ,2003352 ,2003360 ,2003368 ,2003376 ,2003384 ,2003392 ,2003400 ,2003408 ,2003416 ,2003424 ,2003432 ,2003440 ,2003448 ,2003456 ,2003464 ,2003472 ,2003480 ,2003488 ,2003496 ,2003504 ,2003512 ,2003520 ,2003528 ,2003536 , }, false){ Name = "G_Out_Axis_AbsPos" };
			G_In_bIMH_Auto_Run = new BeckhoffBool(this.GetG_In_bIMH_Auto_Run, client, 16448, 2003544){ Name = "G_In_bIMH_Auto_Run" };
			G_IN_bOMH_Home = new BeckhoffBool(this.GetG_IN_bOMH_Home, client, 16448, 2003545){ Name = "G_IN_bOMH_Home" };
			G_IN_bOMH_loadCase = new BeckhoffBool(this.GetG_IN_bOMH_loadCase, client, 16448, 2003546){ Name = "G_IN_bOMH_loadCase" };
			G_IN_bOMH_UnloadCase = new BeckhoffBool(this.GetG_IN_bOMH_UnloadCase, client, 16448, 2003547){ Name = "G_IN_bOMH_UnloadCase" };
			G_In_bOMH_Start = new BeckhoffBool(this.GetG_In_bOMH_Start, client, 16448, 2003548){ Name = "G_In_bOMH_Start" };
			G_In_bOMH_Auto_Run = new BeckhoffBool(this.GetG_In_bOMH_Auto_Run, client, 16448, 2003549){ Name = "G_In_bOMH_Auto_Run" };
			G_IN_bFSU_Home = new BeckhoffBool(this.GetG_IN_bFSU_Home, client, 16448, 2003550){ Name = "G_IN_bFSU_Home" };
			G_IN_bFSU_Strat = new BeckhoffBool(this.GetG_IN_bFSU_Strat, client, 16448, 2003551){ Name = "G_IN_bFSU_Strat" };
			G_Alarm_Index = new BeckhoffUShort(this.GetG_Alarm_Index, client, 16448, 2003552){ Name = "G_Alarm_Index" };
			G_IN_Valve_Index = new BeckhoffShort(this.GetG_IN_Valve_Index, client, 16448, 2003554){ Name = "G_IN_Valve_Index" };
			G_IN_Sensor_Index = new BeckhoffShort(this.GetG_IN_Sensor_Index, client, 16448, 2003556){ Name = "G_IN_Sensor_Index" };
			G_IN_Manual_Axis_Index = new BeckhoffShort(this.GetG_IN_Manual_Axis_Index, client, 16448, 2003558){ Name = "G_IN_Manual_Axis_Index" };
			G_IN_Manual_Axis_Home_Index = new BeckhoffShort(this.GetG_IN_Manual_Axis_Home_Index, client, 16448, 2003560){ Name = "G_IN_Manual_Axis_Home_Index" };
			G_IN_Barcode_Suceess = new BeckhoffBool(this.GetG_IN_Barcode_Suceess, client, 16448, 2003562){ Name = "G_IN_Barcode_Suceess" };
			G_IN_Barcode_Fail = new BeckhoffBool(this.GetG_IN_Barcode_Fail, client, 16448, 2003563){ Name = "G_IN_Barcode_Fail" };
			G_IN_CleanVision_Sucess = new BeckhoffBool(this.GetG_IN_CleanVision_Sucess, client, 16448, 2003564){ Name = "G_IN_CleanVision_Sucess" };
			G_IN_CleanVision_Fail = new BeckhoffBool(this.GetG_IN_CleanVision_Fail, client, 16448, 2003565){ Name = "G_IN_CleanVision_Fail" };
			G_IN_TransBase_Bonding_Pos = new BeckhoffShort(this.GetG_IN_TransBase_Bonding_Pos, client, 16448, 2003566){ Name = "G_IN_TransBase_Bonding_Pos" };
			G_IN_TransBase_Request = new BeckhoffBool(this.GetG_IN_TransBase_Request, client, 16448, 2003568){ Name = "G_IN_TransBase_Request" };
			G_IN_Bonding_Cam_Result = new BeckhoffBool(this.GetG_IN_Bonding_Cam_Result, client, 16448, 2003569){ Name = "G_IN_Bonding_Cam_Result" };
			G_IN_Bonding_Visoion_Sucess = new BeckhoffBool(this.GetG_IN_Bonding_Visoion_Sucess, client, 16448, 2003570){ Name = "G_IN_Bonding_Visoion_Sucess" };
			G_IN_WAF_LOAD_Start = new BeckhoffBool(this.GetG_IN_WAF_LOAD_Start, client, 16448, 2003571){ Name = "G_IN_WAF_LOAD_Start" };
			G_IN_WAF_Unload_Start = new BeckhoffBool(this.GetG_IN_WAF_Unload_Start, client, 16448, 2003572){ Name = "G_IN_WAF_Unload_Start" };
			G_IN_bWLU_Start = new BeckhoffBool(this.GetG_IN_bWLU_Start, client, 16448, 2003573){ Name = "G_IN_bWLU_Start" };
			G_IN_bWLU_Home = new BeckhoffBool(this.GetG_IN_bWLU_Home, client, 16448, 2003574){ Name = "G_IN_bWLU_Home" };
			G_IN_bWLU_Table_Receive_Ready = new BeckhoffBool(this.GetG_IN_bWLU_Table_Receive_Ready, client, 16448, 2003575){ Name = "G_IN_bWLU_Table_Receive_Ready" };
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
		~GVL_PC_Input_PLCWrapper()
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
