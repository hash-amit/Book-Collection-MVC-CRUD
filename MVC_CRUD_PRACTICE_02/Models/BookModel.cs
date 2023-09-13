using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_CRUD_PRACTICE_02.Models
{
    public class BookModel
    {
        public int BookID { get; set; }

        [Required(ErrorMessage = "Book Name is required")]
        [DisplayName("Book Name")]
        public string BookName { get; set; }

        [Required(ErrorMessage = "ISBN is required")]
        [DisplayName("ISBN")]
        public long? ISBN_10 { get; set; } // Use nullable long

        [Required(ErrorMessage = "Net Quantity is required")]
        [DisplayName("Net Quantity")]
        public int? NetQuantity { get; set; } // Use nullable int

        [Required(ErrorMessage = "Author Name is required")]
        [DisplayName("Author Name")]
        public string AuthorName { get; set; }

        public BookModel()
        {
            BookID = -1;
            BookName = "";
            ISBN_10 = null; // Initialize with null
            NetQuantity = null; // Initialize with null
            AuthorName = "";
        }
    }
}