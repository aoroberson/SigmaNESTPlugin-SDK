using System;
using System.Windows.Forms;
//====================================================================================
//=====================     THIS SHOULD NOT BE CHANGED    ============================
//====================================================================================
// Unit Name: STDBEventTypes.cs
// Author:    Anton.Steyn
// Date:      13-June-2012
//====================================================================================

namespace SigmaNEST.Plugin
{

    public delegate object TProgressUpdate(object sender, int part, int total);
    public delegate int TMessageDialogCallBack(TPromptKind PromptKind, MessageBoxButtons Buttons, string ExtraText = "");
    public delegate Exception TNotImplementedException();
   
}
