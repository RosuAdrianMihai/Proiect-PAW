using Proiect_PAW.Abstract_Classes;
using Proiect_PAW.Abstract_Classes.Proiect_PAW.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Classes
{
    internal class Serie : Entitate
    {
        private int nrGrupe;
        private Grupa[] grupe;

        public Serie(string denumire, int anStudiu, int nrGrupe) : base(denumire, anStudiu)
        {
            this.nrGrupe = nrGrupe;
            this.grupe = new Grupa[nrGrupe];
        }

        public Serie(string ID_Entitate, string denumire, int anStudiu, int nrGrupe) : base(ID_Entitate, denumire, anStudiu)
        {
            this.nrGrupe = nrGrupe;
        }

        public int NrGrupe
        {
            get { return nrGrupe; }
            set { nrGrupe = value; }
        }

        public Grupa[] Grupe
        {
            get { return grupe; }
            set { grupe = value; }
        }

        public void adaugaGrupa(Grupa g)
        {
            Array.Resize(ref grupe, grupe.Length + 1);

            grupe[grupe.Length - 1] = g;
        }

        public void eliminaGrupa(Grupa g)
        {
            int index = Array.FindIndex(grupe, grupa => grupa.Denumire == g.Denumire && grupa.Serie == g.Serie);

            if (index >= 0)
            {
                for (int i = index; i < grupe.Length - 1; i++)
                {
                    grupe[i] = grupe[i + 1];
                }
                Array.Resize(ref grupe, grupe.Length - 1);
            }

        }
    }
}
