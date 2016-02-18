using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NantoSoft.SalesManagement.DataBase
{
	/// <summary>
	/// Classé décrivant la table Frais
	/// </summary>
	[Table("Frais")]
	public partial class Frais
	{
		#region Propriétés
		/// <summary>
		/// Identidiant du frais
		/// </summary>
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key]
		public Guid IdFrais { get; set; }

		/// <summary>
		/// Type de frais (ex : carburant, péage, ...)
		/// </summary>
		[Required(ErrorMessage = "Type obligatoire pour enregistrer un frais")]
		public TypeFraisEnum Type { get; set; }

		/// <summary>
		/// Valeur du frais
		/// </summary>
		[Required(ErrorMessage = "Valeur obligatoire pour enregistrer un frais")]
		public decimal Valeur { get; set; }

		#region Reunion
		/// <summary>
		/// Identifiant lié à la réunion
		/// </summary>
		public Guid IdReunion { get; set; }

		/// <summary>
		/// Reunion au cours de la laquelle les frais ont eu lieu
		/// </summary>
		[ForeignKey("IdReunion")]
		public Reunion Reunion { get; set; }
		#endregion

		#endregion
	}
}
