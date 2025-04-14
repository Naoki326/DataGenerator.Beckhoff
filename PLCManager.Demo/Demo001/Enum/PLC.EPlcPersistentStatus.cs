using System;
using System.Runtime.InteropServices;

namespace PLCManager.Demo.Enum
{
	/// <summary>
	/// Name from PLC:PLC.EPlcPersistentStatus
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 1
	/// Comment from PLC: 
	/// <summary>
	public enum PLC_EPlcPersistentStatus : byte
	{
		PS_None = 0,
		PS_All = 1,
		PS_Partial = 2,

	}
}
