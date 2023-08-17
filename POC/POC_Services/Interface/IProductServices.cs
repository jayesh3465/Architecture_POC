namespace NetCoreMicroServices_POC.Services
{
    public interface IProductServices
    {
        Task<IEnumerable<Product>> GetAllProducts();

        Task<Product> GetProductById(int id);

        Task<Product> SaveProduct(Product Product);

        Task<Product> UpdateProduct(Product Product);

        Task<int> DeleteProduct(int id);

    }
}
