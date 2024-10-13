using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssigmentMVCday2.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(10)]
        [UniqueName]
        public string Name { get; set; }
        [Required]
        [Range(50,100)]
        public int Degree { get; set; }
        [Remote("CheckMinDegree","Course",AdditionalFields = nameof(Id))]
        public int minDegree { get; set; }
        [ForeignKey(nameof(Department))]
        public int dep_id { get; set; }
        public virtual Department Department { get; set; }
        public virtual List<Instructor> Instructors { get; set; }=new List<Instructor>();
        public virtual List<CrsResult> CrsResults { get; set; } = new List<CrsResult>();
    }
}
