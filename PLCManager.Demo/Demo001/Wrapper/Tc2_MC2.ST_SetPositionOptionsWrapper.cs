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
	/// Name from PLC:Tc2_MC2.ST_SetPositionOptions
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 6
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_ST_SetPositionOptionsWrapper : BeckhoffStruct<Tc2_MC2_ST_SetPositionOptionsWrapper, Tc2_MC2_ST_SetPositionOptions>
	{
		
		public Tc2_MC2_ST_SetPositionOptionsWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> ClearPositionLag { get; init; }

		public IBaseData<bool> DirectHoming { get; init; }

		public IBaseData<bool> ClearPositionOffset { get; init; }

		public IBaseData<bool> SelectEncoderIndex { get; init; }

		public IBaseData<ushort> EncoderIndex { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return ClearPositionLag;
			yield return DirectHoming;
			yield return ClearPositionOffset;
			yield return SelectEncoderIndex;
			yield return EncoderIndex;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(ClearPositionLag):
					return ClearPositionLag;
				case nameof(DirectHoming):
					return DirectHoming;
				case nameof(ClearPositionOffset):
					return ClearPositionOffset;
				case nameof(SelectEncoderIndex):
					return SelectEncoderIndex;
				case nameof(EncoderIndex):
					return EncoderIndex;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
