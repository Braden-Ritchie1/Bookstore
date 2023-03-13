using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
//the model for an actual purchase of books
namespace Bookstore.Models
{
    public class Purchase
    {
        [Key]
        [BindNever]
        public int PurchaseId { get; set; }

        [BindNever]
        public ICollection<CartLineItem> Lines { get; set; }

        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter the first address line")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }

        [Required(ErrorMessage = "Please enter a City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter a State")]
        public string State { get; set; }

        [Required(ErrorMessage = "Please enter a Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please enter a Zipcode")]
        public string Zip { get; set; }

    }
}
