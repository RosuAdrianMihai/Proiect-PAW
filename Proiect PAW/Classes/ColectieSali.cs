using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Classes
{
    internal class ColectieSali : IEnumerable<Sala>
    {
        private List<Sala> sali;

        public ColectieSali()
        {
            sali = new List<Sala>();
        }

        public void adaugaSala(Sala s)
        {
            sali.Add(s);
        }

        public void eliminaSala(Sala s)
        {
            sali.Remove(s);
        }

        public List<Sala> Sali
        {
            get { return sali; }
            set { sali = value; }
        }

        public IEnumerator<Sala> GetEnumerator()
        {
            return sali.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return sali.GetEnumerator();
        }
    }
}
