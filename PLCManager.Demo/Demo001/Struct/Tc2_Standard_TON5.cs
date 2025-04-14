using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using PLCManager.Demo.Enum;
using PlcCore.Data;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:ARRAY [1..5] OF Tc2_Standard.TON
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 160
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public struct Tc2_Standard_TON5 : IPLCStructArray<Tc2_Standard_TON>
	{
		[FieldOffset(0)]
		public Tc2_Standard_TON Item_0;

		[FieldOffset(32)]
		public Tc2_Standard_TON Item_1;

		[FieldOffset(64)]
		public Tc2_Standard_TON Item_2;

		[FieldOffset(96)]
		public Tc2_Standard_TON Item_3;

		[FieldOffset(128)]
		public Tc2_Standard_TON Item_4;

		public Tc2_Standard_TON this[int index]
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
					default: throw new IndexOutOfRangeException();
				}
			}

		}

		public int Length => 5;

		public IEnumerator<Tc2_Standard_TON> GetEnumerator()
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
