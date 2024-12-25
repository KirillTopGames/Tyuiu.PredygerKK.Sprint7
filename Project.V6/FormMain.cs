using Tyuiu.PredygerKK.Sprint7.Project.V6.Lib;
using System.Data;
using System.Text;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.PredygerKK.Sprint7.Project.V6
{
    public partial class FormMain : Form
    {
        DataTable SourceDT = new DataTable();
        public FormMain()
        {
            InitializeComponent();
            openFileDialog_PKK.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialog_PKK.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";

            foreach (DataGridViewColumn column in dataGridView_PKK.Columns)
            {
                if (column.HeaderText == "Id пациента")
                {
                    SourceDT.Columns.Add(column.HeaderText, typeof(int));
                }
                else if (column.HeaderText == "Дата рождения")
                {
                    SourceDT.Columns.Add(column.HeaderText, typeof(DateTime));
                }
                else
                {
                    SourceDT.Columns.Add(column.HeaderText, typeof(string));
                }
            }

            foreach (DataGridViewRow row in dataGridView_PKK.Rows)
            {
                if (!row.IsNewRow)
                {
                    DataRow dr = SourceDT.NewRow();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dr[cell.ColumnIndex] = cell.Value ?? DBNull.Value;
                    }
                    SourceDT.Rows.Add(dr);
                }
            }

            dataGridView_PKK.Columns.Clear();
            dataGridView_PKK.DataSource = SourceDT;

            foreach (DataGridViewColumn column in dataGridView_PKK.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        DataService ds = new DataService();
        //
        // Variables
        //
        string path;
        int rowIndex;

        //
        //buttonHelp_PKK
        //
        private void buttonAbout_PKK_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonAbout_PKK_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Справка";
            buttonAbout_PKK.BackColor = Color.SteelBlue;
        }
        private void buttonAbout_PKK_MouseLeave(object sender, EventArgs e)
        {
            buttonAbout_PKK.BackColor = Color.CornflowerBlue;
        }

        //
        //buttonHelp_PKK
        //
        private void buttonHelp_PKK_Click(object sender, EventArgs e)
        {
            FormHelp formHelp = new FormHelp();
            formHelp.ShowDialog();
        }
        private void buttonHelp_PKK_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Помощь";
            buttonHelp_PKK.BackColor = Color.Tomato;
        }
        private void buttonHelp_PKK_MouseLeave(object sender, EventArgs e)
        {
            buttonHelp_PKK.BackColor = Color.LightSalmon;
        }

        private void dataGridView_PKK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rowIndex = e.RowIndex;
            }
        }

        //
        //buttonOpenFile_PKK
        //
        private void buttonOpenFile_PKK_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Открыть файл";
        }
        private void buttonOpenFile_PKK_Click(object sender, EventArgs e)
        {
            dataGridView_PKK.Columns.Clear();
            dataGridView_PKK.DataSource = SourceDT;
            foreach (DataGridViewColumn column in dataGridView_PKK.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            openFileDialog_PKK.ShowDialog();
            path = openFileDialog_PKK.FileName;

            DataTable dt = new DataTable();

            try
            {
                dt = SourceDT.Clone();
                using (var reader = new StreamReader(path, Encoding.UTF8))
                {
                    while (!reader.EndOfStream)
                    {
                        string line = reader.ReadLine();
                        string[] values = line.Split(';');
                        DataRow row = dt.NewRow();

                        for (int i = 0; i < Math.Min(values.Length, dt.Columns.Count); i++)
                        {
                            string value = values[i].Trim();
                            int n;
                            bool isNumerical = int.TryParse(value, out n);
                            double k;
                            bool isDouble = double.TryParse(value, out k);
                            DateTime f;
                            bool isDate = DateTime.TryParse(value, out f);
                            if (isDouble)
                            {
                                if (isNumerical)
                                {
                                    row[i] = n;
                                }
                                else
                                {
                                    row[i] = k;
                                }
                            }
                            else
                            {
                                if (!isDate)
                                {
                                    row[i] = value;
                                }
                                else
                                {
                                    row[i] = f;
                                }
                            }

                        }
                        dt.Rows.Add(row);
                    }
                }

                dataGridView_PKK.Columns.Clear();
                dataGridView_PKK.DataSource = dt;

                foreach (DataGridViewColumn column in dataGridView_PKK.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }

                buttonRowsAdd_PKK.Enabled = true;
                buttonSaveFile_PKK.Enabled = true;
                buttonSearch_PKK.Enabled = true;
                buttonVisualize_PKK.Enabled = true;
                buttonSaveFile_PKK.Enabled = true;
                buttonRowsDelete_PKK.Enabled = true;
                buttonColumnsAdd_PKK.Enabled = true;
                buttonColumnsDelete_PKK.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //
        //buttonSaveFile_PKK
        //
        private void buttonSaveFile_PKK_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Сохранить файл";
        }
        private void buttonSaveFile_PKK_Click(object sender, EventArgs e)
        {
            saveFileDialog_PKK.FileName = "SavedData.csv";
            saveFileDialog_PKK.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_PKK.ShowDialog();

            string path = saveFileDialog_PKK.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;

            if (fileExist)
            {
                File.Delete(path);
            }
            using (StreamWriter writer = new StreamWriter(path, false, Encoding.UTF8))
            {
                for (int i = 0; i < dataGridView_PKK.Columns.Count; i++)
                {
                    writer.Write(dataGridView_PKK.Columns[i].HeaderText);
                    if (i < dataGridView_PKK.Columns.Count - 1)
                    {
                        writer.Write(";");
                    }
                }
                writer.WriteLine();

                foreach (DataGridViewRow row in dataGridView_PKK.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        for (int i = 0; i < dataGridView_PKK.Columns.Count; i++)
                        {
                            writer.Write(row.Cells[i].Value?.ToString() ?? string.Empty);
                            if (i < dataGridView_PKK.Columns.Count - 1)
                            {
                                writer.Write(";");
                            }
                        }
                        writer.WriteLine();
                    }
                }
            }
        }
        //
        //Search
        //
        private void buttonSearch_PKK_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Поиск";
        }
        private void buttonSearch_PKK_Click(object sender, EventArgs e)
        {
            SearchHighLight(textBoxSearch_PKK.Text);
        }

        private void SearchHighLight(string searchtext)
        {
            if (!(dataGridView_PKK.DataSource is DataTable dt)) return;

            dataGridView_PKK.ClearSelection();
            ClearHighLight();

            if (string.IsNullOrEmpty(searchtext))
            {
                dt.DefaultView.RowFilter = "";
                return;
            }

            string filterExpression = string.Join(" OR ", dt.Columns.Cast<DataColumn>().Select(c => $"Convert([{c.ColumnName}], 'System.String') LIKE '%{searchtext}%'"));
            try
            {
                dt.DefaultView.RowFilter = filterExpression;

                if (dt.DefaultView.Count == 0)
                {
                    MessageBox.Show("Результатов не найдено.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                foreach (DataGridViewRow row in dataGridView_PKK.Rows)
                {
                    if (row.Visible)
                    {
                        for (int i = 0; i < row.Cells.Count; i++)
                        {
                            if (row.Cells[i].Value != null && row.Cells[i].Value.ToString().Contains(searchtext, StringComparison.OrdinalIgnoreCase))
                            {
                                row.Cells[i].Style.BackColor = Color.CornflowerBlue;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка поиска: {ex.Message}");
                dt.DefaultView.RowFilter = "";
            }
        }

        private void ClearHighLight()
        {
            foreach (DataGridViewRow row in dataGridView_PKK.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                }
            }
        }

        //
        //Edit
        //
        private void buttonRowsAdd_PKK_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Добавить";
        }
        private void buttonRowsAdd_PKK_Click(object sender, EventArgs e)
        {
            if (dataGridView_PKK.DataSource is DataTable dt)
            {
                DataRow row = dt.NewRow();
                dt.Rows.Add(row);
            }
            else
            {
                MessageBox.Show("Нет активного источника данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRowsDelete_PKK_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Удалить";
        }
        private void buttonRowsDelete_PKK_Click(object sender, EventArgs e)
        {
            if (dataGridView_PKK.SelectedCells.Count == 0)
            {
                MessageBox.Show("Выберите строку для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int rowIndex = dataGridView_PKK.SelectedCells[0].RowIndex;


            if (rowIndex < 0 || rowIndex >= dataGridView_PKK.Rows.Count) return;

            DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить данную строку ?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    dataGridView_PKK.Rows.RemoveAt(rowIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при удалении столбца: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonColumnsAdd_PKK_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Добавить";
        }
        private void buttonColumnsAdd_PKK_Click(object sender, EventArgs e)
        {
            dataGridView_PKK.Columns.Add("NewColumn", $"{textBoxColumnName_PKK.Text}");
        }

        private void buttonColumnsDelete_PKK_MouseEnter(object sender, EventArgs e)
        {
            toolTip.ToolTipTitle = "Удалить";
        }
        private void buttonColumnsDelete_PKK_Click(object sender, EventArgs e)
        {
            if (dataGridView_PKK.SelectedCells.Count == 0)
            {
                MessageBox.Show("Выберите столбец для удаления", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int columnIndex = dataGridView_PKK.SelectedCells[0].ColumnIndex;


            if (columnIndex < 0 || columnIndex >= dataGridView_PKK.Columns.Count) return;

            DialogResult dialogResult = MessageBox.Show($"Вы действительно хотите удалить столбец '{dataGridView_PKK.Columns[columnIndex].HeaderText}'?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    dataGridView_PKK.Columns.RemoveAt(columnIndex);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Произошла ошибка при удалении столбца: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UpdateChart(Dictionary<string, int> valueCounts)
        {
            chartVisualize_PKK.Series.Clear();
            chartVisualize_PKK.ChartAreas[0].AxisX.CustomLabels.Clear();
            chartVisualize_PKK.ChartAreas[0].AxisX.Title = "Значения";
            chartVisualize_PKK.ChartAreas[0].AxisY.Title = "Количество";

            int xPosition = 0;
            foreach (var pair in valueCounts)
            {
                Series series = new Series(pair.Key);
                series.Points.AddXY(xPosition, pair.Value);
                chartVisualize_PKK.Series.Add(series);
                chartVisualize_PKK.ChartAreas[0].AxisX.CustomLabels.Add(xPosition, xPosition + 1, pair.Key);
                xPosition++;
            }

            chartVisualize_PKK.ChartAreas[0].AxisX.IsLabelAutoFit = false;
            chartVisualize_PKK.ChartAreas[0].AxisX.Interval = 1;
        }
        private void AnalyzeColumn(int columnIndex)
        {
            List<string> columnValues = new List<string>();
            foreach (DataGridViewRow row in dataGridView_PKK.Rows)
            {
                if (!row.IsNewRow && row.Cells[columnIndex].Value != null)
                {
                    columnValues.Add(row.Cells[columnIndex].Value.ToString());
                }
            }

            var valueCounts = columnValues.GroupBy(x => x).ToDictionary(group => group.Key, group => group.Count());

            UpdateChart(valueCounts);
        }
        private void buttonVisualize_PKK_Click(object sender, EventArgs e)
        {
            AnalyzeColumn(4);
        }
    }
}
