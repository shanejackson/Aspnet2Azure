﻿using System.ComponentModel.DataAnnotations;

namespace MvcNorthwind.Models.Northwind
{
    [MetadataType(typeof(CategoryMetaData))]
    public partial class Category { }
    public class CategoryMetaData
    {
        [Required]
        [Display(Name = "Category")]
        public object CategoryName { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "The {0} must be between {2} and {1} characters.", MinimumLength = 5)]
        public object Description { get; set; }
    }
}
