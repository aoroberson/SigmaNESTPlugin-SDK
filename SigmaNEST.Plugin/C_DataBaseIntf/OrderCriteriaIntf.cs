using System;
using System.Runtime.InteropServices;
//====================================================================================
//=====================     THIS SHOULD NOT BE CHANGED    ============================
//====================================================================================
// Unit Name: OrderCriteriaINtf.cs
// Author:    Anton.Steyn
// Date:      17-June-2012
//====================================================================================

namespace SigmaNEST.Plugin
{

    [ComVisible(true)]
    [Guid("B8FAE0E6-60E6-4A2F-9BDB-F5FE5E5B0BF3"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IOrderItem
    {
        string Name
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        bool Ascending
        {
            get;
            set;
        }
    }


    [ComVisible(true)]
    [Guid("DE173C3C-0F08-4DA7-888A-9A23F0B3ACC7"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IOrderCriteria
    {        
        IOrderItem First();
        int IndexOf(IOrderItem  Item);
        int Add(IOrderItem Item);
        IOrderItem AddOrderItem(string Name,bool Ascending = true);
        void Insert(int Index,IOrderItem Item);
        IOrderItem Last();
        int Remove(IOrderItem Item);


        IOrderItem[] Item
        {
            get;
            set;
        }


        int Count
        {
            get;
        }      
    }
}
