using System.Collections.Generic;
using System;
//====================================================================================
//=====================     THIS SHOULD NOT BE CHANGED    ============================
//====================================================================================
// Unit Name: STDBEnums.cs
// Author:    Anton.Steyn
// Date:      16-June-2012
//====================================================================================
namespace SigmaNEST.Plugin
{  
    public enum TUpdateResult { UR_UNDEFINED = -1, UR_GOOD = 0, UR_SHEET_MISSING = 1, UR_REM_SHEET_QTY_MISMATCH = 2, UR_SH1_MISSING = 3 };
    public enum TDBType { DB_NONE = 0, DB_PDX = 1, DB_MSSQL = 2 };
    public enum TPromptKind
    {
        PK_UPDATE_MISSING_SH1 /*[515 in Errors.txt]*/,
            PK_PART_IN_PROCESS_DELETE_PROGRAMS}; /*{[178] in messages.txt}*/
    public enum TSheetType { SHT_ANY = -1, SHT_SHEET = 0, SHT_REM = 1, SHT_COIL = 2 };
    public enum TKeyType { KT_UNDEFINED = -1, KT_NONKEY = 0, KT_MALE = 1, KT_FEMALE = 2 };
    public enum TDieMgmt { DM_NONE = 0, DM_AUTO = 1, DM_FIXED = 2 };
    public enum TPunchAvoidType { PA_NONE = 0, PA_HEADUP = 1, PA_AROUND = 2 };
    public enum TToolNestSafetyZoneType { tnUnKnown = -1, tnProcessZone = 0, tnNotBetweenClamps = 1, tnNotUnderClamps = 2 }; //QA090604.04
    public enum TWOState { WS_UNKNOWN = 0, WS_COMPLETE = 1, WS_STARTED = 2, WS_CONTINUED = 3, WS_FINISHED = 4 };
    public enum DBGeoEnum { DBGeo_Undefined, DBGeo_CDL, DBGeo_DXF, DBGeo_Native };


    public enum DBGeoStorageFormatEnum
    {
        DBGeoStorageFormat_Undefined,
        DBGeoStorageFormat_Raw,
        DBGeoStorageFormat_Zip,
        DBGeoStorageFormat_ExternalZipFile
    };



    public enum ArchivePacketStateEnum
    {
        ArchivePacketState_Undefined = -1,
        ArchivePacketState_Posted = 0, //SN100
        ArchivePacketState_Deleted = 1, //SN101
        ArchivePacketState_Updated = 2
    }; //SN102


    public enum MultiSheetTypeEnum
    {
        MultiSheetType_Undefined = -1,
        MultiSheetType_NotMultiSheet = 0,
        MultiSheetType_Vertical = 1,
        MultiSheetType_Horizontal = 2
    };

    public enum WorkOrderItemEnum
    {
        WorkOrderItem,
        WorkOrderItem_ProfilePart,
        WorkOrderItem_CTLPart
    };


    [Flags]
    public enum WorkOrderItemsSet
    {
        WorkOrderItem = 0x0,
        WorkOrderItem_ProfilePart = 0x1,
        WorkOrderItem_CTLPart = 0x2
    }

}
