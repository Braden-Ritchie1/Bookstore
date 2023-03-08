using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Bookstore.Pages
{
    public class ShopModel : PageModel
    {
        private IBookstoreRepository repo { get; set; }

        public ShopModel (IBookstoreRepository temp)
        {
            repo = temp;
        }


        public Cart cart { get; set; }

        public void OnGet(Cart c)
        {
            cart = c;
        }

        public IActionResult OnPost(int bookID)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookID);

            cart = new Cart();
            cart.AddItem(b, 1);

            return RedirectToPage(cart);
        }
    }
}
