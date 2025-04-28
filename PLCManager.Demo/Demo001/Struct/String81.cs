using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using PLCManager.Demo.Enum;
using PlcCore.Data;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:STRING(80)
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 81
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public unsafe struct String81 : IPLCStructArray<byte>
	{
		[FieldOffset(0)]
		public fixed byte Array[81];

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
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_0 => ref Get(0);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_1 => ref Get(1);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_2 => ref Get(2);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_3 => ref Get(3);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_4 => ref Get(4);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_5 => ref Get(5);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_6 => ref Get(6);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_7 => ref Get(7);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_8 => ref Get(8);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_9 => ref Get(9);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_10 => ref Get(10);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_11 => ref Get(11);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_12 => ref Get(12);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_13 => ref Get(13);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_14 => ref Get(14);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_15 => ref Get(15);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_16 => ref Get(16);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_17 => ref Get(17);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_18 => ref Get(18);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_19 => ref Get(19);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_20 => ref Get(20);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_21 => ref Get(21);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_22 => ref Get(22);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_23 => ref Get(23);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_24 => ref Get(24);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_25 => ref Get(25);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_26 => ref Get(26);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_27 => ref Get(27);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_28 => ref Get(28);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_29 => ref Get(29);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_30 => ref Get(30);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_31 => ref Get(31);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_32 => ref Get(32);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_33 => ref Get(33);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_34 => ref Get(34);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_35 => ref Get(35);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_36 => ref Get(36);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_37 => ref Get(37);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_38 => ref Get(38);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_39 => ref Get(39);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_40 => ref Get(40);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_41 => ref Get(41);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_42 => ref Get(42);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_43 => ref Get(43);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_44 => ref Get(44);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_45 => ref Get(45);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_46 => ref Get(46);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_47 => ref Get(47);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_48 => ref Get(48);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_49 => ref Get(49);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_50 => ref Get(50);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_51 => ref Get(51);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_52 => ref Get(52);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_53 => ref Get(53);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_54 => ref Get(54);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_55 => ref Get(55);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_56 => ref Get(56);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_57 => ref Get(57);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_58 => ref Get(58);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_59 => ref Get(59);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_60 => ref Get(60);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_61 => ref Get(61);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_62 => ref Get(62);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_63 => ref Get(63);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_64 => ref Get(64);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_65 => ref Get(65);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_66 => ref Get(66);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_67 => ref Get(67);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_68 => ref Get(68);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_69 => ref Get(69);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_70 => ref Get(70);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_71 => ref Get(71);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_72 => ref Get(72);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_73 => ref Get(73);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_74 => ref Get(74);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_75 => ref Get(75);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_76 => ref Get(76);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_77 => ref Get(77);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_78 => ref Get(78);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_79 => ref Get(79);

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public ref byte Item_80 => ref Get(80);

		public int Length => 81;

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
		public unsafe void CopyFrom(ref byte[] sourceData)
		{
			if(sourceData.Length != Length)
				throw new RankException();
			fixed (byte* ptr = sourceData)
			{
				Unsafe.CopyBlockUnaligned(ref Unsafe.As<String81, byte>(ref this), ref *(byte*)ptr, (uint)(sizeof(byte) * Length));
			}
		}


	}
}
