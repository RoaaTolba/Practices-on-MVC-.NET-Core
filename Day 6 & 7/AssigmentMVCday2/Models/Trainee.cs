using System.ComponentModel.DataAnnotations.Schema;

namespace AssigmentMVCday2.Models
{
    public class Trainee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public int Level { get; set; }
        [ForeignKey(nameof(Department))]
        public int dep_id { get; set; }
        public virtual Department Department { get; set; }
        public virtual List<CrsResult> CrsResults { get; set; }

    }
}
