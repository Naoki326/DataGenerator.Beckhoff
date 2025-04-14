using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.ST_HomingOptions
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 40
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_ST_HomingOptions
	{
		public Tc2_MC2_ST_HomingOptions()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool ClearPositionLag;

		[FieldOffset(2)]
		public Tc2_MC2_MC_Direction SearchDirection;

		[FieldOffset(8)]
		public double SearchVelocity;

		[FieldOffset(16)]
		public Tc2_MC2_MC_Direction SyncDirection;

		[FieldOffset(24)]
		public double SyncVelocity;

		[FieldOffset(32)]
		public Tc2_MC2_E_EncoderReferenceMode ReferenceMode;


	}
}
