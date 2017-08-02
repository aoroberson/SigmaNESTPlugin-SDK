using System;
using System.Runtime.InteropServices;
//====================================================================================
//=====================     THIS SHOULD NOT BE CHANGED    ============================
//====================================================================================
// Unit Name: FileAssociationIntf.cs
// Author:    Anton.Steyn
// Date:      15-June-2012
//====================================================================================

namespace SigmaNEST.Plugin
{

    [ComVisible(true)]
    [Guid("4BA18E27-BC09-48D9-9199-D7A40FD8D37D"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IFileSetOwner
    {
        bool WriteToDatabase();


        string Name
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }


        Guid FileSetID
        {
            get;
            set;
        }      
    }


    [ComVisible(true)]
    [Guid("A6889D44-BB34-44A6-B848-2E286CCF3E5A"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAssocFileRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();
        int NumberOfOwnerFileSets();


        Guid FileID
        {
            get;
            set;
        }

        string FileName
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }
    }


    [ComVisible(true)]
    [Guid("8FCBCC8C-A47C-4CFC-BBBF-2B943CC0E005"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAssocFileRecEnumerator : IRecEnumerator
    {
        IAssocFileRec NextAssocFileRec();
    }



    [ComVisible(true)]
    [Guid("B89C6C27-FF05-45EC-A527-58DC05D1CA66"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAssocFileSetRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();
        int NumberOfAssociations();
        void GetContainedFileRecEnumerator();        
        bool AddFile(IAssocFileRec AAssocFileRec);
        bool RemoveFile(IAssocFileRec AAssocFileRec);
        bool Branch();


        Guid FileSetID
        {
            get;
            set;
        }


        IAssocFileRecEnumerator ContainedFileRecEnumerator
        {
            get;
        }
    }


    [ComVisible(true)]
    [Guid("816148AE-0298-4BC2-A0CE-96D52BE02C0D"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAssocFileSetRecEnumerator : IRecEnumerator
    {
        IAssocFileRec NextAssocFileSetRec();         
    }

}

