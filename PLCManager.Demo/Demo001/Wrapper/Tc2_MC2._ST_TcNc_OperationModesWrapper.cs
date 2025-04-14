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
	/// Name from PLC:Tc2_MC2._ST_TcNc_OperationModes
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 16
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2__ST_TcNc_OperationModesWrapper : BeckhoffStruct<Tc2_MC2__ST_TcNc_OperationModesWrapper, Tc2_MC2__ST_TcNc_OperationModes>
	{
		
		public Tc2_MC2__ST_TcNc_OperationModesWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<int> PosAreaControl { get; init; }

		public IBaseData<int> TargetPosControl { get; init; }

		public IBaseData<int> StopMonitoring { get; init; }

		public IBaseData<int> AllowSlaveCommands { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return PosAreaControl;
			yield return TargetPosControl;
			yield return StopMonitoring;
			yield return AllowSlaveCommands;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(PosAreaControl):
					return PosAreaControl;
				case nameof(TargetPosControl):
					return TargetPosControl;
				case nameof(StopMonitoring):
					return StopMonitoring;
				case nameof(AllowSlaveCommands):
					return AllowSlaveCommands;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
