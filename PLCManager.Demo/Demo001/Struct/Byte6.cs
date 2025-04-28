using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using PLCManager.Demo.Enum;
using PlcCore.Data;

namespace PLCManager.Demo.Struct
{
	/// <summary>
	/// Name from PLC:ARRAY [0..5] OF BYTE
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 6
	/// Comment from PLC: 
	/// <summary>
	[StructLayout(LayoutKind.Explicit)]
	public unsafe struct Byte6 : IPLCStructArray<byte>
	{
		[FieldOffset(0)]
		public fixed byte Array[6];

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

		public int Length => 6;

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
				Unsafe.CopyBlockUnaligned(ref Unsafe.As<Byte6, byte>(ref this), ref *(byte*)ptr, (uint)(sizeof(byte) * Length));
			}
		}

	}
}
