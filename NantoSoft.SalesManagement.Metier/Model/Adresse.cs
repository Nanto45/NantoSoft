using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NantoSoft.SalesManagement.Metier
{
	[Table("Adresse")]
	public partial class Adresse
	{
		#region Propriétés
		/// <summary>
		/// Identifiant de l'adresse
		/// </summary>
		[Key]
		public Guid IdAdresse { get; set; }

		/// <summary>
		/// Numéro de la rue
		/// </summary>
		public int NumeroRue { get; set; }

		/// <summary>
		/// Lettre liée au numéro
		/// </summary>
		public string Lettre { get; set; }

		/// <summary>
		/// Description de la voie
		/// </summary>
		public string Voie { get; set; }

		/// <summary>
		/// Complément, lieu dit
		/// </summary>
		public string Complement { get; set; }

		/// <summary>
		/// Adresse avec un Cedex
		/// </summary>
		public bool Cedex { get; set; }

		#region Commune
		/// <summary>
		/// Identifiant de lien avec la commune
		/// </summary>
		public Guid IdCommune { get; set; }
		
		/// <summary>
		/// Commune liée à l'adresse
		/// </summary>
		[ForeignKey("IdCommune")]
		public Commune Commune { get; set; }
		#endregion

		#endregion

		#region Méthodes
		/// <summary>
		/// Permet de renvoyer l'adresse correctement formatée
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("{0}{1}{2}{3}{4}{5}",
								NumeroRue.ToString(),
								Lettre,
								!string.IsNullOrEmpty(Voie) ? " " + Voie : Voie,
								!string.IsNullOrEmpty(Complement) ? " " + Complement : Complement,
								Commune != null ? Commune.CodePostal : string.Empty,
								Commune != null ? Commune.Libelle : string.Empty);

		}
		#endregion
	}
}
