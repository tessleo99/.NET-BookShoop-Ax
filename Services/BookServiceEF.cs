
using BookShoop.Models;
using System.Collections.Generic;



//namespace BookShoop.Services
//{

//    public class BookServiceEF : IBookService
//    {

//        private List<BookModel> DataSource()
//        {
//            return new List<BookModel>()
//            {
//                new BookModel() {Id=0, Title="titolo1", Author="autore1", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. "},
//                new BookModel() {Id=1, Title="titolo2", Author="autore2", Description="Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. "},
//                new BookModel() {Id=2, Title="titolo3", Author="autore3", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. "},
//                new BookModel() {Id=3, Title="titolo4", Author="autore4", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. "},
//                new BookModel() {Id=4, Title="titolo5", Author="autore5", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. "},
//                new BookModel() {Id=5, Title="titolo6", Author="autore6", Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. "}
//            };
//        }
//        public List<BookModel> GetAllBooks()
//        {
//            return DataSource();
//        }

//        public BookModel? GetBookID(int id)
//        {
//            return DataSource().Where(x => x.Id == id).FirstOrDefault();
//        }

//        public BookModel? AddNewBook(BookModel model)
//        {
//            throw new NotImplementedException();
//        }


//        //public BookModel SearchBook(string Title, string Author)
//        //{
//        //    return (BookModel)DataSource().Where(BookModel => BookModel.Title == Title && BookModel.Author == Author).FirstOrDefault();
//        //}

//    }


//}

