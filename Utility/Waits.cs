using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDAutomationFramework.Utility
{
    public class Waits
    {

        public static void waitFor(int sec)
        {
         Thread.Sleep(sec * 1000);
        }

      
    }
}
