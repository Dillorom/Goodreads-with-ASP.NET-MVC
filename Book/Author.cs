using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookTracker
{
    class Author
    {
        public Guid AuthorId { get; set; }
        public string Name { get; set; }
        public int BookId { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
