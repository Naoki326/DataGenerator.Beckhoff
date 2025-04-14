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
	/// Name from PLC:OMH_Unit
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class OMH_UnitWrapper
	{

		/// <summary>
		/// Name from PLC:i
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1167918)
		/// Size: 2
		public IBaseData<short> i { get; }
		internal short ref_i = new short();

		/// <summary>
		/// Name from PLC:car
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1172732)
		/// Size: 2
		public IBaseData<short> car { get; }
		internal short ref_car = new short();

		/// <summary>
		/// Name from PLC:logon
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1172734)
		/// Size: 2
		public IBaseData<short> logon { get; }
		internal short ref_logon = new short();

		/// <summary>
		/// Name from PLC:LCase_Move
		/// TypeName from PLC: ARRAY [1..20] OF BOOL
		/// (IndexGroup, IndexOffset): (16448,1172744)
		/// Size: 20
		public IBaseArray<Bool20, bool> LCase_Move { get; }
		internal Bool20 ref_LCase_Move = new Bool20();

		/// <summary>
		/// Name from PLC:ULCase_Move
		/// TypeName from PLC: ARRAY [1..20] OF BOOL
		/// (IndexGroup, IndexOffset): (16448,1172764)
		/// Size: 20
		public IBaseArray<Bool20, bool> ULCase_Move { get; }
		internal Bool20 ref_ULCase_Move = new Bool20();

		/// <summary>
		/// Name from PLC:Auto_Move
		/// TypeName from PLC: ARRAY [1..20] OF BOOL
		/// (IndexGroup, IndexOffset): (16448,1172784)
		/// Size: 20
		public IBaseArray<Bool20, bool> Auto_Move { get; }
		internal Bool20 ref_Auto_Move = new Bool20();

		/// <summary>
		/// Name from PLC:Pos_YM_Loading_Case_Buffer
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,1172804)
		/// Size: 4
		public IBaseData<float> Pos_YM_Loading_Case_Buffer { get; }
		internal float ref_Pos_YM_Loading_Case_Buffer = new float();

		/// <summary>
		/// Name from PLC:Initial_DelayOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.TON
		/// (IndexGroup, IndexOffset): (16448,1172808)
		/// Size: 640
		public IStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON> Initial_DelayOn { get; }
		internal Tc2_Standard_TON20 ref_Initial_DelayOn = new Tc2_Standard_TON20();

		/// <summary>
		/// Name from PLC:Initial_TrigOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.R_TRIG
		/// (IndexGroup, IndexOffset): (16448,1173448)
		/// Size: 320
		public IStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG> Initial_TrigOn { get; }
		internal Tc2_Standard_R_TRIG20 ref_Initial_TrigOn = new Tc2_Standard_R_TRIG20();

		/// <summary>
		/// Name from PLC:H_DelayOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.TON
		/// (IndexGroup, IndexOffset): (16448,1173768)
		/// Size: 640
		public IStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON> H_DelayOn { get; }
		internal Tc2_Standard_TON20 ref_H_DelayOn = new Tc2_Standard_TON20();

		/// <summary>
		/// Name from PLC:H_TrigOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.R_TRIG
		/// (IndexGroup, IndexOffset): (16448,1174408)
		/// Size: 320
		public IStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG> H_TrigOn { get; }
		internal Tc2_Standard_R_TRIG20 ref_H_TrigOn = new Tc2_Standard_R_TRIG20();

		/// <summary>
		/// Name from PLC:L_DelayOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.TON
		/// (IndexGroup, IndexOffset): (16448,1174728)
		/// Size: 640
		public IStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON> L_DelayOn { get; }
		internal Tc2_Standard_TON20 ref_L_DelayOn = new Tc2_Standard_TON20();

		/// <summary>
		/// Name from PLC:L_TrigOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.R_TRIG
		/// (IndexGroup, IndexOffset): (16448,1175368)
		/// Size: 320
		public IStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG> L_TrigOn { get; }
		internal Tc2_Standard_R_TRIG20 ref_L_TrigOn = new Tc2_Standard_R_TRIG20();

		/// <summary>
		/// Name from PLC:UL_DelayOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.TON
		/// (IndexGroup, IndexOffset): (16448,1175688)
		/// Size: 640
		public IStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON> UL_DelayOn { get; }
		internal Tc2_Standard_TON20 ref_UL_DelayOn = new Tc2_Standard_TON20();

		/// <summary>
		/// Name from PLC:UL_TrigOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.R_TRIG
		/// (IndexGroup, IndexOffset): (16448,1176328)
		/// Size: 320
		public IStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG> UL_TrigOn { get; }
		internal Tc2_Standard_R_TRIG20 ref_UL_TrigOn = new Tc2_Standard_R_TRIG20();

		/// <summary>
		/// Name from PLC:DelayOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.TON
		/// (IndexGroup, IndexOffset): (16448,1176648)
		/// Size: 640
		public IStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON> DelayOn { get; }
		internal Tc2_Standard_TON20 ref_DelayOn = new Tc2_Standard_TON20();

		/// <summary>
		/// Name from PLC:TrigOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.R_TRIG
		/// (IndexGroup, IndexOffset): (16448,1177288)
		/// Size: 320
		public IStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG> TrigOn { get; }
		internal Tc2_Standard_R_TRIG20 ref_TrigOn = new Tc2_Standard_R_TRIG20();

		/// <summary>
		/// Name from PLC:Pos_YM_Receive_Base_Buffer
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,1177608)
		/// Size: 4
		public IBaseData<float> Pos_YM_Receive_Base_Buffer { get; }
		internal float ref_Pos_YM_Receive_Base_Buffer = new float();

		/// <summary>
		/// Name from PLC:Pos_YM_UnLoading_Case_Buffer
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,1177612)
		/// Size: 4
		public IBaseData<float> Pos_YM_UnLoading_Case_Buffer { get; }
		internal float ref_Pos_YM_UnLoading_Case_Buffer = new float();

		/// <summary>
		/// Name from PLC:Pos_ZM_Receive_Buffer
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,1177616)
		/// Size: 4
		public IBaseData<float> Pos_ZM_Receive_Buffer { get; }
		internal float ref_Pos_ZM_Receive_Buffer = new float();

		/// <summary>
		/// Name from PLC:Pos_ZM_Top_TO_Bottom
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,1177620)
		/// Size: 4
		public IBaseData<float> Pos_ZM_Top_TO_Bottom { get; }
		internal float ref_Pos_ZM_Top_TO_Bottom = new float();

		/// <summary>
		/// Name from PLC:Pos_ZM_Bottom_TO_Top
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,1177624)
		/// Size: 4
		public IBaseData<float> Pos_ZM_Bottom_TO_Top { get; }
		internal float ref_Pos_ZM_Bottom_TO_Top = new float();

		/// <summary>
		/// Name from PLC:AlarmCode
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,1177628)
		/// Size: 4
		public IBaseData<uint> AlarmCode { get; }
		internal uint ref_AlarmCode = new uint();

		/// <summary>
		/// Name from PLC:Pos_YM_Loading_Case
		/// TypeName from PLC: LREAL
		/// (IndexGroup, IndexOffset): (16448,1177632)
		/// Size: 8
		public IBaseData<double> Pos_YM_Loading_Case { get; }
		internal double ref_Pos_YM_Loading_Case = new double();

		/// <summary>
		/// Name from PLC:Pos_YM_Receive_Base
		/// TypeName from PLC: LREAL
		/// (IndexGroup, IndexOffset): (16448,1177640)
		/// Size: 8
		public IBaseData<double> Pos_YM_Receive_Base { get; }
		internal double ref_Pos_YM_Receive_Base = new double();

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
