namespace Tanehs.AspNet.Identity.Core.EntityFramework.DataAccessLayer
{
    using System.Data.Entity;
    //Use DropCreateDatabaseIfModelChanges<ApplicationDbContext> when Code Migration is Disabled
    //Use CreateDatabaseIfNotExists<ApplicationDbContext> when you will add your own seed method 
    public class ApplicationDbInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        { 
            //Add Here Custom Code for initialization of the database for first time creation
            //------------------Custom Initialization Code for your Database While Creating for the First Time




            //------------------------------------------
            base.Seed(context);
        }
    }
}
