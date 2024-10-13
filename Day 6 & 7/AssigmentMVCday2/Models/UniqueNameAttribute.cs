using System.ComponentModel.DataAnnotations;

namespace AssigmentMVCday2.Models
{
    public class UniqueNameAttribute:ValidationAttribute
    {
        public string MessageError { get; set; }
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            string name = (string)value;
            MyDbContext context = new MyDbContext();
            Course crs = context.courses.FirstOrDefault(c => c.Name == name);
            if (crs == null)
            {
                return ValidationResult.Success;
            }
            return new ValidationResult("The name is found");
            //return base.IsValid(value, validationContext);
        }
    }
}
