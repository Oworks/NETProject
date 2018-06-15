using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ClassLibrary1.Model.Entities
{
    public class Statut
    {
        [Key]
        public int Id { get; set; }

        [StringLength(100)]
        [Required]
        public String Libelle { get; set; }

     
    }
}
