namespace MVC_ITI.Models
{
    public class ProductSampleDate
    {
        public List<Product> Products { get; set; }
        //Mokeup
        public ProductSampleDate()
        {
            Products = new List<Product>();
            Products.Add(new Product() { Id = 1, Name = "Journal1", Description = "beautiful description", Image = "30ah-journal-superJumbo.jpg", Price = 1000 });
            Products.Add(new Product() { Id = 2, Name = "Journal2", Description = "beautiful description", Image = "png-transparent-journaling-file-system-newspaper-journal-miscellaneous-rectangle-writing-thumbnail.png", Price = 2000 });
            Products.Add(new Product() { Id = 3, Name = "Journal3", Description = "beautiful description", Image = "download.jfif", Price = 4000 });
        }
        public List<Product> GetAll()
        {
                return Products;
        }
        public Product GetById(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
