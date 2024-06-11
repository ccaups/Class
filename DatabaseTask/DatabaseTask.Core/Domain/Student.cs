using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic; // For ICollection

namespace DatabaseTask.Core.Domain
{
    public class Student
    {
        [Key]
        public Guid StudentID { get; set; }

        [Required]
        [StringLength(50)] // Adjust max length as needed
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)] // Adjust max length as needed
        public string LastName { get; set; }

        // Read-only FullName property for convenience
        [NotMapped]
        public string FullName => $"{FirstName} {LastName}";

        // Foreign Key (FK) Relationship (Modified to int based on your SQL script)
        public Guid ClassCode { get; set; }
        [ForeignKey("ClassCode")]
        public virtual Class Class { get; set; }

        // Navigation property for the FoodCoupons (explicitly using List)
        public virtual ICollection<FoodCoupon> FoodCoupons { get; set; } = new List<FoodCoupon>();
    }
}
