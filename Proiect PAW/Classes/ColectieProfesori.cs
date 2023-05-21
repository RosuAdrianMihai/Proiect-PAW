using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Classes
{
    internal class ColectieProfesori : IEnumerable<Profesor>
    {
        private List<Profesor> profesori;
        
        public ColectieProfesori()
        {
            profesori = new List<Profesor>();
        }

        public void adaugaProfesor(Profesor p)
        {
            profesori.Add(p);
        }

        public void eliminaProfesor(Profesor p)
        {
            profesori.Remove(p);
        }

        public List<Profesor> Profesori
        {
            get { return profesori; }
            set { profesori = value; }
        }

        public IEnumerator<Profesor> GetEnumerator()
        {
            return profesori.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return profesori.GetEnumerator();
        }
    }
}
