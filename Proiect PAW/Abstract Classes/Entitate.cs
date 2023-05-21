using Proiect_PAW.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Abstract_Classes
{
    namespace Proiect_PAW.Abstract_Classes
    {
        internal abstract class Entitate
        {
            public string ID_Entitate;
            protected string denumire;
            protected ColectieActivitati activitati;
            protected int anStudiu;

            public Entitate(string denumire, int anStudiu)
            {
                this.ID_Entitate = Guid.NewGuid().ToString();
                this.denumire = denumire;
                this.anStudiu = anStudiu;
                this.activitati = new ColectieActivitati();
            }

            protected Entitate(string ID_Entitate, string denumire, int anStudiu)
            {
                this.ID_Entitate = ID_Entitate;
                this.denumire = denumire;
                this.anStudiu = anStudiu;
                this.activitati = new ColectieActivitati();
            }

            public string Denumire
            {
                get { return denumire; }
                set { denumire = value; }
            }

            public int AnStudiu
            {
                get { return anStudiu; }
                set { anStudiu = value; }
            }

            public ColectieActivitati Activitati
            {
                get { return activitati; }
                set { activitati = value; }
            }

            public int numarActivitati()
            {
                return activitati.Count();
            }

            public void adaugaActivitate(Activitate activitate)
            {
                activitati.adaugaActivitate(activitate);
            }
        }
    }
}
