using System;

namespace lib
{
    public static class Mylib
    {
        public static double linfunc(double a, double b, double c) //Считает линейную функцию
        {
         double res = ((2 * b * b / 6) + 2 * (c * c) - (a * a));
         return res;
        }

        public static double razn_minmax(double x, double y, double z) //Находит минимальное и максимальное значение
        {
        double min, max;
        if ((x * x) > y) min = y;
        else { min = x * x; }
        if (y > z) max = y;
        else { max = z; }
        double p = (min - max) / 2;
        return p;
        }


        public static double MathF1(double x)  // Считает синус от функции
        {
         double f = Math.Sin(x);
         return f;
        }
        public static void MathF11(double xn,double xk) 
        {
            double x, h, f;
            
            h = (xk - xn) / 10;
            for (int i = 0; i <= 10; i++)
            {
                x = xn + i * h;
                f = Math.Sin(x);
                Console.WriteLine("При x = {0}, sin(x) = {1}", x, f);
            }
        }


       
        public static double Fact(int n)
        {
            double f = 1;
            for (int i = 1; i <= 2 * n + 1; i++) //Вычисление факториала (2*n+1)!
            { f = f * i; }
            return f; 
        }




    public static void MassivInput(int m, int[] mas)
    {
            Console.WriteLine("------------------------");

            for (int i = 0; i < m; i++)
        {
            Console.Write("Введите элемент массива mas[{0}] = ", i);
            mas[i] = Convert.ToInt32(Console.ReadLine());
        }
            Console.WriteLine("------------------------");
        }

    public static void MassivOutput(int m,int[] mas)
    {
        for (int i = 0; i < m; i++)
        {
            Console.WriteLine("Элемент массива mas[{0}] = {1}", i, mas[i]);
        }
            Console.WriteLine("------------------------");
    }

    public static void MassivCheck(int m,int[] mas)
    {
        int k = 0;
        for (int i = 0; i < m - 1; i++)
        {
            
            if (mas[i] > mas[i + 1]) { Console.WriteLine("Элемент mas[{0}]>mas[{1}] | {2} > {3}", i, i + 1, mas[i], mas[i+1]); k++; }
                


        }
            Console.WriteLine("------------------------");
            if (k == 0) { Console.WriteLine("Нет элементов, удовлетворяющих условию => k = 0");}
            else { Console.WriteLine("Кол-во элементов удовлетворяющих условию = " + k); }
        
    }










}













}


