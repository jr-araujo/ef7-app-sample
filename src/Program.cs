using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using EF7Sample.Models;

namespace EF7Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new BookstoreContext())
            {
                context.Books.Add(new Book { Title = "Entityframework 7" });
                context.SaveChanges();

                var book = context.Books.FirstOrDefault();

                if (book != null)
                {
                    Console.Write(book.Title);
                }

                Console.Read();
            }
        }
    }
}
