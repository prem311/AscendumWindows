using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestStack.White;

namespace PracticeWindowsAutomation.com.qa.ascendum.windows
{
    [TestFixture]
    public class TestBase
    {
        BaseWindowOperations baseWinOps = new BaseWindowOperations();

        [OneTimeSetUp]
        public void launchApp()
        {
            baseWinOps.launchWindowsApp();
        }

        [OneTimeTearDown]
        public void kill()
        {
            baseWinOps.killApp();
        }

    }
}
