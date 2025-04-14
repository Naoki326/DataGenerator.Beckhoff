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
	/// Name from PLC:STRING(19)
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 20
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public unsafe struct String20 : IPLCStructArray<byte>
	{
		[FieldOffset(0)]
		public fixed byte Array[20];

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

		public int Length => 20;

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
