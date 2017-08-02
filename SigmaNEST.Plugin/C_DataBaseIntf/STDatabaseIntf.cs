using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

//====================================================================================
//=====================     THIS SHOULD NOT BE CHANGED    ============================
//====================================================================================
// Unit Name: STDatabaseIntf.cs
// Author:    Anton.Steyn
// Date:      13-June-2012
//====================================================================================

namespace SigmaNEST.Plugin
{


    [ComVisible(true)]
    [Guid("7B36E900-099E-40B3-A290-C8C2FB21CC28"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ISTDatabase
    {
        int GetFieldLength(string TableName, string FieldName);

        [Obsolete("This method is obsolete-deprecated")]
        void RemoveProgramAndPIPOrphans();

        [Obsolete("This method is obsolete-deprecated")]
        void RemoveProgramAndRemnantOrphans();

        [Obsolete("This method is obsolete-deprecated")]
        void CheckSH1Files();

        void UpdateAllQuantityAvailable();

        void DeleteToolsFromDB(List<int> ToolIDList);
        void DeleteDiesFromDB(List<int> DieIDList);
        void CopyToolsInDBase(List<int> ToolIDList, int CopyCount);
        void CopyDiesInDBase(List<int> DieIDList, int CopyCount);

        void GetBrokenWOList(string[] BrokenWOList, string[] FilteredWOList);

        void UpdateToolsInDB(List<int> ToolIDList, bool DoHolderSize, bool DoStripper, bool DoFaceType,
                             bool DoToolUse, bool DoDieMgmt, bool DoKeyType, bool DoCapability, bool DoAvailable,
                             bool DoCheckPressure, double HolderSize, int Stripper, int FaceType, int ToolUse,
                             int DieMgmtInt, int KeyTypeInt, string CapabilityName, string SNKeyAngles, bool Available, bool CheckPressure);

        bool CheckDupWO(string WoNo);

        string GetNextSheetName(string Prefix, ref int Counter);

        DateTime GetProgramPostDateTime(string ProgramNumber);

        bool GetPartQuantitiesExclProgList(string WoNo, string PartName, ref int QtyOrdered, ref int QtyCompleted, int QtyInProcess, string ExclProgNameList);

        int GetSheetQtyAvExclProgList(string SheetName, string ExclProgramNameList);

        double GetSheetLenAvExclProgList(string SheetName, string ExclProgramNameList);


        IStockRecEnumerator GetStockRecEnumerator();



        bool AreThereToolsWithMissingDies();

        bool CheckDupCTLStockName(string StockName, string ShapeType);

        bool CheckDupCTLPartName(string PartName, string WONumber);

        bool CheckDupCTLTask(string TaskName);

        string GetNextAvailableCTLStocknumber(string StockName);

        string GetNextAvailableCTLPartNumber(string PartName, string WONumber);

        bool CheckShapeInUse(string ShapeName, string ShapeType, double[] ParamList);

        void UpdateCTLOrderNumber(string OldName, string NewName, int AutoID);

        void Disconnect();

        int NextTimeLineID();

        IOrderRec NewOrderRec();
        IOrderItemsRec NewOrderItemsRec();
        IPartRec NewPartRec();
        IPIPRec NewPIPRec();
        IProgramRec NewProgramRec();
        IWORec NewWORec();
        ISIPRec NewSIPRec();
        IRemnantRec NewRemnantRec();

        IStockRec NewStockRec();
        IStockTable NewStockTable();
        IStockReceivedRec NewStockReceivedRec();
        IAssocFileSetRec NewAssocFileSetRec();
        IAssocFileRec NewAssocFileRec();
        IGeoRec NewGeoRec();
        IMaterialRec NewMaterialRec();
        ITempRemnantNameRec NewTempRemnantNameRec();
        IMaterialIACRec NewMaterialIACRec();
        IArchivePacketRec NewArchivePacketRec();
        IStockHistoryRec NewStockHistoryRec();
        IToolAdapterRec NewToolAdapterRec();














        #region properties

        int DBLenWONumber
        {
            get;
        }


        int DBLenPartName
        {
            get;
        }


        int DBLenSheetName
        {
            get;
        }


        int DBLenProgName
        {
            get;
        }


        int DBLenQuoteNumber
        {
            get;
        }


        int DBLenPartRemark
        {
            get;
        }


        int DBLenDrawingNumber
        {
            get;
        }


        IWORec WORec
        {
            get;
        }


        IPartRec PartRec
        {
            get;
        }


        IProgramRec ProgramRec
        {
            get;
        }


        IPIPRec PIPRec
        {
            get;
        }


        ISIPRec SIPRec
        {
            get;
        }


        IProgramMachineRec ProgramMachineRec
        {
            get;
        }


        IOrderRec OrderRec
        {
            get;
        }


        IOrderItemsRec OrderItemsRec
        {
            get;
        }


        ICTLPartRec CTLPartRec
        {
            get;
        }


        ICTLStockRec CTLStockRec
        {
            get;
        }


        ICTLCutPlanRec CTLCutPlanRec
        {
            get;
        }


        ICTLPIPRec CTLPIPRec
        {
            get;
        }


        ICTLSIPRec CTLSIPRec
        {
            get;
        }


        ICTLTaskRec CTLTaskRec
        {
            get;
        }


        ICTLTaskPartRec CTLTaskPartRec
        {
            get;
        }


        ICTLTaskStockRec CTLTaskStockRec
        {
            get;
        }


        IStockRec StockRec
        {
            get;
        }


        IRemnantRec RemnantRec
        {
            get;
        }


        IStockReceivedRec StockReceivedRec
        {
            get;
        }


        IAssocFileSetRec AssocFileSetRec
        {
            get;
        }


        IAssocFileRec AssocFileRec
        {
            get;
        }


        IGeoRec GeoRec
        {
            get;
        }


        IMaterialRec MaterialRec
        {
            get;
        }


        ITempRemnantNameRec TempRemnantNameRec
        {
            get;
        }


        IMaterialIACRec MaterialIACRec
        {
            get;
        }


        IArchivePacketRec ArchivePacketRec
        {
            get;
        }


        IStockHistoryRec StockHistoryRec
        {
            get;
        }


        IToolAdapterRec ToolAdapterRec
        {
            get;
        }


        IStockTable StockTable
        {
            get;
        }


        IPIPTable PIPTable
        {
            get;
        }


        ICTLPipTable CTLPipTable
        {
            get;
        }


        IPartTable PartTable
        {
            get;
        }


        ICTLPartTable CTLPartTable
        {
            get;
        }


        IArchivePacketTable ArchivePacketTable
        {
            get;
        }


        IProgramTable ProgramTable
        {
            get;
        }


        ICTLStockTable CTLStockTable
        {
            get;
        }


        string DataPath
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string SheetsPath
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        bool ExportToSimtrans
        {
            get;
            set;
        }


        double MinCoilSize
        {
            get;
            set;
        }


        bool RemoveSheetsWithZeroOrNegativeQty
        {
            get;
            set;
        }


        string SheetNamePrefix
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        TMessageDialogCallBack MessageDialogCallback
        {
            get;
            set;
        }
        #endregion
    }

}
