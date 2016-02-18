using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NantoSoft.SalesManagement.DataBase
{
	/// <summary>
	/// Classe décrivant la table Vente
	/// </summary>
	[Table("Vente")]
	public partial class Vente
	{
		#region Propriétés
		/// <summary>
		/// Identifiant d'une vente
		/// </summary>
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key]
		public Guid IdVente { get; set; }

		#region Réunion
		/// <summary>
		/// Identifiant en lien avec la Reunion
		/// </summary>
		public Guid IdReunion { get; set; }

		/// <summary>
		/// Réunion au sein de laquelle la vente s'est effectuée
		/// </summary>
		[ForeignKey("IdReunion")]
		public virtual Reunion Reunion { get; set; }
		#endregion

		#region Personne
		/// <summary>
		/// Identifiant en lien avec la Personne
		/// </summary>
		public Guid IdPersonne { get; set; }

		/// <summary>
		/// Personne qui a acheté lors de cette vente
		/// </summary>
		[ForeignKey("IdPersonne")]
		public virtual Personne Personne { get; set; }
		#endregion

		/// <summary>
		/// Liste des articles sur cette vente
		/// </summary>
		public virtual ICollection<VenteArticle> ArticleVentes { get; set; }

		#endregion

		#region Constructeur
		public Vente()
		{
			ArticleVentes = new HashSet<VenteArticle>();
		}
		#endregion
	}
}
