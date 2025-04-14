using System;
using System.Runtime.InteropServices;

namespace PLCManager.Demo.Enum
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.E_NcDriveType
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 4
	/// Comment from PLC: 
	/// <summary>
	public enum Tc2_MC2_E_NcDriveType : int
	{
		NcDriveType_undefined = 0,
		NcDriveType_M2400_DAC1 = 1,
		NcDriveType_M2400_DAC2 = 2,
		NcDriveType_M2400_DAC3 = 3,
		NcDriveType_M2400_DAC4 = 4,
		NcDriveType_KL4XXX = 5,
		NcDriveType_KL4XXX_NonLinear = 6,
		NcDriveType_Discete_TwoSpeed = 7,
		NcDriveType_Stepper = 8,
		NcDriveType_Sercos = 9,
		NcDriveType_KL5051 = 10,
		NcDriveType_AX2000_B200 = 11,
		NcDriveType_ProfiDrive = 12,
		NcDriveType_Universal = 13,
		NcDriveType_NcBackplane = 14,
		NcDriveType_CANopen_Lenze = 15,
		NcDriveType_CANopen_DS402_MDP742 = 16,
		NcDriveType_AX2000_B900 = 17,
		NcDriveType_KL2531_Stepper = 20,
		NcDriveType_KL2532_DC = 21,
		NcDriveType_TCOM = 22,
		NcDriveType_MDP_733 = 23,
		NcDriveType_MDP_703 = 24,

	}
}
