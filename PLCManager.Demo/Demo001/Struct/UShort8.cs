using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;
using PlcCore.Data;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:ARRAY [0..7] OF UINT
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 16
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public unsafe struct UShort8 : IPLCStructArray<ushort>
	{
		[FieldOffset(0)]
		public fixed ushort Array[8];

		public ushort this[int index]
		{
			get
			{
				if(index >= Length)
				{
					throw new IndexOutOfRangeException();
				}
				fixed(ushort* ptr = Array)
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
				fixed (ushort* ptr = Array)
				{
					ptr[index] = value;
				}
			}
		}

		private ref ushort Get(int index)
		{
			fixed(ushort* ptr = Array)
			{
				return ref ptr[index];
			}
		}
		public ref ushort Item_0 => ref Get(0);

		public ref ushort Item_1 => ref Get(1);

		public ref ushort Item_2 => ref Get(2);

		public ref ushort Item_3 => ref Get(3);

		public ref ushort Item_4 => ref Get(4);

		public ref ushort Item_5 => ref Get(5);

		public ref ushort Item_6 => ref Get(6);

		public ref ushort Item_7 => ref Get(7);

		public int Length => 8;

		public IEnumerator<ushort> GetEnumerator()
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
