namespace ProjetBDDIHM
{
    partial class Connexion
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BoutonInscription = new System.Windows.Forms.Button();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.BoutonConnecter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxMdp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 136);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mot de passe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(11, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Connexion";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.BoutonInscription);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TextBoxId);
            this.panel1.Controls.Add(this.BoutonConnecter);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TextBoxMdp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(25, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 302);
            this.panel1.TabIndex = 5;
            // 
            // BoutonInscription
            // 
            this.BoutonInscription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BoutonInscription.FlatAppearance.BorderSize = 0;
            this.BoutonInscription.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoutonInscription.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BoutonInscription.Location = new System.Drawing.Point(11, 257);
            this.BoutonInscription.Name = "BoutonInscription";
            this.BoutonInscription.Size = new System.Drawing.Size(212, 38);
            this.BoutonInscription.TabIndex = 6;
            this.BoutonInscription.Text = "S\'incrire !?";
            this.BoutonInscription.UseVisualStyleBackColor = false;
            this.BoutonInscription.Click += new System.EventHandler(this.BoutonInscription_Click_1);
            // 
            // TextBoxId
            // 
            this.TextBoxId.Location = new System.Drawing.Point(11, 93);
            this.TextBoxId.Margin = new System.Windows.Forms.Padding(6);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(212, 37);
            this.TextBoxId.TabIndex = 1;
            // 
            // BoutonConnecter
            // 
            this.BoutonConnecter.BackColor = System.Drawing.Color.RoyalBlue;
            this.BoutonConnecter.Location = new System.Drawing.Point(11, 217);
            this.BoutonConnecter.Name = "BoutonConnecter";
            this.BoutonConnecter.Size = new System.Drawing.Size(212, 38);
            this.BoutonConnecter.TabIndex = 4;
            this.BoutonConnecter.Text = "Se connecter";
            this.BoutonConnecter.UseVisualStyleBackColor = false;
            this.BoutonConnecter.Click += new System.EventHandler(this.BoutonConnecter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant";
            // 
            // TextBoxMdp
            // 
            this.TextBoxMdp.Location = new System.Drawing.Point(11, 171);
            this.TextBoxMdp.Margin = new System.Windows.Forms.Padding(6);
            this.TextBoxMdp.Name = "TextBoxMdp";
            this.TextBoxMdp.Size = new System.Drawing.Size(212, 37);
            this.TextBoxMdp.TabIndex = 3;
            // 
            // Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(300, 400);
            this.MinimumSize = new System.Drawing.Size(300, 400);
            this.Name = "Connexion";
            this.Text = "Connexion";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BoutonInscription;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.Button BoutonConnecter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxMdp;



    }
}

