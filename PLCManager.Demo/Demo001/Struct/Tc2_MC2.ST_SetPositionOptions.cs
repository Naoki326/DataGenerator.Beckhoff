using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.ST_SetPositionOptions
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 6
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_ST_SetPositionOptions
	{
		public Tc2_MC2_ST_SetPositionOptions()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ClearPositionLag;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.I1)]
		public bool DirectHoming;

		[FieldOffset(2)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ClearPositionOffset;

		[FieldOffset(3)]
		[MarshalAs(UnmanagedType.I1)]
		public bool SelectEncoderIndex;

		[FieldOffset(4)]
		public ushort EncoderIndex;


	}
}
