using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:DUT_AxisState
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 40
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct DUT_AxisState
	{
		public DUT_AxisState()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Warning;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Alarm;

		[FieldOffset(2)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Ready;

		[FieldOffset(3)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Moving;

		[FieldOffset(4)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Home_OK;

		[FieldOffset(5)]
		[MarshalAs(UnmanagedType.I1)]
		public bool PowerOn;

		[FieldOffset(6)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Reset;

		[FieldOffset(7)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Action_completed;

		[FieldOffset(8)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Move_Timeout;

		[FieldOffset(9)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Home_Done;

		[FieldOffset(10)]
		[MarshalAs(UnmanagedType.I1)]
		public bool OP_State;

		[FieldOffset(11)]
		[MarshalAs(UnmanagedType.I1)]
		public bool High_Limit_Sensor;

		[FieldOffset(12)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Home_Sensor;

		[FieldOffset(13)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Low_Limit_Sensor;

		[FieldOffset(14)]
		[MarshalAs(UnmanagedType.I1)]
		public bool AbsMoveDone;

		[FieldOffset(15)]
		[MarshalAs(UnmanagedType.I1)]
		public bool RelMoveDone;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.I1)]
		public bool At_Up_Position;

		[FieldOffset(17)]
		[MarshalAs(UnmanagedType.I1)]
		public bool At_Middle_Position;

		[FieldOffset(18)]
		[MarshalAs(UnmanagedType.I1)]
		public bool At_Down_Position;

		[FieldOffset(4)]
		public float Torque_Feedback;

		[FieldOffset(8)]
		public float Position_Feedback;

		[FieldOffset(12)]
		public float Speed_Feedback;

		[FieldOffset(16)]
		public uint Software_Driver_ErrorID;

		[FieldOffset(20)]
		public ushort Hardware_Driver_ErrorID;

		[FieldOffset(22)]
		public short SubItem25;

		[FieldOffset(24)]
		public short SubItem26;

		[FieldOffset(26)]
		public short SubItem27;

		[FieldOffset(28)]
		public short SubItem28;

		[FieldOffset(30)]
		public short SubItem29;

		[FieldOffset(32)]
		public short SubItem30;

		[FieldOffset(34)]
		public short SubItem31;

		[FieldOffset(36)]
		public short SubItem32;

		[FieldOffset(38)]
		public short SubItem33;


	}
}
