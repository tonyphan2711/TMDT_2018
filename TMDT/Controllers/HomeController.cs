using DataAccess.DAL;
using DataAccess.DATA;
using ERP.Framework.Singleton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMDT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Exampale exam = new Exampale();
            var list = exam.GetContracts();
            var list1 = SingletonIpl.GetInstance<Exampale>().GetContracts();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "abc";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}