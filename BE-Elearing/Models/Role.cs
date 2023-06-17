using System.ComponentModel.DataAnnotations;

namespace BE_Elearing.Models
{
    public enum EROLE
    {
        CLIENT,
    }
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public EROLE Type { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}
