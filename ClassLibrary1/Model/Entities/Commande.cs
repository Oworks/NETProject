using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Model.Entities
{
    public class Commande
    {
        [Key]
        public int IdCommande { get; set; }

        public DateTime CommandeDate { get; set; }

        [StringLength(50)]
        [Required]
        public String CommandeObservation { get; set; }

        public int CommandeClientId { get; set; }
        public Client Client { get; set; }

        public int CommandeStatutId { get; set; }
        public Statut Statut { get; set; }




    }
}
