using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NantoSoft.SalesManagement.DataBase
{
	/// <summary>
	/// Classe décrivant un client. 
	/// Le passage en client intervient au moment où la personne passe une première commande
	/// ou lorsque la personne était déjà cliente mais suivie par un autre conseiller.
	/// </summary>
	[Table("Client")]
	public partial class Client
	{
		#region Propriétés
		/// <summary>
		/// Identifiant du client
		/// </summary>
		[Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid IdClient { get; set; }

		/// <summary>
		/// Date à laquelle la personne est passée cliente.
		/// </summary>
		[Required(ErrorMessage = "Date de passage en \"Client\" obligatoire.")]
		public DateTime DateClient { get; set; }

		/// <summary>
		/// Obtient ou définit si le client est un client gagné par le vendeur en cours
		/// </summary>
		public bool Gagne { get; set; }

		/// <summary>
		/// Si le client n'est pas issu d'une conquête par le vendeur en cours, nom du vendeur
		/// </summary>
		public string NomVendeur { get; set; }

		#region Personne
		/// <summary>
		/// Identifiant lié à la personne
		/// </summary>
		public Guid IdPersonne { get; set; }

		/// <summary>
		/// Personne sous jacente qui est devenue client
		/// </summary>
		[ForeignKey("IdPersonne")]
		public virtual Personne Personne { get; set; }
		#endregion

		#endregion
	}
}
