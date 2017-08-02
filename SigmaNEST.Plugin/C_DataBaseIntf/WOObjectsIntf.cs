using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
//====================================================================================
//=====================     THIS SHOULD NOT BE CHANGED    ============================
//====================================================================================
// Unit Name: WOObjectIntf.cs
// Author:    Anton.Steyn
// Date:      13-June-2012
//====================================================================================

namespace SigmaNEST.Plugin
{

    [ComVisible(true)]
    [Guid("A0712264-AF2F-436C-9CCF-16E79012F378"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWORec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();
        bool GetInProcessProgramList(string[] ProgramList);//todo
        bool CancelWO();
        bool ArchiveWO();
        void GetPartQuantities(out int QtyOrdered, int QtyCompleted, int QtyInProcess);
        bool CheckCTLPartsInProcess(string[] PartList, string[] CutPlanList);//TODO Type
        bool ChangeWONumber(string ANewWONumber); //returns false if the new name already exists


        string WoNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string CustomerName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int CustomerID
        {
            get;
            set;
        }


        int PersonID
        {
            get;
            set;
        }


        DateTime WODate
        {
            get;
            set;
        }

        DateTime OrderDate
        {
            get;
            set;
        }


        int BillTo
        {
            get;
            set;
        }


        int ShipTo
        {
            get;
            set;
        }


        string ShipVia
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string QuoteNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string OrderNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string CustomerPO
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string WOData1
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string WOData2
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double TotalPartCost
        {
            get;
            set;
        }


        double TotalPartPrice
        {
            get;
            set;
        }


        double TotalSalesCost
        {
            get;
            set;
        }


        double TotalShippingCost
        {
            get;
            set;
        }


        double ShippingCost
        {
            get;
            set;
        }


        double Tax
        {
            get;
            set;
        }


        double TaxRate
        {
            get;
            set;
        }


        double Markup
        {
            get;
            set;
        }


        string SpecialInstruction
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double TotalScrap
        {
            get;
            set;
        }


        string ContactName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string SalesRepID
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        byte WoPriority
        {
            get;
            set;
        }


        bool OnHold
        {
            get;
            set;
        }


        int CostTypeID
        {
            get;
            set;
        }


        int StatusID
        {
            get;
            set;
        }


        bool CustomerIDFromName
        {
            get;
            set;
        }

    }


    [ComVisible(true)]
    [Guid("6CA7A6AD-9E1C-4C67-AB6D-95F15F839D78"),
    InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IHaveQtyOrderedCompletedInProcess
    {
        int QtyOrdered
        {
            get;
        }


        int QtyCompleted
        {
            get;
        }


        int QtyInProcess
        {
            get;
        }
    }


    [ComVisible(true)]
    [Guid("0297C1AD-BFD8-4E87-8E17-F2BF321784B5"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPartRec 
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();
        bool DoesWOAndPartExist();
        bool DoesWOExist();
        bool IsInProcess(ref string[] ProgramNames);//todo types
        bool EditPartDatabase();
        void UpdatePartFileLoaded();
        bool GetCompatibleMachineIDs(List <int> ACompatibleMachineIDList);
        bool WriteCompatibleMachineIDs(List <int> ACompatibleMachineIDList);



        string PartName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string WONumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string PartFilename
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        DateTime DueDate
        {
            get;
            set;
        }


        string DrawingNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Material
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double Thickness
        {
            get;
            set;
        }


        string RevisionNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string ProgrammedBy
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Remark
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data1
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data2
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data3
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data4
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data5
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data6
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data7
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data8
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data9
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data10
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data11
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data12
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data13
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data14
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        bool SpecialProperties
        {
            get;
            set;
        }


        short SpecialProperties1
        {
            get;
            set;
        }


        short SpecialProperties2
        {
            get;
            set;
        }


        short SpecialProperties3
        {
            get;
            set;
        }


        double CuttingTime
        {
            get;
            set;
        }


        double NetArea
        {
            get;
            set;
        }


        double RectArea
        {
            get;
            set;
        }


        double PartLength
        {
            get;
            set;
        }


        double PartWidth
        {
            get;
            set;
        }


        double NetWeight
        {
            get;
            set;
        }


        double RectWeight
        {
            get;
            set;
        }


        string QItemID
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int QtyOrdered
        {
            get;
            set;
        }


        int QtyCompleted
        {
            get;
            set;
        }


        int QtyInProcess
        {
            get;
        }


        short MachNumber
        {
            get;
            set;
        }


        int Priority
        {
            get;
            set;
        }


        double UnitCost
        {
            get;
            set;
        }


        double OtherCost
        {
            get;
            set;
        }


        double ShippingCost
        {
            get;
            set;
        }


        double MaterialCost
        {
            get;
            set;
        }


        double ProcessCost
        {
            get;
            set;
        }


        double PriceModifier
        {
            get;
            set;
        }


        double UnitPrice
        {
            get;
            set;
        }


        double TotalPrice
        {
            get;
            set;
        }


        string OtherOperations
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        byte PartFileLoaded
        {
            get;
            set;
        }

    }


    [ComVisible(true)]
    [Guid("419B0247-9B57-45B5-928A-330D4D787AC3"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWOPartStatusRec
    {
        string ProgramName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int RepeatID
        {
            get;
            set;
        }


        string PartName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string WONumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int QtyInProcess
        {
            get;
            set;
        }


        double PartLength
        {
            get;
            set;
        }


        double PartWidth
        {
            get;
            set;
        }


        double NetArea
        {
            get;
            set;
        }


        double RectArea
        {
            get;
            set;
        }


        double Netweight
        {
            get;
            set;
        }


        double RectWeight
        {
            get;
            set;
        }


        double CuttingTime
        {
            get;
            set;
        }


        double CuttingLength
        {
            get;
            set;
        }


        int PierceQty
        {
            get;
            set;
        }


        double MaterialCost
        {
            get;
            set;
        }


        double ProcessCost
        {
            get;
            set;
        }


        double OutsourceCost
        {
            get;
            set;
        }


        double DrawingCost
        {
            get;
            set;
        }


        int LineItemNumber
        {
            get;
            set;
        }


        string MachineName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        DateTime PostDateTime
        {
            get;
            set;
        }


        string SheetName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double Length
        {
            get;
            set;
        }


        double Width
        {
            get;
            set;
        }


        double Area
        {
            get;
            set;
        }


        int Qty
        {
            get;
            set;
        }


        double Cost
        {
            get;
            set;
        }


        string Location
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string HeatNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string BinNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Mill
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string PrimeCode
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        TSheetType SheetType
        {
            get;
            set;
        }


        DateTime DateReceived
        {
            get;
            set;
        }


        DateTime DateCreated
        {
            get;
            set;
        }


        int SpecialProperties1
        {
            get;
            set;
        }


        int SpecialProperties2
        {
            get;
            set;
        }


        int SpecialProperties3
        {
            get;
            set;
        }


        string SpecialInstruction
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string PartFilename
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int QtyOrdered
        {
            get;
            set;
        }


        int QtyCompleted
        {
            get;
            set;
        }


        DateTime DueDate
        {
            get;
            set;
        }


        string DrawingNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Material
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double Thickness
        {
            get;
            set;
        }


        string RevisionNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string ProgrammedBy
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Remark
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data1
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data2
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data3
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data4
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string QItemID
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }

    }


    [ComVisible(true)]
    [Guid("CCD50FAB-87CF-4B3F-A0BA-C6F5777EF94D"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWORecEnumerator : IRecEnumerator
    {
        IWORec NextWORec();

        WorkOrderItemsSet OrderMustContain
        {
            get;
            set;
        }
    }


    [ComVisible(true)]
    [Guid("46B01E5D-906B-4E1F-B3A7-2333BEC10C09"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPartRecEnumerator : IRecEnumerator
    {
        IPartRec NextPartRec();
    }


    [ComVisible(true)]
    [Guid("D0682DC4-1CF0-4232-A6D1-A4DD1C6CF789"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IWOPartStatusEnumerator : IRecEnumerator
    {
        IWOPartStatusRec NextWOPartStatusRec();
    }


    [ComVisible(true)]
    [Guid("7EAD2BE6-3454-4467-A4E9-89F8B33A1BE6"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IArchivedWOPartStatusEnumerator : IRecEnumerator
    {
        IWOPartStatusRec NextWOPartStatusRec();
    }


    [ComVisible(true)]
    [Guid("B3FC7EBE-8E41-44F1-8297-724B97F619BA"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IProgramRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        //bool WriteToDatabaseAllRepeats(int NumberOfRepeats);
        bool DeleteFromDatabase(bool DeleteSH1Files);
        TUpdateResult UpdateProgram(bool AllRepeats = false);
        bool GetRemInProcessList(string[] RemList); //todo
        int GetCount();
        bool DoesPrgNameExistInPipDBOrProgramDB();
        bool DoesPrgnameExistInProgramDB();
        void GetSIPList(string[] SIPList, ref int SheetTotal);
        void GetSIPRecList(ArrayList SIPRecList);
        void GetRemnantRecList(ArrayList RemnantRecLis);
        ISIPRec MakeReplacementSIPRec(string ReplacingSheetName, ISIPRec ReplacedSIPRec);
        void ChangeProgramName(string NewProgramName);


        string ProgramName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int RepeatID
        {
            get;
            set;
        }


        string SheetName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double UsedArea
        {
            get;
            set;
        }


        double ScrapFraction
        {
            get;
            set;
        }


        int QtyInProcess
        {
            get;
            set;
        }


        int StaticCount
        {
            get;
            set;
        }


        string MachineName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double CuttingTime
        {
            get;
            set;
        }


        int PierceQty
        {
            get;
            set;
        }


        double JobCost
        {
            get;
            set;
        }


        DateTime PostDateTime
        {
            get;
            set;
        }


        string Material
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double Thickness
        {
            get;
            set;
        }


        double SheetLength
        {
            get;
            set;
        }


        double SheetWidth
        {
            get;
            set;
        }


        bool Rem
        {
            get;
            set;
        }


        string TaskName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        bool IsMultiSheet
        {
            get;
        }


        int MachineID
        {
            get;
            set;
        }


        DateTime CutStartTime
        {
            get;
            set;
        }


        DateTime CutEndTime
        {
            get;
            set;
        }


        int PostID
        {
            get;
            set;
        }


        int ArchivePacketID
        {
            get;
            set;
        }


        MultiSheetTypeEnum MultiSheetType
        {
            get;
            set;
        }

    }


    [ComVisible(true)]
    [Guid("6A581F28-2D97-4F72-8E82-A6AE4E3CFE26"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IHasActualDuration
    {
        double ActualDuration
        {
            get;
            set;
        }
    }


    [ComVisible(true)]
    [Guid("0B016F60-F136-455F-B416-F589BD4CDC71"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IHasActualTime
    {
        DateTime ActualStartTime
        {
            get;
            set;
        }


        DateTime ActualEndTime
        {
            get;
            set;
        }
    }


    [ComVisible(true)]
    [Guid("6C92D011-284D-45DF-A061-CE8B88D9E618"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IProgramRecEnumerator : IRecEnumerator
    {
        IProgramRec NextProgramRec();
    }


    [ComVisible(true)]
    [Guid("A0C23423-A85A-407E-B5CF-2661407769C2"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPIPRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool IsPartInProcess(ref string ProgramName);
        void ChangeQtyInProcess(int QtyInProcess);


        string ProgramName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string PartName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string WoNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int RepeatID
        {
            get;
            set;
        }


        int QtyInProcess
        {
            get;
            set;
        }


        double PartLength
        {
            get;
            set;
        }


        double PartWidth
        {
            get;
            set;
        }


        double TrueArea
        {
            get;
            set;
        }


        double RectArea
        {
            get;
            set;
        }


        double TrueWeight
        {
            get;
            set;
        }


        double RectWeight
        {
            get;
            set;
        }


        double CuttingTime
        {
            get;
            set;
        }


        double CuttingLength
        {
            get;
            set;
        }


        int PierceQty
        {
            get;
            set;
        }


        double TrueCost
        {
            get;
            set;
        }


        double RectCost
        {
            get;
            set;
        }


        double NestedCost
        {
            get;
            set;
        }


        double MaterialCost
        {
            get;
            set;
        }


        double ProcessCost
        {
            get;
            set;
        }


        double OutsourceCost
        {
            get;
            set;
        }


        double DrawingCost
        {
            get;
            set;
        }


        string LineItemNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double NestedArea
        {
            get;
            set;
        }


        int LastMachineID
        {
            get;
            set;
        }


        double TotalCuttingTime
        {
            get;
            set;
        }


        int MasterPartQty
        {
            get;
            set;
        }


        TWOState WoState
        {
            get;
            set;
        }


        string RevisionNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        bool ArchiveChanges
        {
            get;
            set;
        }

    }


    [ComVisible(true)]
    [Guid("0DC51D2C-9C64-43D7-8699-D8D501DC3A50"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPIPRecEnumerator : IRecEnumerator
    {
        IPIPRec NextPIPRec();
    }


    [ComVisible(true)]
    [Guid("97932558-A5F4-4665-84A7-CAF6699E8470"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ISIPRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase(bool AllRepeats = false);


        string ProgramName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int RepeatID
        {
            get;
            set;
        }


        string Material
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double Thickness
        {
            get;
            set;
        }


        double PlateLen
        {
            get;
            set;
        }


        double PlateHeight
        {
            get;
            set;
        }


        string Location
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string HeatNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string BinNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Mill
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string PrimeCode
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int QtyInProcess
        {
            get;
            set;
        }


        string SheetName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double ScrapFraction
        {
            get;
            set;
        }


        double UsedArea
        {
            get;
            set;
        }


        TSheetType SheetType
        {
            get;
            set;
        }
    }


    [ComVisible(true)]
    [Guid("3F8B0A53-9B09-411C-BAE7-71BFC9C91F59"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ISIPRecEnumerator : IRecEnumerator
    {
        ISIPRec NextSIPRec();
    }


    [ComVisible(true)]
    [Guid("EEDF2D43-B179-411C-A1C4-BAEC4AE2E1BB"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IProgramMachineRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();


        string ProgramName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int RepeatID
        {
            get;
            set;
        }


        string MachineName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double CuttingTime
        {
            get;
            set;
        }

    }


    [ComVisible(true)]
    [Guid("07B96BF3-197F-4DFE-9876-C013E7514A64"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IOrderRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();


        int OrderID
        {
            get;
            set;
        }


        string OrderNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string WoNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string QuoteNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string CustomerName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Location
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string TaxNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string CustComment
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int CustomerID
        {
            get;
            set;
        }


        int BillToID
        {
            get;
            set;
        }


        int ShipToID
        {
            get;
            set;
        }


        int PersonID
        {
            get;
            set;
        }


        string SalesRep
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        DateTime OrderDate
        {
            get;
            set;
        }


        DateTime DueDate
        {
            get;
            set;
        }


        string ShipVia
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string CustomerPO
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int StatusID
        {
            get;
            set;
        }


        double TaxRate
        {
            get;
            set;
        }


        double Markup
        {
            get;
            set;
        }


        double TotalPartCost
        {
            get;
            set;
        }


        double TotalPartPrice
        {
            get;
            set;
        }


        double ShippingCost
        {
            get;
            set;
        }


        double Tax
        {
            get;
            set;
        }


        double TotalPrice
        {
            get;
            set;
        }


        double TotalShippingCost
        {
            get;
            set;
        }


        int CostTypeID
        {
            get;
            set;
        }


        bool UseNestedCost
        {
            get;
            set;
        }


        int CustomerMaterial
        {
            get;
            set;
        }


        string Comments
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }

    }


    [ComVisible(true)]
    [Guid("A9545B83-041E-4249-A706-16CC77DDE98F"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IOrderItemsRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();


        int OrderItemID
        {
            get;
            set;
        }


        string OrderNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int OrderItemType
        {
            get;
            set;
        }


        string PartName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string PartFilename
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string WoNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Material
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double Thickness
        {
            get;
            set;
        }


        int Qty
        {
            get;
            set;
        }


        string CustDrawingNum
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }



        string RevisionNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        DateTime DueDate
        {
            get;
            set;
        }


        string Data1
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }

        string Data2
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data3
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data4
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data5
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data6
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data7
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data8
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data9
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data10
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data11
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data12
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data13
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }

        string Data14
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string MachineName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double CuttingTime
        {
            get;
            set;
        }


        double UnitCost
        {
            get;
            set;
        }


        double OtherCosts
        {
            get;
            set;
        }


        double ShippingCost
        {
            get;
            set;
        }


        double PriceModifier
        {
            get;
            set;
        }


        double Markup
        {
            get;
            set;
        }


        double UnitPrice
        {
            get;
            set;
        }


        double TotalPrice
        {
            get;
            set;
        }


        string Note
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int CostType
        {
            get;
            set;
        }


        double TrueProcessCost
        {
            get;
            set;
        }


        double TrueMatCost
        {
            get;
            set;
        }


        double RectProcessCost
        {
            get;
            set;
        }


        double RectMatCost
        {
            get;
            set;
        }


        double NestedProcessCost
        {
            get;
            set;
        }


        double NestedMatCost
        {
            get;
            set;
        }


        double FixedUnitPrice
        {
            get;
            set;
        }


        double MaterialPrice
        {
            get;
            set;
        }

    }


    [ComVisible(true)]
    [Guid("831EEF7C-3317-4173-ADEA-A1A7CD7CCAE9"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLPartRec
    {
        bool CheckPartInStock();
        bool WriteToDatabase();
        bool DeleteFromDatabase();
        bool ReadFromDatabase();
        bool CheckPartInProcess();
        int GetPartInProcessSum();
        int GetPartQuantityCompleted();
        void UpdateCTLPart();


        string WONumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string PartName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string ShapeType
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int QuantityOrdered
        {
            get;
            set;
        }


        int QuantityCompleted
        {
            get;
            set;
        }


        int QuantityScrapped
        {
            get;
            set;
        }


        double Length
        {
            get;
            set;
        }


        string Material
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data1
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data2
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data3
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data4
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data5
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double Param1
        {
            get;
            set;
        }


        double Param2
        {
            get;
            set;
        }


        double Param3
        {
            get;
            set;
        }


        double Param4
        {
            get;
            set;
        }


        double Param5
        {
            get;
            set;
        }


        double Param6
        {
            get;
            set;
        }


        double Param7
        {
            get;
            set;
        }


        double Param8
        {
            get;
            set;
        }


        double Param9
        {
            get;
            set;
        }


        double Param10
        {
            get;
            set;
        }


        DateTime DueDate
        {
            get;
            set;
        }
    }


    [ComVisible(true)]
    [Guid("5459AF17-A887-4E67-8BB3-D9CABA661837"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLPartRecEnumerator : IRecEnumerator
    {
        ICTLPartRec NextCTLPartRec();
    }


    [ComVisible(true)]
    [Guid("780844C6-D092-4131-A031-40064C0EFF63"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLPIPRec
    {
        void UpdateCTLPIP(string CutPlanName);
        void UpdateCTLPIPNestedLength();
        void UpdateCTLPIPNestedLengthAfterCommit();
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();


        Guid CutPlanID
        {
            get;
            set;
        }


        string WONumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string PartName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string ShapeType
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int QtyInProcess
        {
            get;
            set;
        }


        double Length
        {
            get;
            set;
        }


        string Material
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data1
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data2
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data3
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data4
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Data5
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        DateTime UpDateTime
        {
            get;
            set;
        }


        double Weight
        {
            get;
            set;
        }


        string Units
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }
    }


    [ComVisible(true)]
    [Guid("BC568031-15D3-4736-96E1-DFA5A569E7DD"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLCutPlanRec
    {
        void UpdateCutPlan();
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();
        bool DeleteCutPlanFromDB();
        bool UpDateArchiveTableForDel();
        bool UpDateArchiveTableForCommit(double RemLength);
        bool GetCutPlanIDFromDB();


        Guid CutPlanID
        {
            get;
            set;
        }


        int CutState
        {
            get;
            set;
        }


        string CutPlanName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        Guid TaskID
        {
            get;
            set;
        }


        string MachineName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double Kerf
        {
            get;
            set;
        }


        DateTime UpDateTime
        {
            get;
            set;
        }


        int QtyInCutPlan
        {
            get;
            set;
        }


        bool IsOnRemnant
        {
            get;
            set;
        }


        bool CreateRemnant
        {
            get;
            set;
        }

    }


    [ComVisible(true)]
    [Guid("DE908DCC-94D0-419F-A5BF-1CA3FBBCDB56"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLTaskRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();
        bool GetTaskIDFromDB();


        Guid TaskID
        {
            get;
            set;
        }


        string TaskName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string MachineName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double Kerf
        {
            get;
            set;
        }


        bool CreateRemnant
        {
            get;
            set;
        }
    }


    [ComVisible(true)]
    [Guid("6C9347F3-350C-4190-959A-D027B1C63FE8"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLTaskPartRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();


        string WONumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string PartName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string ShapeType
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        Guid TaskID
        {
            get;
            set;
        }

    }


    [ComVisible(true)]
    [Guid("DDFD5E12-630E-48A6-BF50-B6CEF3BFC818"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IArchivePacketRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();
        int GetNewArchivePacketID();
        void FlagReadyForProcessing();


        int ArchivePacketID
        {
            get;
            set;
        }


        ArchivePacketStateEnum State
        {
            get;
            set;
        }
    }


    [ComVisible(true)]
    [Guid("A48ACA57-7259-40F5-A074-E814004EC058"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IArchivePacketTable
    {
        int GetNextArchivePacketID();
      //  void FlagReadyForProcessing(List <int> AArchivePacketIDList);//TODO
        void FlagProgramReadyforProcessing(string ATaskName, string AProgramName);
        void FlagTaskReadyForProcessing(string ATaskName);
    }


    [ComVisible(true)]
    [Guid("EED2FD78-70D4-417D-A856-8E8AFCEA41B8"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPIPTable
    {
        int QtyInProcessForWO(IWORec AWORec);
    }


    [ComVisible(true)]
    [Guid("6E742FE8-0D2E-4D94-BE25-BF6C51D61FE2"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IPartTable
    {
        int QtyOrderedForWO(IWORec AWORec);
        int QtyCompletedForWO(IWORec AWORec);
    }


    [ComVisible(true)]
    [Guid("341D47C0-4D07-40CD-85EE-9F7BAAD69614"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLPipTable
    {
        int QtyInProcessForWO(IWORec AWORec);
    }



    [ComVisible(true)]
    [Guid("89281A4B-B023-437F-9478-3B3EAFDB157A"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLPartTable
    {
        int QtyOrderedForWO(IWORec AWORec);
        int QtyCompletedForWO(IWORec AWORec);
    }


    [ComVisible(true)]
    [Guid("D2656363-FAD4-419D-B0A7-50D76D7DB1EC"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IProgramTable
    {
        bool DeleteProgramAllRepeats(string AProgramName, string[] AProgramsThatGaveErrors);
        bool UpdateProgramAllRepeats(string AProgName, string[] AProgramsThatGaveErrors);
        bool UpdateAllPrograms(string[] AProgramsThatGaveErrors);

    }


    [ComVisible(true)]
    [Guid("5D8C934C-A596-4575-8CD1-1DF832C30F0A"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLCutPlanRecEnumerator : IRecEnumerator
    {
        ICTLCutPlanRec NextCTLCutPlanRec();
    }


    [ComVisible(true)]
    [Guid("BCAA97C2-FFA8-4F63-B39E-A22E360604D6"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLPIPRecEnumerator : IRecEnumerator
    {
        ICTLPIPRec NextCTLPIPRec();
    }


    [ComVisible(true)]
    [Guid("4E1ED867-0797-4380-9316-63DC42322ACF"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLTaskRecEnumerator : IRecEnumerator
    {
        ICTLTaskRec NextCTLTaskRec();
    }


    [ComVisible(true)]
    [Guid("890F6B2D-3755-41CD-B87C-78DAE8CBC374"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLTaskPartRecEnumerator : IRecEnumerator
    {
        ICTLTaskPartRec NextCTLTaskPartRec();
    }


}
