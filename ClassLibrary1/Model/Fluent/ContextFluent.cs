using ClassLibrary1.Model.Entities;
using System.Data.Entity;
using System.Reflection;

namespace ClassLibrary1.Model.Fluent
{
    public class ContextFluent : DbContext
    {
        public DbSet<Categorie> Offres { get; set; }
        public DbSet<Statut> Statuts { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<Produit> Produits { get; set; }

        public ContextFluent() : base("name=Database")
        {
            //Database.SetInitializer<ContextFluent>(new DropCreateDatabaseIfModelChanges<ContextFluent>());
            Database.SetInitializer<ContextFluent>(null);

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());

        }
    }
}
