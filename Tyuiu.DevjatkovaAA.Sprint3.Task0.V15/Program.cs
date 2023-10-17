using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevjatkovaAA.Sprint3.Task0.V15.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint3.Task0.V15
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнила: Девяткова А. А. | АСОиУБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Оператор цикла for.                                               *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #1                                                              *");
            Console.WriteLine("* Выполнила: Девяткова Анастасия Александровна | АСОиУБ-23-3              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя цикл for, которая вычисляет сумму ряда    *");
            Console.WriteLine("* по формуле:                                                             *");
            Console.WriteLine("*        2                                                                *");
            Console.WriteLine("*  S = (x + i) + 1                                                        *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("* при x = 4                                                               *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double value = 4;
            int startValue = 1;
            int stopValue = 10;

            Console.WriteLine("Переменная х = " + value);
            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetSumSeries(value, startValue, stopValue);

            Console.WriteLine("S = " + res);

            Console.ReadKey();

        }
    }
}
