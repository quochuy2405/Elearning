using System.ComponentModel.DataAnnotations;

namespace BE_Elearing.Models
{
    public class Learning
    {
        [Key]
        public int Id { get; set; }

        public int LessonId { get; set; }
        public int UserId { get; set; }
        public TimeSpan LearnTime { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }


        public virtual User UserNavigation { get; set; }
        public virtual Lesson LessonNavigation { get; set; }

    }
}
