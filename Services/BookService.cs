
using BookShoop.Data;
using BookShoop.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;



namespace BookShoop.Services
{

    public class BookService : IBookService
    {
        private readonly BooksStoreContext _context;

        public BookService (BooksStoreContext context)
        {
            _context = context; //dependency injection
        }


        //----------------------- CRUD --------------------------
        //----------------------- CREATE ------------------------
        public int AddNewBook(BookModel model) //creare un nuovo book nel db
        {
            var newBook = new Books()
            {
                Title = model.Title,
                Author = model.Author,
                Description = model.Description,
                Category = model.Category,
                Language = model.Language,
                TotalPages = model.TotalPages,
            };

            _context.Books.Add(newBook); //mappatura
            _context.SaveChanges(); //salvataggio

            return newBook.Id;
        }


        //------------- RECUPERA LA LISTA DI TUTTI I LIBRI ----------------
        public async Task<List<BookModel>> GetAllBooks()
        {
            var books = new List<BookModel>(); //creiamo una lista di tipo BookModel

            var allBooks = await _context.Books.ToListAsync(); //recuperiamo la lista dei libri

            if (allBooks?.Any() == true) //verifichiamo se ci sono valori nel allBooks
            //.Any() è un metodo che restituisce un valore booleano, indicando se uno o più elementi soddisfano una determinata condizione all'interno di una sequenza
            {
                foreach (var book in allBooks)
                {
                    books.Add(new BookModel() //nuova istanza del BookModel
                    { 
                        Id = book.Id, 
                        Title = book.Title,
                        Author = book.Author,
                        Description = book.Description,
                        Category = book.Category,
                        Language = book.Language,
                        TotalPages = book.TotalPages,

                    });
                }
            }

            return books;
        }


        //--------------- DETTAGLI DI UN LIBRO ----------------
        public BookModel? GetBookID(int id)
        {
            var book = _context.Books.Find(id);
            if (book != null)
            {
                var bookDetails = new BookModel() //nuovo oggetto del BookModel
                {
                    Title = book.Title,
                    Author = book.Author,
                    Description = book.Description,
                    Category = book.Category,
                    Language = book.Language,
                    TotalPages = book.TotalPages,

                };

                return bookDetails;
            }

            return null;
           
        }



        //public BookModel SearchBook(string Title, string Author)
        //{
        //    return (BookModel)DataSource().Where(BookModel => BookModel.Title == Title && BookModel.Author == Author).FirstOrDefault();
        //}

    }


}

