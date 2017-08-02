using System;
using System.Runtime.InteropServices;
//====================================================================================
//=====================     THIS SHOULD NOT BE CHANGED    ============================
//====================================================================================
// Unit Name: ToolAndDieIntf.cs
// Author:    Anton.Steyn
// Date:      15-June-2012
//====================================================================================

namespace SigmaNEST.Plugin
{
    [ComVisible(true)]
    [Guid("0927A506-CD10-47C8-8C3B-4692D3DAF516"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IToolRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();


        int ToolID
        {
            get;
            set;
        }


        string Descr
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string ToolNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int ToolType
        {
            get;
            set;
        }


        double HolderSize
        {
            get;
            set;
        }


        int TurretType
        {
            get;
            set;
        }


        double ToolParam1
        {
            get;
            set;
        }


        double ToolParam2
        {
            get;
            set;
        }


        double ToolParam3
        {
            get;
            set;
        }


        double ToolParam4
        {
            get;
            set;
        }


        double ToolParam5
        {
            get;
            set;
        }


        double ToolParam6
        {
            get;
            set;
        }


        double ToolParam7
        {
            get;
            set;
        }


        double ToolParam8
        {
            get;
            set;
        }


        double ToolParam9
        {
            get;
            set;
        }


        double ToolParam10
        {
            get;
            set;
        }


        int ToolParamInt1
        {
            get;
            set;
        }


        int ToolParamInt2
        {
            get;
            set;
        }


        int ToolParamInt3
        {
            get;
            set;
        }


        int ToolParamInt4
        {
            get;
            set;
        }


        int ToolParamInt5
        {
            get;
            set;
        }


        string SpecFileName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double MaxToolPressure
        {
            get;
            set;
        }


        int FaceType
        {
            get;
            set;
        }


        double StripperHeight
        {
            get;
            set;
        }


        int ToolShape
        {
            get;
            set;
        }


        string KeyAngles
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int HitCount
        {
            get;
            set;
        }


        int LifeCount
        {
            get;
            set;
        }


        int Sharpenings
        {
            get;
            set;
        }


        int AdvancedUse
        {
            get;
            set;
        }


        string Capability
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Symmetry
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        TKeyType KeyType
        {
            get;
            set;
        }


        int DrillType
        {
            get;
            set;
        }


        bool Interference
        {
            get;
            set;
        }


        string ToolData1
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string ToolData2
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string ToolData3
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string ToolData4
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int DieID
        {
            get;
            set;
        }


        TDieMgmt DieMgmt
        {
            get;
            set;
        }


        bool Available
        {
            get;
            set;
        }


        bool DoCheckPressure
        {
            get;
            set;
        }


        TPunchAvoidType AvoidType
        {
            get;
            set;
        }


        bool UseToolSpecificTol
        {
            get;
            set;
        }


        double PositiveTol
        {
            get;
            set;
        }


        double NegativeTol
        {
            get;
            set;
        }


        TToolNestSafetyZoneType NestSafetyZoneType
        {
            get;
            set;
        }


        string ToolMaterial
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        bool LookupCutData
        {
            get;
            set;
        }

    }


    [ComVisible(true)]
    [Guid("65912C6D-CB47-4171-A707-668C0ED75C69"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IToolRecEnumerator : IRecEnumerator
    {
        IToolRec NextToolRec();

    }


    [ComVisible(true)]
    [Guid("E218220B-03E8-4226-8C8A-4229C324F889"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDieRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();


        int DieID
        {
            get;
            set;
        }


        string Descr
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double HolderSize
        {
            get;
            set;
        }


        string DieNumber
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        double DieParam1
        {
            get;
            set;
        }


        double DieParam2
        {
            get;
            set;
        }


        double DieParam3
        {
            get;
            set;
        }


        double DieParam4
        {
            get;
            set;
        }


        double DieParam5
        {
            get;
            set;
        }


        double DieParam6
        {
            get;
            set;
        }


        double DieParam7
        {
            get;
            set;
        }


        double DieParam8
        {
            get;
            set;
        }


        double DieParam9
        {
            get;
            set;
        }


        double DieParam10
        {
            get;
            set;
        }


        int DieType
        {
            get;
            set;
        }


        string SpecFileName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string KeyAngles
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        int HitCount
        {
            get;
            set;
        }


        int LifeCount
        {
            get;
            set;
        }


        int Sharpenings
        {
            get;
            set;
        }


        string DieData1
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string DieData2
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string DieData3
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string DieData4
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        TKeyType KeyType
        {
            get;
            set;
        }


        string Capability
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        bool Available
        {
            get;
            set;
        }


        double ToleranceTighter
        {
            get;
            set;
        }


        double ToleranceLooser
        {
            get;
            set;
        }


        int DedicatedTool
        {
            get;
            set;
        }


        double MinClearance
        {
            get;
            set;
        }


        double MaxClearance
        {
            get;
            set;
        }


        string Materials
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        bool Shaved
        {
            get;
            set;
        }

    }


    [ComVisible(true)]
    [Guid("395D3FA2-FC2D-4DD8-A53F-2FF778B89FC8"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDieRecEnumerator : IDieRec
    {
        IDieRec NextDieRec();
    }


    [ComVisible(true)]
    [Guid("130078E9-12F0-42B9-9736-0644E3F24FAD"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IToolAdapterRec
    {
        int ToolID
        {
            get;
            set;
        }


        int AdapterID
        {
            get;
            set;
        }


        double HolderSize
        {
            get;
            set;
        }


        int KeyType
        {
            get;
            set;
        }


        string AdapterName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }

    }


    [ComVisible(true)]
    [Guid("4AA8ECC6-E804-4BD3-B5BC-68B8BF8018A8"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IToolAdapterRecEnumerator : IRecEnumerator
    {
        IToolAdapterRec NextToolAdapterRec();
    }

}
