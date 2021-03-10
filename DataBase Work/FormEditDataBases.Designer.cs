namespace DataBase_Work
{
    partial class FormEditDataBases
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewDataBases = new System.Windows.Forms.DataGridView();
            this.richTextBoxConnectionString = new System.Windows.Forms.RichTextBox();
            this.labelConnectionString = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelDataBases = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonTestAllDB = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBases)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDataBases
            // 
            this.dataGridViewDataBases.AllowUserToAddRows = false;
            this.dataGridViewDataBases.AllowUserToDeleteRows = false;
            this.dataGridViewDataBases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewDataBases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDataBases.Location = new System.Drawing.Point(12, 202);
            this.dataGridViewDataBases.Name = "dataGridViewDataBases";
            this.dataGridViewDataBases.ReadOnly = true;
            this.dataGridViewDataBases.Size = new System.Drawing.Size(974, 301);
            this.dataGridViewDataBases.TabIndex = 0;
            this.dataGridViewDataBases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDataBases_CellClick);
            this.dataGridViewDataBases.DoubleClick += new System.EventHandler(this.dataGridViewDataBases_DoubleClick);
            // 
            // richTextBoxConnectionString
            // 
            this.richTextBoxConnectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxConnectionString.Location = new System.Drawing.Point(12, 25);
            this.richTextBoxConnectionString.Name = "richTextBoxConnectionString";
            this.richTextBoxConnectionString.Size = new System.Drawing.Size(974, 70);
            this.richTextBoxConnectionString.TabIndex = 1;
            this.richTextBoxConnectionString.Text = "";
            // 
            // labelConnectionString
            // 
            this.labelConnectionString.AutoSize = true;
            this.labelConnectionString.Location = new System.Drawing.Point(12, 9);
            this.labelConnectionString.Name = "labelConnectionString";
            this.labelConnectionString.Size = new System.Drawing.Size(91, 13);
            this.labelConnectionString.TabIndex = 2;
            this.labelConnectionString.Text = "Connection String";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAdd.Location = new System.Drawing.Point(830, 140);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 3;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelDataBases
            // 
            this.labelDataBases.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelDataBases.AutoSize = true;
            this.labelDataBases.Location = new System.Drawing.Point(466, 186);
            this.labelDataBases.Name = "labelDataBases";
            this.labelDataBases.Size = new System.Drawing.Size(59, 13);
            this.labelDataBases.TabIndex = 4;
            this.labelDataBases.Text = "DataBases";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(830, 509);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEdit.Location = new System.Drawing.Point(911, 509);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 6;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonTestAllDB
            // 
            this.buttonTestAllDB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTestAllDB.Location = new System.Drawing.Point(12, 509);
            this.buttonTestAllDB.Name = "buttonTestAllDB";
            this.buttonTestAllDB.Size = new System.Drawing.Size(75, 23);
            this.buttonTestAllDB.TabIndex = 7;
            this.buttonTestAllDB.Text = "Test All DB";
            this.buttonTestAllDB.UseVisualStyleBackColor = true;
            this.buttonTestAllDB.Click += new System.EventHandler(this.buttonTestAllDB_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 98);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(12, 114);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(974, 20);
            this.textBoxName.TabIndex = 9;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(911, 140);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 10;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonTest.Location = new System.Drawing.Point(93, 509);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 23);
            this.buttonTest.TabIndex = 11;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // FormEditDataBases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 544);
            this.Controls.Add(this.buttonTest);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonTestAllDB);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.labelDataBases);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelConnectionString);
            this.Controls.Add(this.richTextBoxConnectionString);
            this.Controls.Add(this.dataGridViewDataBases);
            this.Name = "FormEditDataBases";
            this.Text = "EditDataBases";
            this.Load += new System.EventHandler(this.FormEditDataBases_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDataBases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDataBases;
        private System.Windows.Forms.RichTextBox richTextBoxConnectionString;
        private System.Windows.Forms.Label labelConnectionString;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelDataBases;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonTestAllDB;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonTest;
    }
}