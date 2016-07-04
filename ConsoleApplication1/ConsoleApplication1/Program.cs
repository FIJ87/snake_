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

            horizontline upline = new horizontline(0,78,0, '+');
            upline.Drow();
            horizontline downline = new horizontline(0, 78, 24, '+');
            downline.Drow();
            Verticalline leftline = new Verticalline(0, 24, 0, '+');
            leftline.Drow();
            Verticalline rightline = new Verticalline(0, 24, 78, '+');
            rightline.Drow();
            Console.ReadLine();
        }
       
    }
    
}
