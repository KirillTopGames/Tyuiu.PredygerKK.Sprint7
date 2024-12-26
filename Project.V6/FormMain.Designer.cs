namespace Tyuiu.PredygerKK.Sprint7.Project.V6
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBox1 = new GroupBox();
            groupBoxSearch_PKK = new GroupBox();
            buttonSearch_PKK = new Button();
            textBoxSearch_PKK = new TextBox();
            groupBoxFileOperations_PKK = new GroupBox();
            buttonSaveFile_PKK = new Button();
            buttonOpenFile_PKK = new Button();
            groupBoxFunctions_PKK = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            textBoxColumnName_PKK = new TextBox();
            groupBoxEditColumns_PKK = new GroupBox();
            buttonColumnsDelete_PKK = new Button();
            buttonColumnsAdd_PKK = new Button();
            groupBoxEditRows_PKK = new GroupBox();
            labelEditRows_PKK = new Label();
            buttonRowsDelete_PKK = new Button();
            buttonRowsAdd_PKK = new Button();
            buttonVisualize_PKK = new Button();
            buttonHelp_PKK = new Button();
            buttonAbout_PKK = new Button();
            toolTip = new ToolTip(components);
            openFileDialog_PKK = new OpenFileDialog();
            saveFileDialog_PKK = new SaveFileDialog();
            splitContainer1 = new SplitContainer();
            dataGridView_PKK = new DataGridView();
            column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            Column13 = new DataGridViewTextBoxColumn();
            Column14 = new DataGridViewTextBoxColumn();
            Column15 = new DataGridViewTextBoxColumn();
            chartVisualize_PKK = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBox1.SuspendLayout();
            groupBoxSearch_PKK.SuspendLayout();
            groupBoxFileOperations_PKK.SuspendLayout();
            groupBoxFunctions_PKK.SuspendLayout();
            groupBoxEditColumns_PKK.SuspendLayout();
            groupBoxEditRows_PKK.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_PKK).BeginInit();
            ((System.ComponentModel.ISupportInitialize)chartVisualize_PKK).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBoxSearch_PKK);
            groupBox1.Controls.Add(groupBoxFileOperations_PKK);
            groupBox1.Controls.Add(groupBoxFunctions_PKK);
            groupBox1.Controls.Add(buttonHelp_PKK);
            groupBox1.Controls.Add(buttonAbout_PKK);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(8, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1131, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Управление";
            // 
            // groupBoxSearch_PKK
            // 
            groupBoxSearch_PKK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxSearch_PKK.Controls.Add(buttonSearch_PKK);
            groupBoxSearch_PKK.Controls.Add(textBoxSearch_PKK);
            groupBoxSearch_PKK.Location = new Point(132, 11);
            groupBoxSearch_PKK.Name = "groupBoxSearch_PKK";
            groupBoxSearch_PKK.Size = new Size(672, 83);
            groupBoxSearch_PKK.TabIndex = 4;
            groupBoxSearch_PKK.TabStop = false;
            groupBoxSearch_PKK.Text = "Поиск";
            // 
            // buttonSearch_PKK
            // 
            buttonSearch_PKK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonSearch_PKK.Enabled = false;
            buttonSearch_PKK.Image = (Image)resources.GetObject("buttonSearch_PKK.Image");
            buttonSearch_PKK.Location = new Point(626, 27);
            buttonSearch_PKK.Name = "buttonSearch_PKK";
            buttonSearch_PKK.Size = new Size(40, 40);
            buttonSearch_PKK.TabIndex = 1;
            toolTip.SetToolTip(buttonSearch_PKK, "Поиск в таблице по введённым левее словам");
            buttonSearch_PKK.UseVisualStyleBackColor = true;
            buttonSearch_PKK.Click += buttonSearch_PKK_Click;
            buttonSearch_PKK.MouseEnter += buttonSearch_PKK_MouseEnter;
            // 
            // textBoxSearch_PKK
            // 
            textBoxSearch_PKK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxSearch_PKK.Font = new Font("Segoe UI", 18F);
            textBoxSearch_PKK.Location = new Point(6, 28);
            textBoxSearch_PKK.Name = "textBoxSearch_PKK";
            textBoxSearch_PKK.PlaceholderText = "Введите ключевые слова";
            textBoxSearch_PKK.Size = new Size(614, 39);
            textBoxSearch_PKK.TabIndex = 0;
            // 
            // groupBoxFileOperations_PKK
            // 
            groupBoxFileOperations_PKK.Controls.Add(buttonSaveFile_PKK);
            groupBoxFileOperations_PKK.Controls.Add(buttonOpenFile_PKK);
            groupBoxFileOperations_PKK.Location = new Point(6, 22);
            groupBoxFileOperations_PKK.Name = "groupBoxFileOperations_PKK";
            groupBoxFileOperations_PKK.Size = new Size(120, 72);
            groupBoxFileOperations_PKK.TabIndex = 2;
            groupBoxFileOperations_PKK.TabStop = false;
            groupBoxFileOperations_PKK.Text = "Файл";
            // 
            // buttonSaveFile_PKK
            // 
            buttonSaveFile_PKK.BackColor = Color.CornflowerBlue;
            buttonSaveFile_PKK.Enabled = false;
            buttonSaveFile_PKK.FlatStyle = FlatStyle.Popup;
            buttonSaveFile_PKK.Image = (Image)resources.GetObject("buttonSaveFile_PKK.Image");
            buttonSaveFile_PKK.Location = new Point(64, 16);
            buttonSaveFile_PKK.Name = "buttonSaveFile_PKK";
            buttonSaveFile_PKK.Size = new Size(50, 50);
            buttonSaveFile_PKK.TabIndex = 1;
            toolTip.SetToolTip(buttonSaveFile_PKK, "Сохранить файл в любую директорию");
            buttonSaveFile_PKK.UseVisualStyleBackColor = false;
            buttonSaveFile_PKK.Click += buttonSaveFile_PKK_Click;
            buttonSaveFile_PKK.MouseEnter += buttonSaveFile_PKK_MouseEnter;
            // 
            // buttonOpenFile_PKK
            // 
            buttonOpenFile_PKK.BackColor = Color.NavajoWhite;
            buttonOpenFile_PKK.FlatStyle = FlatStyle.Popup;
            buttonOpenFile_PKK.Image = (Image)resources.GetObject("buttonOpenFile_PKK.Image");
            buttonOpenFile_PKK.Location = new Point(6, 16);
            buttonOpenFile_PKK.Name = "buttonOpenFile_PKK";
            buttonOpenFile_PKK.Size = new Size(50, 50);
            buttonOpenFile_PKK.TabIndex = 0;
            toolTip.SetToolTip(buttonOpenFile_PKK, "Открыть файл из любой директории");
            buttonOpenFile_PKK.UseVisualStyleBackColor = false;
            buttonOpenFile_PKK.Click += buttonOpenFile_PKK_Click;
            buttonOpenFile_PKK.MouseEnter += buttonOpenFile_PKK_MouseEnter;
            // 
            // groupBoxFunctions_PKK
            // 
            groupBoxFunctions_PKK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            groupBoxFunctions_PKK.Controls.Add(label2);
            groupBoxFunctions_PKK.Controls.Add(label1);
            groupBoxFunctions_PKK.Controls.Add(textBoxColumnName_PKK);
            groupBoxFunctions_PKK.Controls.Add(groupBoxEditColumns_PKK);
            groupBoxFunctions_PKK.Controls.Add(groupBoxEditRows_PKK);
            groupBoxFunctions_PKK.Controls.Add(buttonVisualize_PKK);
            groupBoxFunctions_PKK.Location = new Point(810, 11);
            groupBoxFunctions_PKK.Name = "groupBoxFunctions_PKK";
            groupBoxFunctions_PKK.Size = new Size(272, 83);
            groupBoxFunctions_PKK.TabIndex = 3;
            groupBoxFunctions_PKK.TabStop = false;
            groupBoxFunctions_PKK.Text = "Функции";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 25);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 12;
            label2.Text = "Название столбца:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 6F, FontStyle.Bold);
            label1.Location = new Point(228, 11);
            label1.Name = "label1";
            label1.Size = new Size(41, 11);
            label1.TabIndex = 10;
            label1.Text = "Столбцы";
            // 
            // textBoxColumnName_PKK
            // 
            textBoxColumnName_PKK.Font = new Font("Segoe UI", 9F);
            textBoxColumnName_PKK.Location = new Point(52, 44);
            textBoxColumnName_PKK.Name = "textBoxColumnName_PKK";
            textBoxColumnName_PKK.PlaceholderText = "Введите название столбца";
            textBoxColumnName_PKK.Size = new Size(128, 23);
            textBoxColumnName_PKK.TabIndex = 11;
            // 
            // groupBoxEditColumns_PKK
            // 
            groupBoxEditColumns_PKK.Controls.Add(buttonColumnsDelete_PKK);
            groupBoxEditColumns_PKK.Controls.Add(buttonColumnsAdd_PKK);
            groupBoxEditColumns_PKK.Font = new Font("Segoe UI", 1F);
            groupBoxEditColumns_PKK.Location = new Point(229, 17);
            groupBoxEditColumns_PKK.Name = "groupBoxEditColumns_PKK";
            groupBoxEditColumns_PKK.Size = new Size(37, 63);
            groupBoxEditColumns_PKK.TabIndex = 9;
            groupBoxEditColumns_PKK.TabStop = false;
            // 
            // buttonColumnsDelete_PKK
            // 
            buttonColumnsDelete_PKK.BackColor = Color.Salmon;
            buttonColumnsDelete_PKK.Enabled = false;
            buttonColumnsDelete_PKK.Image = (Image)resources.GetObject("buttonColumnsDelete_PKK.Image");
            buttonColumnsDelete_PKK.Location = new Point(6, 34);
            buttonColumnsDelete_PKK.Name = "buttonColumnsDelete_PKK";
            buttonColumnsDelete_PKK.Size = new Size(25, 25);
            buttonColumnsDelete_PKK.TabIndex = 9;
            toolTip.SetToolTip(buttonColumnsDelete_PKK, "Удалить выбранный столбец");
            buttonColumnsDelete_PKK.UseVisualStyleBackColor = false;
            buttonColumnsDelete_PKK.Click += buttonColumnsDelete_PKK_Click;
            buttonColumnsDelete_PKK.MouseEnter += buttonColumnsDelete_PKK_MouseEnter;
            // 
            // buttonColumnsAdd_PKK
            // 
            buttonColumnsAdd_PKK.BackColor = Color.PaleGreen;
            buttonColumnsAdd_PKK.Enabled = false;
            buttonColumnsAdd_PKK.Image = (Image)resources.GetObject("buttonColumnsAdd_PKK.Image");
            buttonColumnsAdd_PKK.Location = new Point(6, 6);
            buttonColumnsAdd_PKK.Name = "buttonColumnsAdd_PKK";
            buttonColumnsAdd_PKK.Size = new Size(25, 25);
            buttonColumnsAdd_PKK.TabIndex = 8;
            toolTip.SetToolTip(buttonColumnsAdd_PKK, "Добавить новый столбец");
            buttonColumnsAdd_PKK.UseVisualStyleBackColor = false;
            buttonColumnsAdd_PKK.Click += buttonColumnsAdd_PKK_Click;
            buttonColumnsAdd_PKK.MouseEnter += buttonColumnsAdd_PKK_MouseEnter;
            // 
            // groupBoxEditRows_PKK
            // 
            groupBoxEditRows_PKK.Controls.Add(labelEditRows_PKK);
            groupBoxEditRows_PKK.Controls.Add(buttonRowsDelete_PKK);
            groupBoxEditRows_PKK.Controls.Add(buttonRowsAdd_PKK);
            groupBoxEditRows_PKK.Font = new Font("Segoe UI", 5F);
            groupBoxEditRows_PKK.Location = new Point(186, 14);
            groupBoxEditRows_PKK.Name = "groupBoxEditRows_PKK";
            groupBoxEditRows_PKK.Size = new Size(37, 66);
            groupBoxEditRows_PKK.TabIndex = 8;
            groupBoxEditRows_PKK.TabStop = false;
            // 
            // labelEditRows_PKK
            // 
            labelEditRows_PKK.AutoSize = true;
            labelEditRows_PKK.Font = new Font("Segoe UI", 6F, FontStyle.Bold);
            labelEditRows_PKK.Location = new Point(3, -3);
            labelEditRows_PKK.Name = "labelEditRows_PKK";
            labelEditRows_PKK.Size = new Size(33, 11);
            labelEditRows_PKK.TabIndex = 9;
            labelEditRows_PKK.Text = "Строки";
            // 
            // buttonRowsDelete_PKK
            // 
            buttonRowsDelete_PKK.BackColor = Color.Salmon;
            buttonRowsDelete_PKK.Enabled = false;
            buttonRowsDelete_PKK.Image = (Image)resources.GetObject("buttonRowsDelete_PKK.Image");
            buttonRowsDelete_PKK.Location = new Point(6, 37);
            buttonRowsDelete_PKK.Name = "buttonRowsDelete_PKK";
            buttonRowsDelete_PKK.Size = new Size(25, 25);
            buttonRowsDelete_PKK.TabIndex = 8;
            toolTip.SetToolTip(buttonRowsDelete_PKK, "Удалить выбранную строку");
            buttonRowsDelete_PKK.UseVisualStyleBackColor = false;
            buttonRowsDelete_PKK.Click += buttonRowsDelete_PKK_Click;
            buttonRowsDelete_PKK.MouseEnter += buttonRowsDelete_PKK_MouseEnter;
            // 
            // buttonRowsAdd_PKK
            // 
            buttonRowsAdd_PKK.BackColor = Color.PaleGreen;
            buttonRowsAdd_PKK.Enabled = false;
            buttonRowsAdd_PKK.Image = (Image)resources.GetObject("buttonRowsAdd_PKK.Image");
            buttonRowsAdd_PKK.Location = new Point(6, 9);
            buttonRowsAdd_PKK.Name = "buttonRowsAdd_PKK";
            buttonRowsAdd_PKK.Size = new Size(25, 25);
            buttonRowsAdd_PKK.TabIndex = 7;
            toolTip.SetToolTip(buttonRowsAdd_PKK, "Добавить новую строку");
            buttonRowsAdd_PKK.UseVisualStyleBackColor = false;
            buttonRowsAdd_PKK.Click += buttonRowsAdd_PKK_Click;
            buttonRowsAdd_PKK.MouseEnter += buttonRowsAdd_PKK_MouseEnter;
            // 
            // buttonVisualize_PKK
            // 
            buttonVisualize_PKK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonVisualize_PKK.BackColor = Color.LightCoral;
            buttonVisualize_PKK.Enabled = false;
            buttonVisualize_PKK.FlatStyle = FlatStyle.Flat;
            buttonVisualize_PKK.Image = (Image)resources.GetObject("buttonVisualize_PKK.Image");
            buttonVisualize_PKK.Location = new Point(6, 27);
            buttonVisualize_PKK.Name = "buttonVisualize_PKK";
            buttonVisualize_PKK.Size = new Size(40, 40);
            buttonVisualize_PKK.TabIndex = 0;
            buttonVisualize_PKK.UseVisualStyleBackColor = false;
            buttonVisualize_PKK.Click += buttonVisualize_PKK_Click;
            // 
            // buttonHelp_PKK
            // 
            buttonHelp_PKK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_PKK.BackColor = Color.LightSalmon;
            buttonHelp_PKK.Image = (Image)resources.GetObject("buttonHelp_PKK.Image");
            buttonHelp_PKK.Location = new Point(1088, 11);
            buttonHelp_PKK.Name = "buttonHelp_PKK";
            buttonHelp_PKK.Size = new Size(40, 40);
            buttonHelp_PKK.TabIndex = 1;
            toolTip.SetToolTip(buttonHelp_PKK, "Инструкция по работе с приложением.");
            buttonHelp_PKK.UseVisualStyleBackColor = false;
            buttonHelp_PKK.Click += buttonHelp_PKK_Click;
            buttonHelp_PKK.MouseEnter += buttonHelp_PKK_MouseEnter;
            buttonHelp_PKK.MouseLeave += buttonHelp_PKK_MouseLeave;
            // 
            // buttonAbout_PKK
            // 
            buttonAbout_PKK.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout_PKK.BackColor = Color.CornflowerBlue;
            buttonAbout_PKK.Cursor = Cursors.Hand;
            buttonAbout_PKK.Image = (Image)resources.GetObject("buttonAbout_PKK.Image");
            buttonAbout_PKK.Location = new Point(1088, 54);
            buttonAbout_PKK.Name = "buttonAbout_PKK";
            buttonAbout_PKK.Size = new Size(40, 40);
            buttonAbout_PKK.TabIndex = 0;
            toolTip.SetToolTip(buttonAbout_PKK, "Сведения о приложении.");
            buttonAbout_PKK.UseVisualStyleBackColor = false;
            buttonAbout_PKK.Click += buttonAbout_PKK_Click;
            buttonAbout_PKK.MouseEnter += buttonAbout_PKK_MouseEnter;
            buttonAbout_PKK.MouseLeave += buttonAbout_PKK_MouseLeave;
            // 
            // toolTip
            // 
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 300;
            toolTip.IsBalloon = true;
            toolTip.ReshowDelay = 300;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            // 
            // openFileDialog_PKK
            // 
            openFileDialog_PKK.FileName = "openFileDialog_PKK";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(8, 108);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView_PKK);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(chartVisualize_PKK);
            splitContainer1.Size = new Size(1131, 515);
            splitContainer1.SplitterDistance = 377;
            splitContainer1.TabIndex = 1;
            // 
            // dataGridView_PKK
            // 
            dataGridView_PKK.BackgroundColor = Color.White;
            dataGridView_PKK.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_PKK.Columns.AddRange(new DataGridViewColumn[] { column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column11, Column12, Column13, Column14, Column15 });
            dataGridView_PKK.Dock = DockStyle.Fill;
            dataGridView_PKK.Location = new Point(0, 0);
            dataGridView_PKK.Name = "dataGridView_PKK";
            dataGridView_PKK.RowHeadersVisible = false;
            dataGridView_PKK.Size = new Size(377, 515);
            dataGridView_PKK.TabIndex = 1;
            // 
            // column1
            // 
            column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column1.HeaderText = "Id пациента";
            column1.Name = "column1";
            column1.Width = 88;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Фамилия пациента";
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Имя пациента";
            Column3.Name = "Column3";
            Column3.Width = 101;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Отчество пациента";
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Диагноз";
            Column5.Name = "Column5";
            Column5.Width = 77;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Амбулаторное лечение";
            Column6.Name = "Column6";
            Column6.Width = 149;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Трудоспособность";
            Column7.Name = "Column7";
            Column7.Width = 135;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column8.HeaderText = "Диспансерный учёт";
            Column8.Name = "Column8";
            Column8.Width = 130;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.HeaderText = "Дата рождения";
            Column9.Name = "Column9";
            Column9.Width = 106;
            // 
            // Column11
            // 
            Column11.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column11.HeaderText = "Фамилия врача";
            Column11.Name = "Column11";
            Column11.Width = 108;
            // 
            // Column12
            // 
            Column12.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column12.HeaderText = "Имя врача";
            Column12.Name = "Column12";
            Column12.Width = 84;
            // 
            // Column13
            // 
            Column13.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column13.HeaderText = "Отчество врача";
            Column13.Name = "Column13";
            Column13.Width = 108;
            // 
            // Column14
            // 
            Column14.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column14.HeaderText = "Должность";
            Column14.Name = "Column14";
            Column14.Width = 94;
            // 
            // Column15
            // 
            Column15.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column15.HeaderText = "Специальность";
            Column15.Name = "Column15";
            Column15.Width = 117;
            // 
            // chartVisualize_PKK
            // 
            chartArea1.Name = "ChartArea1";
            chartVisualize_PKK.ChartAreas.Add(chartArea1);
            chartVisualize_PKK.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartVisualize_PKK.Legends.Add(legend1);
            chartVisualize_PKK.Location = new Point(0, 0);
            chartVisualize_PKK.Name = "chartVisualize_PKK";
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartVisualize_PKK.Series.Add(series1);
            chartVisualize_PKK.Size = new Size(750, 515);
            chartVisualize_PKK.TabIndex = 0;
            chartVisualize_PKK.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1147, 631);
            Controls.Add(splitContainer1);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(1163, 670);
            Name = "FormMain";
            Padding = new Padding(8);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Поликлиника";
            groupBox1.ResumeLayout(false);
            groupBoxSearch_PKK.ResumeLayout(false);
            groupBoxSearch_PKK.PerformLayout();
            groupBoxFileOperations_PKK.ResumeLayout(false);
            groupBoxFunctions_PKK.ResumeLayout(false);
            groupBoxFunctions_PKK.PerformLayout();
            groupBoxEditColumns_PKK.ResumeLayout(false);
            groupBoxEditRows_PKK.ResumeLayout(false);
            groupBoxEditRows_PKK.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView_PKK).EndInit();
            ((System.ComponentModel.ISupportInitialize)chartVisualize_PKK).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button buttonAbout_PKK;
        private Button buttonHelp_PKK;
        private ToolTip toolTip;
        private GroupBox groupBoxFunctions_PKK;
        private GroupBox groupBoxFileOperations_PKK;
        private Button buttonSaveFile_PKK;
        private Button buttonOpenFile_PKK;
        private Button buttonVisualize_PKK;
        private GroupBox groupBoxSearch_PKK;
        private TextBox textBoxSearch_PKK;
        private Button buttonSearch_PKK;
        private OpenFileDialog openFileDialog_PKK;
        private SaveFileDialog saveFileDialog_PKK;
        private GroupBox groupBoxEditRows_PKK;
        private Button buttonRowsAdd_PKK;
        private GroupBox groupBoxEditColumns_PKK;
        private Button buttonColumnsDelete_PKK;
        private Button buttonColumnsAdd_PKK;
        private Button buttonRowsDelete_PKK;
        private Label labelEditRows_PKK;
        private TextBox textBoxColumnName_PKK;
        private Label label2;
        private Label label1;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView_PKK;
        private DataGridViewTextBoxColumn column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private DataGridViewTextBoxColumn Column13;
        private DataGridViewTextBoxColumn Column14;
        private DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartVisualize_PKK;
    }
}
