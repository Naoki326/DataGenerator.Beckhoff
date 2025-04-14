using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;
using PlcCore.Data;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:ARRAY [1..20] OF Tc2_Standard.R_TRIG
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 320
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_Standard_R_TRIG20 : IPLCStructArray<Tc2_Standard_R_TRIG>
	{
		[FieldOffset(0)]
		public Tc2_Standard_R_TRIG Item_0;

		[FieldOffset(16)]
		public Tc2_Standard_R_TRIG Item_1;

		[FieldOffset(32)]
		public Tc2_Standard_R_TRIG Item_2;

		[FieldOffset(48)]
		public Tc2_Standard_R_TRIG Item_3;

		[FieldOffset(64)]
		public Tc2_Standard_R_TRIG Item_4;

		[FieldOffset(80)]
		public Tc2_Standard_R_TRIG Item_5;

		[FieldOffset(96)]
		public Tc2_Standard_R_TRIG Item_6;

		[FieldOffset(112)]
		public Tc2_Standard_R_TRIG Item_7;

		[FieldOffset(128)]
		public Tc2_Standard_R_TRIG Item_8;

		[FieldOffset(144)]
		public Tc2_Standard_R_TRIG Item_9;

		[FieldOffset(160)]
		public Tc2_Standard_R_TRIG Item_10;

		[FieldOffset(176)]
		public Tc2_Standard_R_TRIG Item_11;

		[FieldOffset(192)]
		public Tc2_Standard_R_TRIG Item_12;

		[FieldOffset(208)]
		public Tc2_Standard_R_TRIG Item_13;

		[FieldOffset(224)]
		public Tc2_Standard_R_TRIG Item_14;

		[FieldOffset(240)]
		public Tc2_Standard_R_TRIG Item_15;

		[FieldOffset(256)]
		public Tc2_Standard_R_TRIG Item_16;

		[FieldOffset(272)]
		public Tc2_Standard_R_TRIG Item_17;

		[FieldOffset(288)]
		public Tc2_Standard_R_TRIG Item_18;

		[FieldOffset(304)]
		public Tc2_Standard_R_TRIG Item_19;

		public Tc2_Standard_R_TRIG this[int index]
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
					case 8: return Item_8;
					case 9: return Item_9;
					case 10: return Item_10;
					case 11: return Item_11;
					case 12: return Item_12;
					case 13: return Item_13;
					case 14: return Item_14;
					case 15: return Item_15;
					case 16: return Item_16;
					case 17: return Item_17;
					case 18: return Item_18;
					case 19: return Item_19;
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
					case 8: Item_8 = value; break;
					case 9: Item_9 = value; break;
					case 10: Item_10 = value; break;
					case 11: Item_11 = value; break;
					case 12: Item_12 = value; break;
					case 13: Item_13 = value; break;
					case 14: Item_14 = value; break;
					case 15: Item_15 = value; break;
					case 16: Item_16 = value; break;
					case 17: Item_17 = value; break;
					case 18: Item_18 = value; break;
					case 19: Item_19 = value; break;
					default: throw new IndexOutOfRangeException();
				}
			}

		}

		public int Length => 20;

		public IEnumerator<Tc2_Standard_R_TRIG> GetEnumerator()
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
