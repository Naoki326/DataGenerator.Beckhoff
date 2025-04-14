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
	/// Name from PLC:Tc2_MC2.ST_HomingOptions
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 40
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_ST_HomingOptionsWrapper : BeckhoffStruct<Tc2_MC2_ST_HomingOptionsWrapper, Tc2_MC2_ST_HomingOptions>
	{
		
		public Tc2_MC2_ST_HomingOptionsWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> ClearPositionLag { get; init; }

		public IBaseData<Tc2_MC2_MC_Direction> SearchDirection{ get; init; }

		public IBaseData<double> SearchVelocity { get; init; }

		public IBaseData<Tc2_MC2_MC_Direction> SyncDirection{ get; init; }

		public IBaseData<double> SyncVelocity { get; init; }

		public IBaseData<Tc2_MC2_E_EncoderReferenceMode> ReferenceMode{ get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return ClearPositionLag;
			yield return SearchDirection;
			yield return SearchVelocity;
			yield return SyncDirection;
			yield return SyncVelocity;
			yield return ReferenceMode;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(ClearPositionLag):
					return ClearPositionLag;
				case nameof(SearchDirection):
					return SearchDirection;
				case nameof(SearchVelocity):
					return SearchVelocity;
				case nameof(SyncDirection):
					return SyncDirection;
				case nameof(SyncVelocity):
					return SyncVelocity;
				case nameof(ReferenceMode):
					return ReferenceMode;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
