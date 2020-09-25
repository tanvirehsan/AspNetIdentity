namespace Tanehs.AspNet.Identity.UI.Core.Manager.EntityFramework
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.Owin;
    using Microsoft.Owin;
    using Tanehs.AspNet.Identity.Core.EntityFramework.Models;
    using Tanehs.AspNet.Identity.Core.EntityFramework.DataAccessLayer;
    using Tanehs.AspNet.Identity.Core.EntityFramework.Stores;

    // Configure the application role manager to use in this application. RoleManager is defined in ASP.NET Identity and can be used by the application.
    public class ApplicationRoleManager : RoleManager<Role>
    {
        public ApplicationRoleManager(IRoleStore<Role, string> roleStore) : base(roleStore)
        {

        }

        public static ApplicationRoleManager Create(IdentityFactoryOptions<ApplicationRoleManager> options, IOwinContext context)
        {
            ApplicationRoleStore roleStore = new ApplicationRoleStore(context.Get<ApplicationDbContext>());
            return new ApplicationRoleManager(roleStore);
        }
    }
}