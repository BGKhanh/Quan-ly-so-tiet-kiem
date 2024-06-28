using System;
using System.Data.SQLite;

public class DatabaseManager
{
    private static DatabaseManager instance = null;
    private static readonly object padlock = new object();
    private SQLiteConnection connection;
    private string connectionString = "Data Source=DATA.db;Version=3;";

    private DatabaseManager()
    {
        connection = new SQLiteConnection(connectionString);
    }

    public static DatabaseManager Instance
    {
        get
        {
            lock (padlock)
            {
                if (instance == null)
                {
                    instance = new DatabaseManager();
                }
                return instance;
            }
        }
    }

    public SQLiteConnection GetConnection()
    {
        return connection;
    }

    public void OpenConnection()
    {
        if (connection.State == System.Data.ConnectionState.Closed)
        {
            connection.Open();
        }
    }

    public void CloseConnection()
    {
        if (connection.State == System.Data.ConnectionState.Open)
        {
            connection.Close();
        }
    }

    public void ExecuteNonQuery(string query, SQLiteParameter[] parameters = null)
    {
        try
        {
            OpenConnection();
            using (var command = new SQLiteCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                command.ExecuteNonQuery();
            }
        }
        catch (Exception ex)
        {
            // Log error (you can use a logging library here)
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
        finally
        {
            CloseConnection();
        }
    }

    public SQLiteDataReader ExecuteQuery(string query, SQLiteParameter[] parameters = null)
    {
        SQLiteDataReader reader = null;
        try
        {
            OpenConnection();
            using (var command = new SQLiteCommand(query, connection))
            {
                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }
                reader = command.ExecuteReader();
            }
        }
        catch (Exception ex)
        {
            // Log error (you can use a logging library here)
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        return reader;
    }
}
