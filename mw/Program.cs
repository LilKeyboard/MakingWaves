using System;

namespace mw
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1;
            d1 = DateTime.Parse(Console.ReadLine());

            DateTime d2;
            d2 = DateTime.Parse(Console.ReadLine());


            if (d1.Month == d2.Month && d1.Year == d2.Year)
            {
                Console.WriteLine(d1.Day.ToString("00") + " - " + d2.ToString("d"));
            }

            else if (d1.Year == d2.Year)
            {
                Console.WriteLine(d1.Date.ToString("dd.MM") + " - " + d2.ToString("d"));
            }

            else if(d1.Month == d2.Month)
            {
                Console.WriteLine(d1.ToString("d") + " - " + d2.ToString("d"));
                Console.WriteLine("Tylko ten sam miesiac");
            }


            Console.ReadKey();
        }
    }
}
