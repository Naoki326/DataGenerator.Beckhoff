using System;
using System.Runtime.InteropServices;

namespace PLCManager.Demo.Enum
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.MC_Direction
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 2
	/// Comment from PLC: 
	/// <summary>
	public enum Tc2_MC2_MC_Direction : short
	{
		MC_Positive_Direction = 1,
		MC_Shortest_Way = 2,
		MC_Negative_Direction = 3,
		MC_Current_Direction = 4,
		MC_Undefined_Direction = 128,

	}
}
