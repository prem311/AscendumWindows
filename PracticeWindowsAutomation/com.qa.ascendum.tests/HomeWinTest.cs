using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PracticeWindowsAutomation.com.qa.ascendum.windows;

namespace PracticeWindowsAutomation.com.qa.ascendum.tests
{
    public class HomeWinTest : TestBase
    {

        BaseWindowOperations baseWinOps = new BaseWindowOperations();

        [Test]
        public void launch()
        {
            Process.GetCurrentProcess();
            baseWinOps.clickButton("OpenMessageBox");
            baseWinOps.getText("65535");
            baseWinOps.clickButton("2");
            
            baseWinOps.clickButton("DragDropScenario");
            baseWinOps.enterText("TextBox", "Test to be entered");
            Process.GetCurrentProcess().Close();
  
           
        }

    }
}
