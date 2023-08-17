using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_9._6._1
{
    class SortType
    {
        public delegate void SortDelegate(int x);
        public event SortDelegate? SortEvent;

        public void ReadSortType()
        {
            Console.WriteLine("Выберите метод сортировки");
            Console.WriteLine("1 - сортировка от А до Я");
            Console.WriteLine("2 - Сортировка от Я до А");
            int sort = Convert.ToInt32(Console.ReadLine());
            if (sort != 1 && sort != 2) throw new FormatException();
            Sort(sort);
        }

        protected virtual void Sort(int sort)
        {
            SortEvent?.Invoke(sort);
        }
    }
}
