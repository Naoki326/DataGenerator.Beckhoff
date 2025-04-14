using System;
using System.Runtime.InteropServices;

namespace PLCManager.Demo.Enum
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.MC_AxisStates
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 2
	/// Comment from PLC: 
	/// <summary>
	public enum Tc2_MC2_MC_AxisStates : short
	{
		MC_AXISSTATE_UNDEFINED = 0,
		MC_AXISSTATE_DISABLED = 1,
		MC_AXISSTATE_STANDSTILL = 2,
		MC_AXISSTATE_ERRORSTOP = 3,
		MC_AXISSTATE_STOPPING = 4,
		MC_AXISSTATE_HOMING = 5,
		MC_AXISSTATE_DISCRETEMOTION = 6,
		MC_AXISSTATE_CONTINOUSMOTION = 7,
		MC_AXISSTATE_SYNCHRONIZEDMOTION = 8,

	}
}
