using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Reflection;
using Flee.PublicTypes;

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
        byte Choice();

        void UpdateGraph(List<double[]> inputArr);
        double iterationCount();
        bool MinimumOrMaximum();
        void ShowGraph(PlotModel plotModel);
        void ShowResult(double input, double errorCheck);

        event EventHandler<EventArgs> StartDichotomy;
        event EventHandler<EventArgs> CreateGraph;
        event EventHandler<EventArgs> StartGoldenRatio;
        event EventHandler<EventArgs> StartNewton;
    }


    // ������. �������� ����� ������ ��������� ���������� �����
    class Model
    {
        public PlotModel CreateGraph(double interval, double downLimitation, double upLimitation, string function)
        {
            double limit = Convert.ToDouble(interval);
            double functionLimit = Convert.ToDouble(downLimitation);
            double upFunctionLimit = Convert.ToDouble(upLimitation);
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

            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));

            int lowIndex = Convert.ToInt32(functionLimit);
            int upIndex = Convert.ToInt32(upFunctionLimit);
            for (double counterI = -lowIndex; counterI <= upIndex; ++counterI)
            {
                context.Variables["x"] = counterI;
                var expression = context.CompileGeneric<double>(function);
                double y = expression.Evaluate();
                lineSeries.Points.Add(new DataPoint(counterI, y));
            }

            // ��������� ��� ����� � �����
            lineSeries.Points.AddRange(dot);

            // ��������� ����� ����� � ������ �������
            plotModel.Series.Add(lineSeries);
            plotModel.Series.Add(ordinate);
            plotModel.Series.Add(absicc);

            return plotModel;
        }

        public (double, double) Dichotomy(string inputFunction, double leftLimitation, double rightLimitation, double epsilon)
        {
            double result = double.NaN;
            double currentResult = 0;
            double errorCheck = 0;
            double first = 0;
            double second = 0;

            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));

            while ((rightLimitation - leftLimitation) >= epsilon)
            {
                currentResult = (leftLimitation + rightLimitation) / 2;
                context.Variables["x"] = currentResult;
                var expression = context.CompileGeneric<double>(inputFunction);
                double position = expression.Evaluate();

                context.Variables["x"] = leftLimitation;
                expression = context.CompileGeneric<double>(inputFunction);
                var leftY = expression.Evaluate();
                first = leftY;

                context.Variables["x"] = rightLimitation;
                expression = context.CompileGeneric<double>(inputFunction);
                var rightY = expression.Evaluate();
                second = rightY;

                if (Math.Abs(position) == 0) // ������ ������ ������
                {
                    result = currentResult;
                    return (result, errorCheck);
                }
                else if (leftY * position < 0) // ������ � ����� �������� ���������
                {
                    rightLimitation = currentResult;
                }
                else // ������ � ������ �������� ���������
                {
                    leftLimitation = currentResult;
                }
            }

            result = currentResult;

            if (first * second > 0)
            {
                errorCheck = 1;
            }
            else
            {
                errorCheck = 0;
            }

            return (result, errorCheck);
        }

        public (double, double) GoldenRatio(string inputExpression, double leftLimitation, double rightLimitation, double epsilon, bool choice = true)
        {
            double result = double.NaN;
            double functionResult = 0;
            double goldenRatio = (Math.Sqrt(5) + 1) / 2;
            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));
            if (!choice)
            {
                inputExpression = "-(" + inputExpression + ")";
            }

            double xFirst = rightLimitation - (rightLimitation - leftLimitation) / goldenRatio;
            double xSecond = leftLimitation + (rightLimitation - leftLimitation) / goldenRatio;
            double resultFirst = 0;
            double resultSecond = 0;


            while (Math.Abs(rightLimitation - leftLimitation) > epsilon)
            {
                context.Variables["x"] = xFirst;
                var expression = context.CompileGeneric<double>(inputExpression);
                resultFirst = expression.Evaluate();

                context.Variables["x"] = xSecond;
                expression = context.CompileGeneric<double>(inputExpression);
                resultSecond = expression.Evaluate();

                if (resultFirst < resultSecond)
                {
                    rightLimitation = xSecond;
                    xSecond = xFirst;
                    xFirst = rightLimitation - (rightLimitation - leftLimitation) / goldenRatio;
                }
                else
                {
                    leftLimitation = xFirst;
                    xFirst = xSecond;
                    xSecond = leftLimitation + (rightLimitation - leftLimitation) / goldenRatio;
                }
            }
            result = (leftLimitation + rightLimitation) / 2;
            context.Variables["x"] = result;
            var resultExpression = context.CompileGeneric<double>(inputExpression);
            functionResult = resultExpression.Evaluate();

            return (result, functionResult);
        }


        public (double, double, List<double[]>) Newton(string inputFunction, double inputApproximation, double epsilon, double step, double iterationCount, byte inputChoice)
        {
            double result = 0;
            double functionResult = 0;
            double current = inputApproximation;
            double next = 0;
            double derivative = 0;
            double secondDerivative = 0;
            byte choice = 1;
            string max;
            List<double[]> array = new List<double[]>();
            double leftDerivative = 0;
            double rightDerivative = 0;
            choice = inputChoice;
            int innerCount = 0;

            var context = new ExpressionContext();
            context.Imports.AddType(typeof(Math));
            context.Variables["x"] = current;
            var expression = context.CompileGeneric<double>(inputFunction);
            for (int iteration = 0; iteration < iterationCount; ++iteration)
            {
                switch (choice)
                {
                    case 1:
                        context.Variables["x"] = current;
                        double function = expression.Evaluate(); //�������� ������� � x
                        derivative = NumericalDerivative(context, expression, current, step); //��������� �����������

                        // �������� �� ����
                        if (Math.Abs(derivative) < 1e-10)
                        {
                            return (double.NaN, double.NaN, array);
                        }
                        next = current - function / derivative;
                        context.Variables["x"] = next;
                        array.Add(new double[] { next, expression.Evaluate() });

                        if (Math.Abs(next - current) < epsilon)
                        {
                            result = next;
                            context.Variables["x"] = result;
                            expression = context.CompileGeneric<double>(inputFunction);
                            functionResult = expression.Evaluate();
                            break;
                        }

                        current = next;
                        ++innerCount;
                        break;
                    case 2:
                        context.Variables["x"] = current;
                        derivative = NumericalDerivative(context, expression, current, step); //��������� �����������
                        secondDerivative = NumericalSecondDerivative(context, expression, current, step);

                        if (Math.Abs(secondDerivative) < 1e-10)
                        {
                            iteration = Convert.ToInt32(iterationCount);
                            return (double.NaN, 0, array);
                        }

                        next = current - derivative / secondDerivative;
                        context.Variables["x"] = next;
                        array.Add(new double[] { next, expression.Evaluate() });
                        leftDerivative = NumericalDerivative(context, expression, current - step, step);
                        rightDerivative = NumericalDerivative(context, expression, current + step, step);

                        if (Math.Abs(derivative) < epsilon && leftDerivative < 0 && rightDerivative > 0)
                        {
                            result = current;
                            context.Variables["x"] = result;
                            expression = context.CompileGeneric<double>(inputFunction);
                            functionResult = expression.Evaluate();
                            break;
                        }
                        else if (Math.Abs(derivative) < epsilon)
                        {
                            return (0, double.NaN, array);
                        }

                        ++innerCount;
                        current = next;


                        break;
                    case 3:
                        context.Variables["x"] = current;
                        derivative = NumericalDerivative(context, expression, current, step); //��������� �����������
                        secondDerivative = NumericalSecondDerivative(context, expression, current, step);

                        if (Math.Abs(secondDerivative) < 1e-10)
                        {
                            iteration = Convert.ToInt32(iterationCount);
                            return (double.NaN, 0, array);
                        }

                        next = current - derivative / secondDerivative;
                        context.Variables["x"] = next;
                        array.Add(new double[] { next, expression.Evaluate() });
                        leftDerivative = NumericalDerivative(context, expression, current - step, step);
                        rightDerivative = NumericalDerivative(context, expression, current + step, step);

                        if (Math.Abs(derivative) < epsilon && leftDerivative > 0 && rightDerivative < 0)
                        {
                            result = current;
                            context.Variables["x"] = result;
                            expression = context.CompileGeneric<double>(inputFunction);
                            functionResult = expression.Evaluate();
                            break;
                        }
                        else if (Math.Abs(derivative) < epsilon)
                        {
                            return (0, double.NaN, array);
                        }

                        ++innerCount;
                        current = next;


                        break;
                    default:
                        break;
                }
                if (innerCount >= iterationCount && (result == 0 && functionResult == 0))
                {
                    return (double.NaN, double.NaN, array);
                }
            }

            return (result, functionResult, array);
        }

        double NumericalDerivative(ExpressionContext context, IGenericExpression<double> expression, double x, double step)
        {
            double h = step;
            context.Variables["x"] = x + h;
            double fxPlusH = expression.Evaluate();
            context.Variables["x"] = x - h;
            double fxMinusH = expression.Evaluate();
            return (fxPlusH - fxMinusH) / (2 * h); //����������� �������� (����� ���������� 1 �����������)
        }

        double NumericalSecondDerivative(ExpressionContext context, IGenericExpression<double> expression, double x, double step)
        {
            double h = step;
            context.Variables["x"] = x + h;
            double fxPlusH = expression.Evaluate();
            context.Variables["x"] = x - h;
            double fxMinusH = expression.Evaluate();
            context.Variables["x"] = x;
            double fxOriginal = expression.Evaluate();
            return (fxPlusH - 2 * fxOriginal + fxMinusH) / (h * h); //����������� �������� (����� ���������� 2 �����������)
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
            mainView.StartNewton += new EventHandler<EventArgs>(Newton);
        }

        private void Newton(object sender, EventArgs inputEvent)
        {
            var output = model.Newton(mainView.returnFunction(), mainView.firstSide(), mainView.epsilon(), mainView.secondSide(), mainView.iterationCount(), mainView.Choice());
            mainView.ShowResult(output.Item1, output.Item2);
            mainView.UpdateGraph(output.Item3);
        }

        private void Dichotomy(object sender, EventArgs inputEvent)
        {
            var output = model.Dichotomy(mainView.returnFunction(), mainView.firstSide(), mainView.secondSide(), mainView.epsilon());
            mainView.ShowResult(output.Item1, output.Item2);
        }
        private void CreateGraph(object sender, EventArgs inputEvent)
        {
            var output = model.CreateGraph(mainView.Interval(), mainView.lowLimit(), mainView.upLimit(), mainView.returnFunction());
            mainView.ShowGraph(output);
        }

        private void GoldenRatio(object sender, EventArgs inputEvent)
        {
            var output = model.GoldenRatio(mainView.returnFunction(), mainView.firstSide(), mainView.secondSide(), mainView.epsilon(), mainView.MinimumOrMaximum());
            mainView.ShowResult(output.Item1, output.Item2);
        }
    }

    internal static class Program
    {
        /// <summary>
        /// ������� ����� ����� ��� ����������.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}