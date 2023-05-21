using MySql.Data.MySqlClient;
using Proiect_PAW.Abstract_Classes.Proiect_PAW.Abstract_Classes;
using Proiect_PAW.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW.DB
{
    internal class DbOrar
    {
        public static MySqlConnection GetConnection()
        {
            string sql = "datasource=localhost;port=3306;username=root;password=nanaana123;database=dborar";
            MySqlConnection connection = new MySqlConnection(sql);

            try
            {
                connection.Open();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"MySQL Connection failed\nError: {ex}");
            }

            return connection;
        }

        public static void adaugaDisciplinaDB(Disciplina d)
        {
            string SQLCommand = $"INSERT INTO Discipline(ID_Disciplina, Nr_credite, An_studiu, Denumire)" +
                $" VALUES('{d.ID_Disciplina}', {d.NrCredite}, {d.AnStudiu}, '{d.Denumire}')";

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(SQLCommand, connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Error: {ex.Message}");
                }
            }
        }

        public static List<Disciplina> primesteDisciplineDB()
        {
            List<Disciplina> LDiscipline = new List<Disciplina>();
            string SQLCommand = "SELECT * FROM Discipline";
            DataTable dt = new DataTable();

            try
            {
                using (MySqlConnection connection = GetConnection())
                {
                    using (MySqlCommand command = new MySqlCommand(SQLCommand, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dt);
                        }
                    }
                }
            }
            catch(MySqlException ex)
            {
                MessageBox.Show($"MySQL Error: {ex.Message}");
            }

            foreach (DataRow row in dt.Rows)
            {
                string id = row["ID_Disciplina"].ToString();
                string denumire = row["Denumire"].ToString();
                int nrCredite = Convert.ToInt32(row["Nr_credite"]);
                int anStudiu = Convert.ToInt32(row["An_studiu"]);

                Disciplina disciplina = new Disciplina(id, denumire, nrCredite, anStudiu);
                LDiscipline.Add(disciplina);
            }

            return LDiscipline;
        }

        public static void adaugaProfesorDB(Profesor p)
        {
            using (MySqlConnection connection = GetConnection())
            {
                string SQLCommand = $"INSERT INTO Profesori(ID_Profesor, Nume) " +
                    $"VALUES('{p.ID_Profesor}', '{p.Nume}')";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(SQLCommand, connection))
                    {
                        command.ExecuteNonQuery();
                    }

                    string insertMappingSQL = "INSERT INTO profesori_discipline(FK_ID_Profesor, FK_ID_Disciplina) VALUES";

                    List<string> valuesList = new List<string>();

                    foreach (Disciplina disciplina in p.Discipline)
                    {
                        string values = $"('{p.ID_Profesor}', '{disciplina.ID_Disciplina}')";
                        valuesList.Add(values);
                    }

                    string valuesString = string.Join(", ", valuesList);
                    insertMappingSQL += valuesString;

                    using (MySqlCommand insertMappingCommand = new MySqlCommand(insertMappingSQL, connection))
                    {
                        insertMappingCommand.ExecuteNonQuery();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Error: {ex.Message}");
                }
            }
        }

        public static bool ExistaProfesorDisciplina(string profesorId, string disciplinaId)
        {
            bool exists = false;

            using (MySqlConnection connection = GetConnection())
            {
                string SQLCommand = "SELECT COUNT(*) FROM profesori_discipline WHERE FK_ID_Profesor = @ProfesorId AND FK_ID_Disciplina = @DisciplinaId";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(SQLCommand, connection))
                    {
                        command.Parameters.AddWithValue("@ProfesorId", profesorId);
                        command.Parameters.AddWithValue("@DisciplinaId", disciplinaId);

                        int count = Convert.ToInt32(command.ExecuteScalar());
                        exists = count > 0;
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Error: {ex.Message}");
                }
            }

            return exists;
        }


        public static List<Profesor> primesteProfesoriDB(ColectieDiscipline colDis)
        {
            List<Profesor> listaProfesori = new List<Profesor>();

            using (MySqlConnection connection = GetConnection())
            {
                string SQLCommand = "SELECT * FROM Profesori";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(SQLCommand, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string profesorId = reader.GetString("ID_Profesor");
                                string numeProfesor = reader.GetString("Nume");

                                Profesor profesor = new Profesor(profesorId, numeProfesor);

                                foreach (Disciplina disciplina in colDis)
                                {
                                    string disciplinaId = disciplina.ID_Disciplina;

                                    if (ExistaProfesorDisciplina(profesorId, disciplinaId))
                                    {
                                        profesor.adaugaDisciplina(disciplina);
                                        disciplina.adaugaProfesor(profesor);
                                    }
                                }

                                listaProfesori.Add(profesor);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Error: {ex.Message}");
                }
            }

            return listaProfesori;
        }

        public static void adaugaSalaDB(Sala sala)
        {
            string SQLCommand = $"INSERT INTO Sali(ID_Sala, Cladire, Cod_Sala, Nr_Locuri) " +
                                $"VALUES('{sala.ID_Sala}', '{sala.Cladire}', '{sala.CodSala}', {sala.NrLocuri})";

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(SQLCommand, connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Error: {ex.Message}");
                }
            }
        }

        public static List<Sala> primesteSaliDB()
        {
            List<Sala> sali = new List<Sala>();

            using (MySqlConnection connection = GetConnection())
            {
                string SQLCommand = "SELECT ID_Sala, Cladire, Cod_Sala, Nr_Locuri FROM Sali";

                try
                {
                    using (MySqlCommand command = new MySqlCommand(SQLCommand, connection))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string idSala = reader.GetString("ID_Sala");
                                string cladire = reader.GetString("Cladire");
                                string codSala = reader.GetString("Cod_Sala");
                                int nrLocuri = reader.GetInt32("Nr_Locuri");

                                Sala sala = new Sala(idSala, cladire, codSala, nrLocuri);
                                sali.Add(sala);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Error: {ex.Message}");
                }
            }

            return sali;
        }

        public static void adaugaSerieDB(Serie serie)
        {
            string insertSerieCommand = $"INSERT INTO Serii(ID_Serie, Denumire_Serie, An_studiu, Nr_grupe) " +
                $"VALUES('{serie.ID_Entitate}', '{serie.Denumire}', {serie.AnStudiu}, {serie.NrGrupe})";

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand insertCommand = new MySqlCommand(insertSerieCommand, connection);
                try
                {
                    insertCommand.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Error: {ex.Message}");
                }
            }
        }

        public static List<Serie> primesteSeriiDB()
        {
            List<Serie> listaSerii = new List<Serie>();

            string selectSeriiCommand = "SELECT * FROM Serii";

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(selectSeriiCommand, connection);
                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string serieID = reader.GetString("ID_Serie");
                            string denumire = reader.GetString("Denumire_Serie");
                            int anStudiu = reader.GetInt32("An_studiu");
                            int nrGrupe = reader.GetInt32("Nr_grupe");

                            Serie serie = new Serie(serieID, denumire, anStudiu, nrGrupe);

                            listaSerii.Add(serie);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Error: {ex.Message}");
                }
            }

            return listaSerii;
        }

        public static void adaugaGrupaDB(Grupa grupa)
        {
            string insertGrupaCommand = $"INSERT INTO Grupe(ID_Grupa, Denumire_grupa, An_studiu, FK_ID_Serie) " +
                $"VALUES('{grupa.ID_Entitate}', '{grupa.Denumire}', {grupa.AnStudiu}, '{grupa.Serie.ID_Entitate}')";

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(insertGrupaCommand, connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Error: {ex.Message}");
                }
            }
        }

        public static List<Grupa> primesteGrupeDB()
        {
            List<Grupa> listaGrupe = new List<Grupa>();

            string selectGrupeCommand = "SELECT g.*, s.* FROM Grupe g " +
                                        "JOIN Serii s ON g.FK_ID_Serie = s.ID_Serie";

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(selectGrupeCommand, connection);
                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string grupaID = reader.GetString("ID_Grupa");
                            string denumire = reader.GetString("Denumire_grupa");
                            int anStudiu = reader.GetInt32("An_studiu");

                            string serieID = reader.GetString("ID_Serie");
                            string serieDenumire = reader.GetString("Denumire_serie");
                            int serieAnStudiu = reader.GetInt32("An_studiu");
                            int nrGrupe = reader.GetInt32("Nr_grupe");

                            Serie serie = new Serie(serieID, serieDenumire, serieAnStudiu, nrGrupe);

                            Grupa grupa = new Grupa(grupaID, denumire, anStudiu, serie);

                            listaGrupe.Add(grupa);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Error: {ex.Message}");
                }
            }

            return listaGrupe;
        }

        public static void adaugaActivitateDB(Activitate activitate)
        {
            string insertActivitateCommand = $"INSERT INTO Activitati(ID_Activitate, FK_ID_Disciplina, FK_ID_Profesor, FK_ID_Entitate, FK_ID_Sala, Zi, `Interval`) " +
                $"VALUES('{activitate.ID_Activitate}', '{activitate.Disciplina.ID_Disciplina}', '{activitate.Profesor.ID_Profesor}', '{activitate.entitate.ID_Entitate}', '{activitate.Sala.ID_Sala}', " +
                $"'{activitate.Zi}', '{activitate.Interval}')";

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(insertActivitateCommand, connection);
                try
                {
                    command.ExecuteNonQuery();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Error: {ex.Message}");
                }
            }
        }



        public static List<Activitate> primesteActivitatiDB(ColectieEntitati colEnt, ColectieDiscipline colDis, ColectieProfesori colProf, ColectieSali colSali)
        {
            List<Activitate> activitati = new List<Activitate>();

            string selectActivitatiCommand = "SELECT ID_Activitate, FK_ID_Disciplina, FK_ID_Profesor, FK_ID_Entitate, FK_ID_Sala, Zi, `Interval` " +
                                             "FROM Activitati";

            using (MySqlConnection connection = GetConnection())
            {
                MySqlCommand command = new MySqlCommand(selectActivitatiCommand, connection);

                try
                {
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string activitateID = reader.GetString("ID_Activitate");
                        string disciplinaID = reader.GetString("FK_ID_Disciplina");
                        string profesorID = reader.GetString("FK_ID_Profesor");
                        string entitateID = reader.GetString("FK_ID_Entitate");
                        string salaID = reader.GetString("FK_ID_Sala");
                        string zi = reader.GetString("Zi");
                        string interval = reader.GetString("Interval");

                        Disciplina disciplina = colDis.FirstOrDefault(dis => dis.ID_Disciplina == disciplinaID);
                        Profesor profesor = colProf.FirstOrDefault(prof => prof.ID_Profesor == profesorID);
                        Entitate entitate = colEnt.FirstOrDefault(ent => ent.ID_Entitate == entitateID);
                        Sala sala = colSali.FirstOrDefault(sal => sal.ID_Sala == salaID);

                        Activitate activitate = new Activitate(entitate, disciplina, profesor, sala, zi, interval);
                        activitati.Add(activitate);
                    }

                    reader.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"MySQL Error: {ex.Message}");
                }
            }

            return activitati;
        }


    }
}
