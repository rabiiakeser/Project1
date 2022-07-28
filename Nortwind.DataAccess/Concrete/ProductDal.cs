using NortWind.Entities.Concrete;

namespace Nortwind.DataAccess.Concrete
{
    //Direkt olarak veritabanı işleri yapılır..
    public class ProductDal
    {
       
        public List<Product>GetAll()
        {
            using (NortwindContext context = new NortwindContext())
            {
                return context.Products.ToList();
            }
        }


        public Product Get(int id)
        {
            using (NortwindContext context = new NortwindContext())
            {
                return context.Products.SingleOrDefault(p => p.ProductId == id);
            }      
        }
        public void Add(Product product)
        {
            using (NortwindContext context = new NortwindContext())
            {
                context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void Update(Product product)
        {
            using (NortwindContext context = new NortwindContext())
            {
               // context.Products.Add(product);
                context.SaveChanges();
            }
        }
        public void Delete(Product product)
        {

        }
    }
}
