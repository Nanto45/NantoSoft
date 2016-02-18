using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NantoSoft.SalesManagement.DataBase;

namespace NantoSoft.SalesManagement
{
	public partial class UCPersonnes : UserControl
	{
		#region Attributs privés
		List<Personne> listePersonnes = null;
		#endregion

		#region Constructeur
		public UCPersonnes()
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
				uiPersonnesBindingSource.DataSource = listePersonnes;
			}
		}
		#endregion
	}
}
