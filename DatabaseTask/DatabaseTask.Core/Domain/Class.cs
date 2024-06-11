using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DatabaseTask.Core.Domain
{
    public class Class
    {
        [Key]
        public Guid ClassCode { get; set; }
        public string ClassName { get; set; }
        public Guid GroupLeaderID { get; set; }

        // Navigation property to the GroupLeader entity
        [ForeignKey("GroupLeaderID")]
        public virtual GroupLeader GroupLeader { get; set; }
    }
}

