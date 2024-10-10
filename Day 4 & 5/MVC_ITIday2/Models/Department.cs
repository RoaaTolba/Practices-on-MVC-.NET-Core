namespace MVC_ITIday2.Models
{
    public class Department
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        public string ManegerName { get; set; }

        public virtual List<Employee>? Employees { get; set; }
    }
}
