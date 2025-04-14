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
	/// Name from PLC:Tc2_MC2.MC_Jog
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 6112
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_MC_JogWrapper : BeckhoffStruct<Tc2_MC2_MC_JogWrapper, Tc2_MC2_MC_Jog>
	{
		
		public Tc2_MC2_MC_JogWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> JogForward { get; init; }

		public IBaseData<bool> JogBackwards { get; init; }

		public IBaseData<Tc2_MC2_E_JogMode> Mode{ get; init; }

		public IBaseData<double> Position { get; init; }

		public IBaseData<double> Velocity { get; init; }

		public IBaseData<double> Acceleration { get; init; }

		public IBaseData<double> Deceleration { get; init; }

		public IBaseData<double> Jerk { get; init; }

		public IBaseData<bool> Done { get; init; }

		public IBaseData<bool> Busy { get; init; }

		public IBaseData<bool> Active { get; init; }

		public IBaseData<bool> CommandAborted { get; init; }

		public IBaseData<bool> Error { get; init; }

		public IBaseData<uint> ErrorID { get; init; }

		public IBaseData<short> state { get; init; }

		public Tc2_MC2__ST_FunctionBlockResultsWrapper LastExecutionResult { get; init; }

		public IBaseData<bool> StateDWord { get; init; }

		public IBaseData<bool> ExecuteMoveVelocity { get; init; }

		public Tc2_MC2_MC_MoveVelocityWrapper MoveVelocity { get; init; }

		public Tc2_MC2_ST_McOutputsWrapper MoveVelocityOut { get; init; }

		public IBaseData<Tc2_MC2_MC_Direction> Direction{ get; init; }

		public IBaseData<bool> ExecuteHalt { get; init; }

		public Tc2_MC2_MC_HaltWrapper Halt { get; init; }

		public Tc2_MC2_ST_McOutputsWrapper HaltOut { get; init; }

		public IBaseData<bool> ExecuteMoveAbsolute { get; init; }

		public Tc2_MC2_MC_MoveAbsoluteWrapper MoveAbsolute { get; init; }

		public Tc2_MC2_ST_McOutputsWrapper MoveAbsoluteOut { get; init; }

		public IBaseData<bool> ExecuteMoveRelative { get; init; }

		public Tc2_MC2_MC_MoveRelativeWrapper MoveRelative { get; init; }

		public Tc2_MC2_ST_McOutputsWrapper MoveRelativeOut { get; init; }

		public Tc2_MC2__FB_MoveUniversalGenericWrapper JogMove { get; init; }

		public Tc2_MC2__ST_FunctionBlockResultsWrapper LastJogMoveResult { get; init; }

		public IBaseData<bool> ExecuteJogMove { get; init; }

		public IBaseData<Tc2_MC2__E_TcNC_StartPosType> StartType{ get; init; }

		public Tc2_MC2_ST_McOutputsWrapper JogMoveOut { get; init; }

		public IBaseData<bool> JogEnd { get; init; }

		public IBaseData<double> TargetPosition { get; init; }

		public IBaseData<double> modulo { get; init; }

		public IBaseData<double> moduloremainder { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return JogForward;
			yield return JogBackwards;
			yield return Mode;
			yield return Position;
			yield return Velocity;
			yield return Acceleration;
			yield return Deceleration;
			yield return Jerk;
			yield return Done;
			yield return Busy;
			yield return Active;
			yield return CommandAborted;
			yield return Error;
			yield return ErrorID;
			yield return state;
			yield return LastExecutionResult;
			yield return StateDWord;
			yield return ExecuteMoveVelocity;
			yield return MoveVelocity;
			yield return MoveVelocityOut;
			yield return Direction;
			yield return ExecuteHalt;
			yield return Halt;
			yield return HaltOut;
			yield return ExecuteMoveAbsolute;
			yield return MoveAbsolute;
			yield return MoveAbsoluteOut;
			yield return ExecuteMoveRelative;
			yield return MoveRelative;
			yield return MoveRelativeOut;
			yield return JogMove;
			yield return LastJogMoveResult;
			yield return ExecuteJogMove;
			yield return StartType;
			yield return JogMoveOut;
			yield return JogEnd;
			yield return TargetPosition;
			yield return modulo;
			yield return moduloremainder;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(JogForward):
					return JogForward;
				case nameof(JogBackwards):
					return JogBackwards;
				case nameof(Mode):
					return Mode;
				case nameof(Position):
					return Position;
				case nameof(Velocity):
					return Velocity;
				case nameof(Acceleration):
					return Acceleration;
				case nameof(Deceleration):
					return Deceleration;
				case nameof(Jerk):
					return Jerk;
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
				case nameof(state):
					return state;
				case nameof(LastExecutionResult):
					return LastExecutionResult;
				case nameof(StateDWord):
					return StateDWord;
				case nameof(ExecuteMoveVelocity):
					return ExecuteMoveVelocity;
				case nameof(MoveVelocity):
					return MoveVelocity;
				case nameof(MoveVelocityOut):
					return MoveVelocityOut;
				case nameof(Direction):
					return Direction;
				case nameof(ExecuteHalt):
					return ExecuteHalt;
				case nameof(Halt):
					return Halt;
				case nameof(HaltOut):
					return HaltOut;
				case nameof(ExecuteMoveAbsolute):
					return ExecuteMoveAbsolute;
				case nameof(MoveAbsolute):
					return MoveAbsolute;
				case nameof(MoveAbsoluteOut):
					return MoveAbsoluteOut;
				case nameof(ExecuteMoveRelative):
					return ExecuteMoveRelative;
				case nameof(MoveRelative):
					return MoveRelative;
				case nameof(MoveRelativeOut):
					return MoveRelativeOut;
				case nameof(JogMove):
					return JogMove;
				case nameof(LastJogMoveResult):
					return LastJogMoveResult;
				case nameof(ExecuteJogMove):
					return ExecuteJogMove;
				case nameof(StartType):
					return StartType;
				case nameof(JogMoveOut):
					return JogMoveOut;
				case nameof(JogEnd):
					return JogEnd;
				case nameof(TargetPosition):
					return TargetPosition;
				case nameof(modulo):
					return modulo;
				case nameof(moduloremainder):
					return moduloremainder;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
