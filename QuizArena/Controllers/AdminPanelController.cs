using QuizArena.Data;
using QuizArena.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace QuizArena.Controllers
{   [Authorize (Roles="Admin")]
    public class AdminPanelController : Controller
    {
    QuizArenaDbContext db = new QuizArenaDbContext();

        // GET: /AdminPanel/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Questions()
        {
            return View();
        }

        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    User student = db.Users.Find(id);
        //    if (student == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(student);
        //}
	}
}