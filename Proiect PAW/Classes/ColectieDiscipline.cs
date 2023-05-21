using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Classes
{
    internal class ColectieDiscipline : IEnumerable<Disciplina>
    {
        private List<Disciplina> discipline;

        public ColectieDiscipline()
        {
            discipline = new List<Disciplina>();
        }

        public void adaugaDisciplina(Disciplina d)
        {
            discipline.Add(d);
        }

        public void eliminaDisciplina(Disciplina d)
        {
            discipline.Remove(d);
        }

        public List<Disciplina> Discipline
        {
            get { return discipline; }
            set { discipline = value; }
        }

        public IEnumerator<Disciplina> GetEnumerator()
        {
            return discipline.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return discipline.GetEnumerator();
        }
    }
}
