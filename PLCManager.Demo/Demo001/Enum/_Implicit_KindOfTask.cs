using System;
using System.Runtime.InteropServices;

namespace PLCManager.Demo.Enum
{
	/// <summary>
	/// Name from PLC:_Implicit_KindOfTask
	/// PLCNamespace from PLC: 5.113.195.149.1.1:851
	/// Size: 2
	/// Comment from PLC: 
	/// <summary>
	public enum _Implicit_KindOfTask : short
	{
		_implicit_cyclic = 0,
		_implicit_event = 1,
		_implicit_external = 2,
		_implicit_freewheeling = 3,

	}
}
