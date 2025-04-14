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
	/// Name from PLC:Tc2_MC2.MC_Power
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 120
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_MC_PowerWrapper : BeckhoffStruct<Tc2_MC2_MC_PowerWrapper, Tc2_MC2_MC_Power>
	{
		
		public Tc2_MC2_MC_PowerWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Enable { get; init; }

		public IBaseData<bool> Enable_Positive { get; init; }

		public IBaseData<bool> Enable_Negative { get; init; }

		public IBaseData<double> Override { get; init; }

		public IBaseData<Tc2_MC2_MC_BufferMode> BufferMode{ get; init; }

		public Tc2_MC2_ST_PowerOptionsWrapper Options { get; init; }

		public IBaseData<bool> Status { get; init; }

		public IBaseData<bool> Busy { get; init; }

		public IBaseData<bool> Error { get; init; }

		public IBaseData<uint> ErrorID { get; init; }

		public Tc2_Standard_TONWrapper EnableTimeout { get; init; }

		public Tc2_Standard_TPWrapper EnableOffOnDelay { get; init; }

		public IBaseData<int> iOverride { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Enable;
			yield return Enable_Positive;
			yield return Enable_Negative;
			yield return Override;
			yield return BufferMode;
			yield return Options;
			yield return Status;
			yield return Busy;
			yield return Error;
			yield return ErrorID;
			yield return EnableTimeout;
			yield return EnableOffOnDelay;
			yield return iOverride;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Enable):
					return Enable;
				case nameof(Enable_Positive):
					return Enable_Positive;
				case nameof(Enable_Negative):
					return Enable_Negative;
				case nameof(Override):
					return Override;
				case nameof(BufferMode):
					return BufferMode;
				case nameof(Options):
					return Options;
				case nameof(Status):
					return Status;
				case nameof(Busy):
					return Busy;
				case nameof(Error):
					return Error;
				case nameof(ErrorID):
					return ErrorID;
				case nameof(EnableTimeout):
					return EnableTimeout;
				case nameof(EnableOffOnDelay):
					return EnableOffOnDelay;
				case nameof(iOverride):
					return iOverride;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
