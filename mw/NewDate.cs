using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Date
{
    class NewDate
    {

        [DataType(DataType.Date, ErrorMessage = "Format is incorrect.")]
        public DateTime StartDate { get; set; }

        [DataType(DataType.Date, ErrorMessage = "Format is incorrect.")]
        public DateTime EndDate { get; set; }


        public void ShowDate()
        {
            if (StartDate.Month == EndDate.Month && StartDate.Year == EndDate.Year)
            {
                Console.WriteLine(StartDate.Day.ToString("00") + " - " + EndDate.ToString("d"));
            }

            else if (StartDate.Year == EndDate.Year)
            {
                Console.WriteLine(StartDate.Date.ToString("dd.MM") + " - " + EndDate.ToString("d"));
            }

            else if (StartDate.Month == EndDate.Month)
            {
                Console.WriteLine(StartDate.ToString("d") + " - " + EndDate.ToString("d"));
            }

            else
            {
                Console.WriteLine(StartDate.ToString("d") + " - " + EndDate.ToString("d"));
            }
        }
    }
}
