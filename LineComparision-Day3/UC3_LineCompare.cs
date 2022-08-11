using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_LineComparision
{
    class UC3_LineCompare    {

        public void LineCompare()
        {
            //line 1 length compute
            Console.WriteLine("please enter x1 &y1 coordinates: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter x1 &y1 coordinates: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            double Line1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            {
                Console.WriteLine("length of line " + Line1);
            }
            //Line 2 length compute
            Console.WriteLine("please enter x3 & y3 coordinates: ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            double y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter x4 & y4 coordinates: ");
            double x4 = Convert.ToDouble(Console.ReadLine());
            double y4 = Convert.ToDouble(Console.ReadLine());

            double Line2 = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            {
                Console.WriteLine("length of line " + Line2);
            }
            if (Line1 == Line2)
            {
                Console.WriteLine("Line1 is Equal to line 2");
            }
            else if (Line1 > Line2)
            {
                Console.WriteLine("line1 is Greater ");
            }
            else 
            {
                Console.WriteLine("Line2 is Greater");
            }
            

        }
    }
}

