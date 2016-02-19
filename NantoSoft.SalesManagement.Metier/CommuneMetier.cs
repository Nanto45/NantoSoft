using NantoSoft.SalesManagement.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NantoSoft.SalesManagement.Metier
{
	/// <summary>
	/// Classe Commune gérant le fonctionnel
	/// </summary>
	public class CommuneMetier
	{
		#region Attributs privés
		private Commune _commune = null;
		#endregion

		#region Constructeur
		public CommuneMetier()
		{
			_commune = new Commune();
		}

		public CommuneMetier(Commune commune)
		{
			_commune = commune;
		}
		#endregion

		#region Propriétés
		/// <summary>
		/// Code postal de la commune
		/// </summary>
		public string CodePostal
		{
			get { return _commune.CodePostal; }
			set { _commune.CodePostal = value; }
		}

		/// <summary>
		/// Libellé de la commune
		/// </summary>
		public string Libelle
		{
			get { return _commune.Libelle; }
			set { _commune.Libelle = value; }
		}

		/// <summary>
		/// Obtient la commune sous-jacente
		/// </summary>
		public Commune Commune
		{
			get { return _commune; }
		}
		#endregion
	}
}
