using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBDDIHM.Classes.Nico
{
    class Circuit
    {
        public int id { get; set; }
        public string descriptif { get; set; }
        public string villeDepart { get; set; }
        public string paysDepart { get; set; }
        public string villeArrivee  { get; set; }
        public string paysArrivee { get; set; }
        public DateTime dateDepart { get; set; } 
        public int nbrPlaceDisponible {get;set; }
        public int duree {get;set;}
        public int prixInscription {get;set;}

        public Circuit(int id ,string descriptif, string villeDepart, string paysDepart, string villeArrivee, string paysArrivee, DateTime dateDepart, int nbrPlaceDisponible, int duree, int prixInscription)
        {
            this.id = id;
            this.descriptif = descriptif;
            this.villeDepart = villeDepart;
            this.paysDepart = paysDepart;
            this.villeArrivee = villeArrivee;
            this.paysArrivee = paysArrivee;
            this.dateDepart = dateDepart;
            this.nbrPlaceDisponible = nbrPlaceDisponible;
            this.duree = duree;
            this.prixInscription = prixInscription;
        }
    }
    }
}
