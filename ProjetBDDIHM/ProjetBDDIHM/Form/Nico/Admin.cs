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
    public partial class Admin : Form
    {

        
        public Admin()
        {
            InitializeComponent();
            buttonClient.BackColor = System.Drawing.Color.FromArgb(255, 166, 80);
            
        }

        private void label_Click_Deconnexion(object sender, EventArgs e)
        {
            MessageBox.Show("Clique");
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
           /* string constr = "Data Source=(DESCRIPTION="
+ "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=PC-Port-Nico)(PORT=1521)))"
+ "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));"
+ "User Id=system;Password=password;";

            string cmdstr = "INSERT Into * from PROJETBDDCIRCUIT.CIRCUIT";
            OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);
            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            try
            {
                DataSet1 dataset = new DataSet1();
                adapter.Fill(dataset, "PROJETBDDCIRCUIT.CLIENT");
                DataTable table = dataset.Tables["PROJETBDDCIRCUIT.CIRCUIT"];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }

           
            System.Windows.Forms.MessageBox.Show(nbr.ToString());*/
        }

       
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonCircuit_Click(object sender, EventArgs e)
        {

           /* OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            try
            {
                DataSet1 dataset = new DataSet1();
                adapter.Fill(dataset, "PROJETBDDCIRCUIT.CLIENT");
                DataTable table = dataset.Tables["PROJETBDDCIRCUIT.CIRCUIT"];
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }*/
        }

        
    }
}
