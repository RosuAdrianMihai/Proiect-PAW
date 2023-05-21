using Proiect_PAW.Abstract_Classes;
using Proiect_PAW.Abstract_Classes.Proiect_PAW.Abstract_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Proiect_PAW.Classes
{
    internal class Activitate
    {
        public string ID_Activitate;
        public Entitate entitate;
        private Disciplina disciplina;
        private Profesor profesor;
        private Sala sala;
        private string zi;
        private string interval;

        public Activitate(Entitate entitate, Disciplina disciplina, Profesor profesor, Sala sala, string zi, string interval)
        {
            this.entitate = entitate;
            this.ID_Activitate = Guid.NewGuid().ToString();
            this.disciplina = disciplina;
            this.profesor = profesor;
            this.sala = sala;
            this.zi = zi;
            this.interval = interval;
        }

        public Activitate(Entitate entitate, string ID_Activitate, Disciplina disciplina, Profesor profesor, Sala sala, string zi, string interval)
        {
            this.entitate = entitate;
            this.ID_Activitate = ID_Activitate;
            this.disciplina = disciplina;
            this.profesor = profesor;
            this.sala = sala;
            this.zi = zi;
            this.interval = interval;
        }

        public Disciplina Disciplina
        {
            get { return disciplina; }
            set { disciplina = value; }
        }

        public Profesor Profesor
        {
            get { return profesor; }
            set { profesor = value; }
        }

        public Sala Sala
        {
            get { return sala; }
            set { sala = value; }
        }

        public string Zi
        {
            get { return zi; }
            set { zi = value; }
        }

        public string Interval
        {
            get { return interval; }
            set { interval = value; }
        }
    }
}
