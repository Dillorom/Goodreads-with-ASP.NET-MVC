using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Goodreads.Models
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public string Name { get; set; }

        public ICollection  Books{ get; set; }
    }
}