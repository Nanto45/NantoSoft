using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NantoSoft.SalesManagement.DataBase
{
	/// <summary>
	/// Classe décrivant la table Commune
	/// </summary>
	[Table("Commune")]
	public partial class Commune
	{
		#region Propriétés
		/// <summary>
		/// Identifiant de la commune
		/// </summary>
		[Key]
		public Guid IdCommune { get; set; }

		/// <summary>
		/// Code postal de la commune
		/// </summary>
		[Required(ErrorMessage = "Code postal obligatoire dans une commune")]
		[MaxLength(5)]
		public string CodePostal { get; set; }

		/// <summary>
		/// Libellé de la commune
		/// </summary>
		[Required(ErrorMessage = "Libellé obligatoire dans une commune")]
		public string Libelle { get; set; }
		#endregion
	}
}
