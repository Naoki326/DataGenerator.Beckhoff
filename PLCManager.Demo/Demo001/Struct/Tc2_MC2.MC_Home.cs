using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.MC_Home
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 1008
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_MC_Home
	{
		public Tc2_MC2_MC_Home()
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
		public double Position;

		[FieldOffset(32)]
		public Tc2_MC2_MC_HomingMode HomingMode;

		[FieldOffset(34)]
		public Tc2_MC2_MC_BufferMode BufferMode;

		[FieldOffset(40)]
		public Tc2_MC2_ST_HomingOptions Options = new Tc2_MC2_ST_HomingOptions();

		[FieldOffset(80)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bCalibrationCam;

		[FieldOffset(81)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Done;

		[FieldOffset(82)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Busy;

		[FieldOffset(83)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Active;

		[FieldOffset(84)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CommandAborted;

		[FieldOffset(85)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Error;

		[FieldOffset(88)]
		public uint ErrorID;

		[FieldOffset(92)]
		public Tc2_MC2__ST_FunctionBlockResults LastExecutionResult = new Tc2_MC2__ST_FunctionBlockResults();

		[FieldOffset(104)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ADSbusy;

		[FieldOffset(106)]
		public Tc2_MC2__E_TcMC_STATES iState;

		[FieldOffset(108)]
		public short iSubState;

		[FieldOffset(112)]
		public Tc2_System_ADSWRITE fbAdsWriteCmd = new Tc2_System_ADSWRITE();

		[FieldOffset(280)]
		public Tc2_System_ADSWRITE fbAdsWriteParameter = new Tc2_System_ADSWRITE();

		[FieldOffset(448)]
		public Tc2_System_ADSREAD fbAdsReadRefPos = new Tc2_System_ADSREAD();

		[FieldOffset(624)]
		public uint ReferenceFlagValue;

		[FieldOffset(632)]
		public Tc2_MC2_MC_SetPosition fbSetPosition = new Tc2_MC2_MC_SetPosition();

		[FieldOffset(912)]
		public double CalibrationValue;

		[FieldOffset(920)]
		public ushort SearchDirection;

		[FieldOffset(928)]
		public double SearchVelocity;

		[FieldOffset(936)]
		public ushort SyncDirection;

		[FieldOffset(944)]
		public double SyncVelocity;

		[FieldOffset(952)]
		public Tc2_MC2_E_EncoderReferenceMode ReferenceMode;

		[FieldOffset(960)]
		public Tc2_Standard_R_TRIG fbTrigger = new Tc2_Standard_R_TRIG();

		[FieldOffset(976)]
		public Tc2_Standard_TON fbTimeOut = new Tc2_Standard_TON();


	}
}
