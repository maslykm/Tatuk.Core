using System;
using TatukGIS.NDK;
using TatukGIS.NDK.Common;

namespace SimpleMap
{
    public class Program
    {
        [STAThread]
        static void Main()
        {
            GisLicense.Initialize();

            using TGIS_ViewerBmp viewer = new TGIS_ViewerBmp();
        }
    }
}
