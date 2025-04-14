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
	/// Name from PLC:Tc2_MC2.ST_AdsAddress
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 28
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_ST_AdsAddressWrapper : BeckhoffStruct<Tc2_MC2_ST_AdsAddressWrapper, Tc2_MC2_ST_AdsAddress>
	{
		
		public Tc2_MC2_ST_AdsAddressWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseString NetId{ get; init; }

		public IBaseData<ushort> Port { get; init; }

		public IBaseData<ushort> Channel { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return NetId;
			yield return Port;
			yield return Channel;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(NetId):
					return NetId;
				case nameof(Port):
					return Port;
				case nameof(Channel):
					return Channel;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
