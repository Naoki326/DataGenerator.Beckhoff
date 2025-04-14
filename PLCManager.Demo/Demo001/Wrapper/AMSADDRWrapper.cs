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
	/// Name from PLC:AMSADDR
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 8
	/// Comment from PLC: 
	/// <summary>
	public partial class AMSADDRWrapper : BeckhoffStruct<AMSADDRWrapper, AMSADDR>
	{
		
		public AMSADDRWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseArray<Byte6, byte> netId{ get; init; }

		public IBaseData<short> port { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return netId;
			yield return port;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(netId):
					return netId;
				case nameof(port):
					return port;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
