using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBDDIHM.Classes.Nico
{
    class Etape
    {
        public int id { get; set; }
        public string pays { get; set; }
        public DateTime dateEtape { get; set; }
        public int duree { get; set; }

        public Etape(int id, string pays, DateTime dateEtape, int duree)
        {
            this.id = id;
            this.pays = pays;
            this.dateEtape = dateEtape;
            this.duree = duree;
        }
    }
}
