﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudViper.Core.Entities
{
    public class MaritalStatus
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The field Name is required")]
        [StringLength(40, ErrorMessage = "The field Name must have max length of 40 characters")]
        [DataType(DataType.Text, ErrorMessage = "The field Name must be a string")]
        public String Name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
