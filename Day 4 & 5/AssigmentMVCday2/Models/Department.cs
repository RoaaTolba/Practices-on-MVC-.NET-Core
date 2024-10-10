namespace AssigmentMVCday2.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Maneger { get; set; }
        public virtual List<Trainee> Trainees { get; set; }
        public virtual List<Course> Courses { get; set; }
        public virtual List<Instructor> Instructors { get; set; }

    }
}
