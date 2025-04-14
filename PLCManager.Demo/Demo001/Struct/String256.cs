using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;
using PlcCore.Data;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:STRING(255)
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 256
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public unsafe struct String256 : IPLCStructArray<byte>
	{
		[FieldOffset(0)]
		public fixed byte Array[256];

		public byte this[int index]
		{
			get
			{
				if(index >= Length)
				{
					throw new IndexOutOfRangeException();
				}
				fixed(byte* ptr = Array)
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
				fixed (byte* ptr = Array)
				{
					ptr[index] = value;
				}
			}
		}

		private ref byte Get(int index)
		{
			fixed(byte* ptr = Array)
			{
				return ref ptr[index];
			}
		}
		public override string ToString()
		{
			fixed (byte* ptr = Array)
			{
				return Encoding.ASCII.GetString(ptr, 24);
			}
		}
		public ref byte Item_0 => ref Get(0);

		public ref byte Item_1 => ref Get(1);

		public ref byte Item_2 => ref Get(2);

		public ref byte Item_3 => ref Get(3);

		public ref byte Item_4 => ref Get(4);

		public ref byte Item_5 => ref Get(5);

		public ref byte Item_6 => ref Get(6);

		public ref byte Item_7 => ref Get(7);

		public ref byte Item_8 => ref Get(8);

		public ref byte Item_9 => ref Get(9);

		public ref byte Item_10 => ref Get(10);

		public ref byte Item_11 => ref Get(11);

		public ref byte Item_12 => ref Get(12);

		public ref byte Item_13 => ref Get(13);

		public ref byte Item_14 => ref Get(14);

		public ref byte Item_15 => ref Get(15);

		public ref byte Item_16 => ref Get(16);

		public ref byte Item_17 => ref Get(17);

		public ref byte Item_18 => ref Get(18);

		public ref byte Item_19 => ref Get(19);

		public ref byte Item_20 => ref Get(20);

		public ref byte Item_21 => ref Get(21);

		public ref byte Item_22 => ref Get(22);

		public ref byte Item_23 => ref Get(23);

		public ref byte Item_24 => ref Get(24);

		public ref byte Item_25 => ref Get(25);

		public ref byte Item_26 => ref Get(26);

		public ref byte Item_27 => ref Get(27);

		public ref byte Item_28 => ref Get(28);

		public ref byte Item_29 => ref Get(29);

		public ref byte Item_30 => ref Get(30);

		public ref byte Item_31 => ref Get(31);

		public ref byte Item_32 => ref Get(32);

		public ref byte Item_33 => ref Get(33);

		public ref byte Item_34 => ref Get(34);

		public ref byte Item_35 => ref Get(35);

		public ref byte Item_36 => ref Get(36);

		public ref byte Item_37 => ref Get(37);

		public ref byte Item_38 => ref Get(38);

		public ref byte Item_39 => ref Get(39);

		public ref byte Item_40 => ref Get(40);

		public ref byte Item_41 => ref Get(41);

		public ref byte Item_42 => ref Get(42);

		public ref byte Item_43 => ref Get(43);

		public ref byte Item_44 => ref Get(44);

		public ref byte Item_45 => ref Get(45);

		public ref byte Item_46 => ref Get(46);

		public ref byte Item_47 => ref Get(47);

		public ref byte Item_48 => ref Get(48);

		public ref byte Item_49 => ref Get(49);

		public ref byte Item_50 => ref Get(50);

		public ref byte Item_51 => ref Get(51);

		public ref byte Item_52 => ref Get(52);

		public ref byte Item_53 => ref Get(53);

		public ref byte Item_54 => ref Get(54);

		public ref byte Item_55 => ref Get(55);

		public ref byte Item_56 => ref Get(56);

		public ref byte Item_57 => ref Get(57);

		public ref byte Item_58 => ref Get(58);

		public ref byte Item_59 => ref Get(59);

		public ref byte Item_60 => ref Get(60);

		public ref byte Item_61 => ref Get(61);

		public ref byte Item_62 => ref Get(62);

		public ref byte Item_63 => ref Get(63);

		public ref byte Item_64 => ref Get(64);

		public ref byte Item_65 => ref Get(65);

		public ref byte Item_66 => ref Get(66);

		public ref byte Item_67 => ref Get(67);

		public ref byte Item_68 => ref Get(68);

		public ref byte Item_69 => ref Get(69);

		public ref byte Item_70 => ref Get(70);

		public ref byte Item_71 => ref Get(71);

		public ref byte Item_72 => ref Get(72);

		public ref byte Item_73 => ref Get(73);

		public ref byte Item_74 => ref Get(74);

		public ref byte Item_75 => ref Get(75);

		public ref byte Item_76 => ref Get(76);

		public ref byte Item_77 => ref Get(77);

		public ref byte Item_78 => ref Get(78);

		public ref byte Item_79 => ref Get(79);

		public ref byte Item_80 => ref Get(80);

		public ref byte Item_81 => ref Get(81);

		public ref byte Item_82 => ref Get(82);

		public ref byte Item_83 => ref Get(83);

		public ref byte Item_84 => ref Get(84);

		public ref byte Item_85 => ref Get(85);

		public ref byte Item_86 => ref Get(86);

		public ref byte Item_87 => ref Get(87);

		public ref byte Item_88 => ref Get(88);

		public ref byte Item_89 => ref Get(89);

		public ref byte Item_90 => ref Get(90);

		public ref byte Item_91 => ref Get(91);

		public ref byte Item_92 => ref Get(92);

		public ref byte Item_93 => ref Get(93);

		public ref byte Item_94 => ref Get(94);

		public ref byte Item_95 => ref Get(95);

		public ref byte Item_96 => ref Get(96);

		public ref byte Item_97 => ref Get(97);

		public ref byte Item_98 => ref Get(98);

		public ref byte Item_99 => ref Get(99);

		public ref byte Item_100 => ref Get(100);

		public ref byte Item_101 => ref Get(101);

		public ref byte Item_102 => ref Get(102);

		public ref byte Item_103 => ref Get(103);

		public ref byte Item_104 => ref Get(104);

		public ref byte Item_105 => ref Get(105);

		public ref byte Item_106 => ref Get(106);

		public ref byte Item_107 => ref Get(107);

		public ref byte Item_108 => ref Get(108);

		public ref byte Item_109 => ref Get(109);

		public ref byte Item_110 => ref Get(110);

		public ref byte Item_111 => ref Get(111);

		public ref byte Item_112 => ref Get(112);

		public ref byte Item_113 => ref Get(113);

		public ref byte Item_114 => ref Get(114);

		public ref byte Item_115 => ref Get(115);

		public ref byte Item_116 => ref Get(116);

		public ref byte Item_117 => ref Get(117);

		public ref byte Item_118 => ref Get(118);

		public ref byte Item_119 => ref Get(119);

		public ref byte Item_120 => ref Get(120);

		public ref byte Item_121 => ref Get(121);

		public ref byte Item_122 => ref Get(122);

		public ref byte Item_123 => ref Get(123);

		public ref byte Item_124 => ref Get(124);

		public ref byte Item_125 => ref Get(125);

		public ref byte Item_126 => ref Get(126);

		public ref byte Item_127 => ref Get(127);

		public ref byte Item_128 => ref Get(128);

		public ref byte Item_129 => ref Get(129);

		public ref byte Item_130 => ref Get(130);

		public ref byte Item_131 => ref Get(131);

		public ref byte Item_132 => ref Get(132);

		public ref byte Item_133 => ref Get(133);

		public ref byte Item_134 => ref Get(134);

		public ref byte Item_135 => ref Get(135);

		public ref byte Item_136 => ref Get(136);

		public ref byte Item_137 => ref Get(137);

		public ref byte Item_138 => ref Get(138);

		public ref byte Item_139 => ref Get(139);

		public ref byte Item_140 => ref Get(140);

		public ref byte Item_141 => ref Get(141);

		public ref byte Item_142 => ref Get(142);

		public ref byte Item_143 => ref Get(143);

		public ref byte Item_144 => ref Get(144);

		public ref byte Item_145 => ref Get(145);

		public ref byte Item_146 => ref Get(146);

		public ref byte Item_147 => ref Get(147);

		public ref byte Item_148 => ref Get(148);

		public ref byte Item_149 => ref Get(149);

		public ref byte Item_150 => ref Get(150);

		public ref byte Item_151 => ref Get(151);

		public ref byte Item_152 => ref Get(152);

		public ref byte Item_153 => ref Get(153);

		public ref byte Item_154 => ref Get(154);

		public ref byte Item_155 => ref Get(155);

		public ref byte Item_156 => ref Get(156);

		public ref byte Item_157 => ref Get(157);

		public ref byte Item_158 => ref Get(158);

		public ref byte Item_159 => ref Get(159);

		public ref byte Item_160 => ref Get(160);

		public ref byte Item_161 => ref Get(161);

		public ref byte Item_162 => ref Get(162);

		public ref byte Item_163 => ref Get(163);

		public ref byte Item_164 => ref Get(164);

		public ref byte Item_165 => ref Get(165);

		public ref byte Item_166 => ref Get(166);

		public ref byte Item_167 => ref Get(167);

		public ref byte Item_168 => ref Get(168);

		public ref byte Item_169 => ref Get(169);

		public ref byte Item_170 => ref Get(170);

		public ref byte Item_171 => ref Get(171);

		public ref byte Item_172 => ref Get(172);

		public ref byte Item_173 => ref Get(173);

		public ref byte Item_174 => ref Get(174);

		public ref byte Item_175 => ref Get(175);

		public ref byte Item_176 => ref Get(176);

		public ref byte Item_177 => ref Get(177);

		public ref byte Item_178 => ref Get(178);

		public ref byte Item_179 => ref Get(179);

		public ref byte Item_180 => ref Get(180);

		public ref byte Item_181 => ref Get(181);

		public ref byte Item_182 => ref Get(182);

		public ref byte Item_183 => ref Get(183);

		public ref byte Item_184 => ref Get(184);

		public ref byte Item_185 => ref Get(185);

		public ref byte Item_186 => ref Get(186);

		public ref byte Item_187 => ref Get(187);

		public ref byte Item_188 => ref Get(188);

		public ref byte Item_189 => ref Get(189);

		public ref byte Item_190 => ref Get(190);

		public ref byte Item_191 => ref Get(191);

		public ref byte Item_192 => ref Get(192);

		public ref byte Item_193 => ref Get(193);

		public ref byte Item_194 => ref Get(194);

		public ref byte Item_195 => ref Get(195);

		public ref byte Item_196 => ref Get(196);

		public ref byte Item_197 => ref Get(197);

		public ref byte Item_198 => ref Get(198);

		public ref byte Item_199 => ref Get(199);

		public ref byte Item_200 => ref Get(200);

		public ref byte Item_201 => ref Get(201);

		public ref byte Item_202 => ref Get(202);

		public ref byte Item_203 => ref Get(203);

		public ref byte Item_204 => ref Get(204);

		public ref byte Item_205 => ref Get(205);

		public ref byte Item_206 => ref Get(206);

		public ref byte Item_207 => ref Get(207);

		public ref byte Item_208 => ref Get(208);

		public ref byte Item_209 => ref Get(209);

		public ref byte Item_210 => ref Get(210);

		public ref byte Item_211 => ref Get(211);

		public ref byte Item_212 => ref Get(212);

		public ref byte Item_213 => ref Get(213);

		public ref byte Item_214 => ref Get(214);

		public ref byte Item_215 => ref Get(215);

		public ref byte Item_216 => ref Get(216);

		public ref byte Item_217 => ref Get(217);

		public ref byte Item_218 => ref Get(218);

		public ref byte Item_219 => ref Get(219);

		public ref byte Item_220 => ref Get(220);

		public ref byte Item_221 => ref Get(221);

		public ref byte Item_222 => ref Get(222);

		public ref byte Item_223 => ref Get(223);

		public ref byte Item_224 => ref Get(224);

		public ref byte Item_225 => ref Get(225);

		public ref byte Item_226 => ref Get(226);

		public ref byte Item_227 => ref Get(227);

		public ref byte Item_228 => ref Get(228);

		public ref byte Item_229 => ref Get(229);

		public ref byte Item_230 => ref Get(230);

		public ref byte Item_231 => ref Get(231);

		public ref byte Item_232 => ref Get(232);

		public ref byte Item_233 => ref Get(233);

		public ref byte Item_234 => ref Get(234);

		public ref byte Item_235 => ref Get(235);

		public ref byte Item_236 => ref Get(236);

		public ref byte Item_237 => ref Get(237);

		public ref byte Item_238 => ref Get(238);

		public ref byte Item_239 => ref Get(239);

		public ref byte Item_240 => ref Get(240);

		public ref byte Item_241 => ref Get(241);

		public ref byte Item_242 => ref Get(242);

		public ref byte Item_243 => ref Get(243);

		public ref byte Item_244 => ref Get(244);

		public ref byte Item_245 => ref Get(245);

		public ref byte Item_246 => ref Get(246);

		public ref byte Item_247 => ref Get(247);

		public ref byte Item_248 => ref Get(248);

		public ref byte Item_249 => ref Get(249);

		public ref byte Item_250 => ref Get(250);

		public ref byte Item_251 => ref Get(251);

		public ref byte Item_252 => ref Get(252);

		public ref byte Item_253 => ref Get(253);

		public ref byte Item_254 => ref Get(254);

		public ref byte Item_255 => ref Get(255);

		public int Length => 256;

		public IEnumerator<byte> GetEnumerator()
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
