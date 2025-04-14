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
	/// Name from PLC:Tc2_MC2._ST_FunctionBlockResults
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 12
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2__ST_FunctionBlockResultsWrapper : BeckhoffStruct<Tc2_MC2__ST_FunctionBlockResultsWrapper, Tc2_MC2__ST_FunctionBlockResults>
	{
		
		public Tc2_MC2__ST_FunctionBlockResultsWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Done { get; init; }

		public IBaseData<bool> CommandAborted { get; init; }

		public IBaseData<bool> Error { get; init; }

		public IBaseData<uint> ErrorID { get; init; }

		public IBaseData<uint> BusyCounter { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Done;
			yield return CommandAborted;
			yield return Error;
			yield return ErrorID;
			yield return BusyCounter;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Done):
					return Done;
				case nameof(CommandAborted):
					return CommandAborted;
				case nameof(Error):
					return Error;
				case nameof(ErrorID):
					return ErrorID;
				case nameof(BusyCounter):
					return BusyCounter;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
