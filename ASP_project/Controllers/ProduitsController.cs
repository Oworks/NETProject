using System.Web.Mvc;
using ClassLibrary1.BusinessLayer;
using ClassLibrary1.Model.Entities;
using System.Collections.Generic;

namespace ASP_project.Controllers
{
    public class ProduitsController : Controller
    {
        // GET: Produits

        public ActionResult Liste()
        {
            List<Produit> listeProduit = Manager.Instance().GetListeProduit();
            return View(listeProduit);
        }
        public ActionResult Details(int id)
        {
            Produit details = Manager.Instance().GetProduitById(id);
            return View(details);
        }
        public ActionResult Search(string filter)
        {
            List<Produit> produit = Manager.Instance().GetListeProduitByCode(filter);
            return View("Liste", produit);
        }
    }
}