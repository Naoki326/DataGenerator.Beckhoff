using System;
using System.Runtime.InteropServices;

namespace PLCManager.Demo.Enum
{
	/// <summary>
	/// Name from PLC:Tc2_MC2._E_TcMC_STATES
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 2
	/// Comment from PLC: 
	/// <summary>
	public enum Tc2_MC2__E_TcMC_STATES : short
	{
		STATE_INITIALIZATION = 100,
		STATE_ORDER = 101,
		STATE_RUNNING = 102,
		STATE_WAITING = 103,
		STATE_MOTIONCOMMANDSLOCKED = 104,

	}
}
