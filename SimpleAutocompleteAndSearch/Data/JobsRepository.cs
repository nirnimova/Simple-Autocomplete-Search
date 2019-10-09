using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAutocompleteAndSearch.Data
{
    public class JobsRepository : IJobsRepository
    {
        private JobsContext db;

        public JobsRepository(JobsContext db)
        {
            this.db = db;
        }

        public IQueryable<string> SearchJobsTitle(string str, int count) => (
            from jt in db.LuJobTitle.AsQueryable()
            where jt.JobTitleText.Contains(str)
            select jt.JobTitleText).Take(count).Distinct();

        public IQueryable<JobTitlesAndDescriptions> SearchJobsByTitle(string title, int count) => (
            from jb in db.Jobs.AsQueryable()
            join jt in db.LuJobTitle.AsQueryable() on jb.LuJobTitleId equals jt.Id
            where jt.JobTitleText == title
            select new JobTitlesAndDescriptions()
            {
                jobTitle = jt.JobTitleText,
                jobDescription = jb.JobDescription,
            }).Take(count).Distinct();
    }
}