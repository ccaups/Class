using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class Student
    {
        [Key]
        public Guid StudentID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        // Foreign Key (FK) Relationship
        public Guid ClassCode { get; set; }
        [ForeignKey("ClassCode")]
        public virtual Class Class { get; set; }

        // Navigation property for the FoodCoupons
        public virtual ICollection<FoodCoupon> FoodCoupons { get; set; }
    }
}


