using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Goodreads.Models
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public BookFormat Format { get; set; }
    }

    public enum BookFormat
    {
        Print,
        EBook,
        AudioBook
    }
}