using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAutocompleteAndSearch.Controllers;
using SimpleAutocompleteAndSearch.Data;

namespace SimpleAutocompleteAndSearch.Tests.Controllers
{
    [TestClass]
    public class JobsControllerTest
    {
        private JobsController _ctrl;

        [TestInitialize]
        public void init()
        {
            _ctrl = new JobsController(new Fakes.FakeJobRepository());
        }

        [TestMethod]
        public void JobsController_SearchJobsTitle()
        {
            var results = _ctrl.SearchJobsTitle("Bus", 10);

            Assert.IsNotNull(results);
            Assert.IsInstanceOfType(results.Data, typeof(List<string>));
            Assert.IsTrue(((List<string>)results.Data).Count > 0);
        }

        [TestMethod]
        public void JobsController_SearchJobsByTitle()
        {
            var results = _ctrl.SearchJobsByTitle("Full Stack Developer", 10);

            Assert.IsNotNull(results);
            Assert.IsInstanceOfType(results.Data, typeof(List<JobTitlesAndDescriptions>));
            Assert.IsTrue(((List<JobTitlesAndDescriptions>)results.Data).Count > 0);
        }
    }
}
