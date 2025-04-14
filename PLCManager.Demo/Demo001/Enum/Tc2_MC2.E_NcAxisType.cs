using System;
using System.Runtime.InteropServices;

namespace PLCManager.Demo.Enum
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.E_NcAxisType
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 4
	/// Comment from PLC: 
	/// <summary>
	public enum Tc2_MC2_E_NcAxisType : int
	{
		NcAxisType_undefined = 0,
		NcAxisType_Continious = 1,
		NcAxisType_Discrete_TwoSpeed = 2,
		NcAxisType_LowCostStepper_DigIO = 3,
		NcAxisType_Encoder = 5,
		NcAxisType_Hydraulic = 6,
		NcAxisType_TimeGenerator = 7,
		NcAxisType_Specific = 100,

	}
}
