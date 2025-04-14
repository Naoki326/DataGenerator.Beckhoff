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
	/// Name from PLC:Tc2_MC2.MC_MoveVelocity
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 1208
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_MC_MoveVelocityWrapper : BeckhoffStruct<Tc2_MC2_MC_MoveVelocityWrapper, Tc2_MC2_MC_MoveVelocity>
	{
		
		public Tc2_MC2_MC_MoveVelocityWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Execute { get; init; }

		public IBaseData<double> Velocity { get; init; }

		public IBaseData<double> Acceleration { get; init; }

		public IBaseData<double> Deceleration { get; init; }

		public IBaseData<double> Jerk { get; init; }

		public IBaseData<Tc2_MC2_MC_Direction> Direction{ get; init; }

		public IBaseData<Tc2_MC2_MC_BufferMode> BufferMode{ get; init; }

		public Tc2_MC2_ST_MoveOptionsWrapper Options { get; init; }

		public IBaseData<bool> InVelocity { get; init; }

		public IBaseData<bool> Busy { get; init; }

		public IBaseData<bool> Active { get; init; }

		public IBaseData<bool> CommandAborted { get; init; }

		public IBaseData<bool> Error { get; init; }

		public IBaseData<uint> ErrorID { get; init; }

		public Tc2_MC2__ST_FunctionBlockResultsWrapper LastExecutionResult { get; init; }

		public IBaseData<bool> ADSbusy { get; init; }

		public Tc2_MC2__FB_MoveUniversalGenericWrapper MoveGeneric { get; init; }

		public IBaseData<ushort> CmdNo { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Execute;
			yield return Velocity;
			yield return Acceleration;
			yield return Deceleration;
			yield return Jerk;
			yield return Direction;
			yield return BufferMode;
			yield return Options;
			yield return InVelocity;
			yield return Busy;
			yield return Active;
			yield return CommandAborted;
			yield return Error;
			yield return ErrorID;
			yield return LastExecutionResult;
			yield return ADSbusy;
			yield return MoveGeneric;
			yield return CmdNo;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Execute):
					return Execute;
				case nameof(Velocity):
					return Velocity;
				case nameof(Acceleration):
					return Acceleration;
				case nameof(Deceleration):
					return Deceleration;
				case nameof(Jerk):
					return Jerk;
				case nameof(Direction):
					return Direction;
				case nameof(BufferMode):
					return BufferMode;
				case nameof(Options):
					return Options;
				case nameof(InVelocity):
					return InVelocity;
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
				case nameof(MoveGeneric):
					return MoveGeneric;
				case nameof(CmdNo):
					return CmdNo;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
