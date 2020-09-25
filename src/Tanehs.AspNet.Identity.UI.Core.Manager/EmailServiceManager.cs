namespace Tanehs.AspNet.Identity.UI.Core.Manager.EntityFramework
{
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;

    public class EmailServiceManager : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Plug in your email service here to send an email.
            return Task.FromResult(0);
        }
    }

}