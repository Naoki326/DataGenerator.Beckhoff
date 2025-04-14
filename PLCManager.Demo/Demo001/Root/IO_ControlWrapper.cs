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
	/// Name from PLC:IO_Control
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class IO_ControlWrapper
	{

		/// <summary>
		/// Name from PLC:CY_Control
		/// TypeName from PLC: ARRAY [1..100] OF FB_IO_Cylinder
		/// (IndexGroup, IndexOffset): (16448,1096632)
		/// Size: 52000
		public IStructArray<FB_IO_Cylinder100, FB_IO_CylinderWrapper, FB_IO_Cylinder> CY_Control { get; }
		internal FB_IO_Cylinder100 ref_CY_Control = new FB_IO_Cylinder100();

		/// <summary>
		/// Name from PLC:SR_Control
		/// TypeName from PLC: ARRAY [1..100] OF FB_IO_Sensor
		/// (IndexGroup, IndexOffset): (16448,1148632)
		/// Size: 19200
		public IStructArray<FB_IO_Sensor100, FB_IO_SensorWrapper, FB_IO_Sensor> SR_Control { get; }
		internal FB_IO_Sensor100 ref_SR_Control = new FB_IO_Sensor100();

		/// <summary>
		/// Name from PLC:I
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1167832)
		/// Size: 2
		public IBaseData<short> I { get; }
		internal short ref_I = new short();

		/// <summary>
		/// Name from PLC:k
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1167834)
		/// Size: 2
		public IBaseData<short> k { get; }
		internal short ref_k = new short();

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
