using System;
using System.Collections.Generic;
using System.Text;

using MySqlConnector;

class DBConnection : IDisposable
{

    // Using the default config of XAMPP.
    // Change these settings if you made changes
    private string dbName = "cakestore";
    private string username = "root";
    private string password = "";
    private string host = "localhost";




    public readonly MySqlConnection Connection;

    public DBConnection()
    {
        string conn = string.Format("server={0};user={1};password={2};database={3}", host, username,password, dbName);
        Connection = new MySqlConnection(conn);
    }

    public void Dispose()
    {
        Connection.Close();
    }

}