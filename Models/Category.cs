using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace assignment2WebApp.Models
{
    [Table("categories")]
    [Index(nameof(CategoryName), Name = "category_name")]
    public partial class Category
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        [Key]
        [Column("category_id")]
        public int CategoryId { get; set; }
        [Column("category_name")]
        [StringLength(15)]
        public string CategoryName { get; set; } = null!;
        [Column("description")]
        public string? Description { get; set; }

        [InverseProperty(nameof(Product.Category))]
        public virtual ICollection<Product> Products { get; set; }
    }
}
