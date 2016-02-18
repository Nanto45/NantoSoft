using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NantoSoft.SalesManagement.DataBase
{
	/// <summary>
	/// Classe décrivant la table Reunion
	/// </summary>
	[Table("Reunion")]
	public partial class Reunion
	{
		#region Propriétés
		/// <summary>
		/// Identifiant de la réunion
		/// </summary>
		[Key]
		public Guid IdReunion { get; set; }

		/// <summary>
		/// Date et heure de la réunion
		/// </summary>
		[Required(ErrorMessage = "Date et heure de la réunion obligatoire.")]
		public DateTime Date { get; set; }

		/// <summary>
		/// Notes liées à une réunion
		/// </summary>
		public string Note { get; set; }

		#region Adresse
		/// <summary>
		/// Identifiant en lien avec l'adresse
		/// </summary>
		public Guid IdAdresse { get; set; }

		/// <summary>
		/// Adresse où a lieu la réunion. Par défaut la réunion a lieu à l'adresse de l'hôte.
		/// </summary>
		[ForeignKey("IdAdresse")]
		[Required(ErrorMessage = "Adresse de la réunion obligatoire.")]
		public virtual Adresse Adresse { get; set; }
		#endregion

		#endregion
	}
}
