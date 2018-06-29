using ClassLibrary1.Model.Entities;
using ClassLibrary1.Model.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.BusinessLayer
{
    public class Manager
    {
        private static Manager _manager = null;
        private ContextFluent _contexte = null;

        private Manager()
        {
            _contexte = new ContextFluent();
        }

        public static Manager Instance()
        {
            if (_manager == null)
            {
                _manager = new Manager();
                return _manager;
            }

            return _manager;
        }

        public List<Produit> GetListeProduit()
        {
            try
            {
                return _contexte.Produits.ToList();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public List<Produit> GetListeProduitByCode(string code)
        {
            return _contexte.Produits.Where(p => p.ProduitLibele.ToUpper().Contains(code.ToUpper())).ToList();
        }

        public Produit GetProduitById(int id)
        {
            return _contexte.Produits.Where(p => p.IdProduit==id).FirstOrDefault();
        }

        public Produit AddProduit(Produit produit)
        {

            _contexte.Produits.Add(produit);
            _contexte.SaveChanges();
            return produit;
        }
        public Produit EditProduit(Produit produit)
        {
            
            return produit;
        }
        public void UpdateProduit(Produit produit)
        {
            _contexte.Produits.Where(p => p.IdProduit == produit.IdProduit).ToList().ForEach(p => { p.ProduitCode = produit.ProduitCode; p.ProduitLibele = produit.ProduitLibele; });
        }

        public List<Commande> GetLastOrders(int n)
        {
            return _contexte.Commandes.OrderByDescending(o => o.CommandeDate).Take(n).ToList();
        }

        public List<Produit> GetTrendyProducts(int n)
        {
            Console.WriteLine(_contexte.CommandeProduits.GroupBy(o => o.CommandeProduitID).ToList());
            return null;

        }
    }
}
