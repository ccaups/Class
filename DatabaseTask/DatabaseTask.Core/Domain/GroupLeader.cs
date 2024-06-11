using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseTask.Core.Domain
{
    public class GroupLeader
    {
        [Key]
        public Guid GroupLeaderID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        // Navigation property for the inverse relationship
        public virtual ICollection<Class> Classes { get; set; }
    }
}


