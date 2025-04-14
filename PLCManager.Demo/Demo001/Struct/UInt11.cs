using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;
using PlcCore.Data;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:ARRAY [0..10] OF TIME
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 44
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public unsafe struct UInt11 : IPLCStructArray<uint>
	{
		[FieldOffset(0)]
		public fixed uint Array[11];

		public uint this[int index]
		{
			get
			{
				if(index >= Length)
				{
					throw new IndexOutOfRangeException();
				}
				fixed(uint* ptr = Array)
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
				fixed (uint* ptr = Array)
				{
					ptr[index] = value;
				}
			}
		}

		private ref uint Get(int index)
		{
			fixed(uint* ptr = Array)
			{
				return ref ptr[index];
			}
		}
		public ref uint Item_0 => ref Get(0);

		public ref uint Item_1 => ref Get(1);

		public ref uint Item_2 => ref Get(2);

		public ref uint Item_3 => ref Get(3);

		public ref uint Item_4 => ref Get(4);

		public ref uint Item_5 => ref Get(5);

		public ref uint Item_6 => ref Get(6);

		public ref uint Item_7 => ref Get(7);

		public ref uint Item_8 => ref Get(8);

		public ref uint Item_9 => ref Get(9);

		public ref uint Item_10 => ref Get(10);

		public int Length => 11;

		public IEnumerator<uint> GetEnumerator()
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
