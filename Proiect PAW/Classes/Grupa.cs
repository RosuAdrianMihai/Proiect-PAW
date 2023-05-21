using Proiect_PAW.Abstract_Classes;
using Proiect_PAW.Abstract_Classes.Proiect_PAW.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_PAW.Classes
{
    internal class Grupa : Entitate
    {
        private Serie serie;

        public Grupa(string denumire, int anStudiu, Serie serie) : base(denumire, anStudiu) 
        {
            this.serie = serie;
        }

        public Grupa(string ID_Entitate, string denumire, int anStudiu, Serie serie) : base(ID_Entitate, denumire, anStudiu)
        {
            this.serie = serie;
        }

        public Serie Serie
        {
            get { return serie; }
            set { serie = value; }
        }
    }
}
