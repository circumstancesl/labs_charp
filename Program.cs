using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using org.mariuszgromada.math.mxparser;
using dichotomy_method;

namespace dichotomy_method
{
    interface IView
    {
        double Interval();
        double firstSide();
        double secondSide();
        double epsilon();
        Expression Expression();

        Function Function();
        void ShowResult(double input, double errorCheck);

        event EventHandler<EventArgs> StartDichotomy;
    }

    class Model
    {
        public (double, double) Dichotomy(Function inputFunction, Expression inputExpression, double leftLimitation, double rightLimitation, double epsilon)
        {
            double result = 0;
            double currentResult = 0;
            double errorCheck;


            double firstValue = SolveFunc(inputFunction, leftLimitation.ToString().Replace(",", "."));

            double secondValue = SolveFunc(inputFunction, rightLimitation.ToString().Replace(",", "."));

            if (firstValue * secondValue >= 0)
            {
                errorCheck = 1;
                return (result, errorCheck);
            }
            else
            {
                errorCheck = 0;
            }

            while ((rightLimitation - leftLimitation) >= epsilon)
            {
                currentResult = (leftLimitation + rightLimitation) / 2;
                double position = SolveFunc(inputFunction, currentResult.ToString().Replace(",", "."));

                if (position == 0) // ������ ������ ������
                {
                    result = currentResult;
                    return (result, errorCheck);
                }
                else if (firstValue * position < 0) // ������ � ����� �������� ���������
                {
                    rightLimitation = currentResult;
                    secondValue = SolveFunc(inputFunction, rightLimitation.ToString().Replace(",", "."));
                }
                else // ������ � ������ �������� ���������
                {
                    leftLimitation = currentResult;
                    firstValue = SolveFunc(inputFunction, leftLimitation.ToString().Replace(",", "."));
                }
            }
            result = currentResult;

            return (result, errorCheck);
        }

        public double SolveFunc(Function function, string x)
        {
            return new org.mariuszgromada.math.mxparser.Expression($"f({x})", function).calculate();
        }
    }

    class Presenter
    {
        private IView mainView;
        private Model model;

        public Presenter(IView inputView)
        {
            mainView = inputView;
            model = new Model();
            mainView.StartDichotomy += new EventHandler<EventArgs>(Dichotomy);
        }

        private void Dichotomy(object sender, EventArgs inputEvent)
        {
            var output = model.Dichotomy(mainView.Function(), mainView.Expression(), mainView.firstSide(), mainView.secondSide(), mainView.epsilon());
            mainView.ShowResult(output.Item1, output.Item2);
        }
    }

    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}