using System;
using System.Runtime.InteropServices;

namespace PLCManager.Demo.Enum
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.MC_BufferMode
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 2
	/// Comment from PLC: 
	/// <summary>
	public enum Tc2_MC2_MC_BufferMode : ushort
	{
		MC_Aborting = 0,
		MC_Buffered = 1,
		MC_BlendingLow = 18,
		MC_BlendingPrevious = 19,
		MC_BlendingNext = 20,
		MC_BlendingHigh = 21,

	}
}
