using ProjetBDDIHM.Classes.Nico;
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
    public partial class Connexion : Form
    {
        private List<MotDePasse> listeMdp;
        private string motDePasse;
        private string pseudo;
        public Connexion()
        {
            InitializeComponent();
            MotDePasse.ChargeUtilisateur();
            listeMdp = MotDePasse.getListUtilisateur();
        }

        private void BoutonInscription_Click(object sender, EventArgs e)
        {
                FenetreInscription fenetreInscription = new FenetreInscription();
                fenetreInscription.ShowDialog();
        }

        private void BoutonConnecter_Click(object sender, EventArgs e)
        {
            for(int i =0 ; i<listeMdp.Count; i++)
            {
            				if(IdentifiantConnexion.Text == listeMdp[i].Pseudo){ // si le texte rentré par l'utilisateur dans email et égal a un email de la base de données
								motDePasse = listeMdp[i].Mdp; //alors on sauvegarde le mot de passe... 
								pseudo = listeMdp[i].Pseudo;//... et le pseudo dans des variables
							}
						}
							if(MotDePasseConnexion.Text == motDePasse){ //Ensuite, si le mot de passe correspondant à l'email rentré est le meme que celui de la base
                                this.Hide();
                                Admin form = new Admin();
                                form.ShowDialog();
                                
							}
							else{ // sinon message d'erreur et on remet les champs a vide
								/*Toast.makeText(getApplicationContext(), "Mauvais pseudo ou mot de passe", Toast.LENGTH_SHORT).show();
								mEmail.setText("");
								mPass.setText("");*/
							}
        }
    }
}
