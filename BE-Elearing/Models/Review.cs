using System.ComponentModel.DataAnnotations;

namespace BE_Elearing.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        [Key]
        public int UserId { get; set; }
        [Key]
        public int CourseId { get; set; }
        public int CourseReviewState { get; set; }
        public string Content { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

    }
}
