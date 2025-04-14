using System.Runtime.InteropServices;
using System.Collections.Generic;
using TwinCAT.Ads;
using PLCManager.Demo.Enum;
using PLCManager.Demo.Struct;
using PlcCore.Beckhoff;
using PlcCore.Data;

namespace PLCManager.Demo.Wrapper
{
	/// <summary>
	/// Name from PLC:Tc2_MC2.ST_DriveAddress
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 84
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_ST_DriveAddressWrapper : BeckhoffStruct<Tc2_MC2_ST_DriveAddressWrapper, Tc2_MC2_ST_DriveAddress>
	{
		
		public Tc2_MC2_ST_DriveAddressWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseString NetID{ get; init; }

		public IBaseArray<Byte6, byte> NetIdBytes{ get; init; }

		public IBaseData<ushort> SlaveAddress { get; init; }

		public IBaseData<byte> Channel { get; init; }

		public IBaseData<int> NcDriveId { get; init; }

		public IBaseData<int> NcDriveIndex { get; init; }

		public IBaseData<Tc2_MC2_E_NcDriveType> NcDriveType{ get; init; }

		public IBaseData<int> NcEncoderId { get; init; }

		public IBaseData<int> NcEncoderIndex { get; init; }

		public IBaseData<Tc2_MC2_E_NcEncoderType> NcEncoderType{ get; init; }

		public IBaseData<int> NcAxisId { get; init; }

		public IBaseData<Tc2_MC2_E_NcAxisType> NcAxisType{ get; init; }

		public IBaseData<uint> TcSoftDriveObjectId { get; init; }

		public IBaseData<uint> TcDriveObjectId { get; init; }

		public IBaseData<uint> TcEncoderObjectId { get; init; }

		public IBaseData<uint> TcAxisObjectId { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return NetID;
			yield return NetIdBytes;
			yield return SlaveAddress;
			yield return Channel;
			yield return NcDriveId;
			yield return NcDriveIndex;
			yield return NcDriveType;
			yield return NcEncoderId;
			yield return NcEncoderIndex;
			yield return NcEncoderType;
			yield return NcAxisId;
			yield return NcAxisType;
			yield return TcSoftDriveObjectId;
			yield return TcDriveObjectId;
			yield return TcEncoderObjectId;
			yield return TcAxisObjectId;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(NetID):
					return NetID;
				case nameof(NetIdBytes):
					return NetIdBytes;
				case nameof(SlaveAddress):
					return SlaveAddress;
				case nameof(Channel):
					return Channel;
				case nameof(NcDriveId):
					return NcDriveId;
				case nameof(NcDriveIndex):
					return NcDriveIndex;
				case nameof(NcDriveType):
					return NcDriveType;
				case nameof(NcEncoderId):
					return NcEncoderId;
				case nameof(NcEncoderIndex):
					return NcEncoderIndex;
				case nameof(NcEncoderType):
					return NcEncoderType;
				case nameof(NcAxisId):
					return NcAxisId;
				case nameof(NcAxisType):
					return NcAxisType;
				case nameof(TcSoftDriveObjectId):
					return TcSoftDriveObjectId;
				case nameof(TcDriveObjectId):
					return TcDriveObjectId;
				case nameof(TcEncoderObjectId):
					return TcEncoderObjectId;
				case nameof(TcAxisObjectId):
					return TcAxisObjectId;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
