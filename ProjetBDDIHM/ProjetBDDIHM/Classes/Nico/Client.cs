using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBDDIHM.Classes.Nico
{
    class Client
    {
        public int id { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime dateNaissance { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public bool privilege { get; set; }  //si 0 client si 1 admin

        public Client(int id ,string nom , string prenom, DateTime dateNaissance, string login , string password ,bool privilege)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.login = login;
            this.password = password;
            this.privilege = privilege;
        }
    }
}
