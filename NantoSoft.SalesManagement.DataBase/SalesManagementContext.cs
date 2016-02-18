using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NantoSoft.SalesManagement.DataBase
{
	[DbConfigurationType(typeof(MySqlEFConfiguration))]
	public class SalesManagementContext : DbContext
	{
		#region Entités
		public DbSet<Adresse> Adresse { get; set; }
		public DbSet<Article> Article { get; set; }
		public DbSet<Client> Client { get; set; }
		public DbSet<Commune> Commune { get; set; }
		public DbSet<Contact> Contact { get; set; }
		public DbSet<Famille> Famille { get; set; }
		public DbSet<Frais> Frais { get; set; }
		public DbSet<Personne> Personne { get; set; }
		public DbSet<Reunion> Reunion { get; set; }
		public DbSet<Vente> Vente { get; set; }
		#endregion

		#region Constructeur
		public SalesManagementContext() : base("SMConnectionString")
		{ }
		#endregion

		#region Méthodes publiques
		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			//modelBuilder.Entity<ReunionPersonne>().HasKey(r => new { r.IdReunion, r.IdPersonne });
			//modelBuilder.Entity<ReunionPersonne>().HasRequired(r => r.Personne)
			//							.WithMany(r => r.ReunionPersonnes)
			//							.HasForeignKey(r => r.IdPersonne);

			//modelBuilder.Entity<VenteArticle>().HasKey(v => new { v.IdVente, v.IdArticle });
			//modelBuilder.Entity<VenteArticle>().HasRequired(v => v.Article)
			//							.WithMany(v => v.VenteArticles)
			//							.HasForeignKey(v => v.IdArticle);
		}
		#endregion
	}
}
