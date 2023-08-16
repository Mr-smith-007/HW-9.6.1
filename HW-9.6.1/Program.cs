using System;




namespace HW_9._6._1
{

    class Programm
    {

        public static void Main(string[] args)
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

            List<string> LNames = new List<string>();
            LNames.Add("Иванов");
            LNames.Add("Сидоров");
            LNames.Add("Петров");
            LNames.Add("Капица");
            LNames.Add("Акимов");


            SortLNames sortLnames = new SortLNames();
            sortLnames.SortEvent += Show;
            try
            {
                SortLNames.ReadSortType();
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.ToString());
            }


        }
        static void Show(int sort);
        {
            switch (sort)
            {
                case 1:
                    {
                        LNames.Sort();
                        foreach (string lname in LNames)
                        {
                            Console.WriteLine(lname);
                        }
                        break;
                    }
                case 2:
    {
        LNames.Sort();
        LNames.Reverse();
        foreach (string lname in LNames)
            Console.WriteLine(lname);
        break;
    }
}
        }

}
}
