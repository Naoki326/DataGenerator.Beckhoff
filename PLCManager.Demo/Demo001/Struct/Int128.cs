using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;
using PlcCore.Data;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:ARRAY [0..127] OF DWORD
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 512
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public unsafe struct Int128 : IPLCStructArray<int>
	{
		[FieldOffset(0)]
		public fixed int Array[128];

		public int this[int index]
		{
			get
			{
				if(index >= Length)
				{
					throw new IndexOutOfRangeException();
				}
				fixed(int* ptr = Array)
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
				fixed (int* ptr = Array)
				{
					ptr[index] = value;
				}
			}
		}

		private ref int Get(int index)
		{
			fixed(int* ptr = Array)
			{
				return ref ptr[index];
			}
		}
		public ref int Item_0 => ref Get(0);

		public ref int Item_1 => ref Get(1);

		public ref int Item_2 => ref Get(2);

		public ref int Item_3 => ref Get(3);

		public ref int Item_4 => ref Get(4);

		public ref int Item_5 => ref Get(5);

		public ref int Item_6 => ref Get(6);

		public ref int Item_7 => ref Get(7);

		public ref int Item_8 => ref Get(8);

		public ref int Item_9 => ref Get(9);

		public ref int Item_10 => ref Get(10);

		public ref int Item_11 => ref Get(11);

		public ref int Item_12 => ref Get(12);

		public ref int Item_13 => ref Get(13);

		public ref int Item_14 => ref Get(14);

		public ref int Item_15 => ref Get(15);

		public ref int Item_16 => ref Get(16);

		public ref int Item_17 => ref Get(17);

		public ref int Item_18 => ref Get(18);

		public ref int Item_19 => ref Get(19);

		public ref int Item_20 => ref Get(20);

		public ref int Item_21 => ref Get(21);

		public ref int Item_22 => ref Get(22);

		public ref int Item_23 => ref Get(23);

		public ref int Item_24 => ref Get(24);

		public ref int Item_25 => ref Get(25);

		public ref int Item_26 => ref Get(26);

		public ref int Item_27 => ref Get(27);

		public ref int Item_28 => ref Get(28);

		public ref int Item_29 => ref Get(29);

		public ref int Item_30 => ref Get(30);

		public ref int Item_31 => ref Get(31);

		public ref int Item_32 => ref Get(32);

		public ref int Item_33 => ref Get(33);

		public ref int Item_34 => ref Get(34);

		public ref int Item_35 => ref Get(35);

		public ref int Item_36 => ref Get(36);

		public ref int Item_37 => ref Get(37);

		public ref int Item_38 => ref Get(38);

		public ref int Item_39 => ref Get(39);

		public ref int Item_40 => ref Get(40);

		public ref int Item_41 => ref Get(41);

		public ref int Item_42 => ref Get(42);

		public ref int Item_43 => ref Get(43);

		public ref int Item_44 => ref Get(44);

		public ref int Item_45 => ref Get(45);

		public ref int Item_46 => ref Get(46);

		public ref int Item_47 => ref Get(47);

		public ref int Item_48 => ref Get(48);

		public ref int Item_49 => ref Get(49);

		public ref int Item_50 => ref Get(50);

		public ref int Item_51 => ref Get(51);

		public ref int Item_52 => ref Get(52);

		public ref int Item_53 => ref Get(53);

		public ref int Item_54 => ref Get(54);

		public ref int Item_55 => ref Get(55);

		public ref int Item_56 => ref Get(56);

		public ref int Item_57 => ref Get(57);

		public ref int Item_58 => ref Get(58);

		public ref int Item_59 => ref Get(59);

		public ref int Item_60 => ref Get(60);

		public ref int Item_61 => ref Get(61);

		public ref int Item_62 => ref Get(62);

		public ref int Item_63 => ref Get(63);

		public ref int Item_64 => ref Get(64);

		public ref int Item_65 => ref Get(65);

		public ref int Item_66 => ref Get(66);

		public ref int Item_67 => ref Get(67);

		public ref int Item_68 => ref Get(68);

		public ref int Item_69 => ref Get(69);

		public ref int Item_70 => ref Get(70);

		public ref int Item_71 => ref Get(71);

		public ref int Item_72 => ref Get(72);

		public ref int Item_73 => ref Get(73);

		public ref int Item_74 => ref Get(74);

		public ref int Item_75 => ref Get(75);

		public ref int Item_76 => ref Get(76);

		public ref int Item_77 => ref Get(77);

		public ref int Item_78 => ref Get(78);

		public ref int Item_79 => ref Get(79);

		public ref int Item_80 => ref Get(80);

		public ref int Item_81 => ref Get(81);

		public ref int Item_82 => ref Get(82);

		public ref int Item_83 => ref Get(83);

		public ref int Item_84 => ref Get(84);

		public ref int Item_85 => ref Get(85);

		public ref int Item_86 => ref Get(86);

		public ref int Item_87 => ref Get(87);

		public ref int Item_88 => ref Get(88);

		public ref int Item_89 => ref Get(89);

		public ref int Item_90 => ref Get(90);

		public ref int Item_91 => ref Get(91);

		public ref int Item_92 => ref Get(92);

		public ref int Item_93 => ref Get(93);

		public ref int Item_94 => ref Get(94);

		public ref int Item_95 => ref Get(95);

		public ref int Item_96 => ref Get(96);

		public ref int Item_97 => ref Get(97);

		public ref int Item_98 => ref Get(98);

		public ref int Item_99 => ref Get(99);

		public ref int Item_100 => ref Get(100);

		public ref int Item_101 => ref Get(101);

		public ref int Item_102 => ref Get(102);

		public ref int Item_103 => ref Get(103);

		public ref int Item_104 => ref Get(104);

		public ref int Item_105 => ref Get(105);

		public ref int Item_106 => ref Get(106);

		public ref int Item_107 => ref Get(107);

		public ref int Item_108 => ref Get(108);

		public ref int Item_109 => ref Get(109);

		public ref int Item_110 => ref Get(110);

		public ref int Item_111 => ref Get(111);

		public ref int Item_112 => ref Get(112);

		public ref int Item_113 => ref Get(113);

		public ref int Item_114 => ref Get(114);

		public ref int Item_115 => ref Get(115);

		public ref int Item_116 => ref Get(116);

		public ref int Item_117 => ref Get(117);

		public ref int Item_118 => ref Get(118);

		public ref int Item_119 => ref Get(119);

		public ref int Item_120 => ref Get(120);

		public ref int Item_121 => ref Get(121);

		public ref int Item_122 => ref Get(122);

		public ref int Item_123 => ref Get(123);

		public ref int Item_124 => ref Get(124);

		public ref int Item_125 => ref Get(125);

		public ref int Item_126 => ref Get(126);

		public ref int Item_127 => ref Get(127);

		public int Length => 128;

		public IEnumerator<int> GetEnumerator()
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
