using System;




namespace HW_9._6._1
{

    class Programm
    {

        public static void Main(string[] args)
        {
            //Начало задания 1

            Task1.TaskExceptions();
            Console.WriteLine();

            //Конец задания 1

            //Начало задания 2

            SortType sortLnames = new SortType();
            sortLnames.SortEvent += ShowList.Show;
            try
            {
                sortLnames.ReadSortType();
            }
            catch (MyException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //Конец задания 2


        }

    }
}

