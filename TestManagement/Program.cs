using TestManagement.Forms;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCase testCase = new TestCase("TestName", "TestDocumentation", new List<string>() { "a", "b", "c", "d" }, "TestExpectedResultShalalalalalallaTestExpectedResultShalalalalalalla", 1, false, false);
            GUI_TestCase TestCaseForm = new GUI_TestCase(testCase);
            Application.Run(TestCaseForm);
        }
    }
}
