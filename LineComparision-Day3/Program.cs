using System;

namespace LineComparision_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            //Line length compute
            UC1_LineLength line = new UC1_LineLength();
            line.Length();

            //Line Equality compute
            UC2_LineEquality equalLine = new UC2_LineEquality();
            equalLine.Equality();

            //line compare compute
            UC3_LineCompare compare = new UC3_LineCompare();
            compare.LineCompare();
        }
    }
}