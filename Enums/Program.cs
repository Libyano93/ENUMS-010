using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = "FEB1";
            if (Enum.TryParse(day, out Month month))
            {
                Console.WriteLine(month);
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }


            var day1 = 2;
            if (Enum.IsDefined(typeof(Month), day1))
            {
                Console.WriteLine(((Month) day1));
            }
            else
            {
                Console.WriteLine("Invalid Entry");
            }

            Console.ReadKey();
        }
    }

    enum Month //SIMPLE ENUM
    {
        JAN = 1,
        FEB,
        MAR,
        APR,
        MAY,
        JUN,
        JUL,
        AUG,
        SEP,
        OCT,
        NOV,
        DEC
    }

    enum DAY  //FLAGS ENUM
    {
        NONE = 0b_0000_0000,//0
        MONDAY = 0b_0000_0001,//1
        TUESDAYM = 0b_0000_0010,//2
        WHENSDAY = 0b_0000_0100,//4
        THURSDAY = 0b_0000_1000,//8
        FRAIDAY = 0b_0001_0000,//16
        SATURDAY = 0b_0010_0000,//32
        SUNDAY = 0b_0100_0000,//64
        BUSNISDAY = MONDAY | TUESDAYM | WHENSDAY | THURSDAY | FRAIDAY,
        WEEKEND = SATURDAY | SUNDAY// 0b_0010_0000 + 0b_0100_0000 = 0b_0110_0000

    }
}
