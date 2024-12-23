using OxyPlot.Series;
using OxyPlot;
using SixLabors.ImageSharp;
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

namespace dichotomy_method
{
    public partial class integralForm : Form, IIntegralView
    {
        private Regex regex = new Regex(@"^[\d,-]+$");
        public integralForm()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        double IIntegralView.Interval()
        {
            bool matches;
            if (string.IsNullOrEmpty(txtBoxOxes.Text) || (matches = regex.IsMatch(txtBoxOxes.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода числа построения осей", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;

            }
            else
            {
                return Convert.ToDouble(txtBoxOxes.Text);
            }

        }

        double IIntegralView.upLimit()
        {
            bool matches;
            if (string.IsNullOrEmpty(upBorder.Text) || (matches = regex.IsMatch(upBorder.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода верхнего значения интеграла", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {

                return Convert.ToDouble(upBorder.Text);
            }

        }

        double IIntegralView.lowLimit()
        {
            bool matches;
            if (string.IsNullOrEmpty(lowBorder.Text) || (matches = regex.IsMatch(lowBorder.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода нижнего значения интеграла", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            else
            {
                return Convert.ToDouble(lowBorder.Text);
            }
        }

        double IIntegralView.Accuracy()
        {
            bool matches;
            if (string.IsNullOrEmpty(txtBoxAccuracy.Text) || (matches = regex.IsMatch(txtBoxAccuracy.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода значения точности", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;

            }
            else
            {
                return Convert.ToDouble(txtBoxAccuracy.Text);
            }
        }

        int IIntegralView.IntegralIntervalCount()
        {
            bool matches;
            if (string.IsNullOrEmpty(txtBoxN.Text) || (matches = regex.IsMatch(txtBoxN.Text)) == false)
            {
                MessageBox.Show("Ошибка ввода значения количества интервалов", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 2;
            }
            else
            {
                int intervalCount = Convert.ToInt32(txtBoxN.Text);

                // Проверка для метода Симпсона
                if (chkBoxSimpson.Checked)
                {
                    if (intervalCount < 2)
                    {
                        MessageBox.Show("Количество интервалов должно быть не меньше 2 для метода Симпсона. Вставлено значение 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 2;
                    }
                    if (intervalCount % 2 != 0)
                    {
                        MessageBox.Show("Количество интервалов должно быть четным для метода Симпсона. Вставлено значение 2", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return 2;
                    }
                }

                return intervalCount;
            }
        }

        void IIntegralView.UpdateGraph(List<double[]> inputArr, byte choice)
        {
            var plotModel = this.pvGraph.Model;
            if (choice == 0 && chkBoxRecViz.Checked)
            {
                var lineSeries = new LineSeries
                {
                    Title = "Метод прямоугольников",
                    Color = OxyColor.FromRgb(0, 128, 0)
                };
                foreach (var line in inputArr)
                {
                    lineSeries.Points.Add(new DataPoint(line[0], line[1]));
                }
                plotModel.Series.Add(lineSeries);
                this.pvGraph.Model = plotModel;
            }
            else if (choice == 1 && chkBoxTrapViz.Checked)
            {
                var lineSeries = new LineSeries
                {
                    Title = "Метод трапеций",
                    Color = OxyColor.FromRgb(0, 0, 0)
                };
                foreach (var line in inputArr)
                {
                    lineSeries.Points.Add(new DataPoint(line[0], line[1]));
                }
                plotModel.Series.Add(lineSeries);
                this.pvGraph.Model = plotModel;
            }
            else if (choice == 2 && chkBoxSimpsonViz.Checked)
            {
                var lineSeries = new LineSeries
                {
                    Title = "Метод Симпсона",
                    Color = OxyColor.FromRgb(153, 50, 204)
                };
                foreach (var line in inputArr)
                {
                    lineSeries.Points.Add(new DataPoint(line[0], line[1]));
                }
                plotModel.Series.Add(lineSeries);
                this.pvGraph.Model = plotModel;
            }

        }
        bool IIntegralView.IsRectangleActive()
        {
            if (chkBoxRectangle.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool IIntegralView.IsTrapezoidActive()
        {
            if (chkBoxTrapz.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        bool IIntegralView.IsSimpsonActive()
        {
            if (chkBoxSimpson.Checked)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        void IIntegralView.ShowResult(double[] inputArray)
        {
            if (txtBoxAccuracy.Text.Length != 0)
            {
                inputArray[0] = Math.Truncate(inputArray[0] * Math.Pow(10, Convert.ToInt32(txtBoxAccuracy.Text))) / Math.Pow(10, Convert.ToInt32(txtBoxAccuracy.Text));
                inputArray[1] = Math.Truncate(inputArray[1] * Math.Pow(10, Convert.ToInt32(txtBoxAccuracy.Text))) / Math.Pow(10, Convert.ToInt32(txtBoxAccuracy.Text));
                inputArray[2] = Math.Truncate(inputArray[2] * Math.Pow(10, Convert.ToInt32(txtBoxAccuracy.Text))) / Math.Pow(10, Convert.ToInt32(txtBoxAccuracy.Text));
            }
            rectangleResult.Text = inputArray[0].ToString();
            trapezoidResult.Text = inputArray[1].ToString();
            simpsonResult.Text = inputArray[2].ToString();

        }

        void IIntegralView.ReverseResult(int countOfIterations)
        {
            MessageBox.Show("Необходимое n = " + countOfIterations, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        string IIntegralView.returnFunction()
        {
            return txtBoxFunction.Text;
        }

        void IIntegralView.ShowGraph(PlotModel plotModel)
        {
            this.pvGraph.Model = plotModel;
        }

        public event EventHandler<EventArgs> CreateIntegralGraph;
        public event EventHandler<EventArgs> Calculate;
        public event EventHandler<EventArgs> ReverseMode;

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            CreateIntegralGraph(sender, e);
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            Calculate(sender, e);
        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {
            ReverseMode(sender, e);
        }
    }
}
