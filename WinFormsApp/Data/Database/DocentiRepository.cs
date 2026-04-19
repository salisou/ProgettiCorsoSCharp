using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.Models;

namespace WinFormsApp.Data.Database
{
    public class DocentiRepository
    {
        private readonly string connectionString = $"Data Source={Path.Combine(Application.StartupPath, "CRMScuola.db")}";

        public DocentiRepository()
        {
            CreateTabella();
        }

        private void CreateTabella()
        {
            using var conn = new SqliteConnection(connectionString);
            conn.Open();

            string sql = @"CREATE TABLE IF NOT EXISTS Docenti(
                            DocenteId INTEGER PRIMARY KEY AUTOINCREMENT,
                            Nome TEXT NOT NULL,
                            Cognome TEXT NOT NULL,
                            Email TEXT,
                            Telefono TEXT,
                            CorsoId INTEGER,
                            FOREIGN KEY (CorsoId) REFERENCES Corsi(CorsoId)
                           );";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public List<Docenti> GetAll()
        {
            List<Docenti> lista = new();

            using var conn = new SqliteConnection(connectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                SELECT d.DocenteId, d.Nome, d.Cognome, d.Email, d.Telefono, d.CorsoId, c.NomeCorso
                FROM Docenti d
                LEFT JOIN Corsi c ON d.CorsoId = c.CorsoId";

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Docenti
                {
                    DocenteId = reader.GetInt32(0),
                    Nome = reader.GetString(1),
                    Cognome = reader.GetString(2),
                    Email = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    Telefono = reader.IsDBNull(4) ? "" : reader.GetString(4),
                    CorsoId = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                    Corsi = new Corsi
                    {
                        NomeCorso = reader.IsDBNull(6) ? "" : reader.GetString(6)
                    }
                });
            }

            return lista;
        }

        public void Insert(Docenti docente)
        {
            using var conn = new SqliteConnection(connectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                INSERT INTO Docenti (Nome, Cognome, Email, Telefono, CorsoId)
                VALUES ($nome, $cognome, $email, $tel, $corso)";

            cmd.Parameters.AddWithValue("$nome", docente.Nome);
            cmd.Parameters.AddWithValue("$cognome", docente.Cognome);
            cmd.Parameters.AddWithValue("$email", docente.Email ?? "");
            cmd.Parameters.AddWithValue("$tel", docente.Telefono ?? "");
            cmd.Parameters.AddWithValue("$corso", docente.CorsoId);

            cmd.ExecuteNonQuery();
        }

        public void Update(Docenti docente)
        {
            using var conn = new SqliteConnection(connectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                UPDATE Docenti
                SET Nome=$nome, Cognome=$cognome, Email=$email, Telefono=$tel, CorsoId=$corso
                WHERE DocenteId=$id";

            cmd.Parameters.AddWithValue("$nome", docente.Nome);
            cmd.Parameters.AddWithValue("$cognome", docente.Cognome);
            cmd.Parameters.AddWithValue("$email", docente.Email ?? "");
            cmd.Parameters.AddWithValue("$tel", docente.Telefono ?? "");
            cmd.Parameters.AddWithValue("$corso", docente.CorsoId);
            cmd.Parameters.AddWithValue("$id", docente.DocenteId);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = new SqliteConnection(connectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Docenti WHERE DocenteId=$id";
            cmd.Parameters.AddWithValue("$id", id);

            cmd.ExecuteNonQuery();
        }
    }
}
