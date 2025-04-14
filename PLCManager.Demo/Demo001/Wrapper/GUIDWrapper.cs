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
	/// Name from PLC:GUID
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 16
	/// Comment from PLC: 
	/// <summary>
	public partial class GUIDWrapper : BeckhoffStruct<GUIDWrapper, GUID>
	{
		
		public GUIDWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<int> Data1 { get; init; }

		public IBaseData<short> Data2 { get; init; }

		public IBaseData<short> Data3 { get; init; }

		public IBaseArray<Byte8, byte> Data4{ get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Data1;
			yield return Data2;
			yield return Data3;
			yield return Data4;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Data1):
					return Data1;
				case nameof(Data2):
					return Data2;
				case nameof(Data3):
					return Data3;
				case nameof(Data4):
					return Data4;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
