using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:_Implicit_Task_Info
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 112
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct _Implicit_Task_Info
	{
		public _Implicit_Task_Info()
		{
		}

		[FieldOffset(0)]
		public int dwVersion;

		[FieldOffset(8)]
		// pointer or reference
		[Obsolete("PLC reference not used")]
		public byte pszName;

		[FieldOffset(16)]
		public short nPriority;

		[FieldOffset(18)]
		public _Implicit_KindOfTask KindOf;

		[FieldOffset(20)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bWatchdog;

		[FieldOffset(21)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bProfilingTask;

		[FieldOffset(24)]
		// pointer or reference
		[Obsolete("PLC reference not used")]
		public byte dwEventFunctionPointer;

		[FieldOffset(32)]
		// pointer or reference
		[Obsolete("PLC reference not used")]
		public byte pszExternalEvent;

		[FieldOffset(40)]
		// pointer or reference
		[Obsolete("PLC reference not used")]
		public byte dwTaskEntryFunctionPointer;

		[FieldOffset(48)]
		public int dwWatchdogSensitivity;

		[FieldOffset(52)]
		public int dwInterval;

		[FieldOffset(56)]
		public int dwWatchdogTime;

		[FieldOffset(60)]
		public int dwLastCycleTime;

		[FieldOffset(64)]
		public int dwAverageCycleTime;

		[FieldOffset(68)]
		public int dwMaxCycleTime;

		[FieldOffset(72)]
		public int dwMinCycleTime;

		[FieldOffset(76)]
		public int diJitter;

		[FieldOffset(80)]
		public int diJitterMin;

		[FieldOffset(84)]
		public int diJitterMax;

		[FieldOffset(88)]
		public int dwCycleCount;

		[FieldOffset(92)]
		public short wTaskStatus;

		[FieldOffset(94)]
		public short wNumOfJitterDistributions;

		[FieldOffset(96)]
		// pointer or reference
		[Obsolete("PLC reference not used")]
		public byte pJitterDistribution;

		[FieldOffset(104)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bWithinSPSTimeSlicing;

		[FieldOffset(105)]
		public byte byDummy;

		[FieldOffset(106)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bShouldBlock;

		[FieldOffset(107)]
		[MarshalAs(UnmanagedType.I1)]
		public bool bActive;

		[FieldOffset(108)]
		public int dwIECCycleCount;


	}
}
