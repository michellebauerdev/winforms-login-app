using Microsoft.Data.Sqlite;
using BC = BCrypt.Net.BCrypt;

public class DatabaseHelper
{
    private string connectionString = "Data Source=users.db";

    public void InitializeDatabase()
    {
        using var conn = new SqliteConnection(connectionString);
        conn.Open();
        string sql = @"CREATE TABLE IF NOT EXISTS users (
            id       INTEGER PRIMARY KEY AUTOINCREMENT,
            username TEXT NOT NULL UNIQUE,
            password TEXT NOT NULL,
            email    TEXT
        )";
        using var cmd = new SqliteCommand(sql, conn);
        cmd.ExecuteNonQuery();
    }

    public bool Register(string username, string password, string email)
    {
        try
        {
            string hashed = BC.HashPassword(password);
            using var conn = new SqliteConnection(connectionString);
            conn.Open();
            string sql = "INSERT INTO users (username, password, email) VALUES (@u, @p, @e)";
            using var cmd = new SqliteCommand(sql, conn);
            cmd.Parameters.AddWithValue("@u", username);
            cmd.Parameters.AddWithValue("@p", hashed);
            cmd.Parameters.AddWithValue("@e", email);
            cmd.ExecuteNonQuery();
            return true;
        }
        catch (SqliteException)
        {
            return false;
        }
    }

    public bool Login(string username, string password)
    {
        using var conn = new SqliteConnection(connectionString);
        conn.Open();
        string sql = "SELECT password FROM users WHERE username = @u";
        using var cmd = new SqliteCommand(sql, conn);
        cmd.Parameters.AddWithValue("@u", username);
        var result = cmd.ExecuteScalar();
        if (result == null) return false;
        return BC.Verify(password, result.ToString());
    }
}