using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NantoSoft.SalesManagement.DataBase
{
	/// <summary>
	/// Classe décrivant la table Article
	/// </summary>
	[Table("Article")]
	public partial class Article
	{
		#region Propriétés
		/// <summary>
		/// Identifiant de l'article
		/// </summary>
		[Key]
		public Guid IdArticle { get; set; }

		/// <summary>
		/// Libelle de l'article
		/// </summary>
		[Required(ErrorMessage = "Libellé obligatoire pour un article.")]
		public string Libelle { get; set; }

		/// <summary>
		/// Prix de vente de l'article
		/// </summary>
		public decimal PrixVente { get; set; }

		#region Famille
		/// <summary>
		/// Identifiant en lien avec la classe Famille
		/// </summary>
		[Required(ErrorMessage = "Famille obligatoire pour un article.")]
		public short IdFamille { get; set; }

		/// <summary>
		/// Fammille liée à l'article
		/// </summary>
		[ForeignKey("IdFamille")]
		public virtual Famille Famille { get; set; }
		#endregion

		#endregion
	}
}
