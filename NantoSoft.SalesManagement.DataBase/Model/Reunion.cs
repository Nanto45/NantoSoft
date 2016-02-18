using System;
using System.Collections.Generic;
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
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

		/// <summary>
		/// Liste des personnes de la réunion
		/// </summary>
		public virtual ICollection<ReunionPersonne> ReunionPersonnes { get; set; }

		/// <summary>
		/// Liste des frais de la réunion
		/// </summary>
		public virtual ICollection<Frais> Frais { get; set; }

		/// <summary>
		/// Liste des ventes de la réunion
		/// </summary>
		public virtual ICollection<Vente> Ventes { get; set; }

		#endregion

		#region Constructeur
		public Reunion()
		{
			ReunionPersonnes = new HashSet<ReunionPersonne>();
			Frais = new HashSet<Frais>();
			Ventes = new HashSet<Vente>();
		}
		#endregion
	}
}
