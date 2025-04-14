using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;
using PlcCore.Data;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:ARRAY [1..50] OF ST_Motion
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 778000
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct ST_Motion50 : IPLCStructArray<ST_Motion>
	{
		[FieldOffset(0)]
		public ST_Motion Item_0;

		[FieldOffset(15560)]
		public ST_Motion Item_1;

		[FieldOffset(31120)]
		public ST_Motion Item_2;

		[FieldOffset(46680)]
		public ST_Motion Item_3;

		[FieldOffset(62240)]
		public ST_Motion Item_4;

		[FieldOffset(77800)]
		public ST_Motion Item_5;

		[FieldOffset(93360)]
		public ST_Motion Item_6;

		[FieldOffset(108920)]
		public ST_Motion Item_7;

		[FieldOffset(124480)]
		public ST_Motion Item_8;

		[FieldOffset(140040)]
		public ST_Motion Item_9;

		[FieldOffset(155600)]
		public ST_Motion Item_10;

		[FieldOffset(171160)]
		public ST_Motion Item_11;

		[FieldOffset(186720)]
		public ST_Motion Item_12;

		[FieldOffset(202280)]
		public ST_Motion Item_13;

		[FieldOffset(217840)]
		public ST_Motion Item_14;

		[FieldOffset(233400)]
		public ST_Motion Item_15;

		[FieldOffset(248960)]
		public ST_Motion Item_16;

		[FieldOffset(264520)]
		public ST_Motion Item_17;

		[FieldOffset(280080)]
		public ST_Motion Item_18;

		[FieldOffset(295640)]
		public ST_Motion Item_19;

		[FieldOffset(311200)]
		public ST_Motion Item_20;

		[FieldOffset(326760)]
		public ST_Motion Item_21;

		[FieldOffset(342320)]
		public ST_Motion Item_22;

		[FieldOffset(357880)]
		public ST_Motion Item_23;

		[FieldOffset(373440)]
		public ST_Motion Item_24;

		[FieldOffset(389000)]
		public ST_Motion Item_25;

		[FieldOffset(404560)]
		public ST_Motion Item_26;

		[FieldOffset(420120)]
		public ST_Motion Item_27;

		[FieldOffset(435680)]
		public ST_Motion Item_28;

		[FieldOffset(451240)]
		public ST_Motion Item_29;

		[FieldOffset(466800)]
		public ST_Motion Item_30;

		[FieldOffset(482360)]
		public ST_Motion Item_31;

		[FieldOffset(497920)]
		public ST_Motion Item_32;

		[FieldOffset(513480)]
		public ST_Motion Item_33;

		[FieldOffset(529040)]
		public ST_Motion Item_34;

		[FieldOffset(544600)]
		public ST_Motion Item_35;

		[FieldOffset(560160)]
		public ST_Motion Item_36;

		[FieldOffset(575720)]
		public ST_Motion Item_37;

		[FieldOffset(591280)]
		public ST_Motion Item_38;

		[FieldOffset(606840)]
		public ST_Motion Item_39;

		[FieldOffset(622400)]
		public ST_Motion Item_40;

		[FieldOffset(637960)]
		public ST_Motion Item_41;

		[FieldOffset(653520)]
		public ST_Motion Item_42;

		[FieldOffset(669080)]
		public ST_Motion Item_43;

		[FieldOffset(684640)]
		public ST_Motion Item_44;

		[FieldOffset(700200)]
		public ST_Motion Item_45;

		[FieldOffset(715760)]
		public ST_Motion Item_46;

		[FieldOffset(731320)]
		public ST_Motion Item_47;

		[FieldOffset(746880)]
		public ST_Motion Item_48;

		[FieldOffset(762440)]
		public ST_Motion Item_49;

		public ST_Motion this[int index]
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
					case 20: return Item_20;
					case 21: return Item_21;
					case 22: return Item_22;
					case 23: return Item_23;
					case 24: return Item_24;
					case 25: return Item_25;
					case 26: return Item_26;
					case 27: return Item_27;
					case 28: return Item_28;
					case 29: return Item_29;
					case 30: return Item_30;
					case 31: return Item_31;
					case 32: return Item_32;
					case 33: return Item_33;
					case 34: return Item_34;
					case 35: return Item_35;
					case 36: return Item_36;
					case 37: return Item_37;
					case 38: return Item_38;
					case 39: return Item_39;
					case 40: return Item_40;
					case 41: return Item_41;
					case 42: return Item_42;
					case 43: return Item_43;
					case 44: return Item_44;
					case 45: return Item_45;
					case 46: return Item_46;
					case 47: return Item_47;
					case 48: return Item_48;
					case 49: return Item_49;
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
					case 20: Item_20 = value; break;
					case 21: Item_21 = value; break;
					case 22: Item_22 = value; break;
					case 23: Item_23 = value; break;
					case 24: Item_24 = value; break;
					case 25: Item_25 = value; break;
					case 26: Item_26 = value; break;
					case 27: Item_27 = value; break;
					case 28: Item_28 = value; break;
					case 29: Item_29 = value; break;
					case 30: Item_30 = value; break;
					case 31: Item_31 = value; break;
					case 32: Item_32 = value; break;
					case 33: Item_33 = value; break;
					case 34: Item_34 = value; break;
					case 35: Item_35 = value; break;
					case 36: Item_36 = value; break;
					case 37: Item_37 = value; break;
					case 38: Item_38 = value; break;
					case 39: Item_39 = value; break;
					case 40: Item_40 = value; break;
					case 41: Item_41 = value; break;
					case 42: Item_42 = value; break;
					case 43: Item_43 = value; break;
					case 44: Item_44 = value; break;
					case 45: Item_45 = value; break;
					case 46: Item_46 = value; break;
					case 47: Item_47 = value; break;
					case 48: Item_48 = value; break;
					case 49: Item_49 = value; break;
					default: throw new IndexOutOfRangeException();
				}
			}

		}

		public int Length => 50;

		public IEnumerator<ST_Motion> GetEnumerator()
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
