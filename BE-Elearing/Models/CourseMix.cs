using System.ComponentModel.DataAnnotations;

namespace BE_Elearing.Models
{
    public class CourseMix
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type{ get; set; }
        public string Status { get; set; }
        public string Author{ get; set; }
        public int? ReviewStar { get; set; }
        public int EnrollmentCount { get; set; }
        public string Level { get; set; }
        public string Language{ get; set; }
        public string Image { get; set; }
        public int CourseFee { get; set; }
        public string Description { get; set; }
        public string Tags { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
