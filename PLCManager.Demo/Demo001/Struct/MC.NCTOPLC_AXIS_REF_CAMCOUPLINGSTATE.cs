using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:MC.NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 1
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE
	{
		public MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CamActivationPending;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CamDeactivationPending;

		[FieldOffset(2)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CamActive;

		[FieldOffset(6)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CamDataQueued;

		[FieldOffset(7)]
		[MarshalAs(UnmanagedType.I1)]
		public bool CamScalingPending;


	}
}
