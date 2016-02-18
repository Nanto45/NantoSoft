using NantoSoft.SalesManagement.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NantoSoft.SalesManagement.Metier
{
	/// <summary>
	/// Classe Vente gérant le fonctionnel
	/// </summary>
	public class VenteMetier
	{
		#region Propriétés
		private Vente _vente = null;
		public Vente Vente
		{
			get { return _vente; }
			set { _vente = value; }
		}

		/// <summary>
		/// Réunion au sein de laquelle la vente s'est effectuée
		/// </summary>
		public Reunion Reunion
		{
			get { return _vente.Reunion; }
			set { _vente.Reunion = value; }
		}

		/// <summary>
		/// Personne qui a acheté lors de cette vente
		/// </summary>
		public Personne Personne
		{
			get { return _vente.Personne; }
			set { _vente.Personne = value; }
		}
		#endregion

		#region Constructeur
		public VenteMetier()
		{
			_vente = new Vente();
		}
		#endregion

		#region Méthodes publiques
		/// <summary>
		/// Permet d'ajouter des articles à la vente
		/// </summary>
		/// <param name="articlesVendus">Liste des articles vendus composée de l'article et de son prix</param>
		public void AjouterArticles(Dictionary<Article, decimal> articlesVendus)
		{
			foreach (var articleVendu in articlesVendus)
			{
				VenteArticle va = new VenteArticle() { Vente = _vente, Article = articleVendu.Key, Prix = articleVendu.Value };
				_vente.ArticleVentes.Add(va);
			}
		}

		/// <summary>
		/// Ajout de la vente en cours dans le context
		/// </summary>
		/// <param name="context">Context en cours</param>
		public void AjouterAuContext(SalesManagementContext context)
		{
			context.Vente.Add(_vente);
		}
		#endregion
	}
}
