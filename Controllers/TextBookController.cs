using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW5.Models;
using HW5.Logic;

namespace HW5.Controllers
{
    public class TextBookController : Controller
    {
        [HttpGet]
        public ActionResult Order()
        {
            DB db = new DB();
            TextBook textBook = new TextBook();

            textBook.selectList = new SelectList(db.GetImageList(), "ID", "Name");

            return View(textBook);
        }

        [HttpPost]
        public ActionResult Order(TextBook textbook)
        {
            TextBook current = (TextBook)Repo.Stock.Where(n => n.ISBN.Equals(textbook.ISBN)).FirstOrDefault();
            if (current != null)
            {
                current.Stock += textbook.Stock;
                TempData["MSG"] = $"A book with the same ISBN ({textbook.ISBN}) was found and was added in stock.";
            }
            else
            {
                DB db = new DB();
                Repo.Stock.Add(textbook);
            }

            return RedirectToAction("Index", "Warehouse");
        }

        [HttpGet]
        public ActionResult Update(string isbn)
        {
            DB db = new DB();
            TextBook textBook = (TextBook)Repo.Stock.Where(n => n.ISBN.Equals(isbn)).First();

            textBook.selectList = new SelectList(db.GetImageList(), "ID", "Name");

            return View(textBook);
        }

        [HttpPost]
        public ActionResult Update(TextBook textbook)
        {
            TextBook old = (TextBook)Repo.Stock.Where(n => n.ISBN.Equals(textbook.ISBN)).First();

            old.Author = textbook.Author;
            old.Subject = textbook.Subject;
            old.Genre = textbook.Genre;
            old.Image = new Image();
            old.Image.ID = textbook.Image.ID;
            old.ISBN = textbook.ISBN;
            old.Price = textbook.Price;
            old.Edition = textbook.Edition;
            old.Stock = textbook.Stock;
            old.Title = textbook.Title;

            return RedirectToAction("Index", "Warehouse");
        }
    }
}