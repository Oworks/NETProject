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

    }
}
