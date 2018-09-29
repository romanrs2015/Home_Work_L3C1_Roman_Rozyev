using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task_2_L3C1
/*а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
     Требуется подсчитать сумму всех нечетных положительных чисел. Сами числа и сумму вывести на экран, используя tryParse;
  б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные. 
     При возникновении ошибки вывести сообщение. Напишите соответствующую функцию;*/
{
    class Program
    {
        static bool Odd(int a)
        {
            return a%2==0;
        }

        static string console_message = "Введите целое число: ";        static int GetValue(string message)
        {
            int a;
            string s;
                 bool flag;
                 do
                 {
                    Console.WriteLine(message);
                    s = Console.ReadLine();
                    flag = int.TryParse(s, out a);
                 }
                 while (!flag);
                 return a;
        }
        static void Main(string[] args)
        {
             int x=1;
             int y=0;
             while (x!=0)
             
             {                
                 x = GetValue(console_message);                
                 Odd(x);

                 if (Odd(x))
                 {
                   
                 }
                 else if (x>0)
                 {
                     y = y + x;
                 }
                 
             }
             Console.WriteLine("Сумма нечетных положительных чисел: "+y);        
             Console.WriteLine("Для выхода из приложение нажмите Enter");
             Console.ReadLine();
        }
     }
}
