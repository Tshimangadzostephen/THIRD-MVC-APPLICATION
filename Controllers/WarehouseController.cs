using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW5.Models;
using HW5.Logic;

namespace HW5.Controllers
{
    public class WarehouseController : Controller
    {
        public ActionResult Index()
        {
            DB db = new DB();
            foreach (Book b in Repo.Stock)
            {
                if (b.Image != null)
                    b.Image = db.GetImage(b.Image.ID);
            }
            return View(Repo.Stock);
        }

        [HttpGet]
        public ActionResult Search()
        {
            return View(new List<Book>());
        }
        [HttpPost]
        public ActionResult Search(string field, string term)
        {
            List<Book> books = Repo.Stock;
            List<Book> returnData = new List<Book>();

            if (field.Equals("0"))
            {
                returnData.AddRange(books.Where(b => b.Title.ToUpper().Contains(term.ToUpper())).ToList());
            } 
            else if (field.Equals("1"))
            {
                returnData.AddRange(books.Where(b => b.Author.ToUpper().Contains(term.ToUpper())).ToList());
            }
            else if (field.Equals("2"))
            {
                returnData.AddRange(books.Where(b => b.Genre.ToUpper().Contains(term.ToUpper())).ToList());
            }
            else if (field.Equals("3"))
            {
                returnData.AddRange(books.Where(b => b.ISBN.ToUpper().Contains(term.ToUpper())).ToList());
            }
            else if (field.Equals("4"))
            {
                returnData.AddRange(books.OfType<Manga>().Where(b => b.Studio.ToUpper().Contains(term.ToUpper())).ToList());
            }
            else if (field.Equals("5"))
            {
                returnData.AddRange(books.OfType<Novel>().Where(b => b.Publisher.ToUpper().Contains(term.ToUpper())).ToList());
            }
            else if (field.Equals("6"))
            {
                returnData.AddRange(books.OfType<TextBook>().Where(b => b.Subject.ToUpper().Contains(term.ToUpper())).ToList());
            }

            return View(returnData);
        }
    }
}