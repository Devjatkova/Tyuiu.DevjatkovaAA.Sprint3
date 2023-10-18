using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.DevjatkovaAA.Sprint3.Task3.V16.Lib;

namespace Tyuiu.DevjatkovaAA.Sprint3.Task3.V16
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
            Console.WriteLine("* Тема: Оператор цикла foreach.                                           *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнила: Девяткова Анастасия Александровна | АСОиУБ-23-3              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, используя цикл foreach, которая подсчитывает        *");
            Console.WriteLine("* количество букв с в строке ice nice ice creamcc                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string value = "ice nice ice creamcc";
            char chr = 'c';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Искомый символ = " + chr);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.GetCharCount(value, chr);

            Console.WriteLine("Количество символов "+ chr +" в строке = "+ res);

            Console.ReadKey();
        }
    }
}
