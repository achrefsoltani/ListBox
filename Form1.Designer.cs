
namespace ListBox
{
    partial class Form1
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
            this.Saisie = new System.Windows.Forms.Label();
            this.txtSaisie = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.lb1 = new System.Windows.Forms.ListBox();
            this.lb2 = new System.Windows.Forms.ListBox();
            this.btnAjouterL2 = new System.Windows.Forms.Button();
            this.btnAjouterTL2 = new System.Windows.Forms.Button();
            this.btnAjouterL1 = new System.Windows.Forms.Button();
            this.btnAjouterTL1 = new System.Windows.Forms.Button();
            this.btnEffacerL1 = new System.Windows.Forms.Button();
            this.btnEffacerTL1 = new System.Windows.Forms.Button();
            this.btnEffacerL2 = new System.Windows.Forms.Button();
            this.btnEffacerTL2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Saisie
            // 
            this.Saisie.AutoSize = true;
            this.Saisie.Location = new System.Drawing.Point(160, 38);
            this.Saisie.Name = "Saisie";
            this.Saisie.Size = new System.Drawing.Size(35, 13);
            this.Saisie.TabIndex = 0;
            this.Saisie.Text = "Saisie";
            // 
            // txtSaisie
            // 
            this.txtSaisie.Location = new System.Drawing.Point(222, 38);
            this.txtSaisie.Name = "txtSaisie";
            this.txtSaisie.Size = new System.Drawing.Size(228, 20);
            this.txtSaisie.TabIndex = 1;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(511, 38);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // lb1
            // 
            this.lb1.FormattingEnabled = true;
            this.lb1.Location = new System.Drawing.Point(12, 92);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(271, 225);
            this.lb1.TabIndex = 3;
            // 
            // lb2
            // 
            this.lb2.FormattingEnabled = true;
            this.lb2.Location = new System.Drawing.Point(410, 92);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(271, 225);
            this.lb2.TabIndex = 4;
            // 
            // btnAjouterL2
            // 
            this.btnAjouterL2.Location = new System.Drawing.Point(310, 115);
            this.btnAjouterL2.Name = "btnAjouterL2";
            this.btnAjouterL2.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterL2.TabIndex = 5;
            this.btnAjouterL2.Text = "-->";
            this.btnAjouterL2.UseVisualStyleBackColor = true;
            this.btnAjouterL2.Click += new System.EventHandler(this.btnAjouterL2_Click);
            // 
            // btnAjouterTL2
            // 
            this.btnAjouterTL2.Location = new System.Drawing.Point(310, 168);
            this.btnAjouterTL2.Name = "btnAjouterTL2";
            this.btnAjouterTL2.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterTL2.TabIndex = 6;
            this.btnAjouterTL2.Text = ">>";
            this.btnAjouterTL2.UseVisualStyleBackColor = true;
            this.btnAjouterTL2.Click += new System.EventHandler(this.btnAjouterTL2_Click);
            // 
            // btnAjouterL1
            // 
            this.btnAjouterL1.Location = new System.Drawing.Point(310, 223);
            this.btnAjouterL1.Name = "btnAjouterL1";
            this.btnAjouterL1.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterL1.TabIndex = 7;
            this.btnAjouterL1.Text = "<--";
            this.btnAjouterL1.UseVisualStyleBackColor = true;
            this.btnAjouterL1.Click += new System.EventHandler(this.btnAjouterL1_Click);
            // 
            // btnAjouterTL1
            // 
            this.btnAjouterTL1.Location = new System.Drawing.Point(310, 274);
            this.btnAjouterTL1.Name = "btnAjouterTL1";
            this.btnAjouterTL1.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterTL1.TabIndex = 8;
            this.btnAjouterTL1.Text = "<<";
            this.btnAjouterTL1.UseVisualStyleBackColor = true;
            this.btnAjouterTL1.Click += new System.EventHandler(this.btnAjouterTL1_Click);
            // 
            // btnEffacerL1
            // 
            this.btnEffacerL1.Location = new System.Drawing.Point(28, 340);
            this.btnEffacerL1.Name = "btnEffacerL1";
            this.btnEffacerL1.Size = new System.Drawing.Size(101, 23);
            this.btnEffacerL1.TabIndex = 9;
            this.btnEffacerL1.Text = "Effacer";
            this.btnEffacerL1.UseVisualStyleBackColor = true;
            this.btnEffacerL1.Click += new System.EventHandler(this.btnEffacerL1_Click);
            // 
            // btnEffacerTL1
            // 
            this.btnEffacerTL1.Location = new System.Drawing.Point(154, 340);
            this.btnEffacerTL1.Name = "btnEffacerTL1";
            this.btnEffacerTL1.Size = new System.Drawing.Size(104, 23);
            this.btnEffacerTL1.TabIndex = 10;
            this.btnEffacerTL1.Text = "Tout Effacer";
            this.btnEffacerTL1.UseVisualStyleBackColor = true;
            this.btnEffacerTL1.Click += new System.EventHandler(this.btnEffacerTL1_Click);
            // 
            // btnEffacerL2
            // 
            this.btnEffacerL2.Location = new System.Drawing.Point(424, 340);
            this.btnEffacerL2.Name = "btnEffacerL2";
            this.btnEffacerL2.Size = new System.Drawing.Size(101, 23);
            this.btnEffacerL2.TabIndex = 11;
            this.btnEffacerL2.Text = "Effacer";
            this.btnEffacerL2.UseVisualStyleBackColor = true;
            this.btnEffacerL2.Click += new System.EventHandler(this.btnEffacerL2_Click);
            // 
            // btnEffacerTL2
            // 
            this.btnEffacerTL2.Location = new System.Drawing.Point(559, 340);
            this.btnEffacerTL2.Name = "btnEffacerTL2";
            this.btnEffacerTL2.Size = new System.Drawing.Size(98, 23);
            this.btnEffacerTL2.TabIndex = 12;
            this.btnEffacerTL2.Text = "Tout Effacer";
            this.btnEffacerTL2.UseVisualStyleBackColor = true;
            this.btnEffacerTL2.Click += new System.EventHandler(this.btnEffacerTL2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 383);
            this.Controls.Add(this.btnEffacerTL2);
            this.Controls.Add(this.btnEffacerL2);
            this.Controls.Add(this.btnEffacerTL1);
            this.Controls.Add(this.btnEffacerL1);
            this.Controls.Add(this.btnAjouterTL1);
            this.Controls.Add(this.btnAjouterL1);
            this.Controls.Add(this.btnAjouterTL2);
            this.Controls.Add(this.btnAjouterL2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtSaisie);
            this.Controls.Add(this.Saisie);
            this.Name = "Form1";
            this.Text = "Listes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Saisie;
        private System.Windows.Forms.TextBox txtSaisie;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.ListBox lb1;
        private System.Windows.Forms.ListBox lb2;
        private System.Windows.Forms.Button btnAjouterL2;
        private System.Windows.Forms.Button btnAjouterTL2;
        private System.Windows.Forms.Button btnAjouterL1;
        private System.Windows.Forms.Button btnAjouterTL1;
        private System.Windows.Forms.Button btnEffacerL1;
        private System.Windows.Forms.Button btnEffacerTL1;
        private System.Windows.Forms.Button btnEffacerL2;
        private System.Windows.Forms.Button btnEffacerTL2;
    }
}

