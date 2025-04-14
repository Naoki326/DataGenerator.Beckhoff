using System;
using System.Runtime.InteropServices;

namespace PLCManager.Demo.Enum
{
	/// <summary>
	/// Name from PLC:Tc2_System.E_WATCHDOG_TIME_CONFIG
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 2
	/// Comment from PLC: 
	/// <summary>
	public enum Tc2_System_E_WATCHDOG_TIME_CONFIG : short
	{
		eWATCHDOG_TIME_DISABLED = 0,
		eWATCHDOG_TIME_SECONDS = 1,
		eWATCHDOG_TIME_MINUTES = 2,

	}
}
