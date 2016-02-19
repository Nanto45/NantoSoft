using NantoSoft.SalesManagement.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NantoSoft.SalesManagement.Metier
{
	/// <summary>
	/// Classe Adresse gérant le fonctionnel
	/// </summary>
	public class AdresseMetier
	{
		#region Attributs
		private Adresse _adresse = null;
		#endregion

		#region Constructeur
		public AdresseMetier()
		{
			_adresse = new Adresse();
			_commune = new CommuneMetier();
		}

		public AdresseMetier(Adresse adresse)
		{
			_adresse = adresse;
			_commune = new CommuneMetier(adresse.Commune);
		}
		#endregion

		#region Propriétés
		/// <summary>
		/// Numéro, lettre et description de la voie
		/// </summary>
		public string Voie
		{
			get { return _adresse.Voie; }
			set { _adresse.Voie = value; }
		}

		/// <summary>
		/// Complément, lieu dit
		/// </summary>
		public string Complement
		{
			get { return _adresse.Complement; }
			set { _adresse.Complement = value; }
		}

		/// <summary>
		/// Adresse avec un Cedex
		/// </summary>
		public bool Cedex
		{
			get { return _adresse.Cedex; }
			set { _adresse.Cedex = value; }
		}

		private CommuneMetier _commune = null;
		/// <summary>
		/// Commune liée à l'adresse
		/// </summary>
		public CommuneMetier Commune
		{
			get { return _commune; }
			set { _commune = value; }
		}

		/// <summary>
		/// Obtient l'adresse sous jacente
		/// </summary>
		public Adresse Adresse
		{
			get { return _adresse; }
		}
		#endregion

		#region Méthodes
		/// <summary>
		/// Permet de renvoyer l'adresse correctement formatée
		/// </summary>
		/// <returns></returns>
		public override string ToString()
		{
			return string.Format("{0}{1}{2}{3}",
								Voie,
								!string.IsNullOrEmpty(Complement) ? " " + Complement : Complement,
								Commune != null ? " " + Commune.CodePostal : string.Empty,
								Commune != null ? " " + Commune.Libelle : string.Empty).Trim();

		}

		/// <summary>
		/// Sauvegarde d'une adresse
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		public bool Sauvegarder (SalesManagementContext context)
		{
			bool resultat = false;

			try
			{
				_adresse.Commune = _commune.Commune;
				context.Adresse.Add(_adresse);
			}
			catch (Exception exc)
			{
				throw exc;
			}

			return resultat;
		}
		#endregion
	}
}
