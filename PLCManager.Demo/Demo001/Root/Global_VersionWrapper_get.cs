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
	
	internal static class GetClass_61ce01ed487a4a768d1a518c6ffdaacc
	{
		internal static ref ST_LibVersion GetstLibVersion_Tc2_Standard(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Standard;
		internal static ref ushort GetstLibVersion_Tc2_Standard_Dot_iMajor(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Standard.iMajor;
		internal static ref ushort GetstLibVersion_Tc2_Standard_Dot_iMinor(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Standard.iMinor;
		internal static ref ushort GetstLibVersion_Tc2_Standard_Dot_iBuild(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Standard.iBuild;
		internal static ref ushort GetstLibVersion_Tc2_Standard_Dot_iRevision(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Standard.iRevision;
		internal static ref int GetstLibVersion_Tc2_Standard_Dot_nFlags(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Standard.nFlags;
		internal static ref String24 GetstLibVersion_Tc2_Standard_Dot_sVersion(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Standard.sVersion;
		internal static ref ST_LibVersion GetstLibVersion_Tc2_Utilities(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Utilities;
		internal static ref ushort GetstLibVersion_Tc2_Utilities_Dot_iMajor(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Utilities.iMajor;
		internal static ref ushort GetstLibVersion_Tc2_Utilities_Dot_iMinor(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Utilities.iMinor;
		internal static ref ushort GetstLibVersion_Tc2_Utilities_Dot_iBuild(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Utilities.iBuild;
		internal static ref ushort GetstLibVersion_Tc2_Utilities_Dot_iRevision(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Utilities.iRevision;
		internal static ref int GetstLibVersion_Tc2_Utilities_Dot_nFlags(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Utilities.nFlags;
		internal static ref String24 GetstLibVersion_Tc2_Utilities_Dot_sVersion(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Utilities.sVersion;
		internal static ref ST_LibVersion GetstLibVersion_Tc2_System(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_System;
		internal static ref ushort GetstLibVersion_Tc2_System_Dot_iMajor(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_System.iMajor;
		internal static ref ushort GetstLibVersion_Tc2_System_Dot_iMinor(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_System.iMinor;
		internal static ref ushort GetstLibVersion_Tc2_System_Dot_iBuild(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_System.iBuild;
		internal static ref ushort GetstLibVersion_Tc2_System_Dot_iRevision(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_System.iRevision;
		internal static ref int GetstLibVersion_Tc2_System_Dot_nFlags(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_System.nFlags;
		internal static ref String24 GetstLibVersion_Tc2_System_Dot_sVersion(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_System.sVersion;
		internal static ref ST_LibVersion GetstLibVersion_Tc3_Module(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc3_Module;
		internal static ref ushort GetstLibVersion_Tc3_Module_Dot_iMajor(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc3_Module.iMajor;
		internal static ref ushort GetstLibVersion_Tc3_Module_Dot_iMinor(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc3_Module.iMinor;
		internal static ref ushort GetstLibVersion_Tc3_Module_Dot_iBuild(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc3_Module.iBuild;
		internal static ref ushort GetstLibVersion_Tc3_Module_Dot_iRevision(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc3_Module.iRevision;
		internal static ref int GetstLibVersion_Tc3_Module_Dot_nFlags(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc3_Module.nFlags;
		internal static ref String24 GetstLibVersion_Tc3_Module_Dot_sVersion(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc3_Module.sVersion;
		internal static ref ST_LibVersion GetstLibVersion_Tc2_MC2(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_MC2;
		internal static ref ushort GetstLibVersion_Tc2_MC2_Dot_iMajor(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_MC2.iMajor;
		internal static ref ushort GetstLibVersion_Tc2_MC2_Dot_iMinor(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_MC2.iMinor;
		internal static ref ushort GetstLibVersion_Tc2_MC2_Dot_iBuild(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_MC2.iBuild;
		internal static ref ushort GetstLibVersion_Tc2_MC2_Dot_iRevision(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_MC2.iRevision;
		internal static ref int GetstLibVersion_Tc2_MC2_Dot_nFlags(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_MC2.nFlags;
		internal static ref String24 GetstLibVersion_Tc2_MC2_Dot_sVersion(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_MC2.sVersion;
		internal static ref ST_LibVersion GetstLibVersion_Tc2_Math(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Math;
		internal static ref ushort GetstLibVersion_Tc2_Math_Dot_iMajor(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Math.iMajor;
		internal static ref ushort GetstLibVersion_Tc2_Math_Dot_iMinor(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Math.iMinor;
		internal static ref ushort GetstLibVersion_Tc2_Math_Dot_iBuild(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Math.iBuild;
		internal static ref ushort GetstLibVersion_Tc2_Math_Dot_iRevision(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Math.iRevision;
		internal static ref int GetstLibVersion_Tc2_Math_Dot_nFlags(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Math.nFlags;
		internal static ref String24 GetstLibVersion_Tc2_Math_Dot_sVersion(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_Math.sVersion;
		internal static ref ST_LibVersion GetstLibVersion_Tc2_NC(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_NC;
		internal static ref ushort GetstLibVersion_Tc2_NC_Dot_iMajor(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_NC.iMajor;
		internal static ref ushort GetstLibVersion_Tc2_NC_Dot_iMinor(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_NC.iMinor;
		internal static ref ushort GetstLibVersion_Tc2_NC_Dot_iBuild(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_NC.iBuild;
		internal static ref ushort GetstLibVersion_Tc2_NC_Dot_iRevision(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_NC.iRevision;
		internal static ref int GetstLibVersion_Tc2_NC_Dot_nFlags(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_NC.nFlags;
		internal static ref String24 GetstLibVersion_Tc2_NC_Dot_sVersion(this Global_VersionWrapper parent) => ref parent.ref_stLibVersion_Tc2_NC.sVersion;
	}

}
