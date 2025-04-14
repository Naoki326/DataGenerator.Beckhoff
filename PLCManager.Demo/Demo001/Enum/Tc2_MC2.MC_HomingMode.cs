using System;
using System.Runtime.InteropServices;

namespace PLCManager.Demo.Enum
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.MC_HomingMode
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 2
	/// Comment from PLC: 
	/// <summary>
	public enum Tc2_MC2_MC_HomingMode : short
	{
		MC_DefaultHoming = 0,
		MC_AbsSwitch = 1,
		MC_LimitSwitch = 2,
		MC_RefPulse = 3,
		MC_Direct = 4,
		MC_Absolute = 5,
		MC_Block = 6,
		MC_ForceCalibration = 7,
		MC_ResetCalibration = 8,

	}
}
