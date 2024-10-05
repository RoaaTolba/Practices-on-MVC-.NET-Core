using System.ComponentModel.DataAnnotations.Schema;

namespace AssigmentMVCday2.Models
{
    public class CrsResult
    {
        public int Id { get; set; }
        public int degree { get; set; }
        [ForeignKey(nameof(Course))]
        public int crs_id { get; set; }
        [ForeignKey(nameof(Trainee))]
        public int trainee_id { get; set; }
        public virtual Course Course { get; set; }
        public virtual Trainee Trainee { get; set; }

    }
}
