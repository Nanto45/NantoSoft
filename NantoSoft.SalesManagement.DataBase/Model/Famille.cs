using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NantoSoft.SalesManagement.DataBase
{
	/// <summary>
	/// Classe décrivant une famille d'articles
	/// </summary>
	[Table("Famille")]
	public partial class Famille
	{
		#region Propriétés
		/// <summary>
		/// Identifiant de la famille d'articles
		/// </summary>
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		[Key]
		public short IdFamille { get; set; }

		[Required(ErrorMessage = "Libellé obligatoire pour une famille d'articles.")]
		public string Libelle { get; set; }

		/// <summary>
		/// Liste des articles de la famille
		/// </summary>
		public virtual ICollection<Article> Articles { get; set; }
		#endregion

		#region Constructeur
		public Famille()
		{
			Articles = new HashSet<Article>();
		}
		#endregion
	}
}
