using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._ST_TcNc_OperationModes
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 16
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2__ST_TcNc_OperationModes
	{
		public Tc2_MC2__ST_TcNc_OperationModes()
		{
		}

		[FieldOffset(0)]
		public int PosAreaControl;

		[FieldOffset(4)]
		public int TargetPosControl;

		[FieldOffset(8)]
		public int StopMonitoring;

		[FieldOffset(12)]
		public int AllowSlaveCommands;


	}
}
