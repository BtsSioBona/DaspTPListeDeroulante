namespace TPListeDeroulante
{
    partial class FrmListeSimple
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
            this.grpBoxSelection = new System.Windows.Forms.GroupBox();
            this.rdBtn3 = new System.Windows.Forms.RadioButton();
            this.rdBtn2 = new System.Windows.Forms.RadioButton();
            this.rdBtn1 = new System.Windows.Forms.RadioButton();
            this.chkLocked = new System.Windows.Forms.CheckBox();
            this.btnAffiche = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.txtSaisie = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.grpBoxSelection.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxSelection
            // 
            this.grpBoxSelection.Controls.Add(this.rdBtn3);
            this.grpBoxSelection.Controls.Add(this.rdBtn2);
            this.grpBoxSelection.Controls.Add(this.rdBtn1);
            this.grpBoxSelection.Location = new System.Drawing.Point(30, 39);
            this.grpBoxSelection.Name = "grpBoxSelection";
            this.grpBoxSelection.Size = new System.Drawing.Size(200, 100);
            this.grpBoxSelection.TabIndex = 0;
            this.grpBoxSelection.TabStop = false;
            this.grpBoxSelection.Text = "Type de sélection";
            // 
            // rdBtn3
            // 
            this.rdBtn3.AutoSize = true;
            this.rdBtn3.Location = new System.Drawing.Point(31, 72);
            this.rdBtn3.Name = "rdBtn3";
            this.rdBtn3.Size = new System.Drawing.Size(65, 17);
            this.rdBtn3.TabIndex = 2;
            this.rdBtn3.TabStop = true;
            this.rdBtn3.Text = "Étendue";
            this.rdBtn3.UseVisualStyleBackColor = true;
            this.rdBtn3.CheckedChanged += new System.EventHandler(this.rdBtn3_CheckedChanged);
            // 
            // rdBtn2
            // 
            this.rdBtn2.AutoSize = true;
            this.rdBtn2.Location = new System.Drawing.Point(31, 51);
            this.rdBtn2.Name = "rdBtn2";
            this.rdBtn2.Size = new System.Drawing.Size(61, 17);
            this.rdBtn2.TabIndex = 1;
            this.rdBtn2.TabStop = true;
            this.rdBtn2.Text = "Multiple";
            this.rdBtn2.UseVisualStyleBackColor = true;
            this.rdBtn2.CheckedChanged += new System.EventHandler(this.rdBtn2_CheckedChanged);
            // 
            // rdBtn1
            // 
            this.rdBtn1.AutoSize = true;
            this.rdBtn1.Location = new System.Drawing.Point(31, 29);
            this.rdBtn1.Name = "rdBtn1";
            this.rdBtn1.Size = new System.Drawing.Size(56, 17);
            this.rdBtn1.TabIndex = 0;
            this.rdBtn1.TabStop = true;
            this.rdBtn1.Text = "Simple";
            this.rdBtn1.UseVisualStyleBackColor = true;
            this.rdBtn1.CheckedChanged += new System.EventHandler(this.rdBtn1_CheckedChanged);
            // 
            // chkLocked
            // 
            this.chkLocked.AutoSize = true;
            this.chkLocked.Location = new System.Drawing.Point(61, 158);
            this.chkLocked.Name = "chkLocked";
            this.chkLocked.Size = new System.Drawing.Size(99, 17);
            this.chkLocked.TabIndex = 1;
            this.chkLocked.Text = "Liste vérrouillée";
            this.chkLocked.UseVisualStyleBackColor = true;
            this.chkLocked.CheckedChanged += new System.EventHandler(this.chkLocked_CheckedChanged);
            // 
            // btnAffiche
            // 
            this.btnAffiche.Location = new System.Drawing.Point(54, 224);
            this.btnAffiche.Name = "btnAffiche";
            this.btnAffiche.Size = new System.Drawing.Size(117, 23);
            this.btnAffiche.TabIndex = 2;
            this.btnAffiche.Text = "Afficher sélection";
            this.btnAffiche.UseVisualStyleBackColor = true;
            this.btnAffiche.Click += new System.EventHandler(this.btnAffiche_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(54, 267);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(117, 23);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer sélection";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // txtSaisie
            // 
            this.txtSaisie.Location = new System.Drawing.Point(294, 239);
            this.txtSaisie.Name = "txtSaisie";
            this.txtSaisie.Size = new System.Drawing.Size(266, 20);
            this.txtSaisie.TabIndex = 5;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(390, 283);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(294, 39);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(266, 186);
            this.lstItems.TabIndex = 7;
            // 
            // FrmListeSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 363);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtSaisie);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAffiche);
            this.Controls.Add(this.chkLocked);
            this.Controls.Add(this.grpBoxSelection);
            this.Name = "FrmListeSimple";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmListeSimple_Load);
            this.grpBoxSelection.ResumeLayout(false);
            this.grpBoxSelection.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxSelection;
        private System.Windows.Forms.RadioButton rdBtn3;
        private System.Windows.Forms.RadioButton rdBtn2;
        private System.Windows.Forms.RadioButton rdBtn1;
        private System.Windows.Forms.CheckBox chkLocked;
        private System.Windows.Forms.Button btnAffiche;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.TextBox txtSaisie;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ListBox lstItems;
    }
}

