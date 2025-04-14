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
	/// Name from PLC:GVL_Motion
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class GVL_MotionWrapper
	{

		/// <summary>
		/// Name from PLC:G_ManualHome_Start
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,1177835)
		/// Size: 1
		public IBaseData<bool> G_ManualHome_Start { get; }
		internal bool ref_G_ManualHome_Start = new bool();

		/// <summary>
		/// Name from PLC:MaxAxisNum
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225162)
		/// Size: 2
		public IBaseData<short> MaxAxisNum { get; }
		internal short ref_MaxAxisNum = new short();

		/// <summary>
		/// Name from PLC:AxisIndex
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225164)
		/// Size: 2
		public IBaseData<short> AxisIndex { get; }
		internal short ref_AxisIndex = new short();

		/// <summary>
		/// Name from PLC:IMH_Axis_Num
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225166)
		/// Size: 2
		public IBaseData<short> IMH_Axis_Num { get; }
		internal short ref_IMH_Axis_Num = new short();

		/// <summary>
		/// Name from PLC:PAI
		/// TypeName from PLC: LREAL
		/// (IndexGroup, IndexOffset): (16448,1225168)
		/// Size: 8
		public IBaseData<double> PAI { get; }
		internal double ref_PAI = new double();

		/// <summary>
		/// Name from PLC:OMH_Axis_Num
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225176)
		/// Size: 2
		public IBaseData<short> OMH_Axis_Num { get; }
		internal short ref_OMH_Axis_Num = new short();

		/// <summary>
		/// Name from PLC:FSU_Axis_Num
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225178)
		/// Size: 2
		public IBaseData<short> FSU_Axis_Num { get; }
		internal short ref_FSU_Axis_Num = new short();

		/// <summary>
		/// Name from PLC:WLU_Axis_Num
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225180)
		/// Size: 2
		public IBaseData<short> WLU_Axis_Num { get; }
		internal short ref_WLU_Axis_Num = new short();

		/// <summary>
		/// Name from PLC:IMH_YM_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225182)
		/// Size: 2
		public IBaseData<short> IMH_YM_StepMotor_Index { get; }
		internal short ref_IMH_YM_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:IMH_ZM_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225184)
		/// Size: 2
		public IBaseData<short> IMH_ZM_StepMotor_Index { get; }
		internal short ref_IMH_ZM_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:OMH_YM_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225186)
		/// Size: 2
		public IBaseData<short> OMH_YM_StepMotor_Index { get; }
		internal short ref_OMH_YM_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:OMH_ZM_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225188)
		/// Size: 2
		public IBaseData<short> OMH_ZM_StepMotor_Index { get; }
		internal short ref_OMH_ZM_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FIG_XM_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225190)
		/// Size: 2
		public IBaseData<short> FIG_XM_StepMotor_Index { get; }
		internal short ref_FIG_XM_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FIG_CM_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225192)
		/// Size: 2
		public IBaseData<short> FIG_CM_StepMotor_Index { get; }
		internal short ref_FIG_CM_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FCU_LXM_ServoMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225194)
		/// Size: 2
		public IBaseData<short> FCU_LXM_ServoMotor_Index { get; }
		internal short ref_FCU_LXM_ServoMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FCU_CM_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225196)
		/// Size: 2
		public IBaseData<short> FCU_CM_StepMotor_Index { get; }
		internal short ref_FCU_CM_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FCU_CDA_YM_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225198)
		/// Size: 2
		public IBaseData<short> FCU_CDA_YM_StepMotor_Index { get; }
		internal short ref_FCU_CDA_YM_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FCU_CDA_ZM_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225200)
		/// Size: 2
		public IBaseData<short> FCU_CDA_ZM_StepMotor_Index { get; }
		internal short ref_FCU_CDA_ZM_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FCU_PCM_ServoMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225202)
		/// Size: 2
		public IBaseData<short> FCU_PCM_ServoMotor_Index { get; }
		internal short ref_FCU_PCM_ServoMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FCU_SZM_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225204)
		/// Size: 2
		public IBaseData<short> FCU_SZM_StepMotor_Index { get; }
		internal short ref_FCU_SZM_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FBU_BCM_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225206)
		/// Size: 2
		public IBaseData<short> FBU_BCM_StepMotor_Index { get; }
		internal short ref_FBU_BCM_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FBU_BZ1M_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225208)
		/// Size: 2
		public IBaseData<short> FBU_BZ1M_StepMotor_Index { get; }
		internal short ref_FBU_BZ1M_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FBU_BZ2M_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225210)
		/// Size: 2
		public IBaseData<short> FBU_BZ2M_StepMotor_Index { get; }
		internal short ref_FBU_BZ2M_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FBU_LXM_ServoMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225212)
		/// Size: 2
		public IBaseData<short> FBU_LXM_ServoMotor_Index { get; }
		internal short ref_FBU_LXM_ServoMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FBU_CM_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225214)
		/// Size: 2
		public IBaseData<short> FBU_CM_StepMotor_Index { get; }
		internal short ref_FBU_CM_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FBU_CDA_XM_ServoMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225216)
		/// Size: 2
		public IBaseData<short> FBU_CDA_XM_ServoMotor_Index { get; }
		internal short ref_FBU_CDA_XM_ServoMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FBU_CDA_YM_ServoMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225218)
		/// Size: 2
		public IBaseData<short> FBU_CDA_YM_ServoMotor_Index { get; }
		internal short ref_FBU_CDA_YM_ServoMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FBU_AZM_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225220)
		/// Size: 2
		public IBaseData<short> FBU_AZM_StepMotor_Index { get; }
		internal short ref_FBU_AZM_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FBU_TWM_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225222)
		/// Size: 2
		public IBaseData<short> FBU_TWM_StepMotor_Index { get; }
		internal short ref_FBU_TWM_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FOG_LXM_ServoMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225224)
		/// Size: 2
		public IBaseData<short> FOG_LXM_ServoMotor_Index { get; }
		internal short ref_FOG_LXM_ServoMotor_Index = new short();

		/// <summary>
		/// Name from PLC:FOG_CM_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225226)
		/// Size: 2
		public IBaseData<short> FOG_CM_StepMotor_Index { get; }
		internal short ref_FOG_CM_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:WLU_ZM_ServoMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225228)
		/// Size: 2
		public IBaseData<short> WLU_ZM_ServoMotor_Index { get; }
		internal short ref_WLU_ZM_ServoMotor_Index = new short();

		/// <summary>
		/// Name from PLC:WLU_XM_StepMotor_Index
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1225230)
		/// Size: 2
		public IBaseData<short> WLU_XM_StepMotor_Index { get; }
		internal short ref_WLU_XM_StepMotor_Index = new short();

		/// <summary>
		/// Name from PLC:Motion
		/// TypeName from PLC: ARRAY [1..50] OF ST_Motion
		/// (IndexGroup, IndexOffset): (16448,1225232)
		/// Size: 778000
		public IStructArray<ST_Motion50, ST_MotionWrapper, ST_Motion> Motion { get; }
		internal ST_Motion50 ref_Motion = new ST_Motion50();

		/// <summary>
		/// Name from PLC:G_ManualHome_Step
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2003232)
		/// Size: 2
		public IBaseData<short> G_ManualHome_Step { get; }
		internal short ref_G_ManualHome_Step = new short();

		/// <summary>
		/// Name from PLC:G_AutoHome_Step
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,2003234)
		/// Size: 2
		public IBaseData<short> G_AutoHome_Step { get; }
		internal short ref_G_AutoHome_Step = new short();

		/// <summary>
		/// Name from PLC:G_AutoHome_Start
		/// TypeName from PLC: BOOL
		/// (IndexGroup, IndexOffset): (16448,2003236)
		/// Size: 1
		public IBaseData<bool> G_AutoHome_Start { get; }
		internal bool ref_G_AutoHome_Start = new bool();

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
