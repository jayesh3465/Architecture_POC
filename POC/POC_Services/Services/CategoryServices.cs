namespace NetCoreMicroServices_POC.Services
{
    public class CategoryServices : ICategoryServices
    {
        private readonly IRepository<Category> _categoryRepository;

        public CategoryServices(IRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<IEnumerable<Category>> GetAllCategory()
        {
            return await _categoryRepository.GetAll();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _categoryRepository.Get(id);
        }

        public async Task<Category> SaveCategory(Category category)
        {

            await _categoryRepository.Insert(category);
            return category;

        }

        public async Task<Category> UpdateCategory(Category category)
        {
            if (category != null)
            {
                await _categoryRepository.Update(category);
                return category;
            }
            return category;
        }

        public async Task<int> DeleteCategory(int id)
        {
            var category = await _categoryRepository.Get(id);
            await _categoryRepository.Delete(category);
            return id;
        }

    }
}
