using ProductMicroservicesProject.Models;

namespace ProductMicroservicesProject.Repository
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int productid);
        
        void InsertProduct(Product product);
        void DeleteProduct(int productid);
        void UpdateProduct(Product product);
        void Save();
    }
}
