using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_1_L3C1 //Task_1_Lesson 3_C# level_1 
{
    /*1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры;
         б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса;*/

   struct Complex
    {
        public double im;
        public double re;
        /// <summary>
        /// Метод сложения комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex Plus(Complex x)
        {
            Complex y;
            y.im = im + x.im;
            y.re = re + x.re;
            return y;
        }
        /// <summary>
        /// Метод вычитания комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex Minus(Complex x)
        {
            Complex y;
            y.im = im - x.im;
            y.re = re - x.re;
            return y;
        }
        /// <summary>
        /// Метод произведения комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex Multi(Complex x)
        {
            Complex y;
            y.im = re * x.im + im * x.re;
            y.re = re * x.re - im * x.im;
            return y;
        }
        public string ToString()
        {
            return re + "+" + im + "i"; 
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Complex_Class complex1c= new Complex_Class();
            complex1c.re = 1;
            complex1c.im = 1;
            Complex_Class complex2c = new Complex_Class();
            complex2c.re = 2;
            complex2c.im = 2;
            Complex_Class result1 = new Complex_Class();
            result1 = complex1c.Class_Plus(complex2c);
            Console.WriteLine(result1.ToString());
            result1 = complex1c.Class_Multi(complex2c);
            Console.WriteLine(result1.ToString());
            result1 = complex1c.Class_Minus(complex2c);
            Console.WriteLine(result1.ToString());
            Console.WriteLine("Проверка:");

            Complex complex1;
            complex1.re = 1;
            complex1.im = 1;
            Complex complex2;
            complex2.re = 2;
            complex2.im = 2;
            Complex result = complex1.Plus(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Multi(complex2);
            Console.WriteLine(result.ToString());
            result = complex1.Minus(complex2);
            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}
