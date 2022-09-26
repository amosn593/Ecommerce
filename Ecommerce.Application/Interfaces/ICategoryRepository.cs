using Ecommerce.Domain.Models;

namespace Ecommerce.Application.Interfaces
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllCategories();

        Task<Category> GetCategoryByFilter(string filter);
    }
}
