﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CloudViper.Core.Entities.Common;

namespace CloudViper.Core.Entities
{
    public class ProductInventory : BaseEntity
    {
        [ForeignKey("Product")]
        [Required(ErrorMessage = "The field ProductId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field ProductId must be a number.")]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        [ForeignKey("Site")]
        [Required(ErrorMessage = "The field SiteId is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field SiteId must be a number.")]
        public int SiteId { get; set; }
        public Site Site { get; set; }

        [Required(ErrorMessage = "The field UnitsInStock is required")]
        [Range(0, int.MaxValue, ErrorMessage = "The field UnitsInStock must be a number.")]
        public int UnitsInStock { get; set; }
    }
}
