using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;
using PlcCore.Data;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:ARRAY [1..30] OF LREAL
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 240
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public unsafe struct Double30 : IPLCStructArray<double>
	{
		[FieldOffset(0)]
		public fixed double Array[30];

		public double this[int index]
		{
			get
			{
				if(index >= Length)
				{
					throw new IndexOutOfRangeException();
				}
				fixed(double* ptr = Array)
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
				fixed (double* ptr = Array)
				{
					ptr[index] = value;
				}
			}
		}

		private ref double Get(int index)
		{
			fixed(double* ptr = Array)
			{
				return ref ptr[index];
			}
		}
		public ref double Item_0 => ref Get(0);

		public ref double Item_1 => ref Get(1);

		public ref double Item_2 => ref Get(2);

		public ref double Item_3 => ref Get(3);

		public ref double Item_4 => ref Get(4);

		public ref double Item_5 => ref Get(5);

		public ref double Item_6 => ref Get(6);

		public ref double Item_7 => ref Get(7);

		public ref double Item_8 => ref Get(8);

		public ref double Item_9 => ref Get(9);

		public ref double Item_10 => ref Get(10);

		public ref double Item_11 => ref Get(11);

		public ref double Item_12 => ref Get(12);

		public ref double Item_13 => ref Get(13);

		public ref double Item_14 => ref Get(14);

		public ref double Item_15 => ref Get(15);

		public ref double Item_16 => ref Get(16);

		public ref double Item_17 => ref Get(17);

		public ref double Item_18 => ref Get(18);

		public ref double Item_19 => ref Get(19);

		public ref double Item_20 => ref Get(20);

		public ref double Item_21 => ref Get(21);

		public ref double Item_22 => ref Get(22);

		public ref double Item_23 => ref Get(23);

		public ref double Item_24 => ref Get(24);

		public ref double Item_25 => ref Get(25);

		public ref double Item_26 => ref Get(26);

		public ref double Item_27 => ref Get(27);

		public ref double Item_28 => ref Get(28);

		public ref double Item_29 => ref Get(29);

		public int Length => 30;

		public IEnumerator<double> GetEnumerator()
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
