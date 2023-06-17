using System.ComponentModel.DataAnnotations;

namespace BE_Elearing.Models
{
    public class Approval
    {
        [Key]
        public int Id { get; set; }
        [Key]
        public int CourseId { get; set; }
        [Key]
        public int UserId { get; set; }
        public DateTime ApproveTime { get; set; }
        public bool IsAccepted { get; set; }
        public bool Reason { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual User UserNavigation { get; set; }
        public virtual Course CourseNavigation { get; set; }


    }
}
