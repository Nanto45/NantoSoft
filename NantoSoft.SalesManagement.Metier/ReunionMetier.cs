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

		/// <summary>
		/// Adresse de la réunion
		/// </summary>
		public Adresse Adresse
		{
			get { return _reunion.Adresse; }
			set { _reunion.Adresse = value; }
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
				if (_reunion.Adresse != null)
					return _reunion.Adresse.ToString();
				else
					return string.Empty;
			}
		}

		/// <summary>
		/// Liste des personnes de la réunion
		/// </summary>
		public ICollection<Personne> Personnes
		{
			get
			{
				if (_reunion != null)
					return _reunion.ReunionPersonnes.Select(rp => rp.Personne).ToList();
				else
					return null;
			}
		}
		#endregion

		#region Constructeur
		public ReunionMetier()
		{
			_reunion = new Reunion();
		}
		#endregion

		#region Méthodes publiques
		/// <summary>
		/// Permet de faire participer une personne à une réunion
		/// </summary>
		/// <param name="personne">Personne à raccrocher à la réunion</param>
		/// <param name="hote">Statut d'hôte ou non</param>
		public void AjouterParticipant(Personne personne, bool hote)
		{
			ReunionPersonne rp = new ReunionPersonne()
			{
				Reunion = _reunion,
				Personne = personne,
				Hote = hote,
				Invite = !hote
			};

			_reunion.ReunionPersonnes.Add(rp);
		}

		/// <summary>
		/// Ajout de la réunion en cours dans le context
		/// </summary>
		/// <param name="context">Context en cours</param>
		public void AjouterAuContext(SalesManagementContext context)
		{
			context.Reunion.Add(_reunion);
		}
		#endregion
	}
}
