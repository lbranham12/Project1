using MissionSite.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MissionSite.DAL
{
    public class MissionSiteContext:DbContext
    {
          public MissionSiteContext()
            : base("MissionSiteContext")
        {

        }
        //this page is the context page
        public DbSet<Mission> mission { get; set; }
        public DbSet<Users> users { get; set; }
        public DbSet<MissionQuestion> questions { get; set; }

       
    }
}