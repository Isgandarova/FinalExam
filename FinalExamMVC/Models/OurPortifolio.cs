using System.ComponentModel.DataAnnotations;

namespace FinalExamMVC.Models
{
    public class OurPortifolio:BaseModel
    {
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        [MinLength(5)]
        [MaxLength(25)]
        public string Title { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
