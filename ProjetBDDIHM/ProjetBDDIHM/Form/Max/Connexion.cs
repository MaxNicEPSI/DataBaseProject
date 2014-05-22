using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBDDIHM
{
    [System.Runtime.InteropServices.GuidAttribute("97549539-9563-4E59-A006-456BD78D6BC0")]
    public partial class FenetreConnexion : Form
    {
        public FenetreConnexion()
        {
            InitializeComponent();
        }

        private void BoutonConnecter_Click_1(object sender, EventArgs e)
        {
            ProjetBDDIHM.FenetreGestionCircuit fenetregestioncircuit = new FenetreGestionCircuit();
            fenetregestioncircuit.Show();
        }

        private void BoutonInscription_Click_1(object sender, EventArgs e)
        {
            FenetreInscription fenetreInscription = new FenetreInscription();
            fenetreInscription.ShowDialog();
        }
    }
}
