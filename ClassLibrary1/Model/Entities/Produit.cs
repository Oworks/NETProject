using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Model.Entities
{
    public class Produit
    {
        [Key]
        public int IdProduit { get; set; }
    
      
        public int ProduitCode { get; set; }

        [StringLength(50)]
        [Required]
        public String ProduitLibele { get; set; }

        [StringLength(50)]
        [Required]
        public String ProduitDescription { get; set; }

       
        public Boolean ProduitActif { get; set; }

        public int ProduitStock { get; set; }
        public double ProduitPrix { get; set; }


        public int CategorieId { get; set; }
        public Categorie Categorie { get; set; }
    }
}
