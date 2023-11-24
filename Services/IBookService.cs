using BookShoop.Data;
using BookShoop.Models;



namespace BookShoop.Services
{
    public interface IBookService
    {
        Task<List<BookModel>> GetAllBooks();
        BookModel? GetBookID(int id);
        int AddNewBook(BookModel model);

    }
}