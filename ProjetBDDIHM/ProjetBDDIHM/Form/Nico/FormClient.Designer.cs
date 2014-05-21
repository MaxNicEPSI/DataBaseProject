namespace ProjetBDDIHM
{
    partial class FormClient
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
            this.textBoxPrenomClient = new System.Windows.Forms.TextBox();
            this.textBoxNomClient = new System.Windows.Forms.TextBox();
            this.textBoxIdClient = new System.Windows.Forms.TextBox();
            this.cbCircuit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCircuitReservation = new System.Windows.Forms.TextBox();
            this.textBoxPlaceReservation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdReservation = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonFermer = new System.Windows.Forms.Button();
            this.buttonAjouterReservation = new System.Windows.Forms.Button();
            this.buttonAnnulerClient = new System.Windows.Forms.Button();
            this.buttonModifierClient = new System.Windows.Forms.Button();
            this.buttonAjouterClient = new System.Windows.Forms.Button();
            this.buttonValiderClient = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dateTimePickerReservation = new System.Windows.Forms.DateTimePicker();
            this.buttonSupprimerReservation = new System.Windows.Forms.Button();
            this.buttonAnnulerReservation = new System.Windows.Forms.Button();
            this.buttonModifierReservation = new System.Windows.Forms.Button();
            this.buttonValiderReservation = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cbEtape = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSupprimerClient = new System.Windows.Forms.Button();
            this.dateTimePickerClient = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxPrenomClient
            // 
            this.textBoxPrenomClient.Location = new System.Drawing.Point(85, 77);
            this.textBoxPrenomClient.Name = "textBoxPrenomClient";
            this.textBoxPrenomClient.ReadOnly = true;
            this.textBoxPrenomClient.Size = new System.Drawing.Size(181, 20);
            this.textBoxPrenomClient.TabIndex = 11;
            // 
            // textBoxNomClient
            // 
            this.textBoxNomClient.Location = new System.Drawing.Point(85, 51);
            this.textBoxNomClient.Name = "textBoxNomClient";
            this.textBoxNomClient.ReadOnly = true;
            this.textBoxNomClient.Size = new System.Drawing.Size(181, 20);
            this.textBoxNomClient.TabIndex = 10;
            // 
            // textBoxIdClient
            // 
            this.textBoxIdClient.Enabled = false;
            this.textBoxIdClient.Location = new System.Drawing.Point(85, 26);
            this.textBoxIdClient.Name = "textBoxIdClient";
            this.textBoxIdClient.ReadOnly = true;
            this.textBoxIdClient.Size = new System.Drawing.Size(181, 20);
            this.textBoxIdClient.TabIndex = 9;
            // 
            // cbCircuit
            // 
            this.cbCircuit.FormattingEnabled = true;
            this.cbCircuit.Location = new System.Drawing.Point(6, 19);
            this.cbCircuit.Name = "cbCircuit";
            this.cbCircuit.Size = new System.Drawing.Size(188, 21);
            this.cbCircuit.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prénom :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom :";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(6, 29);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(24, 13);
            this.labelNom.TabIndex = 0;
            this.labelNom.Text = "ID :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Id Circuit :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 86);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "Date réservation :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Place :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "ID :";
            // 
            // textBoxCircuitReservation
            // 
            this.textBoxCircuitReservation.Location = new System.Drawing.Point(80, 116);
            this.textBoxCircuitReservation.Name = "textBoxCircuitReservation";
            this.textBoxCircuitReservation.ReadOnly = true;
            this.textBoxCircuitReservation.Size = new System.Drawing.Size(186, 20);
            this.textBoxCircuitReservation.TabIndex = 3;
            // 
            // textBoxPlaceReservation
            // 
            this.textBoxPlaceReservation.Location = new System.Drawing.Point(80, 54);
            this.textBoxPlaceReservation.Name = "textBoxPlaceReservation";
            this.textBoxPlaceReservation.ReadOnly = true;
            this.textBoxPlaceReservation.Size = new System.Drawing.Size(186, 20);
            this.textBoxPlaceReservation.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Date de naissance :";
            // 
            // textBoxIdReservation
            // 
            this.textBoxIdReservation.Enabled = false;
            this.textBoxIdReservation.Location = new System.Drawing.Point(80, 23);
            this.textBoxIdReservation.Name = "textBoxIdReservation";
            this.textBoxIdReservation.ReadOnly = true;
            this.textBoxIdReservation.Size = new System.Drawing.Size(186, 20);
            this.textBoxIdReservation.TabIndex = 0;
            this.textBoxIdReservation.TextChanged += new System.EventHandler(this.textBoxIdReservation_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.buttonFermer);
            this.groupBox1.Controls.Add(this.buttonAjouterReservation);
            this.groupBox1.Controls.Add(this.buttonAnnulerClient);
            this.groupBox1.Controls.Add(this.buttonModifierClient);
            this.groupBox1.Controls.Add(this.buttonAjouterClient);
            this.groupBox1.Controls.Add(this.buttonValiderClient);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(959, 488);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clients / Réservations";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonFermer
            // 
            this.buttonFermer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.buttonFermer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFermer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFermer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFermer.Location = new System.Drawing.Point(795, 437);
            this.buttonFermer.Name = "buttonFermer";
            this.buttonFermer.Size = new System.Drawing.Size(107, 34);
            this.buttonFermer.TabIndex = 14;
            this.buttonFermer.Text = "Fermer";
            this.buttonFermer.UseVisualStyleBackColor = false;
            this.buttonFermer.Click += new System.EventHandler(this.buttonFermer_Click);
            // 
            // buttonAjouterReservation
            // 
            this.buttonAjouterReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.buttonAjouterReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAjouterReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterReservation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAjouterReservation.Location = new System.Drawing.Point(597, 38);
            this.buttonAjouterReservation.Name = "buttonAjouterReservation";
            this.buttonAjouterReservation.Size = new System.Drawing.Size(77, 31);
            this.buttonAjouterReservation.TabIndex = 8;
            this.buttonAjouterReservation.Text = "Ajouter";
            this.buttonAjouterReservation.UseVisualStyleBackColor = false;
            this.buttonAjouterReservation.Click += new System.EventHandler(this.buttonAjouterReservation_Click);
            // 
            // buttonAnnulerClient
            // 
            this.buttonAnnulerClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.buttonAnnulerClient.Enabled = false;
            this.buttonAnnulerClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnnulerClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnulerClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAnnulerClient.Location = new System.Drawing.Point(237, 284);
            this.buttonAnnulerClient.Name = "buttonAnnulerClient";
            this.buttonAnnulerClient.Size = new System.Drawing.Size(84, 34);
            this.buttonAnnulerClient.TabIndex = 7;
            this.buttonAnnulerClient.Text = "Annuler";
            this.buttonAnnulerClient.UseVisualStyleBackColor = false;
            this.buttonAnnulerClient.Click += new System.EventHandler(this.buttonAnnulerClient_Click);
            // 
            // buttonModifierClient
            // 
            this.buttonModifierClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.buttonModifierClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModifierClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonModifierClient.Location = new System.Drawing.Point(123, 284);
            this.buttonModifierClient.Name = "buttonModifierClient";
            this.buttonModifierClient.Size = new System.Drawing.Size(84, 34);
            this.buttonModifierClient.TabIndex = 6;
            this.buttonModifierClient.Text = "Modifier";
            this.buttonModifierClient.UseVisualStyleBackColor = false;
            this.buttonModifierClient.Click += new System.EventHandler(this.buttonModifierClient_Click);
            // 
            // buttonAjouterClient
            // 
            this.buttonAjouterClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.buttonAjouterClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAjouterClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAjouterClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAjouterClient.Location = new System.Drawing.Point(213, 38);
            this.buttonAjouterClient.Name = "buttonAjouterClient";
            this.buttonAjouterClient.Size = new System.Drawing.Size(77, 31);
            this.buttonAjouterClient.TabIndex = 5;
            this.buttonAjouterClient.Text = "Ajouter";
            this.buttonAjouterClient.UseVisualStyleBackColor = false;
            this.buttonAjouterClient.Click += new System.EventHandler(this.buttonAjouterClient_Click);
            // 
            // buttonValiderClient
            // 
            this.buttonValiderClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.buttonValiderClient.Enabled = false;
            this.buttonValiderClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonValiderClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValiderClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonValiderClient.Location = new System.Drawing.Point(13, 284);
            this.buttonValiderClient.Name = "buttonValiderClient";
            this.buttonValiderClient.Size = new System.Drawing.Size(84, 34);
            this.buttonValiderClient.TabIndex = 4;
            this.buttonValiderClient.Text = "Valider";
            this.buttonValiderClient.UseVisualStyleBackColor = false;
            this.buttonValiderClient.Click += new System.EventHandler(this.buttonValiderClient_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dateTimePickerReservation);
            this.groupBox5.Controls.Add(this.buttonSupprimerReservation);
            this.groupBox5.Controls.Add(this.buttonAnnulerReservation);
            this.groupBox5.Controls.Add(this.buttonModifierReservation);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.buttonValiderReservation);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.textBoxCircuitReservation);
            this.groupBox5.Controls.Add(this.textBoxPlaceReservation);
            this.groupBox5.Controls.Add(this.textBoxIdReservation);
            this.groupBox5.Location = new System.Drawing.Point(391, 103);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(359, 277);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "detail de l\'étape";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // dateTimePickerReservation
            // 
            this.dateTimePickerReservation.Enabled = false;
            this.dateTimePickerReservation.Location = new System.Drawing.Point(107, 86);
            this.dateTimePickerReservation.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerReservation.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerReservation.Name = "dateTimePickerReservation";
            this.dateTimePickerReservation.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReservation.TabIndex = 14;
            // 
            // buttonSupprimerReservation
            // 
            this.buttonSupprimerReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.buttonSupprimerReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSupprimerReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimerReservation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSupprimerReservation.Location = new System.Drawing.Point(107, 230);
            this.buttonSupprimerReservation.Name = "buttonSupprimerReservation";
            this.buttonSupprimerReservation.Size = new System.Drawing.Size(102, 34);
            this.buttonSupprimerReservation.TabIndex = 14;
            this.buttonSupprimerReservation.Text = "Supprimer";
            this.buttonSupprimerReservation.UseVisualStyleBackColor = false;
            this.buttonSupprimerReservation.Click += new System.EventHandler(this.buttonSupprimerReservation_Click);
            // 
            // buttonAnnulerReservation
            // 
            this.buttonAnnulerReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.buttonAnnulerReservation.Enabled = false;
            this.buttonAnnulerReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAnnulerReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAnnulerReservation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAnnulerReservation.Location = new System.Drawing.Point(231, 181);
            this.buttonAnnulerReservation.Name = "buttonAnnulerReservation";
            this.buttonAnnulerReservation.Size = new System.Drawing.Size(84, 34);
            this.buttonAnnulerReservation.TabIndex = 11;
            this.buttonAnnulerReservation.Text = "Annuler";
            this.buttonAnnulerReservation.UseVisualStyleBackColor = false;
            this.buttonAnnulerReservation.Click += new System.EventHandler(this.buttonAnnulerReservation_Click);
            // 
            // buttonModifierReservation
            // 
            this.buttonModifierReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.buttonModifierReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonModifierReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifierReservation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonModifierReservation.Location = new System.Drawing.Point(116, 181);
            this.buttonModifierReservation.Name = "buttonModifierReservation";
            this.buttonModifierReservation.Size = new System.Drawing.Size(84, 34);
            this.buttonModifierReservation.TabIndex = 10;
            this.buttonModifierReservation.Text = "Modifier";
            this.buttonModifierReservation.UseVisualStyleBackColor = false;
            this.buttonModifierReservation.Click += new System.EventHandler(this.buttonModifierReservation_Click);
            // 
            // buttonValiderReservation
            // 
            this.buttonValiderReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.buttonValiderReservation.Enabled = false;
            this.buttonValiderReservation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonValiderReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValiderReservation.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonValiderReservation.Location = new System.Drawing.Point(13, 181);
            this.buttonValiderReservation.Name = "buttonValiderReservation";
            this.buttonValiderReservation.Size = new System.Drawing.Size(84, 34);
            this.buttonValiderReservation.TabIndex = 9;
            this.buttonValiderReservation.Text = "Valider";
            this.buttonValiderReservation.UseVisualStyleBackColor = false;
            this.buttonValiderReservation.Click += new System.EventHandler(this.buttonValiderReservation_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbEtape);
            this.groupBox4.Location = new System.Drawing.Point(391, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 64);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Réservation";
            // 
            // cbEtape
            // 
            this.cbEtape.FormattingEnabled = true;
            this.cbEtape.Location = new System.Drawing.Point(7, 18);
            this.cbEtape.Name = "cbEtape";
            this.cbEtape.Size = new System.Drawing.Size(187, 21);
            this.cbEtape.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSupprimerClient);
            this.groupBox3.Controls.Add(this.dateTimePickerClient);
            this.groupBox3.Controls.Add(this.textBoxPrenomClient);
            this.groupBox3.Controls.Add(this.textBoxNomClient);
            this.groupBox3.Controls.Add(this.textBoxIdClient);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.labelNom);
            this.groupBox3.Location = new System.Drawing.Point(7, 103);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(326, 277);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Détail du client";
            // 
            // buttonSupprimerClient
            // 
            this.buttonSupprimerClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.buttonSupprimerClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSupprimerClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSupprimerClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonSupprimerClient.Location = new System.Drawing.Point(103, 224);
            this.buttonSupprimerClient.Name = "buttonSupprimerClient";
            this.buttonSupprimerClient.Size = new System.Drawing.Size(107, 34);
            this.buttonSupprimerClient.TabIndex = 9;
            this.buttonSupprimerClient.Text = "Supprimer";
            this.buttonSupprimerClient.UseVisualStyleBackColor = false;
            this.buttonSupprimerClient.Click += new System.EventHandler(this.buttonSupprimerClient_Click);
            // 
            // dateTimePickerClient
            // 
            this.dateTimePickerClient.Enabled = false;
            this.dateTimePickerClient.Location = new System.Drawing.Point(114, 110);
            this.dateTimePickerClient.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerClient.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerClient.Name = "dateTimePickerClient";
            this.dateTimePickerClient.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerClient.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCircuit);
            this.groupBox2.Location = new System.Drawing.Point(7, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 64);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 510);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormClient";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxPrenomClient;
        private System.Windows.Forms.TextBox textBoxNomClient;
        private System.Windows.Forms.TextBox textBoxIdClient;
        private System.Windows.Forms.ComboBox cbCircuit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxCircuitReservation;
        private System.Windows.Forms.TextBox textBoxPlaceReservation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIdReservation;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cbEtape;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePickerClient;
        private System.Windows.Forms.Button buttonAjouterReservation;
        private System.Windows.Forms.Button buttonAnnulerClient;
        private System.Windows.Forms.Button buttonModifierClient;
        private System.Windows.Forms.Button buttonAjouterClient;
        private System.Windows.Forms.Button buttonValiderClient;
        private System.Windows.Forms.Button buttonSupprimerReservation;
        private System.Windows.Forms.Button buttonAnnulerReservation;
        private System.Windows.Forms.Button buttonModifierReservation;
        private System.Windows.Forms.Button buttonValiderReservation;
        private System.Windows.Forms.Button buttonSupprimerClient;
        private System.Windows.Forms.DateTimePicker dateTimePickerReservation;
        private System.Windows.Forms.Button buttonFermer;
    }
}