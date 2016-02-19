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
			foreach (Control ctrl in uiPanelMain.Controls)
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

		private void MainForm_Load(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			//Première initialisation pour rapidité EF dans l'application
			using (SalesManagementContext smContext = new SalesManagementContext())
			{
				var personne = smContext.Personne.FirstOrDefault(p => p.Nom != string.Empty);
			}
			Cursor.Current = Cursors.Default;
		}
		#endregion

		private void uiTest_Click(object sender, EventArgs e)
		{
			//using (SalesManagementContext context = new SalesManagementContext())
			//{
			//	for (int i = 0; i < 5; i++)
			//	{
			//		Commune com = new Commune()
			//		{
			//			CodePostal = "6922" + i.ToString(),
			//			Libelle = "BELLEVILLLE" + i.ToString()
			//		};

			//		Adresse adr = new Adresse()
			//		{
			//			Voie = "7 rue de la gare" + i.ToString(),
			//			Commune = com
			//		};

			//		Personne pers = new Personne()
			//		{
			//			Nom = "Manaranche" + i.ToString(),
			//			Prenom = "Willy" + i.ToString(),
			//			DateNaissance = new DateTime(1976, 12, 18),
			//			Email = "nanto45@yahoo.fr" + i.ToString(),
			//			TelephoneDomicile = "04.74.66.43.6" + i.ToString(),
			//			TelephoneMobile = "06.77.13.6" + i.ToString(),
			//			Adresse = adr
			//		};

			//		context.Personne.Add(pers);

			//		ReunionMetier reu = new ReunionMetier()
			//		{
			//			Date = DateTime.Now,
			//			Note = i.ToString(),
			//			Adresse = adr
			//		};

			//		reu.AjouterParticipant(pers, true);
			//		reu.AjouterAuContext(context);

			//	}

			//	context.SaveChanges();


			//	Personne pers2 = context.Personne.FirstOrDefault(p => p.Nom == "Manaranche0");
			//	Reunion reu2 = context.Reunion.FirstOrDefault();
			//	Famille fa = new Famille() { IdFamille = 1, Libelle = "Famille 1" };

			//	VenteMetier vente = new VenteMetier() { Personne = pers2, Reunion = reu2 };
			//	Dictionary<Article, decimal> liste = new Dictionary<Article, decimal>();
			//	for (int i = 0; i < 5; i++)
			//	{
			//		Article art = new Article()
			//		{
			//			Libelle = "Article" + i.ToString(),
			//			PrixVente = 5m,
			//			Famille = fa
			//		};

			//		liste.Add(art, 5 + i);
			//	}
			//	vente.AjouterArticles(liste);
			//	vente.AjouterAuContext(context);

			//	context.SaveChanges();
			//}
		}
	}
}
