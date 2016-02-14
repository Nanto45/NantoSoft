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
	/// Classe décrivant un client. Cette classe dérive de la classe personne.
	/// Ce comportment intervient au moment où la personne passe une première commande et devient donc un client
	/// ou lorsque la personne était déjà cliente mais suivie par un autre conseiller.
	/// </summary>
	[Table("Client")]
	public partial class Client : Personne
	{
		#region Propriétés
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
		#endregion
	}
}
