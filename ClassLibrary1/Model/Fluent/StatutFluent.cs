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
    public class StatutFluent : EntityTypeConfiguration<Statut>
    {
        public StatutFluent()
        {
            ToTable("APP_Statut");
            HasKey(sta => sta.Id);

            Property(sta => sta.Id).HasColumnName("STA_ID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(sta => sta.Libelle).HasColumnName("STA_LIBELLE").IsRequired().HasMaxLength(50);
        }
    }
}
