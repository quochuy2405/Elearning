using System.ComponentModel.DataAnnotations;

namespace BE_Elearing.Models
{
    public class Chapter
    {
        [Key]
        public int Id { get; set; }
        [Key]
        public int CourseId { get; set; }
        public string ChapterName { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

    }
}
