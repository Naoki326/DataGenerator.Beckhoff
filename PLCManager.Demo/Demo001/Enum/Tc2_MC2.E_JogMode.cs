using System;
using System.Runtime.InteropServices;

namespace PLCManager.Demo.Enum
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.E_JogMode
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 2
	/// Comment from PLC: 
	/// <summary>
	public enum Tc2_MC2_E_JogMode : short
	{
		MC_JOGMODE_STANDARD_SLOW = 0,
		MC_JOGMODE_STANDARD_FAST = 1,
		MC_JOGMODE_CONTINOUS = 2,
		MC_JOGMODE_INCHING = 3,
		MC_JOGMODE_INCHING_MODULO = 4,

	}
}
