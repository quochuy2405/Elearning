using System.ComponentModel.DataAnnotations;

namespace BE_Elearing.Models
{
    public class Tag
    {
        [Key]
        public int Id { get; set; }
        [Key]
        public int CourseId { get; set; }
        public string Name { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

    }
}
