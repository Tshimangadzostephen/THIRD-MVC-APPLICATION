using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW5.Models;
using HW5.Logic;

namespace HW5.Controllers
{
    public class NovelController : Controller
    {
        [HttpGet]
        public ActionResult Order()
        {
            DB db = new DB();
            Novel novel = new Novel();

            novel.selectList = new SelectList(db.GetImageList(), "ID", "Name");

            return View(novel);
        }

        [HttpPost]
        public ActionResult Order(Novel novel)
        {
            Novel current = (Novel)Repo.Stock.Where(n => n.ISBN.Equals(novel.ISBN)).FirstOrDefault();
            if (current != null)
            {
                current.Stock += novel.Stock;
                TempData["MSG"] = $"A book with the same ISBN ({novel.ISBN}) was found and was added in stock.";
            }
            else
            {
                DB db = new DB();
                Repo.Stock.Add(novel);
            }

            return RedirectToAction("Index", "Warehouse");
        }

        [HttpGet]
        public ActionResult Update(string isbn)
        {
            DB db = new DB();
            Novel novel = (Novel)Repo.Stock.Where(n => n.ISBN.Equals(isbn)).First();

            novel.selectList = new SelectList(db.GetImageList(), "ID", "Name");

            return View(novel);
        }

        [HttpPost]
        public ActionResult Update(Novel novel, HttpPostedFileBase img)
        {
            Novel old = (Novel)Repo.Stock.Where(n => n.ISBN.Equals(novel.ISBN)).First();

            old.Author = novel.Author;
            old.Fiction = novel.Fiction;
            old.Genre = novel.Genre;
            old.Image = new Image();
            old.Image.ID = novel.Image.ID;
            old.ISBN = novel.ISBN;
            old.Price = novel.Price;
            old.Publisher = novel.Publisher;
            old.Stock = novel.Stock;
            old.Title = novel.Title;

            return RedirectToAction("Index", "Warehouse");
        }
    }
}