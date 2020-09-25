namespace Tanehs.AspNet.Identity.Core.EntityFramework.Stores
{
    using Tanehs.AspNet.Identity.Core.EntityFramework.Models;
    using Microsoft.AspNet.Identity.EntityFramework;

    public class ApplicationRoleStore  : RoleStore<Role>
    {
        public ApplicationRoleStore(DataAccessLayer.ApplicationDbContext context) : base(context)
        {

        }
    }
}
