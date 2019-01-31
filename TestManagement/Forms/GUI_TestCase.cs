using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TestManagement;
using TestManagement.Forms;

namespace ConsoleApp2.Forms
{
    public partial class GUI_TestCase : Form
    {
        private TestCase initialTestCase = new TestCase();
        private TestCase _currentTestCase = new TestCase();


        public GUI_TestCase(TestCase testCase)
        {
            InitializeComponent();
            initialTestCase = testCase;
            Documentation.Text = initialTestCase.Documentation;
            TestName.Text = initialTestCase.Name;
            ExpectedResult.Text = initialTestCase.ExpectedResult;

            var stepsCounter = 0;
            foreach (string step in initialTestCase.TestSteps)
            {
                FormControls.AddTextBox(this, "Step" + stepsCounter, step, new Point(20, 170 + stepsCounter * 20));
                stepsCounter++;
            }
            _currentTestCase = CloneClass.Clone<TestCase>(initialTestCase);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            initialTestCase.Name = TestName.Text;
            initialTestCase.Documentation = Documentation.Text;
            initialTestCase.ExpectedResult = ExpectedResult.Text;
            var _currentSteps = new List<string>();
            for (int i = 0; i < _currentTestCase.TestSteps.Count; i++)
                _currentSteps.Add((Controls["Step" + i] as TextBox).Text);
            initialTestCase.AddSteps(_currentSteps);
            Close();
        }

        private void AddStep_Click(object sender, EventArgs e)
        {
            _currentTestCase.TestSteps.Add("");
            FormControls.AddTextBox(this, "Step" + (_currentTestCase.TestSteps.Count - 1), "", new Point(20, 150 + _currentTestCase.TestSteps.Count * 20));
        }
    }
}
