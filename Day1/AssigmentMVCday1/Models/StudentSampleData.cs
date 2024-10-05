using Microsoft.AspNetCore.Mvc;

namespace AssigmentMVCday1.Models
{
    public class StudentSampleData
    {
        public List<Student> Students { get; set; }
        public StudentSampleData()
        {
            Students = new List<Student>();
            Students.Add(new Student { id = 1, name = "Basem", address = "10th of Ramadan", img = "b852c51b27907d2a5b774a93eeacae5c.jpg" });
            Students.Add(new Student { id = 2, name = "Roaa", address = "Luxor", img = "1344988.jpeg" });
            Students.Add(new Student { id = 3, name = "Gehad", address = "Turkya", img = "1347028.jpeg" });
            Students.Add(new Student { id = 4, name = "Wael", address = "Alexandria", img = "dff54fedc0abfe8ec7f955350f7bd598.jpg" });
        }

        public List<Student> GetAll()
        {
            return Students;
        }
        public Student GetById(int id) 
        {
            return Students.FirstOrDefault(S => S.id == id);
        }

    }
}
