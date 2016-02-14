using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NantoSoft.SalesManagement.Metier
{
	[Table("Contact")]
	public partial class Contact
	{
		#region Propriétés
		/// <summary>
		/// Identifiant du contact
		/// </summary>
		[Key]
		public Guid IdContact { get; set; }

		/// <summary>
		/// Type de contact (ex : téléphone, email, ...)
		/// </summary>
		[Required(ErrorMessage = "Type obligatoire pour enregistrer un contact")]
		public TypeContactEnum Type { get; set; }

		/// <summary>
		/// Date du contact
		/// </summary>
		[Required(ErrorMessage = "Date obligatoire pour enregistrer un contact")]
		public DateTime Date { get; set; }

		#region Personne
		/// <summary>
		/// Identifiant en lien avec la personne
		/// </summary>
		public Guid IdPersonne { get; set; }

		/// <summary>
		/// Personne liée au contact
		/// </summary>
		[Required(ErrorMessage = "Personne obligatoire pour enregistrer un contact")]
		[ForeignKey("IdPersonne")]
		public Personne Personne { get; set; }
		#endregion

		#endregion
	}
}
