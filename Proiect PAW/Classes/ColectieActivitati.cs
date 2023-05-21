using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Classes
{
    internal class ColectieActivitati : IEnumerable<Activitate>
    {
        private List<Activitate> activitati;

        public ColectieActivitati()
        {
            activitati = new List<Activitate>();
        }

        public void adaugaActivitate(Activitate s)
        {
            activitati.Add(s);
        }

        public void eliminaActivitate(Activitate s)
        {
            activitati.Remove(s);
        }

        public List<Activitate> Activitati
        {
            get { return activitati; }
            set { activitati = value; }
        }

        public IEnumerator<Activitate> GetEnumerator()
        {
            return activitati.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return activitati.GetEnumerator();
        }
    }
}
