namespace Tanehs.AspNet.Identity.Core.EntityFramework.Stores
{
    using Tanehs.AspNet.Identity.Core.EntityFramework.Models;
    using Microsoft.AspNet.Identity.EntityFramework;   
    using Microsoft.AspNet.Identity;

    public class ApplicationUserStore : UserStore<User>
    {
        public ApplicationUserStore(DataAccessLayer.ApplicationDbContext context) : base(context)
        {

        }
    }
}
