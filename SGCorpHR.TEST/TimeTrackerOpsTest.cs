using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SGCorpHR.BLL;
using SGCorpHR.Models;

namespace SGCorpHR.TEST
{
    [TestFixture]
    public class TimeTrackerOpsTest
    {
        [Test]
        public void TimesheetOperationsTest()
        {
            TimeTrackerOperations ops = new TimeTrackerOperations();
          var response = ops.GetTimeTrackerSummary(6);
            Assert.IsTrue(response.Success);
            Assert.AreEqual(4, response.Data.AllTimesheets.Count);
        }

        [Test]
        public void GetAllEmployeesTest()
        {
            TimeTrackerOperations ops = new TimeTrackerOperations();
            var response = ops.GetAllEmployees();
            Assert.AreEqual(13, response.Data.Count);
        }
    }
}
