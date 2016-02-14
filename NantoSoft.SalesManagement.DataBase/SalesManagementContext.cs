using MySql.Data.Entity;
using NantoSoft.SalesManagement.Metier;
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
		public DbSet<Client> Client { get; set; }
		public DbSet<Commune> Commune { get; set; }
		public DbSet<Contact> Contact { get; set; }
		public DbSet<Personne> Personne { get; set; }
		public DbSet<Reunion> Reunion { get; set; }
		public DbSet<ReunionPersonne> ReunionPersonne { get; set; }
		#endregion

		#region Constructeur
		public SalesManagementContext() : base("SMConnectionString")
		{ }
		#endregion
	}
}
