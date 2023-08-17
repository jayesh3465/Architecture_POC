namespace POC_Services.Interface
{
    public interface ICategoryServices
    {
        Task<IEnumerable<Category>> GetAllCategory();

        Task<Category> GetCategoryById(int id);

        Task<Category> SaveCategory(Category category);

        Task<Category> UpdateCategory(Category category);

        Task<int> DeleteCategory(int id);

    }
}
