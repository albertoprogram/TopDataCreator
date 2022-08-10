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
        #region ConnectionString
        internal string ConnectionString(
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

        #region DatabaseTables
        internal List<string> DatabaseTables(string connectionString, string database)
        {
            List<string> tables = new List<string>();

            string sqlStatement = "SELECT name FROM " + database + ".sys.tables";

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
    }
}
