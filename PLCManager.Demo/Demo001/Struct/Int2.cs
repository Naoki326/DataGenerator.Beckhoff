using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;
using PlcCore.Data;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:ARRAY [1..2] OF DWORD
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 8
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public unsafe struct Int2 : IPLCStructArray<int>
	{
		[FieldOffset(0)]
		public fixed int Array[2];

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

		public int Length => 2;

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
