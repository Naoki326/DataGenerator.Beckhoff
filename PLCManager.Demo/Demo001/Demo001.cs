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
			
			Global_Version = new Global_VersionWrapper(client){ Name = "Global_Version" };

			TwinCAT_SystemInfoVarList = new TwinCAT_SystemInfoVarListWrapper(client){ Name = "TwinCAT_SystemInfoVarList" };

			this.SetParent();
		}

		public void Initialize()
		{
		    this.SetInit();
		}

		public Global_VersionWrapper Global_Version { get; init; }

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
				yield return Global_Version;
				yield return TwinCAT_SystemInfoVarList;
			}
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Global_Version):
					return Global_Version;
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

