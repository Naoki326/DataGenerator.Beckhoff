using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;
using PlcCore.Data;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:ARRAY [0..7] OF MC.NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 8
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE8 : IPLCStructArray<MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE>
	{
		[FieldOffset(0)]
		public MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE Item_0;

		[FieldOffset(1)]
		public MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE Item_1;

		[FieldOffset(2)]
		public MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE Item_2;

		[FieldOffset(3)]
		public MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE Item_3;

		[FieldOffset(4)]
		public MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE Item_4;

		[FieldOffset(5)]
		public MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE Item_5;

		[FieldOffset(6)]
		public MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE Item_6;

		[FieldOffset(7)]
		public MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE Item_7;

		public MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE this[int index]
		{
			get
			{
				switch(index)
				{
					case 0: return Item_0;
					case 1: return Item_1;
					case 2: return Item_2;
					case 3: return Item_3;
					case 4: return Item_4;
					case 5: return Item_5;
					case 6: return Item_6;
					case 7: return Item_7;
					default: throw new IndexOutOfRangeException();
				}
			}
			set
			{
				switch(index)
				{
					case 0: Item_0 = value; break;
					case 1: Item_1 = value; break;
					case 2: Item_2 = value; break;
					case 3: Item_3 = value; break;
					case 4: Item_4 = value; break;
					case 5: Item_5 = value; break;
					case 6: Item_6 = value; break;
					case 7: Item_7 = value; break;
					default: throw new IndexOutOfRangeException();
				}
			}

		}

		public int Length => 8;

		public IEnumerator<MC_NCTOPLC_AXIS_REF_CAMCOUPLINGSTATE> GetEnumerator()
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
