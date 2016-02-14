using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NantoSoft.SalesManagement.Metier;
using NantoSoft.SalesManagement.DataBase;

namespace NantoSoft.SalesManagement
{
	public partial class UCReunions : UserControl
	{
		#region Attributs privés
		List<Personne> listePersonnes = null;
		#endregion

		#region Constructeur
		public UCReunions()
		{
			InitializeComponent();
		}
		#endregion

		#region UI Events
		private void UCPersonnes_Load(object sender, EventArgs e)
		{
			using (SalesManagementContext smContext = new SalesManagementContext())
			{
				listePersonnes = smContext.Personne.Where(p => p.Nom != string.Empty).ToList();
				uiReunionsBindingSource.DataSource = listePersonnes;
			}
		}
		#endregion
	}
}
