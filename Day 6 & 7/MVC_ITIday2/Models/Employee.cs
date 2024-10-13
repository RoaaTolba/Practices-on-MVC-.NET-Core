using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_ITIday2.Models
{
    public class Employee
    {

        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(12)]
        public string Name { get; set; }
        // any number will repeat 2 time like 24 - 33 - 87 28
        [RegularExpression(@"[0-9]{4}",ErrorMessage ="just 4 numbers")]
        [Range(2000,10000)]
        [Required]
        public int Salary { get; set; }
        [RegularExpression("(Alex|Luxor|Fayom)",ErrorMessage = "there are just 3 countries (Alex,Luxor,Fayom)")]
        [Required]
        public string? Address { get; set; }
        [RegularExpression(@"^[a-zA-Z0-9_-]+\.(jpg|png)$",
                ErrorMessage = "The image must be a .jpg or .png file.")]
        public string Image { get; set; }
        [ForeignKey("Department")]
        [Display(Name="Department")]
        public int Dep_id { get; set; }
        public virtual Department? Department { get; set; }
    }
}
