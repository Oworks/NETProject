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
    public class ClientFluent : EntityTypeConfiguration<Client>
    {
        public ClientFluent()
        {
            ToTable("APP_Client");
            HasKey(cli => cli.Id);

            Property(cli => cli.Id).HasColumnName("CLI_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(cli => cli.Nom).HasColumnName("CLI_NOM").IsRequired().HasMaxLength(50);
            Property(cli => cli.Prenom).HasColumnName("CLI_PRENOM").IsRequired().HasMaxLength(50);
            Property(cli => cli.Actif).HasColumnName("CLI_ACTIF").IsRequired();
        }
    }
}
