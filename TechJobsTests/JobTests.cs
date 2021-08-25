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
    }
}
