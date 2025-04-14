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
	/// Name from PLC:Tc2_MC2.MC_SetPosition
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 280
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_MC_SetPositionWrapper : BeckhoffStruct<Tc2_MC2_MC_SetPositionWrapper, Tc2_MC2_MC_SetPosition>
	{
		
		public Tc2_MC2_MC_SetPositionWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Execute { get; init; }

		public IBaseData<double> Position { get; init; }

		public IBaseData<bool> Mode { get; init; }

		public Tc2_MC2_ST_SetPositionOptionsWrapper Options { get; init; }

		public IBaseData<bool> Done { get; init; }

		public IBaseData<bool> Busy { get; init; }

		public IBaseData<bool> Error { get; init; }

		public IBaseData<uint> ErrorID { get; init; }

		public IBaseData<bool> ADSbusy { get; init; }

		public Tc2_MC2__ST_TcNC_SetPosOnTheFlyWrapper stSetPos { get; init; }

		public IBaseData<Tc2_MC2__E_TcMC_STATES> iState{ get; init; }

		public Tc2_System_ADSWRITEWrapper fbAdsWrite { get; init; }

		public Tc2_Standard_R_TRIGWrapper fbOnTrigger { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Execute;
			yield return Position;
			yield return Mode;
			yield return Options;
			yield return Done;
			yield return Busy;
			yield return Error;
			yield return ErrorID;
			yield return ADSbusy;
			yield return stSetPos;
			yield return iState;
			yield return fbAdsWrite;
			yield return fbOnTrigger;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Execute):
					return Execute;
				case nameof(Position):
					return Position;
				case nameof(Mode):
					return Mode;
				case nameof(Options):
					return Options;
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
				case nameof(stSetPos):
					return stSetPos;
				case nameof(iState):
					return iState;
				case nameof(fbAdsWrite):
					return fbAdsWrite;
				case nameof(fbOnTrigger):
					return fbOnTrigger;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
