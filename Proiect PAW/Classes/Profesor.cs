using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Classes
{
    internal class Profesor : IComparable<Profesor>, ICloneable
    {
        public string ID_Profesor;
        private string nume;
        private List<Disciplina> discipline;

        public Profesor(List<Disciplina> discipline)
        {
            this.ID_Profesor = Guid.NewGuid().ToString();
            this.discipline = discipline;
        }

        public Profesor(string nume)
        {
            this.ID_Profesor = Guid.NewGuid().ToString();
            this.nume = nume;
            this.discipline = new List<Disciplina>();
        }

        public Profesor(string ID_Profesor, string nume)
        {
            this.ID_Profesor = ID_Profesor;
            this.nume = nume;
            this.discipline = new List<Disciplina>();
        }

        public string Nume{
            get {  return nume; }
            set { nume = value; }
        }

        public List<Disciplina> Discipline
        {
            get { return discipline; }
            set { discipline = value; }
        }

        public void adaugaDisciplina(Disciplina d)
        {
            discipline.Add(d);
        }

        public void eliminaDisciplina(Disciplina d)
        {
            discipline.Remove(d);
        }

        public float nrOreSaptamana()
        {
            float nrOre = 0;

            foreach(Disciplina d in discipline)
            {
                nrOre += 1.2f;
            }

            return nrOre;
        }

        public static bool operator >(Profesor p1, Profesor p2)
        {
            if(p1.discipline.Count > p2.discipline.Count)
            {
                return true;
            }

            return false;
        }

        public static bool operator <(Profesor p1, Profesor p2)
        {
            if(p1.discipline.Count < p2.discipline.Count)
            {
                return true;
            }

            return false;
        }

        public int CompareTo(Profesor p2)
        {
            float nrOreP1 = this.nrOreSaptamana();
            float nrOreP2 = p2.nrOreSaptamana();

            if(nrOreP1 > nrOreP2)
            {
                return 1;
            }else if(nrOreP1 < nrOreP2)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public object Clone()
        {
            Profesor clona = new Profesor(this.discipline);

            return clona;
        }
    }
}
