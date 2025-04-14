using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:MC.NCTOPLC_AXIS_REF
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 256
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct MC_NCTOPLC_AXIS_REF
	{
		public MC_NCTOPLC_AXIS_REF()
		{
		}

		[FieldOffset(0)]
		public MC_NCTOPLC_AXIS_REF_STATE StateDWord = new MC_NCTOPLC_AXIS_REF_STATE();

		[FieldOffset(4)]
		public uint ErrorCode;

		[FieldOffset(8)]
		public uint AxisState;

		[FieldOffset(12)]
		public uint AxisModeConfirmation;

		[FieldOffset(16)]
		public uint HomingState;

		[FieldOffset(20)]
		public uint CoupleState;

		[FieldOffset(24)]
		public uint SvbEntries;

		[FieldOffset(28)]
		public uint SafEntries;

		[FieldOffset(32)]
		public uint AxisId;

		[FieldOffset(36)]
		public MC_NCTOPLC_AXIS_REF_OPMODE OpModeDWord = new MC_NCTOPLC_AXIS_REF_OPMODE();

		[FieldOffset(40)]
		public double ActPos;

		[FieldOffset(48)]
		public double ModuloActPos;

		[FieldOffset(56)]
		public ushort ActiveControlLoopIndex;

		[FieldOffset(58)]
		public ushort ControlLoopIndex;

		[FieldOffset(60)]
		public int ModuloActTurns;

		[FieldOffset(64)]
		public double ActVelo;

		[FieldOffset(72)]
		public double PosDiff;

		[FieldOffset(80)]
		public double SetPos;

		[FieldOffset(88)]
		public double SetVelo;

		[FieldOffset(96)]
		public double SetAcc;

		[FieldOffset(104)]
		public double TargetPos;

		[FieldOffset(112)]
		public double ModuloSetPos;

		[FieldOffset(120)]
		public int ModuloSetTurns;

		[FieldOffset(124)]
		public ushort CmdNo;

		[FieldOffset(126)]
		public ushort CmdState;

		[FieldOffset(128)]
		public double SetJerk;

		[FieldOffset(136)]
		public double SetTorque;

		[FieldOffset(144)]
		public double ActTorque;

		[FieldOffset(160)]
		public int TouchProbeState;

		[FieldOffset(164)]
		public int TouchProbeCounter;

		[FieldOffset(168)]
		public MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE8 CamCouplingState = new MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE8();

		[FieldOffset(176)]
		public UShort8 CamCouplingTableID = new UShort8();

		[FieldOffset(192)]
		public double ActTorqueDerivative;

		[FieldOffset(200)]
		public double SetTorqueDerivative;

		[FieldOffset(208)]
		public double AbsPhasingPos;

		[FieldOffset(216)]
		public double TorqueOffset;

		[FieldOffset(224)]
		public double ActPosWithoutPosCorrection;

		[FieldOffset(232)]
		public double ActAcc;

		[FieldOffset(240)]
		public uint DcTimeStamp;

		[FieldOffset(248)]
		public double UserData;


	}
}
