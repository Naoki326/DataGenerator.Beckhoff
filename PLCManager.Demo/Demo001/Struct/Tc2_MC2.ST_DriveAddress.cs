using System;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.ST_DriveAddress
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 84
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_MC2_ST_DriveAddress
	{
		public Tc2_MC2_ST_DriveAddress()
		{
		}

		[FieldOffset(0)]
		public String24 NetID;

		[FieldOffset(24)]
		public Byte6 NetIdBytes = new Byte6();

		[FieldOffset(30)]
		public ushort SlaveAddress;

		[FieldOffset(32)]
		public byte Channel;

		[FieldOffset(36)]
		public int NcDriveId;

		[FieldOffset(40)]
		public int NcDriveIndex;

		[FieldOffset(44)]
		public Tc2_MC2_E_NcDriveType NcDriveType;

		[FieldOffset(48)]
		public int NcEncoderId;

		[FieldOffset(52)]
		public int NcEncoderIndex;

		[FieldOffset(56)]
		public Tc2_MC2_E_NcEncoderType NcEncoderType;

		[FieldOffset(60)]
		public int NcAxisId;

		[FieldOffset(64)]
		public Tc2_MC2_E_NcAxisType NcAxisType;

		[FieldOffset(68)]
		public uint TcSoftDriveObjectId;

		[FieldOffset(72)]
		public uint TcDriveObjectId;

		[FieldOffset(76)]
		public uint TcEncoderObjectId;

		[FieldOffset(80)]
		public uint TcAxisObjectId;


	}
}
