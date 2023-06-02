using System;
using System.Linq;
using System.Text.RegularExpressions;
using MathNet.Numerics;
using MathNet.Numerics.LinearAlgebra;
using MathNet.Symbolics;
using Expr = MathNet.Symbolics.SymbolicExpression;
using System.Collections.Generic;
using System.Xml;
using System.Drawing;
using System.Threading;
using MathNet.Numerics.Optimization.ObjectiveFunctions;
using MathNet.Numerics.Integration;

namespace ProyectoPruebas
{
    internal class Program
    {
        #region Columns
        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }
        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }

        static int tableWidth = 110;
        #endregion

        //static List<double> xi = new List<double>() {
        //      -1, 1.5, 3.4, 5, 10};
        //static List<double> ai = new List<double>() {
        //     -2,3,-1,2,0};
        //static List<double> xi = new List<double>() {
        //     -2, -1, 1, 3};
        //static List<double> ai = new List<double>() {
        //    3,1,2,-1};
        static List<double> xi = new List<double>() {
              0, 30000, 60000, 90000, 120000};
        static List<double> ai = new List<double>() {
             9.81,9.7487,9.6879,9.6278,9.5682};
        static void Main(string[] args)
        {
            //  ExtrapolacionRichardson(Expr.Parse("-0.1*x^4-0.15*x^3-0.5*x^2-0.25*x+1.2"), 0.5, 0.5);
            // ExtrapolacionRichardson(Expr.Parse("sin(x^2)"),0.5,0.5);
            //  IntegracionRomberg("ln(4*x^2+4)", -3, 3, 4);
            // IntegracionRomberg("e^(-0.5*x)", 0, 1, 3);
            //Console.WriteLine( ReglaTrapecio("ln(4*x^2+4)", 2,-3, 3));
            // ReglaTrapecio(Expr.Parse("(e^x)/x"), 16, 2, 4);
            //ReglaTrapecio(Expr.Parse("0.2+25*x-200*x^2+675*x^3-900*x^4+400*x^5"), 10, 0, 0.8);
            //ReglaSimpson(Expr.Parse("(1+x^3)^(1/2)"),12,0,1);
            //Console.Clear();
            //PrintLine();
            //PrintRow("i", "Xi", "F(Xi)");
            //PrintLine();
            //PrintRow("", "","" );
            //PrintRow("", "", "");
            //PrintLine();
            //Console.ReadLine();
            // Console.WriteLine(PolinomioLangrage(new List<double>() { 2.4,1.5,2.4,1.8,1.8,2.9,1.2,3,1.2}, new List<double>() { 2.9,2.1,2.3,2.1,1.8,2.7,1.5,2.9,1.5}));

          //  Console.WriteLine("Polinomio lagrange:");
           // Console.WriteLine(PolinomioLangrage(new List<double> { 2.4,1.5,2.5,1.8,1.9,2.9,1.2,3,1.3},new List<double>() { 2.9,2.1,2.3,2.1,1.8,2.7,1.5,2.9,1.5}));
            //Console.WriteLine("Resultado: "+PolinomioLangrage(new List<double> { 2.4, 1.5, 2.5, 1.8, 1.9, 2.9, 1.2, 3, 1.3 }, new List<double>() { 2.9, 2.1, 2.3, 2.1, 1.8, 2.7, 1.5, 2.9, 1.5 }).Evaluate(new Dictionary<string, FloatingPoint> { { "x", 2 } }).RealValue);
            //SplineCubic(xi, ai);

          //  AjusteCurva(new List<double> {-50,-30,0,60,90,110}, new List<double> { 1270,1280,1350,1480,1580,1700 }, 1);
            //AjusteCurva(new List<double> { 1,2,3,4,5,6,7}, new List<double> { 0.5,2.5,2.0,4.0,3,5,6.0,5.5}, 1);

         //   double[] x = { 2.4, 1.5, 2.5, 1.8, 1.9, 2.9, 1.2, 3, 1.3 };
         //   double[] y = { 2.9, 2.1, 2.3, 2.1, 1.8, 2.7, 1.5, 2.9, 1.5 };
         //   double point = 2;

         //   // Calcular el valor interpolado
         //   double interpolatedValue = NewtonInterpolation(x, y, point);
         ////  Console.WriteLine("Valor interpolado: " + interpolatedValue);

         //   // Mostrar la matriz de diferencias divididas
         //   Console.WriteLine("Matriz de diferencias divididas:");
         //   double[,] dividedDifferences = CalculateDividedDifferences(x, y);
         //   int n = x.Length;
         //   for (int i = 0; i < n; i++)
         //   {
         //       for (int j = 0; j < n - i; j++)
         //       {
         //           if (i == 0)
         //           {
         //               Console.ForegroundColor = ConsoleColor.Yellow;
         //               Console.Write(dividedDifferences[i, j] + "     ");
         //           }
         //           else
         //           {
         //               Console.ForegroundColor = ConsoleColor.White;
         //               Console.Write(dividedDifferences[i, j] + "     ");
         //           }
         //       }
         //       Console.WriteLine();
         //   }
         //   Console.ForegroundColor = ConsoleColor.White;
         //   SymbolicExpression polynomial = NewtonInterpolation(x, y);

         //   // Mostrar la fórmula
         //   Console.WriteLine("Fórmula del polinomio interpolante de Newton:");
         //   Console.WriteLine(polynomial.ExponentialSimplify());
         //   Console.WriteLine(polynomial.ExponentialSimplify().Evaluate(new Dictionary<string, FloatingPoint> { { "x", 2 } }).RealValue);

            //double[] x = { -1, 0, 1, 2 };
            //double[] y = { 0.5, 1, 2, 4 };
            //double point = -0.5;

            //// Calcular el valor interpolado
            //double interpolatedValue = NewtonInterpolation(x, y, point);
            //Console.WriteLine("Valor interpolado: " + interpolatedValue);

            //// Mostrar la matriz de diferencias divididas
            //Console.WriteLine("Matriz de diferencias divididas:");
            //double[,] dividedDifferences = CalculateDividedDifferences(x, y);
            //int n = x.Length;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n - i; j++)
            //    {
            //        Console.Write(dividedDifferences[i, j] + "     ");
            //    }
            //    Console.WriteLine();
            //}
            //SymbolicExpression polynomial = NewtonInterpolation(x, y);

            //// Mostrar la fórmula
            //Console.WriteLine("Fórmula del polinomio interpolante de Newton:");
            //Console.WriteLine(polynomial.ExponentialSimplify());
            DerivacionNumericaTaylor(75, new List<double> { 0, 60, 120, 180, 240, 300 }, new List<double> { 0, 0.0824, 0.2747, 0.6502, 1.3851, 3.2229 });
           // Console.WriteLine(Interpolate(150, new List<double> { 0, 60, 120, 180, 240, 300 }, new List<double> { 0, 0.0824, 0.2747, 0.6502, 1.3851, 3.2229 }));
        }

        static void DerivacionNumericaTaylor(double x,List<double> xi, List<double> yi)
        {
            double h = xi[1] - xi[0];
             if( xi.FindIndex(xa => xa == x) ==0)
            {
                double primerValor = -1 * Interpolate(x + (2 * h), xi, yi);
                double segundoValor = 4* Interpolate(x + h, xi, yi);
                double tercerValor = -3*Interpolate(x, xi, yi);
                double totalNumerador = primerValor + segundoValor + tercerValor;
                double denominador = 2 * h;
                double fx = totalNumerador * 1f / denominador * 1f;
                Console.WriteLine($"f'({x})= "+fx);
                    
                primerValor= -1 * Interpolate(x + (3 * h), xi, yi);
                segundoValor= 4 * Interpolate(x + (2* h), xi, yi);
                tercerValor = -5 * Interpolate(x+h, xi, yi);
                double cuartoValor = 2* Interpolate(x, xi, yi);

                totalNumerador = primerValor + segundoValor + tercerValor + cuartoValor;
                denominador =  Math.Pow(h, 2);
                fx = totalNumerador / denominador;
                Console.WriteLine($"f''({x})= "+fx);
            }
            else if(xi.FindIndex(xa=>xa==x)==yi.Count-1)
            {
                double primerValor = 3 * Interpolate(x + h, xi, yi);
                double segundoValor = -4 * Interpolate(x - h, xi, yi);
                double tercerValor =  Interpolate(x-(2*h), xi, yi);
                double totalNumerador = primerValor + segundoValor + tercerValor;
                double denominador = 2 * h;
                double fx = totalNumerador * 1f / denominador * 1f;
                Console.WriteLine($"f'({x})= " + fx);

                primerValor = 2 * Interpolate(x, xi, yi);
                segundoValor = -5 * Interpolate(x -h, xi, yi);
                tercerValor = 4 * Interpolate(x -(2* h), xi, yi);
                double cuartoValor = -1 * Interpolate(x-(3*h), xi, yi);

                totalNumerador = primerValor + segundoValor + tercerValor + cuartoValor;
                denominador = Math.Pow(h, 2);
                fx = totalNumerador / denominador;
                Console.WriteLine($"f''({x})= " + fx);
            }
            else
            {
                double primerValor = -1 * Interpolate(x + (2 * h), xi, yi);
                double segundoValor = 8 * Interpolate(x + h, xi, yi);
                double tercerValor = Interpolate(x - (2 * h), xi, yi);
                double totalNumerador = primerValor + segundoValor + tercerValor;
                double denominador = 12 * h;
                double fx =totalNumerador*1f/denominador*1f;
                Console.WriteLine($"f'({x})= " + fx);

                segundoValor *= 2;
                tercerValor=-30*Interpolate(x,xi, yi);
                double cuartoValor=16*Interpolate(x-h,xi, yi);
                double QuintoValor = -1 * Interpolate((x - (2 * h)), xi, yi);
                totalNumerador = primerValor + segundoValor + tercerValor + cuartoValor + QuintoValor;
                denominador = 12 * Math.Pow(h, 2);
                fx = totalNumerador / denominador;
                Console.WriteLine($"f''({x})= " + fx);
            }
         
        }
        static double Interpolate(double x, List<double> xValues, List<double> yValues)
        {
            int n = xValues.Count;

            if (n != yValues.Count)
            {
                throw new ArgumentException("Las listas de valores x e y deben tener la misma longitud");
            }

            // Encontrar los índices inferior y superior más cercanos en la lista de x
            int index = 0;
            while (index < n && xValues[index] < x)
            {
                index++;
            }

            if (index == 0)
            {
                return yValues[0]; // Si el valor a interpolar es menor que el primer valor en la lista de x, devolver el primer valor de y
            }
            else if (index == n)
            {
                return yValues[n - 1]; // Si el valor a interpolar es mayor que el último valor en la lista de x, devolver el último valor de y
            }
            else
            {
                // Realizar la interpolación lineal entre los puntos (x[index-1], y[index-1]) y (x[index], y[index])
                double x0 = xValues[index - 1];
                double x1 = xValues[index];
                double y0 = yValues[index - 1];
                double y1 = yValues[index];

                return y0 + (x - x0) * (y1 - y0) / (x1 - x0);
            }
        }

        static SymbolicExpression NewtonInterpolation(double[] x, double[] y)
        {
            SymbolicExpression polynomial = 0;
            int n = x.Length;

            for (int i = 0; i < 4; i++)
            {
                SymbolicExpression term = y[i];

                for (int j = 0; j < 4; j++)
                {
                    if (j != i)
                    {
                        
                        term *= (SymbolicExpression.Variable("x") - x[j]) / (x[i] - x[j]);
                    }
                }

                polynomial += term;
            }

            return polynomial;
        }
        static double[,] CalculateDividedDifferences(double[] x, double[] y)
        {
            int n = x.Length;
            double[,] dividedDifferences = new double[n, n];

            // Inicializar la primera columna con los valores de 'y'
            for (int i = 0; i < n; i++)
            {
                dividedDifferences[i, 0] = y[i];
            }

            // Calcular las diferencias divididas
            for (int j = 1; j < n; j++)
            {
                for (int i = 0; i < n - j; i++)
                {
                    dividedDifferences[i, j] = (dividedDifferences[i + 1, j - 1] - dividedDifferences[i, j - 1]) / (x[i + j] - x[i]);
                }
            }

            return dividedDifferences;
        }

        static double NewtonInterpolation(double[] x, double[] y, double point)
        {
            double[,] dividedDifferences = CalculateDividedDifferences(x, y);
            int n = x.Length;

            double result = dividedDifferences[0, 0];
            double term = 1;

            for (int i = 1; i < n; i++)
            {
                term *= (point - x[i - 1]);
                result += dividedDifferences[0, i] * term;
            }

            return result;
        }


        static void AjusteCurva(List<double> xi, List<double> yi, int grado)
        {
            PrintLine();
            PrintRow(NombresColumnas(grado));
            List<List<double>> xiyi = new List<List<double>>();

            List<double> numeros = new List<double>();
            for (int i = 1; i < xi.Count + 1; i++)
            {
                numeros.Add(i * 1f);
            }
            xiyi.Add(numeros);
            xiyi.Add(xi);

            List<string> rowXY = new List<string>();

            for (int i = 2; i <= (grado + grado); i++)
            {
                xiyi.Add(xi.Select(x => Math.Pow(x, i)).ToList());
            }
            xiyi.Add(yi);
            for (int i = 1; i <= grado; i++)
            {
                xiyi.Add(xi.Zip(yi, (x, y) => Math.Pow(x, i) * y).ToList());
            }
            for (int i = 0; i < xi.Count; i++)
            {
                for (int j = 0; j < (grado + grado) + (grado + 2); j++)
                {
                    rowXY.Add(xiyi[j][i].ToString());
                }
                PrintRow(rowXY.ToArray());
                rowXY.Clear();
            }
            PrintLine();

            List<List<double>> matrizList = new List<List<double>>();
            for (int i = 0; i < grado + 1; i++)
            {
                List<double> columns = new List<double>();
                for (int j = i; j < (i + (grado + 1)); j++)
                {
                    if (i == 0 && j == 0)
                    {

                        columns.Add(xi.Count);
                    }
                    else
                    {

                        //Console.WriteLine(xiyi[j].Sum());
                        columns.Add(xiyi[j].Sum());
                    }
                }
                matrizList.Add(columns);


            }
            List<double> igualdad = new List<double>();
            for (int i = (grado + grado + 1); i < xiyi.Count; i++)
            {
                igualdad.Add(xiyi[i].Sum());
            }
            Vector<double> igualdadVector = Vector<double>.Build.DenseOfArray(igualdad.ToArray());

            Matrix<double> nuevaMatriz = Matrix<double>.Build.DenseOfRowArrays(matrizList.Select(x => x.ToArray()).ToArray());

            Vector<double> vectorAi = nuevaMatriz.Solve(igualdadVector);
            //nuevaMatriz.Add(igualdadVector);

            double SumaError = 0;
            PrintLine();
            PrintRow("Error");

            for (int i = 0; i < xi.Count; i++)
            {
                double error = yi[i];
                double errorxi = 0;
                for (int j = 0; j < grado + 1; j++)
                {
                    errorxi += vectorAi[j] * Math.Pow(xi[i], j);
                }
                error = Math.Pow((error - errorxi), 2);
                PrintRow(error.ToString());
                SumaError += error;

            }
            PrintRow("Suma: " + SumaError.ToString());
            PrintLine();
            double y2 = yi.Select(x => Math.Pow(x, 2)).Sum();
            double ypromedio = (yi.Select(x => x).Sum() / yi.Count);
            double st = y2 - (xi.Count * Math.Pow(ypromedio, 2));
            double determinacion = (st - SumaError) / st;
            double errorglobal = Math.Sqrt(determinacion);
            double syx = Math.Sqrt((SumaError / (xi.Count - (grado + 1))));
            double sy = Math.Sqrt(st / (xi.Count - 1));

            PrintLine();
            PrintRow("sr", SumaError.ToString());
            PrintRow("syx", syx.ToString());
            PrintRow("Promedio de Y", ypromedio.ToString());
            PrintRow("st", st.ToString());
            PrintRow("r^2", determinacion.ToString());
            PrintRow("r", errorglobal.ToString());
            PrintLine();
            Expr ecuacion = Expr.Zero;
            for (int i = 0; i < vectorAi.Count; i++)
            {
                if (i == 0)
                {
                    ecuacion = Expr.Parse($"{vectorAi[i]}");
                }
                else
                {
                    ecuacion += Expr.Parse($"{vectorAi[i]}*x^{i}");
                }
            }
            Console.WriteLine($"Ecuación de grado {grado}: " + ecuacion.ExponentialSimplify().ToString());
        }
        static string[] NombresColumnas(int grado)
        {

            List<string> Nombres = new List<string>();
            Nombres.Add("i");
            for (int i = 1; i <= (grado + grado); i++)
            {
                Nombres.Add($"X^{i}");
            }
            Nombres.Add("yi");
            for (int i = 1; i <= grado; i++)
            {


                Nombres.Add($"X^{i}*yi");

            }
            //for (int i = 1; i <= grado; i++)
            //{
            //    Nombres.Add($"X^{i}*Yi");
            //}
            return Nombres.ToArray();
        }
        static void ExtrapolacionRichardson(Expr funcion, double h1, double x)
        {
            Expr derivate = funcion.Differentiate(Expr.Parse("x"));
            Console.WriteLine("Derivada: " + derivate.ToString());
            double valorReal = derivate.Evaluate(new Dictionary<string, FloatingPoint> { { "x", x } }).RealValue;

            Console.WriteLine("Valor real= " + valorReal.ToString());
            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("h1= " + h1.ToString());
                double h2 = (h1 * 1f / 2 * 1f);
                Console.WriteLine("H2= " + h2.ToString());
                double DH1 = (funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", x + h1 } }).RealValue - funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", x - h1 } }).RealValue) / (2 * (h1) * 1f);
                double DH2 = (funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", x + h2 } }).RealValue - funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", x - h2 } }).RealValue) / (2 * (h2) * 1f);
                Console.WriteLine("D(H1)= " + DH1.ToString());
                Console.WriteLine("D(H2)= " + DH2.ToString());
                double DM = ((4 * DH2) / 3) - ((1 * DH1) / 3);
                Console.WriteLine("D= " + DM.ToString());
                double Error = Math.Abs((((valorReal - DM) * 1f / valorReal * 1f) * 100));
                Console.WriteLine("Error= " + Error.ToString());
                if (Error < 1.0)
                {
                    return;
                }
                double valorNuevo = h2 / 2;
                h1 = h2;
                h2 = valorNuevo;

            }
        }
        static void IntegracionRomberg(Expr funcion, double a, double b, int k)
        {
            double n = 1;
            PrintRow("n", "F(Xi)");

            List<Kn> kns = new List<Kn>();
            Kn kn = new Kn();
            kn.knList = new List<double>();
            for (int i = 0; i < k; i++)
            {

                n *= 2;
                PrintRow(n.ToString(), ReglaTrapecio(funcion, Convert.ToInt32(n), a, b).ToString());
                kn.knList.Add(ReglaTrapecio(funcion, Convert.ToInt32(n), a, b));
            }
            kns.Add(kn);
            PrintLine();
            kn = new Kn();

            for (int i = 1; i < k + 1; i++)
            {
                kn.knList = new List<double>();
                PrintRow("i", $"k= {i}");
                for (int j = 0; j < kns[(i - 1)].knList.Count; j++)
                {
                    PrintRow((j + 1).ToString(), kns[(i - 1)].knList[j].ToString());
                }
                PrintLine();
                for (int j = (k - i); j >= 1; j--)
                {
                    double kii = (kns[(i - 1)].knList[kn.knList.Count + 1]);
                    double ki = kns[(i - 1)].knList[kn.knList.Count];
                    double primerValor = Math.Pow(4, (kns.Count + 1) - 1);
                    double primerResultado = (primerValor * kii) / (primerValor - 1);
                    double segundoResultado = (ki * 1f / (primerValor - 1) * 1f);
                    kn.knList.Add(primerResultado - segundoResultado);
                }
                kns.Add(kn);
                kn = new Kn();

            }
        }
        class Kn
        {
            public List<double> knList { get; set; }
        }
        static double ReglaTrapecio(Expr funcion, int n, double a, double b)
        {


            double h = (b * 1f - a * 1f) / n * 1f;

            double Resultado = 0;
            double xi = a;
            for (int i = 1; i < n; i++)
            {

                xi += +h;
                Resultado += funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", xi } }).RealValue.Round(9);


            }
            double fxa = funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", a } }).RealValue.Round(9);
            double fxb = funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", b } }).RealValue.Round(9);
            double ResultadoTotal = (h * (fxa + 2 * Resultado + fxb) / 2).Round(9);

            return ResultadoTotal;
        }

        static void ReglaSimpson(Expr funcion, int n, double a, double b)
        {
            Console.WriteLine($"h=({b}-{a})/{n}");
            double h = (b * 1f - a * 1f) / n * 1f;
            Console.WriteLine("h=" + h);
            PrintLine();
            PrintRow("i", "Xi", "F(Xi)");
            PrintLine();
            double ResultadoImpar = 0;
            double ResultadoPar = 0;
            double xi = a;
            for (int i = 1; i < n; i++)
            {

                xi += +h;

                if (i % 2 == 0)
                    ResultadoPar += funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", xi } }).RealValue.Round(9);
                else
                    ResultadoImpar += funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", xi } }).RealValue.Round(9);
                PrintRow($"{i}", $"{xi}", $"{funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", xi } }).RealValue.Round(9)}");

            }
            PrintLine();
            Console.WriteLine();
            Console.WriteLine("Suma impar: " + ResultadoImpar.Round(9));
            Console.WriteLine("Suma par: " + ResultadoPar.Round(9));
            double fxa = funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", a } }).RealValue.Round(9);
            double fxb = funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", b } }).RealValue.Round(9);
            if (n % 2 == 0)
            {

                Console.WriteLine("\n Regla de simpson con (1/3):");
                double Parte1 = (h.Round(9) / 3).Round(9);
                double parte2 = fxa + 4 * (ResultadoImpar) + (2 * ResultadoPar) + fxb;
                double ResultadoTotal = Parte1 * parte2;
                Console.Write($"({h}/{3})*[{funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", a } }).RealValue.Round(9)}+4*({ResultadoImpar})+2*({ResultadoPar})+({funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", b } }).RealValue.Round(9)})]= ");
                Console.Write(ResultadoTotal.Round(9));
                Console.WriteLine();

            }
            if (n % 3 == 0)
            {

                Console.WriteLine("\n Regla de simpson con (3/8):");
                double Parte1 = ((h.Round(9)) * 3 / 8).Round(9);
                double parte2 = fxa + 3 * (ResultadoImpar) + (2 * ResultadoPar) + fxb;
                double ResultadoTotal = Parte1 * parte2;
                Console.Write($"({h}*{3}/{8})*[{funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", a } }).RealValue.Round(9)}+3*({ResultadoImpar})+2*({ResultadoPar})+({funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", b } }).RealValue.Round(9)})]= ");
                Console.Write(ResultadoTotal.Round(9));

            }
            Expr derivada = funcion.Differentiate(Expr.Parse("x"));
            Console.WriteLine("\n\n Derivadas");

            for (int i = 1; i < 5; i++)
            {

                Console.WriteLine($"\n Derivada {i}: " + "\n" + derivada.ToString());
                derivada = derivada.Differentiate(Expr.Parse("x"));
            }

        }

        static void ReglaTrapecioPasos(Expr funcion, int n, double a, double b)
        {

            Console.WriteLine($"h=({b}-{a})/{n}");
            double h = (b * 1f - a * 1f) / n * 1f;
            Console.WriteLine("h=" + h);
            PrintLine();
            PrintRow("i", "Xi", "F(Xi)");
            PrintLine();
            double Resultado = 0;
            double xi = a;
            for (int i = 1; i < n; i++)
            {

                xi += +h;
                Resultado += funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", xi } }).RealValue.Round(9);
                PrintRow($"{i}", $"{xi}", $"{funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", xi } }).RealValue.Round(9)}");

            }
            PrintLine();
            PrintRow("", "", "Suma: " + Resultado.Round(9).ToString());
            PrintLine();
            Console.Write("La integración de " + funcion.ToString() + $" en {a} hasta {b} es: ");

            double fxa = funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", a } }).RealValue.Round(9);
            double fxb = funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", b } }).RealValue.Round(9);
            double ResultadoTotal = (h * (fxa + 2 * Resultado + fxb) / 2).Round(9);

            Console.WriteLine($"({h}/{2})*[{funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", a } }).RealValue.Round(9)}+2({Resultado})+({funcion.Evaluate(new Dictionary<string, FloatingPoint> { { "x", b } }).RealValue.Round(9)})]=" + ResultadoTotal);

            Expr derivative = funcion.Differentiate(Expr.Parse("x"));
            Console.WriteLine();
            Console.WriteLine("Primera derivada: " + derivative.RationalReduce().ToString());

            derivative = derivative.Differentiate(Expr.Parse("x"));
            Console.WriteLine();
            Console.WriteLine("Segunda derivada: " + derivative);

            PrintLine();
            PrintRow("i", "Xi", "F''(Ei)");
            PrintLine();
            double ResultadoSuma = 0;
            double EI = a;
            for (int i = 1; i < (n + 1); i++)
            {

                EI += h;
                ResultadoSuma += derivative.Evaluate(new Dictionary<string, FloatingPoint> { { "x", EI } }).RealValue.Round(9);
                PrintRow($"{i}", $"{EI}", $"{derivative.Evaluate(new Dictionary<string, FloatingPoint> { { "x", EI } }).RealValue.Round(2)}");
                PrintLine();
            }

            PrintLine();
            PrintRow("", "", "Suma: " + ResultadoSuma.Round(9).ToString());
            PrintLine();
            Console.WriteLine();
            Console.Write("Resultado de Ea");
            Console.WriteLine($"(({b}-{a})^3/12*{n}^2*)*({ResultadoSuma.Round(9)}/{n})= " + ((((Math.Pow((b - a), 3)) / (12 * (Math.Pow(n, 2)))) * ((ResultadoSuma) / (n))) * 100).Round(9) + "%");

        }
        #region SplineCubic
        static void SplineCubic(List<double> xi, List<double> ai)
        {
            List<double> HI = CalcularHI(xi).ToList();
            List<List<dynamic>> dynamic = Ecuaciones(HI, ai);
            List<double[]> coeficientesPrueba = new List<double[]>();
            List<string> NombresCI = new List<string>();

            for (int i = 0; i < xi.Count; i++)
            {
                NombresCI.Add(
                    $"C{i}");
            }
            List<double> igualdades = new List<double>();
            foreach (var list in dynamic)
            {
                coeficientesPrueba.Add(Coeficientes((list[0] as Expr), NombresCI));
                igualdades.Add(list[1]);
            }
            Console.WriteLine("");
            var B = MatrizRecortada(Matrix<double>.Build.DenseOfRowArrays(coeficientesPrueba.ToArray()));
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Sistema de ecuaciones");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(B);
            Console.WriteLine(B.Solve(Vector<double>.Build.DenseOfArray(igualdades.ToArray())));
            List<double> CI = new List<double>();
            CI.Add((double)0);
            CI.AddRange(B.Solve(Vector<double>.Build.DenseOfArray(igualdades.ToArray())));
            CI.Add((double)0);

            List<double> DI = CalcularDI(CI, HI);
            List<double> BI = CalcularBI(ai, HI, CI);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Ecuaciones cubicas");
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var ecuaciones in EcuacionesCubicas(ai, BI, xi, CI, DI))
            {
                Console.Write("f(x)= ");
                Console.WriteLine(ecuaciones.ExponentialSimplify());
               //Console.WriteLine(ecuaciones.Evaluate(new Dictionary<string, FloatingPoint> { { "x", 55000 } }).RealValue);
            }

        }
        static List<Expr> EcuacionesCubicas(List<double> AI, List<double> BI, List<double> XI, List<double> CI, List<double> DI)
        {
            List<Expr> ecuacionesCubicas = new List<Expr>();
            for (int i = 0; i < (XI.Count - 1); i++)
            {
                ecuacionesCubicas.Add($"{AI[i]}+{BI[i]}*(x-{XI[i]})+{CI[i]}*(x-{XI[i]})^2+{DI[i]}*(x-{XI[i]})^3");
            }
            return ecuacionesCubicas;
        }
        static List<double> CalcularBI(List<double> AI, List<double> HI, List<double> CI)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("BI");
            Console.ForegroundColor = ConsoleColor.White;
            List<double> BI = new List<double>();
            for (int i = -0; i < (CI.Count - 1); i++)
            {
                double parte1 = ((AI[i + 1] - AI[i]) / (HI[i]));
                double parte2 = ((HI[i] * ((2 * CI[i]) + CI[i + 1])) / (3));
                Console.WriteLine(parte1 - parte2);
                BI.Add(parte1 - parte2);
            }
            return BI;
        }
        static List<double> CalcularDI(List<double> ci, List<double> hi)
        {
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Di");
            Console.ForegroundColor = ConsoleColor.White;
            List<double> DI = new List<double>();
            for (int i = 0; i < (ci.Count - 1); i++)
            {
                Console.WriteLine(((ci[i + 1] - ci[i]) * 1f / (3 * hi[i]) * 1f).ToString());
                DI.Add((ci[i + 1] - ci[i]) * 1f / (3 * hi[i]) * 1f);

            }
            return DI;
        }
        static Matrix<double> MatrizRecortada(Matrix<double> Matriz)
        {
            List<int> columnasNoNulas = new List<int>();
            for (int j = 0; j < Matriz.ColumnCount; j++)
            {
                bool columnaNoNula = true;
                for (int i = 0; i < Matriz.RowCount; i++)
                {
                    if (Matriz[i, j] != 0)
                    {
                        columnaNoNula = false;
                        break;
                    }
                }
                if (!columnaNoNula)
                {
                    columnasNoNulas.Add(j);
                }
            }
            Matrix<double> nuevaMatriz = Matrix<double>.Build.Dense(Matriz.RowCount, columnasNoNulas.Count);
            for (int i = 0; i < Matriz.RowCount; i++)
            {
                for (int j = 0; j < columnasNoNulas.Count; j++)
                {
                    nuevaMatriz[i, j] = Matriz[i, columnasNoNulas[j]];
                }
            }
            return nuevaMatriz;
        }
        static List<List<dynamic>> Ecuaciones(List<double> hi, List<double> ai)
        {
            List<List<dynamic>> ecuaciones = new List<List<dynamic>>();
            for (int i = 1; i < hi.Count; i++)
            {
                string ecuacion;
                if (i == 1)
                {
                    ecuacion = $"0*C{i - 1}+{2 * (hi[i - 1] + hi[i])}*C{i}+{hi[i]}*C{i + 1}";
                }
                else if (i == (hi.Count - 1))
                {
                    ecuacion = $"{hi[i - 1]}*C{i - 1}+{2 * (hi[i - 1] + hi[i])}*C{i}+0*C{i + 1}";
                }
                else
                {
                    ecuacion = $"{hi[i - 1]}*C{i - 1}+{2 * (hi[i - 1] + hi[i])}*C{i}+{hi[i]}*C{i + 1}";
                }

                string igualdad = $"3*(({ai[i + 1] - ai[i]})/{hi[i]})-(3*({ai[i] - ai[i - 1]})/{hi[i - 1]})";
                Expr igualdadExp = Expr.Parse(igualdad);

                Expr expresion = Expr.Parse(ecuacion);
                ecuaciones.Add(new List<dynamic>()
                {
                    expresion,
                  Convert.ToDouble(igualdadExp.Approximate().ToString())
                });
            }
            return ecuaciones;
        }

        static double[] Coeficientes(Expr ecuacion, List<string> coeficientesEcuaciones)
        {
            List<double> coeficientes = new List<double>();
            foreach (var variables in coeficientesEcuaciones)
            {


                foreach (var coeficiente in ecuacion.Coefficients(SymbolicExpression.Parse(variables.ToString())).Reverse())
                {

                    if (coeficiente.ToString() == ecuacion.ToString())
                    {
                        coeficientes.Add(0);

                    }
                    else
                    {
                        coeficientes.Add(Convert.ToDouble(coeficiente.ToString()));
                    }
                    break;
                }

            }
            return coeficientes.ToArray();

        }
        static double[] CalcularHI(List<double> x)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Hi");
            Console.ForegroundColor = ConsoleColor.White;
            List<double> hi = new List<double>();
            for (int i = 0; i < x.Count; i++)
            {
                if ((i + 1) >= x.Count)
                    break;

                hi.Add(x[i + 1] - x[i]);
                Console.WriteLine((x[i + 1] - x[i]).ToString());
            }
            return hi.ToArray();
        }

        #endregion


        #region PolinomioLangrage
        static Expr PolinomioLangrage(List<double> xi, List<double> y)
        {

            int n = xi.Count;
            Expr resultado = 0;
            Expr x = Expr.Parse("x");

            for (int i = 0; i < n; i++)
            {
                SymbolicExpression termino = SymbolicExpression.One;
                //if (i== 3)
                //{
                //    break;
                //}
                for (int j = 0; j <  n; j++)
                {
                    if (i != j)
                    {
                        termino *= (x - xi[j]) / (xi[i] - xi[j]);
                    }
                    
                }
                Console.WriteLine($"Iteracción {i+1}");
               Console.WriteLine(termino.ExponentialSimplify().ToString());
                resultado += y[i] * termino;
            }
            Console.WriteLine("Polinomio de lagrange: ");
            Console.WriteLine(resultado.ExponentialSimplify());
            return resultado.ExponentialSimplify();
        }
        #endregion
    }




}
