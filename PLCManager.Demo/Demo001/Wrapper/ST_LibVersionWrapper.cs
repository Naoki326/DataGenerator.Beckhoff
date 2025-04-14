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
	/// Name from PLC:ST_LibVersion
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 36
	/// Comment from PLC: 
	/// <summary>
	public partial class ST_LibVersionWrapper : BeckhoffStruct<ST_LibVersionWrapper, ST_LibVersion>
	{
		
		public ST_LibVersionWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<ushort> iMajor { get; init; }

		public IBaseData<ushort> iMinor { get; init; }

		public IBaseData<ushort> iBuild { get; init; }

		public IBaseData<ushort> iRevision { get; init; }

		public IBaseData<int> nFlags { get; init; }

		public IBaseString sVersion{ get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return iMajor;
			yield return iMinor;
			yield return iBuild;
			yield return iRevision;
			yield return nFlags;
			yield return sVersion;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(iMajor):
					return iMajor;
				case nameof(iMinor):
					return iMinor;
				case nameof(iBuild):
					return iBuild;
				case nameof(iRevision):
					return iRevision;
				case nameof(nFlags):
					return nFlags;
				case nameof(sVersion):
					return sVersion;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
