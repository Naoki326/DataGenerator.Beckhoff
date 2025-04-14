using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._ST_TcNC_UnversalAxisStartResponse
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 4
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2__ST_TcNC_UnversalAxisStartResponse
	{
		public Tc2_MC2__ST_TcNC_UnversalAxisStartResponse()
		{
		}

		[FieldOffset(0)]
		public short nCmdNo;

		[FieldOffset(2)]
		public short nCmdState;


	}
}
