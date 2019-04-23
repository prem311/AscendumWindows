using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestStack.White;

namespace PracticeWindowsAutomation
{
    public class ConfigApp
    {
        private string appPath;
        private string getWinName;


        public string winApp()
        {
            appPath = "C:\\Users\\Rajeshwari.prem\\source\\repos\\PracticeWindowsAutomation\\PracticeWindowsAutomation\\winapplication\\WindowsFormsTestApplication.exe";
            return AppPath;
            
        }

        public string winName()
        {
            getWinName = "MainWindow";
            return getWinName;
        }





        public string AppPath
        {
            get
            {
                return appPath;
            }
        }

        public string getWindowName
        {
            get
            {
                return getWinName;
            }
        }
    }
}
