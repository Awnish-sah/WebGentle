using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;
using Webgentle.BookStore.Repository;

namespace Webgentle.BookStore.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository bookRepository = new BookRepository();

        public ViewResult GetAllBooks()
        {
            var data = bookRepository.GetAllBooks();
            return View(data);
        }

        public ViewResult GetBookById(int id)
        {
            var data = bookRepository.GetBook(id);
            return View(data);
        }
    }
}
