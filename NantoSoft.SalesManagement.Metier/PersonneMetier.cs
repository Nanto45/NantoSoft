using NantoSoft.SalesManagement.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NantoSoft.SalesManagement.Metier
{
	/// <summary>
	/// Classe Personne gérant le fonctionnel
	/// </summary>
	public class PersonneMetier
	{
		#region Propriétés
		private Personne _personne = null;
		/// <summary>
		/// Personne sous-jacente
		/// </summary>
		public Personne Personne
		{
			get { return _personne; }
			set { _personne = value; }
		}

		/// <summary>
		/// Nom de la personne
		/// </summary>
		public string Nom
		{
			get { return _personne.Nom; }
			set { _personne.Nom = value; }
		}

		/// <summary>
		/// Prénom de la personne
		/// </summary>
		public string Prenom
		{
			get { return _personne.Prenom; }
			set { _personne.Prenom = value; }
		}

		/// <summary>
		/// Date de naissance de la personne
		/// </summary>
		public DateTime? DateNaissance
		{
			get { return _personne.DateNaissance; }
			set { _personne.DateNaissance = value; }
		}

		/// <summary>
		/// Numéro de téléphone du domicile
		/// </summary>
		public string TelephoneDomicile
		{
			get { return _personne.TelephoneDomicile; }
			set { _personne.TelephoneDomicile = value; }
		}

		/// <summary>
		/// Numéro de téléphone mobile
		/// </summary>
		public string TelephoneMobile
		{
			get { return _personne.TelephoneMobile; }
			set { _personne.TelephoneMobile = value; }
		}

		/// <summary>
		/// Email de la personne
		/// </summary>
		public string Email
		{
			get { return _personne.Email; }
			set { _personne.Email = value; }
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

		/// <summary>
		/// Adresse de la personne
		/// </summary>
		private AdresseMetier _adresse = null;
		public AdresseMetier Adresse
		{
			get { return _adresse; }
			set
			{ 
				_adresse = value;
				_personne.Adresse = _adresse.Adresse;
			}
		}

		/// <summary>
		/// Liste des contacts effectués auprès de la personne
		/// </summary>
		private List<ContactMetier> _contacts = null;
		public List<ContactMetier> Contacts
		{
			get { return _contacts; }
			set
			{
				_contacts = value;
				_contacts.ForEach(c => { _personne.Contacts.Add(c.Contact); });
			}
		}

		/// <summary>
		/// Liste des réunions auxquelles la personne a participé
		/// </summary>
		public List<ReunionMetier> Reunions
		{
			get
			{
				List<ReunionMetier> reunionsMetier = new List<ReunionMetier>();
				var reunionsBase = _personne.ReunionPersonnes.Select(rp => rp.Reunion).ToList();
				reunionsBase.ForEach(r =>
				{
					ReunionMetier reunionM = new ReunionMetier(r);
					reunionsMetier.Add(reunionM);
				});
				return reunionsMetier;
			}
		}
		#endregion

		#region Constructeur
		public PersonneMetier()
		{
			_personne = new Personne();
		}

		public PersonneMetier(Personne personne)
		{
			_personne = personne;
		}
		#endregion

		#region Méthodes publiques
		/// <summary>
		/// Sauvegarde d'un personne
		/// </summary>
		/// <returns></returns>
		public bool Sauvegarder(SalesManagementContext context)
		{
			bool resultat = false;

			try
			{
				//Remise à 0 des zones qui ne doivent pas être renseignées s'il ne s'agit pas d'un client.
				if (!_personne.Client)
				{
					_personne.ClientGagne = false;
					_personne.ClientNomVendeur = string.Empty;
					_personne.DateClient = null;
				}

				if (_contacts != null && _contacts.Count() > 0)
					_contacts.ForEach(c => { _personne.Contacts.Add(c.Contact); });

				context.Personne.Add(_personne);
				context.SaveChanges();
			}
			catch (Exception exc)
			{
				throw exc;
			}

			return resultat;
		}
		#endregion

		#region Méthodes statiques
		public static List<PersonneMetier> ChargerPersonnes(SalesManagementContext context)
		{
			var personnes = context.Personne.ToList();

			List<PersonneMetier> personnesARetourner = new List<PersonneMetier>();

			foreach (Personne personne in personnes)
			{
				PersonneMetier personneMetier = new PersonneMetier(personne);
				personnesARetourner.Add(personneMetier);
			}

			return personnesARetourner;
		}
		#endregion
	}
}
