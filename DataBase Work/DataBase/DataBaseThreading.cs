using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DataBase_Work
{
    class DataBaseThreading
    {
        public delegate void DataBaseDelegate0(int percentage);
        public delegate void DataBaseDelegateResults(
            DataTable dataTable, 
            string log, 
            string DBName, 
            string status
            );
         
        public static ProgressBar ProgressBarRunQuery
        {
            set { ProgressBarRunQuery_pri = value; }
            get { return ProgressBarRunQuery_pri; }
        }
        private static ProgressBar ProgressBarRunQuery_pri;
        private static BackgroundWorker backgroundWorkerRunQuery;
        private static int queryCount = 0;
        private static int queryDone = 0;

        private static void Clear()
        {
            ProgressBarRunQuery_pri.Value = queryDone = queryCount = 0;
            backgroundWorkerRunQuery = null;
        }

        private static void ThreadRunQuery_DoWork(object sender, DoWorkEventArgs e)
        {
            string log;

            DataBase db = new DataBase();
            DataTable dataTable = new DataTable();
            OdbcDataReader dr = null;

            List<object> Arguments = e.Argument as List<object>;
            string query = Arguments[0] as string;

            query = query.ToLower();

            var _template = @"(?<=(?:from|join)[\s(]+)(?>\w+)(?=[\s)]*(?:\s+(?:as\s+)?\w+)?(?:$|\s+(?:where|on|(?:left|right)?\s+(?:(?:outer|inner)\s+)?join)))";

            Regex patternGetTableName = new Regex(_template);

            dataTable.TableName = patternGetTableName.
                Match(query).
                Value.
                Replace("from", "").
                Replace(" ", "");

            string connectionString = Arguments[1] as string;

            if (db.OpenConnection(connectionString))
            {
                log = "The application connected to the '" +
                    Arguments[3] +
                    "' database using this connection string: '" +
                    connectionString +
                    "'\n\n";
            }
            else
            {
                log = "Error! The application cannot be connected to the '" +
                    Arguments[3] +
                    "' database using this connection string: '" +
                    connectionString +
                    "'\n\n";
                db = null;
            }

            try
            {
                dr = db.DataReader(query);

                log += "The \"" + query + "\" query is successfully done!\n\n";

                int fieldCount = dr.FieldCount;

                for (int i = 0; i < fieldCount; i++)
                {
                    dataTable.Columns.Add(dr.GetName(i));
                    dataTable.Columns[i].DataType = dr.GetFieldType(i);
                }

                while (dr.Read())
                {
                    DataRow dataRow = dataTable.NewRow();
                    for (int i = 0; i < fieldCount; i++)
                    {
                        dataRow[i] = dr[i]; 
                    }
                    dataTable.Rows.Add(dataRow);
                }
            }
            catch (Exception exception)
            {
                log += "Error! " + exception + "\n\n";
            }

            if (db != null)
            {
                db.CloseConnection();
                log += "The application unconnected from the database that used this connection string: '" +
                        connectionString +
                        "'\n\n";
            }

            List<object> results = new List<object>();
            results.Add(log);
            results.Add(dataTable);
            results.Add(Arguments[2]);
            results.Add(Arguments[3]);

            int percentage = (++queryDone) * 100 / queryCount;
            /*Hot Fix*/
            if (percentage > 100) percentage = 100;
             DataBaseDelegate0 delegateProgressChanged = new DataBaseDelegate0(ThreadRunQuery_ProgressChanged);
            ProgressBarRunQuery.Invoke(delegateProgressChanged, percentage);

            e.Result = results;
        }

        private static bool CheckWorkerCompleted(RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled == true)
            {
                MessageBox.Show(
                    "The task is cancelled!",
                    "Cancelled",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
            else if (e.Error != null || e.Result == null)
            {
                MessageBox.Show(
                    "Error! " + (null == e.Error ? "Unknown" : e.Error.Message),
                    "Error!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                return true;
            }
            return false;
        }

        //private static void ThreadRunQuery_WorkerCompletedToFile(object sender, RunWorkerCompletedEventArgs e)
        //{

        //}

        private static void ThreadRunQuery_WorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(CheckWorkerCompleted(e))
            {
                List<object> results = e.Result as List<object>;
                DataTable dataTable = results[1] as DataTable;
                string log = results[0] as string;
                string DBName = results[3] as string;

                DataBaseDelegateResults SetResultsToPages = 
                    results[2] as DataBaseDelegateResults;
                SetResultsToPages(dataTable, log, DBName, "Current");
            }
        }

        private static void ThreadRunQuery_ProgressChanged(int percentage)
        {
            ProgressBarRunQuery.Value = percentage;
        }

        //public static void RunQueryToFile(
        //    List<Tuple<string, string>> DBDescription,
        //    string query,
        //    DataBaseDelegateResults results)
        //{
        //    Clear();
        //    queryCount = DBDescription.Count;
        //    for (int i = 0; i < queryCount; i++)
        //    {
        //        query += " LIMIT 10";//from to
        //        List<object> arguments = new List<object>();
        //        arguments.Add(query);
        //        arguments.Add(DBDescription[i].Item2);
        //        arguments.Add(results);
        //        arguments.Add(DBDescription[i].Item1);

        //        backgroundWorkerRunQuery =
        //            new BackgroundWorker();
        //        backgroundWorkerRunQuery.DoWork +=
        //            new DoWorkEventHandler(ThreadRunQuery_DoWork);
        //        backgroundWorkerRunQuery.RunWorkerCompleted +=
        //            new RunWorkerCompletedEventHandler(ThreadRunQuery_WorkerCompleted);
        //        backgroundWorkerRunQuery.WorkerReportsProgress = true;
        //        backgroundWorkerRunQuery.RunWorkerAsync(arguments);
        //    }
        //}

        public static void ResetQueryDone(int queryDone)
        {
            DataBaseThreading.queryDone = queryDone;
        }

        public static void RunQuery(
            List<Tuple<string, string>> DBDescription,
            string query,
            DataBaseDelegateResults results)
        {
            Clear();
            queryCount = DBDescription.Count;
            for (int i = 0; i < queryCount; i++)
            {
                List<object> arguments = new List<object>();
                arguments.Add(query);
                arguments.Add(DBDescription[i].Item2);
                arguments.Add(results);
                arguments.Add(DBDescription[i].Item1);

                backgroundWorkerRunQuery = 
                    new BackgroundWorker();
                backgroundWorkerRunQuery.DoWork += 
                    new DoWorkEventHandler(ThreadRunQuery_DoWork);                
                backgroundWorkerRunQuery.RunWorkerCompleted += 
                    new RunWorkerCompletedEventHandler(ThreadRunQuery_WorkerCompleted);
                backgroundWorkerRunQuery.WorkerReportsProgress = true;
                backgroundWorkerRunQuery.RunWorkerAsync(arguments);
            }
        }
    }
}
