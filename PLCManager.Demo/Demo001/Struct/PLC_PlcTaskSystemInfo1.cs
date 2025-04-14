using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;
using PlcCore.Data;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:ARRAY [1..1] OF PLC.PlcTaskSystemInfo
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 128
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct PLC_PlcTaskSystemInfo1 : IPLCStructArray<PLC_PlcTaskSystemInfo>
	{
		[FieldOffset(0)]
		public PLC_PlcTaskSystemInfo Item_0;

		public PLC_PlcTaskSystemInfo this[int index]
		{
			get
			{
				switch(index)
				{
					case 0: return Item_0;
					default: throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch(index)
				{
					case 0: Item_0 = value; break;
					default: throw new IndexOutOfRangeException();
				}
			}

		}

		public int Length => 1;

		public IEnumerator<PLC_PlcTaskSystemInfo> GetEnumerator()
		{
			for (int i = 0; i < Length; i++)
			{
				yield return this[i];
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

	}
}
