using System;
using System.Data.Odbc;

namespace DataBase_Work
{
    public class DataBase
    {
        public OdbcConnection Connection { get { return _connection; } }

        public string LastError { get; private set; }

        private OdbcConnection _connection = null;

        ~DataBase()
        {
            CloseConnection();
        }

        public string TakeOffQuotes(string connectionString)
        {
            if (connectionString != "")
            {
                int size = connectionString.Length;
                if (connectionString[0] == '\"' && connectionString[size - 1] == '\"')
                {
                    connectionString = connectionString.Remove(size - 1, 1);
                    connectionString = connectionString.Remove(0, 1);
                }
            }
            return connectionString;
        }

        public bool OpenConnection(string connectionString)
        {
            try
            {
                connectionString = TakeOffQuotes(connectionString);
                _connection = new OdbcConnection(connectionString);
                _connection.Open();
            }
            catch(Exception e)
            {
                LastError = e.Message;
                return false;
            }
            return true;
        }

        public void CloseConnection()
        {
            if (_connection != null)
            {
                try
                {
                    _connection.Close();
                }
                catch (Exception e)
                {
                    LastError = e.Message;
                }
            }
        }

        public void ExecuteNonQuery(string query)
        {
            OdbcCommand com = new OdbcCommand(query, _connection);
            com.ExecuteNonQuery();
        }

        public OdbcDataReader DataReader(string query)
        {
            OdbcCommand com = new OdbcCommand(query, _connection);
            return com.ExecuteReader();
        }

        public class Test
        {
            public string LastError { get; private set; }

            private static string testQuery = "select count(*) from systables";

            public bool TestCurrentConnection(int dataBaseIndex)
            {
                string connectionString =
                                SettingsSave.
                                single.
                                dataBase_WorkSettings.
                                dataBaseSettings[dataBaseIndex].
                                connectionString;
                DataBase db = new DataBase();
                try
                {
                    if(!db.OpenConnection(connectionString))
                    {
                        LastError = db.LastError;
                        return false;
                    }
                    OdbcDataReader dataReader = db.DataReader(testQuery);
                    dataReader.Read();
                    if (dataReader[0].ToString() == "")
                    {
                        LastError = "Error! Something occur in the '" +
                            SettingsSave.
                            single.
                            dataBase_WorkSettings.
                            dataBaseSettings[dataBaseIndex].
                            name +
                            "' database";
                        db.CloseConnection();//HOW TO WRITE IT BETTER
                        return false;
                    }
                    db.CloseConnection();
                }
                catch (Exception e)
                {
                    LastError = e.Message;
                    return false;
                }
                return true;
            }

            public bool TestAllConnection(int[] dataBaseIndexes)
            {
                int size = dataBaseIndexes.Length;
                for (int i = 0; i < size; i++)
                {
                    if (!TestCurrentConnection(dataBaseIndexes[i]))
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
