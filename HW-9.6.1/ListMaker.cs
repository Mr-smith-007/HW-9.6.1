using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9._6._1
{
    class ListMaker
    {
        public static List<string> NewList()
        {
            List<string> LNames = new List<string>();
            Console.WriteLine("Введите 5 фамилий");
            for (int i = 0; i < 5; i++)
            {
                LNames.Add(Console.ReadLine());
                if (LNames[i].Length < 3)
                    throw new MyException("Введено некорректное значение, фамилия не может быть меньше 3 символов");

            }
            Console.WriteLine();
            return LNames;
        }
    }
}
