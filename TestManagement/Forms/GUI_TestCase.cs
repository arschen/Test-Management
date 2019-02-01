using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TestManagement;
using TestManagement.Forms;

namespace TestManagement.Forms
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
                FormControls.AddTestCaseField(this, stepsCounter, step, new Point(20, 170 + stepsCounter * 20), new EventHandler(AddStep), new EventHandler(RemoveStep));
                stepsCounter++;
            }
            _currentTestCase = CloneClass.Clone(initialTestCase);
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
            TextFieldsToSteps();
            _currentTestCase.TestSteps.Add("");
            FormControls.AddTestCaseField(this, (_currentTestCase.TestSteps.Count - 1), "", new Point(20, 150 + _currentTestCase.TestSteps.Count * 20 - VerticalScroll.Value), new EventHandler(AddStep), new EventHandler(RemoveStep));
        }

        private void AddStep(object sender, EventArgs e)
        {
            TextFieldsToSteps();
            var ID = int.Parse((sender as Button).Name.Remove(0, 1)) + 1;
            if (ID == _currentTestCase.TestSteps.Count)
                _currentTestCase.TestSteps.Add("");
            else
                _currentTestCase.TestSteps.Insert(ID, "");
            FormControls.AddTestCaseField(this, _currentTestCase.TestSteps.Count - 1, "", new Point(20, 150 + _currentTestCase.TestSteps.Count * 20 - VerticalScroll.Value), new EventHandler(AddStep), new EventHandler(RemoveStep));
            StepsToTextFields();
        }

        private void RemoveStep(object sender, EventArgs e)
        {
            var ID = int.Parse((sender as Button).Name.Remove(0, 1));
            TextFieldsToSteps();
            Controls.Remove(Controls["-" + (_currentTestCase.TestSteps.Count - 1)]);
            Controls.Remove(Controls["+" + (_currentTestCase.TestSteps.Count - 1)]);
            Controls.Remove(Controls["Step" + (_currentTestCase.TestSteps.Count - 1)]);
            _currentTestCase.TestSteps.RemoveAt(ID);
            StepsToTextFields();
        }

        private void TextFieldsToSteps()
        {
            for (int i = 0; i < _currentTestCase.TestSteps.Count; i++)
                _currentTestCase.TestSteps[i] = (Controls["Step" + i] as TextBox).Text;
        }

        private void StepsToTextFields()
        {
            for (int i = 0; i < _currentTestCase.TestSteps.Count; i++)
                (Controls["Step" + i] as TextBox).Text = _currentTestCase.TestSteps[i];
        }
    }
}
