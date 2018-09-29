using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_1_L3C1
{
   class Complex_Class
     {
        public double im;
        public double re;
        /// <summary>
        /// Метод сложения комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>

        public Complex_Class Class_Plus(Complex_Class xc)
        {
            Complex_Class yc = new Complex_Class();
            yc.im = im + xc.im;
            yc.re = re + xc.re;
            return yc;
        }
        /// <summary>
        /// Метод вычитания комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex_Class Class_Minus(Complex_Class xc)
        {
            Complex_Class yc = new Complex_Class();
            yc.im = im - xc.im;
            yc.re = re - xc.re;
            return yc;
        }
        /// <summary>
        /// Метод произведения комплексных чисел
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public Complex_Class Class_Multi(Complex_Class xc)
        {
            Complex_Class yc = new Complex_Class();
            yc.im = re * xc.im + im * xc.re;
            yc.re = re * xc.re - im * xc.im;
            return yc;
        }
        public string ToString()
        {
            return re + "+" + im + "i"; 
        }
    
    }
}
