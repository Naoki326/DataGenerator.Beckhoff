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
	/// Name from PLC:Struct_FaultEvents
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 56
	/// Comment from PLC: 
	/// <summary>
	public partial class Struct_FaultEventsWrapper : BeckhoffStruct<Struct_FaultEventsWrapper, Struct_FaultEvents>
	{
		
		public Struct_FaultEventsWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> FaultState { get; init; }

		public IBaseData<short> FaultId { get; init; }

		public IBaseString FaultTime{ get; init; }

		public Tc2_Standard_R_TRIGWrapper TimeR_TRIG { get; init; }

		public Tc2_Standard_F_TRIGWrapper TimeF_TRIG { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return FaultState;
			yield return FaultId;
			yield return FaultTime;
			yield return TimeR_TRIG;
			yield return TimeF_TRIG;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(FaultState):
					return FaultState;
				case nameof(FaultId):
					return FaultId;
				case nameof(FaultTime):
					return FaultTime;
				case nameof(TimeR_TRIG):
					return TimeR_TRIG;
				case nameof(TimeF_TRIG):
					return TimeF_TRIG;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
