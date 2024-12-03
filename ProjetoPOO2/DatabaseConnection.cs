using System;
using MySql.Data.MySqlClient;

public class DatabaseConnection
{
    private static DatabaseConnection _instance;
    private MySqlConnection _connection;
    private string _connectionString;

    private DatabaseConnection()
    {
        _connectionString = "Server=seuserver; Database=SistemaEstoque; Uid=seuusuario; Pwd=suasenha;";
        _connection = new MySqlConnection(_connectionString);
    }

    public static DatabaseConnection GetInstance()
    {
        if (_instance == null)
        {
            _instance = new DatabaseConnection();
        }
        return _instance;
    }

    public void OpenConnection()
    {
        if (_connection.State != System.Data.ConnectionState.Open)
        {
            _connection.Open();
        }
    }

    public void CloseConnection()
    {
        if (_connection.State != System.Data.ConnectionState.Closed)
        {
            _connection.Close();
        }
    }

    public MySqlConnection Connection
    {
        get { return _connection; }
    }
}
