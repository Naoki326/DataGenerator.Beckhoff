using System;
using System.Threading;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TwinCAT.Ads;
using PLCManager.Demo.Enum;
using PLCManager.Demo.Struct;
using PLCManager.Demo.Wrapper;
using PLCManager.Demo.Root;
using PlcCore.Beckhoff;
using PlcCore.Data;

namespace PLCManager.Demo
{

	public sealed class Demo001 : BaseData, IPLCRoot, IBaseData, IDisposable
	{

		public Demo001()
		{
			client = new AdsClient();
			
			Global_Variables = new Global_VariablesWrapper(client){ Name = "Global_Variables" };

			Global_Version = new Global_VersionWrapper(client){ Name = "Global_Version" };

			GVL_Alarm_Error = new GVL_Alarm_ErrorWrapper(client){ Name = "GVL_Alarm_Error" };

			GVL_IO_Index = new GVL_IO_IndexWrapper(client){ Name = "GVL_IO_Index" };

			GVL_Motion = new GVL_MotionWrapper(client){ Name = "GVL_Motion" };

			GVL_PC_Input_PLC = new GVL_PC_Input_PLCWrapper(client){ Name = "GVL_PC_Input_PLC" };

			GVL_PLC_Output_PC = new GVL_PLC_Output_PCWrapper(client){ Name = "GVL_PLC_Output_PC" };

			GVL_Recipe_Bool = new GVL_Recipe_BoolWrapper(client){ Name = "GVL_Recipe_Bool" };

			GVL_Recipe_TransferMaterial = new GVL_Recipe_TransferMaterialWrapper(client){ Name = "GVL_Recipe_TransferMaterial" };

			GVL_Recipe_TransferSetting = new GVL_Recipe_TransferSettingWrapper(client){ Name = "GVL_Recipe_TransferSetting" };

			GVL_Recipe_WafferMaterial = new GVL_Recipe_WafferMaterialWrapper(client){ Name = "GVL_Recipe_WafferMaterial" };

			GVL_Sensor_Used = new GVL_Sensor_UsedWrapper(client){ Name = "GVL_Sensor_Used" };

			GVL_Setup = new GVL_SetupWrapper(client){ Name = "GVL_Setup" };

			GVL_Unit = new GVL_UnitWrapper(client){ Name = "GVL_Unit" };

			IMH_Unit = new IMH_UnitWrapper(client){ Name = "IMH_Unit" };

			IO_Control = new IO_ControlWrapper(client){ Name = "IO_Control" };

			MotionControl = new MotionControlWrapper(client){ Name = "MotionControl" };

			OMH_Unit = new OMH_UnitWrapper(client){ Name = "OMH_Unit" };

			TwinCAT_SystemInfoVarList = new TwinCAT_SystemInfoVarListWrapper(client){ Name = "TwinCAT_SystemInfoVarList" };

			this.SetParent();
		}

		public void Initialize()
		{
		    this.SetInit();
		}

		public Global_VariablesWrapper Global_Variables { get; init; }

		public Global_VersionWrapper Global_Version { get; init; }

		public GVL_Alarm_ErrorWrapper GVL_Alarm_Error { get; init; }

		public GVL_IO_IndexWrapper GVL_IO_Index { get; init; }

		public GVL_MotionWrapper GVL_Motion { get; init; }

		public GVL_PC_Input_PLCWrapper GVL_PC_Input_PLC { get; init; }

		public GVL_PLC_Output_PCWrapper GVL_PLC_Output_PC { get; init; }

		public GVL_Recipe_BoolWrapper GVL_Recipe_Bool { get; init; }

		public GVL_Recipe_TransferMaterialWrapper GVL_Recipe_TransferMaterial { get; init; }

		public GVL_Recipe_TransferSettingWrapper GVL_Recipe_TransferSetting { get; init; }

		public GVL_Recipe_WafferMaterialWrapper GVL_Recipe_WafferMaterial { get; init; }

		public GVL_Sensor_UsedWrapper GVL_Sensor_Used { get; init; }

		public GVL_SetupWrapper GVL_Setup { get; init; }

		public GVL_UnitWrapper GVL_Unit { get; init; }

		public IMH_UnitWrapper IMH_Unit { get; init; }

		public IO_ControlWrapper IO_Control { get; init; }

