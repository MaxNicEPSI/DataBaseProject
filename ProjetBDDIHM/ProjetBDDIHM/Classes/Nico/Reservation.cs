using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetBDDIHM.Classes.Nico
{
    class Reservation
    {
        public int id { get; set; }
        public int place { get; set; }
        public DateTime dateReservation { get; set; }


        public Reservation(int id, int place, DateTime dateReservation)
        {
            this.id = id;
            this.place = place;
            this.dateReservation = dateReservation;
        }
    }
}
