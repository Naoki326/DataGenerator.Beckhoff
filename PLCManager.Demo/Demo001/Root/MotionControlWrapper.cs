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
	/// Name from PLC:MotionControl
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class MotionControlWrapper
	{

		/// <summary>
		/// Name from PLC:i
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,384684)
		/// Size: 2
		public IBaseData<short> i { get; }
		internal short ref_i = new short();

		/// <summary>
		/// Name from PLC:AxisStartNum
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,384686)
		/// Size: 2
		public IBaseData<short> AxisStartNum { get; }
		internal short ref_AxisStartNum = new short();

		/// <summary>
		/// Name from PLC:AxisEndNum
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,384732)
		/// Size: 2
		public IBaseData<short> AxisEndNum { get; }
		internal short ref_AxisEndNum = new short();

		/// <summary>
		/// Name from PLC:OMH_YM_bHome
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,384734)
		/// Size: 1
		public IBaseData<bool> OMH_YM_bHome { get; }
		internal bool ref_OMH_YM_bHome = new bool();

		/// <summary>
		/// Name from PLC:OMH_ZM_bHome
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,384735)
		/// Size: 1
		public IBaseData<bool> OMH_ZM_bHome { get; }
		internal bool ref_OMH_ZM_bHome = new bool();

		/// <summary>
		/// Name from PLC:MotionControl
		/// TypeName from PLC: ARRAY [1..50] OF FB_MotionControl
		/// (IndexGroup, IndexOffset): (16448,387976)
		/// Size: 707600
		public IStructArray<FB_MotionControl50, FB_MotionControlWrapper, FB_MotionControl> MotionControl { get; }
		internal FB_MotionControl50 ref_MotionControl = new FB_MotionControl50();

		/// <summary>
		/// Name from PLC:Delay
		/// TypeName from PLC: ARRAY [1..10] OF Tc2_Standard.TON
		/// (IndexGroup, IndexOffset): (16448,1095576)
		/// Size: 320
		public IStructArray<Tc2_Standard_TON10, Tc2_Standard_TONWrapper, Tc2_Standard_TON> Delay { get; }
		internal Tc2_Standard_TON10 ref_Delay = new Tc2_Standard_TON10();

		/// <summary>
		/// Name from PLC:H_TrigOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.R_TRIG
		/// (IndexGroup, IndexOffset): (16448,1095896)
		/// Size: 320
		public IStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG> H_TrigOn { get; }
		internal Tc2_Standard_R_TRIG20 ref_H_TrigOn = new Tc2_Standard_R_TRIG20();

		/// <summary>
		/// Name from PLC:M_TrigOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.R_TRIG
		/// (IndexGroup, IndexOffset): (16448,1096216)
		/// Size: 320
		public IStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG> M_TrigOn { get; }
		internal Tc2_Standard_R_TRIG20 ref_M_TrigOn = new Tc2_Standard_R_TRIG20();

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
