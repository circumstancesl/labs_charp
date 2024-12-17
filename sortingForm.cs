using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace dichotomy_method
{
    public partial class sortingForm : Form, ISortView
    {
        BackgroundWorker _backgroundWorker = new BackgroundWorker();
        string path = "temporary";
        private double[] savedArray;
        private bool _isTest = false;
        private bool _IsFilesExist = false;
        private int _progress = 0;

        public sortingForm()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
            _backgroundWorker = new BackgroundWorker();
            _backgroundWorker.WorkerSupportsCancellation = true;
            _backgroundWorker.WorkerReportsProgress = true;
            _backgroundWorker.DoWork += _backgroundWorkerDoWork;
            _backgroundWorker.ProgressChanged += _backgroundWorkerProgressChanged;
            _backgroundWorker.RunWorkerCompleted += _backgroundWorkerRunWorkerCompleted;
        }

        private void _backgroundWorkerDoWork(object sender, DoWorkEventArgs inputEvent)
        {
            double[] array = (double[])inputEvent.Argument;
            List<double> list = new List<double>();
            for (int inputIndex = 0; inputIndex < array.Length; ++inputIndex)
            {
                list.Add(array[inputIndex]);
                int progress = Convert.ToInt32(inputIndex / Convert.ToDouble(array.Length) * 100);
                _backgroundWorker.ReportProgress(progress);
            }
            inputEvent.Result = list;
        }

        private void _backgroundWorkerRunWorkerCompleted(object sender, RunWorkerCompletedEventArgs inputEvent)
        {
            List<double> dataList = (List<double>)inputEvent.Result;
            foreach (double data in dataList)
            {
                dataGridView1.Rows.Add(data);
            }
            if (_isTest)
            {
                Sort(sender, inputEvent);
                _isTest = false;
            }
            MessageBox.Show("Ввод завершён");

        }

        private void _backgroundWorkerProgressChanged(object sender, ProgressChangedEventArgs inputEvent)
        {
            progressBar1.Value = inputEvent.ProgressPercentage;
        }

        int ISortView.ArraySizeToRandom()
        {
            if (txtBoxCountNumbers.Text.Length == 0 || txtBoxCountNumbers.Text == "0")
            {
                return 10;
            }
            return Convert.ToInt32(txtBoxCountNumbers.Text);
        }

        int ISortView.leftInterval()
        {

            if (txtBoxLeftLimit.Text.Length == 0)
            {
                return 10;
            }
            return Convert.ToInt32(txtBoxLeftLimit.Text);
        }

        int ISortView.rightInterval()
        {
            if (txtBoxRightLimit.Text.Length == 0)
            {
                return 10;
            }
            return Convert.ToInt32(txtBoxRightLimit.Text);
        }

        string ISortView.PathToFile()
        {
            return path;
        }

        void ISortView.ChooseInput(double[] inputArray)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = true;
            if (Double.IsNaN(inputArray[0]))
            {
                savedArray = inputArray;
            }
            else
            {
                savedArray = inputArray;
            }

        }

        void ISortView.ShowSortResult(string[] methodName, int[] methodIterations, double[] methodTime, List<double[]> sortedArrays)
        {
            dataGridView2.Rows.Clear();
            int rowCount = Math.Max(methodName.Length, Math.Max(methodIterations.Length, methodTime.Length));
            for (int index = 0; index < rowCount; ++index)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell { Value = methodName[index] });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = methodIterations[index] });
                row.Cells.Add(new DataGridViewTextBoxCell { Value = methodTime[index] });
                _IsFilesExist = true;
                if (sortedArrays.Count != 0 && sortedArrays.Count > index)
                {
                    string tempFilePath = Path.Combine(System.Windows.Forms.Application.StartupPath, methodName[index].ToString());
                    List<string> strings = new List<string>();
                    double[] tempArray = sortedArrays[index];
                    foreach (double number in tempArray)
                    {
                        strings.Add(number.ToString());
                    }
                    DataGridViewButtonCell buttonCell = new DataGridViewButtonCell();
                    buttonCell.Value = "открыть файл";
                    buttonCell.Tag = tempFilePath;
                    row.Cells.Add(buttonCell);
                    File.WriteAllLines(tempFilePath, strings);
                }
                dataGridView2.Rows.Add(row);
            }
        }

        byte ISortView.StartInput()
        {
            byte inputMethod = 0;
            if (rbtnManual.Checked)
            {
                inputMethod = 1;
            }
            if (rbtnGeneration.Checked)
            {
                inputMethod = 2;
            }
            if (rbtnFile.Checked)
            {
                inputMethod = 3;
            }
            return inputMethod;
        }

        bool ISortView.IsIncreasing()
        {
            if (rbtnIncrease.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        double[] ISortView.NumbersToSort()
        {
            double[] numbers = new double[dataGridView1.Rows.Count - 1];
            try
            {
                for (int index = 0; index < dataGridView1.Rows.Count - 1; ++index)
                {
                    if (dataGridView1.Rows[index].Cells[0].Value != " ")
                    {
                        double value = Convert.ToDouble(dataGridView1.Rows[index].Cells[0].Value);
                        numbers[index] = value;
                    }
                    else
                    {
                        MessageBox.Show("В массиве для сортировки обнаружена пустота. Включено автозаполнение 0.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        numbers[index] = 0;
                    }
                }
                return numbers;
            }
            catch (FormatException)
            {
                MessageBox.Show("Буквы сортировать нельзя. Включено автозаполнение 0", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return numbers;
        }

        bool ISortView.IsActiveBubble()
        {
            if (bubble.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool ISortView.IsActiveInserts()
        {
            if (inserts.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool ISortView.IsActiveFast()
        {
            if (fast.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool ISortView.IsActiveShake()
        {
            if (shake.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool ISortView.IsActiveSwamp()
        {
            if (swamp.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool ISortView.IsDouble()
        {
            if (rbtnDouble.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        double ISortView.SwampsIterations()
        {
            Regex regex = new Regex(@"^[\d]+$");
            bool mathces;
            if (string.IsNullOrEmpty(maxIterations.Text) || (mathces = regex.IsMatch(maxIterations.Text)) == true)
            {
                return Convert.ToDouble(maxIterations.Text);
            }
            else
            {
                return 1000;
            }
        }

        public void UpdateProgress(int progress)
        {
            progressBar1.Value = progress;
        }

        public event EventHandler<EventArgs> AddData;
        public event EventHandler<EventArgs> Sort;

        private void SetDataGridView(DataGridView dataGridView, int row, int cell)
        {
            dataGridView.CurrentCell = dataGridView.Rows[0].Cells[0];
            dataGridView.BeginEdit(true);
        }

        private bool ValidateText()
        {
            Regex regex = new Regex(@"^[\d]+$");
            bool result = true;
            if (rbtnManual.Checked)
            {
                return true;
            }
            bool mathces;
            if (string.IsNullOrEmpty(txtBoxCountNumbers.Text) || (mathces = regex.IsMatch(txtBoxCountNumbers.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода числа генерируемых чисел для массива", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(maxIterations.Text) || (mathces = regex.IsMatch(maxIterations.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода числа итераций для болотной сортировки", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtBoxLeftLimit.Text) || (mathces = regex.IsMatch(txtBoxLeftLimit.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода левого значения интервала", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtBoxRightLimit.Text) || (mathces = regex.IsMatch(txtBoxRightLimit.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода правого значения интервала", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private bool ValidateGrid(DataGridView inputGrid)
        {
            bool Isgood = true;
            bool IsLast = false;
            foreach (DataGridViewRow row in inputGrid.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value == null || cell.Value.ToString() == " ")
                    {
                        if (IsLast)
                        {
                            Isgood = false;
                            MessageBox.Show("В массиве для сортировки есть пустоты. Отмена операции", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        IsLast = true;
                    }
                }
            }
            return Isgood;
        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {
            if (ValidateText())
            {
                AddData(sender, e);
                if (!double.IsNaN(savedArray[0]))
                {
                    _backgroundWorker.RunWorkerAsync(savedArray);
                }
            }
        }

        private void toolStripTextBox2_Click_1(object sender, EventArgs e)
        {
            if (ValidateText() && ValidateGrid(dataGridView1))
            {
                Sort(sender, e);
            }
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
            }
        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                string path = dataGridView2.Rows[e.RowIndex].Cells[3].Tag.ToString();
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("notepad.exe", path));
            }
        }
    }
}
