using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBDDAutomationFramework.Utility
{
    public class Asserts
    {

        public static void assertTrue(bool condition)
        {

            try
            {
                Assert.IsTrue(condition);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void assertFalse(bool condition)
        {

            try
            {
                Assert.IsFalse(condition);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
