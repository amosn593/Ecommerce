using Ecommerce.Application.Interfaces;
using Ecommerce.Domain.Models;

namespace Ecommerce.Application.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public Task<List<Category>> GetAllCategories()
        {
            throw new NotImplementedException();
        }

        public Task<Category> GetCategoryByFilter(string filter)
        {
            throw new NotImplementedException();
        }
    }
}
