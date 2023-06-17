using System.ComponentModel.DataAnnotations;

namespace BE_Elearing.Models
{
    public class Lesson
    {
        [Key]
        public int Id { get; set; }
        public int ChapterId { get; set; }
        public string Name { get; set; }
        public string SourceURL { get; set; }
        public int Duration { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual Learning LearningNavigation { get; set; }
        public virtual Chapter ChapterNavigation { get; set; }

    }
}
