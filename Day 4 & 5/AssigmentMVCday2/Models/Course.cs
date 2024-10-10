using System.ComponentModel.DataAnnotations.Schema;

namespace AssigmentMVCday2.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Degree { get; set; }
        public int minDegree { get; set; }
        [ForeignKey(nameof(Department))]
        public int dep_id { get; set; }
        public virtual Department Department { get; set; }
        public virtual List<Instructor> Instructors { get; set; }=new List<Instructor>();
        public virtual List<CrsResult> CrsResults { get; set; } = new List<CrsResult>();
    }
}
