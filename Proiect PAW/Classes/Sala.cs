using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Classes
{
    internal class Sala : IComparable<Sala>
    {
        public string ID_Sala;
        private string cladire;
        private string codSala;
        private int nrLocuri;

        public Sala(string cladire, string codSala, int nrLocuri)
        {
            this.ID_Sala = Guid.NewGuid().ToString();
            this.cladire = cladire;
            this.codSala = codSala;
            this.nrLocuri = nrLocuri;
        }

        public Sala(string ID_Sala, string cladire, string codSala, int nrLocuri)
        {
            this.ID_Sala = ID_Sala;
            this.cladire = cladire;
            this.codSala = codSala;
            this.nrLocuri = nrLocuri;
        }

        public string Cladire
        {
            get { return cladire; }
            set { cladire = value; }
        }

        public string CodSala
        {
            get { return codSala; }
            set { codSala = value; }
        }

        public int NrLocuri
        {
            get { return nrLocuri; }
            set { nrLocuri = value; }
        }

        public int CompareTo(Sala s)
        {
            if(this.nrLocuri > s.nrLocuri)
            {
                return -1;
            }else if(this.nrLocuri < s.nrLocuri)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return $"{this.Cladire} - {this.CodSala}";
        }
    }
}
