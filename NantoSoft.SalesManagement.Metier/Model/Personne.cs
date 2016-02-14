using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NantoSoft.SalesManagement.Metier
{
	/// <summary>
	/// Classe décrivant une personne. Par défauit une personne est un prospect
	/// </summary>
	[Table("Personne")]
	public partial class Personne
	{
		#region Propriétés
		/// <summary>
		/// Identifiant de la personne
		/// </summary>
		[Key]
		public Guid IdPersonne { get; set; }

		/// <summary>
		/// Nom de la personne
		/// </summary>
		[Required(ErrorMessage = "Nom obligatoire pour une personne")]
		public string Nom { get; set; }

		/// <summary>
		/// Prénom de la personne
		/// </summary>
		public string Prenom { get; set; }

		/// <summary>
		/// Date de naissance de la personne
		/// </summary>
		public DateTime DateNaissance { get; set; }

		/// <summary>
		/// Numéro de téléphone du domicile
		/// </summary>
		public string TelephoneDomicile { get; set; }

		/// <summary>
		/// Numéro de téléphone mobile
		/// </summary>
		public string TelephoneMobile { get; set; }

		/// <summary>
		/// Email de la personne
		/// </summary>
		public string Email { get; set; }

		#region Adresse
		/// <summary>
		/// Identifiant lié à l'adresse
		/// </summary>
		public Guid IdAdresse { get; set; }

		/// <summary>
		/// Adresse de la personne
		/// </summary>
		[ForeignKey("IdAdresse")]
		public Adresse Adresse { get; set; }
		#endregion

		#endregion
	}
}
