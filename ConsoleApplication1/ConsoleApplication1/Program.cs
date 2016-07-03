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
                     
            /*p1.x = 1;
            p1.y = 3;
            p1.sym = '*';*/
            p1.Draw();

            Point p2 = new Point( 4, 5, '#');
          
            
            /* p2.x = 4;
            p2.y = 5;
            p2.sym = '#';*/
            p2.Draw();

         

            Console.ReadLine();
        }
        public static void Main()
            {
            int x = 1;
            Func1(x);
            Func2(x);
            Func3(x);
                              
            
            }
        public static void Func1(int value)
        {
          
        }
        public static void Func2(int value)
        {
            value = value + 1;
        }
        public static void Func3(int value)
        {
            x = x + 1;
        }

        public static void Main1()
        {
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4,5,'#');
            Move(p1, 10, 10);
            Reset(p2);
        }
        public static void Move(Point p, int dx, int dy)
        {
            p.x = p.x + dx;
            p.y = p.y = dy;
        }
        public static void Reset(Point p)
        {
                       
        }
    }
    
}
