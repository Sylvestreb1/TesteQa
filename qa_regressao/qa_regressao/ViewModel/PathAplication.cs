using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ranorex;



namespace qa_regressao.ViewModel
{
    class PathAplication
    {
        public static int Aplication_Web(string pathurl, string chrome)
        {
            Mouse.DefaultMoveTime = 150;
            Keyboard.DefaultKeyPressTime = 5;
            Delay.SpeedFactor = 1.00;

            return Ranorex.Host.Current.OpenBrowser(pathurl, chrome);
        }

        public static int DeskTop(string Modulo, string Path)
        {
            Mouse.DefaultMoveTime = 10;
            Keyboard.DefaultKeyPressTime = 5;
            Delay.SpeedFactor = 1.00;

            return Host.Local.RunApplication(Modulo, "", Path, false);
        }
    }
}
