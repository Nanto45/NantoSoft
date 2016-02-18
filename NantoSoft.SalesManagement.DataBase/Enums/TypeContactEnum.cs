using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NantoSoft.SalesManagement.DataBase
{
	/// <summary>
	/// Enumération présentant les types de contact
	/// </summary>
	public enum TypeContactEnum : byte
	{
		/// <summary>
		/// Contact téléphonique
		/// </summary>
		Telephone = 0,
		/// <summary>
		/// Contact par email
		/// </summary>
		Email = 1,
		/// <summary>
		/// Contact de vive voie
		/// </summary>
		Physique = 2
	}
}
