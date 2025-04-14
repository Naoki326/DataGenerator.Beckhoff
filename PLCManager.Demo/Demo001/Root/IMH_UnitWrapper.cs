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
	/// Name from PLC:IMH_Unit
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class IMH_UnitWrapper
	{

		/// <summary>
		/// Name from PLC:Home_Move
		/// TypeName from PLC: ARRAY [1..20] OF BOOL
		/// (IndexGroup, IndexOffset): (16448,1167836)
		/// Size: 20
		public IBaseArray<Bool20, bool> Home_Move { get; }
		internal Bool20 ref_Home_Move = new Bool20();

		/// <summary>
		/// Name from PLC:LCase_Move
		/// TypeName from PLC: ARRAY [1..20] OF BOOL
		/// (IndexGroup, IndexOffset): (16448,1167856)
		/// Size: 20
		public IBaseArray<Bool20, bool> LCase_Move { get; }
		internal Bool20 ref_LCase_Move = new Bool20();

		/// <summary>
		/// Name from PLC:ULCase_Move
		/// TypeName from PLC: ARRAY [1..20] OF BOOL
		/// (IndexGroup, IndexOffset): (16448,1167876)
		/// Size: 20
		public IBaseArray<Bool20, bool> ULCase_Move { get; }
		internal Bool20 ref_ULCase_Move = new Bool20();

		/// <summary>
		/// Name from PLC:Auto_Move
		/// TypeName from PLC: ARRAY [1..20] OF BOOL
		/// (IndexGroup, IndexOffset): (16448,1167896)
		/// Size: 20
		public IBaseArray<Bool20, bool> Auto_Move { get; }
		internal Bool20 ref_Auto_Move = new Bool20();

		/// <summary>
		/// Name from PLC:i
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,1167916)
		/// Size: 2
		public IBaseData<short> i { get; }
		internal short ref_i = new short();

		/// <summary>
		/// Name from PLC:H_DelayOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.TON
		/// (IndexGroup, IndexOffset): (16448,1167920)
		/// Size: 640
		public IStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON> H_DelayOn { get; }
		internal Tc2_Standard_TON20 ref_H_DelayOn = new Tc2_Standard_TON20();

		/// <summary>
		/// Name from PLC:H_TrigOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.R_TRIG
		/// (IndexGroup, IndexOffset): (16448,1168560)
		/// Size: 320
		public IStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG> H_TrigOn { get; }
		internal Tc2_Standard_R_TRIG20 ref_H_TrigOn = new Tc2_Standard_R_TRIG20();

		/// <summary>
		/// Name from PLC:L_DelayOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.TON
		/// (IndexGroup, IndexOffset): (16448,1168880)
		/// Size: 640
		public IStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON> L_DelayOn { get; }
		internal Tc2_Standard_TON20 ref_L_DelayOn = new Tc2_Standard_TON20();

		/// <summary>
		/// Name from PLC:L_TrigOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.R_TRIG
		/// (IndexGroup, IndexOffset): (16448,1169520)
		/// Size: 320
		public IStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG> L_TrigOn { get; }
		internal Tc2_Standard_R_TRIG20 ref_L_TrigOn = new Tc2_Standard_R_TRIG20();

		/// <summary>
		/// Name from PLC:UL_DelayOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.TON
		/// (IndexGroup, IndexOffset): (16448,1169840)
		/// Size: 640
		public IStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON> UL_DelayOn { get; }
		internal Tc2_Standard_TON20 ref_UL_DelayOn = new Tc2_Standard_TON20();

		/// <summary>
		/// Name from PLC:UL_TrigOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.R_TRIG
		/// (IndexGroup, IndexOffset): (16448,1170480)
		/// Size: 320
		public IStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG> UL_TrigOn { get; }
		internal Tc2_Standard_R_TRIG20 ref_UL_TrigOn = new Tc2_Standard_R_TRIG20();

		/// <summary>
		/// Name from PLC:DelayOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.TON
		/// (IndexGroup, IndexOffset): (16448,1170800)
		/// Size: 640
		public IStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON> DelayOn { get; }
		internal Tc2_Standard_TON20 ref_DelayOn = new Tc2_Standard_TON20();

		/// <summary>
		/// Name from PLC:TrigOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.R_TRIG
		/// (IndexGroup, IndexOffset): (16448,1171440)
		/// Size: 320
		public IStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG> TrigOn { get; }
		internal Tc2_Standard_R_TRIG20 ref_TrigOn = new Tc2_Standard_R_TRIG20();

		/// <summary>
		/// Name from PLC:Initial_DelayOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.TON
		/// (IndexGroup, IndexOffset): (16448,1171760)
		/// Size: 640
		public IStructArray<Tc2_Standard_TON20, Tc2_Standard_TONWrapper, Tc2_Standard_TON> Initial_DelayOn { get; }
		internal Tc2_Standard_TON20 ref_Initial_DelayOn = new Tc2_Standard_TON20();

		/// <summary>
		/// Name from PLC:Initial_TrigOn
		/// TypeName from PLC: ARRAY [1..20] OF Tc2_Standard.R_TRIG
		/// (IndexGroup, IndexOffset): (16448,1172400)
		/// Size: 320
		public IStructArray<Tc2_Standard_R_TRIG20, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG> Initial_TrigOn { get; }
		internal Tc2_Standard_R_TRIG20 ref_Initial_TrigOn = new Tc2_Standard_R_TRIG20();

		/// <summary>
		/// Name from PLC:Pos_IMH_ZM_Bottom_TO_Top
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,1172720)
		/// Size: 4
		public IBaseData<float> Pos_IMH_ZM_Bottom_TO_Top { get; }
		internal float ref_Pos_IMH_ZM_Bottom_TO_Top = new float();

		/// <summary>
		/// Name from PLC:Pos_IMH_ZM_Top_To_Bottom
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,1172724)
		/// Size: 4
		public IBaseData<float> Pos_IMH_ZM_Top_To_Bottom { get; }
		internal float ref_Pos_IMH_ZM_Top_To_Bottom = new float();

		/// <summary>
		/// Name from PLC:Pos_ZM_Receive_Buffer
		/// TypeName from PLC: REAL
		/// (IndexGroup, IndexOffset): (16448,1172728)
		/// Size: 4
		public IBaseData<float> Pos_ZM_Receive_Buffer { get; }
		internal float ref_Pos_ZM_Receive_Buffer = new float();

		/// <summary>
		/// Name from PLC:IMH_PosY_Loader_Buffer
		/// TypeName from PLC: LREAL
		/// (IndexGroup, IndexOffset): (16448,1172736)
		/// Size: 8
		public IBaseData<double> IMH_PosY_Loader_Buffer { get; }
		internal double ref_IMH_PosY_Loader_Buffer = new double();

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
