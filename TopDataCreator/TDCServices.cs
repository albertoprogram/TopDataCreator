using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopDataCreator
{
    internal class TDCServices
    {
        #region SetConnectionString
        internal string SetConnectionString(
            string server, string database, bool trusted_connection,
            string userId, string password)
        {
            string connectionString;

            if (trusted_connection)
            {
                connectionString = "Server=" + server + ";Database=" + database +
                ";Trusted_Connection=True;";
            }
            else
            {
                connectionString = "Server=" + server + ";Database=" + database +
                ";User Id=" + userId + ";Password=" + password + ";";
            }

            return connectionString;
        }
        #endregion

        #region GetDatabaseTables
        internal List<string> GetDatabaseTables(string connectionString, string database)
        {
            List<string> tables = new List<string>();

            string sqlStatement = "SELECT name FROM " + database + ".sys.tables ORDER BY name";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.CommandType = CommandType.Text;
                    sqlCommand.CommandText = sqlStatement;
                    sqlCommand.Connection = sqlConnection;

                    sqlConnection.Open();

                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            tables.Add(sqlDataReader.GetString(0));
                        }
                    }
                }
            }

            return tables;
        }
        #endregion

        #region GetTableFields
        public DataTable GetTableFields(string connectionString, string database, string table)
        {
            string sqlStatement = "SELECT COLUMN_NAME,DATA_TYPE,ISNULL(CHARACTER_MAXIMUM_LENGTH,0) AS FIELD_LENGTH FROM " + database + ".INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + table + "' ORDER BY ORDINAL_POSITION";

            DataSet dataSet = new DataSet();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlStatement, sqlConnection);

                sqlDataAdapter.Fill(dataSet);
            }

            return dataSet.Tables[0];
        }
        #endregion
    }
}
