using System;
using System.Data.SQLite;
using System.IO;

public void CreateDatabaseFromSQL(string databaseFile, string sqlFile)
{
    if (File.Exists(databaseFile))
    {
        File.Delete(databaseFile);
    }

    SQLiteConnection.CreateFile(databaseFile);

    string sql = File.ReadAllText(sqlFile);

    using (SQLiteConnection conn = new SQLiteConnection($"Data Source={databaseFile};Version=3;"))
    {
        conn.Open();
        using (SQLiteCommand cmd = new SQLiteCommand(conn))
        {
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }
    }
}

// Usage example:
string databaseFile = "C:\\Users\\ADMIN\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\passbook_data.db";
string sqlFile = "C:\\Users\\ADMIN\\source\\repos\\WindowsFormsApp1\\WindowsFormsApp1\\Passbook_data.sql";
CreateDatabaseFromSQL(databaseFile, sqlFile);
