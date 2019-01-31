using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    [Serializable]
    public class TestCase
    {
        // TestCase properties
        public int ProjectID { get; }
        public string Name;
        public List<string> TestSteps = new List<string>();
        public string Documentation;
        public string ExpectedResult;
        public bool IsRedundant;
        public bool IsAutomated;

        // Execution properties
        public List<DateTime> DatesExecuted { get; }
        public List<bool> StatusOfLastExecution { get; }
        public List<string> VersionsForExecution { get; }

        // Constructors
        public TestCase() { }

        public TestCase(string name, string documentation, List<string> testSteps, string expectedResult, int projectID, bool isRedundant, bool isAutomated)
        {
            Name = name;
            Documentation = documentation;
            TestSteps = testSteps;
            ExpectedResult = expectedResult;
            ProjectID = projectID;
            IsRedundant = isRedundant;
            IsAutomated = isAutomated;
            DatesExecuted = new List<DateTime>();
            StatusOfLastExecution = new List<bool>();
            VersionsForExecution = new List<string>();
        }

        // Methods
        public void SetToRedundant() { IsRedundant = true; }

        public void SetToAutomated() { IsAutomated = true; }

        public void AddExecution(DateTime date, bool status, string version)
        {
            DatesExecuted.Add(date);
            StatusOfLastExecution.Add(status);
            VersionsForExecution.Add(version);
        }

        public void AddSteps(List<string> steps)
        {
            TestSteps = steps;
        }
    }
}
