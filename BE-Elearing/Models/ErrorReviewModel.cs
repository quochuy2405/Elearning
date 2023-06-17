using System.ComponentModel.DataAnnotations;

namespace BE_Elearing.Models
{
    public class ErrorReviewModel
    {
        [Key]
        public int Id { get; set; }
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
