using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ClassLibrary1.BusinessLayer;
using ClassLibrary1.Model.Entities;

namespace ASP_project.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Produit> listeProduit = Manager.Instance().GetTrendyProducts(5);
            Console.Write(listeProduit);
            return View(listeProduit);
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