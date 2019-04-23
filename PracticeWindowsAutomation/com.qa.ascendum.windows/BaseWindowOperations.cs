using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems;
using TestStack.White.UIItems.TabItems;

namespace PracticeWindowsAutomation
{
    public class BaseWindowOperations
    {
        Application app;
        public static Window window;
        ConfigApp con = new ConfigApp();

        public Application launchWindowsApp()
        {
            app = Application.Launch(con.winApp());
            var windows = app.GetWindows();
            window = windows.Find(x => x.Name == con.winName());
            return app;
        }

        //closes the application launched
        public void closeApp()
        {
            app.Close();
        }

        //Kills the application thats specified
        public void killApp()
        {
            app.Kill();
        }

        //clicks on the particular element specified - AutomationID
        public void clickTab(string elementLocator)
        {
            Tab clickTab = window.Get<Tab>(SearchCriteria.ByClassName(elementLocator));
            clickTab.Click();

        }

        //gets the number of the textBox present on the window
        public void enterText(string elementLocator, string textToBeEntered)
        {
            TextBox enterText = window.Get<TextBox>(SearchCriteria.ByAutomationId(elementLocator));
            enterText.Enter(textToBeEntered);
            Console.Write(textToBeEntered);

        }


        //Clicks on a button specified
        public void clickButton(string elementLocator)
        {
            Button button = window.Get<Button>(SearchCriteria.ByAutomationId(elementLocator));
            button.Click();
        }

        //Assert if the title is valid based on the element specified
        public string getTitleText(string elementLocator)
        {
            TitleBar titleBar = window.Get<TitleBar>(SearchCriteria.ByAutomationId(elementLocator));
            Console.Write(titleBar.ToString());
            return titleBar.ToString();
        }

        //get elemets text
        public string getText(string elementLocator)
        {
            Label textBox = window.Get<Label>(SearchCriteria.ByAutomationId(elementLocator));
            return textBox.ToString();

        }
    }
    
}
