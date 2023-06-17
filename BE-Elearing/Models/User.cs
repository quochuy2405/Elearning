using System.ComponentModel.DataAnnotations;

namespace BE_Elearing.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public EROLE Role { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string Biography { get; set; }
        public DateTime? Birthday { get; set; }
        public string Facebook { get; set; }
        public string Linkedin { get; set; }
        public string Job { get; set; }
        public string Avata { get; set; }
        public string Thumbnail { get; set; }
        public string VerifiedAt { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
}

