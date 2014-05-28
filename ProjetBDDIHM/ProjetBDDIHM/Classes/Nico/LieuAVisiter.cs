using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBDDIHM.Classes.Nico
{
    class LieuAVisiter
    {
        public string nomLieu { get; set; }
        public string ville { get; set; }
        public string pays { get;  set;}
        public string descriptif { get; set; }
        public int prixVisite { get; set; }

        public LieuAVisiter(string nomLieu, string ville, string pays, string descriptif, int prixVisite)
        {
            this.nomLieu = nomLieu;
            this.ville = ville;
            this.pays = pays;
            this.descriptif = descriptif;
            this.prixVisite = prixVisite;
        }
    }
}
