using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:MC.PLCTONC_AXIS_REF
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 128
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct MC_PLCTONC_AXIS_REF
	{
		public MC_PLCTONC_AXIS_REF()
		{
		}

		[FieldOffset(0)]
		public MC_PLCTONC_AXIS_REF_CTRL ControlDWord = new MC_PLCTONC_AXIS_REF_CTRL();

		[FieldOffset(4)]
		public uint Override;

		[FieldOffset(8)]
		public uint AxisModeRequest;

		[FieldOffset(12)]
		public uint AxisModeDWord;

		[FieldOffset(16)]
		public double AxisModeLReal;

		[FieldOffset(24)]
		public double PositionCorrection;

		[FieldOffset(32)]
		public double ExtSetPos;

		[FieldOffset(40)]
		public double ExtSetVelo;

		[FieldOffset(48)]
		public double ExtSetAcc;

		[FieldOffset(56)]
		public int ExtSetDirection;

		[FieldOffset(64)]
		public double ExtControllerOutput;

		[FieldOffset(72)]
		public double GearRatio1;

		[FieldOffset(80)]
		public double GearRatio2;

		[FieldOffset(88)]
		public double GearRatio3;

		[FieldOffset(96)]
		public double GearRatio4;

		[FieldOffset(104)]
		[MarshalAs(UnmanagedType.I1)]
		public bool MapState;

		[FieldOffset(105)]
		public byte PlcCycleControl;

		[FieldOffset(106)]
		public byte PlcCycleCount;

		[FieldOffset(112)]
		public double ExtTorque;


	}
}
