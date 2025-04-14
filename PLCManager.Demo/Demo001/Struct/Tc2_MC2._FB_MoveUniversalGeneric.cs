using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._FB_MoveUniversalGeneric
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 1064
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2__FB_MoveUniversalGeneric
	{
		public Tc2_MC2__FB_MoveUniversalGeneric()
		{
		}

		[FieldOffset(8)]
		// pointer or reference
		[Obsolete("PLC reference not used")]
		public byte Axis;

		[FieldOffset(16)]
		// pointer or reference
		[Obsolete("PLC reference not used")]
		public byte LastExecutionResult;

		[FieldOffset(24)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Execute;

		[FieldOffset(26)]
		public Tc2_MC2__E_TcNC_StartPosType StartType;

		[FieldOffset(32)]
		public double Position;

		[FieldOffset(40)]
		public double Torque;

		[FieldOffset(48)]
		public double TorqueRamp;

		[FieldOffset(56)]
		public double Velocity;

		[FieldOffset(64)]
		public double VelocityLimitHigh;

		[FieldOffset(72)]
		public double VelocityLimitLow;

		[FieldOffset(80)]
		public double Acceleration;

		[FieldOffset(88)]
		public double Deceleration;

		[FieldOffset(96)]
		public double Jerk;

		[FieldOffset(104)]
		public Tc2_MC2_MC_BufferMode BufferMode;

		[FieldOffset(112)]
		public Tc2_MC2_ST_MoveOptions Options = new Tc2_MC2_ST_MoveOptions();

		[FieldOffset(152)]
		public Tc2_MC2_ST_TorqueControlOptions OptionsTorque = new Tc2_MC2_ST_TorqueControlOptions();

		[FieldOffset(168)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Reset;

		[FieldOffset(169)]
		[MarshalAs(UnmanagedType.I1)]
		public bool GotoRunState;

		[FieldOffset(170)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ContinuousUpdate;

		[FieldOffset(171)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Done;

		[FieldOffset(172)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Busy;

		[FieldOffset(173)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Active;

		[FieldOffset(174)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CommandAborted;

		[FieldOffset(175)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Error;

		[FieldOffset(176)]
		public uint ErrorID;

		[FieldOffset(180)]
		public ushort CmdNo;

		[FieldOffset(182)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ADSbusy;

		[FieldOffset(183)]
		[MarshalAs(UnmanagedType.I1)]
		public bool InTorque;

		[FieldOffset(184)]
		public Tc2_MC2__E_TcMC_STATES iState;

		[FieldOffset(192)]
		public Tc2_MC2__ST_TcNC_UnversalAxisStartRequest sStartRequest = new Tc2_MC2__ST_TcNC_UnversalAxisStartRequest();

		[FieldOffset(272)]
		public Tc2_MC2__ST_TcNC_UniversalAxisTorqueStartRequest sTorqueStartRequest = new Tc2_MC2__ST_TcNC_UniversalAxisTorqueStartRequest();

		[FieldOffset(344)]
		public Tc2_MC2__ST_TcNC_UnversalAxisStartResponse sStartResponse = new Tc2_MC2__ST_TcNC_UnversalAxisStartResponse();

		[FieldOffset(352)]
		public Tc2_System_ADSRDWRTEX fbAdsReadWrite = new Tc2_System_ADSRDWRTEX();

		[FieldOffset(576)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ContinousMode;

		[FieldOffset(577)]
		[MarshalAs(UnmanagedType.I1)]
		public bool InVelocity;

		[FieldOffset(580)]
		public uint DiffCycleCounter;

		[FieldOffset(584)]
		public Tc2_MC2__ST_TcNC_UnversalAxisStartResponse EmptyStartResponse = new Tc2_MC2__ST_TcNC_UnversalAxisStartResponse();

		[FieldOffset(588)]
		public uint COUNT_R;

		[FieldOffset(592)]
		public byte CounterCmdNoZero;

		[FieldOffset(593)]
		public byte CounterCmdNotStarted;

		[FieldOffset(594)]
		public short DiffCmdNo;

		[FieldOffset(596)]
		public ushort InitialNcToPlcCmdNo;

		[FieldOffset(598)]
		public byte NcCycleCounter;

		[FieldOffset(599)]
		public byte LastNcCycleCounter;

		[FieldOffset(600)]
		public byte NcMappingCounter;

		[FieldOffset(601)]
		[MarshalAs(UnmanagedType.I1)]
		public bool NcCycleCounterAvailable;

		[FieldOffset(602)]
		[MarshalAs(UnmanagedType.I1)]
		public bool NcCycleCounterNotAvailable;

		[FieldOffset(603)]
		[MarshalAs(UnmanagedType.I1)]
		public bool NcCyclicFeedbackExpected;

		[FieldOffset(604)]
		public int PlcDebugCode;

		[FieldOffset(608)]
		[MarshalAs(UnmanagedType.I1)]
		public bool AxisIsSlave;

		[FieldOffset(616)]
		public Tc2_System_GETCURTASKINDEX GetTaskIndex = new Tc2_System_GETCURTASKINDEX();

		[FieldOffset(648)]
		public uint CycleCounter;

		[FieldOffset(652)]
		public uint BusyCounter;

		[FieldOffset(656)]
		public Tc2_Standard_TON fbTimeOut = new Tc2_Standard_TON();

		[FieldOffset(688)]
		public Tc2_Standard_TON fbStopMonitoringTimeOut = new Tc2_Standard_TON();

		[FieldOffset(720)]
		public Tc2_Standard_TON fbTimeOutMappingCounter = new Tc2_Standard_TON();

		[FieldOffset(752)]
		public Tc2_Standard_R_TRIG fbOnTrigger = new Tc2_Standard_R_TRIG();

		[FieldOffset(768)]
		public String256 sTempMsg;

		[FieldOffset(1024)]
		[MarshalAs(UnmanagedType.I1)]
		public bool AccDecreasing;

		[FieldOffset(1032)]
		public double AccOld;

		[FieldOffset(1040)]
		[MarshalAs(UnmanagedType.I1)]
		public bool iContinuousUpdate;

		[FieldOffset(1044)]
		public Tc2_MC2__ST_TcNc_OperationModes OpMode = new Tc2_MC2__ST_TcNc_OperationModes();


	}
}
