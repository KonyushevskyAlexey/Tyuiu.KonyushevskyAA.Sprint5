using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KonyushevskyAA.Sprint5.Task3.V7.Lib;

namespace Tyuiu.KonyushevskyAA.Sprint5.Task3.V7
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Конюшевский А.А | ИИПб-23-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Потоковый метод записи данных в бинарный файл                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #7                                                              *");
            Console.WriteLine("* Выполнил: Конюшевский Алексей Александрович  | ИИПб-23-2                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дано выражение вычислить его значение при x = 2, результат сохранить в  *");
            Console.WriteLine("* бинарный файл OutPutFileTask3.bin и вывести на консоль.                 *");
            Console.WriteLine("* Округлить до трёх знаков после запятой                                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("x = " + x);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(x);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();






        }
    }
}
