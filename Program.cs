using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //------1
            int a = 4;
            int b = 8;
            int c = 7;

            Class1.Mainl(a, b, c);
            //----2
            int n = 123454;
            Class1.Number(Convert.ToString(n));
            //----3
            int str;
            int summa = 0;
            do
            {
                Console.WriteLine("Введите число:");
                str = Convert.ToInt32(Console.ReadLine());
                if (str > 0 && str % 2 == 1)
                {
                    summa = Class1.Typing(str, summa);
                }

            } while (str != 0);

            Console.WriteLine("Сумма = {0}", summa);
            //-----4
            Boolean flag = false;
            int i = 0;

            do
            {
                Console.WriteLine("Введите логин:");
                string log = Console.ReadLine();
                Console.WriteLine("Введите пароль:");
                string pas = Console.ReadLine();
                flag = Class1.Log(log, pas);

            } while (i < 4 && !flag);

            if (flag)
            {
                Console.WriteLine("далее........");
            }

            //-------5
            Console.WriteLine("Ваш рост в см.? ");
            string rost = Console.ReadLine();
            Console.WriteLine("Ваш вес? ");
            string ves = Console.ReadLine();
            Console.WriteLine("индекс массы тела: ");
            double ind = Convert.ToDouble(ves) / (Convert.ToDouble(rost) * Convert.ToDouble(rost));

            Console.WriteLine(Convert.ToString(ind));
            if (ind < 18)
            {
                Console.WriteLine("Ваш индекс: " + Convert.ToString(ind) + " это ниже нормы");
            }
            else
            {
                if (ind > 25)
                {
                    Console.WriteLine("Ваш индекс: " + Convert.ToString(ind) + " это выше нормы");
                }

                else Console.WriteLine("Ваш индекс: " + Convert.ToString(ind) + " это норма");

            }


            Console.ReadKey();

        }
    }
}
