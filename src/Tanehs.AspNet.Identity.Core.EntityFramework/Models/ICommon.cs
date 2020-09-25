namespace Tanehs.AspNet.Identity.Core.EntityFramework.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public interface ICommon
    {
        string CreatedBy { get; set; }
        DateTime? CreationDt { get; set; }
        string ModifiedBy { get; set; }
        DateTime? ModifiedDt { get; set; }
        int AuthorizationStatus { get; set; }
        int OperationStatus { get; set; }
        string AuthorizedBy { get; set; }
        DateTime? AuthorizedDt { get; set; }
        DateTime SystemDt { get; set; }
    }
}
