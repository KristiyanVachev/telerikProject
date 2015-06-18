using QuizArena.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuizArena.Models;

namespace QuizArena.Controllers
{
    public class HomeController : Controller
    {
        QuizArenaDbContext db = new QuizArenaDbContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Training()
        {
            //string test = db.Questions.Find().AnswerRight;
            //ViewBag.Message = test;

            return View();        
        }

        public ActionResult Competative()
        {
            return View();
        }
        [Authorize (Roles="Admin")]
        public ActionResult AdminPanel()
        {
            ViewBag.Message = "Admin Panel";

            return View();
        }
    }
}