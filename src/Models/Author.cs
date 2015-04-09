using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF7Sample.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
