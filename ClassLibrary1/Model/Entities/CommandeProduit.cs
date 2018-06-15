using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Model.Entities
{
    public class CommandeProduit
    {
        
        public int CommandeProduitID { get; set; }
        public Produit Produit { get; set; }
      
        public int CommandeID { get; set; }
        public Commande Commande { get; set; }

        public int CommandeQuantite { get; set; }
    }
}
