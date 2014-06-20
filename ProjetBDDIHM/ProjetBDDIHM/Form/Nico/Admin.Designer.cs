namespace ProjetBDDIHM
{
    partial class Admin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDeconnexion = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.labelCompte = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonCircuit = new System.Windows.Forms.Button();
            this.cLIENTBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new ProjetBDDIHM.DataSet1();
            this.cLIENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cLIENTTableAdapter = new ProjetBDDIHM.DataSet1TableAdapters.CLIENTTableAdapter();
            this.dataSet11 = new ProjetBDDIHM.DataSet1();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelDeconnexion);
            this.panel1.Controls.Add(this.labelId);
            this.panel1.Controls.Add(this.labelCompte);
            this.panel1.Location = new System.Drawing.Point(12, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1031, 44);
            this.panel1.TabIndex = 0;
            // 
            // labelDeconnexion
            // 
            this.labelDeconnexion.AutoSize = true;
            this.labelDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeconnexion.ForeColor = System.Drawing.Color.Red;
            this.labelDeconnexion.Location = new System.Drawing.Point(961, 0);
            this.labelDeconnexion.Name = "labelDeconnexion";
            this.labelDeconnexion.Size = new System.Drawing.Size(70, 13);
            this.labelDeconnexion.TabIndex = 2;
            this.labelDeconnexion.Text = "Deconnexion";
            this.labelDeconnexion.Click += new System.EventHandler(this.label_Click_Deconnexion);
            this.labelDeconnexion.MouseLeave += new System.EventHandler(this.label3_MouseLeave);
            this.labelDeconnexion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label3_MouseMove);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.BackColor = System.Drawing.SystemColors.Control;
            this.labelId.Location = new System.Drawing.Point(772, 0);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(22, 13);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Id: ";
            // 
            // labelCompte
            // 
            this.labelCompte.AutoSize = true;
            this.labelCompte.Location = new System.Drawing.Point(3, 14);
            this.labelCompte.Name = "labelCompte";
            this.labelCompte.Size = new System.Drawing.Size(49, 13);
            this.labelCompte.TabIndex = 0;
            this.labelCompte.Text = "Compte: ";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel2.Controls.Add(this.buttonClient);
            this.panel2.Controls.Add(this.buttonCircuit);
            this.panel2.Location = new System.Drawing.Point(18, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1025, 466);
            this.panel2.TabIndex = 1;
            // 
            // buttonClient
            // 
            this.buttonClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.buttonClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClient.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonClient.Location = new System.Drawing.Point(117, 203);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(204, 41);
            this.buttonClient.TabIndex = 0;
            this.buttonClient.Text = "Client/Réservation";
            this.buttonClient.UseVisualStyleBackColor = false;
            this.buttonClient.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonCircuit
            // 
            this.buttonCircuit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(126)))), ((int)(((byte)(0)))));
            this.buttonCircuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCircuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCircuit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonCircuit.Location = new System.Drawing.Point(688, 203);
            this.buttonCircuit.Name = "buttonCircuit";
            this.buttonCircuit.Size = new System.Drawing.Size(219, 41);
            this.buttonCircuit.TabIndex = 2;
            this.buttonCircuit.Text = "Circuit/Étapes/Lieux";
            this.buttonCircuit.UseVisualStyleBackColor = false;
            this.buttonCircuit.Click += new System.EventHandler(this.buttonCircuit_Click);
            // 
            // cLIENTBindingSource1
            // 
            this.cLIENTBindingSource1.DataMember = "CLIENT";
            this.cLIENTBindingSource1.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLIENTBindingSource
            // 
            this.cLIENTBindingSource.DataMember = "CLIENT";
            this.cLIENTBindingSource.DataSource = this.dataSet1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cLIENTTableAdapter
            // 
            this.cLIENTTableAdapter.ClearBeforeFill = true;
            // 
            // dataSet11
            // 
            this.dataSet11.DataSetName = "DataSet1";
            this.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 580);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelDeconnexion;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelCompte;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonCircuit;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource cLIENTBindingSource;
        private DataSet1TableAdapters.CLIENTTableAdapter cLIENTTableAdapter;
        private DataSet1 dataSet11;
        private System.Windows.Forms.BindingSource cLIENTBindingSource1;
    }
}