using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Struct_FaultEvents
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 56
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Struct_FaultEvents
	{
		public Struct_FaultEvents()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool FaultState;

		[FieldOffset(2)]
		public short FaultId;

		[FieldOffset(4)]
		public String20 FaultTime;

		[FieldOffset(24)]
		public Tc2_Standard_R_TRIG TimeR_TRIG = new Tc2_Standard_R_TRIG();

		[FieldOffset(40)]
		public Tc2_Standard_F_TRIG TimeF_TRIG = new Tc2_Standard_F_TRIG();


	}
}
