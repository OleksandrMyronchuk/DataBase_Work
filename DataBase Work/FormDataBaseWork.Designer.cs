namespace DataBase_Work
{
    partial class FormDataBaseWork
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
            this.components = new System.ComponentModel.Container();
            this.progressBarRunQuery = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDataBasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkAllConnectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.athorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxDataBase = new System.Windows.Forms.CheckedListBox();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonRunSelected = new System.Windows.Forms.Button();
            this.buttonCheckDataBase = new System.Windows.Forms.Button();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageQuery = new System.Windows.Forms.TabPage();
            this.buttonQueryClear = new System.Windows.Forms.Button();
            this.richTextBoxQuery = new DataBase_Work.CustomComponent.CustomRichTextBox();
            this.tabPageResult = new System.Windows.Forms.TabPage();
            this.buttonCopyWithoutNulls = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.labelResultStatusValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHistoryResult = new System.Windows.Forms.Button();
            this.buttonSaveAllResult = new System.Windows.Forms.Button();
            this.buttonSaveResult = new System.Windows.Forms.Button();
            this.tabControlResult = new DataBase_Work.CustomComponent.CustomTabControl();
            this.tabPageLog = new System.Windows.Forms.TabPage();
            this.labelLogStatusValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonHistoryLog = new System.Windows.Forms.Button();
            this.buttonSaveAllLog = new System.Windows.Forms.Button();
            this.buttonSaveLog = new System.Windows.Forms.Button();
            this.tabControlLog = new DataBase_Work.CustomComponent.CustomTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonRunToFile = new System.Windows.Forms.Button();
            this.buttonRunSelectedToFile = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageQuery.SuspendLayout();
            this.tabPageResult.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBarRunQuery
            // 
            this.progressBarRunQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarRunQuery.Location = new System.Drawing.Point(92, 641);
            this.progressBarRunQuery.Margin = new System.Windows.Forms.Padding(4);
            this.progressBarRunQuery.Name = "progressBarRunQuery";
            this.progressBarRunQuery.Size = new System.Drawing.Size(1227, 12);
            this.progressBarRunQuery.TabIndex = 0;
            // 
            // labelProgress
            // 
            this.labelProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(16, 638);
            this.labelProgress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(69, 17);
            this.labelProgress.TabIndex = 2;
            this.labelProgress.Text = "Progress:";
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.dataBaseToolStripMenuItem,
            this.runToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1335, 28);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(141, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // dataBaseToolStripMenuItem
            // 
            this.dataBaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDataBasesToolStripMenuItem,
            this.checkAllConnectionsToolStripMenuItem});
            this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.dataBaseToolStripMenuItem.Text = "Data Base";
            // 
            // editDataBasesToolStripMenuItem
            // 
            this.editDataBasesToolStripMenuItem.Name = "editDataBasesToolStripMenuItem";
            this.editDataBasesToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.editDataBasesToolStripMenuItem.Text = "Edit data bases";
            this.editDataBasesToolStripMenuItem.Click += new System.EventHandler(this.editDataBasesToolStripMenuItem_Click);
            // 
            // checkAllConnectionsToolStripMenuItem
            // 
            this.checkAllConnectionsToolStripMenuItem.Name = "checkAllConnectionsToolStripMenuItem";
            this.checkAllConnectionsToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.checkAllConnectionsToolStripMenuItem.Text = "Check All Connections";
            // 
            // runToolStripMenuItem
            // 
            this.runToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runAllToolStripMenuItem,
            this.runSelectedToolStripMenuItem});
            this.runToolStripMenuItem.Name = "runToolStripMenuItem";
            this.runToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.runToolStripMenuItem.Text = "Run";
            // 
            // runAllToolStripMenuItem
            // 
            this.runAllToolStripMenuItem.Name = "runAllToolStripMenuItem";
            this.runAllToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.runAllToolStripMenuItem.Text = "Run All";
            // 
            // runSelectedToolStripMenuItem
            // 
            this.runSelectedToolStripMenuItem.Name = "runSelectedToolStripMenuItem";
            this.runSelectedToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.runSelectedToolStripMenuItem.Text = "Run Selected";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem,
            this.toolStripSeparator2,
            this.athorToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(126, 6);
            // 
            // athorToolStripMenuItem
            // 
            this.athorToolStripMenuItem.Name = "athorToolStripMenuItem";
            this.athorToolStripMenuItem.Size = new System.Drawing.Size(129, 26);
            this.athorToolStripMenuItem.Text = "Author";
            // 
            // checkedListBoxDataBase
            // 
            this.checkedListBoxDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBoxDataBase.FormattingEnabled = true;
            this.checkedListBoxDataBase.Location = new System.Drawing.Point(20, 33);
            this.checkedListBoxDataBase.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxDataBase.Name = "checkedListBoxDataBase";
            this.checkedListBoxDataBase.Size = new System.Drawing.Size(1063, 106);
            this.checkedListBoxDataBase.TabIndex = 4;
            // 
            // buttonRun
            // 
            this.buttonRun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRun.Location = new System.Drawing.Point(1092, 33);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(109, 39);
            this.buttonRun.TabIndex = 5;
            this.buttonRun.Text = "Run";
            this.buttonRun.UseVisualStyleBackColor = true;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonRunSelected
            // 
            this.buttonRunSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRunSelected.Location = new System.Drawing.Point(1092, 74);
            this.buttonRunSelected.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRunSelected.Name = "buttonRunSelected";
            this.buttonRunSelected.Size = new System.Drawing.Size(109, 39);
            this.buttonRunSelected.TabIndex = 6;
            this.buttonRunSelected.Text = "Run Selected";
            this.buttonRunSelected.UseVisualStyleBackColor = true;
            this.buttonRunSelected.Click += new System.EventHandler(this.buttonRunSelected_Click);
            // 
            // buttonCheckDataBase
            // 
            this.buttonCheckDataBase.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCheckDataBase.Location = new System.Drawing.Point(1092, 121);
            this.buttonCheckDataBase.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCheckDataBase.Name = "buttonCheckDataBase";
            this.buttonCheckDataBase.Size = new System.Drawing.Size(227, 28);
            this.buttonCheckDataBase.TabIndex = 7;
            this.buttonCheckDataBase.Text = "Check DataBase";
            this.buttonCheckDataBase.UseVisualStyleBackColor = true;
            this.buttonCheckDataBase.Click += new System.EventHandler(this.buttonCheckDataBase_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabPageQuery);
            this.tabControlMain.Controls.Add(this.tabPageResult);
            this.tabControlMain.Controls.Add(this.tabPageLog);
            this.tabControlMain.Location = new System.Drawing.Point(20, 156);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1299, 478);
            this.tabControlMain.TabIndex = 8;
            // 
            // tabPageQuery
            // 
            this.tabPageQuery.Controls.Add(this.buttonQueryClear);
            this.tabPageQuery.Controls.Add(this.richTextBoxQuery);
            this.tabPageQuery.Location = new System.Drawing.Point(4, 25);
            this.tabPageQuery.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageQuery.Name = "tabPageQuery";
            this.tabPageQuery.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageQuery.Size = new System.Drawing.Size(1291, 449);
            this.tabPageQuery.TabIndex = 0;
            this.tabPageQuery.Text = "Query";
            this.tabPageQuery.UseVisualStyleBackColor = true;
            // 
            // buttonQueryClear
            // 
            this.buttonQueryClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQueryClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonQueryClear.ForeColor = System.Drawing.Color.Transparent;
            this.buttonQueryClear.Image = global::DataBase_Work.Properties.Resources.Close;
            this.buttonQueryClear.Location = new System.Drawing.Point(1207, 11);
            this.buttonQueryClear.Margin = new System.Windows.Forms.Padding(4);
            this.buttonQueryClear.Name = "buttonQueryClear";
            this.buttonQueryClear.Size = new System.Drawing.Size(68, 63);
            this.buttonQueryClear.TabIndex = 2;
            this.buttonQueryClear.UseVisualStyleBackColor = true;
            this.buttonQueryClear.Click += new System.EventHandler(this.buttonQueryClear_Click_1);
            // 
            // richTextBoxQuery
            // 
            this.richTextBoxQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxQuery.Location = new System.Drawing.Point(8, 7);
            this.richTextBoxQuery.Margin = new System.Windows.Forms.Padding(4);
            this.richTextBoxQuery.Name = "richTextBoxQuery";
            this.richTextBoxQuery.Size = new System.Drawing.Size(1271, 430);
            this.richTextBoxQuery.TabIndex = 1;
            this.richTextBoxQuery.Text = "";
            // 
            // tabPageResult
            // 
            this.tabPageResult.Controls.Add(this.buttonCopyWithoutNulls);
            this.tabPageResult.Controls.Add(this.buttonCopy);
            this.tabPageResult.Controls.Add(this.labelResultStatusValue);
            this.tabPageResult.Controls.Add(this.label1);
            this.tabPageResult.Controls.Add(this.buttonHistoryResult);
            this.tabPageResult.Controls.Add(this.buttonSaveAllResult);
            this.tabPageResult.Controls.Add(this.buttonSaveResult);
            this.tabPageResult.Controls.Add(this.tabControlResult);
            this.tabPageResult.Location = new System.Drawing.Point(4, 25);
            this.tabPageResult.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageResult.Name = "tabPageResult";
            this.tabPageResult.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageResult.Size = new System.Drawing.Size(1291, 449);
            this.tabPageResult.TabIndex = 1;
            this.tabPageResult.Text = "Result";
            this.tabPageResult.UseVisualStyleBackColor = true;
            // 
            // buttonCopyWithoutNulls
            // 
            this.buttonCopyWithoutNulls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopyWithoutNulls.Location = new System.Drawing.Point(710, 411);
            this.buttonCopyWithoutNulls.Name = "buttonCopyWithoutNulls";
            this.buttonCopyWithoutNulls.Size = new System.Drawing.Size(156, 27);
            this.buttonCopyWithoutNulls.TabIndex = 9;
            this.buttonCopyWithoutNulls.Text = "Copy Without Nulls";
            this.buttonCopyWithoutNulls.UseVisualStyleBackColor = true;
            this.buttonCopyWithoutNulls.Click += new System.EventHandler(this.buttonCopyWithoutNulls_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCopy.Location = new System.Drawing.Point(872, 410);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(76, 28);
            this.buttonCopy.TabIndex = 8;
            this.buttonCopy.Text = "Copy";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // labelResultStatusValue
            // 
            this.labelResultStatusValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelResultStatusValue.AutoSize = true;
            this.labelResultStatusValue.Location = new System.Drawing.Point(184, 422);
            this.labelResultStatusValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelResultStatusValue.Name = "labelResultStatusValue";
            this.labelResultStatusValue.Size = new System.Drawing.Size(56, 17);
            this.labelResultStatusValue.TabIndex = 7;
            this.labelResultStatusValue.Text = "[Status]";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 421);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Status: ";
            // 
            // buttonHistoryResult
            // 
            this.buttonHistoryResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonHistoryResult.Location = new System.Drawing.Point(8, 410);
            this.buttonHistoryResult.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHistoryResult.Name = "buttonHistoryResult";
            this.buttonHistoryResult.Size = new System.Drawing.Size(100, 28);
            this.buttonHistoryResult.TabIndex = 5;
            this.buttonHistoryResult.Text = "History";
            this.buttonHistoryResult.UseVisualStyleBackColor = true;
            this.buttonHistoryResult.Click += new System.EventHandler(this.buttonHistoryResult_Click);
            // 
            // buttonSaveAllResult
            // 
            this.buttonSaveAllResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAllResult.Location = new System.Drawing.Point(1072, 410);
            this.buttonSaveAllResult.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveAllResult.Name = "buttonSaveAllResult";
            this.buttonSaveAllResult.Size = new System.Drawing.Size(100, 28);
            this.buttonSaveAllResult.TabIndex = 4;
            this.buttonSaveAllResult.Text = "Save All";
            this.buttonSaveAllResult.UseVisualStyleBackColor = true;
            this.buttonSaveAllResult.Click += new System.EventHandler(this.buttonSaveAllResult_Click);
            // 
            // buttonSaveResult
            // 
            this.buttonSaveResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveResult.Location = new System.Drawing.Point(1180, 410);
            this.buttonSaveResult.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveResult.Name = "buttonSaveResult";
            this.buttonSaveResult.Size = new System.Drawing.Size(100, 28);
            this.buttonSaveResult.TabIndex = 3;
            this.buttonSaveResult.Text = "Save";
            this.buttonSaveResult.UseVisualStyleBackColor = true;
            // 
            // tabControlResult
            // 
            this.tabControlResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlResult.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlResult.ItemSize = new System.Drawing.Size(240, 22);
            this.tabControlResult.Location = new System.Drawing.Point(4, 0);
            this.tabControlResult.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlResult.Name = "tabControlResult";
            this.tabControlResult.SelectedIndex = 0;
            this.tabControlResult.Size = new System.Drawing.Size(1284, 402);
            this.tabControlResult.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlResult.TabIndex = 0;
            // 
            // tabPageLog
            // 
            this.tabPageLog.Controls.Add(this.labelLogStatusValue);
            this.tabPageLog.Controls.Add(this.label2);
            this.tabPageLog.Controls.Add(this.buttonHistoryLog);
            this.tabPageLog.Controls.Add(this.buttonSaveAllLog);
            this.tabPageLog.Controls.Add(this.buttonSaveLog);
            this.tabPageLog.Controls.Add(this.tabControlLog);
            this.tabPageLog.Location = new System.Drawing.Point(4, 25);
            this.tabPageLog.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Size = new System.Drawing.Size(1291, 449);
            this.tabPageLog.TabIndex = 2;
            this.tabPageLog.Text = "Log";
            this.tabPageLog.UseVisualStyleBackColor = true;
            // 
            // labelLogStatusValue
            // 
            this.labelLogStatusValue.AutoSize = true;
            this.labelLogStatusValue.Location = new System.Drawing.Point(184, 422);
            this.labelLogStatusValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogStatusValue.Name = "labelLogStatusValue";
            this.labelLogStatusValue.Size = new System.Drawing.Size(56, 17);
            this.labelLogStatusValue.TabIndex = 8;
            this.labelLogStatusValue.Text = "[Status]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 421);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Status: ";
            // 
            // buttonHistoryLog
            // 
            this.buttonHistoryLog.Location = new System.Drawing.Point(8, 410);
            this.buttonHistoryLog.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHistoryLog.Name = "buttonHistoryLog";
            this.buttonHistoryLog.Size = new System.Drawing.Size(100, 28);
            this.buttonHistoryLog.TabIndex = 6;
            this.buttonHistoryLog.Text = "History";
            this.buttonHistoryLog.UseVisualStyleBackColor = true;
            this.buttonHistoryLog.Click += new System.EventHandler(this.buttonHistoryLog_Click);
            // 
            // buttonSaveAllLog
            // 
            this.buttonSaveAllLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveAllLog.Location = new System.Drawing.Point(1072, 410);
            this.buttonSaveAllLog.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveAllLog.Name = "buttonSaveAllLog";
            this.buttonSaveAllLog.Size = new System.Drawing.Size(100, 28);
            this.buttonSaveAllLog.TabIndex = 2;
            this.buttonSaveAllLog.Text = "Save All";
            this.buttonSaveAllLog.UseVisualStyleBackColor = true;
            // 
            // buttonSaveLog
            // 
            this.buttonSaveLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveLog.Location = new System.Drawing.Point(1180, 410);
            this.buttonSaveLog.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveLog.Name = "buttonSaveLog";
            this.buttonSaveLog.Size = new System.Drawing.Size(100, 28);
            this.buttonSaveLog.TabIndex = 1;
            this.buttonSaveLog.Text = "Save";
            this.buttonSaveLog.UseVisualStyleBackColor = true;
            // 
            // tabControlLog
            // 
            this.tabControlLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlLog.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControlLog.ItemSize = new System.Drawing.Size(240, 22);
            this.tabControlLog.Location = new System.Drawing.Point(4, 0);
            this.tabControlLog.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlLog.Name = "tabControlLog";
            this.tabControlLog.SelectedIndex = 0;
            this.tabControlLog.Size = new System.Drawing.Size(1284, 402);
            this.tabControlLog.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControlLog.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 74);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonRunToFile
            // 
            this.buttonRunToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRunToFile.Location = new System.Drawing.Point(1209, 33);
            this.buttonRunToFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRunToFile.Name = "buttonRunToFile";
            this.buttonRunToFile.Size = new System.Drawing.Size(109, 39);
            this.buttonRunToFile.TabIndex = 9;
            this.buttonRunToFile.Text = "R... To File";
            this.buttonRunToFile.UseVisualStyleBackColor = true;
            this.buttonRunToFile.Click += new System.EventHandler(this.buttonRunToFile_Click);
            // 
            // buttonRunSelectedToFile
            // 
            this.buttonRunSelectedToFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRunSelectedToFile.Location = new System.Drawing.Point(1209, 74);
            this.buttonRunSelectedToFile.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRunSelectedToFile.Name = "buttonRunSelectedToFile";
            this.buttonRunSelectedToFile.Size = new System.Drawing.Size(109, 39);
            this.buttonRunSelectedToFile.TabIndex = 10;
            this.buttonRunSelectedToFile.Text = "RS... To File";
            this.buttonRunSelectedToFile.UseVisualStyleBackColor = true;
            this.buttonRunSelectedToFile.Click += new System.EventHandler(this.buttonRunSelectedToFile_Click);
            // 
            // FormDataBaseWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 668);
            this.Controls.Add(this.buttonRunSelectedToFile);
            this.Controls.Add(this.buttonRunToFile);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.buttonCheckDataBase);
            this.Controls.Add(this.buttonRunSelected);
            this.Controls.Add(this.buttonRun);
            this.Controls.Add(this.checkedListBoxDataBase);
            this.Controls.Add(this.labelProgress);
            this.Controls.Add(this.progressBarRunQuery);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDataBaseWork";
            this.Text = "DataBase Work";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormDataBaseWork_FormClosing);
            this.Load += new System.EventHandler(this.FormDataBaseWork_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageQuery.ResumeLayout(false);
            this.tabPageResult.ResumeLayout(false);
            this.tabPageResult.PerformLayout();
            this.tabPageLog.ResumeLayout(false);
            this.tabPageLog.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarRunQuery;
        private CustomComponent.CustomRichTextBox richTextBoxQuery;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editDataBasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runSelectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem athorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkAllConnectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.CheckedListBox checkedListBoxDataBase;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonRunSelected;
        private System.Windows.Forms.Button buttonCheckDataBase;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageQuery;
        private System.Windows.Forms.TabPage tabPageResult;
        private System.Windows.Forms.TabPage tabPageLog;
        private System.Windows.Forms.Button buttonQueryClear;
        private CustomComponent.CustomTabControl tabControlResult;
        private System.Windows.Forms.Button buttonSaveAllLog;
        private System.Windows.Forms.Button buttonSaveLog;
        private CustomComponent.CustomTabControl tabControlLog;
        private System.Windows.Forms.Button buttonSaveAllResult;
        private System.Windows.Forms.Button buttonSaveResult;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonHistoryResult;
        private System.Windows.Forms.Button buttonHistoryLog;
        private System.Windows.Forms.Label labelResultStatusValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLogStatusValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonRunToFile;
        private System.Windows.Forms.Button buttonRunSelectedToFile;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Button buttonCopyWithoutNulls;
    }
}

