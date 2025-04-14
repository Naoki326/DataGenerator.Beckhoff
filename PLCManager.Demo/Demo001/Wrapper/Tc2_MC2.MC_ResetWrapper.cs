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
	/// Name from PLC:Tc2_MC2.MC_Reset
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 312
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_MC_ResetWrapper : BeckhoffStruct<Tc2_MC2_MC_ResetWrapper, Tc2_MC2_MC_Reset>
	{
		
		public Tc2_MC2_MC_ResetWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Execute { get; init; }

		public IBaseData<bool> Done { get; init; }

		public IBaseData<bool> Busy { get; init; }

		public IBaseData<bool> Error { get; init; }

		public IBaseData<uint> ErrorID { get; init; }

		public IBaseData<bool> ADSbusy { get; init; }

		public IBaseData<Tc2_MC2__E_TcMC_STATES> iState{ get; init; }

		public Tc2_MC2__ST_FunctionBlockResultsWrapper LastExecutionResult { get; init; }

		public Tc2_Standard_R_TRIGWrapper fbOnTrigger { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Execute;
			yield return Done;
			yield return Busy;
			yield return Error;
			yield return ErrorID;
			yield return ADSbusy;
			yield return iState;
			yield return LastExecutionResult;
			yield return fbOnTrigger;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Execute):
					return Execute;
				case nameof(Done):
					return Done;
				case nameof(Busy):
					return Busy;
				case nameof(Error):
					return Error;
				case nameof(ErrorID):
					return ErrorID;
				case nameof(ADSbusy):
					return ADSbusy;
				case nameof(iState):
					return iState;
				case nameof(LastExecutionResult):
					return LastExecutionResult;
				case nameof(fbOnTrigger):
					return fbOnTrigger;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
