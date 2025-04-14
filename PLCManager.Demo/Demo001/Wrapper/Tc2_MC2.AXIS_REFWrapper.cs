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
	/// Name from PLC:Tc2_MC2.AXIS_REF
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 1136
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_AXIS_REFWrapper : BeckhoffStruct<Tc2_MC2_AXIS_REFWrapper, Tc2_MC2_AXIS_REF>
	{
		
		public Tc2_MC2_AXIS_REFWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public MC_PLCTONC_AXIS_REFWrapper PlcToNc { get; init; }

		public MC_NCTOPLC_AXIS_REFWrapper NcToPlc { get; init; }

		public Tc2_MC2_ST_AdsAddressWrapper ADS { get; init; }

		public Tc2_MC2_ST_AxisStatusWrapper Status { get; init; }

		public Tc2_MC2_ST_DriveAddressWrapper DriveAddress { get; init; }

		public Tc2_MC2__InternalAxisRefDataWrapper _internal { get; init; }

		public IBaseArray<Int128, int> Storage{ get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return PlcToNc;
			yield return NcToPlc;
			yield return ADS;
			yield return Status;
			yield return DriveAddress;
			yield return _internal;
			yield return Storage;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(PlcToNc):
					return PlcToNc;
				case nameof(NcToPlc):
					return NcToPlc;
				case nameof(ADS):
					return ADS;
				case nameof(Status):
					return Status;
				case nameof(DriveAddress):
					return DriveAddress;
				case nameof(_internal):
					return _internal;
				case nameof(Storage):
					return Storage;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
