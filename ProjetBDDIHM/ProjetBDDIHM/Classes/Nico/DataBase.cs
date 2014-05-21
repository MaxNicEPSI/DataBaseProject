using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBDDIHM
{
    class DataBase
    {
        public string connexion;
        public DataBase()
        {
            connexion = "Data Source=(DESCRIPTION="
            + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=PC-Port-Nico)(PORT=1521)))"
            + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));"
            + "User Id=system;Password=password;";

            //
            //Pour remplir les champs pour la connexions de la BDD
            //On peut retrouver ces informations dans 
            //C:\oraclexe\app\oracle\product\11.2.0\server\network\ADMIN\tnsnames.ora
            
        }

        public void UpdateDataBase(string param)
        {

        }
    }
}
