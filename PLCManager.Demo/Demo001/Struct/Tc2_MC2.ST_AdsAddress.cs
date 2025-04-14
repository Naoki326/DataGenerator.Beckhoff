using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.ST_AdsAddress
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 28
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_ST_AdsAddress
	{
		public Tc2_MC2_ST_AdsAddress()
		{
		}

		[FieldOffset(0)]
		public String24 NetId;

		[FieldOffset(24)]
		public ushort Port;

		[FieldOffset(26)]
		public ushort Channel;


	}
}
