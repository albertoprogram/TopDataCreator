using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace TopDataCreator
{
    internal class TDCServices
    {
        #region Constants
        const string LoremIpsum = @"Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.";
        #endregion

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

        #region GetLorem
        public string GetLorem(int totalLength)
        {
            string value = string.Empty;

            while (value.Length < totalLength)
            {
                value += LoremIpsum + " ";
            }

            value = value.Substring(0, totalLength);

            if (value.Substring(value.Length - 1) == " ")
            {
                int finalPosition = value.Length - 1;
                char replacementValue = 'z';

                StringBuilder stringBuilder = new StringBuilder(value);

                stringBuilder[finalPosition] = replacementValue;

                value = stringBuilder.ToString();
            }

            return value;
        }
        #endregion

        #region InsertData
        public void InsertData(string connectionString, List<string> sqlStatements)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                foreach (string statement in sqlStatements)
                {
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        sqlCommand.CommandText = statement;
                        sqlCommand.Connection = sqlConnection;

                        sqlCommand.ExecuteNonQuery();
                    }
                }
            }
        }
        #endregion
    }
}
