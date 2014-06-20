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
    public partial class FenetreGestionCircuit : Form
    {
        static DataBase dataEtape { get; set; }
        static DataBase dataCircuit { get; set; }

        public static object villeDepartCircuit { get; set; }

        public static object villeArriveeCircuit { get; set; }

        public FenetreGestionCircuit()
        {

            InitializeComponent();
            dataCircuit = new DataBase();
            dataCircuit.RequestData("SELECT * FROM CIRCUIT order by identifiant");


            while (dataCircuit.dr.Read())
            {
                object identifiantCircuit = dataCircuit.dr.GetValue(0);
                object villeDepartCircuit = dataCircuit.dr.GetValue(2);
                object villeArriveeCircuit = dataCircuit.dr.GetValue(4);
                try
                {
                    CircuitComboBox.Items.Add(identifiantCircuit + " - " + villeDepartCircuit + "/" + villeArriveeCircuit);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
            }


        }

        private void CircuitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            dataCircuit = new DataBase();
            dataCircuit.RequestData("SELECT * FROM CIRCUIT order by identifiant");


            while (dataCircuit.dr.Read())
            {
                object identifiantCircuit = dataCircuit.dr.GetValue(0);
                object villeDepartCircuit = dataCircuit.dr.GetValue(2);
                object villeArriveeCircuit = dataCircuit.dr.GetValue(4);
                try
                {
                    VilleDepartCircuitTextBox.Text = villeDepartCircuit.ToString();
                    VilleArriveeCircuitTextBox.Text = villeArriveeCircuit.ToString();
                }
                catch (Exception ee)
                {
                    MessageBox.Show(ee.Message);
                }
            }
            
            // Plutot que de rappelr ca faire une fonctione avec des parametres
            dataEtape = new DataBase();
            dataEtape.RequestData("Select * from etape where IdentifiantCircuit ="+(CircuitComboBox.SelectedIndex+1)+"order by ordre");
            EtapeComboBox.Items.Clear();
            EtapeComboBox.Text = "";
                while (dataEtape.dr.Read())
                {
                    
                    /*object descriptifCircuit = data.dr.GetValue(1);
                    object villeDepartCircuit = data.dr.GetValue(2);
                    object paysDepartCircuit = data.dr.GetValue(3);
                    object villeArriveeCircuit = data.dr.GetValue(4);
                    object paysArriveeCircuit = data.dr.GetValue(5);
                    object dateDepartCircuit = data.dr.GetValue(7);
                    object dureeCircuit = data.dr.GetValue(8);
                    object prixCircuit = data.dr.GetValue(9);

                    public object ordreEtape = data.dr.GetValue(0);
                    object paysEtape = data.dr.GetValue(2);
                    object dateEtape = data.dr.GetValue(3);
                    object dureeEtape = data.dr.GetValue(4);
                    object nomLieuEtape = data.dr.GetValue(5);
                    object villeEtape = data.dr.GetValue(6);*/

                    object villeEtape = dataEtape.dr.GetValue(6);
                    try
                    {
                        EtapeComboBox.Items.Add(villeEtape); //Champ ville

                        
                        
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                    }
                }
        }

        private void EtapeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                DateDepartCircuitTextBox.Text = dataCircuit.dr.GetValue(0).ToString();
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);    
            }
                DataBase data = new DataBase();
                data.RequestData("Select nomLieu from LieuAVisiter where Ville ='"+EtapeComboBox.SelectedItem.ToString()+"'");
                while (data.dr.Read())
                {
                    /*object ordreEtape = data.dr.GetValue(0);
                    object paysEtape = data.dr.GetValue(2);
                    object dateEtape = data.dr.GetValue(3);
                    object dureeEtape = data.dr.GetValue(4);
                    object nomLieuEtape = data.dr.GetValue(5);
                    object villeEtape = data.dr.GetValue(6);*/

                    object nomLieuLieuVisiter = data.dr.GetValue(0);
                     /*   ville
                            pays
                            Descriptif
                                prix*/
                    try
                    {
                        LieuVisiter.Text = data.dr.GetValue(0).ToString();

                       /* OrdreEtapeTextBox.Text = ordreEtape.ToString();
                        PaysEtapeTextBox.Text = paysEtape.ToString();
                        DateEtapeTextBox.Text = dateEtape.ToString();
                        DureeEtapeTextBox.Text = dureeEtape.ToString();
                        NomLieuEtapeTextBox.Text = nomLieuEtape.ToString();
                        VilleEtapeTextBox.Text = villeEtape.ToString();*/
                    }
                    catch (Exception e1)
                    {
                        MessageBox.Show(e1.Message);
                    }
                }  
        }

    }
}
