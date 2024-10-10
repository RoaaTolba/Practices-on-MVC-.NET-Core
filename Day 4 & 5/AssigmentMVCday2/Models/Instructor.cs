using System.ComponentModel.DataAnnotations.Schema;

namespace AssigmentMVCday2.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }

        [ForeignKey (nameof(Course))]
        public int crs_id { get; set; }

        [ForeignKey (nameof(Department))]
        public int dep_id { get; set; }
        public virtual Course Course { get; set; }
        public virtual Department Department { get; set; }

    }
}
