using Bookstore.Models;
using Bookstore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Controllers
{
    public class HomeController : Controller
    {
        private IBookstoreRepository repo;
        
        public HomeController (IBookstoreRepository temp)
        {
            repo = temp;
        }

        public IActionResult Index(int pageNum = 1)
        {
            int numResults = 10;

            var x = new BooksViewModel
            {
                //this lists out the books, ordered by title and prints out 10 per page
                Books = repo.Books
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * numResults)
                .Take(numResults),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.Books.Count(),
                    BooksPerPage = numResults,
                    CurrentPage = pageNum
                }

            };

            return View(x);
        }
    }
}
