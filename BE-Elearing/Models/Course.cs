using System.ComponentModel.DataAnnotations;

namespace BE_Elearing.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public int CourseTypeId { get; set; }
        public int CourseAuthorId { get; set; }
        public int CourseLevelId { get; set; }
        public int CourseLanguageId { get; set; }
        public int ApprovalStatus { get; set; }
        public string CourseName { get; set; }
        public string CourseImage { get; set; }
        public int CourseFee { get; set; }
        public string Description { get; set; }
        public int CourseStatus { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

    }
}
