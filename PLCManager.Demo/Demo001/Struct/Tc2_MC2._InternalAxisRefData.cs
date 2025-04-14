using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._InternalAxisRefData
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 20
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2__InternalAxisRefData
	{
		public Tc2_MC2__InternalAxisRefData()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool NcCycleCounterAvailable;

		[FieldOffset(4)]
		public uint NcCycleCounter_AtReadStatusCall;

		[FieldOffset(8)]
		public byte LastTaskIndex_AtReadStatusCall;

		[FieldOffset(10)]
		public ushort CounterSameTaskIndex_AtReadStatusCall;

		[FieldOffset(12)]
		public uint PhasingCmdNo;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.I1)]
		public bool PhasingCmdTriggered;


	}
}
