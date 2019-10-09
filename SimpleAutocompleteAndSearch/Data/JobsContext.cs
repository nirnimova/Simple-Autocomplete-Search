using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SimpleAutocompleteAndSearch.Data
{
    public class JobsContext : DbContext
    {
        public JobsContext() : base("DefaultConnection")
        {

        }

        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<LuJobTitle> LuJobTitle { get; set; }
    }
}