using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Model.Entities
{
    class LogProduit
    {
        [Key]
        public int IdLog { get; set; }

        [StringLength(50)]
        public String LogMessage { get; set; }

        public DateTime LogDate { get; set; }

        public int LogProduitId { get; set; }

        public Produit Produit { get; set; }
    }
}
