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
    }
}
