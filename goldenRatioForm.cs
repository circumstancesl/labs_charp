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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace dichotomy_method
{
    public partial class goldenRatioForm : Form, IView
    {
        private Expression expression;
        private Function Function;
        private bool checkExistence = false;

        public goldenRatioForm()
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

        string IView.returnFunction()
        {
            return txtBoxFunction.Text;
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

        bool IView.MinimumOrMaximum()
        {
            bool choice = true;
            if (rBtnMin.Checked == true)
            {
                return true;
            }
            else if (rBtnMax.Checked == true)
            {
                return false;
            }
            else
            {
                return choice;
            }
        }

        public event EventHandler<EventArgs> StartDichotomy;
        public event EventHandler<EventArgs> CreateGraph;
        public event EventHandler<EventArgs> StartGoldenRatio;


        void IView.ShowGraph(PlotModel plotModel, Function outputFunction, Expression outputExpression)
        {
            this.pvGraph.Model = plotModel;
            expression = outputExpression;
            Function = outputFunction;
            checkExistence = true;
        }
        void IView.ShowResult(double result, double functionResult)
        {
            result = Math.Round(result, Convert.ToInt16(txtBoxLimitation.Text));
            functionResult = Math.Round(functionResult, Convert.ToInt16(txtBoxLimitation.Text));
            if (rBtnMin.Checked)
            {
                MessageBox.Show("Минимум:" + result.ToString() + "\n" + "Значение минимума:" + functionResult.ToString(), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rBtnMax.Checked)
            {
                MessageBox.Show("Максимум:" + result.ToString() + "\n" + "Значение максимума:" + functionResult.ToString(), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Минимум:" + result.ToString() + "\n" + "Значение минимума:" + functionResult.ToString(), "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                CreateGraph(sender, e);
            }
        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {
            if (ValidateText())
            {
                if (checkExistence)
                {
                    StartGoldenRatio(sender, e);
                }
                else
                {
                    MessageBox.Show("Не задана функция и не построен график", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
    }
}
