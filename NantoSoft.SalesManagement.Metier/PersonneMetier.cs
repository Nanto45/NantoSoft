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
		public DateTime DateNaissance
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
				if (_personne.Adresse != null)
					return _personne.Adresse.ToString();
				else
					return string.Empty;
			}
		}

		/// <summary>
		/// Adresse de la personne
		/// </summary>
		public Adresse Adresse
		{
			get { return _personne.Adresse; }
			set { _personne.Adresse = value; }
		}

		/// <summary>
		/// Liste des contacts effectués auprès de la personne
		/// </summary>
		public ICollection<Contact> Contacts
		{
			get { return _personne.Contacts; }
			set { _personne.Contacts = value; }
		}

		/// <summary>
		/// Liste des réunions auxquelles la personne a participé
		/// </summary>
		public ICollection<Reunion> Reunions
		{
			get
			{
				return _personne.ReunionPersonnes.Select(rp => rp.Reunion).ToList();
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
		/// Permet de faire participer une personne à une réunion
		/// </summary>
		/// <param name="reunion">Réunion à laquelle on raccroche la personne</param>
		/// <param name="hote">Statut d'hôte ou non</param>
		public void ParticiperReunion(Reunion reunion, bool hote)
		{
			ReunionPersonne rp = new ReunionPersonne()
			{
				Personne = _personne,
				Reunion = reunion,
				Hote = hote,
				Invite = !hote
			};

			_personne.ReunionPersonnes.Add(rp);
		}

		/// <summary>
		/// Ajout de la personne en cours dans le context
		/// </summary>
		/// <param name="context">Context en cours</param>
		public void Ajouter(SalesManagementContext context)
		{
			context.Personne.Add(_personne);
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
