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
	/// Name from PLC:Tc2_MC2.ST_MoveOptions
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 40
	/// Comment from PLC: 
	/// <summary>
	public partial class Tc2_MC2_ST_MoveOptionsWrapper : BeckhoffStruct<Tc2_MC2_ST_MoveOptionsWrapper, Tc2_MC2_ST_MoveOptions>
	{
		
		public Tc2_MC2_ST_MoveOptionsWrapper(GetDataDel getDataDel, AdsClient client, uint indexGroup, uint indexOffset) : base(getDataDel, client, indexGroup, indexOffset)
		{
		}
		
		public IBaseData<bool> EnableBlendingPosition { get; init; }

		public IBaseData<double> BlendingPosition { get; init; }

		public IBaseData<double> StartVelocity { get; init; }

		public IBaseData<double> EndVelocity { get; init; }

		public IBaseData<bool> IgnorePositionMonitoring { get; init; }

		public IBaseData<bool> EnableStopPositionMonitoring { get; init; }

		protected override IEnumerable<IBaseData> GetChildren()
		{
			yield return EnableBlendingPosition;
			yield return BlendingPosition;
			yield return StartVelocity;
			yield return EndVelocity;
			yield return IgnorePositionMonitoring;
			yield return EnableStopPositionMonitoring;
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(EnableBlendingPosition):
					return EnableBlendingPosition;
				case nameof(BlendingPosition):
					return BlendingPosition;
				case nameof(StartVelocity):
					return StartVelocity;
				case nameof(EndVelocity):
					return EndVelocity;
				case nameof(IgnorePositionMonitoring):
					return IgnorePositionMonitoring;
				case nameof(EnableStopPositionMonitoring):
					return EnableStopPositionMonitoring;
			}
			throw new KeyNotFoundException(name);
		}

	}
}
