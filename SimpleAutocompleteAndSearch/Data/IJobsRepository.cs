using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAutocompleteAndSearch.Data
{
    public interface IJobsRepository
    {
        IQueryable<string> SearchJobsTitle(string str, int count);
        IQueryable<JobTitlesAndDescriptions> SearchJobsByTitle(string title, int count);
    }
}