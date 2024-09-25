using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;
using System.Text.RegularExpressions;

namespace dichotomy_method
{
    public partial class dichotomyForm : Form, IView
    {
        private Expression expression;
        private Function Function;
        public dichotomyForm()
        {
            InitializeComponent();
            Presenter presenter = new Presenter(this);
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

        Expression IView.Expression()
        {
            return expression;
        }

        Function IView.Function()
        {
            return Function;
        }

        public event EventHandler<EventArgs> StartDichotomy;

        void IView.ShowResult(double result, double errorCheck)
        {
            if (errorCheck != 1)
            {
                result = Math.Round(result, Convert.ToInt16(txtBoxLimitation.Text));
                MessageBox.Show("Результат:" + result.ToString(), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("В выбранном интервале корней нет", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Ошибка ввода левого ограничения интервала", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(txtBoxSecondIntervalLim.Text) || (mathces = regex.IsMatch(txtBoxSecondIntervalLim.Text)) == false)
            {
                result = false;
                MessageBox.Show("Ошибка ввода правого ограничения интервала", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            return result;
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            if (ValidateText())
            {
                double limit = Convert.ToDouble(txtBoxInterval.Text);
                double functionLimit = Convert.ToDouble(txtBoxFunctionLimit.Text);
                double upFunctionLimit = Convert.ToDouble(txtBox.Text);
                double xIntercept = double.NaN;
                List<DataPoint> dot = new List<DataPoint>();

                var plotModel = new PlotModel { Title = "График функции f(x)" };


                var dataPoints = new List<double> { 0 };


                var absicc = new LineSeries
                {
                    Title = "Абсцисс",
                    Color = OxyColor.FromRgb(255, 0, 0),
                    StrokeThickness = 2
                };

                absicc.Points.Add(new DataPoint(-limit, 0));
                absicc.Points.Add(new DataPoint(limit, 0));

                var ordinate = new LineSeries
                {
                    Title = "Ординат",
                    Color = OxyColor.FromRgb(255, 0, 0),
                    StrokeThickness = 2,
                };

                ordinate.Points.Add(new DataPoint(0, limit));
                ordinate.Points.Add(new DataPoint(0, -limit));

                // Создаем серию точек графика
                var lineSeries = new LineSeries
                {
                    Title = "f(x)",
                    Color = OxyColor.FromRgb(0, 0, 255) // Синий цвет линии
                };

                Function = new Function("f(x) = " + txtBoxFunction.Text);

                int lowIndex = Convert.ToInt32(functionLimit);
                int upIndex = Convert.ToInt32(upFunctionLimit);
                for (int counterI = -lowIndex; counterI <= upIndex; ++counterI)
                {
                    expression = new Expression($"f({counterI})", Function);
                    expression.setArgumentValue("x", counterI);
                    double y = expression.calculate();
                    if (y == 0)
                    {
                        xIntercept = counterI;
                    }
                    dot.Add(new DataPoint(counterI, y));
                }

                // Добавляем все точки в серию
                lineSeries.Points.AddRange(dot);

                // Добавляем серию точек к модели графика
                plotModel.Series.Add(lineSeries);
                plotModel.Series.Add(ordinate);
                plotModel.Series.Add(absicc);


                this.pvGraph.Model = plotModel;
            }
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            if (ValidateText())
            {
                StartDichotomy(sender, e);
            }
        }
    }
}
