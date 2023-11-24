using Microsoft.AspNetCore.Mvc;
using BookShoop.Models;
using BookShoop.Services;

namespace BookShoop.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookService; //creare istanza

        public IActionResult Index()
        {
            return View();
        }

       public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        //------------- RECUPERA LA LISTA DI TUTTI I LIBRI ----------------
        public async Task<ViewResult> GetAllBooks()
        {
           var data = await _bookService.GetAllBooks();
           return View(data);
        }

        public ViewResult GetBookID(int id)
        {
            var date = _bookService.GetBookID(id);
            return View(date);
        }


        //public BookModel SearchBook(string Title, string Author)
        //{
        //    return _bookRepository.SearchBook(Title, Author);
        //}


        //----------------------- CRUD --------------------------
        //----------------------- CREATE ------------------------
        public ViewResult AddNewBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewBook(BookModel bookModel)
        {
           _bookService.AddNewBook(bookModel); //metodo dal IBookService e BookService
            if (bookModel.Id > 0) //rendiamo possibile il refresh del form dopo averlo compilato
            {
                return RedirectToAction("AddNewBook");
            }
            return View();
        }

    }


}
