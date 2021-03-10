using DataBase_Work.Utility;
using Newtonsoft.Json;
using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using static DataBase_Work.nsHistory.History;

namespace DataBase_Work.nsHistory
{
    public partial class FormHistory : Form
    {
        public FormHistory()
        {
            InitializeComponent();
            dataGridViewHistory.DataSource = HistorySettings.single.fileName;
            dataGridViewHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            string path = (string)dataGridViewHistory.SelectedCells[0].Value;

            if(dataGridViewHistory.Rows.Count <= 1)
            {
                return;
            }

            if (path == "Current")
            {
                path = (string)dataGridViewHistory.Rows[1].Cells[0].Value;
            }

            string json;

            if (File.Exists(path))
            {
                json = File.ReadAllText(path);
            }
            else
            {
                throw new Exception(
                    "Error! According to this path: \"" + 
                    path + 
                    "\" file not found");
            }

            HistoryStruct hs = 
                JsonConvert.DeserializeObject<HistoryStruct>(json);

            /* the 24 char is xx_xx_xx xx_xx_xxxx.json */
            int startInd = path.Length - 24;
            /* the 19 char is xx_xx_xx xx_xx_xxxx */
            path = path.Substring(startInd, 19);

            DateTime dt = DateTime.ParseExact(
                path,
                UtilityDateTime.DataFormat,
                CultureInfo.InvariantCulture
                );
            
            string date =
                "Date: " + dt.ToString("dd:MM:yyyy") +
                " Time: " + dt.ToString("HH:mm:ss");

            FormDataBaseWork.simple.SetResultsToPagesWithoutSaving(hs, date);

            Close();
        }

        private void dataGridViewHistory_DoubleClick(object sender, EventArgs e)
        {
            buttonSelect_Click(sender, e);
        }
    }
}
