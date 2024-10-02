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
        string returnFunction();
        double lowLimit();
        double upLimit();
        double Interval();
        double firstSide();
        double secondSide();
        double epsilon();
        Expression Expression();

        Function Function();

        bool MinimumOrMaximum();
        void ShowGraph(PlotModel plotModel, Function outputFunction, Expression outputExpression);
        void ShowResult(double input, double errorCheck);

        event EventHandler<EventArgs> StartDichotomy;
        event EventHandler<EventArgs> CreateGraph;
        event EventHandler<EventArgs> StartGoldenRatio;
    }


    // ������. �������� ����� ������ ��������� ���������� �����
    class Model
    {
        public (PlotModel, Function, Expression) CreateGraph(double interval, double downLimitation, double upLimitation, string function)
        {
            Expression expression;
            Function Function;
            double limit = Convert.ToDouble(interval);
            double functionLimit = Convert.ToDouble(downLimitation);
            double upFunctionLimit = Convert.ToDouble(upLimitation);
            double xIntercept = double.NaN;
            List<DataPoint> dot = new List<DataPoint>();

            var plotModel = new PlotModel { Title = "������ ������� f(x)" };


            var dataPoints = new List<double> { 0 };


            var absicc = new LineSeries
            {
                Title = "�������",
                Color = OxyColor.FromRgb(255, 0, 0), // ������� ����
                StrokeThickness = 2
            };

            absicc.Points.Add(new DataPoint(-limit, 0));
            absicc.Points.Add(new DataPoint(limit, 0));

            var ordinate = new LineSeries
            {
                Title = "�������",
                Color = OxyColor.FromRgb(255, 0, 0), // ������� ����
                StrokeThickness = 2,
            };

            ordinate.Points.Add(new DataPoint(0, limit));
            ordinate.Points.Add(new DataPoint(0, -limit));

            // ������� ����� ����� �������
            var lineSeries = new LineSeries
            {
                Title = "f(x)",
                Color = OxyColor.FromRgb(0, 0, 255) // ����� ���� �����
            };

            Function = new Function("f(x) = " + function);

            expression = new Expression($"f({1})", Function);
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

            // ��������� ��� ����� � �����
            lineSeries.Points.AddRange(dot);

            // ��������� ����� ����� � ������ �������
            plotModel.Series.Add(lineSeries);
            plotModel.Series.Add(ordinate);
            plotModel.Series.Add(absicc);

            return (plotModel, Function, expression);
        }
        public (double, double) Dichotomy(Function inputFunction, Expression inputExpression, double leftLimitation, double rightLimitation, double epsilon)
        {
            double result = double.NaN;
            double currentResult = 0;
            double errorCheck = 0;


            double firstValue = SolveFunc(inputFunction, leftLimitation.ToString().Replace(",", "."));

            double secondValue = SolveFunc(inputFunction, rightLimitation.ToString().Replace(",", "."));


            while ((rightLimitation - leftLimitation) >= epsilon)
            {
                currentResult = (leftLimitation + rightLimitation) / 2;
                double position = SolveFunc(inputFunction, currentResult.ToString().Replace(",", "."));

                if (Math.Abs(position) == 0) // ������ ������ ������
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

            if (firstValue * secondValue > 0)
            {
                errorCheck = 1;
            }
            else
            {
                errorCheck = 0;
            }

            return (result, errorCheck);
        }

        public (double, double) GoldenRatio(Function inputFunction, string inputExpression, double leftLimitation, double rightLimitation, double epsilon, bool choice = true)
        {
            double result = double.NaN;
            double functionResult = 0;

            if (!choice)
            {
                inputFunction = new Function("f(x) = " + "-" + inputExpression);
            }

            double firstValue = SolveFunc(inputFunction, leftLimitation.ToString().Replace(",", "."));

            double secondValue = SolveFunc(inputFunction, rightLimitation.ToString().Replace(",", "."));

            double goldenRatio = (Math.Sqrt(5) - 1) / 2;

            double xFirst = rightLimitation - goldenRatio * (rightLimitation - leftLimitation);
            double xSecond = leftLimitation + goldenRatio * (rightLimitation - leftLimitation);

            double resultOfXFirst = SolveFunc(inputFunction, xFirst.ToString().Replace(",", "."));
            double resultOfXSecond = SolveFunc(inputFunction, xSecond.ToString().Replace(",", "."));


            while (Math.Abs(rightLimitation - leftLimitation) > epsilon)
            {
                if (resultOfXFirst < resultOfXSecond)
                {
                    rightLimitation = xSecond;
                    xSecond = xFirst;
                    xFirst = rightLimitation - goldenRatio * (rightLimitation - leftLimitation);
                    resultOfXFirst = SolveFunc(inputFunction, xFirst.ToString().Replace(",", "."));
                    resultOfXSecond = SolveFunc(inputFunction, xSecond.ToString().Replace(",", "."));
                }
                else
                {
                    leftLimitation = xFirst;
                    xFirst = xSecond;
                    xSecond = leftLimitation + goldenRatio * (rightLimitation - leftLimitation);
                    resultOfXFirst = SolveFunc(inputFunction, xFirst.ToString().Replace(",", "."));
                    resultOfXSecond = SolveFunc(inputFunction, xSecond.ToString().Replace(",", "."));
                }
            }
            result = (leftLimitation + rightLimitation) / 2;
            functionResult = SolveFunc(inputFunction, result.ToString().Replace(",", "."));

            return (result, functionResult);
        }

        public double SolveFunc(Function function, string x)
        {
            return new org.mariuszgromada.math.mxparser.Expression($"f({x})", function).calculate();
        }
    }

    // ���������. ��������� ������ �� ������, �������� � ���. ������������ �������
    class Presenter
    {
        private IView mainView;
        private Model model;

        public Presenter(IView inputView)
        {
            mainView = inputView;
            model = new Model();
            mainView.StartDichotomy += new EventHandler<EventArgs>(Dichotomy);
            mainView.CreateGraph += new EventHandler<EventArgs>(CreateGraph);
            mainView.StartGoldenRatio += new EventHandler<EventArgs>(GoldenRatio);
        }

        private void Dichotomy(object sender, EventArgs inputEvent)
        {
            var output = model.Dichotomy(mainView.Function(), mainView.Expression(), mainView.firstSide(), mainView.secondSide(), mainView.epsilon());
            mainView.ShowResult(output.Item1, output.Item2);
        }
        private void CreateGraph(object sender, EventArgs inputEvent)
        {
            var output = model.CreateGraph(mainView.Interval(), mainView.lowLimit(), mainView.upLimit(), mainView.returnFunction());
            mainView.ShowGraph(output.Item1, output.Item2, output.Item3);
        }
        private void GoldenRatio(object sender, EventArgs inputEvent)
        {
            var output = model.GoldenRatio(mainView.Function(), mainView.returnFunction(), mainView.firstSide(), mainView.secondSide(), mainView.epsilon(), mainView.MinimumOrMaximum());
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