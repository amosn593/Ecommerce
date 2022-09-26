using Ecommerce.Application.Interfaces;
using Ecommerce.DataAccess.Data;
using Ecommerce.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Application.Repositories
{

    public class BookRepository : IBookRepository
    {
        private readonly EcommerceDbContext _context;
        public BookRepository(EcommerceDbContext context)
        {
            _context = context;
        }

       

        public async Task<List<Book>> GetAllBooks()
        {
            try
            {
                var books = await _context.Books.ToListAsync();

                return books;

            }
            catch (Exception)
            {
                throw;
            }
            
        }

        public Task<Book> GetBookByFilter(string filter)
        {
            throw new NotImplementedException();
        }
    }
}
