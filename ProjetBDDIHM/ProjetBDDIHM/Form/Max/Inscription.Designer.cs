namespace ProjetBDDIHM
{
    partial class FenetreInscription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelMdp = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelIdentifiant = new System.Windows.Forms.Label();
            this.BoutonInscription = new System.Windows.Forms.Button();
            this.LabelInscription = new System.Windows.Forms.Label();
            this.IdentifiantConnexion = new System.Windows.Forms.TextBox();
            this.labelNom = new System.Windows.Forms.Label();
            this.MotDePasseConnexion = new System.Windows.Forms.TextBox();
            this.labelPrenom = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.labelMdp);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.labelIdentifiant);
            this.panel1.Controls.Add(this.BoutonInscription);
            this.panel1.Controls.Add(this.LabelInscription);
            this.panel1.Controls.Add(this.IdentifiantConnexion);
            this.panel1.Controls.Add(this.labelNom);
            this.panel1.Controls.Add(this.MotDePasseConnexion);
            this.panel1.Controls.Add(this.labelPrenom);
            this.panel1.Location = new System.Drawing.Point(32, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 302);
            this.panel1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 212);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 20);
            this.textBox2.TabIndex = 10;
            // 
            // labelMdp
            // 
            this.labelMdp.AutoSize = true;
            this.labelMdp.Location = new System.Drawing.Point(10, 193);
            this.labelMdp.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelMdp.Name = "labelMdp";
            this.labelMdp.Size = new System.Drawing.Size(71, 13);
            this.labelMdp.TabIndex = 9;
            this.labelMdp.Text = "Mot de passe";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(11, 168);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 20);
            this.textBox1.TabIndex = 8;
            // 
            // labelIdentifiant
            // 
            this.labelIdentifiant.AutoSize = true;
            this.labelIdentifiant.Location = new System.Drawing.Point(8, 149);
            this.labelIdentifiant.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelIdentifiant.Name = "labelIdentifiant";
            this.labelIdentifiant.Size = new System.Drawing.Size(53, 13);
            this.labelIdentifiant.TabIndex = 7;
            this.labelIdentifiant.Text = "Identifiant";
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
            this.BoutonInscription.Text = "S\'incrire ";
            this.BoutonInscription.UseVisualStyleBackColor = false;
            this.BoutonInscription.Click += new System.EventHandler(this.BoutonInscription_Click);
            // 
            // LabelInscription
            // 
            this.LabelInscription.AutoSize = true;
            this.LabelInscription.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInscription.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.LabelInscription.Location = new System.Drawing.Point(11, 11);
            this.LabelInscription.Name = "LabelInscription";
            this.LabelInscription.Size = new System.Drawing.Size(121, 29);
            this.LabelInscription.TabIndex = 5;
            this.LabelInscription.Text = "Inscription";
            // 
            // IdentifiantConnexion
            // 
            this.IdentifiantConnexion.Location = new System.Drawing.Point(11, 80);
            this.IdentifiantConnexion.Margin = new System.Windows.Forms.Padding(6);
            this.IdentifiantConnexion.Name = "IdentifiantConnexion";
            this.IdentifiantConnexion.Size = new System.Drawing.Size(212, 20);
            this.IdentifiantConnexion.TabIndex = 1;
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(8, 61);
            this.labelNom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "Nom";
            // 
            // MotDePasseConnexion
            // 
            this.MotDePasseConnexion.Location = new System.Drawing.Point(11, 125);
            this.MotDePasseConnexion.Margin = new System.Windows.Forms.Padding(6);
            this.MotDePasseConnexion.Name = "MotDePasseConnexion";
            this.MotDePasseConnexion.Size = new System.Drawing.Size(212, 20);
            this.MotDePasseConnexion.TabIndex = 3;
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(8, 106);
            this.labelPrenom.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 2;
            this.labelPrenom.Text = "Prénom";
            // 
            // FenetreInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 326);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FenetreInscription";
            this.Text = "Inscription";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BoutonInscription;
        private System.Windows.Forms.Label LabelInscription;
        private System.Windows.Forms.TextBox IdentifiantConnexion;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.TextBox MotDePasseConnexion;
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label labelMdp;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelIdentifiant;
    }
}