using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using ClassLibrary1.Model.Entities;

namespace ClassLibrary1.Model.Fluent
{
    class CategorieFluent : EntityTypeConfiguration<Categorie>
    {
        public CategorieFluent()
        {
            ToTable("APP_Categorie");
            HasKey(catego => catego.CategorieId);

            Property(catego => catego.CategorieId).HasColumnName("CATEGO_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(catego => catego.Libelle).HasColumnName("CATEGO_LIBELLE").IsRequired().HasMaxLength(50);
            Property(catego => catego.Actif).HasColumnName("CATEGO_ACTIF").IsRequired();
        }
    }
}
