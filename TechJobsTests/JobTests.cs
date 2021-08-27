using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobsTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job first_job = new Job();
            Job second_job = new Job();
            Assert.IsFalse(first_job.Id.Equals(second_job.Id));
        }

        [TestMethod]
        public void TestJobConstructorSetsAllFields()
        {
            Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Product tester", test_job.Name);
            Assert.AreEqual("ACME", test_job.EmployerName.ToString());
            Assert.AreEqual("Desert", test_job.EmployerLocation.ToString());
            Assert.AreEqual("Quality control", test_job.JobType.ToString());
            Assert.AreEqual("Persistence", test_job.JobCoreCompetency.ToString());
        }

        [TestMethod]
        public void TestJobsForEquality()
        {
            Job first_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Job second_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsFalse(first_job.Equals(second_job));
        }

        [TestMethod]
        public void TestForBlankLines()
        {
            Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.IsTrue(test_job.ToString().StartsWith("\n"));
            Assert.IsTrue(test_job.ToString().EndsWith("\n"));
        }

        [TestMethod]
        public void TestForLabelDataAndNewLine()
        {
            Job test_job = new Job("Product tester", new Employer("ACME"), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("\n" + "ID: " + test_job.Id + "\n", test_job.ToString());
        }

        [TestMethod]
        public void TestForEmptyField()
        {
            Job test_job = new ("Product tester", new Employer(), new Location("Desert"), new PositionType("Quality control"), new CoreCompetency("Persistence"));
            Assert.AreEqual("Data not available", test_job.EmployerName.ToString());
        }
    }
}
