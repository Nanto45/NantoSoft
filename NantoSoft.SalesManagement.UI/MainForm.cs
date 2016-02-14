using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NantoSoft.SalesManagement.DataBase;
using NantoSoft.SalesManagement.Metier;

namespace NantoSoft.SalesManagement
{
	public partial class MainForm : Form
	{
		#region Attributs privés
		private UCPersonnes _ucPersonnes = null;
		private UCReunions _ucReunions = null;
		#endregion

		#region Constructeur
		public MainForm()
		{
			InitializeComponent();
		}
		#endregion

		#region Méthodes privées
		/// <summary>
		/// Nettoyage des panels à l'écran pour éviter de trop surcharger la mémoire
		/// </summary>
		private void NettoyerPanels()
		{
			foreach(Control ctrl in uiPanelMain.Controls)
			{
				if (ctrl.GetType().BaseType == typeof(UserControl))
					ctrl.Dispose();
			}
		}
		#endregion

		#region UI Events
		private void uiQuitter_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void genererDBToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			try
			{
				using (SalesManagementContext smContext = new SalesManagementContext())
				{
					if (smContext.Personne.Any(p => p.IdPersonne != Guid.Empty))
						MessageBox.Show("La base de données est déjà présente.", "Génération", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception exc)
			{
				Cursor.Current = Cursors.Default;
				MessageBox.Show("Erreur lors de la génération de la base de données :\r\n" + exc.ToString(), "Génération", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			Cursor.Current = Cursors.Default;
			MessageBox.Show("Génération de la base de données terminée.", "Génération", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void uiPersonnes_Click(object sender, EventArgs e)
		{
			NettoyerPanels();
			if (_ucPersonnes == null || _ucPersonnes.IsDisposed)
			{
				_ucPersonnes = new UCPersonnes();
				_ucPersonnes.Dock = DockStyle.Fill;
				uiPanelMain.Controls.Add(_ucPersonnes);
			}
		}

		private void uiReunions_Click(object sender, EventArgs e)
		{
			NettoyerPanels();
			if (_ucReunions == null || _ucPersonnes.IsDisposed)
			{
				_ucReunions = new UCReunions();
				_ucReunions.Dock = DockStyle.Fill;
				uiPanelMain.Controls.Add(_ucReunions);
			}
		}
		#endregion
	}
}
