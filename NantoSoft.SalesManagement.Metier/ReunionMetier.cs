using NantoSoft.SalesManagement.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NantoSoft.SalesManagement.Metier
{
	/// <summary>
	/// Classe Reunion gérant le fonctionnel
	/// </summary>
	public class ReunionMetier
	{
		#region Propriétés
		private Reunion _reunion = null;
		/// <summary>
		/// Réunion sous-jacente
		/// </summary>
		public Reunion Reunion
		{
			get { return _reunion; }
			set { _reunion = value; }
		}

		/// <summary>
		/// Date de la réunion
		/// </summary>
		public DateTime Date
		{
			get { return _reunion.Date; }
			set { _reunion.Date = value; }
		}

		private AdresseMetier _adresse = null;
		/// <summary>
		/// Adresse de la réunion
		/// </summary>
		public AdresseMetier Adresse
		{
			get { return _adresse; }
			set { _adresse = value; }
		}

		/// <summary>
		/// Note de la réunion
		/// </summary>
		public string Note
		{
			get { return _reunion.Note; }
			set { _reunion.Note = value; }
		}

		/// <summary>
		/// Obtient une string pour afficher l'adresse dans une grid
		/// </summary>
		public string AdresseAffichee
		{
			get
			{
				if (Adresse != null)
					return Adresse.ToString();
				else
					return string.Empty;
			}
		}

		private List<PersonneMetier> _personnes = null;
		/// <summary>
		/// Liste des personnes de la réunion
		/// </summary>
		public List<PersonneMetier> Personnes
		{
			get { return _personnes; }
		}
		#endregion

		#region Constructeur
		public ReunionMetier()
		{
			_reunion = new Reunion();
			_adresse = new AdresseMetier();
			_personnes = new List<PersonneMetier>();
		}

		public ReunionMetier(Reunion reunion)
		{
			_reunion = reunion;
			_adresse = new AdresseMetier(reunion.Adresse);
			_personnes = new List<PersonneMetier>();
			foreach (var rp in _reunion.ReunionPersonnes)
				_personnes.Add(new PersonneMetier(rp.Personne));
		}
		#endregion

		#region Méthodes publiques
		/// <summary>
		/// Ajout de la réunion en cours dans le context
		/// </summary>
		/// <param name="context">Context en cours</param>
		public bool Sauvegarder()
		{
			bool resultat = false;
			try
			{
				using (SalesManagementContext context = new SalesManagementContext())
				{
					context.Reunion.Add(_reunion);
					context.SaveChanges();
				}
				resultat = true;
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
