using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bookstore.Models
{
    //this is the class for the cart. it allows for the creation and adding of line items in the cart
    public class Cart
    {
        public List<CartLineItem> Items { get; set; } = new List<CartLineItem>();

        public virtual void AddItem (Book book, int qty)
        {
            CartLineItem line = Items
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new CartLineItem
                    {
                        Book = book,
                        Quantity = qty
                    });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        //class for removing items
        public virtual void RemoveItem (Book book)
        {
            Items.RemoveAll(x => x.Book.BookId == book.BookId);
        }

        //class for clearing the cart
        public virtual void ClearCart()
        {
            Items.Clear();
        }

        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);

            return sum;
        }
    }

    public class CartLineItem
    {
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
