namespace NantoSoft.SalesManagement
{
	partial class UCPersonnes
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
			this.uiPanelListe = new System.Windows.Forms.Panel();
			this.uiPersonnesDg = new System.Windows.Forms.DataGridView();
			this.uiPersonnesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.uiAnnuler = new System.Windows.Forms.Button();
			this.uiValider = new System.Windows.Forms.Button();
			this.uiInserer = new System.Windows.Forms.Button();
			this.uiSupprimer = new System.Windows.Forms.Button();
			this.idPersonneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dateNaissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telephoneDomicileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.telephoneMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.idAdresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.adresseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.uiPanelDetail.SuspendLayout();
			this.uiPanelListe.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.uiPersonnesDg)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.uiPersonnesBindingSource)).BeginInit();
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
			// uiPanelListe
			// 
			this.uiPanelListe.Controls.Add(this.uiPersonnesDg);
			this.uiPanelListe.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uiPanelListe.Location = new System.Drawing.Point(0, 0);
			this.uiPanelListe.Name = "uiPanelListe";
			this.uiPanelListe.Size = new System.Drawing.Size(1130, 370);
			this.uiPanelListe.TabIndex = 1;
			// 
			// uiPersonnesDg
			// 
			this.uiPersonnesDg.AutoGenerateColumns = false;
			this.uiPersonnesDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.uiPersonnesDg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.uiPersonnesDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.uiPersonnesDg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersonneDataGridViewTextBoxColumn,
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.dateNaissanceDataGridViewTextBoxColumn,
            this.telephoneDomicileDataGridViewTextBoxColumn,
            this.telephoneMobileDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.idAdresseDataGridViewTextBoxColumn,
            this.adresseDataGridViewTextBoxColumn});
			this.uiPersonnesDg.DataSource = this.uiPersonnesBindingSource;
			this.uiPersonnesDg.Dock = System.Windows.Forms.DockStyle.Fill;
			this.uiPersonnesDg.Location = new System.Drawing.Point(0, 0);
			this.uiPersonnesDg.Name = "uiPersonnesDg";
			this.uiPersonnesDg.RowTemplate.Height = 24;
			this.uiPersonnesDg.Size = new System.Drawing.Size(1130, 370);
			this.uiPersonnesDg.TabIndex = 0;
			// 
			// uiPersonnesBindingSource
			// 
			this.uiPersonnesBindingSource.DataSource = typeof(NantoSoft.SalesManagement.Metier.Personne);
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
			// uiInserer
			// 
			this.uiInserer.Location = new System.Drawing.Point(3, 305);
			this.uiInserer.Name = "uiInserer";
			this.uiInserer.Size = new System.Drawing.Size(124, 35);
			this.uiInserer.TabIndex = 2;
			this.uiInserer.Text = "Insérer";
			this.uiInserer.UseVisualStyleBackColor = true;
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
			// idPersonneDataGridViewTextBoxColumn
			// 
			this.idPersonneDataGridViewTextBoxColumn.DataPropertyName = "IdPersonne";
			this.idPersonneDataGridViewTextBoxColumn.HeaderText = "IdPersonne";
			this.idPersonneDataGridViewTextBoxColumn.Name = "idPersonneDataGridViewTextBoxColumn";
			this.idPersonneDataGridViewTextBoxColumn.Visible = false;
			// 
			// nomDataGridViewTextBoxColumn
			// 
			this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
			this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
			this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
			// 
			// prenomDataGridViewTextBoxColumn
			// 
			this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
			this.prenomDataGridViewTextBoxColumn.HeaderText = "Prénom";
			this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
			// 
			// dateNaissanceDataGridViewTextBoxColumn
			// 
			this.dateNaissanceDataGridViewTextBoxColumn.DataPropertyName = "DateNaissance";
			this.dateNaissanceDataGridViewTextBoxColumn.HeaderText = "Date de naissance";
			this.dateNaissanceDataGridViewTextBoxColumn.Name = "dateNaissanceDataGridViewTextBoxColumn";
			// 
			// telephoneDomicileDataGridViewTextBoxColumn
			// 
			this.telephoneDomicileDataGridViewTextBoxColumn.DataPropertyName = "TelephoneDomicile";
			this.telephoneDomicileDataGridViewTextBoxColumn.HeaderText = "Téléphone domicile";
			this.telephoneDomicileDataGridViewTextBoxColumn.Name = "telephoneDomicileDataGridViewTextBoxColumn";
			// 
			// telephoneMobileDataGridViewTextBoxColumn
			// 
			this.telephoneMobileDataGridViewTextBoxColumn.DataPropertyName = "TelephoneMobile";
			this.telephoneMobileDataGridViewTextBoxColumn.HeaderText = "Téléphone mobile";
			this.telephoneMobileDataGridViewTextBoxColumn.Name = "telephoneMobileDataGridViewTextBoxColumn";
			// 
			// emailDataGridViewTextBoxColumn
			// 
			this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
			this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
			this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
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
			// UCPersonnes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.uiPanelListe);
			this.Controls.Add(this.uiPanelDetail);
			this.Name = "UCPersonnes";
			this.Size = new System.Drawing.Size(1130, 713);
			this.Load += new System.EventHandler(this.UCPersonnes_Load);
			this.uiPanelDetail.ResumeLayout(false);
			this.uiPanelListe.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.uiPersonnesDg)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.uiPersonnesBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel uiPanelDetail;
		private System.Windows.Forms.Panel uiPanelListe;
		private System.Windows.Forms.DataGridView uiPersonnesDg;
		private System.Windows.Forms.BindingSource uiPersonnesBindingSource;
		private System.Windows.Forms.Button uiSupprimer;
		private System.Windows.Forms.Button uiInserer;
		private System.Windows.Forms.Button uiValider;
		private System.Windows.Forms.Button uiAnnuler;
		private System.Windows.Forms.DataGridViewTextBoxColumn idPersonneDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissanceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telephoneDomicileDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn telephoneMobileDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn idAdresseDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn adresseDataGridViewTextBoxColumn;
	}
}
