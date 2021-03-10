using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DataBase_Work.nsHistory;
using static DataBase_Work.nsHistory.History;
using System.Diagnostics;
using DataBase_Work.Utility;
using System.IO;
using static DataBase_Work.DataBaseThreading;
using System.Text.RegularExpressions;
using System.Globalization;

namespace DataBase_Work
{
    public partial class FormDataBaseWork : Form
    {
        public class SaveFileStruct
        {
            public string pathToDir { get; set; }
            public bool isHeader { get; set; }
            public string separator { get; set; }
            public string type { get; set; }
            public string query { get; set; }
            public int connectionCount { get; set; }
            public List<Tuple<string, string>> DBDescription { get; set; }
        }
        private SaveFileStruct saveFileStruct;
        public static FormDataBaseWork simple;

        public FormDataBaseWork()
        {
            InitializeComponent();
            simple = this;
            SettingsSave.single.NewDataAdded += LoadDataBaseNames;
            DataBaseThreading.ProgressBarRunQuery = progressBarRunQuery;
        }
        
        private void editDataBasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormEditDataBases().Show();
        }

        private void LoadDataBaseNames()
        {
            checkedListBoxDataBase.Items.Clear();
            int size = SettingsSave.single.dataBase_WorkSettings.dataBaseSettings.Count();
            for (int i = 0; i < size; i++)
            {
                checkedListBoxDataBase.Items.Add(SettingsSave.single.dataBase_WorkSettings.dataBaseSettings[i].name);
            }
        }

        private void FormDataBaseWork_Load(object sender, EventArgs e)
        {
            richTextBoxQuery.Text = SettingsSave.single.dataBase_WorkSettings.dataBaseLastQuery.query;

            LoadDataBaseNames();
        }

        private void FormDataBaseWork_FormClosing(object sender, FormClosingEventArgs e)
        {
            SettingsSave.single.dataBase_WorkSettings.dataBaseLastQuery.query = richTextBoxQuery.Text;
        }
        
        private List<Tuple<string, string>> GetConnectionStringFromCheckedBoxListDataBase()
        {
            List<Tuple<string, string>> result = new List<Tuple<string, string>>();
            int CBLCount = checkedListBoxDataBase.Items.Count;
            for (int i = 0; i < CBLCount; i++)
            {
                if (
                    checkedListBoxDataBase.GetItemCheckState(i) ==
                    CheckState.Checked
                    )
                {
                    result.Add(
                     Tuple.Create(
                        SettingsSave.single.dataBase_WorkSettings.dataBaseSettings[i].name,
                        SettingsSave.single.dataBase_WorkSettings.dataBaseSettings[i].connectionString
                        ));
                }
            }
            return result;
        }

        public void SetResultsToPagesWithoutSaving(HistoryStruct hs, string status)
        {
            SetResultsToPagesWithoutSaving(hs.dataSet.Tables[0], hs.log, hs.dbName, status);
        }

        public void SetResultsToPagesWithoutSaving(
            DataTable dataTable,
            string log,
            string dbName,
            string status = "Current"
            )
        {
            if (tabControlResult.TabPages.ContainsKey(dbName))
            {
                tabControlResult.TabPages.RemoveByKey(dbName);
                tabControlLog.TabPages.RemoveByKey(dbName);
            }

            labelLogStatusValue.Text =
            labelResultStatusValue.Text =
            status;

            /* Result */
            TabPage tp = new TabPage(dbName);
            tabControlResult.TabPages.Add(tp);
            tp.Name = dbName;

            DataGridView dgv = new DataGridView();
            dgv.Dock = DockStyle.Fill;
            dgv.DataSource = dataTable;

            tp.Controls.Add(dgv);
            /* Result */

            /* Log */
            tp = new TabPage(dbName);
            tabControlLog.TabPages.Add(tp);
            tp.Name = dbName;

            RichTextBox rtb = new RichTextBox();
            rtb.Dock = DockStyle.Fill;
            rtb.Text = log;

            tp.Controls.Add(rtb);
            /* Log */
        }

        public void SetResultsToPages(HistoryStruct hs, string status)
        {
            SetResultsToPages(hs.dataSet.Tables[0], hs.log, hs.dbName, status);
        }

