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
			this.uiTest = new System.Windows.Forms.Button();
			this.uiQuitter = new System.Windows.Forms.Button();
			this.uiMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.genererDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.uiPanelLeft = new System.Windows.Forms.Panel();
			this.uiReunions = new System.Windows.Forms.Button();
			this.uiPersonnes = new System.Windows.Forms.Button();
			this.uiSplitter = new System.Windows.Forms.Splitter();
			this.uiPanelMain = new System.Windows.Forms.Panel();
			this.uiPanelBoutons.SuspendLayout();
			this.uiMenuStrip.SuspendLayout();
			this.uiPanelLeft.SuspendLayout();
			this.SuspendLayout();
			// 
			// uiPanelBoutons
			// 
			this.uiPanelBoutons.Controls.Add(this.uiTest);
			this.uiPanelBoutons.Controls.Add(this.uiQuitter);
			this.uiPanelBoutons.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.uiPanelBoutons.Location = new System.Drawing.Point(0, 531);
			this.uiPanelBoutons.Margin = new System.Windows.Forms.Padding(2);
			this.uiPanelBoutons.Name = "uiPanelBoutons";
			this.uiPanelBoutons.Size = new System.Drawing.Size(891, 52);
			this.uiPanelBoutons.TabIndex = 0;
			// 
			// uiTest
			// 
			this.uiTest.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.uiTest.Location = new System.Drawing.Point(11, 9);
			this.uiTest.Margin = new System.Windows.Forms.Padding(2);
			this.uiTest.Name = "uiTest";
			this.uiTest.Size = new System.Drawing.Size(138, 32);
			this.uiTest.TabIndex = 2;
			this.uiTest.Text = "Tests";
			this.uiTest.UseVisualStyleBackColor = true;
			this.uiTest.Click += new System.EventHandler(this.uiTest_Click);
			// 
			// uiQuitter
			// 
			this.uiQuitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.uiQuitter.Location = new System.Drawing.Point(806, 10);
			this.uiQuitter.Margin = new System.Windows.Forms.Padding(2);
			this.uiQuitter.Name = "uiQuitter";
			this.uiQuitter.Size = new System.Drawing.Size(76, 32);
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
			this.uiMenuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
			this.uiMenuStrip.Size = new System.Drawing.Size(891, 24);
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
			this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
			this.fichierToolStripMenuItem.Text = "Fichier";
			// 
			// genererDBToolStripMenuItem
			// 
			this.genererDBToolStripMenuItem.Name = "genererDBToolStripMenuItem";
			this.genererDBToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.genererDBToolStripMenuItem.Text = "Générer DB";
			this.genererDBToolStripMenuItem.Click += new System.EventHandler(this.genererDBToolStripMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(130, 6);
			// 
			// quitterToolStripMenuItem
			// 
			this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
			this.quitterToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
			this.quitterToolStripMenuItem.Text = "Quitter";
			this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
			// 
			// uiPanelLeft
			// 
			this.uiPanelLeft.Controls.Add(this.uiReunions);
			this.uiPanelLeft.Controls.Add(this.uiPersonnes);
			this.uiPanelLeft.Dock = System.Windows.Forms.DockStyle.Left;
			this.uiPanelLeft.Location = new System.Drawing.Point(0, 24);
			this.uiPanelLeft.Margin = new System.Windows.Forms.Padding(2);
			this.uiPanelLeft.MinimumSize = new System.Drawing.Size(163, 507);
			this.uiPanelLeft.Name = "uiPanelLeft";
			this.uiPanelLeft.Size = new System.Drawing.Size(163, 507);
			this.uiPanelLeft.TabIndex = 2;
			// 
			// uiReunions
			// 
			this.uiReunions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uiReunions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.uiReunions.Location = new System.Drawing.Point(11, 77);
			this.uiReunions.Margin = new System.Windows.Forms.Padding(2);
			this.uiReunions.Name = "uiReunions";
			this.uiReunions.Size = new System.Drawing.Size(138, 32);
			this.uiReunions.TabIndex = 1;
			this.uiReunions.Text = "Réunions";
			this.uiReunions.UseVisualStyleBackColor = true;
			this.uiReunions.Click += new System.EventHandler(this.uiReunions_Click);
			// 
			// uiPersonnes
			// 
			this.uiPersonnes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.uiPersonnes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.uiPersonnes.Location = new System.Drawing.Point(11, 40);
			this.uiPersonnes.Margin = new System.Windows.Forms.Padding(2);
			this.uiPersonnes.Name = "uiPersonnes";
			this.uiPersonnes.Size = new System.Drawing.Size(138, 32);
			this.uiPersonnes.TabIndex = 0;
			this.uiPersonnes.Text = "Contacts";
			this.uiPersonnes.UseVisualStyleBackColor = true;
			this.uiPersonnes.Click += new System.EventHandler(this.uiPersonnes_Click);
			// 
			// uiSplitter
			// 
			this.uiSplitter.Location = new System.Drawing.Point(163, 24);
			this.uiSplitter.Name = "uiSplitter";
			this.uiSplitter.Size = new System.Drawing.Size(3, 507);
			this.uiSplitter.TabIndex = 3;
			this.uiSplitter.TabStop = false;
			// 
			// uiPanelMain
			// 
			this.uiPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uiPanelMain.Location = new System.Drawing.Point(166, 24);
			this.uiPanelMain.Margin = new System.Windows.Forms.Padding(2);
			this.uiPanelMain.Name = "uiPanelMain";
			this.uiPanelMain.Size = new System.Drawing.Size(725, 507);
			this.uiPanelMain.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(891, 583);
			this.Controls.Add(this.uiPanelMain);
			this.Controls.Add(this.uiSplitter);
			this.Controls.Add(this.uiPanelLeft);
			this.Controls.Add(this.uiPanelBoutons);
			this.Controls.Add(this.uiMenuStrip);
			this.MainMenuStrip = this.uiMenuStrip;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SalesManagement";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
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
		private System.Windows.Forms.Button uiPersonnes;
		private System.Windows.Forms.Button uiReunions;
		private System.Windows.Forms.Splitter uiSplitter;
		private System.Windows.Forms.Panel uiPanelMain;
		private System.Windows.Forms.Button uiTest;
	}
}

