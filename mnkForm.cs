using MathNet.Numerics;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using OxyPlot.Series;
using OxyPlot;
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
using System.Numerics;

namespace dichotomy_method
{
    public partial class mnkForm : Form, IMNKView
    {
        private string pathToFile = "temporary";
        double[] pointNumberX = new double[5];
        double[] pointNumberY = new double[5];
        public mnkForm()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        double[] IMNKView.GetXValue()
        {
            double[] valuesOFX = new double[dataGridView1.Rows.Count - 1];

            for (int indexOfX = 0; indexOfX < dataGridView1.Rows.Count - 1; ++indexOfX)
            {
                if (dataGridView1.Rows[indexOfX].Cells[0].Value == null)
                {
                    MessageBox.Show($"Ячейка X[{indexOfX}] пуста. Заменяем на 1.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dataGridView1.Rows[indexOfX].Cells[0].Value = 1;
                    valuesOFX[indexOfX] = 1;
                }
                else if (double.TryParse(dataGridView1.Rows[indexOfX].Cells[0].Value.ToString(), out double parsedValue))
                {
                    valuesOFX[indexOfX] = parsedValue;
                }
                else
                {
                    MessageBox.Show($"Ячейка X[{indexOfX}] содержит недопустимые символы. Заменяем на 1.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dataGridView1.Rows[indexOfX].Cells[0].Value = 1;
                    valuesOFX[indexOfX] = 1;
                }
            }
            pointNumberX = valuesOFX;
            return valuesOFX;
        }

        double[] IMNKView.GetYValue()
        {
            double[] valuesOFY = new double[dataGridView1.Rows.Count - 1];

            for (int indexOfY = 0; indexOfY < dataGridView1.Rows.Count - 1; ++indexOfY)
            {
                if (dataGridView1.Rows[indexOfY].Cells[1].Value == null)
                {
                    MessageBox.Show($"Ячейка Y[{indexOfY}] пуста. Заменяем на 1.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    valuesOFY[indexOfY] = 1;
                    dataGridView1.Rows[indexOfY].Cells[1].Value = 1;
                }
                else if (double.TryParse(dataGridView1.Rows[indexOfY].Cells[1].Value.ToString(), out double parsedValue))
                {
                    valuesOFY[indexOfY] = parsedValue;
                }
                else
                {
                    MessageBox.Show($"Ячейка Y[{indexOfY}] содержит недопустимые символы. Заменяем на 1.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    valuesOFY[indexOfY] = 1;
                    dataGridView1.Rows[indexOfY].Cells[1].Value = 1;
                }
            }
            pointNumberY = valuesOFY;
            return valuesOFY;
        }

        int IMNKView.Points()
        {
            if (int.TryParse(graphPoints.Text, out int points))
            {
                // Если значение отрицательное или равно 0, возвращаем 5
                if (points <= 0)
                {
                    MessageBox.Show("Количество точек не может быть отрицательным или равным нулю. Устанавливаем значение 100.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    graphPoints.Text = "100";
                    return 100;
                }
                return points; // Возвращаем корректное значение
            }
            else
            {
                // Если преобразование не удалось, возвращаем 5 и выводим сообщение
                MessageBox.Show("Некорректное значение для количества точек. Устанавливаем значение 100.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                graphPoints.Text = "100";
                return 100;
            }
        }

        bool IMNKView.IsLinear()
        {
            if (linear.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void IMNKView.ShowResult(double[] result, OxyPlot.PlotModel plotModel)
        {
            Regex regex = new Regex(@"^[\d,-]+$");
            int accuracy;
            if (string.IsNullOrEmpty(txtBoxOcr.Text) || (regex.IsMatch(txtBoxOcr.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода точности. Присвоено значение 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                accuracy = 2;
                txtBoxOcr.Text = "2";
            }
            else if (int.TryParse(txtBoxOcr.Text, out int parsedValue) && parsedValue < 0)
            {
                // Проверка на отрицательные значения
                MessageBox.Show("Точность не может быть отрицательной. Присвоено значение 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBoxOcr.Text = "2";
                accuracy = 2;
            }
            else
            {
                accuracy = Convert.ToInt32(txtBoxOcr.Text);
            }
            string resultString = "";
            if (result != null)
            {
                for (int outputIndex = 0; outputIndex < result.Length; ++outputIndex)
                {
                    if (outputIndex == 0)
                    {
                        resultString += "a" + " = " + Math.Round(result[outputIndex], accuracy).ToString() + "\n";
                    }
                    else if (outputIndex == 1)
                    {
                        resultString += "b" + " = " + Math.Round(result[outputIndex], accuracy).ToString() + "\n";
                    }
                    else if (outputIndex == 2)
                    {
                        resultString += "c" + " = " + Math.Round(result[outputIndex], accuracy).ToString() + "\n";
                    }

                }

            }
            var series = new LineSeries();
            series.MarkerType = MarkerType.Circle;
            series.Color = OxyColors.DarkOliveGreen;
            series.MarkerSize = 5;
            var points = new List<DataPoint>();
            for (int outputIndex = 0; outputIndex < pointNumberX.Length; outputIndex++)
            {
                points.Add(new DataPoint(pointNumberX[outputIndex], pointNumberY[outputIndex]));
                points.Add(new DataPoint(double.NaN, double.NaN));
            }


            series.ItemsSource = points;

            plotView1.Model = plotModel;
            plotModel.Series.Add(series);
            plotView1.Model = plotModel;
            MessageBox.Show(resultString, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public event EventHandler<EventArgs> Calculate;

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            Calculate(sender, e);
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            dataGridView1.AllowUserToAddRows = false;
            Regex regex = new Regex(@"^[\d,-]+$");
            bool result = true;
            bool mathces;
            int matrixCount = 1;
            int rowsCount = 1;
            int Interval = 5;
            if (string.IsNullOrEmpty(txtBoxMatrix.Text) || (regex.IsMatch(txtBoxMatrix.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода количества точек. Присвоено значене 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                matrixCount = 1;
                txtBoxMatrix.Text = "1";
            }
            else if (int.TryParse(txtBoxMatrix.Text, out int parsedValue) && parsedValue < 0)
            {
                // Проверка на отрицательные значения
                MessageBox.Show("Количество точек не может быть отрицательным. Присвоено значение 1", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                matrixCount = 1;
                txtBoxMatrix.Text = "1";
            }
            else
            {
                rowsCount = Convert.ToInt32(txtBoxMatrix.Text);
            }

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            dataGridView1.Columns.Add("X", "X");
            dataGridView1.Columns.Add("Y", "Y");
            if (rbtnManual.Checked)
            {

                for (int inputIndex = 0; inputIndex < rowsCount; ++inputIndex)
                {
                    dataGridView1.Rows.Add();
                }
            }
            else if (rbtnFile.Checked)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pathToFile = openFileDialog1.FileName;
                }
                if (pathToFile != "temporary")
                {
                    if (pathToFile.Contains("xlsx"))
                    {
                        using (FileStream file = new FileStream(pathToFile, FileMode.Open, FileAccess.Read))
                        {
                            IWorkbook workbook = new XSSFWorkbook(file);
                            ISheet sheet = workbook.GetSheetAt(0);

                            for (int excelIndex = 0; excelIndex <= sheet.LastRowNum; ++excelIndex)
                            {
                                IRow currentrow = sheet.GetRow(excelIndex);
                                if (currentrow != null)
                                {
                                    ICell cell = currentrow.GetCell(0);
                                    ICell Secondcell = currentrow.GetCell(1);
                                    if (cell != null)
                                    {
                                        dataGridView1.Rows.Add(cell.NumericCellValue, Secondcell.NumericCellValue);
                                    }
                                }

                            }
                        }
                    }
                    else if (pathToFile.Contains("txt"))
                    {
                        string text = File.ReadAllText(pathToFile);
                        string[] lines = text.Split('\n');


                        foreach (string line in lines)
                        {
                            string[] numbers = line.Split(' ');
                            if (numbers.Length == 2)
                            {
                                int value1 = int.Parse(numbers[0]);
                                int value2 = int.Parse(numbers[1]);
                                dataGridView1.Rows.Add(value1, value2);
                            }
                        }
                    }

                }

            }
            else if (rbtnGenerate.Checked)
            {
                int maxValue = 1;
                int minValue = 1;
                Random random = new Random();
                if (string.IsNullOrEmpty(minNumber.Text) || (regex.IsMatch(minNumber.Text)) == false)
                {
                    MessageBox.Show("Ошибка ввода минимального значения", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    minValue = Convert.ToInt32(minNumber.Text);
                }

                if (string.IsNullOrEmpty(maxNumber.Text) || (regex.IsMatch(maxNumber.Text)) == false)
                {
                    MessageBox.Show("Ошибка ввода максимального значения", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    maxValue = Convert.ToInt32(maxNumber.Text);
                }
                for (int randomIndex = 0; randomIndex < rowsCount; ++randomIndex)
                {
                    dataGridView1.Rows.Add(random.Next(minValue, maxValue), random.Next(minValue, maxValue));
                }
            }
        }
    }
}
