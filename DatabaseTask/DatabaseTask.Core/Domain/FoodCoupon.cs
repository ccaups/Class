using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace DatabaseTask.Core.Domain
{
    public class FoodCoupon
    {
        [Key]
        public Guid VoucherCode { get; set; }

        public Guid StudentID { get; set; }

        [ForeignKey("StudentID")]
        public virtual Student Student { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public decimal Amount { get; set; }
    }
}
