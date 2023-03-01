using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//part of the repository method
namespace Bookstore.Models
{
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get; }
    }
}
