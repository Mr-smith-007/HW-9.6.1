using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9._6._1
{
    static class Task1
    {
        internal static void TaskExceptions()
        {
            Exception[] exceptions = new Exception[5];
            exceptions[0] = new MyException("Некорректный возраст");
            exceptions[1] = new DivideByZeroException("Деление на нуль");
            exceptions[2] = new IndexOutOfRangeException("Индекс вне заданных пределов");
            exceptions[3] = new ArgumentOutOfRangeException("Аргумент вне заданных пределов");
            exceptions[4] = new ArgumentNullException("Невозможно занчение null");

            for (int i = 0; i < exceptions.Length; i++)
            {
                try
                {
                    throw exceptions[i];
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }

            }
        }

    }
}
