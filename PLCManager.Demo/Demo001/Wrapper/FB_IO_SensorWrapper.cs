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
	/// Name from PLC:FB_IO_Sensor
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 192
	/// Comment from PLC: 
	/// <summary>
	public partial class FB_IO_SensorWrapper : BeckhoffStruct<FB_IO_SensorWrapper, FB_IO_Sensor>
	{
		
		public FB_IO_SensorWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Disenable { get; init; }

		public IBaseData<bool> In_Signal { get; init; }

		public IBaseData<bool> Cmd_Reset { get; init; }

		public IBaseData<float> Over_Time { get; init; }

		public IBaseData<bool> Out_Signal { get; init; }

		public IBaseData<bool> Out_Alarm { get; init; }

		public IStructArray<Tc2_Standard_TON5, Tc2_Standard_TONWrapper, Tc2_Standard_TON> DelayOn{ get; init; }

		public IBaseData<short> I { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Disenable;
			yield return In_Signal;
			yield return Cmd_Reset;
			yield return Over_Time;
			yield return Out_Signal;
			yield return Out_Alarm;
			yield return DelayOn;
			yield return I;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Disenable):
					return Disenable;
				case nameof(In_Signal):
					return In_Signal;
				case nameof(Cmd_Reset):
					return Cmd_Reset;
				case nameof(Over_Time):
					return Over_Time;
				case nameof(Out_Signal):
					return Out_Signal;
				case nameof(Out_Alarm):
					return Out_Alarm;
				case nameof(DelayOn):
					return DelayOn;
				case nameof(I):
					return I;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
