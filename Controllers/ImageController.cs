using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW5.Logic;

namespace HW5.Controllers
{
    public class ImageController : Controller
    {
        // GET: Image
        public ActionResult Index()
        {
            DB db = new DB();
            return View(db.GetImageList());
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(HttpPostedFileBase img, string name)
        {
            DB db = new DB();

            db.SaveImage(img, name);

            return RedirectToAction("Index");
        }

        public ActionResult Delete(Guid id)
        {
            DB db = new DB();

            db.DeleteImage(id);

            return RedirectToAction("Index");
        }
    }
}