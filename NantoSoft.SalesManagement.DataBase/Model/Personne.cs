using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NantoSoft.SalesManagement.DataBase
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
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
		public DateTime? DateNaissance { get; set; }

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

		/// <summary>
		/// Date à laquelle la personne est passée cliente.
		/// </summary>
		public DateTime? DateClient { get; set; }

		/// <summary>
		/// Obtient ou définit si le client est un client gagné par le vendeur en cours
		/// </summary>
		public bool ClientGagne { get; set; }

		/// <summary>
		/// Obtient ou définit si la personne est cliente ou non
		/// </summary>
		public bool Client { get; set; }

		/// <summary>
		/// Si le client n'est pas issu d'une conquête par le vendeur en cours, nom du vendeur
		/// </summary>
		public string ClientNomVendeur { get; set; }

		#region Adresse
		/// <summary>
		/// Identifiant lié à l'adresse
		/// </summary>
		public Guid IdAdresse { get; set; }

		/// <summary>
		/// Adresse de la personne
		/// </summary>
		[ForeignKey("IdAdresse")]
		public virtual Adresse Adresse { get; set; }
		#endregion

		/// <summary>
		/// Liste des réunions auxquelles la personne a participé
		/// </summary>
		public virtual ICollection<ReunionPersonne> ReunionPersonnes { get; set; }

		/// <summary>
		/// Liste des contacts effectués auprès de la personne
		/// </summary>
		public virtual ICollection<Contact> Contacts { get; set; }

		#endregion

		#region Constructeur
		public Personne()
		{
			ReunionPersonnes = new HashSet<ReunionPersonne>();
			Contacts = new HashSet<Contact>();
		}
		#endregion
	}
}
