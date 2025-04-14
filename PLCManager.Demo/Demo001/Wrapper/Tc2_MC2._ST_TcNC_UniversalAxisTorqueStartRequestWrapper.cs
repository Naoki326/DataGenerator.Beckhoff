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
	/// Name from PLC:Tc2_MC2._ST_TcNC_UniversalAxisTorqueStartRequest
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 72
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2__ST_TcNC_UniversalAxisTorqueStartRequestWrapper : BeckhoffStruct<Tc2_MC2__ST_TcNC_UniversalAxisTorqueStartRequestWrapper, Tc2_MC2__ST_TcNC_UniversalAxisTorqueStartRequest>
	{
		
		public Tc2_MC2__ST_TcNC_UniversalAxisTorqueStartRequestWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<uint> nStartType { get; init; }

		public IBaseData<uint> nControlMask { get; init; }

		public IBaseData<uint> nMode { get; init; }

		public IBaseData<uint> nBufferMode { get; init; }

		public IBaseData<double> fTorque { get; init; }

		public IBaseData<double> fTorqueRamp { get; init; }

		public IBaseData<double> fVelocityLimitHigh { get; init; }

		public IBaseData<double> fVelocityLimitLow { get; init; }

		public IBaseData<double> fAcceleration { get; init; }

		public IBaseData<double> fDeceleration { get; init; }

		public IBaseData<double> fManualTorque { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return nStartType;
			yield return nControlMask;
			yield return nMode;
			yield return nBufferMode;
			yield return fTorque;
			yield return fTorqueRamp;
			yield return fVelocityLimitHigh;
			yield return fVelocityLimitLow;
			yield return fAcceleration;
			yield return fDeceleration;
			yield return fManualTorque;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(nStartType):
					return nStartType;
				case nameof(nControlMask):
					return nControlMask;
				case nameof(nMode):
					return nMode;
				case nameof(nBufferMode):
					return nBufferMode;
				case nameof(fTorque):
					return fTorque;
				case nameof(fTorqueRamp):
					return fTorqueRamp;
				case nameof(fVelocityLimitHigh):
					return fVelocityLimitHigh;
				case nameof(fVelocityLimitLow):
					return fVelocityLimitLow;
				case nameof(fAcceleration):
					return fAcceleration;
				case nameof(fDeceleration):
					return fDeceleration;
				case nameof(fManualTorque):
					return fManualTorque;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
