using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW5.Models
{
    public static class Repo
    {
        public static List<Book> Stock = new List<Book> 
        { 
            new Novel("Houghton Mifflin Harcourt", true, "The Lord of the Rings", "J.R.R Tolkien", 349.90, "Fantasy", "9780547951942"),
            new Manga(1, "VIZ Media", "Tokyo Ghoul", "Sui Ishida", 150.00, "Psychological Horror", "9781421580364"),
            new TextBook(1, "Programming", "Fundamentals of Computer Programming with C#", "Svetlin Nakov", 50.00, "Computers", "9789544007737"),
        };
    }
}