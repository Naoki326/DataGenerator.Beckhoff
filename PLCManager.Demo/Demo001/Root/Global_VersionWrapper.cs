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
	/// Name from PLC:Global_Version
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class Global_VersionWrapper
	{

		/// <summary>
		/// Name from PLC:stLibVersion_Tc2_Standard
		/// TypeName from PLC: ST_LibVersion
		/// (IndexGroup, IndexOffset): (16448,384000)
		/// Size: 36
		public ST_LibVersionWrapper stLibVersion_Tc2_Standard { get; }
		internal ST_LibVersion ref_stLibVersion_Tc2_Standard = new ST_LibVersion();

		/// <summary>
		/// Name from PLC:stLibVersion_Tc2_Utilities
		/// TypeName from PLC: ST_LibVersion
		/// (IndexGroup, IndexOffset): (16448,384036)
		/// Size: 36
		public ST_LibVersionWrapper stLibVersion_Tc2_Utilities { get; }
		internal ST_LibVersion ref_stLibVersion_Tc2_Utilities = new ST_LibVersion();

		/// <summary>
		/// Name from PLC:stLibVersion_Tc2_System
		/// TypeName from PLC: ST_LibVersion
		/// (IndexGroup, IndexOffset): (16448,384072)
		/// Size: 36
		public ST_LibVersionWrapper stLibVersion_Tc2_System { get; }
		internal ST_LibVersion ref_stLibVersion_Tc2_System = new ST_LibVersion();

		/// <summary>
		/// Name from PLC:stLibVersion_Tc3_Module
		/// TypeName from PLC: ST_LibVersion
		/// (IndexGroup, IndexOffset): (16448,384612)
		/// Size: 36
		public ST_LibVersionWrapper stLibVersion_Tc3_Module { get; }
		internal ST_LibVersion ref_stLibVersion_Tc3_Module = new ST_LibVersion();

		/// <summary>
		/// Name from PLC:stLibVersion_Tc2_MC2
		/// TypeName from PLC: ST_LibVersion
		/// (IndexGroup, IndexOffset): (16448,384696)
		/// Size: 36
		public ST_LibVersionWrapper stLibVersion_Tc2_MC2 { get; }
		internal ST_LibVersion ref_stLibVersion_Tc2_MC2 = new ST_LibVersion();

		/// <summary>
		/// Name from PLC:stLibVersion_Tc2_Math
		/// TypeName from PLC: ST_LibVersion
		/// (IndexGroup, IndexOffset): (16448,385648)
		/// Size: 36
		public ST_LibVersionWrapper stLibVersion_Tc2_Math { get; }
		internal ST_LibVersion ref_stLibVersion_Tc2_Math = new ST_LibVersion();

		/// <summary>
		/// Name from PLC:stLibVersion_Tc2_NC
		/// TypeName from PLC: ST_LibVersion
		/// (IndexGroup, IndexOffset): (16448,385684)
		/// Size: 36
		public ST_LibVersionWrapper stLibVersion_Tc2_NC { get; }
		internal ST_LibVersion ref_stLibVersion_Tc2_NC = new ST_LibVersion();

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
