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
	/// Name from PLC:Tc2_System.ADSREAD
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 176
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_System_ADSREADWrapper : BeckhoffStruct<Tc2_System_ADSREADWrapper, Tc2_System_ADSREAD>
	{
		
		public Tc2_System_ADSREADWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseString NETID{ get; init; }

		public IBaseData<ushort> PORT { get; init; }

		public IBaseData<uint> IDXGRP { get; init; }

		public IBaseData<uint> IDXOFFS { get; init; }

		public IBaseData<uint> LEN { get; init; }

		public IBaseData<bool> READ { get; init; }

		public IBaseData<uint> TMOUT { get; init; }

		public IBaseData<bool> BUSY { get; init; }

		public IBaseData<bool> ERR { get; init; }

		public IBaseData<uint> ERRID { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return NETID;
			yield return PORT;
			yield return IDXGRP;
			yield return IDXOFFS;
			yield return LEN;
			yield return READ;
			yield return TMOUT;
			yield return BUSY;
			yield return ERR;
			yield return ERRID;
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
				case nameof(LEN):
					return LEN;
				case nameof(READ):
					return READ;
				case nameof(TMOUT):
					return TMOUT;
				case nameof(BUSY):
					return BUSY;
				case nameof(ERR):
					return ERR;
				case nameof(ERRID):
					return ERRID;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
