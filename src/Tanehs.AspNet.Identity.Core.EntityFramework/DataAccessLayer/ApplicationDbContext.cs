namespace Tanehs.AspNet.Identity.Core.EntityFramework.DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Tanehs.AspNet.Identity.Core.EntityFramework.Models;

    public class ApplicationDbContext : IdentityDbContext<User>
    {
        
        private static void InitializeDatabase()
        { 
            Database.SetInitializer(new ApplicationDbInitializer());
        }
        
        public ApplicationDbContext(string nameOrConnectionString= "DefaultConnection") : base(nameOrConnectionString, throwIfV1Schema: false)
        {
            InitializeDatabase();
        }

        public static ApplicationDbContext Create()
        {
           
            return new ApplicationDbContext();
        }

        public static ApplicationDbContext Create(string nameOrConnectionString= "DefaultConnection")
        {
            return new ApplicationDbContext(nameOrConnectionString);
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            if (modelBuilder == null)
            {
                throw new ArgumentNullException("modelBuilder");
            }

            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            #region Renaming The Identiy Tables 
            // Change the name of Default Tables Created by Identity Entity Framework   
            modelBuilder.Entity<User>().ToTable("User").Property(x=>x.Id).HasColumnName("UserID"); 
            modelBuilder.Entity<IdentityUserRole>().ToTable("UserRole"); 
            modelBuilder.Entity<IdentityUserLogin>().ToTable("UserLogin");
            modelBuilder.Entity<IdentityUserClaim>().ToTable("UserClaim").Property(x => x.Id).HasColumnName("UserClaimID");
            modelBuilder.Entity<IdentityRole>().ToTable("Roles").Property(x => x.Id).HasColumnName("RoleID");

            #endregion
        }
    }
}
