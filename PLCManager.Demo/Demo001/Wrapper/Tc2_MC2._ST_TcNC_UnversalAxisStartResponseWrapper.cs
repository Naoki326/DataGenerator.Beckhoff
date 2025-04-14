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
	/// Name from PLC:Tc2_MC2._ST_TcNC_UnversalAxisStartResponse
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 4
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2__ST_TcNC_UnversalAxisStartResponseWrapper : BeckhoffStruct<Tc2_MC2__ST_TcNC_UnversalAxisStartResponseWrapper, Tc2_MC2__ST_TcNC_UnversalAxisStartResponse>
	{
		
		public Tc2_MC2__ST_TcNC_UnversalAxisStartResponseWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<short> nCmdNo { get; init; }

		public IBaseData<short> nCmdState { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return nCmdNo;
			yield return nCmdState;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(nCmdNo):
					return nCmdNo;
				case nameof(nCmdState):
					return nCmdState;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
