using System;
using System.Data;
using System.Threading.Tasks;
using MySqlConnector;
using System.Data.SqlClient;
using Topcast_Report_Manager.Data;

namespace Topcast_Report_Manager.Workers
{
    public class SqlManagement
    {
        public SqlConnection SqlConnection { get; set; }
        public MySqlConnection MySqlConnection { get; set; }
        public SqlConnConfig SqlConnConfig { get; set; }

        public SqlManagement(SqlConnConfig sqlConnConfig)
        {
            SqlConnConfig = sqlConnConfig;
        }

        public string SqlTestConnection()
        {

            string testResult = "CONNECTION OK";

            if (SqlConnConfig.SqlType == "SQL")
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(SqlConnConfig.SqlConnectionString);
                    SqlCommand command = new SqlCommand("SELECT 1", sqlConnection);
                    sqlConnection.Open();
                    command.ExecuteScalar();
                    sqlConnection.Close();
                }
                catch (Exception ex)
                {
                    testResult = "CONNECTION FAIL";
                    throw new Exception($"SqlManagement.SqlTestConnection - SQL - Test Connection Failed: {ex.Message}");
                }
            }

            if (SqlConnConfig.SqlType == "MySql")
            {
                try
                {
                    MySqlConnection mySqlConnection = new MySqlConnection(SqlConnConfig.SqlConnectionString);
                    mySqlConnection.Open();
                    MySqlCommand cmd = new MySqlCommand("SELECT 1", mySqlConnection);
                    mySqlConnection.Close();
                }
                catch (Exception ex)
                {
                    testResult = "CONNECTION FAIL";
                    throw new Exception($"SqlManagement.SqlTestConnection - MySQL - Test Connection Failed: {ex.Message}");
                }
            }

            return testResult;

        }

        public string SqlGetDbUsage()
        {
            string qry;
            string dbInfo;

            DataTable dataTable = new DataTable();

            if (SqlConnConfig.SqlType == "SQL")
            {

                qry = "exec sp_spaceused";

                try
                {
                    SqlConnection sqlConnection = new SqlConnection(SqlConnConfig.SqlConnectionString);
                    SqlCommand command = new SqlCommand(qry, sqlConnection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    throw new Exception($"SqlManagement.SqlGetDbUsage - MySQL: {ex.Message}");
                }
            }

            if (SqlConnConfig.SqlType == "MySQL")
            {

                qry = $"SELECT table_schema 'database_name', ROUND(SUM(data_length + index_length) / 1024 / 1024, 1) 'database_size' FROM information_schema.tables WHERE TABLE_SCHEMA = '{SqlConnConfig.SqlDbName}';";

                try
                {
                    MySqlConnection mySqlConnection = new MySqlConnection(SqlConnConfig.SqlConnectionString);
                    mySqlConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(qry, mySqlConnection);
                    dataTable.Load(cmd.ExecuteReader());
                    mySqlConnection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception($"SqlManagement.SqlGetDbUsage - MySQL: {ex.Message}");
                }
            }

            dbInfo = $"DATABASE: {dataTable.Rows[0]["database_name"]} SIZE: {dataTable.Rows[0]["database_size"]}";

            return dbInfo;
        }

        public DataTable SqlExecuteQuery(string qry)
        {
            DataTable dataTable = new DataTable();

            if (SqlConnConfig.SqlType == "SQL")
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(SqlConnConfig.SqlConnectionString);
                    SqlCommand command = new SqlCommand(qry, sqlConnection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                }
                catch (Exception ex)
                {
                    throw new Exception($"SqlManagement.SqlExecuteQuery - SQL: {ex.Message}");
                }
            }

            if (SqlConnConfig.SqlType == "MySQL")
            {
                try
                {
                    MySqlConnection mySqlConnection = new MySqlConnection(SqlConnConfig.SqlConnectionString);
                    mySqlConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(qry, mySqlConnection);
                    dataTable.Load(cmd.ExecuteReader());
                    mySqlConnection.Close();
                }
                catch (Exception ex)
                {
                    //MySqlConnection.Close();
                    throw new Exception($"SqlManagement.SqlExecuteQuery - MySQL: {ex.Message}");
                }
            }

            return dataTable;

        }

        public async Task<DataTable> SqlExecuteQueryAsync(string qry)
        {
            DataTable dataTable = new DataTable();

            if (SqlConnConfig.SqlType == "SQL")
            {
                try
                {
                    SqlConnection sqlConnection = new SqlConnection(SqlConnConfig.SqlConnectionString);
                    SqlCommand command = new SqlCommand(qry, sqlConnection);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    await Task.Run(() => dataAdapter.Fill(dataTable));
                }
                catch (Exception ex)
                {
                    throw new Exception($"SqlManagement.SqlExecuteQueryAsync - SQL: {ex.Message}");
                }
            }

            if (SqlConnConfig.SqlType == "MySQL")
            {
                try
                {
                    MySqlConnection mySqlConnection = new MySqlConnection(SqlConnConfig.SqlConnectionString);
                    mySqlConnection.Open();
                    MySqlCommand cmd = new MySqlCommand(qry, mySqlConnection);
                    await Task.Run(() => dataTable.Load(cmd.ExecuteReader()));
                    mySqlConnection.Close();
                }
                catch (Exception ex)
                {
                    //MySqlConnection.Close();
                    throw new Exception($"SqlManagement.SqlExecuteQueryAsync - MySQL: {ex.Message}");
                }
            }

            return dataTable;

        }
    }
}
