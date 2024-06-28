using System;
using System.Data.SQLite;
using System.IO;

public class DatabaseManager
{
    private static DatabaseManager instance = null;
    private static readonly object padlock = new object();
    private SQLiteConnection connection;
    private string connectionString = "Data Source=DATA.db;Version=3;";

    DatabaseManager()
    {
        // Đường dẫn tới tệp DATA.db trong thư mục dự án
        string projectDbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\DATA.db");

        // Đường dẫn tới tệp DATA.db trong thư mục chạy hiện tại (bin\Debug hoặc bin\Release)
        string executableDbPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DATA.db");

        // Nếu tệp không tồn tại trong thư mục chạy hiện tại, sao chép từ thư mục dự án
        if (!File.Exists(executableDbPath) && File.Exists(projectDbPath))
        {
            File.Copy(projectDbPath, executableDbPath, true);
        }

        // Sử dụng tệp DATA.db trong thư mục chạy hiện tại
        connectionString = $"Data Source={executableDbPath};Version=3;";
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
