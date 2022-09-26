using Ecommerce.Domain.Models;

namespace Ecommerce.Application.Interfaces
{
    public interface IBookRepository
    {
        Task<List<Book>> GetAllBooks();

        Task<Book> GetBookByFilter(string filter);
    }
}
