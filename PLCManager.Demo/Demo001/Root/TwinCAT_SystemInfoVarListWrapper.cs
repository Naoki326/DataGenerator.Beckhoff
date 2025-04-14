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
	/// Name from PLC:TwinCAT_SystemInfoVarList
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class TwinCAT_SystemInfoVarListWrapper
	{

		/// <summary>
		/// Name from PLC:_AppInfo
		/// TypeName from PLC: PLC.PlcAppSystemInfo
		/// (IndexGroup, IndexOffset): (16448,2005752)
		/// Size: 256
		public PLC_PlcAppSystemInfoWrapper _AppInfo { get; }
		internal PLC_PlcAppSystemInfo ref__AppInfo = new PLC_PlcAppSystemInfo();

		/// <summary>
		/// Name from PLC:_TaskInfo
		/// TypeName from PLC: ARRAY [1..1] OF PLC.PlcTaskSystemInfo
		/// (IndexGroup, IndexOffset): (16448,2006008)
		/// Size: 128
		public IStructArray<PLC_PlcTaskSystemInfo1, PLC_PlcTaskSystemInfoWrapper, PLC_PlcTaskSystemInfo> _TaskInfo { get; }
		internal PLC_PlcTaskSystemInfo1 ref__TaskInfo = new PLC_PlcTaskSystemInfo1();

		/// <summary>
		/// Name from PLC:_TaskPouOid_PlcTask
		/// TypeName from PLC: OTCID
		/// (IndexGroup, IndexOffset): (16448,2006136)
		/// Size: 4
		public IBaseData<uint> _TaskPouOid_PlcTask { get; }
		internal uint ref__TaskPouOid_PlcTask = new uint();

		/// <summary>
		/// Name from PLC:_TaskOid_PlcTask
		/// TypeName from PLC: OTCID
		/// (IndexGroup, IndexOffset): (16448,2006140)
		/// Size: 4
		public IBaseData<uint> _TaskOid_PlcTask { get; }
		internal uint ref__TaskOid_PlcTask = new uint();

		/// <summary>
		/// Name from PLC:__PlcTask
		/// TypeName from PLC: _Implicit_Task_Info
		/// (IndexGroup, IndexOffset): (16448,2006144)
		/// Size: 112
		public _Implicit_Task_InfoWrapper __PlcTask { get; }
		internal _Implicit_Task_Info ref___PlcTask = new _Implicit_Task_Info();

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
