using System;

namespace projekt_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("podaj imie");
            var name = Console.ReadLine();
            Console.WriteLine("podaj miejsce urodznia");
            var place = Console.ReadLine();
            Console.WriteLine("podaj rok urodznia");
            var YearOfbirth = getyear();
            Console.WriteLine("podaj miesiac urodznia");
            var Monthofbirth = Getmonth();
            Console.WriteLine("podaj dzien urodznia");
            var Dayofbirth = getDay();
            DateTime date1 = new DateTime(YearOfbirth, Monthofbirth, Dayofbirth);
            var age = DateTime.Now.Year - date1.Year;
            if (DateTime.Now.DayOfYear < date1.DayOfYear)
            {
                age = age - 1;
            }

            Console.WriteLine($"Czesc {name} urodziłeś się w {place} i masz {age} lat.");


        }

        private static int getDay()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int day) || day > 31 || day < 1)
                {
                    Console.WriteLine("podałeś nieprawidłowe dane");
                    continue;
                }
                return day;
            }
        }

        private static int Getmonth()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int month) || month > 12 || month < 1)
                {
                    Console.WriteLine("podałeś nieprawidłowe dane");
                    continue;
                }
                return month;
            }
            
            
        }

        private static int getyear()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int year) || year > 2021)
                {
                    Console.WriteLine("podałeś nieprawidłowe dane");
                    continue;
                }
                return year;
            }
            
        }
    }
}
