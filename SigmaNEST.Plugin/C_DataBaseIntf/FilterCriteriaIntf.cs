using System;
using System.Runtime.InteropServices;
//====================================================================================
//=====================     THIS SHOULD NOT BE CHANGED    ============================
//====================================================================================
// Unit Name: FiletCriteriaIntf.cs
// Author:    Anton.Steyn
// Date:      17-June-2012
//====================================================================================

namespace SigmaNEST.Plugin
{

    [ComVisible(true)]
    [Guid("CEB937B5-4C61-4E52-819C-274974CC1FBC"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IFilterItem
    {
    }


    [ComVisible(true)]
    [Guid("63B0C234-E3E0-458C-B239-CFF1AC22DF24"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IFilterCriterion
    {
        string Name
        {
            [return: MarshalAs(UnmanagedType.BStr)]
            get;
            [param: MarshalAs(UnmanagedType.BStr)]
            set;
        }


        object Value
        {
            get;
            set;
        }


        TFilterComparison Comparison
        {
            get;
            set;
        }
    }
    

    [ComVisible(true)]
    [Guid("7D6F9830-30BB-453D-8924-803938EFF7A8"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IFilterCriteria
    {
        int GetCount();
        IFilterItem First();
        int IndexOf(IFilterItem Item);
        int Add(IFilterItem Item);

        IFilterCriterion AddFilterCriterion(string Name,object Value,TFilterComparison Comparison = TFilterComparison.cop_EqualTo);
        IFilterCriteria AddFilterCriteria(TFilterBooleanOperator BooleanOperator = TFilterBooleanOperator.lop_AND);
        void Insert(int Index,IFilterItem Item);
        IFilterItem Last();
        int Remove(IFilterItem Item);

        IFilterItem[] Items
        {
            get;
            set;
        } 

    
        int Count
        {
            get;
        }


        TFilterBooleanOperator BooleanOperator
        {
            get;
            set;
        }

    }


    #region Enum Types

    public enum TFilterComparison
    {
        cop_EqualTo, cop_NotEqualTo, cop_Like, cop_not_Like,
        cop_GreaterThan, cop_LessThan, cop_GreaterThanOrEqualTo, cop_LessThanOrEqualTo,
        cop_In
    };


    public enum TFilterBooleanOperator
    {
        lop_AND, lop_OR
    };

    #endregion

}



