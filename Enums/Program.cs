using System;

namespace Enums
{
    class Program
    {
        static void Main(string[] args)
        {
            var day = (DAY.SATURDAY | DAY.SUNDAY);
            if (day.HasFlag(DAY.WEEKEND))
            {
                Console.WriteLine("enjoy your weekend");
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
        NONE     = 0b_0000_0000,//0
        MONDAY   = 0b_0000_0001,//1
        TUESDAYM = 0b_0000_0010,//2
        WHENSDAY = 0b_0000_0100,//4
        THURSDAY = 0b_0000_1000,//8
        FRAIDAY  = 0b_0001_0000,//16
        SATURDAY = 0b_0010_0000,//32
        SUNDAY   = 0b_0100_0000,//64
        BUSNISDAY   = MONDAY | TUESDAYM | WHENSDAY | THURSDAY | FRAIDAY ,
        WEEKEND  = SATURDAY | SUNDAY// 0b_0010_0000 + 0b_0100_0000 = 0b_0110_0000

    }
}
