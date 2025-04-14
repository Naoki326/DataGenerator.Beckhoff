using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;
using PlcCore.Data;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:ARRAY [1..100] OF BOOL
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 100
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public unsafe struct Bool100 : IPLCStructArray<bool>
	{
		[FieldOffset(0)]
		public fixed bool Array[100];

		public bool this[int index]
		{
			get
			{
				if(index >= Length)
				{
					throw new IndexOutOfRangeException();
				}
				fixed(bool* ptr = Array)
				{
					return ptr[index];
				}
			}
			set
			{
				if(index >= Length)
				{
					throw new IndexOutOfRangeException();
				}
				fixed (bool* ptr = Array)
				{
					ptr[index] = value;
				}
			}
		}

		private ref bool Get(int index)
		{
			fixed(bool* ptr = Array)
			{
				return ref ptr[index];
			}
		}
		public ref bool Item_0 => ref Get(0);

		public ref bool Item_1 => ref Get(1);

		public ref bool Item_2 => ref Get(2);

		public ref bool Item_3 => ref Get(3);

		public ref bool Item_4 => ref Get(4);

		public ref bool Item_5 => ref Get(5);

		public ref bool Item_6 => ref Get(6);

		public ref bool Item_7 => ref Get(7);

		public ref bool Item_8 => ref Get(8);

		public ref bool Item_9 => ref Get(9);

		public ref bool Item_10 => ref Get(10);

		public ref bool Item_11 => ref Get(11);

		public ref bool Item_12 => ref Get(12);

		public ref bool Item_13 => ref Get(13);

		public ref bool Item_14 => ref Get(14);

		public ref bool Item_15 => ref Get(15);

		public ref bool Item_16 => ref Get(16);

		public ref bool Item_17 => ref Get(17);

		public ref bool Item_18 => ref Get(18);

		public ref bool Item_19 => ref Get(19);

		public ref bool Item_20 => ref Get(20);

		public ref bool Item_21 => ref Get(21);

		public ref bool Item_22 => ref Get(22);

		public ref bool Item_23 => ref Get(23);

		public ref bool Item_24 => ref Get(24);

		public ref bool Item_25 => ref Get(25);

		public ref bool Item_26 => ref Get(26);

		public ref bool Item_27 => ref Get(27);

		public ref bool Item_28 => ref Get(28);

		public ref bool Item_29 => ref Get(29);

		public ref bool Item_30 => ref Get(30);

		public ref bool Item_31 => ref Get(31);

		public ref bool Item_32 => ref Get(32);

		public ref bool Item_33 => ref Get(33);

		public ref bool Item_34 => ref Get(34);

		public ref bool Item_35 => ref Get(35);

		public ref bool Item_36 => ref Get(36);

		public ref bool Item_37 => ref Get(37);

		public ref bool Item_38 => ref Get(38);

		public ref bool Item_39 => ref Get(39);

		public ref bool Item_40 => ref Get(40);

		public ref bool Item_41 => ref Get(41);

		public ref bool Item_42 => ref Get(42);

		public ref bool Item_43 => ref Get(43);

		public ref bool Item_44 => ref Get(44);

		public ref bool Item_45 => ref Get(45);

		public ref bool Item_46 => ref Get(46);

		public ref bool Item_47 => ref Get(47);

		public ref bool Item_48 => ref Get(48);

		public ref bool Item_49 => ref Get(49);

		public ref bool Item_50 => ref Get(50);

		public ref bool Item_51 => ref Get(51);

		public ref bool Item_52 => ref Get(52);

		public ref bool Item_53 => ref Get(53);

		public ref bool Item_54 => ref Get(54);

		public ref bool Item_55 => ref Get(55);

		public ref bool Item_56 => ref Get(56);

		public ref bool Item_57 => ref Get(57);

		public ref bool Item_58 => ref Get(58);

		public ref bool Item_59 => ref Get(59);

		public ref bool Item_60 => ref Get(60);

		public ref bool Item_61 => ref Get(61);

		public ref bool Item_62 => ref Get(62);

		public ref bool Item_63 => ref Get(63);

		public ref bool Item_64 => ref Get(64);

		public ref bool Item_65 => ref Get(65);

		public ref bool Item_66 => ref Get(66);

		public ref bool Item_67 => ref Get(67);

		public ref bool Item_68 => ref Get(68);

		public ref bool Item_69 => ref Get(69);

		public ref bool Item_70 => ref Get(70);

		public ref bool Item_71 => ref Get(71);

		public ref bool Item_72 => ref Get(72);

		public ref bool Item_73 => ref Get(73);

		public ref bool Item_74 => ref Get(74);

		public ref bool Item_75 => ref Get(75);

		public ref bool Item_76 => ref Get(76);

		public ref bool Item_77 => ref Get(77);

		public ref bool Item_78 => ref Get(78);

		public ref bool Item_79 => ref Get(79);

		public ref bool Item_80 => ref Get(80);

		public ref bool Item_81 => ref Get(81);

		public ref bool Item_82 => ref Get(82);

		public ref bool Item_83 => ref Get(83);

		public ref bool Item_84 => ref Get(84);

		public ref bool Item_85 => ref Get(85);

		public ref bool Item_86 => ref Get(86);

		public ref bool Item_87 => ref Get(87);

		public ref bool Item_88 => ref Get(88);

		public ref bool Item_89 => ref Get(89);

		public ref bool Item_90 => ref Get(90);

		public ref bool Item_91 => ref Get(91);

		public ref bool Item_92 => ref Get(92);

		public ref bool Item_93 => ref Get(93);

		public ref bool Item_94 => ref Get(94);

		public ref bool Item_95 => ref Get(95);

		public ref bool Item_96 => ref Get(96);

		public ref bool Item_97 => ref Get(97);

		public ref bool Item_98 => ref Get(98);

		public ref bool Item_99 => ref Get(99);

		public int Length => 100;

		public IEnumerator<bool> GetEnumerator()
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
