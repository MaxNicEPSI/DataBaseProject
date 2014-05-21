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
    public partial class FenetreConnexion : Form
    {
        public FenetreConnexion()
        {
            InitializeComponent();
        }

        private void BoutonInscription_Click(object sender, EventArgs e)
        {
                FenetreInscription fenetreInscription = new FenetreInscription();
                fenetreInscription.ShowDialog();
        }

        private void BoutonConnecter_Click(object sender, EventArgs e)
        {
            
        }
    }
}
