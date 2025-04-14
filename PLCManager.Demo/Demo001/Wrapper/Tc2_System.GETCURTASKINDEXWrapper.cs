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
	/// Name from PLC:Tc2_System.GETCURTASKINDEX
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 32
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_System_GETCURTASKINDEXWrapper : BeckhoffStruct<Tc2_System_GETCURTASKINDEXWrapper, Tc2_System_GETCURTASKINDEX>
	{
		
		public Tc2_System_GETCURTASKINDEXWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<byte> index { get; init; }

		public Tc2_System_FW_GetCurTaskIndexWrapper fbGetCurTaskIndex { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return index;
			yield return fbGetCurTaskIndex;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(index):
					return index;
				case nameof(fbGetCurTaskIndex):
					return fbGetCurTaskIndex;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
