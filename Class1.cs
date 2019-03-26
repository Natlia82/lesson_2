using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Class1
    {
        /// <summary>
        ///  метод ищет мин. число из трех
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        static public void Mainl(int a, int b, int c)
        {
            int min;
            Console.WriteLine("a = {0} b = {1} c = {2}", a, b, c);
            if (a < b)
            {
                min = a;
            }
            else min = b;

            if (min > c)
            {
                min = c;
            }

            Console.WriteLine("мин:  {0}", min);


        }

        /// <summary>
        /// подсчет кол-ва цифр числа n
        /// </summary>
        /// <param name="n"></param>

        static public void Number(string n)
        {
            Console.WriteLine(n + " кол-во цифр = " + n.Length);

        }

        /// <summary>
        /// подсчет суммы всех нечетных положительных 
        /// </summary>
        static public int Typing(int str, int summa)
        {
            int summa1 = str + summa;
            //  Console.WriteLine("Сумма = {0}", summa1);
            return summa;
        }

        /// <summary>
        /// проверка логина и пароля
        /// </summary>
        /// <param name="str"></param>
        /// <param name="summa"></param>
        /// <returns></returns>

        static public Boolean Log(string log, string pas)
        {
            Boolean flag;
              if (log == "root" & pas == "GeekBrains") 
          //  if (log == "1" & pas == "1")
            {
                flag = true;
            }
            else { flag = false; }
            return flag;
        }
    }
}
