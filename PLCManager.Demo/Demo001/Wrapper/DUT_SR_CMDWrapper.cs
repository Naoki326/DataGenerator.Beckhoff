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
	/// Name from PLC:DUT_SR_CMD
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 2
	/// Comment from PLC: 
	/// <summary>
	public partial class DUT_SR_CMDWrapper : BeckhoffStruct<DUT_SR_CMDWrapper, DUT_SR_CMD>
	{
		
		public DUT_SR_CMDWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> ManualDisable { get; init; }

		public IBaseData<bool> Sensor_In_Signal { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return ManualDisable;
			yield return Sensor_In_Signal;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(ManualDisable):
					return ManualDisable;
				case nameof(Sensor_In_Signal):
					return Sensor_In_Signal;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
