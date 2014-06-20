using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ProjetBDDIHM
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            /*string constr = "Data Source=(DESCRIPTION="
+ "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=PC-Port-Nico)(PORT=1521)))"
+ "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));"
+ "User Id=system;Password=password;";
            string cmdstr = "SELECT * from DataSet1.CIRCUIT";
            //OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);
            
            try
            {
                DataSet1 dataset = new DataSet1();
                //adapter.Fill(dataset, "DataSet1.CIRCUIT");
                DataTable table = dataset.Tables["DataSet1.CIRCUIT"];
                DataRow row = table.Rows[2];
                MessageBox.Show(row["DESCRIPTIF"].ToString());
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.Message);
            }
            */

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
                        string constr = "Data Source=(DESCRIPTION="
            + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=PC-Port-Nico)(PORT=1521)))"
            + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));"
            + "User Id=system;Password=password;";
     
                        string cmdstr = "SELECT * from ProjetBDD.CIRCUIT";
                        OracleDataAdapter adapter = new OracleDataAdapter(cmdstr, constr);
                        OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
                        try
                        {
                            DataSet1 dataset = new DataSet1();
                            adapter.Fill(dataset, "ProjetBDD.CIRCUIT");
                            DataTable table = dataset.Tables["ProjetBDD.CIRCUIT"];
                            DataRow row = table.Rows[1];
                            MessageBox.Show(row["DESCRIPTIF"].ToString());
                        }
                        catch (Exception ee)
                        {
                            MessageBox.Show(ee.Message);
                        }
                    */
        }
    }
}
