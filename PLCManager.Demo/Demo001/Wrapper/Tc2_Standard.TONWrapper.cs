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
	/// Name from PLC:Tc2_Standard.TON
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 32
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_Standard_TONWrapper : BeckhoffStruct<Tc2_Standard_TONWrapper, Tc2_Standard_TON>
	{
		
		public Tc2_Standard_TONWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> IN { get; init; }

		public IBaseData<uint> PT { get; init; }

		public IBaseData<bool> Q { get; init; }

		public IBaseData<uint> ET { get; init; }

		public IBaseData<bool> M { get; init; }

		public IBaseData<uint> StartTime { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return IN;
			yield return PT;
			yield return Q;
			yield return ET;
			yield return M;
			yield return StartTime;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(IN):
					return IN;
				case nameof(PT):
					return PT;
				case nameof(Q):
					return Q;
				case nameof(ET):
					return ET;
				case nameof(M):
					return M;
				case nameof(StartTime):
					return StartTime;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
