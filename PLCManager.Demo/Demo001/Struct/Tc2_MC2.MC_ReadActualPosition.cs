using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.MC_ReadActualPosition
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 32
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_MC_ReadActualPosition
	{
		public Tc2_MC2_MC_ReadActualPosition()
		{
		}

		[FieldOffset(8)]
		// pointer or reference
		[Obsolete("PLC reference not used")]
		public byte Axis;

		[FieldOffset(16)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Enable;

		[FieldOffset(17)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Valid;

		[FieldOffset(18)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Busy;

		[FieldOffset(19)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Error;

		[FieldOffset(20)]
		public uint ErrorID;

		[FieldOffset(24)]
		public double Position;


	}
}
