using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace assignment2WebApp.Models
{
    [Table("customers")]
    [Index(nameof(City), Name = "city")]
    [Index(nameof(CompanyName), Name = "company_name")]
    [Index(nameof(PostalCode), Name = "postal_code")]
    [Index(nameof(Region), Name = "region")]
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        [Column("customer_id")]
        [StringLength(5)]
        public string CustomerId { get; set; } = null!;
        [Column("company_name")]
        [StringLength(40)]
        public string CompanyName { get; set; } = null!;
        [Column("contact_name")]
        [StringLength(30)]
        public string? ContactName { get; set; }
        [Column("contact_title")]
        [StringLength(30)]
        public string? ContactTitle { get; set; }
        [Column("address")]
        [StringLength(60)]
        public string? Address { get; set; }
        [Column("city")]
        [StringLength(15)]
        public string? City { get; set; }
        [Column("region")]
        [StringLength(15)]
        public string? Region { get; set; }
        [Column("postal_code")]
        [StringLength(10)]
        public string? PostalCode { get; set; }
        [Column("country")]
        [StringLength(15)]
        public string? Country { get; set; }
        [Column("phone")]
        [StringLength(24)]
        public string? Phone { get; set; }
        [Column("fax")]
        [StringLength(24)]
        public string? Fax { get; set; }

        [InverseProperty(nameof(Order.Customer))]
        public virtual ICollection<Order> Orders { get; set; }
    }
}
