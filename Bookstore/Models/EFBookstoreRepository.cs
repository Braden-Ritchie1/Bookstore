using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//part of the respoitory method set up
namespace Bookstore.Models
{
    public class EFBookstoreRepository : IBookstoreRepository
    {
        //this now does the job of the controller
        private BookstoreContext context { get; set; }

        public EFBookstoreRepository (BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Book> Books => context.Books;
    }
}
