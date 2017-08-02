using System;
using System.Runtime.InteropServices;

namespace SigmaNEST.Plugin
{
    [ComVisible(true)]
    [Guid("B79C1B48-A816-4452-BA5B-08A60FE69D96"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ISNPlugin
    {
        string Author
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string AuthorizationGUID
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        byte AuthorizationType
        {
            get;
        }

        string ButtonDescription
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        bool ButtonOnLocation(byte AButtonLocation);

        bool CanConfigure
        {
            get;
        }

        bool CanExecute
        {
            get;
        }

        void Configure(string AParameters);

        double DateCreated
        {
            get;
        }

        void Execute(string AParameters);

        string PlugInDescription
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string PlugInExplenation
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }

        string Version
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
        }
    }

    [ComVisible(true)]
    [Guid("3935EAED-5579-4569-9BE5-4BD688A9E6CA"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface ISNPokeIntf
    {
        int Poke(ref double AD1, ref double AD2, ref double ADI3, ref string AS1, ref string AS2, ref string AS3);
    }
}
