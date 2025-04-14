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
	/// Name from PLC:Tc2_MC2.ST_McOutputs
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 12
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_ST_McOutputsWrapper : BeckhoffStruct<Tc2_MC2_ST_McOutputsWrapper, Tc2_MC2_ST_McOutputs>
	{
		
		public Tc2_MC2_ST_McOutputsWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Done { get; init; }

		public IBaseData<bool> Busy { get; init; }

		public IBaseData<bool> Active { get; init; }

		public IBaseData<bool> CommandAborted { get; init; }

		public IBaseData<bool> Error { get; init; }

		public IBaseData<uint> ErrorID { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Done;
			yield return Busy;
			yield return Active;
			yield return CommandAborted;
			yield return Error;
			yield return ErrorID;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Done):
					return Done;
				case nameof(Busy):
					return Busy;
				case nameof(Active):
					return Active;
				case nameof(CommandAborted):
					return CommandAborted;
				case nameof(Error):
					return Error;
				case nameof(ErrorID):
					return ErrorID;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
