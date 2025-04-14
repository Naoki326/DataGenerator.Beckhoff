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
	/// Name from PLC:DUT_SR_STATE
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 2
	/// Comment from PLC: 
	/// <summary>
	public partial class DUT_SR_STATEWrapper : BeckhoffStruct<DUT_SR_STATEWrapper, DUT_SR_STATE>
	{
		
		public DUT_SR_STATEWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> Sensor_Act { get; init; }

		public IBaseData<bool> Sensor_Fault_Alarm { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return Sensor_Act;
			yield return Sensor_Fault_Alarm;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(Sensor_Act):
					return Sensor_Act;
				case nameof(Sensor_Fault_Alarm):
					return Sensor_Fault_Alarm;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
