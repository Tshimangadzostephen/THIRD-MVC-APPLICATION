using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HW5.Models
{
    public abstract class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public string Genre { get; set; }
        public string ISBN { get; set; }
        public int Stock { get; set; }
        public Image Image { get; set; }
        public SelectList selectList { get; set; }

        public abstract string GetInfo();
        public abstract override string ToString();
    }
}