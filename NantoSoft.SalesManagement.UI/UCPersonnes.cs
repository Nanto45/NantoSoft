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
	public partial class UCPersonnes : UserControl
	{
		#region Attributs privés
		List<PersonneMetier> listePersonnes = null;
		SalesManagementContext _context;
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
			_context = new SalesManagementContext();
			listePersonnes = PersonneMetier.ChargerPersonnes(_context);
			uiPersonnesBindingSource.DataSource = listePersonnes;
		}
		#endregion

		private void uiPersonnesDg_SelectionChanged(object sender, EventArgs e)
		{
			if (uiPersonnesDg.CurrentRow.DataBoundItem != null)
				uiPersonneBindingSource.DataSource = (PersonneMetier)uiPersonnesDg.CurrentRow.DataBoundItem;
		}
	}
}
