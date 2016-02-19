using NantoSoft.SalesManagement.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NantoSoft.SalesManagement.Metier
{
	/// <summary>
	/// Classe Article gérant le fonctionnel
	/// </summary>
	public class ArticleMetier
	{
		#region Constructeur
		public ArticleMetier()
		{
			_article = new Article();
		}

		public ArticleMetier(Article article)
		{
			_article = article;
		}
		#endregion

		#region Propriétés
		private Article _article = null;
		/// <summary>
		/// Obtient l'article sous-jacent
		/// </summary>
		public Article Article
		{
			get { return _article; }
		}
		#endregion

		#region Méthodes
		/// <summary>
		/// Sauvegarde d'un article
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		public bool Sauvegarder(SalesManagementContext context)
		{
			bool resultat = false;

			try
			{
				context.Article.Add(_article);
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
