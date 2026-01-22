using System.ComponentModel.DataAnnotations;

namespace FinalExamMVC.Models
{
    public class BaseModel
    {
        [Required]
        public int Id { get; set; }
     
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
