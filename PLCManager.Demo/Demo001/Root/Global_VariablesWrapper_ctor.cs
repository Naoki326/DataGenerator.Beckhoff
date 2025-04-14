using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TwinCAT.Ads;
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
	
	public sealed partial class Global_VariablesWrapper : BaseData, IBaseData
	{
		public override IEnumerable<IBaseData> Children
		{
			get
			{
				yield return AMSPORT_LOGGER;
				yield return AMSPORT_EVENTLOG;
				yield return AMSPORT_R0_RTIME;
				yield return AMSPORT_R0_IO;
				yield return AMSPORT_R0_NC;
				yield return AMSPORT_R0_NCSAF;
				yield return AMSPORT_R0_NCSVB;
				yield return AMSPORT_R0_ISG;
				yield return AMSPORT_R0_CNC;
				yield return AMSPORT_R0_LINE;
				yield return AMSPORT_R0_PLC;
				yield return AMSPORT_R0_PLC_RTS1;
				yield return AMSPORT_R0_PLC_RTS2;
				yield return AMSPORT_R0_PLC_RTS3;
				yield return AMSPORT_R0_PLC_RTS4;
				yield return AMSPORT_R0_CAM;
				yield return AMSPORT_R0_CAMTOOL;
				yield return AMSPORT_R3_SYSSERV;
				yield return AMSPORT_R3_SCOPESERVER;
				yield return ADSSTATE_INVALID;
				yield return ADSSTATE_IDLE;
				yield return ADSSTATE_RESET;
				yield return ADSSTATE_INIT;
				yield return ADSSTATE_START;
				yield return ADSSTATE_RUN;
				yield return ADSSTATE_STOP;
				yield return ADSSTATE_SAVECFG;
				yield return ADSSTATE_LOADCFG;
				yield return ADSSTATE_POWERFAILURE;
				yield return ADSSTATE_POWERGOOD;
				yield return ADSSTATE_ERROR;
				yield return ADSSTATE_SHUTDOWN;
				yield return ADSSTATE_SUSPEND;
				yield return ADSSTATE_RESUME;
				yield return ADSSTATE_CONFIG;
				yield return ADSSTATE_RECONFIG;
				yield return ADSSTATE_STOPPING;
				yield return ADSSTATE_INCOMPATIBLE;
				yield return ADSSTATE_EXCEPTION;
				yield return ADSSTATE_MAXSTATES;
				yield return ADSIGRP_SYMTAB;
				yield return ADSIGRP_SYMNAME;
				yield return ADSIGRP_SYMVAL;
				yield return ADSIGRP_SYM_HNDBYNAME;
				yield return ADSIGRP_SYM_VALBYNAME;
				yield return ADSIGRP_SYM_VALBYHND;
				yield return ADSIGRP_SYM_RELEASEHND;
				yield return ADSIGRP_SYM_INFOBYNAME;
				yield return ADSIGRP_SYM_VERSION;
				yield return ADSIGRP_SYM_INFOBYNAMEEX;
				yield return ADSIGRP_SYM_DOWNLOAD;
				yield return ADSIGRP_SYM_UPLOAD;
				yield return ADSIGRP_SYM_UPLOADINFO;
				yield return ADSIGRP_SYMNOTE;
				yield return ADSIGRP_IOIMAGE_RWIB;
				yield return ADSIGRP_IOIMAGE_RWIX;
				yield return ADSIGRP_IOIMAGE_RISIZE;
				yield return ADSIGRP_IOIMAGE_RWOB;
				yield return ADSIGRP_IOIMAGE_RWOX;
				yield return ADSIGRP_IOIMAGE_ROSIZE;
				yield return ADSIGRP_IOIMAGE_CLEARI;
				yield return ADSIGRP_IOIMAGE_CLEARO;
				yield return ADSIGRP_IOIMAGE_RWIOB;
				yield return ADSIGRP_DEVICE_DATA;
				yield return ADSIOFFS_DEVDATA_ADSSTATE;
				yield return ADSIOFFS_DEVDATA_DEVSTATE;
				yield return SYSTEMSERVICE_OPENCREATE;
				yield return SYSTEMSERVICE_OPENREAD;
				yield return SYSTEMSERVICE_OPENWRITE;
				yield return SYSTEMSERVICE_CREATEFILE;
				yield return SYSTEMSERVICE_CLOSEHANDLE;
				yield return SYSTEMSERVICE_FOPEN;
				yield return SYSTEMSERVICE_FCLOSE;
				yield return SYSTEMSERVICE_FREAD;
				yield return SYSTEMSERVICE_FWRITE;
				yield return SYSTEMSERVICE_FSEEK;
				yield return SYSTEMSERVICE_FTELL;
				yield return SYSTEMSERVICE_FGETS;
				yield return SYSTEMSERVICE_FPUTS;
				yield return SYSTEMSERVICE_FSCANF;
				yield return SYSTEMSERVICE_FPRINTF;
				yield return SYSTEMSERVICE_FEOF;
				yield return SYSTEMSERVICE_FDELETE;
				yield return SYSTEMSERVICE_FRENAME;
				yield return SYSTEMSERVICE_MKDIR;
				yield return SYSTEMSERVICE_RMDIR;
				yield return SYSTEMSERVICE_REG_HKEYLOCALMACHINE;
				yield return SYSTEMSERVICE_SENDEMAIL;
				yield return SYSTEMSERVICE_TIMESERVICES;
				yield return SYSTEMSERVICE_STARTPROCESS;
				yield return SYSTEMSERVICE_CHANGENETID;
				yield return TIMESERVICE_DATEANDTIME;
				yield return TIMESERVICE_SYSTEMTIMES;
				yield return TIMESERVICE_RTCTIMEDIFF;
				yield return TIMESERVICE_ADJUSTTIMETORTC;
				yield return TIMESERVICE_TIMEZONINFORMATION;
				yield return ADSLOG_MSGTYPE_HINT;
				yield return ADSLOG_MSGTYPE_WARN;
				yield return ADSLOG_MSGTYPE_ERROR;
				yield return ADSLOG_MSGTYPE_LOG;
				yield return ADSLOG_MSGTYPE_MSGBOX;
				yield return ADSLOG_MSGTYPE_RESOURCE;
				yield return ADSLOG_MSGTYPE_STRING;
				yield return BOOTDATAFLAGS_RETAIN_LOADED;
				yield return BOOTDATAFLAGS_RETAIN_INVALID;
				yield return BOOTDATAFLAGS_RETAIN_REQUESTED;
				yield return BOOTDATAFLAGS_PERSISTENT_LOADED;
				yield return BOOTDATAFLAGS_PERSISTENT_INVALID;
				yield return SYSTEMSTATEFLAGS_BSOD;
				yield return SYSTEMSTATEFLAGS_RTVIOLATION;
				yield return nWatchdogTime;
				yield return FOPEN_MODEREAD;
				yield return FOPEN_MODEWRITE;
				yield return FOPEN_MODEAPPEND;
				yield return FOPEN_MODEPLUS;
				yield return FOPEN_MODEBINARY;
				yield return FOPEN_MODETEXT;
				yield return TCEVENTFLAG_PRIOCLASS;
				yield return TCEVENTFLAG_FMTSELF;
				yield return TCEVENTFLAG_LOG;
				yield return TCEVENTFLAG_MSGBOX;
				yield return TCEVENTFLAG_SRCID;
				yield return TCEVENTFLAG_AUTOFMTALL;
				yield return TCEVENTSTATE_INVALID;
				yield return TCEVENTSTATE_SIGNALED;
				yield return TCEVENTSTATE_RESET;
				yield return TCEVENTSTATE_CONFIRMED;
				yield return TCEVENTSTATE_RESETCON;
				yield return TCEVENT_SRCNAMESIZE;
				yield return TCEVENT_FMTPRGSIZE;
				yield return eWatchdogConfig;
				yield return PI;
				yield return DEFAULT_ADS_TIMEOUT;
				yield return MAX_STRING_LENGTH;
				yield return TcMcGlobal;
				yield return DEFAULT_HOME_POSITION;
				yield return DEFAULT_BACKLASHVALUE;
			}
		}

		public override IBaseData Get(string name)
		{
			switch (name)
			{
				case nameof(AMSPORT_LOGGER):
					return AMSPORT_LOGGER;
				case nameof(AMSPORT_EVENTLOG):
					return AMSPORT_EVENTLOG;
				case nameof(AMSPORT_R0_RTIME):
					return AMSPORT_R0_RTIME;
				case nameof(AMSPORT_R0_IO):
					return AMSPORT_R0_IO;
				case nameof(AMSPORT_R0_NC):
					return AMSPORT_R0_NC;
				case nameof(AMSPORT_R0_NCSAF):
					return AMSPORT_R0_NCSAF;
				case nameof(AMSPORT_R0_NCSVB):
					return AMSPORT_R0_NCSVB;
				case nameof(AMSPORT_R0_ISG):
					return AMSPORT_R0_ISG;
				case nameof(AMSPORT_R0_CNC):
					return AMSPORT_R0_CNC;
				case nameof(AMSPORT_R0_LINE):
					return AMSPORT_R0_LINE;
				case nameof(AMSPORT_R0_PLC):
					return AMSPORT_R0_PLC;
				case nameof(AMSPORT_R0_PLC_RTS1):
					return AMSPORT_R0_PLC_RTS1;
				case nameof(AMSPORT_R0_PLC_RTS2):
					return AMSPORT_R0_PLC_RTS2;
				case nameof(AMSPORT_R0_PLC_RTS3):
					return AMSPORT_R0_PLC_RTS3;
				case nameof(AMSPORT_R0_PLC_RTS4):
					return AMSPORT_R0_PLC_RTS4;
				case nameof(AMSPORT_R0_CAM):
					return AMSPORT_R0_CAM;
				case nameof(AMSPORT_R0_CAMTOOL):
					return AMSPORT_R0_CAMTOOL;
				case nameof(AMSPORT_R3_SYSSERV):
					return AMSPORT_R3_SYSSERV;
				case nameof(AMSPORT_R3_SCOPESERVER):
					return AMSPORT_R3_SCOPESERVER;
				case nameof(ADSSTATE_INVALID):
					return ADSSTATE_INVALID;
				case nameof(ADSSTATE_IDLE):
					return ADSSTATE_IDLE;
				case nameof(ADSSTATE_RESET):
					return ADSSTATE_RESET;
				case nameof(ADSSTATE_INIT):
					return ADSSTATE_INIT;
				case nameof(ADSSTATE_START):
					return ADSSTATE_START;
				case nameof(ADSSTATE_RUN):
					return ADSSTATE_RUN;
				case nameof(ADSSTATE_STOP):
					return ADSSTATE_STOP;
				case nameof(ADSSTATE_SAVECFG):
					return ADSSTATE_SAVECFG;
				case nameof(ADSSTATE_LOADCFG):
					return ADSSTATE_LOADCFG;
				case nameof(ADSSTATE_POWERFAILURE):
					return ADSSTATE_POWERFAILURE;
				case nameof(ADSSTATE_POWERGOOD):
					return ADSSTATE_POWERGOOD;
				case nameof(ADSSTATE_ERROR):
					return ADSSTATE_ERROR;
				case nameof(ADSSTATE_SHUTDOWN):
					return ADSSTATE_SHUTDOWN;
				case nameof(ADSSTATE_SUSPEND):
					return ADSSTATE_SUSPEND;
				case nameof(ADSSTATE_RESUME):
					return ADSSTATE_RESUME;
				case nameof(ADSSTATE_CONFIG):
					return ADSSTATE_CONFIG;
				case nameof(ADSSTATE_RECONFIG):
					return ADSSTATE_RECONFIG;
				case nameof(ADSSTATE_STOPPING):
					return ADSSTATE_STOPPING;
				case nameof(ADSSTATE_INCOMPATIBLE):
					return ADSSTATE_INCOMPATIBLE;
				case nameof(ADSSTATE_EXCEPTION):
					return ADSSTATE_EXCEPTION;
				case nameof(ADSSTATE_MAXSTATES):
					return ADSSTATE_MAXSTATES;
				case nameof(ADSIGRP_SYMTAB):
					return ADSIGRP_SYMTAB;
				case nameof(ADSIGRP_SYMNAME):
					return ADSIGRP_SYMNAME;
				case nameof(ADSIGRP_SYMVAL):
					return ADSIGRP_SYMVAL;
				case nameof(ADSIGRP_SYM_HNDBYNAME):
					return ADSIGRP_SYM_HNDBYNAME;
				case nameof(ADSIGRP_SYM_VALBYNAME):
					return ADSIGRP_SYM_VALBYNAME;
				case nameof(ADSIGRP_SYM_VALBYHND):
					return ADSIGRP_SYM_VALBYHND;
				case nameof(ADSIGRP_SYM_RELEASEHND):
					return ADSIGRP_SYM_RELEASEHND;
				case nameof(ADSIGRP_SYM_INFOBYNAME):
					return ADSIGRP_SYM_INFOBYNAME;
				case nameof(ADSIGRP_SYM_VERSION):
					return ADSIGRP_SYM_VERSION;
				case nameof(ADSIGRP_SYM_INFOBYNAMEEX):
					return ADSIGRP_SYM_INFOBYNAMEEX;
				case nameof(ADSIGRP_SYM_DOWNLOAD):
					return ADSIGRP_SYM_DOWNLOAD;
				case nameof(ADSIGRP_SYM_UPLOAD):
					return ADSIGRP_SYM_UPLOAD;
				case nameof(ADSIGRP_SYM_UPLOADINFO):
					return ADSIGRP_SYM_UPLOADINFO;
				case nameof(ADSIGRP_SYMNOTE):
					return ADSIGRP_SYMNOTE;
				case nameof(ADSIGRP_IOIMAGE_RWIB):
					return ADSIGRP_IOIMAGE_RWIB;
				case nameof(ADSIGRP_IOIMAGE_RWIX):
					return ADSIGRP_IOIMAGE_RWIX;
				case nameof(ADSIGRP_IOIMAGE_RISIZE):
					return ADSIGRP_IOIMAGE_RISIZE;
				case nameof(ADSIGRP_IOIMAGE_RWOB):
					return ADSIGRP_IOIMAGE_RWOB;
				case nameof(ADSIGRP_IOIMAGE_RWOX):
					return ADSIGRP_IOIMAGE_RWOX;
				case nameof(ADSIGRP_IOIMAGE_ROSIZE):
					return ADSIGRP_IOIMAGE_ROSIZE;
				case nameof(ADSIGRP_IOIMAGE_CLEARI):
					return ADSIGRP_IOIMAGE_CLEARI;
				case nameof(ADSIGRP_IOIMAGE_CLEARO):
					return ADSIGRP_IOIMAGE_CLEARO;
				case nameof(ADSIGRP_IOIMAGE_RWIOB):
					return ADSIGRP_IOIMAGE_RWIOB;
				case nameof(ADSIGRP_DEVICE_DATA):
					return ADSIGRP_DEVICE_DATA;
				case nameof(ADSIOFFS_DEVDATA_ADSSTATE):
					return ADSIOFFS_DEVDATA_ADSSTATE;
				case nameof(ADSIOFFS_DEVDATA_DEVSTATE):
					return ADSIOFFS_DEVDATA_DEVSTATE;
				case nameof(SYSTEMSERVICE_OPENCREATE):
					return SYSTEMSERVICE_OPENCREATE;
				case nameof(SYSTEMSERVICE_OPENREAD):
					return SYSTEMSERVICE_OPENREAD;
				case nameof(SYSTEMSERVICE_OPENWRITE):
					return SYSTEMSERVICE_OPENWRITE;
				case nameof(SYSTEMSERVICE_CREATEFILE):
					return SYSTEMSERVICE_CREATEFILE;
				case nameof(SYSTEMSERVICE_CLOSEHANDLE):
					return SYSTEMSERVICE_CLOSEHANDLE;
				case nameof(SYSTEMSERVICE_FOPEN):
					return SYSTEMSERVICE_FOPEN;
				case nameof(SYSTEMSERVICE_FCLOSE):
					return SYSTEMSERVICE_FCLOSE;
				case nameof(SYSTEMSERVICE_FREAD):
					return SYSTEMSERVICE_FREAD;
				case nameof(SYSTEMSERVICE_FWRITE):
					return SYSTEMSERVICE_FWRITE;
				case nameof(SYSTEMSERVICE_FSEEK):
					return SYSTEMSERVICE_FSEEK;
				case nameof(SYSTEMSERVICE_FTELL):
					return SYSTEMSERVICE_FTELL;
				case nameof(SYSTEMSERVICE_FGETS):
					return SYSTEMSERVICE_FGETS;
				case nameof(SYSTEMSERVICE_FPUTS):
					return SYSTEMSERVICE_FPUTS;
				case nameof(SYSTEMSERVICE_FSCANF):
					return SYSTEMSERVICE_FSCANF;
				case nameof(SYSTEMSERVICE_FPRINTF):
					return SYSTEMSERVICE_FPRINTF;
				case nameof(SYSTEMSERVICE_FEOF):
					return SYSTEMSERVICE_FEOF;
				case nameof(SYSTEMSERVICE_FDELETE):
					return SYSTEMSERVICE_FDELETE;
				case nameof(SYSTEMSERVICE_FRENAME):
					return SYSTEMSERVICE_FRENAME;
				case nameof(SYSTEMSERVICE_MKDIR):
					return SYSTEMSERVICE_MKDIR;
				case nameof(SYSTEMSERVICE_RMDIR):
					return SYSTEMSERVICE_RMDIR;
				case nameof(SYSTEMSERVICE_REG_HKEYLOCALMACHINE):
					return SYSTEMSERVICE_REG_HKEYLOCALMACHINE;
				case nameof(SYSTEMSERVICE_SENDEMAIL):
					return SYSTEMSERVICE_SENDEMAIL;
				case nameof(SYSTEMSERVICE_TIMESERVICES):
					return SYSTEMSERVICE_TIMESERVICES;
				case nameof(SYSTEMSERVICE_STARTPROCESS):
					return SYSTEMSERVICE_STARTPROCESS;
				case nameof(SYSTEMSERVICE_CHANGENETID):
					return SYSTEMSERVICE_CHANGENETID;
				case nameof(TIMESERVICE_DATEANDTIME):
					return TIMESERVICE_DATEANDTIME;
				case nameof(TIMESERVICE_SYSTEMTIMES):
					return TIMESERVICE_SYSTEMTIMES;
				case nameof(TIMESERVICE_RTCTIMEDIFF):
					return TIMESERVICE_RTCTIMEDIFF;
				case nameof(TIMESERVICE_ADJUSTTIMETORTC):
					return TIMESERVICE_ADJUSTTIMETORTC;
				case nameof(TIMESERVICE_TIMEZONINFORMATION):
					return TIMESERVICE_TIMEZONINFORMATION;
				case nameof(ADSLOG_MSGTYPE_HINT):
					return ADSLOG_MSGTYPE_HINT;
				case nameof(ADSLOG_MSGTYPE_WARN):
					return ADSLOG_MSGTYPE_WARN;
				case nameof(ADSLOG_MSGTYPE_ERROR):
					return ADSLOG_MSGTYPE_ERROR;
				case nameof(ADSLOG_MSGTYPE_LOG):
					return ADSLOG_MSGTYPE_LOG;
				case nameof(ADSLOG_MSGTYPE_MSGBOX):
					return ADSLOG_MSGTYPE_MSGBOX;
				case nameof(ADSLOG_MSGTYPE_RESOURCE):
					return ADSLOG_MSGTYPE_RESOURCE;
				case nameof(ADSLOG_MSGTYPE_STRING):
					return ADSLOG_MSGTYPE_STRING;
				case nameof(BOOTDATAFLAGS_RETAIN_LOADED):
					return BOOTDATAFLAGS_RETAIN_LOADED;
				case nameof(BOOTDATAFLAGS_RETAIN_INVALID):
					return BOOTDATAFLAGS_RETAIN_INVALID;
				case nameof(BOOTDATAFLAGS_RETAIN_REQUESTED):
					return BOOTDATAFLAGS_RETAIN_REQUESTED;
				case nameof(BOOTDATAFLAGS_PERSISTENT_LOADED):
					return BOOTDATAFLAGS_PERSISTENT_LOADED;
				case nameof(BOOTDATAFLAGS_PERSISTENT_INVALID):
					return BOOTDATAFLAGS_PERSISTENT_INVALID;
				case nameof(SYSTEMSTATEFLAGS_BSOD):
					return SYSTEMSTATEFLAGS_BSOD;
				case nameof(SYSTEMSTATEFLAGS_RTVIOLATION):
					return SYSTEMSTATEFLAGS_RTVIOLATION;
				case nameof(nWatchdogTime):
					return nWatchdogTime;
				case nameof(FOPEN_MODEREAD):
					return FOPEN_MODEREAD;
				case nameof(FOPEN_MODEWRITE):
					return FOPEN_MODEWRITE;
				case nameof(FOPEN_MODEAPPEND):
					return FOPEN_MODEAPPEND;
				case nameof(FOPEN_MODEPLUS):
					return FOPEN_MODEPLUS;
				case nameof(FOPEN_MODEBINARY):
					return FOPEN_MODEBINARY;
				case nameof(FOPEN_MODETEXT):
					return FOPEN_MODETEXT;
				case nameof(TCEVENTFLAG_PRIOCLASS):
					return TCEVENTFLAG_PRIOCLASS;
				case nameof(TCEVENTFLAG_FMTSELF):
					return TCEVENTFLAG_FMTSELF;
				case nameof(TCEVENTFLAG_LOG):
					return TCEVENTFLAG_LOG;
				case nameof(TCEVENTFLAG_MSGBOX):
					return TCEVENTFLAG_MSGBOX;
				case nameof(TCEVENTFLAG_SRCID):
					return TCEVENTFLAG_SRCID;
				case nameof(TCEVENTFLAG_AUTOFMTALL):
					return TCEVENTFLAG_AUTOFMTALL;
				case nameof(TCEVENTSTATE_INVALID):
					return TCEVENTSTATE_INVALID;
				case nameof(TCEVENTSTATE_SIGNALED):
					return TCEVENTSTATE_SIGNALED;
				case nameof(TCEVENTSTATE_RESET):
					return TCEVENTSTATE_RESET;
				case nameof(TCEVENTSTATE_CONFIRMED):
					return TCEVENTSTATE_CONFIRMED;
				case nameof(TCEVENTSTATE_RESETCON):
					return TCEVENTSTATE_RESETCON;
				case nameof(TCEVENT_SRCNAMESIZE):
					return TCEVENT_SRCNAMESIZE;
				case nameof(TCEVENT_FMTPRGSIZE):
					return TCEVENT_FMTPRGSIZE;
				case nameof(eWatchdogConfig):
					return eWatchdogConfig;
				case nameof(PI):
					return PI;
				case nameof(DEFAULT_ADS_TIMEOUT):
					return DEFAULT_ADS_TIMEOUT;
				case nameof(MAX_STRING_LENGTH):
					return MAX_STRING_LENGTH;
				case nameof(TcMcGlobal):
					return TcMcGlobal;
				case nameof(DEFAULT_HOME_POSITION):
					return DEFAULT_HOME_POSITION;
				case nameof(DEFAULT_BACKLASHVALUE):
					return DEFAULT_BACKLASHVALUE;
			}
			throw new KeyNotFoundException(name);
		}

		private readonly AdsClient client;

		public Global_VariablesWrapper(AdsClient client)
		{
			this.client = client;

			AMSPORT_LOGGER = new BeckhoffUShort(this.GetAMSPORT_LOGGER, client, 16448, 384108){ Name = "AMSPORT_LOGGER" };
			AMSPORT_EVENTLOG = new BeckhoffUShort(this.GetAMSPORT_EVENTLOG, client, 16448, 384110){ Name = "AMSPORT_EVENTLOG" };
			AMSPORT_R0_RTIME = new BeckhoffUShort(this.GetAMSPORT_R0_RTIME, client, 16448, 384112){ Name = "AMSPORT_R0_RTIME" };
			AMSPORT_R0_IO = new BeckhoffUShort(this.GetAMSPORT_R0_IO, client, 16448, 384114){ Name = "AMSPORT_R0_IO" };
			AMSPORT_R0_NC = new BeckhoffUShort(this.GetAMSPORT_R0_NC, client, 16448, 384116){ Name = "AMSPORT_R0_NC" };
			AMSPORT_R0_NCSAF = new BeckhoffUShort(this.GetAMSPORT_R0_NCSAF, client, 16448, 384118){ Name = "AMSPORT_R0_NCSAF" };
			AMSPORT_R0_NCSVB = new BeckhoffUShort(this.GetAMSPORT_R0_NCSVB, client, 16448, 384120){ Name = "AMSPORT_R0_NCSVB" };
			AMSPORT_R0_ISG = new BeckhoffUShort(this.GetAMSPORT_R0_ISG, client, 16448, 384122){ Name = "AMSPORT_R0_ISG" };
			AMSPORT_R0_CNC = new BeckhoffUShort(this.GetAMSPORT_R0_CNC, client, 16448, 384124){ Name = "AMSPORT_R0_CNC" };
			AMSPORT_R0_LINE = new BeckhoffUShort(this.GetAMSPORT_R0_LINE, client, 16448, 384126){ Name = "AMSPORT_R0_LINE" };
			AMSPORT_R0_PLC = new BeckhoffUShort(this.GetAMSPORT_R0_PLC, client, 16448, 384128){ Name = "AMSPORT_R0_PLC" };
			AMSPORT_R0_PLC_RTS1 = new BeckhoffUShort(this.GetAMSPORT_R0_PLC_RTS1, client, 16448, 384130){ Name = "AMSPORT_R0_PLC_RTS1" };
			AMSPORT_R0_PLC_RTS2 = new BeckhoffUShort(this.GetAMSPORT_R0_PLC_RTS2, client, 16448, 384132){ Name = "AMSPORT_R0_PLC_RTS2" };
			AMSPORT_R0_PLC_RTS3 = new BeckhoffUShort(this.GetAMSPORT_R0_PLC_RTS3, client, 16448, 384134){ Name = "AMSPORT_R0_PLC_RTS3" };
			AMSPORT_R0_PLC_RTS4 = new BeckhoffUShort(this.GetAMSPORT_R0_PLC_RTS4, client, 16448, 384136){ Name = "AMSPORT_R0_PLC_RTS4" };
			AMSPORT_R0_CAM = new BeckhoffUShort(this.GetAMSPORT_R0_CAM, client, 16448, 384138){ Name = "AMSPORT_R0_CAM" };
			AMSPORT_R0_CAMTOOL = new BeckhoffUShort(this.GetAMSPORT_R0_CAMTOOL, client, 16448, 384140){ Name = "AMSPORT_R0_CAMTOOL" };
			AMSPORT_R3_SYSSERV = new BeckhoffUShort(this.GetAMSPORT_R3_SYSSERV, client, 16448, 384142){ Name = "AMSPORT_R3_SYSSERV" };
			AMSPORT_R3_SCOPESERVER = new BeckhoffUShort(this.GetAMSPORT_R3_SCOPESERVER, client, 16448, 384144){ Name = "AMSPORT_R3_SCOPESERVER" };
			ADSSTATE_INVALID = new BeckhoffUShort(this.GetADSSTATE_INVALID, client, 16448, 384146){ Name = "ADSSTATE_INVALID" };
			ADSSTATE_IDLE = new BeckhoffUShort(this.GetADSSTATE_IDLE, client, 16448, 384148){ Name = "ADSSTATE_IDLE" };
			ADSSTATE_RESET = new BeckhoffUShort(this.GetADSSTATE_RESET, client, 16448, 384150){ Name = "ADSSTATE_RESET" };
			ADSSTATE_INIT = new BeckhoffUShort(this.GetADSSTATE_INIT, client, 16448, 384152){ Name = "ADSSTATE_INIT" };
			ADSSTATE_START = new BeckhoffUShort(this.GetADSSTATE_START, client, 16448, 384154){ Name = "ADSSTATE_START" };
			ADSSTATE_RUN = new BeckhoffUShort(this.GetADSSTATE_RUN, client, 16448, 384156){ Name = "ADSSTATE_RUN" };
			ADSSTATE_STOP = new BeckhoffUShort(this.GetADSSTATE_STOP, client, 16448, 384158){ Name = "ADSSTATE_STOP" };
			ADSSTATE_SAVECFG = new BeckhoffUShort(this.GetADSSTATE_SAVECFG, client, 16448, 384160){ Name = "ADSSTATE_SAVECFG" };
			ADSSTATE_LOADCFG = new BeckhoffUShort(this.GetADSSTATE_LOADCFG, client, 16448, 384162){ Name = "ADSSTATE_LOADCFG" };
			ADSSTATE_POWERFAILURE = new BeckhoffUShort(this.GetADSSTATE_POWERFAILURE, client, 16448, 384164){ Name = "ADSSTATE_POWERFAILURE" };
			ADSSTATE_POWERGOOD = new BeckhoffUShort(this.GetADSSTATE_POWERGOOD, client, 16448, 384166){ Name = "ADSSTATE_POWERGOOD" };
			ADSSTATE_ERROR = new BeckhoffUShort(this.GetADSSTATE_ERROR, client, 16448, 384168){ Name = "ADSSTATE_ERROR" };
			ADSSTATE_SHUTDOWN = new BeckhoffUShort(this.GetADSSTATE_SHUTDOWN, client, 16448, 384170){ Name = "ADSSTATE_SHUTDOWN" };
			ADSSTATE_SUSPEND = new BeckhoffUShort(this.GetADSSTATE_SUSPEND, client, 16448, 384172){ Name = "ADSSTATE_SUSPEND" };
			ADSSTATE_RESUME = new BeckhoffUShort(this.GetADSSTATE_RESUME, client, 16448, 384174){ Name = "ADSSTATE_RESUME" };
			ADSSTATE_CONFIG = new BeckhoffUShort(this.GetADSSTATE_CONFIG, client, 16448, 384176){ Name = "ADSSTATE_CONFIG" };
			ADSSTATE_RECONFIG = new BeckhoffUShort(this.GetADSSTATE_RECONFIG, client, 16448, 384178){ Name = "ADSSTATE_RECONFIG" };
			ADSSTATE_STOPPING = new BeckhoffUShort(this.GetADSSTATE_STOPPING, client, 16448, 384180){ Name = "ADSSTATE_STOPPING" };
			ADSSTATE_INCOMPATIBLE = new BeckhoffUShort(this.GetADSSTATE_INCOMPATIBLE, client, 16448, 384182){ Name = "ADSSTATE_INCOMPATIBLE" };
			ADSSTATE_EXCEPTION = new BeckhoffUShort(this.GetADSSTATE_EXCEPTION, client, 16448, 384184){ Name = "ADSSTATE_EXCEPTION" };
			ADSSTATE_MAXSTATES = new BeckhoffUShort(this.GetADSSTATE_MAXSTATES, client, 16448, 384186){ Name = "ADSSTATE_MAXSTATES" };
			ADSIGRP_SYMTAB = new BeckhoffUInt(this.GetADSIGRP_SYMTAB, client, 16448, 384188){ Name = "ADSIGRP_SYMTAB" };
			ADSIGRP_SYMNAME = new BeckhoffUInt(this.GetADSIGRP_SYMNAME, client, 16448, 384192){ Name = "ADSIGRP_SYMNAME" };
			ADSIGRP_SYMVAL = new BeckhoffUInt(this.GetADSIGRP_SYMVAL, client, 16448, 384196){ Name = "ADSIGRP_SYMVAL" };
			ADSIGRP_SYM_HNDBYNAME = new BeckhoffUInt(this.GetADSIGRP_SYM_HNDBYNAME, client, 16448, 384200){ Name = "ADSIGRP_SYM_HNDBYNAME" };
			ADSIGRP_SYM_VALBYNAME = new BeckhoffUInt(this.GetADSIGRP_SYM_VALBYNAME, client, 16448, 384204){ Name = "ADSIGRP_SYM_VALBYNAME" };
			ADSIGRP_SYM_VALBYHND = new BeckhoffUInt(this.GetADSIGRP_SYM_VALBYHND, client, 16448, 384208){ Name = "ADSIGRP_SYM_VALBYHND" };
			ADSIGRP_SYM_RELEASEHND = new BeckhoffUInt(this.GetADSIGRP_SYM_RELEASEHND, client, 16448, 384212){ Name = "ADSIGRP_SYM_RELEASEHND" };
			ADSIGRP_SYM_INFOBYNAME = new BeckhoffUInt(this.GetADSIGRP_SYM_INFOBYNAME, client, 16448, 384216){ Name = "ADSIGRP_SYM_INFOBYNAME" };
			ADSIGRP_SYM_VERSION = new BeckhoffUInt(this.GetADSIGRP_SYM_VERSION, client, 16448, 384220){ Name = "ADSIGRP_SYM_VERSION" };
			ADSIGRP_SYM_INFOBYNAMEEX = new BeckhoffUInt(this.GetADSIGRP_SYM_INFOBYNAMEEX, client, 16448, 384224){ Name = "ADSIGRP_SYM_INFOBYNAMEEX" };
			ADSIGRP_SYM_DOWNLOAD = new BeckhoffUInt(this.GetADSIGRP_SYM_DOWNLOAD, client, 16448, 384228){ Name = "ADSIGRP_SYM_DOWNLOAD" };
			ADSIGRP_SYM_UPLOAD = new BeckhoffUInt(this.GetADSIGRP_SYM_UPLOAD, client, 16448, 384232){ Name = "ADSIGRP_SYM_UPLOAD" };
			ADSIGRP_SYM_UPLOADINFO = new BeckhoffUInt(this.GetADSIGRP_SYM_UPLOADINFO, client, 16448, 384236){ Name = "ADSIGRP_SYM_UPLOADINFO" };
			ADSIGRP_SYMNOTE = new BeckhoffUInt(this.GetADSIGRP_SYMNOTE, client, 16448, 384240){ Name = "ADSIGRP_SYMNOTE" };
			ADSIGRP_IOIMAGE_RWIB = new BeckhoffUInt(this.GetADSIGRP_IOIMAGE_RWIB, client, 16448, 384244){ Name = "ADSIGRP_IOIMAGE_RWIB" };
			ADSIGRP_IOIMAGE_RWIX = new BeckhoffUInt(this.GetADSIGRP_IOIMAGE_RWIX, client, 16448, 384248){ Name = "ADSIGRP_IOIMAGE_RWIX" };
			ADSIGRP_IOIMAGE_RISIZE = new BeckhoffUInt(this.GetADSIGRP_IOIMAGE_RISIZE, client, 16448, 384252){ Name = "ADSIGRP_IOIMAGE_RISIZE" };
			ADSIGRP_IOIMAGE_RWOB = new BeckhoffUInt(this.GetADSIGRP_IOIMAGE_RWOB, client, 16448, 384256){ Name = "ADSIGRP_IOIMAGE_RWOB" };
			ADSIGRP_IOIMAGE_RWOX = new BeckhoffUInt(this.GetADSIGRP_IOIMAGE_RWOX, client, 16448, 384260){ Name = "ADSIGRP_IOIMAGE_RWOX" };
			ADSIGRP_IOIMAGE_ROSIZE = new BeckhoffUInt(this.GetADSIGRP_IOIMAGE_ROSIZE, client, 16448, 384264){ Name = "ADSIGRP_IOIMAGE_ROSIZE" };
			ADSIGRP_IOIMAGE_CLEARI = new BeckhoffUInt(this.GetADSIGRP_IOIMAGE_CLEARI, client, 16448, 384268){ Name = "ADSIGRP_IOIMAGE_CLEARI" };
			ADSIGRP_IOIMAGE_CLEARO = new BeckhoffUInt(this.GetADSIGRP_IOIMAGE_CLEARO, client, 16448, 384272){ Name = "ADSIGRP_IOIMAGE_CLEARO" };
			ADSIGRP_IOIMAGE_RWIOB = new BeckhoffUInt(this.GetADSIGRP_IOIMAGE_RWIOB, client, 16448, 384276){ Name = "ADSIGRP_IOIMAGE_RWIOB" };
			ADSIGRP_DEVICE_DATA = new BeckhoffUInt(this.GetADSIGRP_DEVICE_DATA, client, 16448, 384280){ Name = "ADSIGRP_DEVICE_DATA" };
			ADSIOFFS_DEVDATA_ADSSTATE = new BeckhoffUInt(this.GetADSIOFFS_DEVDATA_ADSSTATE, client, 16448, 384284){ Name = "ADSIOFFS_DEVDATA_ADSSTATE" };
			ADSIOFFS_DEVDATA_DEVSTATE = new BeckhoffUInt(this.GetADSIOFFS_DEVDATA_DEVSTATE, client, 16448, 384288){ Name = "ADSIOFFS_DEVDATA_DEVSTATE" };
			SYSTEMSERVICE_OPENCREATE = new BeckhoffUInt(this.GetSYSTEMSERVICE_OPENCREATE, client, 16448, 384292){ Name = "SYSTEMSERVICE_OPENCREATE" };
			SYSTEMSERVICE_OPENREAD = new BeckhoffUInt(this.GetSYSTEMSERVICE_OPENREAD, client, 16448, 384296){ Name = "SYSTEMSERVICE_OPENREAD" };
			SYSTEMSERVICE_OPENWRITE = new BeckhoffUInt(this.GetSYSTEMSERVICE_OPENWRITE, client, 16448, 384300){ Name = "SYSTEMSERVICE_OPENWRITE" };
			SYSTEMSERVICE_CREATEFILE = new BeckhoffUInt(this.GetSYSTEMSERVICE_CREATEFILE, client, 16448, 384304){ Name = "SYSTEMSERVICE_CREATEFILE" };
			SYSTEMSERVICE_CLOSEHANDLE = new BeckhoffUInt(this.GetSYSTEMSERVICE_CLOSEHANDLE, client, 16448, 384308){ Name = "SYSTEMSERVICE_CLOSEHANDLE" };
			SYSTEMSERVICE_FOPEN = new BeckhoffUInt(this.GetSYSTEMSERVICE_FOPEN, client, 16448, 384312){ Name = "SYSTEMSERVICE_FOPEN" };
			SYSTEMSERVICE_FCLOSE = new BeckhoffUInt(this.GetSYSTEMSERVICE_FCLOSE, client, 16448, 384316){ Name = "SYSTEMSERVICE_FCLOSE" };
			SYSTEMSERVICE_FREAD = new BeckhoffUInt(this.GetSYSTEMSERVICE_FREAD, client, 16448, 384320){ Name = "SYSTEMSERVICE_FREAD" };
			SYSTEMSERVICE_FWRITE = new BeckhoffUInt(this.GetSYSTEMSERVICE_FWRITE, client, 16448, 384324){ Name = "SYSTEMSERVICE_FWRITE" };
			SYSTEMSERVICE_FSEEK = new BeckhoffUInt(this.GetSYSTEMSERVICE_FSEEK, client, 16448, 384328){ Name = "SYSTEMSERVICE_FSEEK" };
			SYSTEMSERVICE_FTELL = new BeckhoffUInt(this.GetSYSTEMSERVICE_FTELL, client, 16448, 384332){ Name = "SYSTEMSERVICE_FTELL" };
			SYSTEMSERVICE_FGETS = new BeckhoffUInt(this.GetSYSTEMSERVICE_FGETS, client, 16448, 384336){ Name = "SYSTEMSERVICE_FGETS" };
			SYSTEMSERVICE_FPUTS = new BeckhoffUInt(this.GetSYSTEMSERVICE_FPUTS, client, 16448, 384340){ Name = "SYSTEMSERVICE_FPUTS" };
			SYSTEMSERVICE_FSCANF = new BeckhoffUInt(this.GetSYSTEMSERVICE_FSCANF, client, 16448, 384344){ Name = "SYSTEMSERVICE_FSCANF" };
			SYSTEMSERVICE_FPRINTF = new BeckhoffUInt(this.GetSYSTEMSERVICE_FPRINTF, client, 16448, 384348){ Name = "SYSTEMSERVICE_FPRINTF" };
			SYSTEMSERVICE_FEOF = new BeckhoffUInt(this.GetSYSTEMSERVICE_FEOF, client, 16448, 384352){ Name = "SYSTEMSERVICE_FEOF" };
			SYSTEMSERVICE_FDELETE = new BeckhoffUInt(this.GetSYSTEMSERVICE_FDELETE, client, 16448, 384356){ Name = "SYSTEMSERVICE_FDELETE" };
			SYSTEMSERVICE_FRENAME = new BeckhoffUInt(this.GetSYSTEMSERVICE_FRENAME, client, 16448, 384360){ Name = "SYSTEMSERVICE_FRENAME" };
			SYSTEMSERVICE_MKDIR = new BeckhoffUInt(this.GetSYSTEMSERVICE_MKDIR, client, 16448, 384364){ Name = "SYSTEMSERVICE_MKDIR" };
			SYSTEMSERVICE_RMDIR = new BeckhoffUInt(this.GetSYSTEMSERVICE_RMDIR, client, 16448, 384368){ Name = "SYSTEMSERVICE_RMDIR" };
			SYSTEMSERVICE_REG_HKEYLOCALMACHINE = new BeckhoffUInt(this.GetSYSTEMSERVICE_REG_HKEYLOCALMACHINE, client, 16448, 384372){ Name = "SYSTEMSERVICE_REG_HKEYLOCALMACHINE" };
			SYSTEMSERVICE_SENDEMAIL = new BeckhoffUInt(this.GetSYSTEMSERVICE_SENDEMAIL, client, 16448, 384376){ Name = "SYSTEMSERVICE_SENDEMAIL" };
			SYSTEMSERVICE_TIMESERVICES = new BeckhoffUInt(this.GetSYSTEMSERVICE_TIMESERVICES, client, 16448, 384380){ Name = "SYSTEMSERVICE_TIMESERVICES" };
			SYSTEMSERVICE_STARTPROCESS = new BeckhoffUInt(this.GetSYSTEMSERVICE_STARTPROCESS, client, 16448, 384384){ Name = "SYSTEMSERVICE_STARTPROCESS" };
			SYSTEMSERVICE_CHANGENETID = new BeckhoffUInt(this.GetSYSTEMSERVICE_CHANGENETID, client, 16448, 384388){ Name = "SYSTEMSERVICE_CHANGENETID" };
			TIMESERVICE_DATEANDTIME = new BeckhoffUInt(this.GetTIMESERVICE_DATEANDTIME, client, 16448, 384392){ Name = "TIMESERVICE_DATEANDTIME" };
			TIMESERVICE_SYSTEMTIMES = new BeckhoffUInt(this.GetTIMESERVICE_SYSTEMTIMES, client, 16448, 384396){ Name = "TIMESERVICE_SYSTEMTIMES" };
			TIMESERVICE_RTCTIMEDIFF = new BeckhoffUInt(this.GetTIMESERVICE_RTCTIMEDIFF, client, 16448, 384400){ Name = "TIMESERVICE_RTCTIMEDIFF" };
			TIMESERVICE_ADJUSTTIMETORTC = new BeckhoffUInt(this.GetTIMESERVICE_ADJUSTTIMETORTC, client, 16448, 384404){ Name = "TIMESERVICE_ADJUSTTIMETORTC" };
			TIMESERVICE_TIMEZONINFORMATION = new BeckhoffUInt(this.GetTIMESERVICE_TIMEZONINFORMATION, client, 16448, 384408){ Name = "TIMESERVICE_TIMEZONINFORMATION" };
			ADSLOG_MSGTYPE_HINT = new BeckhoffInt(this.GetADSLOG_MSGTYPE_HINT, client, 16448, 384412){ Name = "ADSLOG_MSGTYPE_HINT" };
			ADSLOG_MSGTYPE_WARN = new BeckhoffInt(this.GetADSLOG_MSGTYPE_WARN, client, 16448, 384416){ Name = "ADSLOG_MSGTYPE_WARN" };
			ADSLOG_MSGTYPE_ERROR = new BeckhoffInt(this.GetADSLOG_MSGTYPE_ERROR, client, 16448, 384420){ Name = "ADSLOG_MSGTYPE_ERROR" };
			ADSLOG_MSGTYPE_LOG = new BeckhoffInt(this.GetADSLOG_MSGTYPE_LOG, client, 16448, 384424){ Name = "ADSLOG_MSGTYPE_LOG" };
			ADSLOG_MSGTYPE_MSGBOX = new BeckhoffInt(this.GetADSLOG_MSGTYPE_MSGBOX, client, 16448, 384428){ Name = "ADSLOG_MSGTYPE_MSGBOX" };
			ADSLOG_MSGTYPE_RESOURCE = new BeckhoffInt(this.GetADSLOG_MSGTYPE_RESOURCE, client, 16448, 384432){ Name = "ADSLOG_MSGTYPE_RESOURCE" };
			ADSLOG_MSGTYPE_STRING = new BeckhoffInt(this.GetADSLOG_MSGTYPE_STRING, client, 16448, 384436){ Name = "ADSLOG_MSGTYPE_STRING" };
			BOOTDATAFLAGS_RETAIN_LOADED = new BeckhoffByte(this.GetBOOTDATAFLAGS_RETAIN_LOADED, client, 16448, 384440){ Name = "BOOTDATAFLAGS_RETAIN_LOADED" };
			BOOTDATAFLAGS_RETAIN_INVALID = new BeckhoffByte(this.GetBOOTDATAFLAGS_RETAIN_INVALID, client, 16448, 384441){ Name = "BOOTDATAFLAGS_RETAIN_INVALID" };
			BOOTDATAFLAGS_RETAIN_REQUESTED = new BeckhoffByte(this.GetBOOTDATAFLAGS_RETAIN_REQUESTED, client, 16448, 384442){ Name = "BOOTDATAFLAGS_RETAIN_REQUESTED" };
			BOOTDATAFLAGS_PERSISTENT_LOADED = new BeckhoffByte(this.GetBOOTDATAFLAGS_PERSISTENT_LOADED, client, 16448, 384443){ Name = "BOOTDATAFLAGS_PERSISTENT_LOADED" };
			BOOTDATAFLAGS_PERSISTENT_INVALID = new BeckhoffByte(this.GetBOOTDATAFLAGS_PERSISTENT_INVALID, client, 16448, 384444){ Name = "BOOTDATAFLAGS_PERSISTENT_INVALID" };
			SYSTEMSTATEFLAGS_BSOD = new BeckhoffByte(this.GetSYSTEMSTATEFLAGS_BSOD, client, 16448, 384445){ Name = "SYSTEMSTATEFLAGS_BSOD" };
			SYSTEMSTATEFLAGS_RTVIOLATION = new BeckhoffByte(this.GetSYSTEMSTATEFLAGS_RTVIOLATION, client, 16448, 384446){ Name = "SYSTEMSTATEFLAGS_RTVIOLATION" };
			nWatchdogTime = new BeckhoffByte(this.GetnWatchdogTime, client, 16448, 384447){ Name = "nWatchdogTime" };
			FOPEN_MODEREAD = new BeckhoffInt(this.GetFOPEN_MODEREAD, client, 16448, 384448){ Name = "FOPEN_MODEREAD" };
			FOPEN_MODEWRITE = new BeckhoffInt(this.GetFOPEN_MODEWRITE, client, 16448, 384452){ Name = "FOPEN_MODEWRITE" };
			FOPEN_MODEAPPEND = new BeckhoffInt(this.GetFOPEN_MODEAPPEND, client, 16448, 384456){ Name = "FOPEN_MODEAPPEND" };
			FOPEN_MODEPLUS = new BeckhoffInt(this.GetFOPEN_MODEPLUS, client, 16448, 384460){ Name = "FOPEN_MODEPLUS" };
			FOPEN_MODEBINARY = new BeckhoffInt(this.GetFOPEN_MODEBINARY, client, 16448, 384464){ Name = "FOPEN_MODEBINARY" };
			FOPEN_MODETEXT = new BeckhoffInt(this.GetFOPEN_MODETEXT, client, 16448, 384468){ Name = "FOPEN_MODETEXT" };
			TCEVENTFLAG_PRIOCLASS = new BeckhoffShort(this.GetTCEVENTFLAG_PRIOCLASS, client, 16448, 384500){ Name = "TCEVENTFLAG_PRIOCLASS" };
			TCEVENTFLAG_FMTSELF = new BeckhoffShort(this.GetTCEVENTFLAG_FMTSELF, client, 16448, 384502){ Name = "TCEVENTFLAG_FMTSELF" };
			TCEVENTFLAG_LOG = new BeckhoffShort(this.GetTCEVENTFLAG_LOG, client, 16448, 384504){ Name = "TCEVENTFLAG_LOG" };
			TCEVENTFLAG_MSGBOX = new BeckhoffShort(this.GetTCEVENTFLAG_MSGBOX, client, 16448, 384506){ Name = "TCEVENTFLAG_MSGBOX" };
			TCEVENTFLAG_SRCID = new BeckhoffShort(this.GetTCEVENTFLAG_SRCID, client, 16448, 384508){ Name = "TCEVENTFLAG_SRCID" };
			TCEVENTFLAG_AUTOFMTALL = new BeckhoffShort(this.GetTCEVENTFLAG_AUTOFMTALL, client, 16448, 384510){ Name = "TCEVENTFLAG_AUTOFMTALL" };
			TCEVENTSTATE_INVALID = new BeckhoffShort(this.GetTCEVENTSTATE_INVALID, client, 16448, 384512){ Name = "TCEVENTSTATE_INVALID" };
			TCEVENTSTATE_SIGNALED = new BeckhoffShort(this.GetTCEVENTSTATE_SIGNALED, client, 16448, 384514){ Name = "TCEVENTSTATE_SIGNALED" };
			TCEVENTSTATE_RESET = new BeckhoffShort(this.GetTCEVENTSTATE_RESET, client, 16448, 384516){ Name = "TCEVENTSTATE_RESET" };
			TCEVENTSTATE_CONFIRMED = new BeckhoffShort(this.GetTCEVENTSTATE_CONFIRMED, client, 16448, 384518){ Name = "TCEVENTSTATE_CONFIRMED" };
			TCEVENTSTATE_RESETCON = new BeckhoffShort(this.GetTCEVENTSTATE_RESETCON, client, 16448, 384520){ Name = "TCEVENTSTATE_RESETCON" };
			TCEVENT_SRCNAMESIZE = new BeckhoffShort(this.GetTCEVENT_SRCNAMESIZE, client, 16448, 384522){ Name = "TCEVENT_SRCNAMESIZE" };
			TCEVENT_FMTPRGSIZE = new BeckhoffShort(this.GetTCEVENT_FMTPRGSIZE, client, 16448, 384524){ Name = "TCEVENT_FMTPRGSIZE" };
			eWatchdogConfig = new BeckhoffEnum<Tc2_System_E_WATCHDOG_TIME_CONFIG>(this.GeteWatchdogConfig, client, 16448, 384526){ Name = "eWatchdogConfig" };
			PI = new BeckhoffDouble(this.GetPI, client, 16448, 384528){ Name = "PI" };
			DEFAULT_ADS_TIMEOUT = new BeckhoffUInt(this.GetDEFAULT_ADS_TIMEOUT, client, 16448, 384536){ Name = "DEFAULT_ADS_TIMEOUT" };
			MAX_STRING_LENGTH = new BeckhoffUInt(this.GetMAX_STRING_LENGTH, client, 16448, 384540){ Name = "MAX_STRING_LENGTH" };
			TcMcGlobal = new Tc2_MC2__TCMCGLOBALWrapper(this.GetTcMcGlobal, client, 16448, 384736)
			{
				Name = "TcMcGlobal",
				NCPORT_TCMC = new BeckhoffUShort(this.GetTcMcGlobal_Dot_NCPORT_TCMC, client, 16448, 384744){ Name = "NCPORT_TCMC" },
				NCPORT_TCMC_COUPLING = new BeckhoffUShort(this.GetTcMcGlobal_Dot_NCPORT_TCMC_COUPLING, client, 16448, 384746){ Name = "NCPORT_TCMC_COUPLING" },
				NCNETID_TCMC = new BeckhoffString<String24>(this.GetTcMcGlobal_Dot_NCNETID_TCMC, client, 16448, 384748){ Name = "NCNETID_TCMC" },
				NCPORT_TCMC_CAM = new BeckhoffUShort(this.GetTcMcGlobal_Dot_NCPORT_TCMC_CAM, client, 16448, 384772){ Name = "NCPORT_TCMC_CAM" },
				NCPORT_TCMC_CAM_FAST = new BeckhoffUShort(this.GetTcMcGlobal_Dot_NCPORT_TCMC_CAM_FAST, client, 16448, 384774){ Name = "NCPORT_TCMC_CAM_FAST" },
				NCNETID_TCMC_CAM = new BeckhoffString<String24>(this.GetTcMcGlobal_Dot_NCNETID_TCMC_CAM, client, 16448, 384776){ Name = "NCNETID_TCMC_CAM" },
				NCPORT_TCMC_SUPERPOSITION = new BeckhoffUShort(this.GetTcMcGlobal_Dot_NCPORT_TCMC_SUPERPOSITION, client, 16448, 384800){ Name = "NCPORT_TCMC_SUPERPOSITION" },
				NCPORT_TCMC_RESET = new BeckhoffUShort(this.GetTcMcGlobal_Dot_NCPORT_TCMC_RESET, client, 16448, 384802){ Name = "NCPORT_TCMC_RESET" },
				NcDeviceInfoTcMainVersion = new BeckhoffInt(this.GetTcMcGlobal_Dot_NcDeviceInfoTcMainVersion, client, 16448, 384804){ Name = "NcDeviceInfoTcMainVersion" },
				NcDeviceInfoTcSubVersion = new BeckhoffInt(this.GetTcMcGlobal_Dot_NcDeviceInfoTcSubVersion, client, 16448, 384808){ Name = "NcDeviceInfoTcSubVersion" },
				NcDeviceInfoNcDriverVersion = new BeckhoffInt(this.GetTcMcGlobal_Dot_NcDeviceInfoNcDriverVersion, client, 16448, 384812){ Name = "NcDeviceInfoNcDriverVersion" },
				NcDeviceInfoNcVersion = new BeckhoffInt(this.GetTcMcGlobal_Dot_NcDeviceInfoNcVersion, client, 16448, 384816){ Name = "NcDeviceInfoNcVersion" },
				NcDeviceInfoNcName = new BeckhoffString<String20>(this.GetTcMcGlobal_Dot_NcDeviceInfoNcName, client, 16448, 384820){ Name = "NcDeviceInfoNcName" },
				Axis = new Tc2_MC2__ST_NCADS_AxisWrapper(this.GetTcMcGlobal_Dot_Axis, client, 16448, 384840)
				{
					Name = "Axis",
					Parameter = new Tc2_MC2__ST_NCADS_AxisParameterWrapper(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter, client, 16448, 384840)
					{
						Name = "Parameter",
						IDXGRP = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXGRP, client, 16448, 384840){ Name = "IDXGRP" },
						IDXOFFS = new Tc2_MC2__ST_NCADS_IDXOFFS_AxisParameterWrapper(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS, client, 16448, 384844)
						{
							Name = "IDXOFFS",
							PARAMSTRUCT = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_PARAMSTRUCT, client, 16448, 384844){ Name = "PARAMSTRUCT" },
							ID = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_ID, client, 16448, 384848){ Name = "ID" },
							NAME = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_NAME, client, 16448, 384852){ Name = "NAME" },
							AXISTYPE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_AXISTYPE, client, 16448, 384856){ Name = "AXISTYPE" },
							CYCLETIME = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_CYCLETIME, client, 16448, 384860){ Name = "CYCLETIME" },
							UNITNAME = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_UNITNAME, client, 16448, 384864){ Name = "UNITNAME" },
							VELOREFSEARCH = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_VELOREFSEARCH, client, 16448, 384868){ Name = "VELOREFSEARCH" },
							VELOSYNCSEARCH = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_VELOSYNCSEARCH, client, 16448, 384872){ Name = "VELOSYNCSEARCH" },
							VELOSLOWMANUAL = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_VELOSLOWMANUAL, client, 16448, 384876){ Name = "VELOSLOWMANUAL" },
							VELOFASTMANUAL = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_VELOFASTMANUAL, client, 16448, 384880){ Name = "VELOFASTMANUAL" },
							VELOFAST = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_VELOFAST, client, 16448, 384884){ Name = "VELOFAST" },
							POSAREAENABLE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_POSAREAENABLE, client, 16448, 384888){ Name = "POSAREAENABLE" },
							POSAREARANGE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_POSAREARANGE, client, 16448, 384892){ Name = "POSAREARANGE" },
							MOTCNTRLENABLE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_MOTCNTRLENABLE, client, 16448, 384896){ Name = "MOTCNTRLENABLE" },
							MOTCNTRLTIME = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_MOTCNTRLTIME, client, 16448, 384900){ Name = "MOTCNTRLTIME" },
							LOOPENABLE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_LOOPENABLE, client, 16448, 384904){ Name = "LOOPENABLE" },
							LOOPDISTANCE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_LOOPDISTANCE, client, 16448, 384908){ Name = "LOOPDISTANCE" },
							TARGETPOSENA = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_TARGETPOSENA, client, 16448, 384912){ Name = "TARGETPOSENA" },
							TARGETPOSRANGE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_TARGETPOSRANGE, client, 16448, 384916){ Name = "TARGETPOSRANGE" },
							TARGETPOSTIME = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_TARGETPOSTIME, client, 16448, 384920){ Name = "TARGETPOSTIME" },
							PULSDISTPOS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_PULSDISTPOS, client, 16448, 384924){ Name = "PULSDISTPOS" },
							PULSDISTNEG = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_PULSDISTNEG, client, 16448, 384928){ Name = "PULSDISTNEG" },
							FADINGACCELERATION = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_FADINGACCELERATION, client, 16448, 384932){ Name = "FADINGACCELERATION" },
							FASTAXISSTOPSIGNALTYPE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_FASTAXISSTOPSIGNALTYPE, client, 16448, 384936){ Name = "FASTAXISSTOPSIGNALTYPE" },
							UNITFLAGS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_UNITFLAGS, client, 16448, 384940){ Name = "UNITFLAGS" },
							VELOMAXIMUM = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_VELOMAXIMUM, client, 16448, 384944){ Name = "VELOMAXIMUM" },
							MOTCNTRLRANGE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_MOTCNTRLRANGE, client, 16448, 384948){ Name = "MOTCNTRLRANGE" },
							PEHCONTROLENA = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_PEHCONTROLENA, client, 16448, 384952){ Name = "PEHCONTROLENA" },
							PEHCONTROLTIME = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_PEHCONTROLTIME, client, 16448, 384956){ Name = "PEHCONTROLTIME" },
							BACKLASHCOMPENA = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_BACKLASHCOMPENA, client, 16448, 384960){ Name = "BACKLASHCOMPENA" },
							BACKLASH = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_BACKLASH, client, 16448, 384964){ Name = "BACKLASH" },
							DATAPERSISTENCE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_DATAPERSISTENCE, client, 16448, 384968){ Name = "DATAPERSISTENCE" },
							HWAMSADDR = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_HWAMSADDR, client, 16448, 384972){ Name = "HWAMSADDR" },
							HWCHNNO = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_HWCHNNO, client, 16448, 384976){ Name = "HWCHNNO" },
							APPLICATIONREQUEST = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_APPLICATIONREQUEST, client, 16448, 384980){ Name = "APPLICATIONREQUEST" },
							ACC = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_ACC, client, 16448, 384984){ Name = "ACC" },
							DEC = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_DEC, client, 16448, 384988){ Name = "DEC" },
							JERK = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_JERK, client, 16448, 384992){ Name = "JERK" },
							DELAY = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_DELAY, client, 16448, 384996){ Name = "DELAY" },
							OVERRIDETYPE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_OVERRIDETYPE, client, 16448, 385000){ Name = "OVERRIDETYPE" },
							VELOJUMPFACTOR = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_VELOJUMPFACTOR, client, 16448, 385004){ Name = "VELOJUMPFACTOR" },
							REDUCTIONFEEDBACK = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_REDUCTIONFEEDBACK, client, 16448, 385008){ Name = "REDUCTIONFEEDBACK" },
							TOLERANCEBALLAUXAXIS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_TOLERANCEBALLAUXAXIS, client, 16448, 385012){ Name = "TOLERANCEBALLAUXAXIS" },
							MAXPOSDEVIATIONAUXAXIS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_MAXPOSDEVIATIONAUXAXIS, client, 16448, 385016){ Name = "MAXPOSDEVIATIONAUXAXIS" },
							FASTACC = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_FASTACC, client, 16448, 385020){ Name = "FASTACC" },
							FASTDEC = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_FASTDEC, client, 16448, 385024){ Name = "FASTDEC" },
							FASTJERK = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_FASTJERK, client, 16448, 385028){ Name = "FASTJERK" },
							REF_POS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_REF_POS, client, 16448, 385032){ Name = "REF_POS" },
							ENCSEARCHDIR = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_ENCSEARCHDIR, client, 16448, 385036){ Name = "ENCSEARCHDIR" },
							ENCSYNCDIR = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_ENCSYNCDIR, client, 16448, 385040){ Name = "ENCSYNCDIR" },
							ENCREFMODE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Parameter_Dot_IDXOFFS_Dot_ENCREFMODE, client, 16448, 385044){ Name = "ENCREFMODE" },
						},
					},
					State = new Tc2_MC2__ST_NCADS_AxisStateWrapper(this.GetTcMcGlobal_Dot_Axis_Dot_State, client, 16448, 385048)
					{
						Name = "State",
						IDXGRP = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXGRP, client, 16448, 385048){ Name = "IDXGRP" },
						IDXOFFS = new Tc2_MC2__ST_NCADS_IDXOFFS_AxisStateWrapper(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS, client, 16448, 385052)
						{
							Name = "IDXOFFS",
							ONLINESTRUCT = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_ONLINESTRUCT, client, 16448, 385052){ Name = "ONLINESTRUCT" },
							ERROR = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_ERROR, client, 16448, 385056){ Name = "ERROR" },
							SETTASKCYCLE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_SETTASKCYCLE, client, 16448, 385060){ Name = "SETTASKCYCLE" },
							SETPOS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_SETPOS, client, 16448, 385064){ Name = "SETPOS" },
							SETVELO = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_SETVELO, client, 16448, 385068){ Name = "SETVELO" },
							SETACC = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_SETACC, client, 16448, 385072){ Name = "SETACC" },
							MODULOSETPOS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_MODULOSETPOS, client, 16448, 385076){ Name = "MODULOSETPOS" },
							MODULOSETTURNS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_MODULOSETTURNS, client, 16448, 385080){ Name = "MODULOSETTURNS" },
							SETDIR = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_SETDIR, client, 16448, 385084){ Name = "SETDIR" },
							TARGETPOSITION = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_TARGETPOSITION, client, 16448, 385088){ Name = "TARGETPOSITION" },
							REMAININGTIMEANDPOS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_REMAININGTIMEANDPOS, client, 16448, 385092){ Name = "REMAININGTIMEANDPOS" },
							STOPINFORMATION = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_STOPINFORMATION, client, 16448, 385096){ Name = "STOPINFORMATION" },
							SETTASKCYCLE_WITHOUTCORR = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_SETTASKCYCLE_WITHOUTCORR, client, 16448, 385100){ Name = "SETTASKCYCLE_WITHOUTCORR" },
							SETPOS_WITHOUTCORR = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_SETPOS_WITHOUTCORR, client, 16448, 385104){ Name = "SETPOS_WITHOUTCORR" },
							SETVELO_WITHOUTCORR = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_SETVELO_WITHOUTCORR, client, 16448, 385108){ Name = "SETVELO_WITHOUTCORR" },
							SETACC_WITHOUTCORR = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_SETACC_WITHOUTCORR, client, 16448, 385112){ Name = "SETACC_WITHOUTCORR" },
							SETDIR_WITHOUTCORR = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_SETDIR_WITHOUTCORR, client, 16448, 385116){ Name = "SETDIR_WITHOUTCORR" },
							COUPLESTATE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_COUPLESTATE, client, 16448, 385120){ Name = "COUPLESTATE" },
							CPLPARAMS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_CPLPARAMS, client, 16448, 385124){ Name = "CPLPARAMS" },
							CPLFACTOR = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_CPLFACTOR, client, 16448, 385128){ Name = "CPLFACTOR" },
							AXISCTRLLOOPIDX = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_AXISCTRLLOOPIDX, client, 16448, 385132){ Name = "AXISCTRLLOOPIDX" },
							AXISSETPOINTGENIDX = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_AXISSETPOINTGENIDX, client, 16448, 385136){ Name = "AXISSETPOINTGENIDX" },
							CPLCHARACVALUES = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_CPLCHARACVALUES, client, 16448, 385140){ Name = "CPLCHARACVALUES" },
							CAMINFO = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_CAMINFO, client, 16448, 385144){ Name = "CAMINFO" },
							CAMSTATUS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_CAMSTATUS, client, 16448, 385148){ Name = "CAMSTATUS" },
							ENCODERINITIALIZATIONDONE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_State_Dot_IDXOFFS_Dot_ENCODERINITIALIZATIONDONE, client, 16448, 385152){ Name = "ENCODERINITIALIZATIONDONE" },
						},
					},
					Functions = new Tc2_MC2__ST_NCADS_AxisFunctionsWrapper(this.GetTcMcGlobal_Dot_Axis_Dot_Functions, client, 16448, 385156)
					{
						Name = "Functions",
						IDXGRP = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXGRP, client, 16448, 385156){ Name = "IDXGRP" },
						IDXOFFS = new Tc2_MC2__ST_NCADS_IDXOFFS_AxisFunctionsWrapper(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS, client, 16448, 385160)
						{
							Name = "IDXOFFS",
							RESET = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_RESET, client, 16448, 385160){ Name = "RESET" },
							STOP = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_STOP, client, 16448, 385164){ Name = "STOP" },
							CLEAR = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_CLEAR, client, 16448, 385168){ Name = "CLEAR" },
							EMERGENCYSTOP = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_EMERGENCYSTOP, client, 16448, 385172){ Name = "EMERGENCYSTOP" },
							PARAMETRIZEDSTOP = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_PARAMETRIZEDSTOP, client, 16448, 385176){ Name = "PARAMETRIZEDSTOP" },
							INITIALIZE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_INITIALIZE, client, 16448, 385180){ Name = "INITIALIZE" },
							ORIENTEDSTOP = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_ORIENTEDSTOP, client, 16448, 385184){ Name = "ORIENTEDSTOP" },
							CALIBR = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_CALIBR, client, 16448, 385188){ Name = "CALIBR" },
							NEWTARGPOS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_NEWTARGPOS, client, 16448, 385192){ Name = "NEWTARGPOS" },
							NEWTARGPOSANDVELO = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_NEWTARGPOSANDVELO, client, 16448, 385196){ Name = "NEWTARGPOSANDVELO" },
							CHANGEDYNAMICPARAM = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_CHANGEDYNAMICPARAM, client, 16448, 385200){ Name = "CHANGEDYNAMICPARAM" },
							UNIVERSALSTART = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_UNIVERSALSTART, client, 16448, 385204){ Name = "UNIVERSALSTART" },
							SLAVEUNIVERSALSTART = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_SLAVEUNIVERSALSTART, client, 16448, 385208){ Name = "SLAVEUNIVERSALSTART" },
							RELEASEAXISLOCK = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_RELEASEAXISLOCK, client, 16448, 385212){ Name = "RELEASEAXISLOCK" },
							SETEXTERNALERROR = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_SETEXTERNALERROR, client, 16448, 385216){ Name = "SETEXTERNALERROR" },
							SETPOS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_SETPOS, client, 16448, 385220){ Name = "SETPOS" },
							SETCALFLAG = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_SETCALFLAG, client, 16448, 385224){ Name = "SETCALFLAG" },
							SETACTPOS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_SETACTPOS, client, 16448, 385228){ Name = "SETACTPOS" },
							SETDRIVEPOS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_SETDRIVEPOS, client, 16448, 385232){ Name = "SETDRIVEPOS" },
							SETENCODERSCALING = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_SETENCODERSCALING, client, 16448, 385236){ Name = "SETENCODERSCALING" },
							SETPOSONTHEFLY = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_SETPOSONTHEFLY, client, 16448, 385240){ Name = "SETPOSONTHEFLY" },
							START = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_START, client, 16448, 385244){ Name = "START" },
							STARTEXT = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_STARTEXT, client, 16448, 385248){ Name = "STARTEXT" },
							STARTVELOCHANGE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_STARTVELOCHANGE, client, 16448, 385252){ Name = "STARTVELOCHANGE" },
							ENABLEEXTGEN = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_ENABLEEXTGEN, client, 16448, 385256){ Name = "ENABLEEXTGEN" },
							DISABLEEXTGEN = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_DISABLEEXTGEN, client, 16448, 385260){ Name = "DISABLEEXTGEN" },
							REVERSINGSEQUENCE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_REVERSINGSEQUENCE, client, 16448, 385264){ Name = "REVERSINGSEQUENCE" },
							STARTDRVOUT = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_STARTDRVOUT, client, 16448, 385268){ Name = "STARTDRVOUT" },
							STOPDRVOUT = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_STOPDRVOUT, client, 16448, 385272){ Name = "STOPDRVOUT" },
							CHANGEDRVOUT = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_CHANGEDRVOUT, client, 16448, 385276){ Name = "CHANGEDRVOUT" },
							JUMPTOOVERRIDE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_JUMPTOOVERRIDE, client, 16448, 385280){ Name = "JUMPTOOVERRIDE" },
							EXTSETGENUNIVERSALSTART = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_EXTSETGENUNIVERSALSTART, client, 16448, 385284){ Name = "EXTSETGENUNIVERSALSTART" },
							UNIVERSALTORQUESTART = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_UNIVERSALTORQUESTART, client, 16448, 385288){ Name = "UNIVERSALTORQUESTART" },
							STARTSCOM = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_STARTSCOM, client, 16448, 385292){ Name = "STARTSCOM" },
							STOPSCOM = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_STOPSCOM, client, 16448, 385296){ Name = "STOPSCOM" },
							PHASINGREQEUST = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_PHASINGREQEUST, client, 16448, 385300){ Name = "PHASINGREQEUST" },
							REINITIALIZEENCODER = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_REINITIALIZEENCODER, client, 16448, 385304){ Name = "REINITIALIZEENCODER" },
							CPL = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_CPL, client, 16448, 385308){ Name = "CPL" },
							DECPL = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_DECPL, client, 16448, 385312){ Name = "DECPL" },
							CPLCHANGE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_CPLCHANGE, client, 16448, 385316){ Name = "CPLCHANGE" },
							TABCPLCHANGE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_TABCPLCHANGE, client, 16448, 385320){ Name = "TABCPLCHANGE" },
							STOPSLAVE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_STOPSLAVE, client, 16448, 385324){ Name = "STOPSLAVE" },
							CPLTAB = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_CPLTAB, client, 16448, 385328){ Name = "CPLTAB" },
							TABSLVACTIVCOR = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_TABSLVACTIVCOR, client, 16448, 385332){ Name = "TABSLVACTIVCOR" },
							TABSLVLEAVECYC = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_TABSLVLEAVECYC, client, 16448, 385336){ Name = "TABSLVLEAVECYC" },
							TABSLVCOROFFSET = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_TABSLVCOROFFSET, client, 16448, 385340){ Name = "TABSLVCOROFFSET" },
							TABSLVSCALING = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_TABSLVSCALING, client, 16448, 385344){ Name = "TABSLVSCALING" },
							CPLSOLOTAB = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_CPLSOLOTAB, client, 16448, 385348){ Name = "CPLSOLOTAB" },
							CPLSYNCHRONIZING = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_CPLSYNCHRONIZING, client, 16448, 385352){ Name = "CPLSYNCHRONIZING" },
							CAMSCALING = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_CAMSCALING, client, 16448, 385356){ Name = "CAMSCALING" },
							DISABLE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_DISABLE, client, 16448, 385360){ Name = "DISABLE" },
							ENABLE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_ENABLE, client, 16448, 385364){ Name = "ENABLE" },
							CHANGEAXISCTRLLOOP = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_CHANGEAXISCTRLLOOP, client, 16448, 385368){ Name = "CHANGEAXISCTRLLOOP" },
							DRIVEDISABLE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_DRIVEDISABLE, client, 16448, 385372){ Name = "DRIVEDISABLE" },
							DRIVEENABLE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_DRIVEENABLE, client, 16448, 385376){ Name = "DRIVEENABLE" },
							RELEASEBRAKE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_RELEASEBRAKE, client, 16448, 385380){ Name = "RELEASEBRAKE" },
							RECONFIGURATE = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Axis_Dot_Functions_Dot_IDXOFFS_Dot_RECONFIGURATE, client, 16448, 385384){ Name = "RECONFIGURATE" },
						},
					},
				},
				Table = new Tc2_MC2__ST_NCADS_TableWrapper(this.GetTcMcGlobal_Dot_Table, client, 16448, 385388)
				{
					Name = "Table",
					Parameter = new Tc2_MC2__ST_NCADS_TableParameterWrapper(this.GetTcMcGlobal_Dot_Table_Dot_Parameter, client, 16448, 385388)
					{
						Name = "Parameter",
						IDXGRP = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Table_Dot_Parameter_Dot_IDXGRP, client, 16448, 385388){ Name = "IDXGRP" },
						IDXOFFS = new Tc2_MC2__ST_NCADS_IDXOFFS_TableParameterWrapper(this.GetTcMcGlobal_Dot_Table_Dot_Parameter_Dot_IDXOFFS, client, 16448, 385392)
						{
							Name = "IDXOFFS",
							MFREADCHARACVALUES = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Table_Dot_Parameter_Dot_IDXOFFS_Dot_MFREADCHARACVALUES, client, 16448, 385392){ Name = "MFREADCHARACVALUES" },
							WRITETABROWS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Table_Dot_Parameter_Dot_IDXOFFS_Dot_WRITETABROWS, client, 16448, 385396){ Name = "WRITETABROWS" },
							WRITEMFTABROWS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Table_Dot_Parameter_Dot_IDXOFFS_Dot_WRITEMFTABROWS, client, 16448, 385400){ Name = "WRITEMFTABROWS" },
							MFREADTAB = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Table_Dot_Parameter_Dot_IDXOFFS_Dot_MFREADTAB, client, 16448, 385404){ Name = "MFREADTAB" },
							READSLAVEDYNAMICS = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Table_Dot_Parameter_Dot_IDXOFFS_Dot_READSLAVEDYNAMICS, client, 16448, 385408){ Name = "READSLAVEDYNAMICS" },
							READMASTERPOSITION = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Table_Dot_Parameter_Dot_IDXOFFS_Dot_READMASTERPOSITION, client, 16448, 385412){ Name = "READMASTERPOSITION" },
						},
					},
					Functions = new Tc2_MC2__ST_NCADS_TableFunctionsWrapper(this.GetTcMcGlobal_Dot_Table_Dot_Functions, client, 16448, 385416)
					{
						Name = "Functions",
						IDXGRP = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Table_Dot_Functions_Dot_IDXGRP, client, 16448, 385416){ Name = "IDXGRP" },
						IDXOFFS = new Tc2_MC2__ST_NCADS_IDXOFFS_TableFunctionsWrapper(this.GetTcMcGlobal_Dot_Table_Dot_Functions_Dot_IDXOFFS, client, 16448, 385420)
						{
							Name = "IDXOFFS",
							CREATETAB = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Table_Dot_Functions_Dot_IDXOFFS_Dot_CREATETAB, client, 16448, 385420){ Name = "CREATETAB" },
							CREATEMOTIONTAB = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Table_Dot_Functions_Dot_IDXOFFS_Dot_CREATEMOTIONTAB, client, 16448, 385424){ Name = "CREATEMOTIONTAB" },
							DELETETAB = new BeckhoffUInt(this.GetTcMcGlobal_Dot_Table_Dot_Functions_Dot_IDXOFFS_Dot_DELETETAB, client, 16448, 385428){ Name = "DELETETAB" },
						},
					},
				},
				NCPORT_TCNCCAMMING_TABLEFUNCTION = new BeckhoffUShort(this.GetTcMcGlobal_Dot_NCPORT_TCNCCAMMING_TABLEFUNCTION, client, 16448, 385432){ Name = "NCPORT_TCNCCAMMING_TABLEFUNCTION" },
				tTargetPosTimeOut = new BeckhoffUInt(this.GetTcMcGlobal_Dot_tTargetPosTimeOut, client, 16448, 385436){ Name = "tTargetPosTimeOut" },
				tADSTimeOut = new BeckhoffUInt(this.GetTcMcGlobal_Dot_tADSTimeOut, client, 16448, 385440){ Name = "tADSTimeOut" },
				tStopMonitoringTimeOut = new BeckhoffUInt(this.GetTcMcGlobal_Dot_tStopMonitoringTimeOut, client, 16448, 385444){ Name = "tStopMonitoringTimeOut" },
				NCTOPLC_FEEDBACK_MAXWAITCYCLES = new BeckhoffShort(this.GetTcMcGlobal_Dot_NCTOPLC_FEEDBACK_MAXWAITCYCLES, client, 16448, 385448){ Name = "NCTOPLC_FEEDBACK_MAXWAITCYCLES" },
				fbADSRDDEVINFO = new Tc2_System_ADSRDDEVINFOWrapper(this.GetTcMcGlobal_Dot_fbADSRDDEVINFO, client, 16448, 385456)
				{
					Name = "fbADSRDDEVINFO",
					NETID = new BeckhoffString<String24>(this.GetTcMcGlobal_Dot_fbADSRDDEVINFO_Dot_NETID, client, 16448, 385464){ Name = "NETID" },
					PORT = new BeckhoffUShort(this.GetTcMcGlobal_Dot_fbADSRDDEVINFO_Dot_PORT, client, 16448, 385488){ Name = "PORT" },
					RDINFO = new BeckhoffBool(this.GetTcMcGlobal_Dot_fbADSRDDEVINFO_Dot_RDINFO, client, 16448, 385490){ Name = "RDINFO" },
					TMOUT = new BeckhoffUInt(this.GetTcMcGlobal_Dot_fbADSRDDEVINFO_Dot_TMOUT, client, 16448, 385492){ Name = "TMOUT" },
					BUSY = new BeckhoffBool(this.GetTcMcGlobal_Dot_fbADSRDDEVINFO_Dot_BUSY, client, 16448, 385496){ Name = "BUSY" },
					ERR = new BeckhoffBool(this.GetTcMcGlobal_Dot_fbADSRDDEVINFO_Dot_ERR, client, 16448, 385497){ Name = "ERR" },
					ERRID = new BeckhoffUInt(this.GetTcMcGlobal_Dot_fbADSRDDEVINFO_Dot_ERRID, client, 16448, 385500){ Name = "ERRID" },
					DEVNAME = new BeckhoffString<String20>(this.GetTcMcGlobal_Dot_fbADSRDDEVINFO_Dot_DEVNAME, client, 16448, 385504){ Name = "DEVNAME" },
					DEVVER = new BeckhoffUInt(this.GetTcMcGlobal_Dot_fbADSRDDEVINFO_Dot_DEVVER, client, 16448, 385524){ Name = "DEVVER" },
				},
				DeviceVersion = new BeckhoffInt(this.GetTcMcGlobal_Dot_DeviceVersion, client, 16448, 385624){ Name = "DeviceVersion" },
				Init = new BeckhoffBool(this.GetTcMcGlobal_Dot_Init, client, 16448, 385628){ Name = "Init" },
			};
			DEFAULT_HOME_POSITION = new BeckhoffDouble(this.GetDEFAULT_HOME_POSITION, client, 16448, 385632){ Name = "DEFAULT_HOME_POSITION" };
			DEFAULT_BACKLASHVALUE = new BeckhoffDouble(this.GetDEFAULT_BACKLASHVALUE, client, 16448, 385640){ Name = "DEFAULT_BACKLASHVALUE" };
		}

		private bool disposedValue;
		
		private void Dispose(bool disposing)
		{
		    if (!disposedValue)
		    {
		        if (disposing)
		        {
		            // TODO: 释放托管状态(托管对象)
		        }
		
		        // TODO: 释放未托管的资源(未托管的对象)并重写终结器
		        // TODO: 将大型字段设置为 null
		        disposedValue = true;
		    }
		}
		
		// TODO: 仅当“Dispose(bool disposing)”拥有用于释放未托管资源的代码时才替代终结器
		~Global_VariablesWrapper()
		{
		    // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
		    Dispose(disposing: false);
		}
		
		public override void Dispose()
		{
		    // 不要更改此代码。请将清理代码放入“Dispose(bool disposing)”方法中
		    Dispose(disposing: true);
		    GC.SuppressFinalize(this);
		}
	}

}
