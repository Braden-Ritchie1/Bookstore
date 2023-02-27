using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models.ViewModels
{
    public class BooksViewModel
    {
        //setting up teh BooksViewModel that will be called on the Index
        public IQueryable<Book> Books { get; set; }

        public PageInfo PageInfo { get; set; }
    }
}
