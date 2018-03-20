using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using entityDemo.Models;
using System.Linq;

namespace entityDemo.Controllers
{
    public class HomeController : Controller
    {
        private BookContext _context;

        public HomeController(BookContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            List<Book> AllBooks = _context.Books.ToList();
            ViewBag.Books = AllBooks;
            return View();
        }

        [HttpPost]
        [Route("createBook")]
        public IActionResult CreateBook(Book newBook)
        {
            _context.Add(newBook);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("delete/{id}")]
        public IActionResult DeleteBook(int id)
        {
            Book bookToDelete = _context.Books.SingleOrDefault(b => b.BookId == id);
            _context.Remove(bookToDelete);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
