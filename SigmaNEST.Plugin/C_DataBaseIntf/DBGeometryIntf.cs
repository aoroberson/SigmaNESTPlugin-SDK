using System;
using System.Runtime.InteropServices;
//====================================================================================
//=====================     THIS SHOULD NOT BE CHANGED    ============================
//====================================================================================
// Unit Name: DBGeometryIntf.cs
// Author:    Anton.Steyn
// Date:      13-June-2012
//====================================================================================

namespace SigmaNEST.Plugin
{
    [ComVisible(true)]
    [Guid("04C6C26D-3F9C-4402-91B2-737245786413"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IGeoRec
    {
        bool ReadFromDatabase();
        bool WriteToDatabase();
        bool DeleteFromDatabase();

        Guid GeoID
        {
            get;
            set;
        }


        DBGeoStorageFormatEnum GeoStorageFormat
        {
            get;
            set;
        }


        DBGeoEnum GeoType
        {
            get;
            set;
        }


        object GeoData
        {
            get;
            set;
        }       
    }
}


