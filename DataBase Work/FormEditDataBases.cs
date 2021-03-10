using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DataBase_Work
{
    public partial class FormEditDataBases : Form
    {
        DataTable dataTable = new DataTable();
        private int currentDataGridViewIndex = 0;
        public void Init()
        {
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("String Connection");
            dataGridViewDataBases.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public FormEditDataBases()
        {
            InitializeComponent();
            Init();
        }

        private void ClearAll()
        {
            richTextBoxConnectionString.Clear();
            textBoxName.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string connectionString = richTextBoxConnectionString.Text;
            string name = textBoxName.Text;

            ClearAll();
            dataTable.Rows.Add(name, connectionString);

            SettingsSave.single.AddNewDataBaseSettings(connectionString, name);
        }

        private void FormEditDataBases_Load(object sender, EventArgs e)
        {
            int size = SettingsSave.single.dataBase_WorkSettings.dataBaseSettings.Count;
            for (int i = 0; i < size; i++)
            {
                dataTable.Rows.Add(
                    SettingsSave.single.dataBase_WorkSettings.dataBaseSettings[i].name,
                    SettingsSave.single.dataBase_WorkSettings.dataBaseSettings[i].connectionString
                    );
            }
            dataGridViewDataBases.DataSource = dataTable;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult deleteDialog = MessageBox.Show(
                "Are you sure you want to delete this entry?",
                "Warning!", 
                MessageBoxButtons.YesNo, 
                MessageBoxIcon.Warning);
            if(deleteDialog == DialogResult.No)
            {
                return;
            }
            dataTable.Rows.RemoveAt(currentDataGridViewIndex);
            SettingsSave.single.dataBase_WorkSettings.dataBaseSettings.RemoveAt(currentDataGridViewIndex);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            richTextBoxConnectionString.Text = 
                SettingsSave.single.dataBase_WorkSettings.dataBaseSettings[currentDataGridViewIndex].connectionString;
            textBoxName.Text = 
                SettingsSave.single.dataBase_WorkSettings.dataBaseSettings[currentDataGridViewIndex].name;
            buttonUpdate.Enabled = true;
        }

        private void buttonTestAllDB_Click(object sender, EventArgs e)
        {
            int size = SettingsSave.single.dataBase_WorkSettings.dataBaseSettings.Count;
            int[] index = new int[size];
            index = Enumerable.Range(0, size).ToArray();
            DataBase.Test test = new DataBase.Test();
            string result;
            if (test.TestAllConnection(index))
            {
                result = "All databases are checked!";
            }
            else
            {
                result = "Error! " + test.LastError;
            }
            MessageBox.Show(result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            dataTable.Rows[currentDataGridViewIndex][0] = textBoxName.Text; 
            dataTable.Rows[currentDataGridViewIndex][1] = richTextBoxConnectionString.Text;

            SettingsSave.single.UpdateNewDataBaseSettings(
                richTextBoxConnectionString.Text, 
                textBoxName.Text, 
                currentDataGridViewIndex
                );

            ClearAll();
            buttonUpdate.Enabled = false;
        }

        private void dataGridViewDataBases_DoubleClick(object sender, EventArgs e)
        {
            new FormDataBaseSettings(currentDataGridViewIndex).Show();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            DataBase.Test test = new DataBase.Test();
            string result;
            if (test.TestCurrentConnection( currentDataGridViewIndex ))
            {
                result = "Database is checked!";
            }
            else
            {
                result = "Error! " + test.LastError;
            }
            MessageBox.Show(result, "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridViewDataBases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentDataGridViewIndex = dataGridViewDataBases.CurrentCell.RowIndex;
        }
    }
}
