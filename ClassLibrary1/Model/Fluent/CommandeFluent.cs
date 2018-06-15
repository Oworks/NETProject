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
    class CommandeFluent : EntityTypeConfiguration<Commande>
    {
        public CommandeFluent()
        {
            ToTable("APP_Commande");
            HasKey(com => com.IdCommande);

            Property(com => com.IdCommande).HasColumnName("COM_COMID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(com => com.CommandeDate).HasColumnName("COM_DATE").IsRequired();
            Property(com => com.CommandeObservation).HasColumnName("COM_OBSERVATION").IsRequired().HasMaxLength(50);
            Property(com => com.CommandeStatutId).HasColumnName("COM_STATUTID").IsRequired();
            Property(com => com.CommandeClientId).HasColumnName("COM_CLIENTID").IsRequired();


            HasRequired(com => com.Statut).WithMany().HasForeignKey(com => com.CommandeStatutId);
            HasRequired(com => com.Client).WithMany(cli => cli.Commandes).HasForeignKey(com => com.CommandeClientId);

        }
    }
}
