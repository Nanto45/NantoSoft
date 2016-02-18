namespace NantoSoft.SalesManagement
{
	partial class UCReunions
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

		#region Code généré par le Concepteur de composants

		/// <summary> 
		/// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
		/// le contenu de cette méthode avec l'éditeur de code.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.uiPanelDetail = new System.Windows.Forms.Panel();
			this.uiSupprimer = new System.Windows.Forms.Button();
			this.uiInserer = new System.Windows.Forms.Button();
			this.uiValider = new System.Windows.Forms.Button();
			this.uiAnnuler = new System.Windows.Forms.Button();
			this.uiReunionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.uiSplitter = new System.Windows.Forms.Splitter();
			this.uiPanelListe = new System.Windows.Forms.Panel();
			this.uiReunionsDg = new System.Windows.Forms.DataGridView();
			this.idAdresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uiPanelDetail.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiReunionsBindingSource)).BeginInit();
			this.uiPanelListe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiReunionsDg)).BeginInit();
			this.SuspendLayout();
			// 
			// uiPanelDetail
			// 
			this.uiPanelDetail.Controls.Add(this.uiSupprimer);
			this.uiPanelDetail.Controls.Add(this.uiInserer);
			this.uiPanelDetail.Controls.Add(this.uiValider);
			this.uiPanelDetail.Controls.Add(this.uiAnnuler);
			this.uiPanelDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.uiPanelDetail.Location = new System.Drawing.Point(0, 300);
			this.uiPanelDetail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.uiPanelDetail.Name = "uiPanelDetail";
			this.uiPanelDetail.Size = new System.Drawing.Size(848, 279);
			this.uiPanelDetail.TabIndex = 0;
			// 
			// uiSupprimer
			// 
			this.uiSupprimer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.uiSupprimer.Location = new System.Drawing.Point(100, 248);
			this.uiSupprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.uiSupprimer.Name = "uiSupprimer";
			this.uiSupprimer.Size = new System.Drawing.Size(93, 28);
			this.uiSupprimer.TabIndex = 3;
			this.uiSupprimer.Text = "Supprimer";
			this.uiSupprimer.UseVisualStyleBackColor = true;
			// 
			// uiInserer
			// 
			this.uiInserer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.uiInserer.Location = new System.Drawing.Point(2, 248);
			this.uiInserer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.uiInserer.Name = "uiInserer";
			this.uiInserer.Size = new System.Drawing.Size(93, 28);
			this.uiInserer.TabIndex = 2;
			this.uiInserer.Text = "Insérer";
			this.uiInserer.UseVisualStyleBackColor = true;
			// 
			// uiValider
			// 
			this.uiValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.uiValider.Location = new System.Drawing.Point(655, 248);
			this.uiValider.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.uiValider.Name = "uiValider";
			this.uiValider.Size = new System.Drawing.Size(93, 28);
			this.uiValider.TabIndex = 1;
			this.uiValider.Text = "Valider";
			this.uiValider.UseVisualStyleBackColor = true;
			// 
			// uiAnnuler
			// 
			this.uiAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.uiAnnuler.Location = new System.Drawing.Point(752, 248);
			this.uiAnnuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.uiAnnuler.Name = "uiAnnuler";
			this.uiAnnuler.Size = new System.Drawing.Size(93, 28);
			this.uiAnnuler.TabIndex = 0;
			this.uiAnnuler.Text = "Annuler";
			this.uiAnnuler.UseVisualStyleBackColor = true;
			// 
			// uiReunionsBindingSource
			// 
			this.uiReunionsBindingSource.DataSource = typeof(NantoSoft.SalesManagement.DataBase.Reunion);
			// 
			// uiSplitter
			// 
			this.uiSplitter.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.uiSplitter.Cursor = System.Windows.Forms.Cursors.HSplit;
			this.uiSplitter.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.uiSplitter.Location = new System.Drawing.Point(0, 297);
			this.uiSplitter.Name = "uiSplitter";
			this.uiSplitter.Size = new System.Drawing.Size(848, 3);
			this.uiSplitter.TabIndex = 1;
			this.uiSplitter.TabStop = false;
			// 
			// uiPanelListe
			// 
			this.uiPanelListe.Controls.Add(this.uiReunionsDg);
			this.uiPanelListe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uiPanelListe.Location = new System.Drawing.Point(0, 0);
			this.uiPanelListe.Margin = new System.Windows.Forms.Padding(2);
			this.uiPanelListe.Name = "uiPanelListe";
			this.uiPanelListe.Padding = new System.Windows.Forms.Padding(3);
			this.uiPanelListe.Size = new System.Drawing.Size(848, 297);
			this.uiPanelListe.TabIndex = 2;
			// 
			// uiReunionsDg
			// 
			this.uiReunionsDg.AutoGenerateColumns = false;
			this.uiReunionsDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.uiReunionsDg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.uiReunionsDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.uiReunionsDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAdresseDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn});
			this.uiReunionsDg.DataSource = this.uiReunionsBindingSource;
			this.uiReunionsDg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uiReunionsDg.Location = new System.Drawing.Point(3, 3);
			this.uiReunionsDg.Margin = new System.Windows.Forms.Padding(2);
			this.uiReunionsDg.Name = "uiReunionsDg";
			this.uiReunionsDg.RowTemplate.Height = 24;
			this.uiReunionsDg.Size = new System.Drawing.Size(842, 291);
			this.uiReunionsDg.TabIndex = 0;
			// 
			// idAdresseDataGridViewTextBoxColumn
			// 
			this.idAdresseDataGridViewTextBoxColumn.DataPropertyName = "IdAdresse";
			this.idAdresseDataGridViewTextBoxColumn.HeaderText = "IdAdresse";
			this.idAdresseDataGridViewTextBoxColumn.Name = "idAdresseDataGridViewTextBoxColumn";
			this.idAdresseDataGridViewTextBoxColumn.Visible = false;
			// 
			// adresseDataGridViewTextBoxColumn
			// 
			this.adresseDataGridViewTextBoxColumn.DataPropertyName = "Adresse";
			this.adresseDataGridViewTextBoxColumn.HeaderText = "Adresse";
			this.adresseDataGridViewTextBoxColumn.Name = "adresseDataGridViewTextBoxColumn";
			// 
			// UCReunions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.uiPanelListe);
			this.Controls.Add(this.uiSplitter);
			this.Controls.Add(this.uiPanelDetail);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "UCReunions";
			this.Size = new System.Drawing.Size(848, 579);
			this.Load += new System.EventHandler(this.UCPersonnes_Load);
			this.uiPanelDetail.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uiReunionsBindingSource)).EndInit();
			this.uiPanelListe.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uiReunionsDg)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel uiPanelDetail;
		private System.Windows.Forms.BindingSource uiReunionsBindingSource;
		private System.Windows.Forms.Button uiSupprimer;
		private System.Windows.Forms.Button uiInserer;
		private System.Windows.Forms.Button uiValider;
		private System.Windows.Forms.Button uiAnnuler;
		private System.Windows.Forms.Splitter uiSplitter;
		private System.Windows.Forms.Panel uiPanelListe;
		private System.Windows.Forms.DataGridView uiReunionsDg;
		private System.Windows.Forms.DataGridViewTextBoxColumn idAdresseDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
	}
}
