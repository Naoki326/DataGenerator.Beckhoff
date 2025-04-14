using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.MC_Stop
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 1408
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_MC_Stop
	{
		public Tc2_MC2_MC_Stop()
		{
		}

		[FieldOffset(8)]
		// pointer or reference
		[Obsolete("PLC reference not used")]
		public byte Axis;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Execute;

		[FieldOffset(24)]
		public double Deceleration;

		[FieldOffset(32)]
		public double Jerk;

		[FieldOffset(40)]
		public Tc2_MC2_ST_MoveOptions Options = new Tc2_MC2_ST_MoveOptions();

		[FieldOffset(80)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Done;

		[FieldOffset(81)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Busy;

		[FieldOffset(82)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Active;

		[FieldOffset(83)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CommandAborted;

		[FieldOffset(84)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Error;

		[FieldOffset(88)]
		public uint ErrorID;

		[FieldOffset(92)]
		public Tc2_MC2__ST_FunctionBlockResults LastExecutionResult = new Tc2_MC2__ST_FunctionBlockResults();

		[FieldOffset(104)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ADSbusy;

		[FieldOffset(112)]
		public Tc2_MC2__FB_MoveUniversalGeneric MoveGeneric = new Tc2_MC2__FB_MoveUniversalGeneric();

		[FieldOffset(1176)]
		public Tc2_System_ADSWRITE ReleaseLock = new Tc2_System_ADSWRITE();

		[FieldOffset(1344)]
		public ushort CmdNo;

		[FieldOffset(1346)]
		[MarshalAs(UnmanagedType.I1)]
		public bool AxisMotionCommandsLocked;

		[FieldOffset(1348)]
		public Tc2_MC2__E_TcMC_STATES iState;

		[FieldOffset(1352)]
		public Tc2_Standard_TON NoJobTimer = new Tc2_Standard_TON();

		[FieldOffset(1384)]
		public Tc2_Standard_R_TRIG fbOnTrigger = new Tc2_Standard_R_TRIG();

		[FieldOffset(1400)]
		public short CounterMotionCommandsLocked;


	}
}
