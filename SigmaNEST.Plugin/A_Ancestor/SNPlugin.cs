using SigmaNEST;
using System;
using System.Linq;

namespace SigmaNEST.Plugin
{
    public class SNPlugin : ISNPlugin
    {
        #region Private Fields

        private ISNApp FSNApp;
        private ISNPokeIntf FSNPoke;

        #endregion

        #region Properties

        public ISNApp SNApp
        {
            get
            {
                return FSNApp;
            }
        }

        public string Author { get; set; }

        public string AuthorizationGUID { get; set; }

        public byte AuthorizationType { get; set; }

        public string ButtonDescription { get; set; }

        public int[] ButtonLocations { get; set; }

        public bool ButtonOnLocation(byte AButtonLocation)
        {
            return ButtonLocations.Contains(AButtonLocation);
        }

        public bool CanConfigure
        {
            get
            {
                return ConfigCallback != null;
            }
        }

        public bool CanExecute
        {
            get
            {
                return ExecuteCallback != null;
            }
        }

        public double DateCreated { get; set; }

        public string PlugInDescription { get; set; }

        public string PlugInExplenation { get; set; }

        public string Version { get; set; }

        #endregion

        #region Methods

        public void Configure(string AParameters)
        {
            DoConfigure(ConfigCallback, AParameters);
        }

        private void DoConfigure(Action<string> callback, string parameters)
        {
            callback?.Invoke(parameters);
        }

        public Action<string> ConfigCallback { get; set; }

        public void Execute(string AParameters)
        {
            DoExecute(ExecuteCallback, AParameters);
        }

        private void DoExecute(Action<string> callback, string parameters)
        {
            callback?.Invoke(parameters);
        }

        public Action<string> ExecuteCallback { get; set; }

        #endregion

        #region Constructor

        public SNPlugin(ISNApp ASNApp, ISNPokeIntf ASNPoke)
        {
            FSNApp = ASNApp;
            FSNPoke = ASNPoke;
        }

        #endregion

        #region Utility Methods

        public int Poke(ref double AI1, ref double AI2, ref double AI3, ref string AS1, ref string AS2, ref string AS3)
        {
            return (FSNPoke != null) ? FSNPoke.Poke(ref AI1, ref AI2, ref AI3, ref AS1, ref AS2, ref AS3) : 0;
        }

        public int Poke(ref double AI1, ref double AI2, ref double AI3)
        {
            string LTempString = "";
            return Poke(ref AI1, ref AI2, ref AI3, ref LTempString, ref LTempString, ref LTempString);
        }

        public string GetConfigFile_PathNameExt(string AExtension = "INI", byte AFileNumber = 0)
        {
            double LTempDouble = 0;
            double LIniFileNumber = AFileNumber;
            double LCallNr = 2;
            string LIniFileName = "";
            string LTempString = "";
            Poke(ref LCallNr, ref LIniFileNumber, ref LTempDouble, ref AExtension, ref LIniFileName, ref LTempString);
            return LIniFileName;
        }

        #endregion
    }
}
