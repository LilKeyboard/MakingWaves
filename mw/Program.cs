using System;

namespace Date
{
    class Program
    {
        static void Main(string[] args)
        {
            NewDate Date = new NewDate();

            Date.StartDate = DateTime.Parse(Console.ReadLine());
            Date.EndDate = DateTime.Parse(Console.ReadLine());

            Date.ShowDate();

            Console.ReadKey();
        }
    }
}
