using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparision_Day3
{
    class UC1_LineLength
    {

        public void Length()
        {
            Console.WriteLine("please enter x1 &y1 coordinates: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter x1 &y1 coordinates: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());




            double FinalResult = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            {
                Console.WriteLine("length of line " + FinalResult);
            }


        }
    }
}
