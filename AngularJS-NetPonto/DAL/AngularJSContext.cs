using System;
using System.Collections.Generic;
using System.Data.Entity;
using AngularJS_NetPonto.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace AngularJS_NetPonto.DAL
{
    public class AngularJSContext : DbContext
    {
        public DbSet<Process> Processes { get; set; }
        public DbSet<Activity> Activities { get; set; }
        public DbSet<ActivityProcess> ActivitiesProcesses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}