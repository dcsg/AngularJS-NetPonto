using System.Data.Entity;

namespace AngularJS_NetPonto.Models
{
    public class AngularJS_NetPontoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<AngularJS_NetPonto.Models.AngularJS_NetPontoContext>());

        public AngularJS_NetPontoContext() : base("name=AngularJS_NetPontoContext")
        {
        }

        public DbSet<Process> Processes { get; set; }
    }
}
