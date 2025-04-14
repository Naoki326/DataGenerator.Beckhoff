using System.Runtime.InteropServices;
using System.Collections.Generic;
using TwinCAT.Ads;
using PLCManager.Demo.Enum;
using PLCManager.Demo.Struct;
using PlcCore.Beckhoff;
using PlcCore.Data;

namespace PLCManager.Demo.Wrapper
{
	/// <summary>
	/// Name from PLC:FB_IO_Cylinder
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 520
	/// Comment from PLC: 
	/// <summary>
	public partial class FB_IO_CylinderWrapper : BeckhoffStruct<FB_IO_CylinderWrapper, FB_IO_Cylinder>
	{
		
		public FB_IO_CylinderWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> RunMode { get; init; }

		public IBaseData<bool> Selected { get; init; }

		public IBaseData<bool> Nl { get; init; }

		public IBaseData<bool> PL { get; init; }

		public IBaseData<short> Coil_Num { get; init; }

		public IBaseData<bool> Cmd_Auto_Extend { get; init; }

		public IBaseData<bool> Cmd_Auto_Retract { get; init; }

		public IBaseData<bool> Cmd_Manual_Extend { get; init; }

		public IBaseData<bool> Cmd_Manual_Retract { get; init; }

		public IBaseData<bool> Cmd_Reset { get; init; }

		public IBaseData<float> Over_Time { get; init; }

		public IBaseData<bool> Out_Retract { get; init; }

		public IBaseData<bool> Out_Extend { get; init; }

		public IBaseData<bool> Out_Alarm { get; init; }

		public IStructArray<Tc2_Standard_TON10, Tc2_Standard_TONWrapper, Tc2_Standard_TON> DelayOn{ get; init; }

		public IStructArray<Tc2_Standard_R_TRIG10, Tc2_Standard_R_TRIGWrapper, Tc2_Standard_R_TRIG> TrigOn{ get; init; }

		public IBaseData<short> I { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return RunMode;
			yield return Selected;
			yield return Nl;
			yield return PL;
			yield return Coil_Num;
			yield return Cmd_Auto_Extend;
			yield return Cmd_Auto_Retract;
			yield return Cmd_Manual_Extend;
			yield return Cmd_Manual_Retract;
			yield return Cmd_Reset;
			yield return Over_Time;
			yield return Out_Retract;
			yield return Out_Extend;
			yield return Out_Alarm;
			yield return DelayOn;
			yield return TrigOn;
			yield return I;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(RunMode):
					return RunMode;
				case nameof(Selected):
					return Selected;
				case nameof(Nl):
					return Nl;
				case nameof(PL):
					return PL;
				case nameof(Coil_Num):
					return Coil_Num;
				case nameof(Cmd_Auto_Extend):
					return Cmd_Auto_Extend;
				case nameof(Cmd_Auto_Retract):
					return Cmd_Auto_Retract;
				case nameof(Cmd_Manual_Extend):
					return Cmd_Manual_Extend;
				case nameof(Cmd_Manual_Retract):
					return Cmd_Manual_Retract;
				case nameof(Cmd_Reset):
					return Cmd_Reset;
				case nameof(Over_Time):
					return Over_Time;
				case nameof(Out_Retract):
					return Out_Retract;
				case nameof(Out_Extend):
					return Out_Extend;
				case nameof(Out_Alarm):
					return Out_Alarm;
				case nameof(DelayOn):
					return DelayOn;
				case nameof(TrigOn):
					return TrigOn;
				case nameof(I):
					return I;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
