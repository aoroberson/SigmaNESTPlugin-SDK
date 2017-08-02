using System;
using System.Runtime.InteropServices;
//====================================================================================
//=====================     THIS SHOULD NOT BE CHANGED    ============================
//====================================================================================
// Unit Name: EnumerationIntf.cs
// Author:    Anton.Steyn
// Date:      13-June-2012
//====================================================================================

namespace SigmaNEST.Plugin
{
    [ComVisible(true)]
    [Guid("09EF288E-D7E2-4EAC-BA82-7EB7358EA44C"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IRecEnumerable 
    {
    }


    [ComVisible(true)]
    [Guid("682E547F-2963-495C-B1C6-77DB8EDB40C6"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IRecEnumerator
    {
        void Retrieve();
      
        IRecEnumerable Next();
       
        bool EOF();
  
        IFilterCriteria Filter
        {
            get;
            set;
        }


        IOrderCriteria GetOrder
        {
            get;
            set;
        }
    }
}
 



 
