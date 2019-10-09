using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleAutocompleteAndSearch.Data
{
    public class Jobs
    {
        public int Id { get; set; }
        public string JobDescription { get; set; }
        public int LuJobTitleId { get; set; }
    }
}