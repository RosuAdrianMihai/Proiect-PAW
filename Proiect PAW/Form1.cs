using Proiect_PAW.Abstract_Classes.Proiect_PAW.Abstract_Classes;
using Proiect_PAW.Classes;
using Proiect_PAW.DB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class Form1 : Form
    {
        ColectieEntitati colEnt = new ColectieEntitati();
        ColectieDiscipline colDis = new ColectieDiscipline();
        ColectieProfesori colProf = new ColectieProfesori();
        ColectieSali colSali = new ColectieSali();
        ColectieActivitati colAct = new ColectieActivitati();

        List<Serie> colSerie = new List<Serie>();
        List<Grupa> colGrupa = new List<Grupa>();

        public Form1()
        {
            List<Disciplina> dbDiscipline = DbOrar.primesteDisciplineDB();

            foreach(Disciplina d in dbDiscipline)
            {
                colDis.adaugaDisciplina(d);
            }

            List<Profesor> dbProfesori = DbOrar.primesteProfesoriDB(colDis);

            foreach(Profesor p in dbProfesori)
            {
                colProf.adaugaProfesor(p);
            }

            List<Sala> dbSali = DbOrar.primesteSaliDB();

            foreach(Sala s in dbSali)
            {
                colSali.adaugaSala(s);
            }

            List<Serie> dbSerii = DbOrar.primesteSeriiDB();
            List<Grupa> dbGrupe = DbOrar.primesteGrupeDB();

            foreach(Serie ser in dbSerii)
            {
                colEnt.adaugaEntitate(ser);
                colSerie.Add(ser);
            }

            foreach(Grupa grupa in dbGrupe)
            {
                colEnt.adaugaEntitate(grupa);
                colGrupa.Add(grupa);
            }

            List<Activitate> dbActivitati = DbOrar.primesteActivitatiDB(colEnt, colDis, colProf, colSali);

            foreach(Activitate a in dbActivitati)
            {
                colAct.adaugaActivitate(a);
            }

            InitializeComponent();            
        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnDisciplina.BringToFront();
            pnDisciplina.Visible = true;

            pnEntitate.Visible = false;
            pnProfesor.Visible = false;
            pnSala.Visible = false;
            pnActivitate.Visible = false;
            pnOrar.Visible = false;
        }

        private void profesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxProfesorDisciplina.Items.Clear();

            foreach (Disciplina d in colDis)
            {
                listBoxProfesorDisciplina.Items.Add(d.Denumire);
            }

            pnProfesor.BringToFront();
            pnProfesor.Visible = true;

            pnDisciplina.Visible = false;
            pnEntitate.Visible = false;
            pnSala.Visible = false;
            pnActivitate.Visible = false;
            pnOrar.Visible = false;
        }

        private void entitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnEntitate.BringToFront();
            pnEntitate.Visible = true;

            pnDisciplina.Visible = false;
            pnProfesor.Visible = false;
            pnSala.Visible = false;
            pnActivitate.Visible = false;
            pnOrar.Visible = false;
        }

        private void salaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pnSala.BringToFront();
            pnSala.Visible = true;

            pnProfesor.Visible = false;
            pnDisciplina.Visible = false;
            pnEntitate.Visible = false;
            pnActivitate.Visible = false;
            pnOrar.Visible = false;
        }

        private void activitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbActEntitate.Items.Clear();

            pnActivitate.BringToFront();
            pnActivitate.Visible = true;

            pnDisciplina.Visible = false;
            pnEntitate.Visible = false;
            pnProfesor.Visible = false;
            pnSala.Visible = false;
            pnOrar.Visible = false;

            foreach (Entitate entitate in colEnt)
            {
                cbActEntitate.Items.Add(entitate.Denumire);
            }
        }

        private void orarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbOrarEnt.Items.Clear();

            foreach (Entitate ent in colEnt)
            {
                cbOrarEnt.Items.Add(ent.Denumire);
            }

            pnOrar.BringToFront();
            pnOrar.Visible = true;

            pnDisciplina.Visible = false;
            pnProfesor.Visible = false;
            pnEntitate.Visible = false;
            pnSala.Visible = false;
            pnActivitate.Visible = false;
        }

        private void cbEntitate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbEntitate.SelectedItem != null)
            {
                lbDenumire.Visible = true;
                tbDenumire.Visible = true;

                lbAnStudiu.Visible = true;
                cbAnStudiu.Visible = true;

                btnEntitate.Visible = true;
            }

            if(cbEntitate.SelectedItem.ToString() == "Serie")
            {
                lbDenumire.Text = "Denumire serie";

                lbNrGrupe.Visible = true;
                cbNrGrupe.Visible = true;

                btnEntitate.Text = "Creeaza serie";
            }
            else if (cbEntitate.SelectedItem.ToString() == "Grupa")
            {
                lbDenumire.Text = "Denumire grupa";
                btnEntitate.Text = "Creeaza grupa";

                lbNrGrupe.Visible = false;
                cbNrGrupe.Visible = false;

                lbSerie.Visible = true;
                cbSerie.Visible = true;
            }
        }

        private void btnEntitate_Click(object sender, EventArgs e)
        {
            if(tbDenumire.Text.Trim() == "")
            {
                MessageBox.Show($"{cbEntitate.SelectedItem} trebuie sa aiba un nume");
                return;
            }else if (cbAnStudiu.SelectedItem == null)
            {
                MessageBox.Show($"{cbEntitate.SelectedItem} nu are an de studiu");
                return;
            }
            else if(cbEntitate.SelectedIndex == 0 && cbNrGrupe.SelectedItem == null)
            {
                MessageBox.Show("Seria trebuie sa aiba un numar de grupe");
                return;
            }
        

            if(cbEntitate.SelectedIndex == 0)
            {
                Serie s = new Serie(tbDenumire.Text, int.Parse(cbAnStudiu.SelectedItem.ToString()), int.Parse(cbNrGrupe.SelectedItem.ToString()));

                colSerie.Add(s);
                colEnt.adaugaEntitate(s);
                DbOrar.adaugaSerieDB(s);

                tbDenumire.Text = "";
                cbNrGrupe.SelectedIndex = -1;
                cbAnStudiu.SelectedIndex = -1;

                MessageBox.Show($"{s.Denumire} a fost creata cu succes");
            }
            else if(cbEntitate.SelectedIndex == 1)
            {
                Serie s = colSerie.FirstOrDefault(serie => serie.Denumire == cbSerie.SelectedItem.ToString() && serie.AnStudiu == int.Parse(cbAnStudiu.SelectedItem.ToString()));

                if(s != null)
                {
                    Grupa g = new Grupa(tbDenumire.Text, int.Parse(cbAnStudiu.Text), s);

                    colGrupa.Add(g);
                    colEnt.adaugaEntitate(g);
                    DbOrar.adaugaGrupaDB(g);

                    tbDenumire.Text = "";
                    cbSerie.SelectedIndex = -1;
                    cbAnStudiu.SelectedIndex = -1;

                    s.adaugaGrupa(g);

                    MessageBox.Show($"{g.Denumire} a fost creata cu succes");
                }
                else
                {
                    MessageBox.Show("Selecteaza o serie (Sau creeaza daca nu exista)");
                }
            }

            cbSerie.Items.Clear();
        }

        private void cbAnStudiu_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSerie.Items.Clear();

            if (colSerie.Count > 0 && cbAnStudiu.SelectedItem != null)
            {
                foreach (Serie s in colSerie)
                {
                    if (s.AnStudiu == int.Parse(cbAnStudiu.SelectedItem.ToString()))
                    {
                        cbSerie.Items.Add(s.Denumire);
                    }
                }
            }
        }

        private void btnDisciplina_Click(object sender, EventArgs e)
        {
            if(tbDenumireDis.Text.Trim() == "")
            {
                MessageBox.Show("Disciplina trebuie sa aiba o denumire");
                return;
            }

            if (cbNumarCredite.SelectedIndex == -1)
            {
                MessageBox.Show("Disciplina trebuie sa aiba un numar de credite");
                return;
            }

            if (cbAnDis.SelectedIndex == -1)
            {
                MessageBox.Show("Disciplina trebuie sa aiba un an de studiu");
                return;
            }


            bool disciplinaNoua = true;
            foreach(Disciplina disciplina in colDis)
            {
                if(disciplina.Denumire == tbDenumireDis.Text)
                {
                    disciplinaNoua = false;
                    break;
                }
            }

            if (disciplinaNoua)
            {
                Disciplina d = new Disciplina(tbDenumireDis.Text, int.Parse(cbNumarCredite.SelectedItem.ToString()), int.Parse(cbAnDis.SelectedItem.ToString()));
                colDis.adaugaDisciplina(d);
                DbOrar.adaugaDisciplinaDB(d);

                tbDenumireDis.Text = "";
                cbNumarCredite.SelectedIndex = -1;
                cbAnDis.SelectedIndex = -1;

                MessageBox.Show($"Disciplina {d.Denumire} a fost creata cu succes");
            }
            else
            {
                MessageBox.Show($"Disciplina {tbDenumireDis.Text} exista deja");
            }
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            if(tbNumeProfesor.Text.Trim() == "")
            {
                MessageBox.Show("Campul nume este obligatoriu");
                return;
            }

            ListBox.SelectedObjectCollection disciplinePredate = listBoxProfesorDisciplina.SelectedItems;
            if(disciplinePredate.Count == 0)
            {
                MessageBox.Show("Profesorul trebuie sa predea cel putin o materie");
                return;
            }

            Profesor profesorNou = new Profesor(tbNumeProfesor.Text.Trim());

            foreach(var disciplina in disciplinePredate)
            {
                foreach(Disciplina d in colDis)
                {
                    if(d.Denumire == disciplina.ToString())
                    {
                        profesorNou.Discipline.Add(d);
                        break;
                    }
                }   
            }

            colProf.adaugaProfesor(profesorNou);
            DbOrar.adaugaProfesorDB(profesorNou);

            tbNumeProfesor.Text = "";
            listBoxProfesorDisciplina.SelectedItems.Clear();

            MessageBox.Show($"Profesorul {profesorNou.Nume} a fost creat cu succes");
        }

        private void btnSala_Click(object sender, EventArgs e)
        {
            string denumireCladire = tbCladire.Text.Trim();
            string codSala = tbCodSala.Text.Trim();
            int nrLocuriSala = int.Parse(tbLocuri.Text.Trim());

            if (denumireCladire == "")
            {
                MessageBox.Show($"Sala trebuie sa existe intr-o cladire");
                return;
            }

            if (codSala == "")
            {
                MessageBox.Show($"Sala trebuie sa aiba un cod");
                return;
            }

            if (tbLocuri.Text.Trim() == "")
            {
                MessageBox.Show($"Sala trebuie sa aiba numar de locuri");
                return;
            }else if(nrLocuriSala < 20 && nrLocuriSala > 500)
            {
                MessageBox.Show($"Sala trebuie sa aiba numar de locuri valid ( > 19 ; < 501)");
                return;
            }

            Sala salaNoua = new Sala(denumireCladire, codSala, nrLocuriSala);
            colSali.adaugaSala(salaNoua);
            DbOrar.adaugaSalaDB(salaNoua);

            tbCodSala.Text = "";
            tbLocuri.Text = "";

            MessageBox.Show($"Sala aflata in {denumireCladire}, cu codul {codSala} si {nrLocuriSala} locuri, a fost creata.");
        }

        private void btnActivitate_Click(object sender, EventArgs e)
        {
            if(cbActEntitate.SelectedIndex == -1)
            {
                MessageBox.Show("Selecteaza o entitate");
                return;
            }

            if (cbActDisciplina.SelectedIndex == -1)
            {
                MessageBox.Show("Selecteaza o disciplina");
                return;
            }

            if (cbActProfesor.SelectedIndex == -1)
            {
                MessageBox.Show("Selecteaza un profesor");
                return;
            }

            if (cbActSala.SelectedIndex == -1)
            {
                MessageBox.Show("Selecteaza o sala");
                return;
            }

            if (cbActZi.SelectedIndex == -1)
            {
                MessageBox.Show("Selecteaza o zi");
                return;
            }

            if (cbActInterval.SelectedIndex == -1)
            {
                MessageBox.Show("Selecteaza un interval");
                return;
            }

            string denumireEntitate = cbActEntitate.SelectedItem.ToString();
            Entitate entitateSelectata = colEnt.FirstOrDefault(entitate => entitate.Denumire == denumireEntitate);

            string denumireDisciplina = cbActDisciplina.SelectedItem.ToString();
            Disciplina disciplinaSelectata = colDis.FirstOrDefault(dis => dis.Denumire == denumireDisciplina);

            string numeProfesor = cbActProfesor.SelectedItem.ToString();
            Profesor profesorSelectat = colProf.FirstOrDefault(profesor => profesor.Nume == numeProfesor);

            string denumireSala = cbActSala.SelectedItem.ToString();
            Sala salaSelectata = colSali.FirstOrDefault(sala => sala.ToString() == denumireSala);

            string ziSelectata = cbActZi.SelectedItem.ToString();
            string intervalSelectat = cbActInterval.SelectedItem.ToString();

            Activitate activitateNoua = new Activitate(entitateSelectata, disciplinaSelectata, profesorSelectat, salaSelectata, ziSelectata, intervalSelectat);
            entitateSelectata.adaugaActivitate(activitateNoua);
            colAct.adaugaActivitate(activitateNoua);
            DbOrar.adaugaActivitateDB(activitateNoua);

            cbActDisciplina.SelectedIndex = -1;
            cbActProfesor.SelectedIndex = -1;
            cbActSala.SelectedIndex = -1;
            cbActZi.SelectedIndex = -1;
            cbActInterval.SelectedIndex = -1;

            cbActSala.Items.Clear();
            cbActInterval.Items.Clear();

            MessageBox.Show("Activitatea a fost creata cu succes");
        }

        private void cbActEntitate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbActEntitate.SelectedIndex != -1)
            {
                cbActDisciplina.Items.Clear();

                string denumireEntitate = cbActEntitate.SelectedItem.ToString();
                Entitate entitateSelectata = colEnt.FirstOrDefault(entitate => entitate.Denumire == denumireEntitate);

                foreach (Disciplina d in colDis)
                {
                    if(d.AnStudiu == entitateSelectata.AnStudiu)
                    {
                        cbActDisciplina.Items.Add(d.Denumire);
                    }
                }

                lbActDisciplina.Visible = true;
                cbActDisciplina.Visible = true;
            }
        }

        private void cbActDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbActDisciplina.SelectedIndex != -1)
            {
                cbActProfesor.Items.Clear();

                string denumireDisciplina = cbActDisciplina.SelectedItem.ToString();
                Disciplina disciplinaSelectata = colDis.FirstOrDefault(dis => dis.Denumire == denumireDisciplina);

                foreach (Profesor p in colProf)
                {
                    if (p.Discipline.Contains(disciplinaSelectata))
                    {
                        cbActProfesor.Items.Add(p.Nume);
                    }
                }

                lbActProfesor.Visible = true;
                cbActProfesor.Visible = true;
            }
        }

        private void cbActProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbActProfesor.SelectedIndex != -1)
            {
                foreach(Sala s in colSali)
                {
                    cbActSala.Items.Add($"{s.Cladire} - {s.CodSala}");
                }

                lbActSala.Visible = true;
                cbActSala.Visible = true;
            }
        }

        private void cbActSala_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbActSala.SelectedIndex != -1)
            {
                lbActZi.Visible = true;
                cbActZi.Visible = true;

                TimeSpan inceputActivitati = new TimeSpan(7, 30, 0);
                TimeSpan sfarsitActivitati = new TimeSpan(19, 20, 0);

                while (inceputActivitati < sfarsitActivitati)
                {
                    cbActInterval.Items.Add(inceputActivitati.ToString("hh\\:mm") + " - " + inceputActivitati.Add(new TimeSpan(1, 20, 0)).ToString("hh\\:mm"));
                    inceputActivitati = inceputActivitati.Add(new TimeSpan(1, 30, 0));
                }

                lbActInterval.Visible = true;
                cbActInterval.Visible = true;
            }
        }

        private void cbOrarEnt_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbLayPnOrar.Controls.Clear();

            Entitate ent = colEnt.FirstOrDefault(et => et.Denumire == cbOrarEnt.SelectedItem.ToString());
            List<Activitate> listaActivitati = new List<Activitate>();

            if (ent is Grupa)
            {
                Grupa grupaSelectata = (Grupa)ent;

                foreach(Activitate act in colAct)
                {
                    if(act.entitate.Denumire == grupaSelectata.Denumire || act.entitate.Denumire == grupaSelectata.Serie.Denumire)
                    {
                        listaActivitati.Add(act);
                    }
                }
            }else if(ent is Serie)
            {
                Serie serieSelectata = (Serie)ent;

                foreach (Activitate act in colAct)
                {
                    if (act.entitate.Denumire == serieSelectata.Denumire)
                    {
                        listaActivitati.Add(act);
                    }
                }
            }

            listaActivitati = listaActivitati.OrderBy(act => act.Interval).ToList();

            List<Activitate> listaActLuni = new List<Activitate>();
            List<Activitate> listaActMarti = new List<Activitate>();
            List<Activitate> listaActMiercuri = new List<Activitate>();
            List<Activitate> listaActJoi = new List<Activitate>();
            List<Activitate> listaActVineri = new List<Activitate>();

            foreach(Activitate act in listaActivitati)
            {
                switch (act.Zi)
                {
                    case "Luni":
                        listaActLuni.Add(act);
                        break;

                    case "Marti":
                        listaActMarti.Add(act);
                        break;

                    case "Miercuri":
                        listaActMiercuri.Add(act);
                        break;

                    case "Joi":
                        listaActJoi.Add(act);
                        break;

                    case "Vineri":
                        listaActVineri.Add(act);
                        break;
                }
            }


            int column = 0;
            int row = 0;
            foreach (Activitate actLuni in listaActLuni)
            {
                Label actLabel = new Label();
                actLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                actLabel.Text = $"{actLuni.Interval} {actLuni.Disciplina.Denumire}\n{actLuni.Profesor.Nume} {actLuni.Sala.CodSala}";
                tbLayPnOrar.Controls.Add(actLabel, column, row);
                row++;
            }

            column = 1;
            row = 0;
            foreach (Activitate actMarti in listaActMarti)
            {
                Label actLabel = new Label();
                actLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                actLabel.Text = $"{actMarti.Interval} {actMarti.Disciplina.Denumire}\n{actMarti.Profesor.Nume} {actMarti.Sala.CodSala}";
                tbLayPnOrar.Controls.Add(actLabel, column, row);
                row++;
            }

            column = 2;
            row = 0;
            foreach (Activitate actMiercuri in listaActMiercuri)
            {
                Label actLabel = new Label();
                actLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                actLabel.Text = $"{actMiercuri.Interval} {actMiercuri.Disciplina.Denumire}\n{actMiercuri.Profesor.Nume} {actMiercuri.Sala.CodSala}";
                tbLayPnOrar.Controls.Add(actLabel, column, row);
                row++;
            }

            column = 3;
            row = 0;
            foreach (Activitate actJoi in listaActJoi)
            {
                Label actLabel = new Label();
                actLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                actLabel.Text = $"{actJoi.Interval} {actJoi.Disciplina.Denumire}\n{actJoi.Profesor.Nume} {actJoi.Sala.CodSala}";
                tbLayPnOrar.Controls.Add(actLabel, column, row);
                row++;
            }

            column = 4;
            row = 0;

            foreach (Activitate actVineri in listaActVineri)
            {
                Label actLabel = new Label();
                actLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
                actLabel.Text = $"{actVineri.Interval} {actVineri.Disciplina.Denumire}\n{actVineri.Profesor.Nume} {actVineri.Sala.CodSala}";
                tbLayPnOrar.Controls.Add(actLabel, column, row);
                row++;
            }
        }
    }
}
