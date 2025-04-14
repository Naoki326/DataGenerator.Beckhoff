using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:ST_Motion
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 15560
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct ST_Motion
	{
		public ST_Motion()
		{
		}

		[FieldOffset(0)]
		public DUT_MotionCMD ManualMotionCMD = new DUT_MotionCMD();

		[FieldOffset(104)]
		public DUT_MotionCMD AutoMotionCMD = new DUT_MotionCMD();

		[FieldOffset(208)]
		public Tc2_MC2_AXIS_REF AXIS_REFERENCE = new Tc2_MC2_AXIS_REF();

		[FieldOffset(1344)]
		public FB_MotionControl AutoMotionAct = new FB_MotionControl();

		[FieldOffset(15496)]
		public DUT_AxisState AxisState = new DUT_AxisState();

		[FieldOffset(15536)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ManualMove;

		[FieldOffset(15540)]
		public uint AxisInput;

		[FieldOffset(15544)]
		public ushort Hardware_AxisErrorID;

		[FieldOffset(15546)]
		public ushort State;

		[FieldOffset(15548)]
		public short Port;

		[FieldOffset(15550)]
		public byte nCtrl1;

		[FieldOffset(15551)]
		public byte nCtrl2;

		[FieldOffset(15552)]
		public ushort Controlword;

		[FieldOffset(15554)]
		public sbyte ModesOfOperation;


	}
}