		public MotionControlWrapper MotionControl { get; init; }

		public OMH_UnitWrapper OMH_Unit { get; init; }

		public TwinCAT_SystemInfoVarListWrapper TwinCAT_SystemInfoVarList { get; init; }

		internal override void Init()
		{
		}

		private CircleManager circleManager = new CircleManager();
		
		public void AddToNotifyCircle(IBaseData node)
		{
		    circleManager.AddCircleCallback(node);
		}
		
		public void AddToNotifyCircles(IEnumerable<IBaseData> nodes)
		{
		    circleManager.AddCircleCallbacks(nodes);
		}
		
		public void StartCircle()
		{
			circleManager.StartCircle();
		}
		
		public void StopCircle()
		{
			circleManager.StopCircle();
		}
		
		public void SetInterval(int interval)
		{
			circleManager.ReadCircleSleepTime = interval;
			circleManager.ReadSleepTime = interval;
		}

		public override void CheckAndNotify(int timeout = -1, CancellationToken token = default)
		{
		    foreach (var child in Children)
		    {
		        child?.CheckAndNotify(timeout, token);
		    }
		}

		public override IEnumerable<IBaseData> Children
		{
			get
			{
				yield return Global_Variables;
				yield return Global_Version;
				yield return GVL_Alarm_Error;
				yield return GVL_IO_Index;
				yield return GVL_Motion;
				yield return GVL_PC_Input_PLC;
				yield return GVL_PLC_Output_PC;
				yield return GVL_Recipe_Bool;
				yield return GVL_Recipe_TransferMaterial;
				yield return GVL_Recipe_TransferSetting;
				yield return GVL_Recipe_WafferMaterial;
				yield return GVL_Sensor_Used;
				yield return GVL_Setup;
				yield return GVL_Unit;
				yield return IMH_Unit;
				yield return IO_Control;
				yield return MotionControl;
				yield return OMH_Unit;
				yield return TwinCAT_SystemInfoVarList;
			}
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Global_Variables):
					return Global_Variables;
				case nameof(Global_Version):
					return Global_Version;
				case nameof(GVL_Alarm_Error):
					return GVL_Alarm_Error;
				case nameof(GVL_IO_Index):
					return GVL_IO_Index;
				case nameof(GVL_Motion):
					return GVL_Motion;
				case nameof(GVL_PC_Input_PLC):
					return GVL_PC_Input_PLC;
				case nameof(GVL_PLC_Output_PC):
					return GVL_PLC_Output_PC;
				case nameof(GVL_Recipe_Bool):
					return GVL_Recipe_Bool;
				case nameof(GVL_Recipe_TransferMaterial):
					return GVL_Recipe_TransferMaterial;
				case nameof(GVL_Recipe_TransferSetting):
					return GVL_Recipe_TransferSetting;
				case nameof(GVL_Recipe_WafferMaterial):
					return GVL_Recipe_WafferMaterial;
				case nameof(GVL_Sensor_Used):
					return GVL_Sensor_Used;
				case nameof(GVL_Setup):
					return GVL_Setup;
				case nameof(GVL_Unit):
					return GVL_Unit;
				case nameof(IMH_Unit):
					return IMH_Unit;
				case nameof(IO_Control):
					return IO_Control;
				case nameof(MotionControl):
					return MotionControl;
				case nameof(OMH_Unit):
					return OMH_Unit;
				case nameof(TwinCAT_SystemInfoVarList):
					return TwinCAT_SystemInfoVarList;
			}
			throw new KeyNotFoundException(name);
		}
		public void Connect(string ip, int port)
		{
		    client.Connect(ip, port);
		}
		
		public bool TryConnect(string ip, int port)
		{
		    try
		    {
		        Connect(ip, port);
		        return true;
		    }
		    catch (Exception ex)
		    {
		        return false;
		    }
		}
		
		public void Disconnect()
		{
		    client.Disconnect();
		}
		
		public bool TryDisconnect()
		{
		    try
		    {
		        Disconnect();
		        return true;
		    }
		    catch (Exception ex)
		    {
		        return false;
		    }
		}
		
		private AdsClient client;
		
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
		        client.Dispose();
		        // TODO: 将大型字段设置为 null
		        disposedValue = true;
		    }
		}
		
		// TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器
		~Demo001()
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

