using HaterDate2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HaterDate2.Controllers
{
    public class HomeController : Controller
    {
        private IHaterDateRepository _repo;

        public HomeController(IHaterDateRepository repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            var questions = _repo.GetAllQuestions();
            return View(questions);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}