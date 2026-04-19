using Microsoft.Data.Sqlite;
using WinFormsApp.Models;

namespace CRMScuola.Data.Database
{
    public class CorsiRepository
    {
        //private readonly string connectionString = "Data Source=CRMScuola.db;";
        private readonly string connectionString = $"Data Source={Path.Combine(Application.StartupPath, "CRMScuola.db")}";


        public CorsiRepository()
        {
            CreateTablla();
        }

        private void CreateTablla()
        {
            using var conn = new SqliteConnection(connectionString);
            conn.Open();

            string sql = @"CREATE TABLE IF NOT EXISTS Corsi(
                            CorsoId INTEGER PRIMARY KEY AUTOINCREMENT,
                            NomeCorso TEXT NOT NULL,
                            Descrizione TEXT
                           );";

            using var cmd = new SqliteCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }

        public void Init()
        {
            using var conn = new SqliteConnection(connectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                                CREATE TABLE IF NOT EXISTS Corsi (
                                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                    NomeCorso TEXT NOT NULL,
                                    Descrizione TEXT
                                );";

            cmd.ExecuteNonQuery();
        }

        public List<Corsi> GetAll()
        {
            List<Corsi> lista = new();

            using var conn = new SqliteConnection(connectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT CorsoId, NomeCorso, Descrizione FROM Corsi";
            
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                lista.Add(new Corsi
                {
                    CorsoId = reader.GetInt32(0),
                    NomeCorso = reader.GetString(1),
                    Descrizione = reader.IsDBNull(2) ? "" : reader.GetString(2)
                });
            }

            return lista;
        }

        public void Insert(Corsi corso)
        {
            using var conn = new SqliteConnection(connectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                                INSERT INTO Corsi (NomeCorso, Descrizione)
                                VALUES ($nome, $desc)";

            cmd.Parameters.AddWithValue("$nome", corso.NomeCorso ?? "");
            cmd.Parameters.AddWithValue("$desc", corso.Descrizione ?? "");

            cmd.ExecuteNonQuery();
        }

        public void Update(Corsi corso)
        {
            using var conn = new SqliteConnection(connectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = @"
                              UPDATE Corsi
                              SET NomeCorso = $nome,
                              Descrizione = $desc
                              WHERE CorsoId = $id";

            cmd.Parameters.AddWithValue("$nome", corso.NomeCorso ?? "");
            cmd.Parameters.AddWithValue("$desc", corso.Descrizione ?? "");
            cmd.Parameters.AddWithValue("$id", corso.CorsoId);

            cmd.ExecuteNonQuery();
        }

        public void Delete(int id)
        {
            using var conn = new SqliteConnection(connectionString);
            conn.Open();

            var cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Corsi WHERE CorsoId = $id";

            cmd.Parameters.AddWithValue("$id", id);

            cmd.ExecuteNonQuery();
        }
    }
}
