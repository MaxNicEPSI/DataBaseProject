using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBDDIHM
{
    public partial class ProgrameCircuitTouristique : Form
    {

        
        public ProgrameCircuitTouristique(string nom, string prenom,string mdp, string type)
        {
            InitializeComponent();
            buttonClient.BackColor = System.Drawing.Color.FromArgb(255, 166, 80);
            labelId.Text="Id : "+prenom + " " + nom;
            labelCompte.Text = "Compte : " + type;
            
        }

        private void label_Click_Deconnexion(object sender, EventArgs e)
        {
            MessageBox.Show("TO DO : Fermer le fils et réappeler le parent (Fenêtre authentification)");
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            labelDeconnexion.ForeColor = System.Drawing.Color.Red;
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            labelDeconnexion.ForeColor = System.Drawing.Color.DarkRed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //buttonClient.BackColor = System.Drawing.Color.FromArgb(255, 166, 80);
            FormClient form = new FormClient();
            form.ShowDialog();
            
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'dataSet1.CLIENT'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.cLIENTTableAdapter.Fill(this.dataSet1.CLIENT);


        }





        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Voulez vous quitter l'application ?", "Quitter l'application", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit(); // kill l'application
            }
        }

        
    }
}
