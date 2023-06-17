using System.ComponentModel.DataAnnotations;

namespace BE_Elearing.Models
{
    public class Payment
    {
        [Key]
        public int Id { get; set; }

        public int CourseId { get; set; }
        public string Content { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
