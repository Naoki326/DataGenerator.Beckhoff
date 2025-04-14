using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;
using PlcCore.Data;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:ARRAY [1..100] OF FB_IO_Sensor
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 19200
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct FB_IO_Sensor100 : IPLCStructArray<FB_IO_Sensor>
	{
		[FieldOffset(0)]
		public FB_IO_Sensor Item_0;

		[FieldOffset(192)]
		public FB_IO_Sensor Item_1;

		[FieldOffset(384)]
		public FB_IO_Sensor Item_2;

		[FieldOffset(576)]
		public FB_IO_Sensor Item_3;

		[FieldOffset(768)]
		public FB_IO_Sensor Item_4;

		[FieldOffset(960)]
		public FB_IO_Sensor Item_5;

		[FieldOffset(1152)]
		public FB_IO_Sensor Item_6;

		[FieldOffset(1344)]
		public FB_IO_Sensor Item_7;

		[FieldOffset(1536)]
		public FB_IO_Sensor Item_8;

		[FieldOffset(1728)]
		public FB_IO_Sensor Item_9;

		[FieldOffset(1920)]
		public FB_IO_Sensor Item_10;

		[FieldOffset(2112)]
		public FB_IO_Sensor Item_11;

		[FieldOffset(2304)]
		public FB_IO_Sensor Item_12;

		[FieldOffset(2496)]
		public FB_IO_Sensor Item_13;

		[FieldOffset(2688)]
		public FB_IO_Sensor Item_14;

		[FieldOffset(2880)]
		public FB_IO_Sensor Item_15;

		[FieldOffset(3072)]
		public FB_IO_Sensor Item_16;

		[FieldOffset(3264)]
		public FB_IO_Sensor Item_17;

		[FieldOffset(3456)]
		public FB_IO_Sensor Item_18;

		[FieldOffset(3648)]
		public FB_IO_Sensor Item_19;

		[FieldOffset(3840)]
		public FB_IO_Sensor Item_20;

		[FieldOffset(4032)]
		public FB_IO_Sensor Item_21;

		[FieldOffset(4224)]
		public FB_IO_Sensor Item_22;

		[FieldOffset(4416)]
		public FB_IO_Sensor Item_23;

		[FieldOffset(4608)]
		public FB_IO_Sensor Item_24;

		[FieldOffset(4800)]
		public FB_IO_Sensor Item_25;

		[FieldOffset(4992)]
		public FB_IO_Sensor Item_26;

		[FieldOffset(5184)]
		public FB_IO_Sensor Item_27;

		[FieldOffset(5376)]
		public FB_IO_Sensor Item_28;

		[FieldOffset(5568)]
		public FB_IO_Sensor Item_29;

		[FieldOffset(5760)]
		public FB_IO_Sensor Item_30;

		[FieldOffset(5952)]
		public FB_IO_Sensor Item_31;

		[FieldOffset(6144)]
		public FB_IO_Sensor Item_32;

		[FieldOffset(6336)]
		public FB_IO_Sensor Item_33;

		[FieldOffset(6528)]
		public FB_IO_Sensor Item_34;

		[FieldOffset(6720)]
		public FB_IO_Sensor Item_35;

		[FieldOffset(6912)]
		public FB_IO_Sensor Item_36;

		[FieldOffset(7104)]
		public FB_IO_Sensor Item_37;

		[FieldOffset(7296)]
		public FB_IO_Sensor Item_38;

		[FieldOffset(7488)]
		public FB_IO_Sensor Item_39;

		[FieldOffset(7680)]
		public FB_IO_Sensor Item_40;

		[FieldOffset(7872)]
		public FB_IO_Sensor Item_41;

		[FieldOffset(8064)]
		public FB_IO_Sensor Item_42;

		[FieldOffset(8256)]
		public FB_IO_Sensor Item_43;

		[FieldOffset(8448)]
		public FB_IO_Sensor Item_44;

		[FieldOffset(8640)]
		public FB_IO_Sensor Item_45;

		[FieldOffset(8832)]
		public FB_IO_Sensor Item_46;

		[FieldOffset(9024)]
		public FB_IO_Sensor Item_47;

		[FieldOffset(9216)]
		public FB_IO_Sensor Item_48;

		[FieldOffset(9408)]
		public FB_IO_Sensor Item_49;

		[FieldOffset(9600)]
		public FB_IO_Sensor Item_50;

		[FieldOffset(9792)]
		public FB_IO_Sensor Item_51;

		[FieldOffset(9984)]
		public FB_IO_Sensor Item_52;

		[FieldOffset(10176)]
		public FB_IO_Sensor Item_53;

		[FieldOffset(10368)]
		public FB_IO_Sensor Item_54;

		[FieldOffset(10560)]
		public FB_IO_Sensor Item_55;

		[FieldOffset(10752)]
		public FB_IO_Sensor Item_56;

		[FieldOffset(10944)]
		public FB_IO_Sensor Item_57;

		[FieldOffset(11136)]
		public FB_IO_Sensor Item_58;

		[FieldOffset(11328)]
		public FB_IO_Sensor Item_59;

		[FieldOffset(11520)]
		public FB_IO_Sensor Item_60;

		[FieldOffset(11712)]
		public FB_IO_Sensor Item_61;

		[FieldOffset(11904)]
		public FB_IO_Sensor Item_62;

		[FieldOffset(12096)]
		public FB_IO_Sensor Item_63;

		[FieldOffset(12288)]
		public FB_IO_Sensor Item_64;

		[FieldOffset(12480)]
		public FB_IO_Sensor Item_65;

		[FieldOffset(12672)]
		public FB_IO_Sensor Item_66;

		[FieldOffset(12864)]
		public FB_IO_Sensor Item_67;

		[FieldOffset(13056)]
		public FB_IO_Sensor Item_68;

		[FieldOffset(13248)]
		public FB_IO_Sensor Item_69;

		[FieldOffset(13440)]
		public FB_IO_Sensor Item_70;

		[FieldOffset(13632)]
		public FB_IO_Sensor Item_71;

		[FieldOffset(13824)]
		public FB_IO_Sensor Item_72;

		[FieldOffset(14016)]
		public FB_IO_Sensor Item_73;

		[FieldOffset(14208)]
		public FB_IO_Sensor Item_74;

		[FieldOffset(14400)]
		public FB_IO_Sensor Item_75;

		[FieldOffset(14592)]
		public FB_IO_Sensor Item_76;

		[FieldOffset(14784)]
		public FB_IO_Sensor Item_77;

		[FieldOffset(14976)]
		public FB_IO_Sensor Item_78;

		[FieldOffset(15168)]
		public FB_IO_Sensor Item_79;

		[FieldOffset(15360)]
		public FB_IO_Sensor Item_80;

		[FieldOffset(15552)]
		public FB_IO_Sensor Item_81;

		[FieldOffset(15744)]
		public FB_IO_Sensor Item_82;

		[FieldOffset(15936)]
		public FB_IO_Sensor Item_83;

		[FieldOffset(16128)]
		public FB_IO_Sensor Item_84;

		[FieldOffset(16320)]
		public FB_IO_Sensor Item_85;

		[FieldOffset(16512)]
		public FB_IO_Sensor Item_86;

		[FieldOffset(16704)]
		public FB_IO_Sensor Item_87;

		[FieldOffset(16896)]
		public FB_IO_Sensor Item_88;

		[FieldOffset(17088)]
		public FB_IO_Sensor Item_89;

		[FieldOffset(17280)]
		public FB_IO_Sensor Item_90;

		[FieldOffset(17472)]
		public FB_IO_Sensor Item_91;

		[FieldOffset(17664)]
		public FB_IO_Sensor Item_92;

		[FieldOffset(17856)]
		public FB_IO_Sensor Item_93;

		[FieldOffset(18048)]
		public FB_IO_Sensor Item_94;

		[FieldOffset(18240)]
		public FB_IO_Sensor Item_95;

		[FieldOffset(18432)]
		public FB_IO_Sensor Item_96;

		[FieldOffset(18624)]
		public FB_IO_Sensor Item_97;

		[FieldOffset(18816)]
		public FB_IO_Sensor Item_98;

		[FieldOffset(19008)]
		public FB_IO_Sensor Item_99;

		public FB_IO_Sensor this[int index]
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
					case 50: return Item_50;
					case 51: return Item_51;
					case 52: return Item_52;
					case 53: return Item_53;
					case 54: return Item_54;
					case 55: return Item_55;
					case 56: return Item_56;
					case 57: return Item_57;
					case 58: return Item_58;
					case 59: return Item_59;
					case 60: return Item_60;
					case 61: return Item_61;
					case 62: return Item_62;
					case 63: return Item_63;
					case 64: return Item_64;
					case 65: return Item_65;
					case 66: return Item_66;
					case 67: return Item_67;
					case 68: return Item_68;
					case 69: return Item_69;
					case 70: return Item_70;
					case 71: return Item_71;
					case 72: return Item_72;
					case 73: return Item_73;
					case 74: return Item_74;
					case 75: return Item_75;
					case 76: return Item_76;
					case 77: return Item_77;
					case 78: return Item_78;
					case 79: return Item_79;
					case 80: return Item_80;
					case 81: return Item_81;
					case 82: return Item_82;
					case 83: return Item_83;
					case 84: return Item_84;
					case 85: return Item_85;
					case 86: return Item_86;
					case 87: return Item_87;
					case 88: return Item_88;
					case 89: return Item_89;
					case 90: return Item_90;
					case 91: return Item_91;
					case 92: return Item_92;
					case 93: return Item_93;
					case 94: return Item_94;
					case 95: return Item_95;
					case 96: return Item_96;
					case 97: return Item_97;
					case 98: return Item_98;
					case 99: return Item_99;
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
					case 50: Item_50 = value; break;
					case 51: Item_51 = value; break;
					case 52: Item_52 = value; break;
					case 53: Item_53 = value; break;
					case 54: Item_54 = value; break;
					case 55: Item_55 = value; break;
					case 56: Item_56 = value; break;
					case 57: Item_57 = value; break;
					case 58: Item_58 = value; break;
					case 59: Item_59 = value; break;
					case 60: Item_60 = value; break;
					case 61: Item_61 = value; break;
					case 62: Item_62 = value; break;
					case 63: Item_63 = value; break;
					case 64: Item_64 = value; break;
					case 65: Item_65 = value; break;
					case 66: Item_66 = value; break;
					case 67: Item_67 = value; break;
					case 68: Item_68 = value; break;
					case 69: Item_69 = value; break;
					case 70: Item_70 = value; break;
					case 71: Item_71 = value; break;
					case 72: Item_72 = value; break;
					case 73: Item_73 = value; break;
					case 74: Item_74 = value; break;
					case 75: Item_75 = value; break;
					case 76: Item_76 = value; break;
					case 77: Item_77 = value; break;
					case 78: Item_78 = value; break;
					case 79: Item_79 = value; break;
					case 80: Item_80 = value; break;
					case 81: Item_81 = value; break;
					case 82: Item_82 = value; break;
					case 83: Item_83 = value; break;
					case 84: Item_84 = value; break;
					case 85: Item_85 = value; break;
					case 86: Item_86 = value; break;
					case 87: Item_87 = value; break;
					case 88: Item_88 = value; break;
					case 89: Item_89 = value; break;
					case 90: Item_90 = value; break;
					case 91: Item_91 = value; break;
					case 92: Item_92 = value; break;
					case 93: Item_93 = value; break;
					case 94: Item_94 = value; break;
					case 95: Item_95 = value; break;
					case 96: Item_96 = value; break;
					case 97: Item_97 = value; break;
					case 98: Item_98 = value; break;
					case 99: Item_99 = value; break;
					default: throw new IndexOutOfRangeException();
				}
			}

		}

		public int Length => 100;

		public IEnumerator<FB_IO_Sensor> GetEnumerator()
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
