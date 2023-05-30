using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;

public class DataBaseUtils
{
    private static OracleConnection connection;
    private static DataTable dataTable;

    public static void ConnectToOracle(String connectionString)
    {
        if (connection == null )
        {
            try
            {
                connection = new OracleConnection(connectionString);
                connection.Open();
            }
            catch (OracleException e)
            {
                Console.WriteLine("Exception in Connection: " + e.Message);
            }
        }
    }

    public static void closeConnection()
    {
        try
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
        catch (OracleException e)
        {
            Console.WriteLine("Exception in CLOSING the Connection: " + e.Message);
        }
    }

    public static DataTable RunQuery(String query)
    {
        try
        {
            using (OracleCommand command = new OracleCommand(query, connection))
            {
                using (OracleDataReader reader = command.ExecuteReader())
                {
                    DataTable results = new DataTable();
                    results.Load(reader);
                    dataTable = results;
                    return results;
                }
            }
        }
        catch (OracleException e)
        {
            Console.WriteLine("Exception in RUNNING Query: " + e.Message);
            return null;
        }
        finally
        {
            closeConnection();
        }
    }
}
