using System.Data.Entity;
using Dig.Data.Models;
using Dig.Data.Models.Mock;

namespace Dig.MvcWeb.Models
{
	public class DigDbContext : DbContext
	{
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, add the following
        // code to the Application_Start method in your Global.asax file.
        // Note: this will destroy and re-create your database with every model change.
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<webapiCodeFirst.Models.EventsContext>());

        public DigDbContext() : base("name=DigDbContext")
        {
        }

		public DbSet<Event> Events { get; set; }
		public DbSet<Variety> Varieties { get; set; }
		public DbSet<RefVarietyType> RefVarieties { get; set; }
	}
}
