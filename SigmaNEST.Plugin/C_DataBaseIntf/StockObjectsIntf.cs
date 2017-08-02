using System;
using System.Data;
using System.Runtime.InteropServices;
//====================================================================================
//=====================     THIS SHOULD NOT BE CHANGED    ============================
//====================================================================================
// Unit Name: StockObjectIntf.cs
// Author:    Anton.Steyn
// Date:      13-June-2012
//====================================================================================

namespace SigmaNEST.Plugin
{

    [ComVisible(true)]
    [Guid("87817214-4FD4-442F-8483-B81B1B2E81B0"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IStockTable
    {
        int QuantityAvailable(string Sheetname);
        int AbsQuantityInProcess(string Sheetname);
        double CoilLengthInProcess(string Sheetname);
        double LengthAvailable(string Sheetname);
        bool DoesSheetExistInStockTable(string SheetName);
        bool DoesSheetExistInStockOrRemDB(string SheetName);
        bool IsSheetNameInUse(string ASheetName);
        bool DoesSheetExistInStockTableWithQty(string SheetName);
        void UpdateQuantityAvailable(string SheetName);
        void UpdateQuantityAvailable(string[] SheetsList);
        bool DoesTempRemExist(string SheetName);
        bool DeleteAllStockFromDatabase(bool DeleteSheets, bool DeleteRems, bool DeleteInProcessStock);
        void GetStockTotals(ref int NumSheets, int NumRems, int NumCoils);


    }


    [ComVisible(true)]
    [Guid("3A5996EA-C24A-4D3C-9854-037F4440B515"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IStockRecParent
    {
        bool IsInStockTable();

        TProgressUpdate OnProgress
        {
            get;
            set;
        }


        int Quantity
        {
            get;
            set;
        }


        string PrimeCode
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double Area
        {
            get;
            set;
        }


        string Mill
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


        double Weight
        {
            get;
            set;
        }


        double Cost
        {
            get;
            set;
        }


        double Width
        {
            get;
            set;
        }


        double Length
        {
            get;
            set;
        }


        double Thickness
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


        TSheetType SheetType
        {
            get;
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


        string SpecialInstruction
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string SheetData1
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string SheetData2
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


        Guid FileSetID
        {
            get;
            set;
        }


        double EdgeDistTop
        {
            get;
            set;
        }


        double EdgeDistBottom
        {
            get;
            set;
        }


        double EdgeDistLeft
        {
            get;
            set;
        }


        double EdgeDistRight
        {
            get;
            set;
        }


        Guid GeoID
        {
            get;
            set;
        }


        Guid CargoGeoID
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

    }


    [ComVisible(true)]
    [Guid("D4A7F948-B9D4-45BE-9BD7-11C3A802C2B3"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IStockRec : IStockRecParent
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool WriteToHistory(string AProgramName, int RepeatID);
        bool DeleteFromDatabase();
        bool DeleteFromDatabaseNoCheck();
        void UpdateStock(string ProgramName, int RepeatID);
        void UpdateQuantityAvailable();
        bool SetDBQuantityAvailable(int QtyAvailable);
        bool IsInProcess(ref string ProgName, ref int QtyInProc);
        bool RotateSheet();
        int AbsQtyInProcess();
        int QtyInProcessForProgram(string ProgName);
        void SetPropertiesFromRecord(DataSet DataSet);
        bool RenameSheet(string ANewName);


        int QtyAvailable
        {
            get;
            set;
        }


        int QtyOnOrder
        {
            get;
            set;
        }


        int QtyReserved
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


        string SheetName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string OrigSheetName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        bool Reserved
        {
            get;
            set;
        }


        bool Consignment
        {
            get;
            set;
        }


        bool Single
        {
            get;
            set;
        }


        double LengthAvailable
        {
            get;
        }


        double CoilLengthInProcess
        {
            get;
        }

    }


    [ComVisible(true)]
    [Guid("C3493F62-07C0-4C09-A236-E3453156DB88"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IStockRecEnumerator : IRecEnumerator
    {
        IStockRec NextStockRec();
    }


    [ComVisible(true)]
    [Guid("A9804C8D-8309-40D3-8682-8F40F5DE4BEE"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IRemnantRec : IStockRecParent
    {
        bool WriteToDatabase();
        bool ReadFromDatabase();
        bool DeleteFromDatabase();
        bool Update(string AOrigSheetName = "");
        bool DoesRemExist();
        bool DoesRemExistGetProg(ref string ProgramName, ref int RepeatID);
        bool IsInStockTableAs(ref TSheetType DBSheetType);
        bool IsInRemDB();


        string RemnantName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


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

    }


    [ComVisible(true)]
    [Guid("6E2ADF64-0A7F-4F64-B918-18EDA9AFCA55"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IRemnantRecEnumerator : IRecEnumerator
    {
        IRemnantRec NextRemnantRec();
    }


    [ComVisible(true)] //todo give SN this GUID
    [Guid("97076E51-1231-4D58-9994-59361A3406CB"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IStockReceivedRec : IStockRecParent
    {
        bool WriteToStockTable(string StartSheetname, bool Unique, string[] WrittenSheetNames);//todo
        bool GenerateSheetnames(int Quantity, ref string[] Names); //todo
        bool IsInStockorRemDB();


        int QtyOnOrder
        {
            get;
            set;
        }


        int QtyReserved
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


        bool Consignment
        {
            get;
            set;
        }
    }


    [ComVisible(true)] //todo give SN this GUID
    [Guid("4096F9DF-1802-4FB9-86A3-021AD6DD9964"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IStockHistoryRec : IStockRecParent
    {
        bool ReadFromDatabase();


        string SheetName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string OrigSheetName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int Iteration
        {
            get;
            set;
        }


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

    }


    [ComVisible(true)] //todo give SN this GUID
    [Guid("619536D3-D14E-4950-90E6-F2CF84A84256"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLStockTable
    {
        void GetStockTotals(ref int NumStock, int NumRems);
    }


    [ComVisible(true)] //todo give SN this GUID
    [Guid("1075322B-A050-4105-BE5C-BA677908546A"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLStockRec
    {
        void UpdateCTLStock(string OldStockName);
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();
        bool CheckStockInPRocess(ref string[] WOList);
        int GetAvailableStock();
        int GetStockInProcessSum();
        int GetStockQtyCompleted();
        bool UpdateCTLStockQty(int QtyToUpdate);
        bool GetRemnantLength(ref double RemLength);



        string StockName
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


        double EdgeDistance
        {
            get;
            set;
        }


        bool IsRemnant
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

    }


    [ComVisible(true)] //todo give SN this GUID
    [Guid("78E8F603-4A7C-4718-A0BC-37578DE33DD0"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLStockRecEnumerator : IRecEnumerator
    {
        ICTLStockRec NextCTLStockRec();
    }


    [ComVisible(true)]
    [Guid("CB8E4E40-AC85-4BB9-B99B-C9B33434B15D"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLSIPRec
    {
        void UpdateCTLSIP(string CutPlanName);
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();
        int GetQuantityInProcess();


        Guid CutPlanID
        {
            get;
            set;
        }


        string StockName
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


        double EdgeDistance
        {
            get;
            set;
        }


        DateTime UpDateTime
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
    [Guid("A76EB8DF-FAA2-4AE0-9D15-E42833C564A0"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLTaskStockRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();


        string StockName
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


        int Qty
        {
            get;
            set;
        }

    }


    [ComVisible(true)]
    [Guid("C9FF1098-355F-4CCC-82B3-4382DC7EE4BE"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ITempRemnantNameRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();

        string RemnantName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }

        DateTime DateCreated
        {
            get;
            set;
        }

    }


    [ComVisible(true)]
    [Guid("F91C878F-80A6-4D78-95D9-2A8D792FB90C"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLSIPRecEnumerator : IRecEnumerator
    {
        ICTLSIPRec NextCTLSIPRec();
    }


    [ComVisible(true)]
    [Guid("240481F0-DF4E-4F38-9C1E-7FF73C36982B"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ICTLTaskStockRecEnumerator : IRecEnumerator
    {
        ICTLTaskStockRec NextCTLTaskStockRec();
    }

}
