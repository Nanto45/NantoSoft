using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NantoSoft.SalesManagement.Metier
{
	[Table("ReunionPersonne")]
	public partial class ReunionPersonne
	{
		#region Propriétés

		#region Reunion
		/// <summary>
		/// Identifiant composé lié à Reunion
		/// </summary>
		[Column(Order = 0), Key]
		public Guid IdReunion { get; set; }

		/// <summary>
		/// Réunion à laquelle ont participé les personnes enregistrées
		/// </summary>
		[ForeignKey("IdReunion")]
		public virtual Reunion Reunion { get; set; }
		#endregion

		#region Personne
		/// <summary>
		/// Identifiant composé ié à Personne
		/// </summary>
		[Column(Order = 1), Key]
		public Guid IdPersonne { get; set; }

		/// <summary>
		/// Personne enregistrée à cette réunion.
		/// </summary>
		[ForeignKey("IdPersonne")]
		public virtual Personne Personne { get; set; }
		#endregion

		/// <summary>
		/// La personne était-elle hôte de la réunion
		/// </summary>
		public bool Hote { get; set; }

		/// <summary>
		/// La personne était-elle invitée de la réunion
		/// </summary>
		public bool Invite { get; set; }
		#endregion
	}
}
