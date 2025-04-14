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
	/// Name from PLC:GVL_PLC_Output_PC
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_PLC_Output_PCWrapper
	{

		/// <summary>
		/// Name from PLC:G_Out_bIMH_Home_Done
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003576)
		/// Size: 1
		public IBaseData<bool> G_Out_bIMH_Home_Done { get; }
		internal bool ref_G_Out_bIMH_Home_Done = new bool();

		/// <summary>
		/// Name from PLC:G_Out_bOMH_Home_Done
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003577)
		/// Size: 1
		public IBaseData<bool> G_Out_bOMH_Home_Done { get; }
		internal bool ref_G_Out_bOMH_Home_Done = new bool();

		/// <summary>
		/// Name from PLC:G_Out_bFSU_Home_Done
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003578)
		/// Size: 1
		public IBaseData<bool> G_Out_bFSU_Home_Done { get; }
		internal bool ref_G_Out_bFSU_Home_Done = new bool();

		/// <summary>
		/// Name from PLC:G_OUT_Barcode_Start_Request
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003579)
		/// Size: 1
		public IBaseData<bool> G_OUT_Barcode_Start_Request { get; }
		internal bool ref_G_OUT_Barcode_Start_Request = new bool();

		/// <summary>
		/// Name from PLC:G_OUT_CleanVision_Request
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003580)
		/// Size: 1
		public IBaseData<bool> G_OUT_CleanVision_Request { get; }
		internal bool ref_G_OUT_CleanVision_Request = new bool();

		/// <summary>
		/// Name from PLC:G_OUT_TransBonding_Suceess
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003581)
		/// Size: 1
		public IBaseData<bool> G_OUT_TransBonding_Suceess { get; }
		internal bool ref_G_OUT_TransBonding_Suceess = new bool();

		/// <summary>
		/// Name from PLC:G_OUT_TransBonding_Fail
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003582)
		/// Size: 1
		public IBaseData<bool> G_OUT_TransBonding_Fail { get; }
		internal bool ref_G_OUT_TransBonding_Fail = new bool();

		/// <summary>
		/// Name from PLC:G_OUT_Bonding_Vision_Request
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003583)
		/// Size: 1
		public IBaseData<bool> G_OUT_Bonding_Vision_Request { get; }
		internal bool ref_G_OUT_Bonding_Vision_Request = new bool();

		/// <summary>
		/// Name from PLC:G_OUT_Substrate_InCleanPos
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003584)
		/// Size: 1
		public IBaseData<bool> G_OUT_Substrate_InCleanPos { get; }
		internal bool ref_G_OUT_Substrate_InCleanPos = new bool();

		/// <summary>
		/// Name from PLC:G_OUT_Preform_Inspection_Start
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003585)
		/// Size: 1
		public IBaseData<bool> G_OUT_Preform_Inspection_Start { get; }
		internal bool ref_G_OUT_Preform_Inspection_Start = new bool();

		/// <summary>
		/// Name from PLC:G_Out_CDA_Inspect_Result
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2003586)
		/// Size: 2
		public IBaseData<short> G_Out_CDA_Inspect_Result { get; }
		internal short ref_G_Out_CDA_Inspect_Result = new short();

		/// <summary>
		/// Name from PLC:G_Out_Bonding_Ready
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003588)
		/// Size: 1
		public IBaseData<bool> G_Out_Bonding_Ready { get; }
		internal bool ref_G_Out_Bonding_Ready = new bool();

		/// <summary>
		/// Name from PLC:G_OUT_WLU_Wafer_Ready
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003589)
		/// Size: 1
		public IBaseData<bool> G_OUT_WLU_Wafer_Ready { get; }
		internal bool ref_G_OUT_WLU_Wafer_Ready = new bool();

		/// <summary>
		/// Name from PLC:G_Out_bWLU_Home_Done
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003590)
		/// Size: 1
		public IBaseData<bool> G_Out_bWLU_Home_Done { get; }
		internal bool ref_G_Out_bWLU_Home_Done = new bool();

		/// <summary>
		/// Name from PLC:G_Out_bJOG_HighSpeed_Move
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003591)
		/// Size: 1
		public IBaseData<bool> G_Out_bJOG_HighSpeed_Move { get; }
		internal bool ref_G_Out_bJOG_HighSpeed_Move = new bool();

		/// <summary>
		/// Name from PLC:G_Out_bJOG_LowSpeed_Move
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003592)
		/// Size: 1
		public IBaseData<bool> G_Out_bJOG_LowSpeed_Move { get; }
		internal bool ref_G_Out_bJOG_LowSpeed_Move = new bool();

		/// <summary>
		/// Name from PLC:G_Out_Cursor_Speed
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2003594)
		/// Size: 2
		public IBaseData<short> G_Out_Cursor_Speed { get; }
		internal short ref_G_Out_Cursor_Speed = new short();

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
