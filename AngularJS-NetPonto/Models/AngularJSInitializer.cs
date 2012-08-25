using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using AngularJS_NetPonto.Models;

namespace AngularJS_NetPonto.Models
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
        }
    }
}