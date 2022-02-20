using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW5.Models;
using HW5.Logic;

namespace HW5.Controllers
{
    public class MangaController : Controller
    {
        [HttpGet]
        public ActionResult Order()
        {
            DB db = new DB();
            Manga manga = new Manga();

            manga.selectList = new SelectList(db.GetImageList(), "ID", "Name");

            return View(manga);
        }

        [HttpPost]
        public ActionResult Order(Manga manga)
        {
            Manga current = (Manga)Repo.Stock.Where(n => n.ISBN.Equals(manga.ISBN)).FirstOrDefault();
            if (current != null)
            {
                current.Stock += manga.Stock;
                TempData["MSG"] = $"A book with the same ISBN ({manga.ISBN}) was found and was added in stock.";
            }
            else
            {
                DB db = new DB();
                Repo.Stock.Add(manga);
            }

            return RedirectToAction("Index", "Warehouse");
        }

        [HttpGet]
        public ActionResult Update(string isbn)
        {
            Manga manga = (Manga)Repo.Stock.Where(n => n.ISBN.Equals(isbn)).First();
            DB db = new DB();
            manga.selectList = new SelectList(db.GetImageList(), "ID", "Name");
            return View(manga);
        }

        [HttpPost]
        public ActionResult Update(Manga manga)
        {
            Manga old = (Manga)Repo.Stock.Where(n => n.ISBN.Equals(manga.ISBN)).First();

            old.Author = manga.Author;
            old.Volume = manga.Volume;
            old.Genre = manga.Genre;
            old.Image = new Image();
            old.Image.ID = manga.Image.ID;
            old.ISBN = manga.ISBN;
            old.Price = manga.Price;
            old.Studio = manga.Studio;
            old.Stock = manga.Stock;
            old.Title = manga.Title;

            return RedirectToAction("Index", "Warehouse");
        }
    }
}