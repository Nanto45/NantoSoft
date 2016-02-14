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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			this.uiPanelDetail = new System.Windows.Forms.Panel();
			this.uiSupprimer = new System.Windows.Forms.Button();
			this.uiInserer = new System.Windows.Forms.Button();
			this.uiValider = new System.Windows.Forms.Button();
			this.uiAnnuler = new System.Windows.Forms.Button();
			this.uiPanelListe = new System.Windows.Forms.Panel();
			this.uiReunionsDg = new System.Windows.Forms.DataGridView();
			this.idAdresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uiReunionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.uiPanelDetail.SuspendLayout();
			this.uiPanelListe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiReunionsDg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uiReunionsBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// uiPanelDetail
			// 
			this.uiPanelDetail.Controls.Add(this.uiSupprimer);
			this.uiPanelDetail.Controls.Add(this.uiInserer);
			this.uiPanelDetail.Controls.Add(this.uiValider);
			this.uiPanelDetail.Controls.Add(this.uiAnnuler);
			this.uiPanelDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.uiPanelDetail.Location = new System.Drawing.Point(0, 370);
			this.uiPanelDetail.Name = "uiPanelDetail";
			this.uiPanelDetail.Size = new System.Drawing.Size(1130, 343);
			this.uiPanelDetail.TabIndex = 0;
			// 
			// uiSupprimer
			// 
			this.uiSupprimer.Location = new System.Drawing.Point(133, 305);
			this.uiSupprimer.Name = "uiSupprimer";
			this.uiSupprimer.Size = new System.Drawing.Size(124, 35);
			this.uiSupprimer.TabIndex = 3;
			this.uiSupprimer.Text = "Supprimer";
			this.uiSupprimer.UseVisualStyleBackColor = true;
			// 
			// uiInserer
			// 
			this.uiInserer.Location = new System.Drawing.Point(3, 305);
			this.uiInserer.Name = "uiInserer";
			this.uiInserer.Size = new System.Drawing.Size(124, 35);
			this.uiInserer.TabIndex = 2;
			this.uiInserer.Text = "Insérer";
			this.uiInserer.UseVisualStyleBackColor = true;
			// 
			// uiValider
			// 
			this.uiValider.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.uiValider.Location = new System.Drawing.Point(873, 305);
			this.uiValider.Name = "uiValider";
			this.uiValider.Size = new System.Drawing.Size(124, 35);
			this.uiValider.TabIndex = 1;
			this.uiValider.Text = "Valider";
			this.uiValider.UseVisualStyleBackColor = true;
			// 
			// uiAnnuler
			// 
			this.uiAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.uiAnnuler.Location = new System.Drawing.Point(1003, 305);
			this.uiAnnuler.Name = "uiAnnuler";
			this.uiAnnuler.Size = new System.Drawing.Size(124, 35);
			this.uiAnnuler.TabIndex = 0;
			this.uiAnnuler.Text = "Annuler";
			this.uiAnnuler.UseVisualStyleBackColor = true;
			// 
			// uiPanelListe
			// 
			this.uiPanelListe.Controls.Add(this.uiReunionsDg);
			this.uiPanelListe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uiPanelListe.Location = new System.Drawing.Point(0, 0);
			this.uiPanelListe.Name = "uiPanelListe";
			this.uiPanelListe.Size = new System.Drawing.Size(1130, 370);
			this.uiPanelListe.TabIndex = 1;
			// 
			// uiReunionsDg
			// 
			this.uiReunionsDg.AutoGenerateColumns = false;
			this.uiReunionsDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.uiReunionsDg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.uiReunionsDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.uiReunionsDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAdresseDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn});
			this.uiReunionsDg.DataSource = this.uiReunionsBindingSource;
			this.uiReunionsDg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uiReunionsDg.Location = new System.Drawing.Point(0, 0);
			this.uiReunionsDg.Name = "uiReunionsDg";
			this.uiReunionsDg.RowTemplate.Height = 24;
			this.uiReunionsDg.Size = new System.Drawing.Size(1130, 370);
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
			// uiReunionsBindingSource
			// 
			this.uiReunionsBindingSource.DataSource = typeof(NantoSoft.SalesManagement.Metier.Reunion);
			// 
			// UCReunions
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.uiPanelListe);
			this.Controls.Add(this.uiPanelDetail);
			this.Name = "UCReunions";
			this.Size = new System.Drawing.Size(1130, 713);
			this.Load += new System.EventHandler(this.UCPersonnes_Load);
			this.uiPanelDetail.ResumeLayout(false);
			this.uiPanelListe.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uiReunionsDg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uiReunionsBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel uiPanelDetail;
		private System.Windows.Forms.Panel uiPanelListe;
		private System.Windows.Forms.DataGridView uiReunionsDg;
		private System.Windows.Forms.BindingSource uiReunionsBindingSource;
		private System.Windows.Forms.Button uiSupprimer;
		private System.Windows.Forms.Button uiInserer;
		private System.Windows.Forms.Button uiValider;
		private System.Windows.Forms.Button uiAnnuler;
		private System.Windows.Forms.DataGridViewTextBoxColumn idAdresseDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
	}
}
