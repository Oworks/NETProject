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
    public class ProduitFluent : EntityTypeConfiguration<Produit>
    {
        public ProduitFluent()
        {
            ToTable("APP_Produit");
            HasKey(prod => prod.IdProduit);

            Property(prod => prod.IdProduit).HasColumnName("PROD_COMID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(prod => prod.ProduitCode).HasColumnName("PROD_CODE").IsRequired();
            Property(prod => prod.ProduitLibele).HasColumnName("PROD_LIBELE").IsRequired().HasMaxLength(50);
            Property(prod => prod.ProduitDescription).HasColumnName("PROD_DESCRIPTION").IsRequired();
            Property(prod => prod.ProduitActif).HasColumnName("PROD_ACTIF").IsRequired();
            Property(prod => prod.ProduitStock).HasColumnName("PROD_STOCK").IsRequired();
            Property(prod => prod.ProduitPrix).HasColumnName("PROD_PRIX").IsRequired();
            Property(prod => prod.CategorieId).HasColumnName("PROD_CATEGO").IsRequired();



            HasRequired(prod => prod.Categorie).WithMany().HasForeignKey(prod => prod.CategorieId);
        }
    }
}
