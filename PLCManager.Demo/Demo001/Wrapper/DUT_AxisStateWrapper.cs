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
	/// Name from PLC:DUT_AxisState
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 40
	/// Comment from PLC: 
	/// <summary>
	public partial class DUT_AxisStateWrapper : BeckhoffStruct<DUT_AxisStateWrapper, DUT_AxisState>
	{
		
		public DUT_AxisStateWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Warning { get; init; }

		public IBaseData<bool> Alarm { get; init; }

		public IBaseData<bool> Ready { get; init; }

		public IBaseData<bool> Moving { get; init; }

		public IBaseData<bool> Home_OK { get; init; }

		public IBaseData<bool> PowerOn { get; init; }

		public IBaseData<bool> Reset { get; init; }

		public IBaseData<bool> Action_completed { get; init; }

		public IBaseData<bool> Move_Timeout { get; init; }

		public IBaseData<bool> Home_Done { get; init; }

		public IBaseData<bool> OP_State { get; init; }

		public IBaseData<bool> High_Limit_Sensor { get; init; }

		public IBaseData<bool> Home_Sensor { get; init; }

		public IBaseData<bool> Low_Limit_Sensor { get; init; }

		public IBaseData<bool> AbsMoveDone { get; init; }

		public IBaseData<bool> RelMoveDone { get; init; }

		public IBaseData<bool> At_Up_Position { get; init; }

		public IBaseData<bool> At_Middle_Position { get; init; }

		public IBaseData<bool> At_Down_Position { get; init; }

		public IBaseData<float> Torque_Feedback { get; init; }

		public IBaseData<float> Position_Feedback { get; init; }

		public IBaseData<float> Speed_Feedback { get; init; }

		public IBaseData<uint> Software_Driver_ErrorID { get; init; }

		public IBaseData<ushort> Hardware_Driver_ErrorID { get; init; }

		public IBaseData<short> SubItem25 { get; init; }

		public IBaseData<short> SubItem26 { get; init; }

		public IBaseData<short> SubItem27 { get; init; }

		public IBaseData<short> SubItem28 { get; init; }

		public IBaseData<short> SubItem29 { get; init; }

		public IBaseData<short> SubItem30 { get; init; }

		public IBaseData<short> SubItem31 { get; init; }

		public IBaseData<short> SubItem32 { get; init; }

		public IBaseData<short> SubItem33 { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Warning;
			yield return Alarm;
			yield return Ready;
			yield return Moving;
			yield return Home_OK;
			yield return PowerOn;
			yield return Reset;
			yield return Action_completed;
			yield return Move_Timeout;
			yield return Home_Done;
			yield return OP_State;
			yield return High_Limit_Sensor;
			yield return Home_Sensor;
			yield return Low_Limit_Sensor;
			yield return AbsMoveDone;
			yield return RelMoveDone;
			yield return At_Up_Position;
			yield return At_Middle_Position;
			yield return At_Down_Position;
			yield return Torque_Feedback;
			yield return Position_Feedback;
			yield return Speed_Feedback;
			yield return Software_Driver_ErrorID;
			yield return Hardware_Driver_ErrorID;
			yield return SubItem25;
			yield return SubItem26;
			yield return SubItem27;
			yield return SubItem28;
			yield return SubItem29;
			yield return SubItem30;
			yield return SubItem31;
			yield return SubItem32;
			yield return SubItem33;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Warning):
					return Warning;
				case nameof(Alarm):
					return Alarm;
				case nameof(Ready):
					return Ready;
				case nameof(Moving):
					return Moving;
				case nameof(Home_OK):
					return Home_OK;
				case nameof(PowerOn):
					return PowerOn;
				case nameof(Reset):
					return Reset;
				case nameof(Action_completed):
					return Action_completed;
				case nameof(Move_Timeout):
					return Move_Timeout;
				case nameof(Home_Done):
					return Home_Done;
				case nameof(OP_State):
					return OP_State;
				case nameof(High_Limit_Sensor):
					return High_Limit_Sensor;
				case nameof(Home_Sensor):
					return Home_Sensor;
				case nameof(Low_Limit_Sensor):
					return Low_Limit_Sensor;
				case nameof(AbsMoveDone):
					return AbsMoveDone;
				case nameof(RelMoveDone):
					return RelMoveDone;
				case nameof(At_Up_Position):
					return At_Up_Position;
				case nameof(At_Middle_Position):
					return At_Middle_Position;
				case nameof(At_Down_Position):
					return At_Down_Position;
				case nameof(Torque_Feedback):
					return Torque_Feedback;
				case nameof(Position_Feedback):
					return Position_Feedback;
				case nameof(Speed_Feedback):
					return Speed_Feedback;
				case nameof(Software_Driver_ErrorID):
					return Software_Driver_ErrorID;
				case nameof(Hardware_Driver_ErrorID):
					return Hardware_Driver_ErrorID;
				case nameof(SubItem25):
					return SubItem25;
				case nameof(SubItem26):
					return SubItem26;
				case nameof(SubItem27):
					return SubItem27;
				case nameof(SubItem28):
					return SubItem28;
				case nameof(SubItem29):
					return SubItem29;
				case nameof(SubItem30):
					return SubItem30;
				case nameof(SubItem31):
					return SubItem31;
				case nameof(SubItem32):
					return SubItem32;
				case nameof(SubItem33):
					return SubItem33;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