        private Utility.Console console;
        private bool keyCompleted = false;
        private static int completedWork = 0;
        private const int getByOneRequest = 15000;
        private static int requestCount = 0;
        public void SetResultsToFiles(
            DataTable dataTable,
            string log,
            string dbName,
            string status = "Current")
        {
            try
            {
                if (dataTable.Rows.Count == 0)
                {
                    saveFileStruct.DBDescription.
                        RemoveAll(item => item.Item1 == dbName);
                    saveFileStruct.connectionCount--;
                    DataBaseThreading.ResetQueryDone(saveFileStruct.connectionCount);
                    console.Add($"\n\n\n\n\n\n***\nThe {dbName} has been completed work\n***\n\n\n\n\n\n");
                }

                if (saveFileStruct.DBDescription.Count == 0 && !keyCompleted)
                {
                    keyCompleted = true;
                    console.Add("\n\n\n\n\n\n***\nFiles were saved\n***\n\n\n\n\n\n");
                    MessageBox.Show("Files were saved", "Success!");
                    return;
                }

                dbName = UtilityFile.RemoveInvalidChars(dbName);

                SaveAllFiles(
                    dataTable,
                    dbName,
                    saveFileStruct.pathToDir,
                    saveFileStruct.isHeader,
                    saveFileStruct.separator,
                    saveFileStruct.type);

                completedWork++;
                if (saveFileStruct.connectionCount == completedWork)
                {
                    saveFileStruct.isHeader = false;
                    requestCount++;
                    var limit = $"SELECT SKIP {getByOneRequest * requestCount} " +
                        $"FIRST {getByOneRequest} ";

                    var regex = new Regex(Regex.Escape("SELECT "), RegexOptions.IgnoreCase);
                    var query = regex.Replace(saveFileStruct.query, limit, 1);

                    Run(query, SetResultsToFiles, saveFileStruct.DBDescription);

                    completedWork = 0;
                }
                console.Add($"+++\ndbName = {dbName}\ngetByOneRequest = {getByOneRequest}\nrequestCount = {requestCount}\n");
            }
            catch (Exception e)
            {
                console.Add($"\n\n\n ERROR!\n{e.Message} \n\n\n");
            }
        }

        public void SetResultsToPages(
            DataTable dataTable, 
            string log, 
            string dbName, 
            string status = "Current"
            )
        {
            Save(dataTable, log, dbName);
            SetResultsToPagesWithoutSaving(dataTable, log, dbName, status);
        }

        private void Run(string text, DataBaseDelegateResults results, List<Tuple<string, string>> DBDescription)
        {
            RunQuery(
                DBDescription,
                text,
                results
                );
        }

        private void Run(string text, DataBaseDelegateResults results)
        {
            List<Tuple<string, string>> DBDescription =
                GetConnectionStringFromCheckedBoxListDataBase();
            Run(
                text,
                results,
                DBDescription
                );
        }
        
        private void buttonRun_Click(object sender, EventArgs e)
        {
            Run(richTextBoxQuery.Text, SetResultsToPages);
        }

        private void buttonRunSelected_Click(object sender, EventArgs e)
        {
            Run(richTextBoxQuery.SelectedText, SetResultsToPages);
        }

        private void buttonCheckDataBase_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonQueryClear_Click_1(object sender, EventArgs e)
        {
            richTextBoxQuery.Clear();
        }

        private void buttonHistoryLog_Click(object sender, EventArgs e)
        {
            new FormHistory().Show();
        }

        private void buttonHistoryResult_Click(object sender, EventArgs e)
        {
            new FormHistory().Show();
        }

        private void SaveAllFiles(
            DataTable dt,
            string fileName,
            string pathToDir,
            bool isHeader,
            string separator,
            string type)
        {
            var currentFile = pathToDir + @"\" + fileName + "." + type;
            UtilityCSV.ToCSV2(dt, currentFile, isHeader, separator);
        }
        
        private void SaveAllFiles(
            string pathToDir, 
            bool isHeader, 
            string separator,
            string type)
        {
            int pagesCount = tabControlResult.TabPages.Count;
            UtilityFile.CreateDir(pathToDir);
            for (int i = 0; i < pagesCount; i++)
            {
                var currentPage = 
                    tabControlResult.
                    TabPages[i];
                var currentFileName = 
                    currentPage.Name;
                DataTable dt =
                    (DataTable)
                    ((DataGridView)currentPage.
                    Controls[0]).
                    DataSource;
                SaveAllFiles(
                    dt, 
                    currentFileName, 
                    pathToDir, 
                    isHeader, 
                    separator, 
                    type);              
            }
        }

