using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CloudViper.Core.Entities.Common
{
    public abstract class AuditableEntity<T> : IAuditableEntity
    {
        [Key]
        public int Id { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.Text)]
        public string CreatedBy { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.DateTime)]
        public DateTime LastUpdatedDate { get; set; }

        [ScaffoldColumn(false)]
        [DataType(DataType.Text)]
        public string LastUpdatedBy { get; set; }
    }
}