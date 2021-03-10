using DataBase_Work.Utility;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using static DataBase_Work.nsHistory.History.HistorySettings;

namespace DataBase_Work.nsHistory
{
    public class History
    {
        public static string dirHistory = "History";

        public class HistoryStruct
        {
            public DataSet dataSet;
            public string log;
            public string dbName;
        }

        public class HistorySettings
        {
            public class StringValue
            {
                public static implicit operator StringValue(string address)
                {
                    return new StringValue(address);
                }

                public override string ToString()
                {
                    return Value;
                }

                public StringValue(string s)
                {
                    _value = s;
                }
                public string Value { get { return _value; } set { _value = value; } }
                string _value;
            }

            [NonSerialized]
            public static HistorySettings single;
            [NonSerialized]
            private static string hsPathToFile = dirHistory + "/HistorySettings.json";

            public List<StringValue> fileName { get; set; }

            public static void AddFile(StringValue hsFileName)
            {
                single.fileName.Add(hsFileName);
            }

            static HistorySettings()
            {
                string fileValue = "";
                if (File.Exists(hsPathToFile))
                {
                    fileValue = File.ReadAllText(hsPathToFile);
                }
                HistorySettings hs = JsonConvert.DeserializeObject<HistorySettings>(fileValue);
                if(hs == null)
                {
                    single = new HistorySettings();
                    single.fileName = new List<StringValue>();
                    single.fileName.Add("Current");
                }
                else
                {
                    single = hs;
                    single.fileName.Insert(0, "Current");                    
                }
            }
            ~HistorySettings()
            {
                single.fileName.RemoveAt(0);
                string json = JsonConvert.SerializeObject(single);
                File.WriteAllText(hsPathToFile, json);
            }
        }

        public static void Save(DataTable dataTable, string log, string dbName)
        {
            HistoryStruct st = new HistoryStruct();
            DataSet ds = new DataSet();
            ds.Tables.Add(dataTable);
            st.dataSet = ds;
            st.log = log;
            st.dbName = dbName;
            StringValue fileName = dirHistory + "/History " +
                 UtilityDateTime.GetCurrentTime() +
                ".json";
            string json = JsonConvert.SerializeObject(st);
            File.WriteAllText(fileName.ToString(), json);
            AddFile(fileName);
        }

        public static HistoryStruct Read()
        {
            return null;
        }
    }
}
