using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:DUT_SR_STATE
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 2
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct DUT_SR_STATE
	{
		public DUT_SR_STATE()
		{
		}

		[FieldOffset(0)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Sensor_Act;

		[FieldOffset(1)]
		[MarshalAs(UnmanagedType.I1)]
		public bool Sensor_Fault_Alarm;


	}
}
