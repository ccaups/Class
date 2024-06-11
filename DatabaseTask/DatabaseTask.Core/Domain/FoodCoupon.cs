using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class FoodCoupon
    {
        [Key]
        public Guid VoucherCode { get; set; }

        [ForeignKey("StudentID")]        
        public Guid StudentID { get; set; }

        public virtual Student Student { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }

        [Required]
        [Column(TypeName = "decimal(10, 2)")] // Adjust precision/scale as needed
        public decimal Amount { get; set; }
    }
}
