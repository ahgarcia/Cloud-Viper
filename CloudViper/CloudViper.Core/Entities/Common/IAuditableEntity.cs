using System;
using System.Collections.Generic;
using System.Text;

namespace CloudViper.Core.Entities.Common
{
    public interface IAuditableEntity
    {
        int Id { get; set; }

        DateTime CreatedDate { get; set; }

        string CreatedBy { get; set; }

        DateTime LastUpdatedDate { get; set; }

        string LastUpdatedBy { get; set; }
    }
}
