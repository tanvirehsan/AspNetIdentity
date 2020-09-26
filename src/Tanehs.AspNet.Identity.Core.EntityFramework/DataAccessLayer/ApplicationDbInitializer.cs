namespace Tanehs.AspNet.Identity.Core.EntityFramework.DataAccessLayer
{
    using System.Data.Entity;
    // This is useful if you do not want to tear down the database each time you run the application.
    // public class ApplicationDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    // This example shows you how to create a new database if the Model changes
    public class ApplicationDbInitializer :   DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        { 
            base.Seed(context);
        }
    }
}
