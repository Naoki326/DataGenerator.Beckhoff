using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;
using PlcCore.Data;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:ARRAY [1..20] OF BOOL
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 20
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public unsafe struct Bool20 : IPLCStructArray<bool>
	{
		[FieldOffset(0)]
		public fixed bool Array[20];

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

		public int Length => 20;

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
