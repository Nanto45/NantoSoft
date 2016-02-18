using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NantoSoft.SalesManagement.DataBase
{
	/// <summary>
	/// Classe décrivant le lien entre les article vendus au cours d'une vente
	/// </summary>
	[Table("VenteArticle")]
	public partial class VenteArticle
	{
		#region Propriétés

		#region Vente
		/// <summary>
		/// Identifiant lié à la vente
		/// </summary>
		[Key]
		[Column(Order = 0)]
		public Guid IdVente { get; set; }

		/// <summary>
		/// Vente durant laquelle les articles ont été achetés
		/// </summary>
		public virtual Vente Vente { get; set; }
		#endregion

		#region Article
		/// <summary>
		/// Identifiant lié à l'article
		/// </summary>
		[Key]
		[Column(Order = 1)]
		public Guid IdArticle { get; set; }

		/// <summary>
		/// Article acheté durant la vente
		/// </summary>
		public virtual Article Article { get; set; }
		#endregion

		/// <summary>
		/// Prix de vente de l'article
		/// </summary>
		public decimal Prix { get; set; }

		#endregion
	}
}
