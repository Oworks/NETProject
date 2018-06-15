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
    class LogProduitFluent : EntityTypeConfiguration<LogProduit>
    {
        public LogProduitFluent()
        {
            ToTable("APP_LogProduit");
            HasKey(logP => logP.IdLog);

            Property(logP => logP.IdLog).HasColumnName("LOG_LOGID").IsRequired().HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(logP => logP.LogMessage).HasColumnName("LOG_MESSAGE");
            Property(logP => logP.LogDate).HasColumnName("LOG_DATE");
            HasRequired(logP => logP.Produit).WithMany().HasForeignKey(logP => logP.LogProduitId);
        }
    }
}
