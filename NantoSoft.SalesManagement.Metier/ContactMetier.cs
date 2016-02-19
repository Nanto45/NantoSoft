using NantoSoft.SalesManagement.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NantoSoft.SalesManagement.Metier
{
	/// <summary>
	/// Classe Contact gérant le fonctionnel
	/// </summary>
	public class ContactMetier
	{
		#region Attributs privés
		private Contact _contact = null;
		#endregion

		#region Constructeurs
		public ContactMetier ()
		{
			_contact = new Contact();
		}

		public ContactMetier(Contact contact)
		{
			_contact = contact;
		}
		#endregion

		#region Propriétés
		/// <summary>
		/// Obtient le contact sous-jacent
		/// </summary>
		public Contact Contact
		{
			get { return _contact; }
		}
		#endregion
	}
}
