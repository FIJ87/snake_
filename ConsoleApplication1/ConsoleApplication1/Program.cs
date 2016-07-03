using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point( 1, 3, '*');
            p1.Draw();

            Point p2 = new Point( 4, 5, '#');
            p2.Draw();

            Point p3 = new Point(7, 8, '&');

            Point p4 = new Point(6, 9, '=');

            horizontline line = new horizontline(5,10,8, '+');
            line.Drow();
            Verticalline line2 = new Verticalline(10, 20, 7, '$');
            line2.Drow();
            Console.ReadLine();
        }
       
    }
    
}
