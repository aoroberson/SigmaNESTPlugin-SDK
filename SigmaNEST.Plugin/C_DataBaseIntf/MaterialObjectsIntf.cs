using System;
using System.Runtime.InteropServices;
//====================================================================================
//=====================     THIS SHOULD NOT BE CHANGED    ============================
//====================================================================================
// Unit Name: MaterialObjectIntf.cs
// Author:    Anton.Steyn
// Date:      17-June-2012
//====================================================================================

namespace SigmaNEST.Plugin
{
    [ComVisible(true)]
    [Guid("405FE130-22C8-453E-ADA4-215D85C709E1"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMaterialRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();


        int MatID
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


        double Costmm
        {
            get;
            set;
        }


        double Costin
        {
            get;
            set;
        }


        double Densitymm
        {
            get;
            set;
        }


        double Densityin
        {
            get;
            set;
        }


        double Shearmm
        {
            get;
            set;
        }


        double Shearin
        {
            get;
            set;
        }


        double DieClearancemm
        {
            get;
            set;
        }


        double DieClearancein
        {
            get;
            set;
        }


        double MachinabilityIndex
        {
            get;
            set;
        }


        bool CostByThickness
        {
            get;
            set;
        }


        int UseInCTL
        {
            get;
            set;
        }


        int MatGroupID
        {
            get;
            set;
        }


        string MatGroupName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        MaterialRecKeySetEnum KeySet
        {
            get;
            set;
        }
    }


    [ComVisible(true)]
    [Guid("CD7BB209-608B-44FB-BE6B-94450202C8A6"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMaterialCostRec
    {
        int ID
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


        double Cost
        {
            get;
            set;
        }


        int Units
        {
            get;
            set;
        }
    }


    [ComVisible(true)]
    [Guid("28DD69E0-D8A2-4659-B251-FE3ADDA55235"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMaterialIACRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();


        Guid ID
        {
            get;
            set;
        }


        string IAC
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        string Description
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        IMaterialRec MaterialRec
        {
            get;
        }


        double Thickness
        {
            get;
            set;
        }


        double UnitCost
        {
            get;
            set;
        }


        int MatID
        {
            get;
            set;
        }
    }


    [ComVisible(true)]
    [Guid("E3AEA207-4DB3-4344-992A-C075E3A77252"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMaterialIACRecEnumerator : IRecEnumerator
    {
        IMaterialIACRec NextMaterialIACRec();
    }



    [ComVisible(true)]
    [Guid("0FF96298-7BCD-4CC3-8697-2931B3FFB29D"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IMaterialRecEnumerator : IRecEnumerator
    {
        IMaterialRec NextMaterialRec();
    }


    #region Enum Types


    public enum MaterialRecKeySetEnum
    {
        MaterialRecKeySet_MatID, MaterialRecKeySet_MaterialType
    };
    
    #endregion
}
