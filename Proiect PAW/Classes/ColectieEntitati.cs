using Proiect_PAW.Abstract_Classes.Proiect_PAW.Abstract_Classes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Classes
{
    internal class ColectieEntitati : IEnumerable<Entitate>
    {
        private List<Entitate> entitati;

        public ColectieEntitati()
        {
            entitati = new List<Entitate>();
        }

        public void adaugaEntitate(Entitate entitate)
        {
            entitati.Add(entitate);
        }

        public List<Entitate> GetEntitati()
        {
            return entitati;
        }

        public IEnumerator<Entitate> GetEnumerator()
        {
            return entitati.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return entitati.GetEnumerator();
        }
    }
}
