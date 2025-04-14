using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._ST_TcNC_SetPosOnTheFly
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 32
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2__ST_TcNC_SetPosOnTheFly
	{
		public Tc2_MC2__ST_TcNC_SetPosOnTheFly()
		{
		}

		[FieldOffset(0)]
		public uint nPosSetType;

		[FieldOffset(4)]
		public uint nCtrlDWord;

		[FieldOffset(8)]
		public double fPreviousActualPos;

		[FieldOffset(16)]
		public double fNewActualPos;

		[FieldOffset(24)]
		public Int2 nReserved = new Int2();


	}
}
