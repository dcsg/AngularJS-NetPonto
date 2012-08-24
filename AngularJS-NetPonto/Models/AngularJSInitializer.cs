using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AngularJS_NetPonto.Models;

namespace AngularJS_NetPonto.DAL
{
    public class AngularJSInitializer : DropCreateDatabaseIfModelChanges<AngularJS_NetPontoContext>
    {
        protected override void Seed(AngularJS_NetPontoContext context)
        {
            var processes = new List<Process>
            {
                new Process { name = "Gestão de Recursos",  description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec massa est, adipiscing quis feugiat quis.",                acronym = "GR" },
                new Process { name = "User Interface",      description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque hendrerit fermentum lobortis. Vestibulum ac auctor.",   acronym = "UI" },
                new Process { name = "Arquitectura",        description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Mauris a dui odio. Quisque eleifend urna.",                     acronym = "AR" },
                new Process { name = "Gestão de Projectos", description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec nec nisi elit. Sed ante purus.",                          acronym = "GP" }
            };
            processes.ForEach(s => context.Processes.Add(s));
            context.SaveChanges();

            var activities = new List<Activity>
            {
                new Activity { name = "Implementação",      description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec massa est, adipiscing quis feugiat quis.", },
                new Activity { name = "Desenvolvimento",    description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec massa est, adipiscing quis feugiat quis.", },
                new Activity { name = "Brainstorm",         description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec massa est, adipiscing quis feugiat quis.", },
                new Activity { name = "Conceção",           description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec massa est, adipiscing quis feugiat quis.", },
                new Activity { name = "Projecto",           description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec massa est, adipiscing quis feugiat quis.", }
            };
            activities.ForEach(s => context.Activities.Add(s));
            context.SaveChanges();

            var activitiesProcesses = new List<ActivityProcess>
            {
                new ActivityProcess { ProcessID = 1, ActivityID = 1 },
                new ActivityProcess { ProcessID = 1, ActivityID = 2 },
                new ActivityProcess { ProcessID = 1, ActivityID = 3 },
                new ActivityProcess { ProcessID = 2, ActivityID = 4 },
                new ActivityProcess { ProcessID = 2, ActivityID = 3 },
                new ActivityProcess { ProcessID = 2, ActivityID = 2 },
                new ActivityProcess { ProcessID = 3, ActivityID = 1 },
                new ActivityProcess { ProcessID = 4, ActivityID = 1 },
                new ActivityProcess { ProcessID = 4, ActivityID = 2 }
            };
            activitiesProcesses.ForEach(s => context.ActivityProcesses.Add(s));
            context.SaveChanges();
        }
    }
}