using SimpleAutocompleteAndSearch.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace SimpleAutocompleteAndSearch.Controllers
{
    public class JobsController : ApiController
    {
        //IJobsRepository _repo;

        //public JobsController(IJobsRepository repo)
        //{
        //    _repo = repo;
        //}

        [System.Web.Http.HttpGet]
        public JsonResult SearchJobsTitle(string str, int count)
        {
            using (JobsContext db = new JobsContext())
            {
                IJobsRepository _repo = new JobsRepository(db);

                return new JsonResult()
                {

                    Data = _repo.SearchJobsTitle(str, count).ToList(),
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                };
            }
        }

        [System.Web.Http.HttpGet]
        public JsonResult SearchJobsByTitle(string title, int count)
        {
            using (JobsContext db = new JobsContext())
            {
                IJobsRepository _repo = new JobsRepository(db);
                
                return new JsonResult()
                {
                    Data = _repo.SearchJobsByTitle(title, count).ToList(),
                    JsonRequestBehavior = JsonRequestBehavior.AllowGet,
                };
            }            
        }
    }
}
