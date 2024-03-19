using AuditTrialTest.Models;
using AuditTrialTest.Pages;

namespace AuditTrialTest.Data.Services
{
    public class BookService
    {
        private readonly ApplicationDbContext _context;
        public BookService(ApplicationDbContext context)
        {
            _context = context;
        }

        public bool AddBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveBook(Book book)
        {
            _context.Books.Remove(book);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateBook(Book book) 
        { 
            _context.Books.Update(book);
            _context.SaveChanges();
            return true;
        }

         public Book? GetBook(int id) 
        { 
            var book = _context.Books.FirstOrDefault(b => b.Id == id);
            return book;
        }

        public List<Book> GetAllBooks()
        {
            var books = new List<Book>();
            books = _context.Books.ToList();
            return books;
        }
    }
}
