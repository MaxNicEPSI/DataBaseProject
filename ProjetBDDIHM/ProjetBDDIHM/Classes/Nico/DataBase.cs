using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetBDDIHM
{
    class DataBase
    {
      
        public OracleDataReader dr { get; set; }
        private string constr;
        private OracleConnection con;
        public DataBase()
        {
            constr = "Data Source=(DESCRIPTION="
+ "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))"
+ "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));"
+ "User Id=PROJETBDDCIRCUIT;Password=password;";

            con = new OracleConnection();
            con = new OracleConnection(constr);
            con.Open();       
            //
            //Pour remplir les champs pour la connexions de la BDD
            //On peut retrouver ces informations dans 
            //C:\oraclexe\app\oracle\product\11.2.0\server\network\ADMIN\tnsnames.ora
            
        }

        public void RequestData(string req)   //requête à passer en param
        {
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandText = req;
                cmd.CommandType = CommandType.Text;
                dr = cmd.ExecuteReader();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
