using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_ITIday2.Models
{
    public class Employee
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string? Address { get; set; }
        public string Image { get; set; }
        [ForeignKey("Department")]
        [Display(Name="Department")]
        public int Dep_id { get; set; }
        public virtual Department? Department { get; set; }
    }
}
