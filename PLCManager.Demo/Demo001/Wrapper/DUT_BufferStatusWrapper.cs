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
	/// Name from PLC:DUT_BufferStatus
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 6
	/// Comment from PLC: 
	/// <summary>
	public partial class DUT_BufferStatusWrapper : BeckhoffStruct<DUT_BufferStatusWrapper, DUT_BufferStatus>
	{
		
		public DUT_BufferStatusWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<short> iCellNo { get; init; }

		public IBaseData<short> bHomeDone { get; init; }

		public IBaseData<short> Step { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return iCellNo;
			yield return bHomeDone;
			yield return Step;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(iCellNo):
					return iCellNo;
				case nameof(bHomeDone):
					return bHomeDone;
				case nameof(Step):
					return Step;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
