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
	/// Name from PLC:Global_Version
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class Global_VersionWrapper : BaseData, IBaseData
	{
		public override IEnumerable<IBaseData> Children
		{
			get
			{
				yield return stLibVersion_Tc2_Standard;
				yield return stLibVersion_Tc2_System;
				yield return stLibVersion_Tc3_Module;
			}
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(stLibVersion_Tc2_Standard):
					return stLibVersion_Tc2_Standard;
				case nameof(stLibVersion_Tc2_System):
					return stLibVersion_Tc2_System;
				case nameof(stLibVersion_Tc3_Module):
					return stLibVersion_Tc3_Module;
			}
			throw new KeyNotFoundException(name);
		}

		private readonly AdsClient client;

		public Global_VersionWrapper(AdsClient client)
		{
			this.client = client;

			stLibVersion_Tc2_Standard = new ST_LibVersionWrapper(this.GetstLibVersion_Tc2_Standard, client, 16448, 384000)
			{
				Name = "stLibVersion_Tc2_Standard",
				iMajor = new BeckhoffUShort(this.GetstLibVersion_Tc2_Standard_Dot_iMajor, client, 16448, 384000){ Name = "iMajor" },
				iMinor = new BeckhoffUShort(this.GetstLibVersion_Tc2_Standard_Dot_iMinor, client, 16448, 384002){ Name = "iMinor" },
				iBuild = new BeckhoffUShort(this.GetstLibVersion_Tc2_Standard_Dot_iBuild, client, 16448, 384004){ Name = "iBuild" },
				iRevision = new BeckhoffUShort(this.GetstLibVersion_Tc2_Standard_Dot_iRevision, client, 16448, 384006){ Name = "iRevision" },
				nFlags = new BeckhoffInt(this.GetstLibVersion_Tc2_Standard_Dot_nFlags, client, 16448, 384008){ Name = "nFlags" },
				sVersion = new BeckhoffString<String24>(this.GetstLibVersion_Tc2_Standard_Dot_sVersion, client, 16448, 384012){ Name = "sVersion" },
			};
			stLibVersion_Tc2_System = new ST_LibVersionWrapper(this.GetstLibVersion_Tc2_System, client, 16448, 384036)
			{
				Name = "stLibVersion_Tc2_System",
				iMajor = new BeckhoffUShort(this.GetstLibVersion_Tc2_System_Dot_iMajor, client, 16448, 384036){ Name = "iMajor" },
				iMinor = new BeckhoffUShort(this.GetstLibVersion_Tc2_System_Dot_iMinor, client, 16448, 384038){ Name = "iMinor" },
				iBuild = new BeckhoffUShort(this.GetstLibVersion_Tc2_System_Dot_iBuild, client, 16448, 384040){ Name = "iBuild" },
				iRevision = new BeckhoffUShort(this.GetstLibVersion_Tc2_System_Dot_iRevision, client, 16448, 384042){ Name = "iRevision" },
				nFlags = new BeckhoffInt(this.GetstLibVersion_Tc2_System_Dot_nFlags, client, 16448, 384044){ Name = "nFlags" },
				sVersion = new BeckhoffString<String24>(this.GetstLibVersion_Tc2_System_Dot_sVersion, client, 16448, 384048){ Name = "sVersion" },
			};
			stLibVersion_Tc3_Module = new ST_LibVersionWrapper(this.GetstLibVersion_Tc3_Module, client, 16448, 384072)
			{
				Name = "stLibVersion_Tc3_Module",
				iMajor = new BeckhoffUShort(this.GetstLibVersion_Tc3_Module_Dot_iMajor, client, 16448, 384072){ Name = "iMajor" },
				iMinor = new BeckhoffUShort(this.GetstLibVersion_Tc3_Module_Dot_iMinor, client, 16448, 384074){ Name = "iMinor" },
				iBuild = new BeckhoffUShort(this.GetstLibVersion_Tc3_Module_Dot_iBuild, client, 16448, 384076){ Name = "iBuild" },
				iRevision = new BeckhoffUShort(this.GetstLibVersion_Tc3_Module_Dot_iRevision, client, 16448, 384078){ Name = "iRevision" },
				nFlags = new BeckhoffInt(this.GetstLibVersion_Tc3_Module_Dot_nFlags, client, 16448, 384080){ Name = "nFlags" },
				sVersion = new BeckhoffString<String24>(this.GetstLibVersion_Tc3_Module_Dot_sVersion, client, 16448, 384084){ Name = "sVersion" },
			};
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
		~Global_VersionWrapper()
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
