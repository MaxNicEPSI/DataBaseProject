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
    public partial class FormClient : Form
    {
        private bool flagClient = true;
        private bool flagReservation = true;
        public FormClient()
        {
            InitializeComponent();
            DataBase data = new DataBase();
            data.RequestData("SELECT DATEDEPART FROM CIRCUIT");
                while (data.dr.Read())
                {
                    try
                    {
                        cbCircuit.Items.Add(data.dr.GetValue(0));
                    }
                    catch (Exception ee)
                    {
                        MessageBox.Show(ee.Message);
                    }
                }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonModifierClient_Click(object sender, EventArgs e)
        {
            if(flagClient)
            {
                buttonValiderClient.Enabled = true;
                buttonAnnulerClient.Enabled = true;
                textBoxNomClient.ReadOnly = false;
                textBoxPrenomClient.ReadOnly = false;
                dateTimePickerClient.Enabled = true;
                buttonModifierClient.Enabled = false;
                buttonAjouterClient.Enabled = false;
                buttonSupprimerClient.Enabled = false;
                textBoxNomClient.Enabled = true;
                flagClient = false;
            }
        }

        private void buttonValiderClient_Click(object sender, EventArgs e)
        {
            if (!flagClient)
            {
                //mettre à jour dans la base mais vérifier si les champs remplis sont correctes
                buttonValiderClient.Enabled = false;
                buttonAnnulerClient.Enabled = false;
                textBoxNomClient.ReadOnly = true;
                textBoxPrenomClient.ReadOnly = true;
                dateTimePickerClient.Enabled = false;
                buttonModifierClient.Enabled = true;
                buttonAjouterClient.Enabled = true;
                buttonSupprimerClient.Enabled = true;
                flagClient = true;
            }
        }

        private void buttonAnnulerClient_Click(object sender, EventArgs e)
        {
            if (!flagClient)
            {
                //Annuler la saisi, on recharge les valeurs par defaut du client
                buttonAjouterClient.Enabled = false;
                buttonAnnulerClient.Enabled = false;
                textBoxNomClient.ReadOnly = true;
                textBoxPrenomClient.ReadOnly = true;
                dateTimePickerClient.Enabled = false;
                buttonModifierClient.Enabled = true;
                buttonAjouterClient.Enabled = true;
                buttonSupprimerClient.Enabled = true;
                flagClient = true;
            }
        }

        private void buttonAjouterClient_Click(object sender, EventArgs e)
        {
            if (flagClient)
            {
                buttonValiderClient.Enabled = true;
                buttonAnnulerClient.Enabled = true;
                textBoxNomClient.ReadOnly = false;
                textBoxPrenomClient.ReadOnly = false;
                dateTimePickerClient.Enabled = true;
                buttonModifierClient.Enabled = false;
                buttonAjouterClient.Enabled = false;
                buttonSupprimerClient.Enabled = false;
                flagClient = false;
            }
        }
         
        //RESERVATION
        private void buttonAjouterReservation_Click(object sender, EventArgs e)
        {
            if (flagReservation)
            {
                buttonValiderReservation.Enabled = true;
                buttonAnnulerReservation.Enabled = true;
                textBoxPlaceReservation.ReadOnly = false;
                dateTimePickerReservation.Enabled = true;
                textBoxCircuitReservation.ReadOnly = false;
                buttonModifierReservation.Enabled = false;
                buttonAjouterReservation.Enabled = false;
                buttonSupprimerReservation.Enabled = false;
                flagReservation = false;
            }
        }

        private void buttonModifierReservation_Click(object sender, EventArgs e)
        {
            if (flagReservation)
            {
                buttonValiderReservation.Enabled = true;
                buttonAnnulerReservation.Enabled = true;
                textBoxPlaceReservation.ReadOnly = false;
                dateTimePickerReservation.Enabled = true;
                textBoxCircuitReservation.ReadOnly = false;
                buttonModifierReservation.Enabled = false;
                buttonAjouterReservation.Enabled = false;
                buttonSupprimerReservation.Enabled = false;
                flagReservation = false;
            }
        }

        private void buttonAnnulerReservation_Click(object sender, EventArgs e)
        {
            if (!flagReservation)
            {
                buttonValiderReservation.Enabled = false;
                buttonAnnulerReservation.Enabled = false;
                textBoxPlaceReservation.ReadOnly = true;
                dateTimePickerReservation.Enabled = false;
                textBoxCircuitReservation.ReadOnly = true;
                buttonModifierReservation.Enabled = true;
                buttonAjouterReservation.Enabled = true;
                buttonSupprimerReservation.Enabled = true;
                flagReservation = true;
            }
        }

        private void buttonValiderReservation_Click(object sender, EventArgs e)
        {
            if (!flagReservation)
            {
                buttonValiderReservation.Enabled = false;
                buttonAnnulerReservation.Enabled = false;
                textBoxPlaceReservation.ReadOnly = true;
                dateTimePickerReservation.Enabled = false;
                textBoxCircuitReservation.ReadOnly = true;
                buttonModifierReservation.Enabled = true;
                buttonAjouterReservation.Enabled = true;
                buttonSupprimerReservation.Enabled = true;
                flagReservation = true;
            }
        }

        private void buttonSupprimerReservation_Click(object sender, EventArgs e)
        {
            //delete de la selection dans la table Reservation
        }

        private void buttonSupprimerClient_Click(object sender, EventArgs e)
        {
            //delete de la selection dans la table Client
        }

        private void buttonFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxIdReservation_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void cbCircuit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


       
    }
}
