using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._ST_NCADS_IDXOFFS_AxisState
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 104
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2__ST_NCADS_IDXOFFS_AxisState
	{
		public Tc2_MC2__ST_NCADS_IDXOFFS_AxisState()
		{
		}

		[FieldOffset(0)]
		public uint ONLINESTRUCT;

		[FieldOffset(4)]
		public uint ERROR;

		[FieldOffset(8)]
		public uint SETTASKCYCLE;

		[FieldOffset(12)]
		public uint SETPOS;

		[FieldOffset(16)]
		public uint SETVELO;

		[FieldOffset(20)]
		public uint SETACC;

		[FieldOffset(24)]
		public uint MODULOSETPOS;

		[FieldOffset(28)]
		public uint MODULOSETTURNS;

		[FieldOffset(32)]
		public uint SETDIR;

		[FieldOffset(36)]
		public uint TARGETPOSITION;

		[FieldOffset(40)]
		public uint REMAININGTIMEANDPOS;

		[FieldOffset(44)]
		public uint STOPINFORMATION;

		[FieldOffset(48)]
		public uint SETTASKCYCLE_WITHOUTCORR;

		[FieldOffset(52)]
		public uint SETPOS_WITHOUTCORR;

		[FieldOffset(56)]
		public uint SETVELO_WITHOUTCORR;

		[FieldOffset(60)]
		public uint SETACC_WITHOUTCORR;

		[FieldOffset(64)]
		public uint SETDIR_WITHOUTCORR;

		[FieldOffset(68)]
		public uint COUPLESTATE;

		[FieldOffset(72)]
		public uint CPLPARAMS;

		[FieldOffset(76)]
		public uint CPLFACTOR;

		[FieldOffset(80)]
		public uint AXISCTRLLOOPIDX;

		[FieldOffset(84)]
		public uint AXISSETPOINTGENIDX;

		[FieldOffset(88)]
		public uint CPLCHARACVALUES;

		[FieldOffset(92)]
		public uint CAMINFO;

		[FieldOffset(96)]
		public uint CAMSTATUS;

		[FieldOffset(100)]
		public uint ENCODERINITIALIZATIONDONE;


	}
}
