namespace Tanehs.AspNet.Identity.Core.EntityFramework.Models
{
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;   
    using System;
    using System.Security.Claims;
    using System.Threading.Tasks;


    public class User : IdentityUser, ICommon
    {
        public string CreatedBy { get; set; }
        public DateTime? CreationDt { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDt { get; set; }
        public int AuthorizationStatus { get; set; }
        public int OperationStatus { get; set; } = (int)EntityFramework.Enum.OperationStatus.ADD;
        public string AuthorizedBy { get; set; }
        public DateTime? AuthorizedDt { get; set; }
        public DateTime SystemDt { get; set; } = DateTime.Now;


        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

    }
}
