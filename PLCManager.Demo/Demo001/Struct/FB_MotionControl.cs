using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:FB_MotionControl
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 14152
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct FB_MotionControl
	{
		public FB_MotionControl()
		{
		}

		[FieldOffset(8)]
		public DUT_MotionCMD CMD = new DUT_MotionCMD();

		[FieldOffset(112)]
		public DUT_AxisState State = new DUT_AxisState();

		[FieldOffset(152)]
		public Tc2_MC2_MC_Power fbPOWER = new Tc2_MC2_MC_Power();

		[FieldOffset(272)]
		public Tc2_MC2_MC_Home fbHome = new Tc2_MC2_MC_Home();

		[FieldOffset(1280)]
		public Tc2_MC2_MC_Stop fbStop = new Tc2_MC2_MC_Stop();

		[FieldOffset(2688)]
		public Tc2_MC2_MC_Halt fbHalt = new Tc2_MC2_MC_Halt();

		[FieldOffset(3880)]
		public Tc2_MC2_MC_Reset fbMcreset = new Tc2_MC2_MC_Reset();

		[FieldOffset(4192)]
		public Tc2_MC2_MC_Jog fbJog = new Tc2_MC2_MC_Jog();

		[FieldOffset(10304)]
		public Tc2_MC2_MC_MoveVelocity fbMoveVelo = new Tc2_MC2_MC_MoveVelocity();

		[FieldOffset(11512)]
		public Tc2_MC2_MC_MoveAbsolute fbMoveAbs = new Tc2_MC2_MC_MoveAbsolute();

		[FieldOffset(12728)]
		public Tc2_MC2_MC_MoveRelative fbMoveRelative = new Tc2_MC2_MC_MoveRelative();

		[FieldOffset(13944)]
		public Tc2_MC2_MC_ReadActualPosition fbCurrentPos = new Tc2_MC2_MC_ReadActualPosition();

		[FieldOffset(13976)]
		public Tc2_MC2_MC_ReadStatus fbAxisStatus = new Tc2_MC2_MC_ReadStatus();

		[FieldOffset(14112)]
		public Tc2_MC2_MC_ReadAxisError fbAxisErrorID = new Tc2_MC2_MC_ReadAxisError();

		[FieldOffset(14144)]
		// pointer or reference
		[Obsolete("PLC reference not used")]
		public byte AXIS;


	}
}
