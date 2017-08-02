using System.Runtime.InteropServices;

namespace SigmaNEST.Plugin
{
    public static class SNPluginTypes
    {
        public const int AuthorizationType_None = 0;
        public const int AuthorizationType_LicenseFile = 1;

        public const int ButtonLocation_Default = 0;
        public const int ButtonLocation_WorkSpace = 1;
        public const int ButtonLocation_CAD = 2;
        public const int ButtonLocation_NestingManual = 3;
        public const int ButtonLocation_NestingNC = 4;
        public const int ButtonLocation_NestingDetail = 5;
        public const int ButtonLocation_PartMode = 6;
        public const int ButtonLocation_PartModeDetail = 7;
        public const int ButtonLocation_Help = 8;
        public const int ButtonLocation_Modify = 9;
    }
}
