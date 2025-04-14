using System;
using System.Runtime.InteropServices;

namespace PLCManager.Demo.Enum
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.E_NcEncoderType
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 4
	/// Comment from PLC: 
	/// <summary>
	public enum Tc2_MC2_E_NcEncoderType : int
	{
		NcEncoderType_undefined = 0,
		NcEncoderType_Simulation = 1,
		NcEncoderType_ABS_M3000 = 2,
		NcEncoderType_INC_M31X0 = 3,
		NcEncoderType_INC_KL5101 = 4,
		NcEncoderType_ABS_KL5001_SSI = 5,
		NcEncoderType_INC_KL5051 = 6,
		NcEncoderType_ABS_KL30XX = 7,
		NcEncoderType_INC_Sercos_P = 8,
		NcEncoderType_INC_Sercos_PV = 9,
		NcEncoderType_INC_Binary = 10,
		NcEncoderType_ABS_M2510 = 11,
		NcEncoderType_ABS_FOX50 = 12,
		NcEncoderType_ABS_HYDRAULIC_FORCE = 13,
		NcEncoderType_INC_AX2000_B200 = 14,
		NcEncoderType_INC_PROFIDRIVE = 15,
		NcEncoderType_INC_UNIVERSAL = 16,
		NcEncoderType_INC_NCBACKPLANE = 17,
		NcEncoderType_INC_CANOPEN_LENZE = 18,
		NcEncoderType_INC_CANOPEN_DS402_MDP513_MDP742 = 19,
		NcEncoderType_INC_AX2000_B900 = 20,
		NcEncoderType_INC_KL5151 = 21,
		NcEncoderType_INC_IP5209 = 24,
		NcEncoderType_INC_KL2531_Stepper = 25,
		NcEncoderType_INC_KL2532_DC = 26,
		NcEncoderType_INC_TIMEBASEGENERATOR = 27,
		NcEncoderType_INC_TCOM = 28,
		NcEncoderType_INC_CANOPEN_MDP513_64BIT = 29,
		NcEncoderType_SPECIFIC = 100,

	}
}
