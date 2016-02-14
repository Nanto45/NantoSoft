namespace NantoSoft.SalesManagement
{
	partial class MainForm
	{
		/// <summary>
		/// Variable nécessaire au concepteur.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Nettoyage des ressources utilisées.
		/// </summary>
		/// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Code généré par le Concepteur Windows Form

		/// <summary>
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.uiPanelBoutons = new System.Windows.Forms.Panel();
			this.uiQuitter = new System.Windows.Forms.Button();
			this.uiMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.genererDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uiPanelLeft = new System.Windows.Forms.Panel();
			this.uiPanelMain = new System.Windows.Forms.Panel();
			this.uiPersonnes = new System.Windows.Forms.Button();
			this.uiReunions = new System.Windows.Forms.Button();
			this.uiPanelBoutons.SuspendLayout();
			this.uiMenuStrip.SuspendLayout();
			this.uiPanelLeft.SuspendLayout();
			this.SuspendLayout();
			// 
			// uiPanelBoutons
			// 
			this.uiPanelBoutons.Controls.Add(this.uiQuitter);
			this.uiPanelBoutons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.uiPanelBoutons.Location = new System.Drawing.Point(0, 654);
			this.uiPanelBoutons.Name = "uiPanelBoutons";
			this.uiPanelBoutons.Size = new System.Drawing.Size(1188, 64);
			this.uiPanelBoutons.TabIndex = 0;
			// 
			// uiQuitter
			// 
			this.uiQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.uiQuitter.Location = new System.Drawing.Point(1075, 12);
			this.uiQuitter.Name = "uiQuitter";
			this.uiQuitter.Size = new System.Drawing.Size(101, 40);
			this.uiQuitter.TabIndex = 0;
			this.uiQuitter.Text = "Quitter";
			this.uiQuitter.UseVisualStyleBackColor = true;
			this.uiQuitter.Click += new System.EventHandler(this.uiQuitter_Click);
			// 
			// uiMenuStrip
			// 
			this.uiMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.uiMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem});
			this.uiMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.uiMenuStrip.Name = "uiMenuStrip";
			this.uiMenuStrip.Size = new System.Drawing.Size(1188, 28);
			this.uiMenuStrip.TabIndex = 1;
			this.uiMenuStrip.Text = "menuStrip1";
			// 
			// fichierToolStripMenuItem
			// 
			this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genererDBToolStripMenuItem,
            this.toolStripSeparator1,
            this.quitterToolStripMenuItem});
			this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
			this.fichierToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
			this.fichierToolStripMenuItem.Text = "Fichier";
			// 
			// quitterToolStripMenuItem
			// 
			this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
			this.quitterToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.quitterToolStripMenuItem.Text = "Quitter";
			this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
			// 
			// genererDBToolStripMenuItem
			// 
			this.genererDBToolStripMenuItem.Name = "genererDBToolStripMenuItem";
			this.genererDBToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
			this.genererDBToolStripMenuItem.Text = "Générer DB";
			this.genererDBToolStripMenuItem.Click += new System.EventHandler(this.genererDBToolStripMenuItem_Click);
			// 
			// uiPanelLeft
			// 
			this.uiPanelLeft.Controls.Add(this.uiReunions);
			this.uiPanelLeft.Controls.Add(this.uiPersonnes);
			this.uiPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.uiPanelLeft.Location = new System.Drawing.Point(0, 28);
			this.uiPanelLeft.Name = "uiPanelLeft";
			this.uiPanelLeft.Size = new System.Drawing.Size(277, 626);
			this.uiPanelLeft.TabIndex = 2;
			// 
			// uiPanelMain
			// 
			this.uiPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uiPanelMain.Location = new System.Drawing.Point(277, 28);
			this.uiPanelMain.Name = "uiPanelMain";
			this.uiPanelMain.Size = new System.Drawing.Size(911, 626);
			this.uiPanelMain.TabIndex = 3;
			// 
			// uiPersonnes
			// 
			this.uiPersonnes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.uiPersonnes.Location = new System.Drawing.Point(53, 64);
			this.uiPersonnes.Name = "uiPersonnes";
			this.uiPersonnes.Size = new System.Drawing.Size(184, 39);
			this.uiPersonnes.TabIndex = 0;
			this.uiPersonnes.Text = "Contacts";
			this.uiPersonnes.UseVisualStyleBackColor = true;
			this.uiPersonnes.Click += new System.EventHandler(this.uiPersonnes_Click);
			// 
			// uiReunions
			// 
			this.uiReunions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.uiReunions.Location = new System.Drawing.Point(53, 109);
			this.uiReunions.Name = "uiReunions";
			this.uiReunions.Size = new System.Drawing.Size(184, 39);
			this.uiReunions.TabIndex = 1;
			this.uiReunions.Text = "Réunions";
			this.uiReunions.UseVisualStyleBackColor = true;
			this.uiReunions.Click += new System.EventHandler(this.uiReunions_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1188, 718);
			this.Controls.Add(this.uiPanelMain);
			this.Controls.Add(this.uiPanelLeft);
			this.Controls.Add(this.uiPanelBoutons);
			this.Controls.Add(this.uiMenuStrip);
			this.MainMenuStrip = this.uiMenuStrip;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SalesManagement";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.uiPanelBoutons.ResumeLayout(false);
			this.uiMenuStrip.ResumeLayout(false);
			this.uiMenuStrip.PerformLayout();
			this.uiPanelLeft.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel uiPanelBoutons;
		private System.Windows.Forms.Button uiQuitter;
		private System.Windows.Forms.MenuStrip uiMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem genererDBToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.Panel uiPanelLeft;
		private System.Windows.Forms.Panel uiPanelMain;
		private System.Windows.Forms.Button uiPersonnes;
		private System.Windows.Forms.Button uiReunions;
	}
}

