using System.Runtime.InteropServices;
using System.Threading;
using PLCManager.Demo.Enum;
using PLCManager.Demo.Struct;
using PLCManager.Demo.Wrapper;
using PlcCore.Beckhoff;
using PlcCore.Data;

namespace PLCManager.Demo.Root
{

	/// <summary>
	/// Name from PLC:Global_Variables
	/// TypeName from PLC: 
	/// (IndexGroup, IndexOffset): (0,0)
	/// Size: 0
	/// IsArray: False
	
	public sealed partial class Global_VariablesWrapper
	{

		/// <summary>
		/// Name from PLC:AMSPORT_LOGGER
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384108)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_LOGGER { get; }
		internal ushort ref_AMSPORT_LOGGER = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_EVENTLOG
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384110)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_EVENTLOG { get; }
		internal ushort ref_AMSPORT_EVENTLOG = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_R0_RTIME
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384112)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_R0_RTIME { get; }
		internal ushort ref_AMSPORT_R0_RTIME = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_R0_IO
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384114)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_R0_IO { get; }
		internal ushort ref_AMSPORT_R0_IO = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_R0_NC
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384116)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_R0_NC { get; }
		internal ushort ref_AMSPORT_R0_NC = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_R0_NCSAF
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384118)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_R0_NCSAF { get; }
		internal ushort ref_AMSPORT_R0_NCSAF = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_R0_NCSVB
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384120)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_R0_NCSVB { get; }
		internal ushort ref_AMSPORT_R0_NCSVB = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_R0_ISG
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384122)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_R0_ISG { get; }
		internal ushort ref_AMSPORT_R0_ISG = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_R0_CNC
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384124)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_R0_CNC { get; }
		internal ushort ref_AMSPORT_R0_CNC = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_R0_LINE
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384126)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_R0_LINE { get; }
		internal ushort ref_AMSPORT_R0_LINE = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_R0_PLC
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384128)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_R0_PLC { get; }
		internal ushort ref_AMSPORT_R0_PLC = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_R0_PLC_RTS1
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384130)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_R0_PLC_RTS1 { get; }
		internal ushort ref_AMSPORT_R0_PLC_RTS1 = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_R0_PLC_RTS2
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384132)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_R0_PLC_RTS2 { get; }
		internal ushort ref_AMSPORT_R0_PLC_RTS2 = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_R0_PLC_RTS3
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384134)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_R0_PLC_RTS3 { get; }
		internal ushort ref_AMSPORT_R0_PLC_RTS3 = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_R0_PLC_RTS4
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384136)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_R0_PLC_RTS4 { get; }
		internal ushort ref_AMSPORT_R0_PLC_RTS4 = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_R0_CAM
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384138)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_R0_CAM { get; }
		internal ushort ref_AMSPORT_R0_CAM = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_R0_CAMTOOL
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384140)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_R0_CAMTOOL { get; }
		internal ushort ref_AMSPORT_R0_CAMTOOL = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_R3_SYSSERV
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384142)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_R3_SYSSERV { get; }
		internal ushort ref_AMSPORT_R3_SYSSERV = new ushort();

		/// <summary>
		/// Name from PLC:AMSPORT_R3_SCOPESERVER
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384144)
		/// Size: 2
		public IBaseData<ushort> AMSPORT_R3_SCOPESERVER { get; }
		internal ushort ref_AMSPORT_R3_SCOPESERVER = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_INVALID
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384146)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_INVALID { get; }
		internal ushort ref_ADSSTATE_INVALID = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_IDLE
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384148)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_IDLE { get; }
		internal ushort ref_ADSSTATE_IDLE = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_RESET
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384150)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_RESET { get; }
		internal ushort ref_ADSSTATE_RESET = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_INIT
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384152)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_INIT { get; }
		internal ushort ref_ADSSTATE_INIT = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_START
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384154)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_START { get; }
		internal ushort ref_ADSSTATE_START = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_RUN
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384156)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_RUN { get; }
		internal ushort ref_ADSSTATE_RUN = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_STOP
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384158)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_STOP { get; }
		internal ushort ref_ADSSTATE_STOP = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_SAVECFG
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384160)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_SAVECFG { get; }
		internal ushort ref_ADSSTATE_SAVECFG = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_LOADCFG
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384162)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_LOADCFG { get; }
		internal ushort ref_ADSSTATE_LOADCFG = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_POWERFAILURE
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384164)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_POWERFAILURE { get; }
		internal ushort ref_ADSSTATE_POWERFAILURE = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_POWERGOOD
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384166)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_POWERGOOD { get; }
		internal ushort ref_ADSSTATE_POWERGOOD = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_ERROR
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384168)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_ERROR { get; }
		internal ushort ref_ADSSTATE_ERROR = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_SHUTDOWN
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384170)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_SHUTDOWN { get; }
		internal ushort ref_ADSSTATE_SHUTDOWN = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_SUSPEND
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384172)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_SUSPEND { get; }
		internal ushort ref_ADSSTATE_SUSPEND = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_RESUME
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384174)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_RESUME { get; }
		internal ushort ref_ADSSTATE_RESUME = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_CONFIG
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384176)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_CONFIG { get; }
		internal ushort ref_ADSSTATE_CONFIG = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_RECONFIG
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384178)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_RECONFIG { get; }
		internal ushort ref_ADSSTATE_RECONFIG = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_STOPPING
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384180)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_STOPPING { get; }
		internal ushort ref_ADSSTATE_STOPPING = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_INCOMPATIBLE
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384182)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_INCOMPATIBLE { get; }
		internal ushort ref_ADSSTATE_INCOMPATIBLE = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_EXCEPTION
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384184)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_EXCEPTION { get; }
		internal ushort ref_ADSSTATE_EXCEPTION = new ushort();

		/// <summary>
		/// Name from PLC:ADSSTATE_MAXSTATES
		/// TypeName from PLC: UINT
		/// (IndexGroup, IndexOffset): (16448,384186)
		/// Size: 2
		public IBaseData<ushort> ADSSTATE_MAXSTATES { get; }
		internal ushort ref_ADSSTATE_MAXSTATES = new ushort();

		/// <summary>
		/// Name from PLC:ADSIGRP_SYMTAB
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384188)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_SYMTAB { get; }
		internal uint ref_ADSIGRP_SYMTAB = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_SYMNAME
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384192)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_SYMNAME { get; }
		internal uint ref_ADSIGRP_SYMNAME = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_SYMVAL
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384196)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_SYMVAL { get; }
		internal uint ref_ADSIGRP_SYMVAL = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_SYM_HNDBYNAME
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384200)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_SYM_HNDBYNAME { get; }
		internal uint ref_ADSIGRP_SYM_HNDBYNAME = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_SYM_VALBYNAME
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384204)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_SYM_VALBYNAME { get; }
		internal uint ref_ADSIGRP_SYM_VALBYNAME = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_SYM_VALBYHND
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384208)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_SYM_VALBYHND { get; }
		internal uint ref_ADSIGRP_SYM_VALBYHND = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_SYM_RELEASEHND
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384212)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_SYM_RELEASEHND { get; }
		internal uint ref_ADSIGRP_SYM_RELEASEHND = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_SYM_INFOBYNAME
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384216)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_SYM_INFOBYNAME { get; }
		internal uint ref_ADSIGRP_SYM_INFOBYNAME = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_SYM_VERSION
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384220)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_SYM_VERSION { get; }
		internal uint ref_ADSIGRP_SYM_VERSION = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_SYM_INFOBYNAMEEX
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384224)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_SYM_INFOBYNAMEEX { get; }
		internal uint ref_ADSIGRP_SYM_INFOBYNAMEEX = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_SYM_DOWNLOAD
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384228)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_SYM_DOWNLOAD { get; }
		internal uint ref_ADSIGRP_SYM_DOWNLOAD = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_SYM_UPLOAD
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384232)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_SYM_UPLOAD { get; }
		internal uint ref_ADSIGRP_SYM_UPLOAD = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_SYM_UPLOADINFO
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384236)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_SYM_UPLOADINFO { get; }
		internal uint ref_ADSIGRP_SYM_UPLOADINFO = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_SYMNOTE
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384240)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_SYMNOTE { get; }
		internal uint ref_ADSIGRP_SYMNOTE = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_IOIMAGE_RWIB
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384244)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_IOIMAGE_RWIB { get; }
		internal uint ref_ADSIGRP_IOIMAGE_RWIB = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_IOIMAGE_RWIX
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384248)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_IOIMAGE_RWIX { get; }
		internal uint ref_ADSIGRP_IOIMAGE_RWIX = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_IOIMAGE_RISIZE
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384252)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_IOIMAGE_RISIZE { get; }
		internal uint ref_ADSIGRP_IOIMAGE_RISIZE = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_IOIMAGE_RWOB
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384256)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_IOIMAGE_RWOB { get; }
		internal uint ref_ADSIGRP_IOIMAGE_RWOB = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_IOIMAGE_RWOX
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384260)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_IOIMAGE_RWOX { get; }
		internal uint ref_ADSIGRP_IOIMAGE_RWOX = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_IOIMAGE_ROSIZE
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384264)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_IOIMAGE_ROSIZE { get; }
		internal uint ref_ADSIGRP_IOIMAGE_ROSIZE = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_IOIMAGE_CLEARI
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384268)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_IOIMAGE_CLEARI { get; }
		internal uint ref_ADSIGRP_IOIMAGE_CLEARI = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_IOIMAGE_CLEARO
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384272)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_IOIMAGE_CLEARO { get; }
		internal uint ref_ADSIGRP_IOIMAGE_CLEARO = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_IOIMAGE_RWIOB
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384276)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_IOIMAGE_RWIOB { get; }
		internal uint ref_ADSIGRP_IOIMAGE_RWIOB = new uint();

		/// <summary>
		/// Name from PLC:ADSIGRP_DEVICE_DATA
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384280)
		/// Size: 4
		public IBaseData<uint> ADSIGRP_DEVICE_DATA { get; }
		internal uint ref_ADSIGRP_DEVICE_DATA = new uint();

		/// <summary>
		/// Name from PLC:ADSIOFFS_DEVDATA_ADSSTATE
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384284)
		/// Size: 4
		public IBaseData<uint> ADSIOFFS_DEVDATA_ADSSTATE { get; }
		internal uint ref_ADSIOFFS_DEVDATA_ADSSTATE = new uint();

		/// <summary>
		/// Name from PLC:ADSIOFFS_DEVDATA_DEVSTATE
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384288)
		/// Size: 4
		public IBaseData<uint> ADSIOFFS_DEVDATA_DEVSTATE { get; }
		internal uint ref_ADSIOFFS_DEVDATA_DEVSTATE = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_OPENCREATE
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384292)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_OPENCREATE { get; }
		internal uint ref_SYSTEMSERVICE_OPENCREATE = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_OPENREAD
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384296)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_OPENREAD { get; }
		internal uint ref_SYSTEMSERVICE_OPENREAD = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_OPENWRITE
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384300)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_OPENWRITE { get; }
		internal uint ref_SYSTEMSERVICE_OPENWRITE = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_CREATEFILE
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384304)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_CREATEFILE { get; }
		internal uint ref_SYSTEMSERVICE_CREATEFILE = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_CLOSEHANDLE
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384308)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_CLOSEHANDLE { get; }
		internal uint ref_SYSTEMSERVICE_CLOSEHANDLE = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_FOPEN
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384312)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_FOPEN { get; }
		internal uint ref_SYSTEMSERVICE_FOPEN = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_FCLOSE
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384316)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_FCLOSE { get; }
		internal uint ref_SYSTEMSERVICE_FCLOSE = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_FREAD
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384320)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_FREAD { get; }
		internal uint ref_SYSTEMSERVICE_FREAD = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_FWRITE
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384324)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_FWRITE { get; }
		internal uint ref_SYSTEMSERVICE_FWRITE = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_FSEEK
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384328)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_FSEEK { get; }
		internal uint ref_SYSTEMSERVICE_FSEEK = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_FTELL
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384332)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_FTELL { get; }
		internal uint ref_SYSTEMSERVICE_FTELL = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_FGETS
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384336)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_FGETS { get; }
		internal uint ref_SYSTEMSERVICE_FGETS = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_FPUTS
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384340)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_FPUTS { get; }
		internal uint ref_SYSTEMSERVICE_FPUTS = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_FSCANF
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384344)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_FSCANF { get; }
		internal uint ref_SYSTEMSERVICE_FSCANF = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_FPRINTF
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384348)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_FPRINTF { get; }
		internal uint ref_SYSTEMSERVICE_FPRINTF = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_FEOF
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384352)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_FEOF { get; }
		internal uint ref_SYSTEMSERVICE_FEOF = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_FDELETE
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384356)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_FDELETE { get; }
		internal uint ref_SYSTEMSERVICE_FDELETE = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_FRENAME
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384360)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_FRENAME { get; }
		internal uint ref_SYSTEMSERVICE_FRENAME = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_MKDIR
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384364)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_MKDIR { get; }
		internal uint ref_SYSTEMSERVICE_MKDIR = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_RMDIR
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384368)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_RMDIR { get; }
		internal uint ref_SYSTEMSERVICE_RMDIR = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_REG_HKEYLOCALMACHINE
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384372)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_REG_HKEYLOCALMACHINE { get; }
		internal uint ref_SYSTEMSERVICE_REG_HKEYLOCALMACHINE = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_SENDEMAIL
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384376)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_SENDEMAIL { get; }
		internal uint ref_SYSTEMSERVICE_SENDEMAIL = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_TIMESERVICES
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384380)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_TIMESERVICES { get; }
		internal uint ref_SYSTEMSERVICE_TIMESERVICES = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_STARTPROCESS
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384384)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_STARTPROCESS { get; }
		internal uint ref_SYSTEMSERVICE_STARTPROCESS = new uint();

		/// <summary>
		/// Name from PLC:SYSTEMSERVICE_CHANGENETID
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384388)
		/// Size: 4
		public IBaseData<uint> SYSTEMSERVICE_CHANGENETID { get; }
		internal uint ref_SYSTEMSERVICE_CHANGENETID = new uint();

		/// <summary>
		/// Name from PLC:TIMESERVICE_DATEANDTIME
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384392)
		/// Size: 4
		public IBaseData<uint> TIMESERVICE_DATEANDTIME { get; }
		internal uint ref_TIMESERVICE_DATEANDTIME = new uint();

		/// <summary>
		/// Name from PLC:TIMESERVICE_SYSTEMTIMES
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384396)
		/// Size: 4
		public IBaseData<uint> TIMESERVICE_SYSTEMTIMES { get; }
		internal uint ref_TIMESERVICE_SYSTEMTIMES = new uint();

		/// <summary>
		/// Name from PLC:TIMESERVICE_RTCTIMEDIFF
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384400)
		/// Size: 4
		public IBaseData<uint> TIMESERVICE_RTCTIMEDIFF { get; }
		internal uint ref_TIMESERVICE_RTCTIMEDIFF = new uint();

		/// <summary>
		/// Name from PLC:TIMESERVICE_ADJUSTTIMETORTC
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384404)
		/// Size: 4
		public IBaseData<uint> TIMESERVICE_ADJUSTTIMETORTC { get; }
		internal uint ref_TIMESERVICE_ADJUSTTIMETORTC = new uint();

		/// <summary>
		/// Name from PLC:TIMESERVICE_TIMEZONINFORMATION
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384408)
		/// Size: 4
		public IBaseData<uint> TIMESERVICE_TIMEZONINFORMATION { get; }
		internal uint ref_TIMESERVICE_TIMEZONINFORMATION = new uint();

		/// <summary>
		/// Name from PLC:ADSLOG_MSGTYPE_HINT
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,384412)
		/// Size: 4
		public IBaseData<int> ADSLOG_MSGTYPE_HINT { get; }
		internal int ref_ADSLOG_MSGTYPE_HINT = new int();

		/// <summary>
		/// Name from PLC:ADSLOG_MSGTYPE_WARN
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,384416)
		/// Size: 4
		public IBaseData<int> ADSLOG_MSGTYPE_WARN { get; }
		internal int ref_ADSLOG_MSGTYPE_WARN = new int();

		/// <summary>
		/// Name from PLC:ADSLOG_MSGTYPE_ERROR
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,384420)
		/// Size: 4
		public IBaseData<int> ADSLOG_MSGTYPE_ERROR { get; }
		internal int ref_ADSLOG_MSGTYPE_ERROR = new int();

		/// <summary>
		/// Name from PLC:ADSLOG_MSGTYPE_LOG
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,384424)
		/// Size: 4
		public IBaseData<int> ADSLOG_MSGTYPE_LOG { get; }
		internal int ref_ADSLOG_MSGTYPE_LOG = new int();

		/// <summary>
		/// Name from PLC:ADSLOG_MSGTYPE_MSGBOX
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,384428)
		/// Size: 4
		public IBaseData<int> ADSLOG_MSGTYPE_MSGBOX { get; }
		internal int ref_ADSLOG_MSGTYPE_MSGBOX = new int();

		/// <summary>
		/// Name from PLC:ADSLOG_MSGTYPE_RESOURCE
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,384432)
		/// Size: 4
		public IBaseData<int> ADSLOG_MSGTYPE_RESOURCE { get; }
		internal int ref_ADSLOG_MSGTYPE_RESOURCE = new int();

		/// <summary>
		/// Name from PLC:ADSLOG_MSGTYPE_STRING
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,384436)
		/// Size: 4
		public IBaseData<int> ADSLOG_MSGTYPE_STRING { get; }
		internal int ref_ADSLOG_MSGTYPE_STRING = new int();

		/// <summary>
		/// Name from PLC:BOOTDATAFLAGS_RETAIN_LOADED
		/// TypeName from PLC: BYTE
		/// (IndexGroup, IndexOffset): (16448,384440)
		/// Size: 1
		public IBaseData<byte> BOOTDATAFLAGS_RETAIN_LOADED { get; }
		internal byte ref_BOOTDATAFLAGS_RETAIN_LOADED = new byte();

		/// <summary>
		/// Name from PLC:BOOTDATAFLAGS_RETAIN_INVALID
		/// TypeName from PLC: BYTE
		/// (IndexGroup, IndexOffset): (16448,384441)
		/// Size: 1
		public IBaseData<byte> BOOTDATAFLAGS_RETAIN_INVALID { get; }
		internal byte ref_BOOTDATAFLAGS_RETAIN_INVALID = new byte();

		/// <summary>
		/// Name from PLC:BOOTDATAFLAGS_RETAIN_REQUESTED
		/// TypeName from PLC: BYTE
		/// (IndexGroup, IndexOffset): (16448,384442)
		/// Size: 1
		public IBaseData<byte> BOOTDATAFLAGS_RETAIN_REQUESTED { get; }
		internal byte ref_BOOTDATAFLAGS_RETAIN_REQUESTED = new byte();

		/// <summary>
		/// Name from PLC:BOOTDATAFLAGS_PERSISTENT_LOADED
		/// TypeName from PLC: BYTE
		/// (IndexGroup, IndexOffset): (16448,384443)
		/// Size: 1
		public IBaseData<byte> BOOTDATAFLAGS_PERSISTENT_LOADED { get; }
		internal byte ref_BOOTDATAFLAGS_PERSISTENT_LOADED = new byte();

		/// <summary>
		/// Name from PLC:BOOTDATAFLAGS_PERSISTENT_INVALID
		/// TypeName from PLC: BYTE
		/// (IndexGroup, IndexOffset): (16448,384444)
		/// Size: 1
		public IBaseData<byte> BOOTDATAFLAGS_PERSISTENT_INVALID { get; }
		internal byte ref_BOOTDATAFLAGS_PERSISTENT_INVALID = new byte();

		/// <summary>
		/// Name from PLC:SYSTEMSTATEFLAGS_BSOD
		/// TypeName from PLC: BYTE
		/// (IndexGroup, IndexOffset): (16448,384445)
		/// Size: 1
		public IBaseData<byte> SYSTEMSTATEFLAGS_BSOD { get; }
		internal byte ref_SYSTEMSTATEFLAGS_BSOD = new byte();

		/// <summary>
		/// Name from PLC:SYSTEMSTATEFLAGS_RTVIOLATION
		/// TypeName from PLC: BYTE
		/// (IndexGroup, IndexOffset): (16448,384446)
		/// Size: 1
		public IBaseData<byte> SYSTEMSTATEFLAGS_RTVIOLATION { get; }
		internal byte ref_SYSTEMSTATEFLAGS_RTVIOLATION = new byte();

		/// <summary>
		/// Name from PLC:nWatchdogTime
		/// TypeName from PLC: BYTE
		/// (IndexGroup, IndexOffset): (16448,384447)
		/// Size: 1
		public IBaseData<byte> nWatchdogTime { get; }
		internal byte ref_nWatchdogTime = new byte();

		/// <summary>
		/// Name from PLC:FOPEN_MODEREAD
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,384448)
		/// Size: 4
		public IBaseData<int> FOPEN_MODEREAD { get; }
		internal int ref_FOPEN_MODEREAD = new int();

		/// <summary>
		/// Name from PLC:FOPEN_MODEWRITE
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,384452)
		/// Size: 4
		public IBaseData<int> FOPEN_MODEWRITE { get; }
		internal int ref_FOPEN_MODEWRITE = new int();

		/// <summary>
		/// Name from PLC:FOPEN_MODEAPPEND
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,384456)
		/// Size: 4
		public IBaseData<int> FOPEN_MODEAPPEND { get; }
		internal int ref_FOPEN_MODEAPPEND = new int();

		/// <summary>
		/// Name from PLC:FOPEN_MODEPLUS
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,384460)
		/// Size: 4
		public IBaseData<int> FOPEN_MODEPLUS { get; }
		internal int ref_FOPEN_MODEPLUS = new int();

		/// <summary>
		/// Name from PLC:FOPEN_MODEBINARY
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,384464)
		/// Size: 4
		public IBaseData<int> FOPEN_MODEBINARY { get; }
		internal int ref_FOPEN_MODEBINARY = new int();

		/// <summary>
		/// Name from PLC:FOPEN_MODETEXT
		/// TypeName from PLC: DWORD
		/// (IndexGroup, IndexOffset): (16448,384468)
		/// Size: 4
		public IBaseData<int> FOPEN_MODETEXT { get; }
		internal int ref_FOPEN_MODETEXT = new int();

		/// <summary>
		/// Name from PLC:TCEVENTFLAG_PRIOCLASS
		/// TypeName from PLC: WORD
		/// (IndexGroup, IndexOffset): (16448,384500)
		/// Size: 2
		public IBaseData<short> TCEVENTFLAG_PRIOCLASS { get; }
		internal short ref_TCEVENTFLAG_PRIOCLASS = new short();

		/// <summary>
		/// Name from PLC:TCEVENTFLAG_FMTSELF
		/// TypeName from PLC: WORD
		/// (IndexGroup, IndexOffset): (16448,384502)
		/// Size: 2
		public IBaseData<short> TCEVENTFLAG_FMTSELF { get; }
		internal short ref_TCEVENTFLAG_FMTSELF = new short();

		/// <summary>
		/// Name from PLC:TCEVENTFLAG_LOG
		/// TypeName from PLC: WORD
		/// (IndexGroup, IndexOffset): (16448,384504)
		/// Size: 2
		public IBaseData<short> TCEVENTFLAG_LOG { get; }
		internal short ref_TCEVENTFLAG_LOG = new short();

		/// <summary>
		/// Name from PLC:TCEVENTFLAG_MSGBOX
		/// TypeName from PLC: WORD
		/// (IndexGroup, IndexOffset): (16448,384506)
		/// Size: 2
		public IBaseData<short> TCEVENTFLAG_MSGBOX { get; }
		internal short ref_TCEVENTFLAG_MSGBOX = new short();

		/// <summary>
		/// Name from PLC:TCEVENTFLAG_SRCID
		/// TypeName from PLC: WORD
		/// (IndexGroup, IndexOffset): (16448,384508)
		/// Size: 2
		public IBaseData<short> TCEVENTFLAG_SRCID { get; }
		internal short ref_TCEVENTFLAG_SRCID = new short();

		/// <summary>
		/// Name from PLC:TCEVENTFLAG_AUTOFMTALL
		/// TypeName from PLC: WORD
		/// (IndexGroup, IndexOffset): (16448,384510)
		/// Size: 2
		public IBaseData<short> TCEVENTFLAG_AUTOFMTALL { get; }
		internal short ref_TCEVENTFLAG_AUTOFMTALL = new short();

		/// <summary>
		/// Name from PLC:TCEVENTSTATE_INVALID
		/// TypeName from PLC: WORD
		/// (IndexGroup, IndexOffset): (16448,384512)
		/// Size: 2
		public IBaseData<short> TCEVENTSTATE_INVALID { get; }
		internal short ref_TCEVENTSTATE_INVALID = new short();

		/// <summary>
		/// Name from PLC:TCEVENTSTATE_SIGNALED
		/// TypeName from PLC: WORD
		/// (IndexGroup, IndexOffset): (16448,384514)
		/// Size: 2
		public IBaseData<short> TCEVENTSTATE_SIGNALED { get; }
		internal short ref_TCEVENTSTATE_SIGNALED = new short();

		/// <summary>
		/// Name from PLC:TCEVENTSTATE_RESET
		/// TypeName from PLC: WORD
		/// (IndexGroup, IndexOffset): (16448,384516)
		/// Size: 2
		public IBaseData<short> TCEVENTSTATE_RESET { get; }
		internal short ref_TCEVENTSTATE_RESET = new short();

		/// <summary>
		/// Name from PLC:TCEVENTSTATE_CONFIRMED
		/// TypeName from PLC: WORD
		/// (IndexGroup, IndexOffset): (16448,384518)
		/// Size: 2
		public IBaseData<short> TCEVENTSTATE_CONFIRMED { get; }
		internal short ref_TCEVENTSTATE_CONFIRMED = new short();

		/// <summary>
		/// Name from PLC:TCEVENTSTATE_RESETCON
		/// TypeName from PLC: WORD
		/// (IndexGroup, IndexOffset): (16448,384520)
		/// Size: 2
		public IBaseData<short> TCEVENTSTATE_RESETCON { get; }
		internal short ref_TCEVENTSTATE_RESETCON = new short();

		/// <summary>
		/// Name from PLC:TCEVENT_SRCNAMESIZE
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,384522)
		/// Size: 2
		public IBaseData<short> TCEVENT_SRCNAMESIZE { get; }
		internal short ref_TCEVENT_SRCNAMESIZE = new short();

		/// <summary>
		/// Name from PLC:TCEVENT_FMTPRGSIZE
		/// TypeName from PLC: INT
		/// (IndexGroup, IndexOffset): (16448,384524)
		/// Size: 2
		public IBaseData<short> TCEVENT_FMTPRGSIZE { get; }
		internal short ref_TCEVENT_FMTPRGSIZE = new short();

		/// <summary>
		/// Name from PLC:eWatchdogConfig
		/// TypeName from PLC: Tc2_System.E_WATCHDOG_TIME_CONFIG
		/// (IndexGroup, IndexOffset): (16448,384526)
		/// Size: 2
		public IBaseData<Tc2_System_E_WATCHDOG_TIME_CONFIG> eWatchdogConfig { get; }
		internal Tc2_System_E_WATCHDOG_TIME_CONFIG  ref_eWatchdogConfig = new Tc2_System_E_WATCHDOG_TIME_CONFIG();

		/// <summary>
		/// Name from PLC:PI
		/// TypeName from PLC: LREAL
		/// (IndexGroup, IndexOffset): (16448,384528)
		/// Size: 8
		public IBaseData<double> PI { get; }
		internal double ref_PI = new double();

		/// <summary>
		/// Name from PLC:DEFAULT_ADS_TIMEOUT
		/// TypeName from PLC: TIME
		/// (IndexGroup, IndexOffset): (16448,384536)
		/// Size: 4
		public IBaseData<uint> DEFAULT_ADS_TIMEOUT { get; }
		internal uint ref_DEFAULT_ADS_TIMEOUT = new uint();

		/// <summary>
		/// Name from PLC:MAX_STRING_LENGTH
		/// TypeName from PLC: UDINT
		/// (IndexGroup, IndexOffset): (16448,384540)
		/// Size: 4
		public IBaseData<uint> MAX_STRING_LENGTH { get; }
		internal uint ref_MAX_STRING_LENGTH = new uint();

		/// <summary>
		/// Name from PLC:TcMcGlobal
		/// TypeName from PLC: Tc2_MC2._TCMCGLOBAL
		/// (IndexGroup, IndexOffset): (16448,384736)
		/// Size: 896
		public Tc2_MC2__TCMCGLOBALWrapper TcMcGlobal { get; }
		internal Tc2_MC2__TCMCGLOBAL ref_TcMcGlobal = new Tc2_MC2__TCMCGLOBAL();

		/// <summary>
		/// Name from PLC:DEFAULT_HOME_POSITION
		/// TypeName from PLC: LREAL
		/// (IndexGroup, IndexOffset): (16448,385632)
		/// Size: 8
		public IBaseData<double> DEFAULT_HOME_POSITION { get; }
		internal double ref_DEFAULT_HOME_POSITION = new double();

		/// <summary>
		/// Name from PLC:DEFAULT_BACKLASHVALUE
		/// TypeName from PLC: LREAL
		/// (IndexGroup, IndexOffset): (16448,385640)
		/// Size: 8
		public IBaseData<double> DEFAULT_BACKLASHVALUE { get; }
		internal double ref_DEFAULT_BACKLASHVALUE = new double();

		internal override void Init()
		{
		}
		public override void CheckAndNotify(int timeout = -1, CancellationToken token = default)
		{
		    foreach (var child in Children)
		    {
		        child?.CheckAndNotify(timeout, token);
		    }
		}


	}

}
