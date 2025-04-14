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
	/// Name from PLC:Tc2_MC2.MC_Home
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 1008
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_MC_HomeWrapper : BeckhoffStruct<Tc2_MC2_MC_HomeWrapper, Tc2_MC2_MC_Home>
	{
		
		public Tc2_MC2_MC_HomeWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Execute { get; init; }

		public IBaseData<double> Position { get; init; }

		public IBaseData<Tc2_MC2_MC_HomingMode> HomingMode{ get; init; }

		public IBaseData<Tc2_MC2_MC_BufferMode> BufferMode{ get; init; }

		public Tc2_MC2_ST_HomingOptionsWrapper Options { get; init; }

		public IBaseData<bool> bCalibrationCam { get; init; }

		public IBaseData<bool> Done { get; init; }

		public IBaseData<bool> Busy { get; init; }

		public IBaseData<bool> Active { get; init; }

		public IBaseData<bool> CommandAborted { get; init; }

		public IBaseData<bool> Error { get; init; }

		public IBaseData<uint> ErrorID { get; init; }

		public Tc2_MC2__ST_FunctionBlockResultsWrapper LastExecutionResult { get; init; }

		public IBaseData<bool> ADSbusy { get; init; }

		public IBaseData<Tc2_MC2__E_TcMC_STATES> iState{ get; init; }

		public IBaseData<short> iSubState { get; init; }

		public Tc2_System_ADSWRITEWrapper fbAdsWriteCmd { get; init; }

		public Tc2_System_ADSWRITEWrapper fbAdsWriteParameter { get; init; }

		public Tc2_System_ADSREADWrapper fbAdsReadRefPos { get; init; }

		public IBaseData<uint> ReferenceFlagValue { get; init; }

		public Tc2_MC2_MC_SetPositionWrapper fbSetPosition { get; init; }

		public IBaseData<double> CalibrationValue { get; init; }

		public IBaseData<ushort> SearchDirection { get; init; }

		public IBaseData<double> SearchVelocity { get; init; }

		public IBaseData<ushort> SyncDirection { get; init; }

		public IBaseData<double> SyncVelocity { get; init; }

		public IBaseData<Tc2_MC2_E_EncoderReferenceMode> ReferenceMode{ get; init; }

		public Tc2_Standard_R_TRIGWrapper fbTrigger { get; init; }

		public Tc2_Standard_TONWrapper fbTimeOut { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Execute;
			yield return Position;
			yield return HomingMode;
			yield return BufferMode;
			yield return Options;
			yield return bCalibrationCam;
			yield return Done;
			yield return Busy;
			yield return Active;
			yield return CommandAborted;
			yield return Error;
			yield return ErrorID;
			yield return LastExecutionResult;
			yield return ADSbusy;
			yield return iState;
			yield return iSubState;
			yield return fbAdsWriteCmd;
			yield return fbAdsWriteParameter;
			yield return fbAdsReadRefPos;
			yield return ReferenceFlagValue;
			yield return fbSetPosition;
			yield return CalibrationValue;
			yield return SearchDirection;
			yield return SearchVelocity;
			yield return SyncDirection;
			yield return SyncVelocity;
			yield return ReferenceMode;
			yield return fbTrigger;
			yield return fbTimeOut;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Execute):
					return Execute;
				case nameof(Position):
					return Position;
				case nameof(HomingMode):
					return HomingMode;
				case nameof(BufferMode):
					return BufferMode;
				case nameof(Options):
					return Options;
				case nameof(bCalibrationCam):
					return bCalibrationCam;
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
				case nameof(LastExecutionResult):
					return LastExecutionResult;
				case nameof(ADSbusy):
					return ADSbusy;
				case nameof(iState):
					return iState;
				case nameof(iSubState):
					return iSubState;
				case nameof(fbAdsWriteCmd):
					return fbAdsWriteCmd;
				case nameof(fbAdsWriteParameter):
					return fbAdsWriteParameter;
				case nameof(fbAdsReadRefPos):
					return fbAdsReadRefPos;
				case nameof(ReferenceFlagValue):
					return ReferenceFlagValue;
				case nameof(fbSetPosition):
					return fbSetPosition;
				case nameof(CalibrationValue):
					return CalibrationValue;
				case nameof(SearchDirection):
					return SearchDirection;
				case nameof(SearchVelocity):
					return SearchVelocity;
				case nameof(SyncDirection):
					return SyncDirection;
				case nameof(SyncVelocity):
					return SyncVelocity;
				case nameof(ReferenceMode):
					return ReferenceMode;
				case nameof(fbTrigger):
					return fbTrigger;
				case nameof(fbTimeOut):
					return fbTimeOut;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
