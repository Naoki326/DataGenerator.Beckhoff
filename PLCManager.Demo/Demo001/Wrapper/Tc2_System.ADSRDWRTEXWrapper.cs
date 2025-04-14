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
	/// Name from PLC:Tc2_System.ADSRDWRTEX
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 224
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_System_ADSRDWRTEXWrapper : BeckhoffStruct<Tc2_System_ADSRDWRTEXWrapper, Tc2_System_ADSRDWRTEX>
	{
		
		public Tc2_System_ADSRDWRTEXWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseString NETID{ get; init; }

		public IBaseData<ushort> PORT { get; init; }

		public IBaseData<uint> IDXGRP { get; init; }

		public IBaseData<uint> IDXOFFS { get; init; }

		public IBaseData<uint> WRITELEN { get; init; }

		public IBaseData<uint> READLEN { get; init; }

		public IBaseData<bool> WRTRD { get; init; }

		public IBaseData<uint> TMOUT { get; init; }

		public IBaseData<bool> BUSY { get; init; }

		public IBaseData<bool> ERR { get; init; }

		public IBaseData<uint> ERRID { get; init; }

		public IBaseData<uint> COUNT_R { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return NETID;
			yield return PORT;
			yield return IDXGRP;
			yield return IDXOFFS;
			yield return WRITELEN;
			yield return READLEN;
			yield return WRTRD;
			yield return TMOUT;
			yield return BUSY;
			yield return ERR;
			yield return ERRID;
			yield return COUNT_R;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(NETID):
					return NETID;
				case nameof(PORT):
					return PORT;
				case nameof(IDXGRP):
					return IDXGRP;
				case nameof(IDXOFFS):
					return IDXOFFS;
				case nameof(WRITELEN):
					return WRITELEN;
				case nameof(READLEN):
					return READLEN;
				case nameof(WRTRD):
					return WRTRD;
				case nameof(TMOUT):
					return TMOUT;
				case nameof(BUSY):
					return BUSY;
				case nameof(ERR):
					return ERR;
				case nameof(ERRID):
					return ERRID;
				case nameof(COUNT_R):
					return COUNT_R;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
