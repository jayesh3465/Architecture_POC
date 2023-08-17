namespace POC_Services.Services
{
    public class ProductServices : IProductServices
    {
        private readonly IRepository<Product> _ProductServices;

        public ProductServices(IRepository<Product> ProductServices)
        {
            _ProductServices = ProductServices;
        }
        public async Task<IEnumerable<Product>> GetAllProducts()
        {

            return await _ProductServices.GetAll();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _ProductServices.Get(id);
        }

        public async Task<Product> SaveProduct(Product product)
        {
            await _ProductServices.Insert(product);
            return product;

        }

        public async Task<Product> UpdateProduct(Product product)
        {
            if (product != null)
            {
                await _ProductServices.Update(product);
                return product;
            }
            return product;
        }

        public async Task<int> DeleteProduct(int id)
        {
            var Product = await _ProductServices.Get(id);
            await _ProductServices.Delete(Product);
            return id;
        }

    }
}
