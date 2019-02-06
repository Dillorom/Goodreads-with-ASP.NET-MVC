using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookTracker
{
    class Book
    {
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public int Rating { get; set; }

        public virtual Author Author { get; set; }
    }
}
