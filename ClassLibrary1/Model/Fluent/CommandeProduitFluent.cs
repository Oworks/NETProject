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
    class CommandeProduitFluent : EntityTypeConfiguration<CommandeProduit>
    {
        public CommandeProduitFluent()
        {
            ToTable("APP_CommandeProduit");

            HasKey(comProd => new { comProd.CommandeProduitID, comProd.CommandeID });

            Property(comProd => comProd.CommandeProduitID).HasColumnName("COMPROD_COMPRODID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(comProd => comProd.CommandeID).HasColumnName("COMPROD_COMID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(comProd => comProd.CommandeQuantite).HasColumnName("COMPROD_QUANTITE").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            HasRequired(comProd => comProd.Produit).WithMany().HasForeignKey(comProd => comProd.CommandeProduitID);
            HasRequired(comProd => comProd.Commande).WithMany().HasForeignKey(comProd => comProd.CommandeID);


        }
    }
}