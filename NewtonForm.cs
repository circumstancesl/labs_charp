using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace dichotomy_method
{
    public partial class NewtonForm : Form, IView
    {
        private bool checkExistence = false;

        public NewtonForm()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
        }

        double IView.lowLimit()
        {
            return Convert.ToDouble(txtBoxFunctionLimit.Text);
        }

        double IView.upLimit()
        {
            return Convert.ToDouble(txtBox.Text);
        }

        double IView.iterationCount()
        {
            return Convert.ToDouble(txtBoxIteration.Text);
        }

        byte IView.Choice()
        {
            byte choice = 1;
            if (rbtn1.Checked)
            {
                choice = 1;
            }
            else if (rbtn2.Checked)
            {
                choice = 2;
            }
            else if (rbtn3.Checked)
            {
                choice = 3;
            }
            return choice;
        }

        string IView.returnFunction()
        {
            if (txtBoxFunction.Text.Contains("x"))
            {
                return txtBoxFunction.Text;
            }
            else
            {
                MessageBox.Show("Нет функции", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "x";
            }
        }

        double IView.firstSide()
        {
            return Convert.ToDouble(txtBoxFirstIntervalLim.Text);
        }

        double IView.Interval()
        {
            return Convert.ToDouble(txtBoxInterval.Text);
        }

        double IView.secondSide()
        {
            return Convert.ToDouble(txtBoxSecondIntervalLim.Text);
        }

        double IView.epsilon()
        {
            return Convert.ToDouble(txtBoxEpsilon.Text);
        }

        void IView.UpdateGraph(List<double[]> inputArr)
        {
            var plotModel = this.pvGraph.Model;
            var lineSeries = new LineSeries
            {
                Title = "точки производной",
                Color = OxyColor.FromRgb(0, 128, 0)
            };
            foreach (var line in inputArr)
            {
                lineSeries.Points.Add(new DataPoint(line[0], line[1]));
            }
            plotModel.Series.Add(lineSeries);
            this.pvGraph.Model = plotModel;
        }

        bool IView.MinimumOrMaximum()
        {
            return true;
        }

        public event EventHandler<EventArgs> StartDichotomy;
        public event EventHandler<EventArgs> CreateGraph;
        public event EventHandler<EventArgs> StartGoldenRatio;
        public event EventHandler<EventArgs> StartNewton;

        void IView.ShowGraph(PlotModel plotModel)
        {
            this.pvGraph.Model = plotModel;
            checkExistence = true;
        }
        void IView.ShowResult(double result, double functionResult)
        {
            result = Math.Round(result, Convert.ToInt16(txtBoxLimitation.Text));
            functionResult = Math.Round(functionResult, Convert.ToInt16(txtBoxLimitation.Text));
            if (double.IsNaN(result) && !double.IsNaN(functionResult))
            {
                MessageBox.Show("Метод остановлен: производная достигла 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!double.IsNaN(result) && double.IsNaN(functionResult))
            {
                if (rbtn2.Checked)
                {
                    MessageBox.Show("Метод остановлен: найден максимум, а не минимум. Измените начальное приближение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (rbtn3.Checked)
                {
                    MessageBox.Show("Метод остановлен: найден минимум, а не максимум. Измените начальное приближение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (double.IsNaN(result) && double.IsNaN(functionResult))
            {
                MessageBox.Show("Метод остановлен: за введённое число итераций он не подошёл к точке. Проверьте, есть ли у функции точки минимума или максимума, либо увеличьте число итераций", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (rbtn2.Checked)
                {
                    MessageBox.Show("Минимум:" + result.ToString() + "\n" + "Значение минимума:" + functionResult.ToString(), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbtn3.Checked)
                {
                    functionResult = Math.Abs(functionResult);
                    MessageBox.Show("Максимум:" + result.ToString() + "\n" + "Значение максимума:" + functionResult.ToString(), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (rbtn1.Checked)
                {
                    MessageBox.Show("Точка пересечения:" + result.ToString(), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }


        }


        private bool ValidateText()
        {
            Regex regex = new Regex(@"^[\d,-]+$");
            bool result = true;
            bool mathces;
            if (string.IsNullOrEmpty(txtBoxFirstIntervalLim.Text) || (mathces = regex.IsMatch(txtBoxFirstIntervalLim.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода начального приближения", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtBoxSecondIntervalLim.Text) || (mathces = regex.IsMatch(txtBoxSecondIntervalLim.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения численного дифференциала", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtBoxEpsilon.Text) || (mathces = regex.IsMatch(txtBoxEpsilon.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения epsilon", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtBoxLimitation.Text) || (mathces = regex.IsMatch(txtBoxLimitation.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения требуемой точности", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtBoxInterval.Text) || (mathces = regex.IsMatch(txtBoxInterval.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения числа точек построения осей", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtBoxFunctionLimit.Text) || (mathces = regex.IsMatch(txtBoxFunctionLimit.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения числа точек построения отрицательной стороны  функции", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtBox.Text) || (mathces = regex.IsMatch(txtBox.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения числа точек построения положительной стороны функции", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtBoxIteration.Text) || (mathces = regex.IsMatch(txtBoxIteration.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода значения числа итераций", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            if (ValidateText())
            {
                CreateGraph(sender, e);
            }
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            if (ValidateText())
            {
                if (checkExistence)
                {
                    CreateGraph(sender, e);
                    StartNewton(sender, e);
                }
                else
                {
                    MessageBox.Show("Не задана функция и не построен график", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
