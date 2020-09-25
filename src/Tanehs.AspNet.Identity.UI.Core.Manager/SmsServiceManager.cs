namespace Tanehs.AspNet.Identity.UI.Core.Manager.EntityFramework
{
    using System.Threading.Tasks;
    using Microsoft.AspNet.Identity;


    public class SmsServiceManager : IIdentityMessageService
    {
        public Task SendAsync(IdentityMessage message)
        {
            // Plug in your SMS service here to send a text message.
            return Task.FromResult(0);
        }
    }
}