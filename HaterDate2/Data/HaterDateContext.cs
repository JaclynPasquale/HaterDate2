using HaterDate2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HaterDate2.Data
{
    public class HaterDateContext : DbContext
    {
        public HaterDateContext() : base("DefaultConnection")
        {

        }

        public DbSet<Hate> Hates { get; set; }
        public DbSet<Profile> Profiles { get; set; }
    }
}