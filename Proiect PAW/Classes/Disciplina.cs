using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Classes
{
    internal class Disciplina : IComparable<Disciplina>
    {
        public string ID_Disciplina;
        private string denumire;
        private List<Profesor> profesori;
        private int nrCredite;
        private int anStudiu;

        public Disciplina(string denumire, int nrCredite, int anStudiu)
        {
            this.ID_Disciplina = Guid.NewGuid().ToString();
            this.denumire = denumire;
            this.profesori = new List<Profesor>();
            this.nrCredite = nrCredite;
            this.anStudiu = anStudiu;
        }

        public Disciplina(string ID_Disciplina, string denumire, int nrCredite, int anStudiu)
        {
            this.ID_Disciplina = ID_Disciplina;
            this.denumire = denumire;
            this.profesori = new List<Profesor>();
            this.nrCredite = nrCredite;
            this.anStudiu = anStudiu;
        }

        public string Denumire
        {
            get { return denumire; }
            set { denumire = value; }
        }

        public List<Profesor> Profesori
        {
            get { return profesori; }
            set { profesori = value; }
        }

        public int NrCredite
        {
            get { return nrCredite; }
            set { nrCredite = value; }
        }

        public int AnStudiu
        {
            get { return anStudiu; }
            set { anStudiu = value; }
        }

        public void adaugaProfesor(Profesor p) 
        {
            profesori.Add(p);
        }

        public void eliminaProfesor(Profesor p)
        {
            profesori.Remove(p);
        }

        public int CompareTo(Disciplina d2)
        {
            if(this.nrCredite > d2.nrCredite)
            {
                return -1;
            }
            else if(this.nrCredite < d2.nrCredite)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
