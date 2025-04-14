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
	/// Name from PLC:Tc2_MC2._ST_NCADS_IDXOFFS_TableParameter
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 24
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2__ST_NCADS_IDXOFFS_TableParameterWrapper : BeckhoffStruct<Tc2_MC2__ST_NCADS_IDXOFFS_TableParameterWrapper, Tc2_MC2__ST_NCADS_IDXOFFS_TableParameter>
	{
		
		public Tc2_MC2__ST_NCADS_IDXOFFS_TableParameterWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<uint> MFREADCHARACVALUES { get; init; }

		public IBaseData<uint> WRITETABROWS { get; init; }

		public IBaseData<uint> WRITEMFTABROWS { get; init; }

		public IBaseData<uint> MFREADTAB { get; init; }

		public IBaseData<uint> READSLAVEDYNAMICS { get; init; }

		public IBaseData<uint> READMASTERPOSITION { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return MFREADCHARACVALUES;
			yield return WRITETABROWS;
			yield return WRITEMFTABROWS;
			yield return MFREADTAB;
			yield return READSLAVEDYNAMICS;
			yield return READMASTERPOSITION;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(MFREADCHARACVALUES):
					return MFREADCHARACVALUES;
				case nameof(WRITETABROWS):
					return WRITETABROWS;
				case nameof(WRITEMFTABROWS):
					return WRITEMFTABROWS;
				case nameof(MFREADTAB):
					return MFREADTAB;
				case nameof(READSLAVEDYNAMICS):
					return READSLAVEDYNAMICS;
				case nameof(READMASTERPOSITION):
					return READMASTERPOSITION;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
