using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using SalaDeGimnastica;
using SalaDeGimanastica;


namespace SalaDeGimanastica
{
    class Rezervare
    {
        private ArrayList PtList;
        private string ReservationDate;


        public void add(PersonalTrainer pt)
        {
            PtList = new ArrayList();
            PtList.Add(pt);
        }

        public Rezervare( ArrayList PtList, string ReservationDate)
        {
            PtList = new ArrayList();
            this.PtList = PtList;
            this.ReservationDate = ReservationDate;
        }
        public Rezervare()
        {
            PtList = null;
            ReservationDate =" ";

        }
    }
}
