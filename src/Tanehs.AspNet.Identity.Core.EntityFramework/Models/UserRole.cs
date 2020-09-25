namespace Tanehs.AspNet.Identity.Core.EntityFramework.Models
{
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class UserRole : IdentityUserRole, ICommon
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

    }
}
