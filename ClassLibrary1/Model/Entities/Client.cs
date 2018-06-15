using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Model.Entities
{
    public class Client
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        [Required]
        public String Nom { get; set; }

        [StringLength(50)]
        [Required]
        public String Prenom { get; set; }

        [Required]
        public Boolean Actif { get; set; }

        public List<Commande> Commandes { get; set; }
    }
}
