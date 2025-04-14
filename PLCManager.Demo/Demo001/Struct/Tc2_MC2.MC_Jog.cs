using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.MC_Jog
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 6112
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_MC_Jog
	{
		public Tc2_MC2_MC_Jog()
		{
		}

		[FieldOffset(8)]
		// pointer or reference
		[Obsolete("PLC reference not used")]
		public byte Axis;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.I1)]
		public bool JogForward;

		[FieldOffset(17)]
		[MarshalAs(UnmanagedType.I1)]
		public bool JogBackwards;

		[FieldOffset(18)]
		public Tc2_MC2_E_JogMode Mode;

		[FieldOffset(24)]
		public double Position;

		[FieldOffset(32)]
		public double Velocity;

		[FieldOffset(40)]
		public double Acceleration;

		[FieldOffset(48)]
		public double Deceleration;

		[FieldOffset(56)]
		public double Jerk;

		[FieldOffset(64)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Done;

		[FieldOffset(65)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Busy;

		[FieldOffset(66)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Active;

		[FieldOffset(67)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CommandAborted;

		[FieldOffset(68)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Error;

		[FieldOffset(72)]
		public uint ErrorID;

		[FieldOffset(76)]
		public short state;

		[FieldOffset(80)]
		public Tc2_MC2__ST_FunctionBlockResults LastExecutionResult = new Tc2_MC2__ST_FunctionBlockResults();

		[FieldOffset(92)]
		[MarshalAs(UnmanagedType.I1)]
		public bool StateDWord;

		[FieldOffset(93)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ExecuteMoveVelocity;

		[FieldOffset(96)]
		public Tc2_MC2_MC_MoveVelocity MoveVelocity = new Tc2_MC2_MC_MoveVelocity();

		[FieldOffset(1304)]
		public Tc2_MC2_ST_McOutputs MoveVelocityOut = new Tc2_MC2_ST_McOutputs();

		[FieldOffset(1316)]
		public Tc2_MC2_MC_Direction Direction;

		[FieldOffset(1318)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ExecuteHalt;

		[FieldOffset(1320)]
		public Tc2_MC2_MC_Halt Halt = new Tc2_MC2_MC_Halt();

		[FieldOffset(2512)]
		public Tc2_MC2_ST_McOutputs HaltOut = new Tc2_MC2_ST_McOutputs();

		[FieldOffset(2524)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ExecuteMoveAbsolute;

		[FieldOffset(2528)]
		public Tc2_MC2_MC_MoveAbsolute MoveAbsolute = new Tc2_MC2_MC_MoveAbsolute();

		[FieldOffset(3744)]
		public Tc2_MC2_ST_McOutputs MoveAbsoluteOut = new Tc2_MC2_ST_McOutputs();

		[FieldOffset(3756)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ExecuteMoveRelative;

		[FieldOffset(3760)]
		public Tc2_MC2_MC_MoveRelative MoveRelative = new Tc2_MC2_MC_MoveRelative();

		[FieldOffset(4976)]
		public Tc2_MC2_ST_McOutputs MoveRelativeOut = new Tc2_MC2_ST_McOutputs();

		[FieldOffset(4992)]
		public Tc2_MC2__FB_MoveUniversalGeneric JogMove = new Tc2_MC2__FB_MoveUniversalGeneric();

		[FieldOffset(6056)]
		public Tc2_MC2__ST_FunctionBlockResults LastJogMoveResult = new Tc2_MC2__ST_FunctionBlockResults();

		[FieldOffset(6068)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ExecuteJogMove;

		[FieldOffset(6070)]
		public Tc2_MC2__E_TcNC_StartPosType StartType;

		[FieldOffset(6072)]
		public Tc2_MC2_ST_McOutputs JogMoveOut = new Tc2_MC2_ST_McOutputs();

		[FieldOffset(6084)]
		[MarshalAs(UnmanagedType.I1)]
		public bool JogEnd;

		[FieldOffset(6088)]
		public double TargetPosition;

		[FieldOffset(6096)]
		public double modulo;

		[FieldOffset(6104)]
		public double moduloremainder;


	}
}
