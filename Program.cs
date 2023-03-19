using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib;

namespace _1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("The 1.1 lab!");
            Console.WriteLine("17 вариант");
            Console.WriteLine("L=(2b^2/6)+2*(c^2-a^2)");
            Console.WriteLine("Введите a,b,c");
            double a, b, c;
            Console.Write("a=");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c=");
            c = Convert.ToDouble(Console.ReadLine());
            Mylib.linfunc(a, b, c);
            Console.WriteLine("L= " + Mylib.linfunc(a, b, c));
            Console.ReadKey();

            Console.WriteLine("----------------------------");
            Console.WriteLine("The 1.2 lab!");
            Console.WriteLine("17 вариант");
            Console.WriteLine("p=min(x^2,y)-max(y,z)/2");
            double x, y, z;
            Console.WriteLine("Введите x,y,z");
            Console.Write("x= ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y= ");
            y = Convert.ToDouble(Console.ReadLine());
            Console.Write("z= ");
            z = Convert.ToDouble(Console.ReadLine());
            Mylib.razn_minmax(x, y, z);
            Console.WriteLine("p= " + Mylib.razn_minmax(x, y, z));

            Console.WriteLine("----------------------------");
            Console.WriteLine("The 1.3 lab!");
            Console.WriteLine("1 вариант");
            Console.WriteLine("f=sin(x)");
            double xn, xk, h, f;
            Console.WriteLine("Рекомендуемые значения xn = 0, xk = 1");
            Console.Write("xn=");
            xn = double.Parse(Console.ReadLine());
            Console.Write("xk=");
            xk = double.Parse(Console.ReadLine());
            h = (xk - xn) / 10;
            for (int i = 0; i <= 10; i++)
            {
                x = xn + i * h;
                Console.WriteLine("| {0,7:0.00000 } | {1,8:0.00000} |", x, Mylib.MathF1(x));

            }
            Console.ReadKey();
            Console.WriteLine("ряд от 0 до N (-1)^n * x^2n+1/(2n+1)!");
            double S;
            int n, N;
            xk = 1;
            xn = 0.1;
            h = (xk - xn) / 10;
            N = 16;
            for (x = xn; x <= xk; x += h) //Цикл задающий изменение x от xn до xk с шагом h
            {
                
                S = 1;
                
                for (n = 1; n <= N; n++)
                {
                    
                    f=Mylib.Fact(n);

                    S = S + Math.Pow(-1, n) * Math.Pow(x, 2 * n + 1) / f;
                }
      
                Console.WriteLine("| {0,7:0.00000 } | {1,8:0.00000} |", x, S);



            }
            Console.ReadKey();

            Console.WriteLine("----------------------------");
            Console.WriteLine("The 1.4 lab!");
            Console.WriteLine("Найти номера тех элементов массива, которые больше своего правого соседа, и количество таких элементов. ");
            Console.Write("Введите размерность массива n = ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] mas = new int[m];
            Mylib.MassivInput(m, mas);
            Mylib.MassivOutput(m, mas);
            Mylib.MassivCheck(m, mas);
            
        }
    }
}