        private void buttonSaveAllResult_Click(object sender, EventArgs e)
        {
            new SaveFile(SaveAllFiles).Show();            
        }
        
        private int GetConnectionCount()
        {
            int result = 0;
            int CBLCount = checkedListBoxDataBase.Items.Count;
            for (int i = 0; i < CBLCount; i++)
            {
                if (
                    checkedListBoxDataBase.GetItemCheckState(i) ==
                    CheckState.Checked
                    )
                {
                    result++;
                }
            }
            return result;
        }

        private void buttonRunToFile_Click(object sender, EventArgs e)
        {
            completedWork = 0;
            
            saveFileStruct = new SaveFileStruct();

            saveFileStruct.DBDescription =
                GetConnectionStringFromCheckedBoxListDataBase();
            new SaveFile(
                (string pathToDir,
                    bool isHeader,
                    string separator,
                    string type) => 
                {
                    saveFileStruct.pathToDir = pathToDir;
                    saveFileStruct.isHeader = isHeader;
                    saveFileStruct.separator = separator;
                    saveFileStruct.type = type;                    
                    saveFileStruct.query = richTextBoxQuery.Text;
                    saveFileStruct.connectionCount = GetConnectionCount();
                    UtilityFile.CreateDir(pathToDir);
                    var query = saveFileStruct.query + " LIMIT " + getByOneRequest;
                    Run(query, SetResultsToFiles, saveFileStruct.DBDescription);
                    var strPathToLog = saveFileStruct.pathToDir + @"\log.txt";
                    console = new Utility.Console(strPathToLog);
                    console.Show();
                }).Show();            
        }

        private void buttonRunSelectedToFile_Click(object sender, EventArgs e)
        {
            /*зберегти у файл великий запит*/
        }

        private string GetQueryForInsert(bool isNullAllow = true)
        {
            var dgv = (DataGridView)tabControlResult.SelectedTab.Controls[0];
            var dt = (DataTable)dgv.DataSource;
            var tableName = dt.TableName;
            if (tableName == string.Empty)
            {
                tableName = "UNKNOW_TABLE";
            }

            string[] fieldNames = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToArray();

            var _RIA = dt.Rows[dgv.CurrentCell.RowIndex].ItemArray;// row -> item array

            string[] fieldValues = _RIA.Select(
                (c) =>
                {
                    var s = c.ToString();
                    return s == string.Empty ? "null" : s;
                }).ToArray();
            
            List<string> fieldNames2 = new List<string>();
            List<string> fieldValues2 = new List<string>();
            int _len = fieldNames.Length;
            for (int i = 0; i < _len; i++)
            {
                if (!isNullAllow && fieldValues[i] == "null")
                {
                    continue;
                }

                Type t = dt.Columns[i].DataType;
                fieldNames2.Add(fieldNames[i]);

                if (t == typeof(string))
                {
                    fieldValues2.Add($"\"{fieldValues[i].ToString().Replace("\"", "\"\"")}\"");
                }
                else if (t == typeof(DateTime) || t == typeof(TimeSpan))
                {
                    var _date = Convert.ToDateTime(fieldValues[i]).ToString(UtilityDateTime.DataTimeFormat);
                    var _val = $"TO_DATE(\"{_date}\", \"%d.%m.%Y %H:%M:%S\")";
                    fieldValues2.Add(_val);
                }
                else if(t == typeof(bool))
                {
                    var _val = Convert.ToBoolean(fieldValues[i]) ? "t" : "f";
                    fieldValues2.Add($"\"{_val}\"");
                }
                else if(t == typeof(float) || t == typeof(double) || t == typeof(decimal))
                {
                    fieldValues2.Add(
                        Convert.ToDecimal(fieldValues[i]).
                        ToString("F16", CultureInfo.CreateSpecificCulture("en-US"))
                        );
                }
                else
                {
                    fieldValues2.Add(fieldValues[i]);
                }

            }
            fieldNames = fieldNames2.ToArray();
            fieldValues = fieldValues2.ToArray();

            string sFieldNames = string.Join(", ", fieldNames);
            string sFieldValues = string.Join(", ", fieldValues);

            return $"INSERT INTO {tableName}({sFieldNames}) VALUES({sFieldValues})";
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            var result = GetQueryForInsert();
            Clipboard.SetText(result);
        }

        private void buttonCopyWithoutNulls_Click(object sender, EventArgs e)
        {
            var result = GetQueryForInsert(false);
            Clipboard.SetText(result);
        }
    }
}
